using System;
using System.Net.Sockets;
using ItzWarty.Threading;

namespace ItzWarty.Networking {
   public interface IListenerSocket : IDisposable {
      Socket __Socket { get; }

      IConnectedSocket Accept();
      IConnectedSocket Accept(ICancellationToken cancellationToken);
   }
}