using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VirtualPet
{
   public class VirtualPet
    {
        public string name;
        public string eat;
        public string drink;
        public string play;
        private int hungerLevel;
        private int thirstLevel;
        private int boredomLevel;


     public static int TickCount
       { get; }



        public VirtualPet()
        {
            this.name = "Godzooky";
            this.hungerLevel = 15;
            this.thirstLevel = 10;
            this.boredomLevel = 5;      
        }

        public string Name
        {
            get { return this.name; }
            
        }
        public int HungerLevel
        {
            get { return this.hungerLevel; }
            set { this.hungerLevel = value; }
        }
        public int ThirstLevel
        {
            get { return this.thirstLevel; }
            set { this.thirstLevel = value; }
        }
        public int BoredomLevel
        {
            get { return this.boredomLevel; }
            set { this.boredomLevel = value; }
        }
         
        public void Eat (string food)
        {
          
             food += 2;
        }

        public void Drink (string water)
        {
            water += 2;
        }

        public void Boredom (string play)
        {
             play += 2;
        }


        public void Speak( )
        {
            if (hungerLevel == 15 && hungerLevel <= 20)
            {
                Console.WriteLine(" {0} dances with joy, I'm stuffed that was good food ", name);
            }
            else if (hungerLevel == 10 && hungerLevel <= 14)
            {
                Console.WriteLine(" {0} looks around with a sheepish grin, what can we do now ? ", name);
            }
            else if (hungerLevel == 5 && hungerLevel <= 9)
            {
                Console.WriteLine(" {0} looks sad, hey I'm getting hungry ", name);
            }
            else
            {
                Console.WriteLine(" {0} stomach grumbles loud, momma, momma", name);
            }

            if (thirstLevel == 15 && thirstLevel <= 20)
            {
                Console.WriteLine("/(h)wō/ {0} whoa that hit the hot spot ", name);
            }
            else if (thirstLevel == 10 && thirstLevel <= 14)
            {
                Console.WriteLine(" {0} looks directly at you, what can we do for fun ?", name);
            }
            else if (thirstLevel == 5 && thirstLevel <= 9)
            {
                Console.WriteLine(" {0} looks at you with dry lips, hey I'm parched", name);
            }
            else
            {
                Console.WriteLine(name, " {0} loud grumbling , momma, momma, they're a terrible pet owner ", name);
            }

            if (boredomLevel == 15 && boredomLevel <= 20)
            {
                Console.WriteLine(" OMG where is {0} at, ", name);
                Console.WriteLine(" you see people running past you terrified & the building on fire  ");
                Console.WriteLine(" ENTER PLAY, #4 QUICK, before he burns up your neighborhood");
            }
            else if (boredomLevel == 10 && boredomLevel <= 14)
            {
                Console.WriteLine(" {0} looks down at the ground, you look up, ", name);
                Console.WriteLine( " and see the neighbors trash can on fire ");
            }
            else if (boredomLevel == 5 && boredomLevel <= 9)
            {
                Console.WriteLine(" {0} come on, lets go on a run", name);
            }
            else
            {
                Console.WriteLine(" {0} looks at you & says, lets have some fun ", name);
            }
        }
        
    }
    
}
