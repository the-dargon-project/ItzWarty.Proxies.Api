using System.IO;

namespace ItzWarty.IO {
   public interface IStreamFactory {
      IStream CreateFromStream(Stream stream);

      IFileStream CreateFileStream(string path, FileMode mode = FileMode.Open, FileAccess access = FileAccess.ReadWrite, FileShare share = FileShare.None);

      IMemoryStream CreateMemoryStream();
      IMemoryStream CreateMemoryStream(byte[] buffer);
      IMemoryStream CreateMemoryStream(int capacity);
      IMemoryStream CreateMemoryStream(byte[] buffer, bool writable);
      IMemoryStream CreateMemoryStream(byte[] buffer, int index, int count);
      IMemoryStream CreateMemoryStream(byte[] buffer, int index, int count, bool writable);
   }
}
