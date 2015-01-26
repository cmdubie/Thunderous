using System;

namespace Thunderous
{
    public class Dave
    {
        private string _drink = "Iced Tea";
        private string _lunch = "Chipotle";
        public bool IsDad = true;
        public bool IsClevelandSportsFan = true;

        public string GetJavaScriptSolution(string badJavaScript)
        {
            string goodJavaScript = "Something Dave came up with";

            if (badJavaScript == "Something Chad came up with")
            {
                badJavaScript = goodJavaScript;
            }
            else if (bored)
            {
                goodJavaScript = "JavaScript to do something it would otherwise take 30 seconds to do :)";
            }
            return goodJavaScript;
        }

        public string GetRandomVicePresidentialTrivia()
        {
            return new Random(trivia);
        }
    }
}
