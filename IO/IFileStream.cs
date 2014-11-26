namespace ItzWarty.IO {
   public interface IFileStream : IStream {
      string Path { get; }

      void Lock(long position, long length);
      void Unlock(long position, long length);
   }
}