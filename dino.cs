using System;
using System.Collections.Generic;
using Park;
//Front End
 public class Program
 {
public static void Main()
    {
        Dino tRex = new Dino("Philip", "Mountain", "Hella","Trex");
        Dino triceratops = new Dino ("Raven", "Jungle", "Lil' snappy", "triceratops");
        Dino brontosaurus = new Dino ("Brian", "Jungle", "Chillin", "brontosaurus");
        Dino raptor = new Dino("Felicia", "Fields", "Angsty", "raptor");

        List<Dino> Dinos = new List<Dino>() {tRex, triceratops, brontosaurus, raptor};

        Console.WriteLine("Who would you like to track dinosours in our park or create your own?[track or create]");
        string toc = Console.ReadLine();




        if(toc.ToLower() == "track")
    {
        Console.WriteLine("Pick a Dino to learn about: Philip, Raven, Brian, Felicia");
        string userChoice = Console.ReadLine();
           if(userChoice.ToLower() == "philip")
           {
                Console.WriteLine(tRex.GetName());
                Console.WriteLine(tRex.GetHabitat());
                Console.WriteLine(tRex.GetDanger());
                Console.WriteLine(tRex.GetType());
                }               
            if(userChoice.ToLower() == "raven")
           {
                Console.WriteLine(triceratops.GetName());
                Console.WriteLine(triceratops.GetHabitat());
                Console.WriteLine(triceratops.GetDanger());
                Console.WriteLine(triceratops.GetType());
                } 
            if(userChoice.ToLower() == "brian")
           {
                Console.WriteLine(brontosaurus.GetName());
                Console.WriteLine(brontosaurus.GetHabitat());
                Console.WriteLine(brontosaurus.GetDanger());
                Console.WriteLine(brontosaurus.GetType());
                }  
            if(userChoice.ToLower() == "felicia")
           {
                Console.WriteLine(raptor.GetName());
                Console.WriteLine(raptor.GetHabitat());
                Console.WriteLine(raptor.GetDanger());
                Console.WriteLine(raptor.GetType());
                } 
           
    }
         else if(toc.ToLower() == "create")
        {
            Console.WriteLine("Create a new Dino! Enter a type of dino");
            string dinoType = Console.ReadLine();

            Console.WriteLine("Enter a name for your dino");
            string dinoName = Console.ReadLine();
            
            Console.WriteLine("Enter your dino's habitat");
            string dinoHab = Console.ReadLine();

             Console.WriteLine("Enter your dino's danger level");
            string dinoDanger = Console.ReadLine();

            Console.WriteLine("Here is your dino!, Your dino is a " + " " + dinoType + " named " + " " + dinoName + " living in " +   " " + dinoHab + " ."+ " Danger level is " + dinoDanger);

            //attempted to create setters to display the informaiton that the user defined and it failed. 
        
        }
    }
 }