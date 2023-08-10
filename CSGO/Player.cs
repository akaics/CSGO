using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGO
{
    internal class Player
    {
        //instansfelter:

        private int id;
        private string nickName;
        private int kills;
        private int deaths;
        private string teamSelected;

        //Konstruktør:

        public Player(int Id, string NickName, int Kills, int Deaths, string TeamSelected)
        {
            id = Id;
            nickName = NickName;
            kills = Kills;
            deaths = Deaths;
            teamSelected = TeamSelected;
        }

        //Properties:

        public int Id { get { return id; } }
        public string NickName { get { return nickName; } }
        public int Kills { get { return kills; } }

        public int Deaths { get { return deaths; } }
        public string TeamSelected { get { return teamSelected; } } 


        // ToString() method: 

        public override string ToString()
        {
            return $"Players details: ID: {Id}, NickName: {NickName}, Kills: {Kills}, Deaths: {Deaths}";
        }

    }

}

