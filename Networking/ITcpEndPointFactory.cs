using System.Net;

namespace ItzWarty.Networking {
   public interface ITcpEndPointFactory {
      ITcpEndPoint CreateLoopbackEndPoint(int port);
      ITcpEndPoint CreateAnyEndPoint(int port);
      ITcpEndPoint CreateEndPoint(string host, int port);
      ITcpEndPoint CreateEndPoint(IPAddress address, int port);
   }
}