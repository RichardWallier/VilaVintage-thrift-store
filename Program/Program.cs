namespace DatabaseManipulation
{
	class Program
	{
		public static void Main()
		{
			// using (var data = new sqliteconnection("local file"));
			Console.WriteLine("which operation want to do ?");
			Console.WriteLine("(1) - add a new product in database");
			Console.WriteLine("(2) - att a product of database");
			Console.WriteLine("(3) - list products of database");
			Console.WriteLine("(4) - remove a product of database");
			int selectionInput = Convert.ToInt32(Console.ReadLine());

			if (selectionInput == 1)
				Console.WriteLine("added new product");
			else if (selectionInput == 2)
				Console.WriteLine("atualizate a product");
			else if (selectionInput == 3)
			{
				Console.WriteLine("You want to list:");
				Console.WriteLine("(1) all products");
				Console.WriteLine("(2) sold products");
				Console.WriteLine("(3) available products");
				int selectionListInput = Convert.ToInt32(Console.ReadLine());
				if (selectionListInput == 1)
					Console.WriteLine("listing all products");
				else if (selectionListInput == 2)
					Console.WriteLine("listing sold products");
				else if (selectionListInput == 3)
					Console.WriteLine("listing available products");
				else if (selectionInput == 2)
					Console.WriteLine("removing product from database");
			}
			Main();
		}
	}
}

