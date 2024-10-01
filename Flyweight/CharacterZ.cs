using System;

namespace Flyweight.RealWorld
{
    public class CharacterZ : Character
    {
        public CharacterZ()
        {
            symbol = 'Z';
            height = 100;
            width = 100;
            ascent = 68;
            descent = 0;
        }

        public override void Display(int pointSize)
        {
            this.pointSize = pointSize;
            Console.WriteLine($"{symbol} (pointsize {this.pointSize})");
        }
    }
}
