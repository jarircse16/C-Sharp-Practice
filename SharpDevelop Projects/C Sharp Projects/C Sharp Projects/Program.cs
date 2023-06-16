using System;

namespace C_Sharp_Projects
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("I am Jarir and This is my "); //No new lines
			Console.WriteLine("1st Program in C#");
			Console.WriteLine(500); //Message with new line
			
			// TODO: Implement Functionality Here
			
			//string declaration
    		string message = "You are the best";
   			Console.WriteLine(message);
   			
   			int points = 44;
   			Console.WriteLine(points);
   			
   			double weight = 95.4;
   			Console.WriteLine(weight);
   			
   			float height = 1.82f;
   			Console.WriteLine(height);
   			
   			decimal weight1 = 92.8m;
   			Console.WriteLine(weight1);
   			
   			bool x= true;
   			bool y= false;
   			Console.WriteLine(x || y);
   			Console.WriteLine(5+4-3);
   			int xx = 5;
   			int yy = 4;
   			int zz = 3;
   			Console.WriteLine(xx+yy-zz);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			
			
		}
	}
}