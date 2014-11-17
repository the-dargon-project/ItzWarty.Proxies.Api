namespace ItzWarty.Threading {
   public interface IThreadingProxy {
      IThread CreateThread(ThreadEntryPoint entryPoint, ThreadCreationOptions options);
   }
}
