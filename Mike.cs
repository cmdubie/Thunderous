using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thunderous
{
    class Mike
    {
        public bool HasTwoCellPhones = true;
        public bool IsVBGuy = true;

        public string SwapMilitaryStories(string story)
        {
            if (story == "good")
            {
                return "When I was in the military. . .";
            }
        }

        public string DocumentPhoenix()
        {
            return "Lots of VB documentation";
        }

        public void FixPhoenix()
        {
            WalkToPhoenixLab();
            TakeBreak();
            AttemptToStopSweating();
            DeviseIngeniusVBSolution();
        }
    }
}
