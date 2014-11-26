using System;
using System.IO;

namespace ItzWarty.IO {
   public interface IBinaryReader : IDisposable {
      BinaryReader __Reader { get; }

      int PeekChar();
      int Read();
      bool ReadBoolean();
      byte ReadByte();
      sbyte ReadSByte();
      char ReadChar();
      short ReadInt16();
      ushort ReadUInt16();
      int ReadInt32();
      uint ReadUInt32();
      long ReadInt64();
      ulong ReadUInt64();
      float ReadSingle();
      double ReadDouble();
      decimal ReadDecimal();
      string ReadString();
      string ReadStringOfLength(int length);
      string ReadNullTerminatedString();
      string ReadTinyText();
      string ReadText();
      string ReadLongText();
      int Read(char[] buffer, int index, int count);
      char[] ReadChars(int count);
      int Read(byte[] buffer, int index, int count);
      byte[] ReadBytes(int count);
      byte[] ReadAllBytes();
      void Close();
      IStream BaseStream { get; }
   }
}