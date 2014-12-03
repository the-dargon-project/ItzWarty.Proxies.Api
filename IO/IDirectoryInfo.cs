using System.Collections.Generic;
using System.IO;
using ItzWarty.IO;

namespace ItzWarty.IO
{
   public interface IDirectoryInfo : IFileSystemInfo {
      IDirectoryInfo Root { get; }

      void Create();
      void Delete();
      void Delete(bool recursive);

      IEnumerable<IDirectoryInfo> EnumerateDirectories();
      IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern);
      IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern, SearchOption searchOption);

      IEnumerable<IFileInfo> EnumerateFiles();
      IEnumerable<IFileInfo> EnumerateFiles(string searchPattern);
      IEnumerable<IFileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption);

      IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos();
      IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern);
      IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption);

   }
}
