using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EvalServiceLibrary
{
  [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
  class EvalService : IEvalService
  {
    #region Fields...

    private List<Eval> _evals = new List<Eval>();

      #endregion

    #region IEvalService Public Methods...

    public void SubmitEval(Eval eval)
    {
      eval.Id = Guid.NewGuid().ToString();
      _evals.Add(eval);
    }

    public List<Eval> GetEvals()
    {
      return _evals;
    }

    public void RemoveEval(string id)
    {
      _evals.Remove(_evals.Find(e => e.Id.Equals(id)));
    }

    #endregion
  }
}
