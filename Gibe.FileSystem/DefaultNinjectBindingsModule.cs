using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;

namespace Gibe.FileSystem
{
	public class DefaultNinjectBindingsModule : NinjectModule
	{
		public override void Load()
		{
			Bind<IDirectoryService>().To<DirectoryService>().InSingletonScope();
			Bind<IFileService>().To<FileService>();
			Bind<IPaths>().To<Paths>();
		}
	}
}
