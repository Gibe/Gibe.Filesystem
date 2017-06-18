namespace Gibe.FileSystem
{
	public interface IPaths
	{
		string ServerMapPath(string path);
	}

	public class FakePaths : IPaths
	{
		private readonly string _path;
		public FakePaths(string path)
		{
			_path = path;
		}
		public string ServerMapPath(string path)
		{
			return _path;
		}
	}
}