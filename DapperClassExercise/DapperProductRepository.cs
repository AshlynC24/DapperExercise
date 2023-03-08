using System;
using System.Data;
using Dapper;

namespace DapperClassExercise
{
	public class DapperProductRepository : IProductRepository
	{
        private readonly IDbConnection _Connection;

		public DapperProductRepository(IDbConnection connection)
		{
            _Connection = connection;
		}

        public void CreateProduct(string Name, double price, int CategoryID)
        {
            _Connection.Execute("INSERT INTO products (Name, Price, CategoryID) VALUES(@name, @price, @categoryID);",
            new { name = Name, price = price, categoryID = CategoryID });
        }

        public IEnumerable<Products> GetAllProducts()
        {
           return _Connection.Query<Products>("SELECT * FROM Products;");
            
        }
    }
}

