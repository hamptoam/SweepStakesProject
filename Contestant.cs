using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Contestant
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }

        public Contestant()
        {
            Console.WriteLine("What is your full name?");
            this.name = Console.ReadLine();
            Console.WriteLine("What is your email?");
            this.email = Console.ReadLine();
            this.id = randomId();

           // RegisterContestant();
            


         int randomId()
            {
                Random random = new Random();
                int id = random.Next(10000, 20000);

                return id;
            }

        }

    }
}
                
            


                

            

                    



                    




