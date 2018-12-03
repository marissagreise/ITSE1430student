/*
 * Marissa Greise
 * ITSE 1430
 * 12/3/2018
 */
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile.Stores.Sql
{
    class SqlProductDatabase : ProductDatabase
    {
        public SqlProductDatabase(string connectionString)
        {
            if (connectionString == null)
                throw new ArgumentNullException(nameof(connectionString));
            if (connectionString == "")
                throw new ArgumentException("Connection String Cannot be empty. "
                                , nameof(connectionString));

            _connectionString = connectionString;
        }
        private readonly string _connectionString;

        protected override Product AddCore( Product product )
        {
            //var conn = new SqlConnection(_connectionString);
            throw new NotImplementedException();
            //Run command
            //try
            //using (var conn = CreateConnection())
            //{
            //    var cmd = new SqlCommand("AddProduct", conn);
            //    cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //    cmd.Parameters.AddWithValue("@name", product.Name);
            //    cmd.Parameters.AddWithValue("@description", product.Description);
            //    cmd.Parameters.AddWithValue("@Price", product.Price);
            //    cmd.Parameters.AddWithValue("@isDiscontinued", product.IsDiscontinued);
               
            //    conn.Open();
            //    var result = cmd.ExecuteScalar();
            //    var id = Convert.ToInt32(result);
            //};
            }

        protected override IEnumerable<Product> GetAllCore()
        {
            throw new NotImplementedException();
        }

        protected override Product GetCore( int id )
        {
            throw new NotImplementedException();
        }

        protected override void RemoveCore( int id )
        {
            throw new NotImplementedException();

            //var product = FindByName(name);
            //if (product == null)
            //    return;

            //using (var conn = CreateConnection())
            //{
            //    var cmd = conn.CreateCommand();
            //    cmd.CommandText = "RemoveMovie";
            //    cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //    var id = GetProductId(product);
            //    cmd.Parameters.AddWithValue("@id", id);

            //    conn.Open();
            //    cmd.ExecuteNonQuery();


            }

        protected override Product UpdateCore( Product existing, Product newItem )
        {
            throw new NotImplementedException();
        }

        private SqlConnection CreateConnection()
               => new SqlConnection(_connectionString);

        protected override Product FindByName( string name )
        {
            throw new NotImplementedException();
        }

        //private object GetProductId (Product product)
        //{
        //    var sql = product as SqlPr
        //}
    }
}
