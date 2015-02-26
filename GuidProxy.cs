using System;

namespace ItzWarty {
   public interface GuidProxy {
      Guid NewGuid();
      Guid Parse(string input);
      Guid ParseExact(string input, string format);
      bool TryParse(string input, out Guid result);
      bool TryParseExact(string input, string format, out Guid result);
   }
}
