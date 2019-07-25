using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Contestant
    {
        public int registrationNum { get; set; }
        public string firstName;
        public string lastName;
        public string email;
      


        public Contestant()
        {

            Contestant contestant = new Contestant()
            {
                registrationNum = 8675309;
                firstName = "Susan";
                lastName = "Anderson";
                email = "suziAn@gmail.com";
               
            };

            {
                registrationNum = 8675308;
                firstName = "Bill";
                lastName = "Anderson";
                email = "billson@gmail.com";
            };

        }
    }
}
