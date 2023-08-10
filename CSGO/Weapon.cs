using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGO
{
    internal class Weapon
    {
        //instantfelter:
        private string name;
        private int damage;
        private int ammo;
        private int reloadTime;

        //Properties

        public string Name { get { return name; } }
        public int Damage { get { return damage; } }
        public int Ammo { get { return ammo; } }
        public int ReloadTime { get { return reloadTime; } }



        //Konstruktør: 

        public Weapon(string Name, int Damage, int Ammo, int ReloadTime)
        {
            name = Name;
            damage = Damage;
            ammo = Ammo;
            reloadTime = ReloadTime;
        }

        public override string ToString()
        {
            return $"Weapons details: Name: {Name}, Damage: {Damage}, Ammo: {Ammo}, ReloadTime: {ReloadTime}";
        }
    }
}
