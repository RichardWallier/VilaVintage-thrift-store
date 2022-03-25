using System.Data.SQLite;
using programCore;

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
			cmd.CommandText = $"INSERT INTO products(tag, description, brand, price, details, dateIN) VALUES('{tag}', '{description}', '{brand}', '{price}', '{details}', '{dateIN}');";
			cmd.ExecuteNonQuery();

			data.Close();

			Console.WriteLine($"add into products{tag}, {description}, {brand}, {price}, {details}");
		}

		public void SellProduct(string tag, double price, string dateOUT)
		{
			using var data = new SQLiteConnection(LocalData);
			data.Open();

			using var cmd = new SQLiteCommand(data);
			cmd.CommandText = $"UPDATE Products SET price = '{price}', dateOUT = '{dateOUT}', sold = 1 WHERE tag = '{tag}';";
			cmd.ExecuteNonQuery();

			data.Close();
			Console.WriteLine($"sold item {tag}, price = {price}, dateOUT = {dateOUT}");
		}

		public void RemoveProduct(string tag)
		{
			using var data = new SQLiteConnection(LocalData);
			data.Open();

			using var cmd = new SQLiteCommand(data);
			cmd.CommandText = $"DELETE FROM Products WHERE tag = '{tag}';";
			cmd.ExecuteNonQuery();

			data.Close();
			Console.WriteLine($"Removed {tag} from products");
		}

		// public void ListAllProduct()
		// {
		// 	using var data = new SQLiteConnection(LocalData);
		// 	data.Open();

		// 	using var cmd = new SQLiteCommand(data);
		// 	cmd.CommandText = "SELECT * FROM Products WHERE 1 = 1";
		// 	using var dataRead = cmd.ExecuteReader();
		// 	while (dataRead.Read())
		// 	{
		// 		string row = dataRead.GetString(0);
		// 		Console.WriteLine(row);
		// 	}

		// 	data.Close();
		// 	Console.WriteLine("selected all from products");
		// }
	}
}
