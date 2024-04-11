namespace ColorSpheres
{
    public class Sphere
    {
        private readonly Color _color;
        private float _radius;
        private int _xThrown;

        
        public Sphere(Color color, float radius)
        {
            _color = color;
            _radius = radius;
            _xThrown = 0;
        }

        public void Pop()
        {
            _radius = 0;
        }

        public void Throw()
        {
            if (_radius > 0)
            {
                _xThrown++;
            }
                
        }
    }
}