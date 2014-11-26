using System.Collections.Generic;
using System.IO;

namespace ItzWarty.IO
{
   public interface IFileSystemProxy {
      IFileStream CreateFile(string path);
      IFileStream OpenFile(string path, FileMode mode = FileMode.Open, FileAccess access = FileAccess.ReadWrite, FileShare share = FileShare.None);

      IEnumerable<string> EnumerateDirectories(string path);
      IEnumerable<string> EnumerateDirectories(string path, string searchPattern);
      IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption);

      IDirectoryInfo GetDirectoryInfo(string path);
      
      string ReadAllText(string path);
      void WriteAllText(string path, string contents);
      void CopyFile(string sourceFilePath, string destinationFilePath);

      void PrepareDirectory(string path);
      void PrepareParentDirectory(string path);

      void DeleteDirectory(string path, bool recursive = false);
   }
}
