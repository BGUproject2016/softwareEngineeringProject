using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace softwareEngineeringProject
{
    class BL : IBL
    {
        private IPL pl=new PL();
        private IDAL dal=new DAL(); 

        public void cheackUsername()
        {
            string username= pl.enter("username");
            string check = dal.cheackUsername(username);
            while (check == "")
            {
                username = pl.illegal("username");
                if (username == "1")
                    Environment.Exit(0);
            }
            cheackPassword(check);
            pl.isLoggedIn(username);
        }

        public void cheackPassword(string correct)
        {
            int count = 5;
            string password = pl.enter("password");
            count = count - 1;
            while ((password!=correct)&&(count>0))
            {
                password = pl.illegal("password, you have "+count+" times left to try");
                if (password == "1")
                    Environment.Exit(0);
                count = count - 1;
            }
            if (count==0)
            {
                pl.incorrect();
                Thread.Sleep(900);
            }
        }

        public void changePassword(string username)
        {

        }



    }
}
