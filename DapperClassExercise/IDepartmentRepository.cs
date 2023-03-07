using System;

namespace DapperClassExercise
{
	public interface IDepartmentRepository
	{
		IEnumerable<Department> GetAllDepartments();
	}
}

