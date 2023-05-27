namespace MoodAnalyser
{
	class MoodAnalyzer
	{
		public bool AnalyseMood(string s)
		{
			string []arr=s.split(' ');
			foreach(var ele in arr)
			{
				if(ele.LowerCase=="happy")
					return true;
			}
			return false;
		}
	}
}
