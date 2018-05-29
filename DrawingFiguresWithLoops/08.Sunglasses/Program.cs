using System;

namespace _08.Sunglasses
{
    class Program
    {
        static void Main()
        {
            int frameHeight = int.Parse(Console.ReadLine());
            int frameWidth = frameHeight * 2;

            CreateTopBottomFrame(frameWidth, frameHeight);
            for (int i = 0; i < frameHeight-2; i++)
            {
                DrawACenterPart(frameWidth, frameHeight, i);
            }
            CreateTopBottomFrame(frameWidth, frameHeight);
        }

        public static void DrawACenterPart(int width, int spacing, int index)
        {
            int bridgeIndex = (int)((spacing - 2) / 2d);
            if ((spacing - 2) % 2 == 0)
            {
                bridgeIndex--;
            }

            var fillPart = new String('/', width - 2);
            var spacingPart = new String(' ', spacing);

            if (index == bridgeIndex)
            {
                spacingPart = new String('|', spacing);
            }
            Console.WriteLine('*' + fillPart + '*' + spacingPart + '*' + fillPart + '*');
        }

        public static void CreateTopBottomFrame(int width, int spacing)
        {
            var sidePart = new String('*', width);
            var spacingPart = new String(' ', spacing); 
            Console.WriteLine(sidePart + spacingPart + sidePart);
        }
    }
}
