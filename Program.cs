namespace MoodAnalyser
{
	class Program
	{
		public static void Main(string[] args)
		{
			MoodAnalyzer person1=new MoodAnalyzer("I am in sad mood");
			if(person1.AnalyseMood()==true)
				Console.WriteLine("Happy");
			else
				Console.WriteLine("Sad");
		}
	}
}

