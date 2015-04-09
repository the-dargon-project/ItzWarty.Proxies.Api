using System.IO;
using System.Text;

namespace ItzWarty.IO {
   public interface IStreamFactory {
      IStream CreateFromStream(Stream stream);
      IStream CreateFromStream(Stream stream, bool leaveOpen);

      IFileStream CreateFileStream(string path, FileMode mode = FileMode.Open, FileAccess access = FileAccess.ReadWrite, FileShare share = FileShare.None);

      IMemoryStream CreateMemoryStream();
      IMemoryStream CreateMemoryStream(byte[] buffer);
      IMemoryStream CreateMemoryStream(int capacity);
      IMemoryStream CreateMemoryStream(byte[] buffer, bool writable);
      IMemoryStream CreateMemoryStream(byte[] buffer, int index, int count);
      IMemoryStream CreateMemoryStream(byte[] buffer, int index, int count, bool writable);

      IBinaryReader CreateBinaryReader(IStream stream);
      IBinaryReader CreateBinaryReader(IStream stream, Encoding encoding);
      IBinaryReader CreateBinaryReader(IStream stream, Encoding encoding, bool leaveOpen);

      IBinaryWriter CreateBinaryWriter(IStream stream);
      IBinaryWriter CreateBinaryWriter(IStream stream, Encoding encoding);
      IBinaryWriter CreateBinaryWriter(IStream stream, Encoding encoding, bool leaveOpen);
   }
}
