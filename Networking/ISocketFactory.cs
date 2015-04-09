namespace ItzWarty.Networking {
   public interface ISocketFactory {
      IConnectedSocket CreateConnectedSocket(string host, int port);
      IConnectedSocket CreateConnectedSocket(ITcpEndPoint endpoint);

      IListenerSocket CreateListenerSocket(int port);
      IListenerSocket CreateListenerSocket(ITcpEndPoint endpoint);
   }
}