namespace MoodAnalyser
{
	class Program
	{
		public static void Main(string[] args)
		{
			try
			{
				Console.Write("Enter mood status: ");
				string mood="";
				mood+=Console.ReadLine();
				MoodAnalyzer person1=new MoodAnalyzer(mood);
				if(person1.AnalyseMood()==true)
					Console.WriteLine("Happy");
				else
					Console.WriteLine("Sad");
			}
			catch(FormatException)
			{
				Console.WriteLine("You have to enter a string");
			}
			catch(Exception exp2)
			{
				Console.WriteLine(exp2.Message);
			}
		}

	}
}

