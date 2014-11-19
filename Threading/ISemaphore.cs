using System;
using System.Threading;

namespace ItzWarty.Threading {
   public interface ISemaphore : IDisposable {
      void Release();
      void Release(int count);

      void Wait();
      bool Wait(TimeSpan timespan);
      bool Wait(CancellationToken cancellationToken);
      bool Wait(TimeSpan timespan, CancellationToken cancellationToken);
   }
}