using System.IO;

namespace ItzWarty.IO {
   public interface IFileInfo : IFileSystemInfo {
      IFileStream Create();
      IFileStream Open(FileMode fileMode);
      IFileStream Open(FileMode fileMode, FileAccess fileAccess);
      IFileStream Open(FileMode fileMode, FileAccess fileAccess, FileShare fileShare);
   }
}