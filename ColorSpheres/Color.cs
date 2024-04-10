using System;

namespace ColorSpheres
{
    public class Color
    {
        private byte red, green, blue, alpha;


        public Color(byte r, byte g, byte b, byte a)
        {
            red = SetRed(r);
            green = SetGreen(g);
            blue = SetBlue(b);
            alpha = SetAlpha(a);
        }

        
    }
}