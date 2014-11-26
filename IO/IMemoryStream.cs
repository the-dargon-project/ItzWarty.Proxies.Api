namespace ItzWarty.IO {
   public interface IMemoryStream : IStream {
      byte[] GetBuffer();
      byte[] ToArray();
   }
}