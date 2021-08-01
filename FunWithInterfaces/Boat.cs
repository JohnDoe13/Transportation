using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithInterfaces
{
    public class Boat : Airplane
    {
        public string boatline = "Viking Line";

        public void IamSailing()
        {
            Console.WriteLine("Sailing across the ocean.");
        }
    }

    
    
    
}

