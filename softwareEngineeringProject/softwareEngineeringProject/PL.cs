using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace softwareEngineeringProject
{
    class PL : IPL
    {
        

        public void run()
        {
            Console.WriteLine("Welcome, please choose one of the following options:");
            Console.WriteLine("1 - Log In");
            Console.WriteLine("2 - Exit");
            string ans = Console.ReadLine();
            while ((ans != "1")&&(ans!="2"))
            {
                Console.WriteLine("illegal input, please choose another option.");
                ans = Console.ReadLine();
            }
            if (ans=="1")
            {
                IBL bl = new BL();
                bl.cheackUsername();
                
            }
            else if (ans=="2")
            {
                Thread.Sleep(200);
                Environment.Exit(0);
            }
        }

        public string enter(string st)
        {
            Console.WriteLine("Please enter your "+st+": ");
            return Console.ReadLine();
        }

        public string illegal(string st)
        {
            Console.WriteLine("illegal "+st+", try again or press 1 to Exit ");
            return Console.ReadLine();
        }

        public void incorrect()
        {
            Console.WriteLine("incorrect password.");
            Console.WriteLine("the prigram will now shut down.");
        }

        public void isLoggedIn(string username)
        {
            Console.WriteLine("Welcome " + username + "!") ;
            Console.WriteLine("please choose one of the following options:");
            Console.WriteLine("1 - Change Password");
            Console.WriteLine("2 - Log Out");
            Console.WriteLine("3 - Exit");
            string ans = Console.ReadLine();
            while ((ans != "1") && (ans != "2")&&(ans!="3"))
            {
                Console.WriteLine("illegal input, please choose another option.");
                ans = Console.ReadLine();
            }
            if (ans == "1")
            {
                IBL bl = new BL();
                bl.changePassword(username);

            }
            else if (ans == "2")
            {
                run();
            }
            else if (ans == "3")
            {
                Thread.Sleep(200);
                Environment.Exit(0);
            }

        }



    }
}
