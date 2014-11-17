namespace Dargon.Processes
{
   public interface IProcessProxy
   {
      IProcess GetProcessById(int id);
      IProcess GetProcessOrNull(int id);
      IProcess[] GetProcesses();
      IProcess GetParentProcess(IProcess process);
   }
}