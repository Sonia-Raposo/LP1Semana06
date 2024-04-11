using System;

namespace ColorSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating colors
            Color violet = new Color (84, 88, 204, 255);
            Color aqua = new Color (91, 250, 187, 255);

            // Creating spheres
            Sphere violetSphere = new Sphere (violet, 2.5f);
            Sphere aquaSphere = new Sphere (aqua, 5.0f);


            //Throw violet and print times thrown
            violetSphere.Throw();
            Console.WriteLine(violetSphere.GetTimesThrown);

            //Throw aqua and print times thrown
            aquaSphere.Throw();
            Console.WriteLine(aquaSphere.GetTimesThrown);


            //Throw violet twice, print times thrown and pop
            violetSphere.Throw();
            violetSphere.Throw();
            violetSphere.Pop();
            Console.WriteLine(violetSphere.GetTimesThrown);

            //Pop aqua sphere
            aquaSphere.Pop();            
        }
    }
}
