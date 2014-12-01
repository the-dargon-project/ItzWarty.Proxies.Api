using ItzWarty.IO;
using System;
using System.Net.Sockets;

namespace ItzWarty.Networking {
   public interface IConnectedSocket : IDisposable {
      Socket __Socket { get; }

      IBinaryReader GetReader();
      IBinaryWriter GetWriter();
   }
}