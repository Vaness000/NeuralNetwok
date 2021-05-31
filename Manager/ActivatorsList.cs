using System;
using System.Collections.Generic;

namespace Manager
{
    public class ActivatorsList
    {
        public static IEnumerable<Activator> GetActivators()
        {
            yield return new Activator((x) => 1 / (1 + Math.Exp(-x)), "Сигмоид");
            yield return new Activator((x) => x > 0 ? 1 : 0, "Ступенчатая");
            yield return new Activator((x) => 2 / (1 + Math.Exp(-2 * x) - 1), "Гиперболический тангенс");
            yield return new Activator(ReLu, "ReLu");
        }

        private static double ReLu(double x)
        {
            return x > 0 ? x : 0;
        }
    }
}
