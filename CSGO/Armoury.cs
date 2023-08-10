using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGO
{
    internal class Armoury 
    {

        
        Dictionary<int, Weapon> armouryDictionary = new Dictionary<int, Weapon>();

        public Armoury() 
        { 
        armouryDictionary[1] = "AK-47";
        armouryDictionary[2] = "M4A1-S";
        }
         
    }
}
