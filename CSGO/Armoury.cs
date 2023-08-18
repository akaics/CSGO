using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace CSGO
{
    internal class Armoury 
    {

        //Creating a dictionary and adding two weapons: 
        Dictionary<int, Weapon> weapons = new Dictionary<int, Weapon>();

        public Armoury() 
        { 

        Weapon weaponOne = new Weapon(1, "AK-47", 90, 25, 2, 1200, "T");
        Weapon weaponTwo = new Weapon(2, "M4A1-S", 80, 30, 1, 1100, "CT");

            weapons[1] = weaponOne;
            weapons[2] = weaponTwo;
        }
        public void Create(int id, string name, int damage, int ammo, int reloadTime, int price, string team)
        {
            weapons.Add(1, new Weapon(id, name, damage, ammo, reloadTime, price, team));
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
