using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace WinFormsApp1.ProgramData
{
	internal class DatabaseControl
	{
		static string path = Directory.GetCurrentDirectory() + "/database.db";
		private string LocalData = $"Data Source={path}";

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

		public void CreateTable()
		{
			using var data = new SQLiteConnection(LocalData);
			data.Open();

			using var cmd = new SQLiteCommand(data);
			cmd.CommandText = $"CREATE TABLE products(id INTEGER, " +
				$"tag TEXT, description TEXT, brand TEXT, price REAL, " +
				$"details TEXT, dateIN TEXT, dateOUT TEXT DEFAULT '00-00-00', " +
				$"sold INTEGER DEFAULT 0, PRIMARY KEY(id));";
			cmd.ExecuteNonQuery();

			data.Close();
		}
	}
}
