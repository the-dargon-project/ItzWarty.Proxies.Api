using System.Net.Sockets;

namespace ItzWarty.Networking {
   public interface IListenerSocket {
      Socket __Socket { get; }
   }
}