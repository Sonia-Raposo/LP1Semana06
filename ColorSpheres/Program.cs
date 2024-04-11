using System;

namespace ColorSpheres
{
    class Program
    {
        /// <summary>
        /// Method allows the creation of colors and spheres by using methods 
        /// located in other classes. The user can throw the spheres and
        /// print the number of times throw. It is also possible to pop the 
        /// spheres (radius = 0).
        /// </summary>
        /// <param name="args">No args are being used</param>
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
