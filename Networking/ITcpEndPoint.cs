using System.Net;

namespace ItzWarty.Networking {
   public interface ITcpEndPoint {
      IPEndPoint ToIPEndPoint();
   }
}