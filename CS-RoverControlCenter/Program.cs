using System;

namespace RoverControlCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
            MoonRover apollo = new MoonRover("Apollo 15", 1971);
            MarsRover sojourner = new MarsRover("Sojourner", 1997);
            Satellite sputnik = new Satellite("Sputnik", 1957);
            //Rover[] rovers = {lunokhod, apollo, sojourner};
            //Object[] probes = {lunokhod, apollo, sojourner, sputnik};
            IDirectable[] spaceProbes = { lunokhod, apollo, sojourner, sputnik };

            DirectAll(spaceProbes);
            /*foreach(Object probe in probes)
            {
              Console.WriteLine($"Tracking a {probe.GetType()}...");
            }*/
        }
        public static void DirectAll(IDirectable[] spaceProbes)
        {
            foreach (IDirectable sp in spaceProbes)
            {
                Console.WriteLine(sp.GetInfo());
                Console.WriteLine(sp.Explore());
                Console.WriteLine(sp.Collect());
            }
        }
    }
}
