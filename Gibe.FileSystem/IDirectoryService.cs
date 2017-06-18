namespace Gibe.FileSystem
{
	public interface IDirectoryService
	{
		/// <summary>
		/// checks the passed path exists
		/// </summary>
		bool Exists(string path);

		/// <summary>
		/// checks the passed path exists with an option to create if it doesn't
		/// </summary>
		bool Exists(string path, bool create);

		/// <summary>
		/// copies the passed directory and it's sub directories to a destination directory
		/// </summary>
		bool Copy(string origin, string destination);
	}
}