namespace ColorSpheres
{
    public class Color
    {
        private readonly byte _red, _green, _blue, _alpha;


        public Color(byte r, byte g, byte b, byte a)
        {
            _red = SetRed(r);
            _green = SetGreen(g);
            _blue = SetBlue(b);
            _alpha = SetAlpha(a);
        }

        public Color(byte r, byte g, byte b)
        {
            _red = SetRed(r);
            _green = SetGreen(g);
            _blue = SetBlue(b);
            _alpha = SetAlpha(255);
        }

        //Set
        
        private byte SetRed(byte r)
        {
            return r;
        }

        private byte SetGreen(byte g)
        {
            return g;
        }

        private byte SetBlue(byte b)
        {
            return b;
        }

        private byte SetAlpha(byte a)
        {
            return a;
        }

        //Get

        private byte GetRed()
        {
            return _red;
        }

        private byte GetGreen()
        {
            return _green;
        }

        private byte GetBlue()
        {
            return _blue;
        }

        private byte GetAlpha()
        {
            return _alpha;
        }

        private byte GetGrey()
        {
            return (byte)((_red + _green + _blue) / 3);
        }
    }
}