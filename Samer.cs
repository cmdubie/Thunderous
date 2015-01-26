using System;

namespace Thunderous
{
    internal class Samer
    {
        public int Volume = 2;

        private readonly string[] _samerism =
        {
            "Cross your fingers.", "Life is too short.",
            "This is true.", "This is not possible.",
            "I don't think children should learn this [FiM++].  It will ruin their life."
        };

        private bool _hasLeakyCeiling = true;

        public static void CheckForPasskey(string name)
        {
            if (!name.hasPasskey)
            {
                sendText(!name, "Can you come and open the door for me?");
            }
        }

        public string ChooseWordsCarefully()
        {
            return Random(_samerism);
        }

        public string FindSize()
        {
            if (!S && !M)
            {
                Volume = 7;
                return "Do you have any S and M?";
            }
            return ChooseWordsCarefully();
        }
    }
}
