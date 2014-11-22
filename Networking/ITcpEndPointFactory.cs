namespace ItzWarty.Networking {
   public interface ITcpEndPointFactory {
      ITcpEndPoint CreateLoopbackEndPoint(int port);
      ITcpEndPoint CreateAnyEndPoint(int port);
      ITcpEndPoint CreateEndPoint(string host, int port);
   }
}