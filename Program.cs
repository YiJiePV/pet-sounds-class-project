using System;

namespace PetHW
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pets = new string[5];
            string[] sounds = new string[5];
            string userInput = "while";
            
            
            GetPetTypes(pets);
            Console.WriteLine();
            GetPetSounds(pets, sounds);
            Console.WriteLine();
            do
            {
                Console.WriteLine();
                ShowPets(pets);
                Console.WriteLine();
                Console.WriteLine("enter a pet type and I will show their sound");
                Console.WriteLine("enter 'exit' to quit");
                userInput = Console.ReadLine().ToLower();
                if(userInput != "exit")
                {
                    ShowSound(userInput, pets, sounds);
                }
            } while (userInput != "exit");
            Console.WriteLine("good bye");
            Console.ReadLine();
        }
        private static void GetPetTypes(string[] ppets)
        {
            for (int i = 0; i < ppets.Length; i++)
            {
                Console.WriteLine("Enter a pet");
                ppets[i] = Console.ReadLine();
            }
        }
        private static void GetPetSounds(string [] ppets, string[] psounds)
        {
            for (int i = 0; i < psounds.Length; i++)
            {
                Console.WriteLine("Enter a sound for {0}", ppets[i]);
                psounds[i] = Console.ReadLine();
            }
        }
        private static void ShowPets(string[] ppets)
        {
           for(int i = 0; i < ppets.Length; i++)
            {
                Console.Write("{0}  ", ppets[i]);
            }
        }
        private static void ShowSound(string pUserinput, string[] ppets, string[] psounds)
        {
            for(int i = 0; i < ppets.Length; i++)
            {
                if(ppets[i].ToLower() == pUserinput)
                {
                    Console.WriteLine();
                    Console.WriteLine("The {0} says '{1}'. ", ppets[i], psounds[i]);
                }
            }
        }
    }
}
