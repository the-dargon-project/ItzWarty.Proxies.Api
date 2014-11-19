using System;
using System.Threading;

namespace ItzWarty.Threading {
   public interface ICountdownEvent : IDisposable {
      int CurrentCount { get; }
      int InitialCount { get; }
      bool IsSet { get; }

      void AddCount();
      void AddCount(int count);
      void Reset();
      void Reset(int count);
      void Signal();
      void Signal(int count);

      void Wait();
      bool Wait(int milliseconds);
      bool Wait(TimeSpan timespan);
      bool Wait(CancellationToken cancellationToken);
      bool Wait(int milliseconds, CancellationToken cancellationToken);
      bool Wait(TimeSpan timespan, CancellationToken cancellationToken);
   }
}