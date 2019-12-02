using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebPage______.Models;

namespace WebPage______.DataLayer
{
	public static class DatabaseVet
	{
		// read
		public static Cats Read()
		{
			string queryString =
	@"SELECT [EmployeeID] as id
	  ,[LastName] as catName
  FROM[Northwind].[dbo].[Employees]
  order by[EmployeeID]";

			return execute(queryString, true);
		}

		// add
		public static void Add(string catName)
		{
			string queryString =
@"insert into [Northwind].[dbo].[Employees]
	(lastName, FirstName)
	values ('" + catName + "', 'xyz')";
// this is a major problem! sql indjection time!
// '); Drop Table [Northwind].[dbo].[Employees] --


			execute(queryString, false);
		}

		// delete
		public static void Delete(int id)
		{
			string queryString =
@"delete from [Northwind].[dbo].[Employees]
	where [EmployeeID] = " + id;

			execute(queryString, false);
		}

		private static Cats execute(string queryString, bool andRead)
		{
			string connectionString = @"Server=localhost\SQLEXPRESS;User Id=open;Password=open;integrated security=false";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				SqlCommand command = new SqlCommand(queryString, connection);
				connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				if (!andRead) return null;
				try
				{
					Cats cats = new Cats();
					cats.IdToName = new Dictionary<int, string>();
					while (reader.Read())
					{
						Console.WriteLine(String.Format("{0}, {1}",
							reader["id"], reader["catName"]));// etc
						cats.IdToName.Add((int)reader["id"], (string)reader["catName"]);
					}
					return cats;
				}
				finally
				{
					reader.Close();
				}
			}
		}
	}
}
