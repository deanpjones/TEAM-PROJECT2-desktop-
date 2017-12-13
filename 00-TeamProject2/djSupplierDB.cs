using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _00_TeamProject2
{
    //**********************************************************************
    //**********************************************************************

    //DATABASE CLASS (Supplier table)
    //Author: Dean Jones
    //Date: Dec.27, 2016

    //**********************************************************************
    //**********************************************************************
    //TO DO...

    //**********************************************************************
    //**********************************************************************

    class djSupplierDB
    {
        //SQL VARIABLES
        private static SqlConnection conn;
        //SQL Database (connection info)
        private static string connstr = "server=ICTVM-DTHBDVOHH\\SQLEXPRESS;user id=sa;password=sa;Trusted_Connection=yes;database=TravelExperts;connection timeout=20";

        /// <summary>
        /// LOAD SUPPLIERS INFO (from database)
        /// </summary>
        public static List<djSupplier> loadSuppliersInfo(string sortbyTag)
        {
            //string sortbyTag = frmSupplier
            string sql = "SELECT * FROM Suppliers ORDER BY " + sortbyTag + " ASC;";   //SQL query (sort alphabetically)
            //string sql = "SELECT * FROM Suppliers ORDER BY SupName ASC;";   //SQL query (sort alphabetically)

            List<djSupplier> mySupplierList = new List<djSupplier>();       //a new djSupplier list

            try
            {
                //start a new connection to database
                conn = new SqlConnection(connstr);
                conn.Open();
                //query database
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create list with data
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        mySupplierList.Add(new djSupplier(reader.GetInt32(0), reader.GetString(1)));
                    }
                }
            }
            //Catch for back SERVER or DATABASE name
            catch(SqlException ex)
            {
                MessageBox.Show("There was trouble connecting to the database...\n\n" + ex.GetType() + ": " + ex.Message, "SQL EXCEPTION");
            }
            finally
            {
                conn.Close();                      //close database connection                
            }
            return mySupplierList;
        }

        /// <summary>
        /// EDIT SUPPLIER INFO (to database)(sql UPDATE)
        /// </summary>
        public static void editSupplier(int id, string myOldUpdate, string myNewUpdate)
        {
            using (conn = new SqlConnection(connstr))
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                SqlTransaction transaction;

                //sql query to EDIT ROW
                //string sqlUpdate = "UPDATE Suppliers SET SupName='" + myUpdate + "' WHERE SupplierId=" + id +    //"; DROP TABLE Suppliers;       
                string sqlUpdate = "UPDATE Suppliers " +
                    "SET SupName = @MyNewUpdate " +
                    //"WHERE (SupplierId = " + id + ") " +                          //*** need parameter for 'id' as using a textbox...                    
                    "WHERE (SupplierId = @id) " +                                   //update only selected record (SupplierId=#)
                    "AND (SupName = @MyOldUpdate " +                                //update only if record hasn't changed
                    "OR SupName IS NULL AND @MyOldUpdate IS NULL);";
                //Points for parameters
                //set parameter (old update)
                var x = cmd.Parameters.AddWithValue("@MyOldUpdate", myOldUpdate ?? (object)DBNull.Value);
                //set parameter (new update)
                var y = cmd.Parameters.AddWithValue("@MyNewUpdate", myNewUpdate ?? (object)DBNull.Value);
                //set parameter (supplier id)
                var z = cmd.Parameters.AddWithValue("@id", id); //supplier id  (not null)

                //start a local transaction
                transaction = conn.BeginTransaction("UpdateSupplier");

                //assign both CONNECTION and TRANSACTION to cmd object for a local transaction?
                cmd.Connection = conn;
                cmd.Transaction = transaction;

                try
                {
                    //run query
                    cmd.CommandText = sqlUpdate;            //SQL query
                    cmd.ExecuteNonQuery();                  //Execute query

                    //attempt to COMMIT the transaction
                    transaction.Commit();
                    MessageBox.Show("The supplier was UPDATED in the database successfully!", "DATABASE ENTRY UPDATED");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was trouble updating a supplier in the database...\n\n" + ex.GetType() + ": " + ex.Message, "UPDATE SUPPLIER EXCEPTION");

                    //attempt ROLLBACK
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show("There was trouble ROLLBACKing the database...\n\n" + ex2.GetType() + ": " + ex2.Message, "ROLLBACK DATABASE EXCEPTION");
                    }
                }
                //(conn.Close() not required, closes automatically from 'using')
            }
        }

        /// <summary>
        /// REMOVE SUPPLIER INFO (from database)(sql DELETE)
        /// </summary>
        public static void removeSupplier(int id)
        {
            //sql query to DELETE ROW
            string sqlDelete = "DELETE FROM Suppliers WHERE SupplierId = " + id + ";";
            //delete also from (product_suppliers)
            //DELETE FROM Products_Suppliers WHERE SupplierId=123;
            string sqlDelete2 = "DELETE FROM Products_Suppliers WHERE SupplierId = " + id + ";";

            using (conn = new SqlConnection(connstr))
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                //SqlCommand cmd2 = conn.CreateCommand();
                SqlTransaction transaction;
                //SqlTransaction transaction2;

                //start a local transaction
                transaction = conn.BeginTransaction("RemoveSupplier");
                //transaction2 = conn.BeginTransaction("RemoveSupplierFromProdSup");

                //assign both CONNECTION and TRANSACTION to cmd object for a local transaction?
                cmd.Connection = conn;
                //cmd2.Connection = conn;
                cmd.Transaction = transaction;
                //cmd2.Transaction = transaction2;

                try
                {
                    //run query   
                    //*******************************************       
                    //*** need to delete (Product_Supplier) first
                    //cmd2.CommandText = sqlDelete2;          //DELETE (Product_Supplier)         
                    cmd.CommandText = sqlDelete;            //DELETE (Supplier) 

                    //EXECUTE QUERY AND COMMIT
                    cmd.ExecuteNonQuery();
                    transaction.Commit();

                    //if(cmd2.ExecuteNonQuery() != 0 && cmd.ExecuteNonQuery() != 0)
                    //{
                    //attempt to COMMIT the transaction
                    //transaction2.Commit();
                    //transaction.Commit();
                    //}

                    //*******************************************


                    MessageBox.Show("The supplier was REMOVED from the database successfully!", "DATABASE ENTRY REMOVED");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was trouble removing a supplier from the database...\n\n" + ex.GetType() + ": " + ex.Message, "REMOVE SUPPLIER EXCEPTION");

                    //attempt ROLLBACK
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show("There was trouble ROLLBACKing the database...\n\n" + ex2.GetType() + ": " + ex2.Message, "ROLLBACK DATABASE EXCEPTION");
                    }
                }
            }
        }

        /// <summary>
        /// ADD SUPPLIER (to database)(sql INSERT INTO)
        /// </summary>
        public static void addSupplier(int mySupplierId, string mySupplierName)
        {
            using (conn = new SqlConnection(connstr))
            {
                conn.Open();        //NO CLOSE required, the (using) keyword will close it when done with the object (Jolanta)

                SqlCommand cmd = conn.CreateCommand();
                SqlTransaction transaction;

                //build the SQL QUERY from parameters (*** IMPORTANT to add the SINGLE QUOTES (')    
                //string sqlAdd = "INSERT INTO Suppliers (SupplierId, SupName) VALUES(" + mySupplierId + ", '" + mySupplierName + "');";       
                string sqlAdd = "INSERT INTO Suppliers (SupplierId, SupName) VALUES(@SupplierId, @SupName);";
                //INSERT INTO Suppliers (SupplierId, SupName) VALUES(123, 'ALAL');
                cmd.Parameters.AddWithValue("@SupplierId", mySupplierId);
                cmd.Parameters.AddWithValue("@SupName", mySupplierName);

                //start a local transaction
                transaction = conn.BeginTransaction("AddSupplier");

                //assign both CONNECTION and TRANSACTION to cmd object for a local transaction?
                cmd.Connection = conn;
                cmd.Transaction = transaction;

                try
                {
                    //run query
                    cmd.CommandText = sqlAdd;                  //SQL query
                    cmd.ExecuteNonQuery();                  //Execute query

                    //attempt to COMMIT the transaction
                    transaction.Commit();           
                    MessageBox.Show("The supplier was ADDED SUCCESSFULLY to the database!", "DATABASE ENTRY ADDED");
                }
                catch (FormatException ex3)
                {
                    MessageBox.Show("There was a problem with the input format...\n\n" + ex3.GetType() + ": " + ex3.Message, "FORMAT EXCEPTION");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was trouble adding a supplier to the database...\n\n" + ex.GetType() + ": " + ex.Message, "ADD SUPPLIER EXCEPTION");

                    //attempt ROLLBACK
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show("There was trouble ROLLBACKing the database...\n\n" + ex2.GetType() + ": " + ex2.Message, "ROLLBACK DATABASE EXCEPTION");
                    }
                }
            }
        }
    }
}
