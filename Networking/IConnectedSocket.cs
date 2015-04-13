using ItzWarty.IO;
using System;
using System.Net.Sockets;

namespace ItzWarty.Networking {
   public interface IConnectedSocket : IDisposable {
      Socket __Socket { get; }
      IStream Stream { get; }
      IBinaryReader Reader { get; }
      IBinaryWriter Writer { get; }

      IStream GetStream();
      IBinaryReader GetReader();
      IBinaryWriter GetWriter();
   }
}