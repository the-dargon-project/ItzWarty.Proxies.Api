using System.Net.Sockets;

namespace ItzWarty.Networking {
   public interface IConnectedSocket {
      Socket __Socket { get; }
   }
}