using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALC_MVC.Models
{
    public class SaveUpdate
    {
        
        public void saveContact(Contact obj)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nithu\source\WebSites\alc-MVC\ALC-MVC\ALC-MVC\App_Data\Database1.mdf;Integrated Security=True";
            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                try
                {
                   // obj.contactEmail
                    //string insertData = "insert into Contact(contactName, contactPhone, contactEmail, contactBestDatetoCall,  contactBestTimetoCall, contactApprovalCode, contactMessage )" +
                    //                    " values (@C_Name, @C_Phone, @C_Email, @C_BestDate,@C_BestTime, @C_ApproveCode, @C_message)";
                    //System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(insertData, connection);

                    //command.Parameters.AddWithValue("@C_Name", obj.contactName);
                    //command.Parameters.AddWithValue("@C_Phone", obj.contactPhone);
                    //command.Parameters.AddWithValue("@C_Email", obj.contactEmail);
                    //command.Parameters.AddWithValue("@C_BestDate", obj.contactBestDatetoCall);
                    //command.Parameters.AddWithValue("@C_BestTime", obj.contactBestTimetoCall);
                    //command.Parameters.AddWithValue("@C_ApproveCode", obj.contactApprovalCode);
                    //command.Parameters.AddWithValue("@C_message", obj.contactMessage);
                  
                    connection.Open();

                    string insertData = "insert into Contact(contactName, contactPhone, contactEmail, contactBestDatetoCall,  contactBestTimetoCall, contactApprovalCode, contactMessage )" +
                                     " values ('"+obj.contactName+"'" +
                                     ",'"+ obj.contactPhone + "'" +
                                     ",'" + obj.contactEmail + "'" +
                                     ",'" + obj.contactBestDatetoCall + "'" +
                                     ",'" + obj.contactBestTimetoCall + "'" +
                                     ",'" + obj.contactApprovalCode + "'" +
                                      ",'" + obj.contactMessage + "' )";


                    System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(insertData, connection);

                    int result = command.ExecuteNonQuery();
                    //  MessageBox.Show("Connected to database");
                    //  MessageBox.Show("Data inserted successfully");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed to connect to database due to" + ex.ToString());
                   // MessageBox.Show("Failed to insert data due to" + ex.ToString());
                }

            }
        }



    }
}