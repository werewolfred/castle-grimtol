using System;
using CastleGrimtol.Project;

namespace CastleGrimtol
{
    public class Program
    {
          public static bool Running = true;

        public static void Main(string[] args)
        {
            Console.Clear();
            Project.Game CastleGame = new Project.Game();
            CastleGame.Setup();
            while (Running)
            {
                CastleGame.GetInput();
                
            }
            
            
        }
    }
}
