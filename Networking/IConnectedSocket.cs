using System;
using System.IO;
using System.Net.Sockets;

namespace ItzWarty.Networking {
   public interface IConnectedSocket : IDisposable {
      Socket __Socket { get; }

      BinaryReader GetReader();
      BinaryWriter GetWriter();
   }
}