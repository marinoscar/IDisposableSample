using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public class ObjectCounter
    {

        private static Dictionary<string, int> _counter;

        public static Dictionary<string, int> Counter
        {
            get { return _counter ?? (_counter = new Dictionary<string, int>()); }
        }

        /// <summary>
        /// This method is only used for the test cases
        /// </summary>
        internal static void ClearCounter()
        {
            _counter = null;
        }
    }
}
