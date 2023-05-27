namespace MoodAnalyser
{
	class MoodAnalyzer
	{
		public bool AnalyseMood(string s)
		{
			string []arr=s.Split(' ');
			foreach(var ele in arr)
			{
				if(ele.ToLower()=="sad")
					return false;
			}
			return true;
		}
	}
}
