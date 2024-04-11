namespace ColorSpheres
{
    public class Color
    {
        /// <summary>
        /// Setting the variables being used which are readonly
        /// </summary>
        private readonly byte _red, _green, _blue, _alpha;


        /// <summary>
        /// Method consists in getting colors from the rgb colors (red, green, 
        /// blue) and transparency (alpha)
        /// </summary>
        /// <param name="r">stands for "red"</param>
        /// <param name="g">stands for "green"</param>
        /// <param name="b">stands for "blue"</param>
        /// <param name="a">stands for "alpha"</param>
        public Color(byte r, byte g, byte b, byte a)
        {
            _red = SetRed(r);
            _green = SetGreen(g);
            _blue = SetBlue(b);
            _alpha = SetAlpha(a);
        }

        /// <summary>
        /// Method overload Color which doesn't request alpha value since it's
        /// set at 255 (full opacity).
        /// </summary>
        /// <param name="r">stands for "red"</param>
        /// <param name="g">stands for "green"</param>
        /// <param name="b">stands for "blue"</param>
        public Color(byte r, byte g, byte b)
        {
            _red = SetRed(r);
            _green = SetGreen(g);
            _blue = SetBlue(b);
            _alpha = SetAlpha(255);
        }

        //Set
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="r">stands for "red"</param>
        /// <returns></returns>
        private byte SetRed(byte r)
        {
            return r;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="g">stands for "green"</param>
        /// <returns></returns>
        private byte SetGreen(byte g)
        {
            return g;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="b">stands for "blue"</param>
        /// <returns></returns>
        private byte SetBlue(byte b)
        {
            return b;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">stands for "alpha"</param>
        /// <returns></returns>
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