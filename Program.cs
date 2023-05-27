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
				if(mood.Length==0)
					throw new MoodAnalysisException();
				MoodAnalyzer person1=new MoodAnalyzer(mood);
				if(person1.AnalyseMood()==true)
					Console.WriteLine("Happy");
				else
					Console.WriteLine("Sad");
			}
			catch(MoodAnalysisException)
			{
				Console.WriteLine("Empty mood");
			}
			catch(Exception exp2)
			{
				Console.WriteLine(exp2.Message);
			}
		}

	}
}

