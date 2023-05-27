namespace MoodAnalyser
{
	class MoodAnalyzer
	{
		public string phrase="";
		public MoodAnalyzer()
		{

		}
		public MoodAnalyzer(string s)
		{
			this.phrase = s;
		}
		public bool AnalyseMood()
		{
			string []arr=this.phrase.Split(' ');
			foreach(var ele in arr)
			{
				if(ele.ToLower()=="sad")
					return false;
			}
			return true;
		}
	}
}
