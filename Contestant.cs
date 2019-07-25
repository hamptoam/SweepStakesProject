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

        public Contestant(int id)
        {
            GetContestants();
        }

          public void GetContestants()
        {
            Dictionary<object, Contestant> contestants = new Dictionary<object, Contestant>();
            

           var c1 = new Contestant(8675309);
            c1.name = "Mary Anderson";
            c1.email = "";
            


            var c2 = new Contestant(8675308);
            c2.name = "Peter Anderson";
            c2.email = "";

            var c3 = new Contestant(8675307);
            c3.name = "";
            


        }        
    }
}
                
            


                

            

                    



                    




