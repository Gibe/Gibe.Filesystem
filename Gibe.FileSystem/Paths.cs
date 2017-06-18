using System.Web;

namespace Gibe.FileSystem
{
	public class Paths : IPaths
	{
		public string ServerMapPath(string path)
		{
			return HttpContext.Current.Server.MapPath(path);
		}
	}
}