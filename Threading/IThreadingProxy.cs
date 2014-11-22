using System;

namespace ItzWarty.Threading {
   public interface IThreadingProxy : IThreadingFactory, ISynchronizationFactory {
      void Sleep(int durationMilliseconds);
      void Sleep(TimeSpan duration);
   }
}
