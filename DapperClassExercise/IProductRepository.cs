using System;
using System.Collections.Generic;
namespace DapperClassExercise
{
	public interface IProductRepository
	{
		IEnumerable<Products> GetAllProducts();

		void CreateProduct(string Name, double price, int CategoryID);
	}
}

