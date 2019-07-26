using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Sweepstake
    {
        Dictionary<object, Contestant> contestants;


        public Sweepstake()
        {
            contestants = new Dictionary<object, Contestant>();

        }
        public void RegisterContestants(Contestant, contestant)
        {

            Contestant thiscontestant = new Contestant(string id);
            
            Console.WriteLine("What is your full name?");
            thiscontestant.name = Console.ReadLine(); 
            Console.WriteLine("What is your email?");
            thiscontestant.email = Console.ReadLine();

            contestants.Add(thiscontestant.name + thiscontestant.email);   
        }
    }
}


