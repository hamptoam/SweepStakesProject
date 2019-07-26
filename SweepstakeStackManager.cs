using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class SweepstakeStackManager : ISweepstakesManager
    {

        public Dictionary contestants;

        public SweepstakeStackManager()
        {
            GetSweepstakeStack();

        }

        public static void GetSweepstakeStack()
        {

            Stack st = new Stack(contestants);
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(4);

        }
    }
}
