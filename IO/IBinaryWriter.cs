using System;
using System.IO;

namespace ItzWarty.IO {
   public interface IBinaryWriter : IDisposable {
      System.IO.BinaryWriter __Writer { get; }

      void Write(bool value);
      void Write(byte value);
      void Write(sbyte value);
      void Write(char ch);
      void Write(short value);
      void Write(ushort value);
      void Write(int value);
      void Write(uint value);
      void Write(long value);
      void Write(ulong value);
      void Write(float value);
      void Write(double value);
      void Write(decimal value);
      void Write(string value);
      void WriteNullTerminatedString(string value);
      void WriteTinyText(string value);
      void WriteText(string value);
      void WriteLongText(string value);
      

      long Seek(int offset, SeekOrigin origin);
      void Write(byte[] buffer);
      void Write(byte[] buffer, int index, int count);
      void Write(char[] chars);
      void Write(char[] chars, int index, int count);

      void Close();
      void Flush();
      IStream BaseStream { get; }
   }
}