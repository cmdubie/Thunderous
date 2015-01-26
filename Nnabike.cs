namespace Thunderous
{
    class Nnabike
    {
        public bool IsGiant = true;
        public string[] _friends = new string[645128];
        public string Dialogue = "Something witty, funny, and charming";

        public string Converse(object anyone)
        {
            return Dialogue;
        }

        public object MakeFriend(object stranger)
        {
            Converse(stranger);
            return Friendship;
        }

        public void GetFamous()
        {
            var famous = BringCameraCrewToWorkAndFilmSelfLeadingImportantMeeting();

            while (!famous)
            {
                WriteProduceAndDirectMovies();
            }
        }

        public void HookUpSamer()
        {
            //TODO
        }
    }
}
