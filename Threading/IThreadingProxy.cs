using System;

namespace ItzWarty.Threading {
   public interface IThreadingProxy {
      void Sleep(int durationMilliseconds);
      void Sleep(TimeSpan duration);
      IThread CreateThread(ThreadEntryPoint entryPoint, ThreadCreationOptions options);
      ISemaphore CreateSemaphore(int initialCount, int maximumCount);
      ICountdownEvent CreateCountdownEvent(int initialCount);
      ICancellationTokenSource CreateCancellationTokenSource();
      ICancellationTokenSource CreateCancellationTokenSource(int cancellationDelayMilliseconds);
      ICancellationTokenSource CreateCancellationTokenSource(TimeSpan cancellationDelay);
   }
}
