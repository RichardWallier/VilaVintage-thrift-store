using System.Data.SQLite;

namespace ProgramData
{
	class DataControl
	{

		private string LocalData = "Data Source=./ProgramData/database.db";
		public void AddProduct(string tag, string description, string brand, double price, string details, string dateIN)
		{
			using var data = new SQLiteConnection(LocalData);
			data.Open();

			using var cmd = new SQLiteCommand(data);
			cmd.CommandText = $"INSERT INTO products(tag, description, brand, price, details, dateIN) VALUES('{tag}', '{description}', '{brand}', '{price}', '{details}', '{dateIN});";
			cmd.ExecuteNonQuery();

			data.Close();

			Console.WriteLine($"add into products{tag}, {description}, {brand}, {price}, {details}");
		}
	}
}
