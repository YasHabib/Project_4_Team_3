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
                                     "FROM Packages " +
                                     "WHERE PgkName = @Pkgname";
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
            using (SqlConnection con = TravelExpertConnection.GetConnection())
            {
                string updateStatement = "UPDATE Packages " +
                                         "SET PkgName = @NewPkgName, " +
                                         "    PkgDesc = @NewPkgDesc,  " +
                                         "    PkgStartDate = @NewPkgStartDate, " +
                                         "    PkgEndDate = @NewPkgEndDate, " +
                                         "    PkgBasePrice = @NewPkgBasePrice, " +
                                         "    PkgAgencyCommission = @NewPkgAgencyCommission " +
                                         "WHERE PackageId = @OldPackageId " +
                                        "AND PkgName = @OldPkgName " +
                                        "AND PkgDesc = @OldPkgDesc " +
                                        "AND (PkgStartDate = @OldPkgStartDate OR " +                //Nullable
                                        "     PkgStartDate IS NULL AND @OldPkgStartDate IS NULL)" +
                                        "AND (PkgEndDate = @OldPkgEndDate OR" +                     //Nullable
                                        "     PkgStartDate IS NULL AND @OldPkgStartDate IS NULL)" +
                                        "AND PkgBasePrice = @OldPkgBasePrice " +
                                        "AND PkgAgencyCommission = @OldPkgAgencyCommission";
                using (SqlCommand cmd = new SqlCommand(updateStatement, con))
                {
                    //******NEW Packages data*********
                    cmd.Parameters.AddWithValue("@NewPkgName", newPack.PkgName);
                    cmd.Parameters.AddWithValue("@NewPkgDesc", newPack.PkgDesc);
                    //cmd.Parameters.AddWithValue("@NewPkgStartDate", (DateTime)newPack.PkgStartDate);
                    //cmd.Parameters.AddWithValue("@NewPkgEndDate", (DateTime)newPack.PkgEndDate);
                    cmd.Parameters.AddWithValue("@NewPkgBasePrice", newPack.PkgBasePrice);
                    cmd.Parameters.AddWithValue("@NewPkgAgencyCommission", newPack.PkgAgencyCommission);

                    ////description
                    //if (string.IsNullOrEmpty(newPack.PkgDesc))
                    //    cmd.Parameters.AddWithValue("@OldPkgDesc", oldPack.PkgDesc);   //keep the old value 
                    //else
                    //    cmd.Parameters.AddWithValue("@NewPkgDesc", newPack.PkgDesc);

                    //New Start date
                    if (newPack.PkgStartDate == null)
                        cmd.Parameters.AddWithValue("@NewPkgStartDate", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@NewPkgStartDate", (DateTime)newPack.PkgStartDate);
                    //New End date
                    if (newPack.PkgEndDate == null)
                        cmd.Parameters.AddWithValue("@NewPkgEndDate", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@NewPkgEndDate", (DateTime)newPack.PkgEndDate);
                    //Agency commission
                    //if (newPack.PkgAgencyCommission == null)
                    //    cmd.Parameters.AddWithValue("@NewPkgAgencyCommission", DBNull.Value);
                    //else
                    //    cmd.Parameters.AddWithValue("@NewPkgAgencyCommission", newPack.PkgAgencyCommission);


                    //******OLD Packages data*********
                    cmd.Parameters.AddWithValue("@OldPackageId", oldPack.PackgeId);
                    cmd.Parameters.AddWithValue("@OldPkgName", oldPack.PkgName);
                    cmd.Parameters.AddWithValue("@OldPkgDesc", oldPack.PkgDesc);
                    //New Start date
                    if (newPack.PkgStartDate == null)
                        cmd.Parameters.AddWithValue("@OldPkgStartDate", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@OldPkgStartDate", (DateTime)oldPack.PkgStartDate);
                    //New End date
                    if (newPack.PkgEndDate == null)
                        cmd.Parameters.AddWithValue("@OldPkgEndDate", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@OldPkgEndDate", (DateTime)oldPack.PkgEndDate);

                    //cmd.Parameters.AddWithValue("@OldPkgStartDate", (DateTime)oldPack.PkgStartDate);
                    //cmd.Parameters.AddWithValue("@OldPkgEndDate", (DateTime)oldPack.PkgEndDate);
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
                }//2nd using
            }//1st "using"

        }//End of Update

        //Add package
        //public static int AddPackage(Packages pack)
        //{
        //    SqlConnection con = TravelExpertConnection.GetConnection();
        //    string insertStatement = "INSERT INTO Packages " +
        //                                    "(PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission) " +
        //                             "VALUES(@PkgName, @PkgStartDate, @PkgEndDate, @PkgDesc, @PkgBasePrice, @PkgAgencyCommission)";
        //    //navrchar(50)
        //    //    navrchar(50)
        //    SqlCommand cmd = new SqlCommand(insertStatement, con);

        //      cmd.Parameters.AddWithValue("@PkgName", pack.PkgName);
        //    cmd.Parameters.AddWithValue("@PkgDesc", pack.PkgDesc);
        //    //description
        //    //Start date
        //    if (pack.PkgStartDate == null)
        //        cmd.Parameters.AddWithValue("@PkgStartDate", DBNull.Value);
        //    else
        //        cmd.Parameters.AddWithValue("@PkgStartDate", pack.PkgStartDate);
        //    //End date
        //    if (pack.PkgEndDate == null)
        //        cmd.Parameters.AddWithValue("@PkgEndDate", DBNull.Value);
        //    else
        //        cmd.Parameters.AddWithValue("@PkgEndDate", pack.PkgEndDate);

        //    //cmd.Parameters.AddWithValue("@PkgStartDate", pack.PkgStartDate);
        //    //cmd.Parameters.AddWithValue("@PkgEndDate", pack.PkgEndDate);
        //    cmd.Parameters.AddWithValue("@PkgBasePrice", pack.PkgBasePrice);
        //    cmd.Parameters.AddWithValue("@PkgAgencyCommission", pack.PkgAgencyCommission);

        //    try
        //    {
        //        con.Open();
        //    cmd.ExecuteNonQuery(); // run the insert command //Error here
        //                           //get the generated ID
        //    string selectQuery = "SELECT IDENT_CURRENT('PackageId') FROM Packages";
        //        SqlCommand selectCmd = new SqlCommand(selectQuery, con);
        //        int pkId = Convert.ToInt32(selectCmd.ExecuteScalar()); // single value

        //        return pkId;
        //}
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}//End of add

        public static int AddPackage(Packages pack)
        {
            int pkId = 0;
            using (SqlConnection con = TravelExpertConnection.GetConnection())
            {
                string insertStatement = "INSERT INTO Packages " +
                                         "(PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission) " +
                                         "OUTPUT inserted.PackageId " + // output auto-generated ID
                                         "VALUES(@PkgName, @PkgStartDate, @PkgEndDate, @PkgDesc, @PkgBasePrice, @PkgAgencyCommission)";
                using (SqlCommand cmd = new SqlCommand(insertStatement, con))
                {
                    cmd.Parameters.AddWithValue("@PkgName", pack.PkgName);
                    cmd.Parameters.AddWithValue("@PkgDesc", pack.PkgDesc);
                    //description

                    //Start date
                    if (pack.PkgStartDate == null)
                        cmd.Parameters.AddWithValue("@PkgStartDate", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@PkgStartDate", pack.PkgStartDate);
                    //End date
                    if (pack.PkgEndDate == null)
                        cmd.Parameters.AddWithValue("@PkgEndDate", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@PkgEndDate", pack.PkgEndDate);

                    //cmd.Parameters.AddWithValue("@PkgStartDate", pack.PkgStartDate);
                    //cmd.Parameters.AddWithValue("@PkgEndDate", pack.PkgEndDate);
                    cmd.Parameters.AddWithValue("@PkgBasePrice", pack.PkgBasePrice);
                    cmd.Parameters.AddWithValue("@PkgAgencyCommission", pack.PkgAgencyCommission);


                    con.Open();
                    pkId = (int)cmd.ExecuteScalar();
                }//2nd using
            }//1st using
            return pkId;
        } // end AddCustomer
    }//End of PackageDB
}//End of Namespace
