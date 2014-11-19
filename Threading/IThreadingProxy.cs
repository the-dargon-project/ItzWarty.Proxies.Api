namespace ItzWarty.Threading {
   public interface IThreadingProxy {
      IThread CreateThread(ThreadEntryPoint entryPoint, ThreadCreationOptions options);
      ISemaphore CreateSemaphore(int initialCount, int maximumCount);
      ICountdownEvent CreateCountdownEvent(int initialCount);
   }
}
