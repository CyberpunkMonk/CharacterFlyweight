using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharactersFlyweight {
    class MainApp {
        static void Main() {
            //Build a document with text
            string document = "AAZZBBZB";
            char[] chars = document.ToCharArray();

            CharacterFactory factory = new CharacterFactory();

            //extrinsic state
            int pointSize = 10;

            //foreach char use flyweight obj
            foreach(char c in chars) {
                pointSize++;
                Character character = factory.getCharacter(c);
                character.Display(pointSize);
            }
            //Wait for user
            Console.ReadKey();
        }
    }
}
