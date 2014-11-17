using System;
using System.IO;

namespace Dargon.IO
{
   public interface IDirectoryInfo
   {
      FileAttributes Attributes { get; set; }
      string FullName { get; }
      string Name { get; }
      bool Exists { get; }
      DateTime CreationTime { get; set; }
      DateTime CreationTimeUtc { get; set; }
      DateTime LastWriteTime { get; set; }
      DateTime LastWriteTimeUtc { get; set; }
   }
}
