using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4_Data
{
    //Author: Yasin Habib
    public class PackageDB
    {
        //Getting all packages
        public static List<Packages> GetAllPackages()
        {
            List<Packages> packages = new List<Packages>();
            Packages pk = null;
            SqlConnection con = TravelExpertConnection.GetConnection();
            string selectStatement = "SELECT * " +
                                     "FROM Packages " +
                                     "ORDER BY PackageId";

            SqlCommand cmd = new SqlCommand(selectStatement, con);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) // while there is another record
                {
                    pk = new Packages();
                    pk.PackgeId = (int)reader["PackageId"];
                    pk.PkgName = reader["PkgName"].ToString();
                    pk.PkgStartDate = Convert.ToDateTime(reader["PkgStartDate"]); //nullable
                    pk.PkgEndDate = Convert.ToDateTime(reader["PkgEndDate"]); //nullable
                    pk.PkgDesc = reader["PkgDesc"].ToString();
                    pk.PkgBasePrice = (decimal)reader["PkgBasePrice"];
                    pk.PkgAgencyCommission = (decimal)reader["PkgAgencyCommission"];
                    packages.Add(pk);


                    //for null values

                    int dateStart = reader.GetOrdinal("PkgStartDate");
                    int dateEnd = reader.GetOrdinal("PkgEndDate");
                    if (reader.IsDBNull(dateStart) || reader.IsDBNull(dateEnd))
                    {
                        pk.PkgStartDate = null;
                        pk.PkgEndDate = null;
                    }
                    else // it is not null
                    {
                        pk.PkgStartDate = Convert.ToDateTime(reader["PkgStartDate"]);
                        pk.PkgEndDate = Convert.ToDateTime(reader["PkgEndDate"]);
                    }
                }
            }

            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return packages;
        }//End of GetAllPackages

        //Selecting packages by their Name
        public static Packages GetPackagesByName(string name)
        {
            Packages p = null;
            SqlConnection con = TravelExpertConnection.GetConnection();
            string selectStatement = "SELECT CustomerID, Name, Address, City, State, ZipCode " +
                                     "FROM Customers " +
                                     "WHERE Name = @name";
            SqlCommand cmd = new SqlCommand(selectStatement, con);
            cmd.Parameters.AddWithValue("@name", name); // value comes from the method's argument
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read()) // found a customer
                {
                    p = new Packages();
                    p.PkgName = reader["PkgName"].ToString();
                    p.PkgStartDate = Convert.ToDateTime(reader["PkgStartDate"]); //nullable
                    p.PkgEndDate = Convert.ToDateTime(reader["PkgEndDate"]); //nullable
                    p.PkgDesc = reader["PkgDesc"].ToString();
                    p.PkgBasePrice = (decimal)reader["PkgBasePrice"];
                    p.PkgAgencyCommission = (decimal)reader["PkgAgencyCommission"];

                    //for null values
                    int dateStart = reader.GetOrdinal("PkgStartDate");
                    int dateEnd = reader.GetOrdinal("PkgEndDate");
                    if (reader.IsDBNull(dateStart) || reader.IsDBNull(dateEnd))
                    {
                        p.PkgStartDate = null;
                        p.PkgEndDate = null;
                    }
                    else // it is not null
                    {
                        p.PkgStartDate = Convert.ToDateTime(reader["PkgStartDate"]);
                        p.PkgEndDate = Convert.ToDateTime(reader["PkgEndDate"]);
                    }
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return p;
        }//End of GetPackagesByName

        //Update Package
        public static bool UpdatePackage(Packages oldPack, Packages newPack)
        {
            SqlConnection con = TravelExpertConnection.GetConnection();
            string updateStatement = "UPDATE Packages " +
                                     "SET PkgName = @NewPkgName, " +
                                     "    PkgDesc = @NewPkgDesc,  " +
                                     "    PkgStartDate = @NewPkgStartDates, " +
                                     "    PkgEndDate = @NewPkgEndDate, " +
                                     "    PkgBasePrice = @NewPkgBasePrice, " +
                                     "    PkgAgencyCommission = @NewPkgAgencyCommission " +
                                     "WHERE PackageId = @OldPackageId "+
                                    "AND PkgName = @OldPkgName " +
                                    "AND PkgDesc = @OldPkgDesc " +
                                    "AND PkgStartDate = @OldPkgStartDate " +
                                    "AND PkgEndDate = @OldPkgEndDate " +
                                    "AND PkgBasePrice = @OldPkgBasePrice " +
                                    "AND PkgAgencyCommission = @OldPkgAgencyCommission";
            SqlCommand cmd = new SqlCommand(updateStatement, con);
            cmd.Parameters.AddWithValue("@NewPkgName", newPack.PkgName);
            //cmd.Parameters.AddWithValue("@NewPkgStartDates", (DateTime)newPack.PkgStartDate);
            //cmd.Parameters.AddWithValue("@NewPkgEndDate", (DateTime)newPack.PkgEndDate);
            cmd.Parameters.AddWithValue("@NewPkgBasePrice", newPack.PkgBasePrice);
            cmd.Parameters.AddWithValue("@NewPkgAgencyCommission", newPack.PkgAgencyCommission);
            cmd.Parameters.AddWithValue("@OldPackageId", oldPack.PackgeId);

            if (newPack.PkgDesc == null)
               cmd.Parameters.AddWithValue("@OldPkgDesc", oldPack.PkgDesc);    
            else
               cmd.Parameters.AddWithValue("@NewPkgDesc", newPack.PkgDesc);

            if ((newPack.PkgStartDate == null) || (newPack.PkgEndDate == null))
            {
                cmd.Parameters.AddWithValue("@NewPkgStartDates", DBNull.Value);
                cmd.Parameters.AddWithValue("@NewPkgEndDate", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@NewPkgStartDates", (DateTime)newPack.PkgStartDate);
                cmd.Parameters.AddWithValue("@NewPkgEndDate", (DateTime)newPack.PkgEndDate);
            }


            cmd.Parameters.AddWithValue("@OldPkgName", oldPack.PkgName);
            cmd.Parameters.AddWithValue("@OldPkgDesc", oldPack.PkgDesc);
            cmd.Parameters.AddWithValue("@OldPkgStartDate", oldPack.PkgStartDate);
            cmd.Parameters.AddWithValue("@OldPkgEndDate", oldPack.PkgEndDate);
            cmd.Parameters.AddWithValue("@OldPkgBasePrice", oldPack.PkgBasePrice);
            cmd.Parameters.AddWithValue("@OldPkgAgencyCommission", oldPack.PkgAgencyCommission);
            try
            {
                con.Open();
                int count = cmd.ExecuteNonQuery();
                if (count > 0) return true;
                else return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
