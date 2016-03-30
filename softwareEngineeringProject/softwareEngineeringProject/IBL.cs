using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softwareEngineeringProject
{
    //logic tire
    interface IBL
    {
        void cheackUsername();
        void cheackPassword(string correct);
        void changePassword(string username);


    }
}
