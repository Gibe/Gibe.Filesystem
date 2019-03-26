using Ninject.Modules;

namespace Gibe.FileSystem
{
	public class DefaultNinjectBindingsModule : NinjectModule
	{
		public override void Load()
		{
			Bind<IDirectoryService>().To<DirectoryService>().InSingletonScope();
			Bind<IFileService>().To<FileService>();
#if NETFULL
			Bind<IPaths>().To<Paths>();
#endif
		}
	}
}
