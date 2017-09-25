using System;
using CastleGrimtol.Project;

namespace CastleGrimtol
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            bool Running = true;
            Project.Game CastleGame = new Project.Game();
            CastleGame.Setup();
            while (Running)
            {
                CastleGame.GetInput();
                
            }
            
            
        }
    }
}
