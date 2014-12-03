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

      bool Exists(string path);

      IFileInfo GetFileInfo(string path);
      IDirectoryInfo GetDirectoryInfo(string path);
      IFileSystemInfo GetFileSystemInfo(string path);
      
      string ReadAllText(string path);
      void WriteAllText(string path, string contents);
      void CopyFile(string sourceFilePath, string destinationFilePath);

      void PrepareDirectory(string path);
      void PrepareParentDirectory(string path);

      void DeleteFile(string path);
      void DeleteDirectory(string path, bool recursive = false);

      void MoveFile(string source, string destination);
      void MoveDirectory(string source, string destination);
   }
}
