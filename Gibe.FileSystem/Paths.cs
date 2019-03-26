using System.Web;

#if NETFULL
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
#endif