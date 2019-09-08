using System;

namespace ClassLibrary1
{
    public class ModeAttribute : Attribute
    {
        public Mode Mode { get; }

        public ModeAttribute(Mode mode)
        {
            Mode = mode;
        }
    }
}