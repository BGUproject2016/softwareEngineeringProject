using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softwareEngineeringProject
{
    //presentation tier
    interface IPL
    {
        void run();
        string enter(string st);
        string illegal(string st);
        void incorrect();
        void isLoggedIn(string username);
    }
}
