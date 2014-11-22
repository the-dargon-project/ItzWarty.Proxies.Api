using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItzWarty.Threading {
   public interface IThreadingFactory {
      IThread CreateThread(ThreadEntryPoint entryPoint, ThreadCreationOptions options);
   }
}
