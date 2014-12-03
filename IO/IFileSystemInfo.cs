using System;
using System.IO;

namespace ItzWarty.IO {
   public interface IFileSystemInfo {
      string Name { get; }
      string FullName { get; }
      bool Exists { get; }
      FileAttributes Attributes { get; set; }
      DateTime CreationTime { get; set; }
      DateTime CreationTimeUtc { get; set; }
      DateTime LastWriteTime { get; set; }
      DateTime LastWriteTimeUtc { get; set; }
      IDirectoryInfo Parent { get; }
   }
}