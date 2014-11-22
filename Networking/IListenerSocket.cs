using System;
using System.Net.Sockets;

namespace ItzWarty.Networking {
   public interface IListenerSocket : IDisposable {
      Socket __Socket { get; }

      IConnectedSocket Accept();
   }
}