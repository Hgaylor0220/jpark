using System;
using System.Collections.Generic;
//Back End
namespace Park {
     class Dino 
    {
         private string _name;
         private string _habitat;
         private string _danger;
         private string _type;

     
        public Dino (string name, string habitat, string danger, string type)
        {
         _name = name;
         _habitat = habitat;
         _danger  = danger;
         _type = type;

        }
   
        public string GetName()
        {
            return _name;
        }
        public string GetHabitat()
        {
            return _habitat;
        }

        public string GetDanger()
        {
            return _danger;
        }

        public string GetType()
        {
            return _type;
        }


    }

}