using System;

namespace MagicalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Storm s = new Storm("wind", false, "Zul'rajas");
            Console.WriteLine(s.Announce());

            Pupil p = new Pupil("Mezil-Kree");
            Storm pupilCast = p.CastWindStorm();
            Console.WriteLine(pupilCast.Announce());

            Mage m = new Mage("Gul-dan");
            Storm mageCast = m.CastRainStorm();
            Console.WriteLine(mageCast.Announce());

            Archmage a = new Archmage("Nielas Aran");
            Storm archmageCastRain = a.CastRainStorm();
            Console.WriteLine(archmageCastRain.Announce());
            Storm archmageCastLightning = a.CastLightningStorm();
            Console.WriteLine(archmageCastLightning.Announce());
        }
    }
}