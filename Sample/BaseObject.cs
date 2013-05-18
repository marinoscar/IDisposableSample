using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{

    /// <summary>
    /// This needs to be the base class for all the objects you want to keep track
    /// </summary>
    public abstract class BaseObject : IDisposable
    {


        /// <summary>
        /// In the constrcutor we will initialize the counter for the type
        /// </summary>
        protected BaseObject()
        {
            if (!ObjectCounter.Counter.ContainsKey(GetName()))
            {
                ObjectCounter.Counter.Add(GetName(), 1);
                return;
            }
            ObjectCounter.Counter[GetName()] = ObjectCounter.Counter[GetName()] + 1;
        }

        //When the item is disposed then the counter will be decreased
        public void Dispose()
        {
            if (ObjectCounter.Counter[GetName()] > 0)
                ObjectCounter.Counter[GetName()] = ObjectCounter.Counter[GetName()] - 1;
        }


        private string GetName()
        {
            return GetType().Name;
        }

    }
}
