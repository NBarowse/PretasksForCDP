using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4.2 -	Process different kinds of requests as SELECT, DELETE, UPDATE, INSERT using ADO.NET
//-	Call at least one stored procedure using ADO.NET

namespace DbExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=EPBYMINW7053\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            
            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {            

                // Open the connection in a try/catch block
                try
                {
                    connection.Open();

                    //INSERT
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO dbo.Orders(Freight, ShipCountry) VALUES ( @freight, @shipCountry)", connection);
                    insertCommand.Parameters.AddRange(new SqlParameter[]
                    {
                        new SqlParameter("freight",1),
                        new SqlParameter("shipCountry","France")
                    });
                    insertCommand.ExecuteNonQuery();
                    Console.WriteLine("New values are added to Database Northwind");

                    //SELECT - вывдеем запись на консоль, чтобы убедиться, что значение действительно довбелно в базу
                    SqlCommand selectCommand = new SqlCommand("SELECT OrderID, Freight, ShipCountry FROM dbo.Orders WHERE Freight = @freighValue",connection);
                    selectCommand.Parameters.AddWithValue("@freighValue", 1);
                    SqlDataReader reader = selectCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("\t{0}\t{1}\t{2}",
                            reader[0], reader[1], reader[2]);
                    }
                    reader.Close();
                    Console.ReadKey();

                    //UPDATE
                    SqlCommand updateCommand = new SqlCommand("UPDATE dbo.Orders SET ShipCountry = @newCountry WHERE Freight=@freightValue", connection);
                    updateCommand.Parameters.AddRange(new SqlParameter[]
                    {
                        new SqlParameter("newCountry","Belarus"),
                        new SqlParameter("freightValue",1)
                    });
                    updateCommand.ExecuteNonQuery();
                    Console.WriteLine("Values are updated");

                    //выведем обновленную запись на консоль, чтобы убедиться, что значение обновилось
                    reader = selectCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("\t{0}\t{1}\t{2}",
                            reader[0], reader[1], reader[2]);
                    }
                    reader.Close();
                    Console.ReadKey();

                    //DELETE
                    SqlCommand deleteCommand = new SqlCommand("DELETE FROM dbo.Orders WHERE Freight = @freighValue", connection);
                    deleteCommand.Parameters.AddWithValue("@freighValue", 1);
                    deleteCommand.ExecuteNonQuery();
                    Console.WriteLine("Values are deleted");

                    //выведем на консоль, чтобы убедиться, что данных не будет
                    reader = selectCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("\t{0}\t{1}\t{2}",
                            reader[0], reader[1], reader[2]);
                    }
                    reader.Close();
                    Console.ReadKey();


                    //Call at least one stored procedure 
                    // 1.  create a command object identifying the stored procedure
                    SqlCommand cmd = new SqlCommand("CustOrdersDetail", connection);

                    // 2. set the command object so it knows to execute a stored procedure
                    cmd.CommandType = CommandType.StoredProcedure;

                    // 3. add parameter to command, which will be passed to the stored procedure
                    int orderId = 10248;
                    cmd.Parameters.Add(new SqlParameter("@OrderID", orderId));

                    // execute the command
                    Console.WriteLine("\nCalling stored procedure CustOrdersDetail...");
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        // iterate through results, printing each to console
                        while (rdr.Read())
                        {
                            Console.WriteLine("ProductName: {0,-35} UnitPrice: {1,2} Quantity: {2} Discount: {3} ExtendedPrice: {4} ", 
                                rdr["ProductName"], rdr["UnitPrice"],rdr["Quantity"], rdr["Discount"], rdr["ExtendedPrice"]);
                        }
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }
            
        }
    }
}
