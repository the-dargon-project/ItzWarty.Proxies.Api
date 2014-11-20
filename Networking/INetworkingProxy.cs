using System.IO;
using System.Net.Sockets;

namespace ItzWarty.Networking {
   public interface INetworkingProxy {
      IConnectedSocket CreateConnectedSocket(string host, int port);
      IConnectedSocket CreateConnectedSocket(ITcpEndPoint endpoint);

      IListenerSocket CreateListenerSocket(int port);
      IConnectedSocket Accept(IListenerSocket listenerSocket);

      NetworkStream CreateNetworkStream(IConnectedSocket connectedSocket, bool ownsSocket = true); 

      ITcpEndPoint CreateLoopbackEndPoint(int port);
      ITcpEndPoint CreateEndPoint(string host, int port);
   }
}
