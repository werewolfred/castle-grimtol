using System;
using System.Collections.Generic;

namespace CastleGrimtol.Project
{
    public class Game : IGame
    {
        public Room CurrentRoom { get; set; }
        public Player CurrentPlayer { get; set; }
        public void Setup()
        {
            //build rooms
            Room room1 = new Room("room1", "you begin the quest here in this squalor of a room, with no way back,/n the only thing to do now is move forward,/n however this room does have some old sword here, /n maybe it will be of some use?");
            Room room2 = new Room("room2", "the room is dark and you seem to have located the door./n but it has been long boarded up./n maye there is something here that can help you? ");
            Room room3 = new Room("room3", "the room is covered in weird vines that seem almost alive, you prod them hoping for a good reaction but nothing happens, perhaps they are needing to be pruned?");
            Room room4 = new Room("room4", "this is the final room to escape, hopefully things will be easy enough from now on... oh no the dragon!!");
            //Room room5 = new Room("room5", "final room");
            //establish relationships
            room1.Exits.Add("e", room2);
            room2.Exits.Add("w", room1);
            room2.Exits.Add("e", room3);
            room3.Exits.Add("w", room2);
            room3.Exits.Add("e", room4);
            room4.Exits.Add("w", room3);
            //room4.Exits.Add("e", room5);
            //room5.Exits.Add("w", room4);
            //build items and build to room
            Item sword = new Item("sword", "a big sharp object used for slaying");
            // Item shield = new Item("shield", "something like a mirror but more defensible");
            // Item Yoyo = new Item("Yoyo", "a child plaything that mesmorises its opponents into deathlike slumber");
            // Item skeletonKey = new Item("skeleton key", "this key is made from the pinkey bone of a troll, surprisingly it does not smell like rotting death like like trolls do");
            room1.Items.Add(sword);
            // room2.Items.Add(shield);
            // room3.Items.Add(Yoyo);
            // room4.Items.Add(skeletonKey);
            CurrentRoom = room1;
            System.Console.WriteLine("let's play a game :{");
            System.Console.WriteLine("W == move west to new room");
            System.Console.WriteLine("E == move east to new room");
            System.Console.WriteLine("R == resets game to beginning");
            System.Console.WriteLine("your in a room that has only one exit should we get on with it already?");
            GetInput();
        }
        public void GetInput()
        {
            string userinput = System.Console.ReadLine().ToLower();
            //build if statements for every possible text command 
            if (userinput == "w" || userinput == "e")
            {
                Go(userinput);
            }
            else if (userinput == "r")
            {
                Reset();
            }
            else if (userinput == "h")
            {
                Help();
            }
            else if (userinput == "u")
            {
                UseItem();
            }
            else if (userinput == "t")
            {
                Item item = CurrentRoom.Items.Find(Item => Item.Name== "sword");
                Console.WriteLine(item.Name);
                Take(item);
            }
            else
            {
                System.Console.WriteLine("what the fuck!!!");
            }
        }

        private void UseItem()
        {
            throw new NotImplementedException();
        }

        //this function take in userInput and makes whatever was passed into a new CurrentRoom
        public void Go(string direction)
        {
            //write out validation
            if (CurrentRoom.Exits.ContainsKey("e") || CurrentRoom.Exits.ContainsKey("w"))
            {

                CurrentRoom = CurrentRoom.Exits[direction];
                System.Console.WriteLine($"you are in {CurrentRoom.Name}, {CurrentRoom.Description}");
                CurrentPlayer.Score++;
            }
        }
        public void Reset()
        {
            System.Console.WriteLine("are you sure you want to do this?");
            string userinput = System.Console.ReadLine().ToLower();
            if (userinput == "n")
            {
                System.Console.WriteLine("back to where we were then?");
                //System.Console.WriteLine("get back to the game!");
            }
            else
            {
                if (userinput == "y")
                {
                    Setup();
                }
            }
        }
        public void Help()
        {
            System.Console.WriteLine("W == move west to new room");
            System.Console.WriteLine("E == move east to new room");
            System.Console.WriteLine("R == resets game to beginning");
        }
        public void Take(Item item)
        {
            for (var i = 0; i < CurrentRoom.Items.Count; i++)
            {
                if (CurrentRoom.Items[i].Name == item.Name)
                {
                    Console.ReadLine();
                    CurrentPlayer.Inventory.Add(item);
                    CurrentRoom.Items.Remove(item);
                    System.Console.WriteLine("moved to inventory");
                }
            }
        }
        public void UseItem(Item item)
        {
            for(var i = 0; i<CurrentPlayer.Inventory.Count; i++)
            {
                if(CurrentPlayer.Inventory[i].Name == item.Name)
                {
                    
                }
            }
        }

        public void UseItem(string itemName)
        {
            throw new NotImplementedException();
        }
    }
}