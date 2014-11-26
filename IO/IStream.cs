using System;
using System.IO;

namespace ItzWarty.IO {
   public interface IStream : IDisposable {
      long Length { get; }
      long Position { get; set; }
      void SetLength(long value);

      bool CanRead { get; }
      int ReadByte();
      int Read(byte[] buffer, int offset, int count);
      // IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state);
      // int EndRead(IAsyncResult asyncResult);
      // Task<int> ReadAsync(byte[] buffer, int offset, int count);
      // Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);

      bool CanSeek { get; }
      long Seek(long offset, SeekOrigin origin);

      bool CanWrite { get; }
      void WriteByte(byte value);
      void Write(byte[] buffer, int offset, int count);
      // IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state);
      // void EndWrite(IAsyncResult asyncResult);
      // Task WriteAsync(byte[] buffer, int offset, int count);
      // Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);

      void Flush();
      void Close();
      // void CopyTo(System.IO.Stream destination);
      // void CopyTo(System.IO.Stream destination, int bufferSize);

      Stream __Stream { get;  }

      IBinaryReader GetReader();
      IBinaryWriter GetWriter();
   }
}
