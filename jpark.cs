using System;
using System.Collections.Generic;

namespace Park {
     class Dino 
    {
         private string _name;
         private string _habitat;
         private string _danger;

     
        public Dino (string name, string habitat, string danger)
        {
         _name = name;
         _habitat = habitat;
         _danger  = danger;

        }
    public static void Main()
    {
        Dino tRex = new Dino("Philip", "Mountain", "Hella");
        Dino triceratops = new Dino ("Raven", "Jungle", "Lil' snappy");
        Dino brontosaurus = new Dino ("Brian", "Jungle", "Chillin");
        Dino raptor = new Dino("Felicia", "Fields", "Angsty");

        Console.WriteLine("Who would you like to track? Raven, Brian, Felicia or Phillip?");
        string whichDino = Console.ReadLine();
        
    }
    }
    
    
    
    // FRONT END
}