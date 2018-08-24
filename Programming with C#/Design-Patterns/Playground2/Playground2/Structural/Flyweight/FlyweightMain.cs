using System;

namespace Playground2.Structural.Flyweight
{
    // 1 000 000 Chinese objects
    // not necessary every one chinese to bring all his stuff (properties) 
    // with him.
    // using tables to retrieve information.

    public static class FlyweightMain
    {
        public static void Run()
        {
            //Build a document with text
            const string Document = "AAZZABBZZBAB";

            var characterFactory = new CharacterFactory();

            // extrinsic state
            var pointSize = 10;

            // For each character use a flyweight object
            foreach (var c in Document)
            {
                pointSize++;
                var character = characterFactory.GetCharacter(c);
                character.Display(pointSize);
            }

            Console.WriteLine(
                    "Total number of character objects: {0}",
                    characterFactory.NumberOfObjects);


            Console.WriteLine(new string('-', 60));

            string str1 = "some value";
            string str2 = "some value";
            string str3 = Console.ReadLine();
            string str4 = string.Intern(str3);
            Console.WriteLine(ReferenceEquals(str1, str2));
            Console.WriteLine(ReferenceEquals(str1, str3));
            Console.WriteLine(ReferenceEquals(str1, str4));
        }
    }
}
