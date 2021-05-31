using System;

namespace Manager
{
    public class Activator
    {
        public Func<double, double> ActivationFunc { get; private set; }
        public string TitleFunc { get; private set; }

        public Activator(Func<double, double> activationFunc, string titleFunc)
        {
            ActivationFunc = activationFunc;
            TitleFunc = titleFunc;
        }
    }
}
