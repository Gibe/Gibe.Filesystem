using System.IO;
using System.Web;
using System.Xml.Linq;

namespace Gibe.FileSystem
{
	public class FileService : IFileService
	{
		/// <summary>
		/// saves the passed xml file to the passed output path
		/// </summary>
		public virtual void SaveXDocument(XDocument doc, string outputPath)
		{
			doc.Save(outputPath);
		}

		/// <summary>
		/// saves the passed uploaded file to the output path
		/// </summary>
		public virtual void SavePosted(HttpPostedFileBase file, string outputPath)
		{
			file.SaveAs(outputPath);
		}

		/// <summary>
		/// saves a file to the passed output path
		/// </summary>
		public virtual void SaveFileStream(string outputPath, string content, FileMode fileMode)
		{
			if ((fileMode == FileMode.CreateNew) && (FileExists(outputPath))) File.Delete(outputPath);

			using (var stream = new FileStream(outputPath, fileMode))
			{
				var writer = new StreamWriter(stream);
				writer.WriteLine(content);
				writer.Flush();
			}
		}

		/// <summary>
		/// reads all lines from the passed file path
		/// </summary>
		public virtual string[] ReadAllLines(string filePath)
		{
			return File.ReadAllLines(filePath);
		}

		public string ReadAllText(string filePath)
		{
			return File.ReadAllText(filePath);
		}

		/// <summary>
		/// creates a new file, writes the specified string to the file, and then closes the file. If the target file already exists, it is overwritten.
		/// </summary>
		public void WriteAllText(string path, string contents)
		{
			File.WriteAllText(path, contents);
		}

		/// <summary>
		/// checks is the file exists in the passed location
		/// </summary>
		public virtual bool FileExists(string path)
		{
			return File.Exists(path);
		}

		public virtual bool DeleteFile(string path)
		{
			if (!File.Exists(path)) return false;

			File.Delete(path);

			return true;
		}
	}
}