using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharactersFlyweight {
    class CharacterFactory {
        private Dictionary<char,Character> _characters = new Dictionary<char,Character>();
        public Character getCharacter(char key) {
            //uses 'lazy' initialization
            Character character = null;
            if(_characters.ContainsKey(key)) {
                character=_characters[key];
            }
            else {
                switch(key) {
                    case 'A':character=new CharacterA(); break;
                    case 'B':character=new CharacterB(); break;
                    //case '...'
                    case 'Z':character=new CharacterZ();break;
                }
                _characters.Add(key,character);
            }
            return character;
        }
    }
}
