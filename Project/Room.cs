using System.Collections.Generic;

namespace CastleGrimtol.Project
{
    public class Room : IRoom
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Item> Items { get; set; }
        public Dictionary<string, Room> Exits = new Dictionary<string, Room>();
        public Room(string name, string description)
        {
            Name = name;
            Description = description;
            Items = new List<Item>();
            // Exits = new Dictionary<string, Room>();
        }
        public void UseItem(Item item)
        {
            if (Items.Contains(item))
            {
                //use the item
            }
            else
            {
             System.Console.WriteLine("not working asshole");
            }
        }
        public void PickUpItem(Item item, Player bob)
        {
         if(!Items.Contains(item))
         {
             System.Console.WriteLine("sorry cant pick up what you cant see including your mother!");
         }   
         else
         {
             //at this point pick up item 
             bob.Inventory.Add(item);
         }
        }
    }
}