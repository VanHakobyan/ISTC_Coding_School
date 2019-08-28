using System;
using System.Threading;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.TPL.TPL08
{
    class Program
    {

        //The following example shows the basic pattern for task cancellation that throws the exception.
        //Note that the token is passed to the user delegate and to the task instance itself.
        static void Main(string[] args)
        {
            var tokenSource2 = new CancellationTokenSource();
            CancellationToken ct = tokenSource2.Token;
           
            Task task = Task.Factory.StartNew(() =>
            {

                // Were we already canceled?
                //ct.ThrowIfCancellationRequested();

                while (true)
                {
                    // Poll on this property if you have to do
                    // other cleanup before throwing.
                    if (ct.IsCancellationRequested)
                    {
                        // Clean up here, then...
                        ct.ThrowIfCancellationRequested();
                    }
                }
            }, tokenSource2.Token); // Pass same token to StartNew.

            //tokenSource2.Cancel();

            // Just continue on this thread, or Wait/WaitAll with try-catch:
            try
            {
                task.Wait();
            }
            catch (AggregateException e)
            {
                foreach (var v in e.InnerExceptions)
                    Console.WriteLine(e.Message + " " + v.Message);
            }
            finally
            {
                tokenSource2.Dispose();
            }

            Console.ReadKey();
        }
    }
}
