using System;
using System.Runtime;

namespace Thunderous
{
    class Jenalee
    {
        public bool SpectrumExpert = true;
        public bool HasCoolHaircut = true;
        private bool _hasJeffsMouse = true;
        private bool _hasGLORPSticker = false;

        public string FixSpectrum()
        {
            foreach (string server in serverArray)
            {
                resetIIS();
                restartWorkFlowEngine();
            }

            return "Try it now.";
        }

        public void GoToLunch()
        {
            if (temperature < 10 && snowDepth >= 8)
            {
                Broadcast("I wanna go out for lunch. Who wants to go to lunch?");
                Invite(JimRaden);
            }
        }

        private void AccessMemory()
        {
            MemoryFailPoint = DateTime.Today.AddDays(-7);
        }
    }
}
