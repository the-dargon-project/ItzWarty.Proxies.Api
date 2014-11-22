using System;
using System.Threading;

namespace ItzWarty.Threading {
   public interface ICancellationTokenSource : IDisposable {
      bool IsCancellationRequested { get; }
      ICancellationToken Token { get; }

      void CancelAfter(int millisecondDelay);
      void CancelAfter(TimeSpan delay);

      void Cancel();
   }
}