using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.EvalServiceReference;

namespace Client
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Hit ENTER to start the application... ");
      Console.ReadLine();

      // Pass in the name of the endpoint you want to connect to on the service
      EvalServiceClient client = new EvalServiceClient("ws");

      Eval eval = new Eval {Comments = "This came from code", Submitter = "Ira", TimeSubmitted = DateTime.Now};
      
      client.SubmitEval(eval);

      Eval[] evals = client.GetEvals();

      foreach (Eval ev in evals)
      {
        Console.WriteLine(String.Format("Comment: {0}", ev.Comments));
      }

      Console.Write("Hit ENTER to exit the application... ");
      Console.ReadLine();
    }
  }
}
