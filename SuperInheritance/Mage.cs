// Mage.cs
using System;

namespace MagicalInheritance
{
    class Mage : Pupil
    {
        public Mage(string Title) : base(Title)
        { }

        public Mage(string title, string origin) : base(title, origin)
        { }

        public virtual Storm CastRainStorm()
        {
            return new Storm("rain", false, Title);
        }
    }
}