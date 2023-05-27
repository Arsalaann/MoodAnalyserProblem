namespace MoodAnalyser
{
	class Program
	{
		public static void Main(string[] args)
		{
			MoodAnalyzer obj=new MoodAnalyzer();
			if(obj.AnalyseMood("I am in any Mood")==true)
				Console.WriteLine("Happy");
			else
				Console.WriteLine("Sad");
		}
	}
}

