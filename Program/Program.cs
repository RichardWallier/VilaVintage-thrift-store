using ProgramData;


namespace DatabaseManipulation
{
	class Program
	{
		public static void Main()
		{
			int selectionInput;
			do
			{
				Console.WriteLine("(1) - add a new product in database");
				Console.WriteLine("which operation want to do ?");
				Console.WriteLine("(2) - att a product of database");
				Console.WriteLine("(3) - list products of database");
				Console.WriteLine("(4) - remove a product of database");
				Console.WriteLine("(0) - close app");
				selectionInput = Convert.ToInt32(Console.ReadLine());
			} while (selectionInput < 0 || selectionInput > 4);

			if (selectionInput == 1)
			{
				Console.WriteLine("Which tag ?");
				string tag = Convert.ToString(Console.ReadLine());

				Console.WriteLine("Which description ?");
				string description = Convert.ToString(Console.ReadLine());

				Console.WriteLine("Which brand ?");
				string brand = Convert.ToString(Console.ReadLine());

				Console.WriteLine("Which price ?");
				double price = Double.Parse(Console.ReadLine());

				Console.WriteLine("Which details ?");
				string details = Convert.ToString(Console.ReadLine());

				Console.WriteLine("Which date IN ?");
				string dateIN = Convert.ToString(Console.ReadLine());

				DataControl data = new DataControl();
				data.AddProduct(tag, description, brand, price, details, dateIN);
			}
			else if (selectionInput == 2)
			{
				Console.WriteLine("Which tag ?");
				string tag = Convert.ToString(Console.ReadLine());

				Console.WriteLine("Which sold price ?");
				double price = Double.Parse(Console.ReadLine());

				Console.WriteLine("Which dateOUT ?");
				string dateOUT = Convert.ToString(Console.ReadLine());

				DataControl data = new DataControl();
				data.SellProduct(tag, price, dateOUT);
			}
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
			else if (selectionInput == 4)
			{
				Console.WriteLine("Which tag to remove ?");
				string tag = Convert.ToString(Console.ReadLine());

				DataControl data = new DataControl();
				data.RemoveProduct(tag);
			}
			else if (selectionInput == 0)
			{
				return;
			}
			Main();
		}
	}
}

