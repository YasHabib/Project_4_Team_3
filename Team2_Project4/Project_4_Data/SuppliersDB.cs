using Project_4_Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Project_4_Data
{
    public class SuppliersDB
    {


        public static List<int> GetSupplierIDs()
        {
            List<int> supplierIDs = new List<int>();
            // make empty list of IDs
            int id;

            using (SqlConnection con = TravelExpertConnection.GetConnection())
            {
                string query = "SELECT SupplierId FROM Suppliers";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id = (int)reader["SuppplierId"];
                            supplierIDs.Add(id);
                        }
                    }
                }
            }
            return supplierIDs;
        }

        public static int AddSupplier(Suppliers supplier)
        {
            int supID = 0;
            using (SqlConnection con = TravelExpertConnection.GetConnection())
            {
                string insertStatement = "INSERT INTO Suppliers (SupName, ) "
                    + "OUTPUT inserted.SupplierId " +
                    "Values (SupName)";
                using (SqlCommand cmd = new SqlCommand (insertStatement, con))
                {
                    cmd.Parameters.AddWithValue("@SupName", supplier.SupName);

                    con.Open();
                    supID = (int)cmd.ExecuteScalar();
                }
            }

            return supID;
        } // end of AddSuplier


        public static Suppliers GetSupplier(int supplierId)
        {
            Suppliers supplier = null;
            using (SqlConnection con = TravelExpertConnection.GetConnection())
            {
                string query = "SELECT SupplierId, SupName "        //SupplierId,
                              + "FROM Suppliers "
                            + "WHERE SupplierId = @SupplierId";

                using (SqlCommand cmd = new SqlCommand (query, con))
                {
                    cmd.Parameters.AddWithValue("@SupplierId", supplierId);
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader
                        (CommandBehavior.SingleRow))
                    {
                        if (reader.Read()) // filling up the suppliers
                        {
                            supplier = new Suppliers();
                            supplier.SupplierID = (int)reader["SupplierId"];
                            supplier.SupName = reader["SupName"].ToString();


                        }// end of if object

                    }// end of 3rd using
                    
                    
                    
                }// end of 2nd using

                
            }// end of 1st using
            return supplier;
        }// end of GetSupplier

        public static bool UpdateSuppliers (Suppliers oldSup, Suppliers newSup)
        {
            bool success = false; // if no new supplier
            using (SqlConnection con = TravelExpertConnection.GetConnection())
            {
                string UpdateStatement = "UPDATE SUPPLIERS SET " +
                                           " SupName = @NewSupName " +
                                           " WHERE Suppliersid = @OldSuppliersid " +
                                           " And (SupName = @OldSupName OR " +
                                           " SupName IS NULL AND OldSupName IS NULL)";
                using (SqlCommand cmd = new SqlCommand(UpdateStatement, con))
                {
                    if (newSup.SupName == null)
                    {
                        cmd.Parameters.AddWithValue("@NewSupName", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@NewSupName", (string)oldSup.SupName);
                        cmd.Parameters.AddWithValue("@NewSuuplierID", oldSup.SupplierID);
                    }
                    if (oldSup.SupName == null)
                    {
                        cmd.Parameters.AddWithValue("@OldSupName", DBNull.Value);
                    }
                    else
                        cmd.Parameters.AddWithValue("@OldSupName", (string)oldSup.SupName);

                    con.Open();
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0) success = true;
                } // end of object using object

                return success;
            }// end of connection update Supplier
        }// end of query search

    }

}

/// below came from under the IF statement of GetCustomer... (line 76 ..)

//supplier.SupplierID = (int)reader["SupplierID"];  // could be NULL

//int sup = reader.GetOrdinal("SupplierId");
//if (reader.IsDBNull(sup))
//{
//    supplier.SupName = null;
//}
//else
//supplier.SupName = (string)reader["SupName"];