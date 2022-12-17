using System;
using api.DataModels;

namespace api.Repositories
{
	public interface IStudentRepository
	{
		Task<List<Student>> GetStudentsAsync();
	}
}

