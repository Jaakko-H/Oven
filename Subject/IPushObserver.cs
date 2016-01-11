using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Subject
{
    public interface IPushObserver
    {
        void Update(int temp, int maxTemp);
        //pushes all the parameters defined to the observer from the subject
    }
}
