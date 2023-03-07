using System;
using System.Data;
using Dapper;

namespace DapperClassExercise
{
	public class DapperDepartmentRepository : IDepartmentRepository
	{
        private readonly IDbConnection _Connection;//this is a feild to store what we feed to the class 

		public DapperDepartmentRepository(IDbConnection connection)//this is the constructor that gets fed a parameters of type IDb
		{
            _Connection = connection;
		}

        public IEnumerable<Department> GetAllDepartments()
        {
            return _Connection.Query<Department>("SELECT * FROM departments;");//this will return all the departments inside of a collection

        }
    }
}

