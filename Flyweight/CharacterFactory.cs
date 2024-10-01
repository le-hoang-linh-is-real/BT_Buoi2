using System.Collections.Generic;

namespace Flyweight.RealWorld
{
    public class CharacterFactory
    {
        private Dictionary<char, Character> characters = new Dictionary<char, Character>();

        public Character GetCharacter(char key)
        {
            // Uses "lazy initialization"
            if (!characters.ContainsKey(key))
            {
                Character character = key switch
                {
                    'A' => new CharacterA(),
                    'B' => new CharacterB(),
                    // Add other characters as needed
                    'Z' => new CharacterZ(),
                    _ => null
                };

                if (character != null)
                {
                    characters.Add(key, character);
                }
            }

            return characters[key];
        }
    }
}
