namespace Dargon.Threading {
   public interface IThreadingProxy {
      IThread CreateThread(ThreadEntryPoint entryPoint, ThreadCreationOptions options);
   }
}
