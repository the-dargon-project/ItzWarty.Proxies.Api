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
      bool Wait(ICancellationToken cancellationToken);
      bool Wait(int milliseconds, ICancellationToken cancellationToken);
      bool Wait(TimeSpan timespan, ICancellationToken cancellationToken);
   }
}