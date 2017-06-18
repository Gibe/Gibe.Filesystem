using System.IO;

namespace Gibe.FileSystem
{
	public class DirectoryService : IDirectoryService
	{
		/// <summary>
		/// checks the passed path exists
		/// </summary>
		public virtual bool Exists(string path)
		{
			return Directory.Exists(path);
		}

		/// <summary>
		/// checks the passed path exists with an option to create if it doesn't
		/// </summary>
		public virtual bool Exists(string path, bool create)
		{
			if (Exists(path)) return true;

			if (!Exists(path) && (!create)) return false;

			Directory.CreateDirectory(path);
			
			return true;
		}

		/// <summary>
		/// copies the passed directory and it's sub directories to a destination directory
		/// </summary>
		public virtual bool Copy(string origin, string destination)
		{
			var dir = new DirectoryInfo(origin);
			var dirs = dir.GetDirectories();

			if (!dir.Exists) return false;

			Exists(destination, true);

			var files = dir.GetFiles();
			foreach (var file in files)
			{
				var temppath = Path.Combine(destination, file.Name);
				file.CopyTo(temppath, false);
			}

			foreach (var subdir in dirs)
			{
				var temppath = Path.Combine(destination, subdir.Name);
				Copy(subdir.FullName, temppath);
			}

			return true;
		}
	}
}