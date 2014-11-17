using System;

namespace Dargon.Processes
{
   public interface IProcess
   {
      int Id { get; }
      string ProcessName { get; }

      bool EnableRaisingEvents { get; set; }
      bool HasExited { get; }
      event EventHandler Exited;
   }
}