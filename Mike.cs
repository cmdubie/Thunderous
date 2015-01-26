namespace Thunderous
{
    class Mike
    {
        public bool IsVBGuy = true;
        public bool HasTwoCellPhones = true;

        public string DocumentPhoenix()
        {
            return "Lots of VB documentation";
        }

        public void FixPhoenix()
        {
            WalkToPhoenixLab();
            TakeBreak();
            ContinueWalkingToPhoenixLab();
            AttemptToControlHeatInPhoenixLab();
            DeviseIngeniusVBSolution() || SendCorrectFilesToStore();
        }
        
        public string SwapAgeSpecificStories(string story)
        {
            if (story == "military")
            {
                return "When I was in the military. . .";
            }
            if (story == "childhood")
            {
                return "Life as a kid in the 70's and 80's was great. . .";
            }
        }
    }
}
