using System.IO;
using System.Web;
using System.Xml.Linq;
#if NETCORE
using Microsoft.AspNetCore.Http;
#endif

namespace Gibe.FileSystem
{
	public interface IFileService
	{
		/// <summary>
		/// saves the passed xml file to the passed output path
		/// </summary>
		void SaveXDocument(XDocument doc, string outputPath);

#if NETFULL
		/// <summary>
		/// saves the passed uploaded file to the output path
		/// </summary>
		void SavePosted(HttpPostedFileBase file, string outputPath);

#endif
#if NETCORE
		/// <summary>
		/// saves the passed uploaded file to the output path
		/// </summary>
		void SavePosted(IFormFile file, string outputPath);
#endif
		/// <summary>
		/// saves a file to the passed output path
		/// </summary>
		void SaveFileStream(string outputPath, string content, FileMode fileMode);

		/// <summary>
		/// reads all lines from the passed file path
		/// </summary>
		string[] ReadAllLines(string filePath);

		/// <summary>
		/// Read all text from a file
		/// </summary>
		string ReadAllText(string filePath);

		/// <summary>
		/// creates a new file, writes the specified string to the file, and then closes the file. if the target file already exists, it is overwritten
		/// </summary>
		void WriteAllText(string path, string contents);

		/// <summary>
		/// checks is the file exists in the passed location
		/// </summary>
		bool FileExists(string path);
	}
}