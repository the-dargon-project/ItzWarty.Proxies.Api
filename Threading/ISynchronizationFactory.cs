using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItzWarty.Threading {
   public interface ISynchronizationFactory {
      ISemaphore CreateSemaphore(int initialCount, int maximumCount);
      ICountdownEvent CreateCountdownEvent(int initialCount);
      ICancellationTokenSource CreateCancellationTokenSource();
      ICancellationTokenSource CreateCancellationTokenSource(int cancellationDelayMilliseconds);
      ICancellationTokenSource CreateCancellationTokenSource(TimeSpan cancellationDelay);
      ICancellationTokenSource CreateLinkedCancellationTokenSource(params ICancellationToken[] tokens);
   }
}
