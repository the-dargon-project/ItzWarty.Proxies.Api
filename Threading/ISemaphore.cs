using System;
using System.Threading;

namespace ItzWarty.Threading {
   public interface ISemaphore : IDisposable {
      void Release();
      void Release(int count);

      void Wait();
      bool Wait(int milliseconds);
      bool Wait(TimeSpan timespan);
      bool Wait(ICancellationToken cancellationToken);
      bool Wait(int millseconds, ICancellationToken cancellationToken);
      bool Wait(TimeSpan timespan, ICancellationToken cancellationToken);
   }
}