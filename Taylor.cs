using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Thunderous
{
    class Taylor
    {
        public bool IsQA = true;
        public bool IsGameMaker = true;
        public string Dialogue = "Something intelligent and thoughtful";

        public string Analyze()
        {
            foreach (object field in Thunderous.Application)
            {
                EnterAllPossibleKeystrokes();
            }
            foreach (object button in Thunderous.Application)
            {
                PushButton();
            }
            return CalculateOptions();
        }

        public string Converse(object anyTeamMember)
        {
            return Dialogue;
        }
    }
}
