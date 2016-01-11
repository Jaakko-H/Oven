using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Subject
{
    public interface IPullObserver
    {
        void Update();
        //works as a notification to the observer that the state on the subject has changed so that
        //it fetches it's desired information from the subject
    }
}
