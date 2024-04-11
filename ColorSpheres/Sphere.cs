namespace ColorSpheres
{
    /// <summary>
    /// Class that contains the sphere parameters; color, radius and number of 
    /// times thrown.
    /// </summary>
    public class Sphere
    {
        /// <summary>
        /// Defines the color.
        /// </summary>
        private readonly Color _color;

        /// <summary>
        /// Defines the radius of the sphere.
        /// </summary>
        private float _radius;
        
        /// <summary>
        /// Counts the number of times sphere was thrown.
        /// </summary>
        private int _xThrown;

        
        /// <summary>
        /// Sets the variables color, radius and times throw.
        /// </summary>
        /// <param name="color">defines the color of the sphere</param>
        /// <param name="radius">defines the radius of the sphere</param>
        public Sphere(Color color, float radius)
        {
            _color = color;
            _radius = radius;
            _xThrown = 0;
        }

        /// <summary>
        /// If method is used, the sphere radius is set to 0.
        /// </summary>
        public void Pop()
        {
            _radius = 0;
        }

        /// <summary>
        /// Throws the sphere if the radius is superior to 0.
        /// </summary>
        public void Throw()
        {
            if (_radius > 0)
            {
                _xThrown++;
            }
        }

        /// <summary>
        /// Gets the number of times the sphere was thrown.
        /// </summary>
        public int GetTimesThrown
        {
            get => _xThrown;
        }
    }
}