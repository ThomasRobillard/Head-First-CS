using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbilityScoreTester
{
    internal class AbilityScoreCalculator
    {
        public int RollResult = 14;
        public double DivideBy = 1.75;
        public int AddAmount = 2;
        public int Minimum = 3;
        public int Score;

        public void CalculateAbilityScore()
        {
            // divide the roll result by the DivideBy field
            double divided = RollResult / DivideBy;

            // Add Addamount to the result of that division. Round down.
            int added = AddAmount += (int)divided;

            // if result is too small, use minimium
            if (added < Minimum )
            {
                Score = Minimum;
            }
            else
            {
                Score = added;
            }
        }
    }
}
