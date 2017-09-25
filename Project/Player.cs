using System;
using System.Collections.Generic;

namespace CastleGrimtol.Project
{
    public class Player : IPlayer
    {

        public int Score { get; set; }
        public List<Item> Inventory { get; set; }

        public Player(int score, List<Item> inventory)
        {
            Score = score;
            Inventory = new List<Item>();
            
        }
     
    }
}