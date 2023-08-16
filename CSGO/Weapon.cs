using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CSGO
{
    public class Weapon
    {
        //instantfelter:
        private int id;
        private string name;
        private int damage;
        private int ammo;
        private int reloadTime;
        private int price;
        private string team;

        //Properties

        public int ID { get { return id; } }
        public string Name { get { return name; } }
        public int Damage { get { return damage; } }
        public int Ammo { get { return ammo; } }
        public int ReloadTime { get { return reloadTime; } }
        public int Price { get { return price; } }
        public string Team { get { return team; } }     




        //Konstruktør: 

        public Weapon(int ID, string Name, int Damage, int Ammo, int ReloadTime, int Price, string Team)
        {
            id = ID;
            name = Name;
            damage = Damage;
            ammo = Ammo;
            reloadTime = ReloadTime;
            price = Price;
            team = Team;

         
        }

        public override string ToString()
        {
            return $"Weapons details: Name: {Name}, Damage: {Damage}, Ammo: {Ammo}, ReloadTime: {ReloadTime}, Team: {Team}";
        }
    }
}
