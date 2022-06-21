using System;

namespace MagicalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Storm[] storms = new Storm[10];
            int stormIndex = 0;

            //storms[0]
            Pupil p = new Pupil("Mezil-Kree", "Icecrown");
            storms[stormIndex] = p.CastWindStorm();
            stormIndex++;
            //storms[1]
            Mage m = new Mage("Gul-dan", "Draenor");
            storms[stormIndex] = m.CastRainStorm();
            stormIndex++;
            //storms[2]
            Archmage a = new Archmage("Nielas Aran", "Stormwind");
            storms[stormIndex] = a.CastWindStorm();
            stormIndex++;
            //storms[3]
            storms[stormIndex] = a.CastRainStorm();
            stormIndex++;
            //storms[4]
            storms[stormIndex] = a.CastLightningStorm();
            stormIndex++;

            for (int i = 0; i < stormIndex; i++)
            {
                Console.WriteLine(storms[i].Announce());
            }
        }
    }
}