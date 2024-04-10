namespace ColorSpheres
{
    public class Color
    {
        private byte red, green, blue, alpha, average;


        public Color(byte r, byte g, byte b, byte a)
        {
            red = SetRed(r);
            green = SetGreen(g);
            blue = SetBlue(b);
            alpha = SetAlpha(a);
        }

        //Set
        
        private readonly byte SetRed(byte r)
        {
            return r;
        }

        private readonly byte SetGreen(byte g)
        {
            return g;
        }

        private readonly byte SetBlue(byte b)
        {
            return b;
        }

        private readonly byte SetAlpha(byte a)
        {
            return a;
        }

        //Get

        private readonly byte GetRed()
        {
            return red;
        }

        private readonly byte GetGreen()
        {
            return green;
        }

        private readonly byte GetBlue()
        {
            return blue;
        }

        private readonly byte GetAlpha()
        {
            return alpha;
        }

        private int GetGrey()
        {
            return (red + green + blue) / 3;
        }
    }
}