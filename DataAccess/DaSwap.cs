
namespace DataAccess
{
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using Entities;

    public class DaSwap : DaConnection
    {

        public List<Swap> GetSwaps()
        {
            using (SqlConnection myConnection = new SqlConnection(ConnectionString))
            {
                myConnection.Open();
                using (SqlCommand myCommand = new SqlCommand())
                {
                    myCommand.Connection = myConnection;
                    myCommand.CommandText = "[usp.SWAP.Get]";
                    myCommand.CommandType = CommandType.StoredProcedure;
                    SqlDataReader myDataReader = myCommand.ExecuteReader();

                    List<Swap> swaps = new List<Swap>();
                    while (myDataReader.Read())
                    {
                        Swap swap = new Swap();
                        swap.Id = int.Parse(myDataReader["IdServices"].ToString());
                        swap.Title = myDataReader["Title"].ToString();
                        swap.Description = myDataReader["Description"].ToString();
                        swap.Code = myDataReader["Code"].ToString();
                        swap.Price = decimal.Parse(myDataReader["Price"].ToString());
                        swap.Imageurl = myDataReader["Imageurl"].ToString();
                        swap.IdCategoriaServices = int.Parse(myDataReader["IdCategoriaServices"].ToString());
                        swap.Location = myDataReader["Location"].ToString();
                        swaps.Add(swap);
                        swap = null;
                    }
                    myConnection.Close();
                    return swaps;
                }
            }
        }

    }
}
