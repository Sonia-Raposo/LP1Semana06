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
        /// Method sets the value for the red from the rgb
        /// </summary>
        /// <param name="r">stands for "red"</param>
        /// <returns></returns>
        private byte SetRed(byte r)
        {
            return r;
        }

        /// <summary>
        /// Method sets the value for the green from the rgb
        /// </summary>
        /// <param name="g">stands for "green"</param>
        /// <returns></returns>
        private byte SetGreen(byte g)
        {
            return g;
        }

        /// <summary>
        /// Method sets the value for the color blue from the rgb
        /// </summary>
        /// <param name="b">stands for "blue"</param>
        /// <returns></returns>
        private byte SetBlue(byte b)
        {
            return b;
        }

        /// <summary>
        /// Method sets the alpha (transparency)
        /// </summary>
        /// <param name="a">stands for "alpha"</param>
        /// <returns></returns>
        private byte SetAlpha(byte a)
        {
            return a;
        }

        //Get

        /// <summary>
        /// Method gets the value for the red from the rgb
        /// </summary>
        /// <returns>value of color red</returns>
        private byte GetRed()
        {
            return _red;
        }

        /// <summary>
        /// Method gets the value for the green from the rgb
        /// </summary>
        /// <returns>value of color green</returns>
        private byte GetGreen()
        {
            return _green;
        }

        /// <summary>
        /// Method gets the value for the blue from the rgb
        /// </summary>
        /// <returns>value of color blue</returns>
        private byte GetBlue()
        {
            return _blue;
        }

        /// <summary>
        /// Method gets the value for the alpha
        /// </summary>
        /// <returns>value of alpha</returns>
        private byte GetAlpha()
        {
            return _alpha;
        }

        /// <summary>
        /// Method gets the value for the grey color ((r+g+b)/3)
        /// </summary>
        /// <returns>value of color grey</returns>
        private byte GetGrey()
        {
            return (byte)((_red + _green + _blue) / 3);
        }
    }
}