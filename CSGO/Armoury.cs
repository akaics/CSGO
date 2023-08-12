using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGO
{
    internal class Armoury 
    {

        //Creating a dictionary and adding two weapons: 
        Dictionary<int, Weapon> armouryDictionary = new Dictionary<int, Weapon>();

        public Armoury() 
        { 

        Weapon weaponOne = new Weapon("AK-47", 90, 25, 2, 1200, "T");
        Weapon weaponTwo = new Weapon("M4A1-S", 80, 30, 1, 1100, "CT");

        armouryDictionary[1] = weaponOne;
        armouryDictionary[2] = weaponTwo;
        }

        public void Create()
        {
           
        }

        public void Read() 
        {

        }

        public void Update()
        {
            
        }

        public void Delete()
        {
            
        }

        public void PurchaseWeapon()
        {
            
        }

    }
}
