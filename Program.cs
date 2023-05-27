namespace MoodAnalyser
{
	class Program
	{
		public static void Main(string[] args)
		{
			MoodAnalyze obj=new MoodAnalyze();
			if(obj.AnalyzeMood("i am Happy")==true)
				Console.WriteLine("Happy");
			else
				Console.WriteLine("Sad");
		}
	}
}

