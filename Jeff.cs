using System;
using System.Data.SqlClient;
using System.Linq;

namespace Thunderous
{
    class Jeff
    {
        private static int _experience = 16;
        public bool IsDad = true;
        public bool LikesLongWeekends = true;
        private string[] _tableNames = new string[4982];


        public void RemoveObstacles(object obstacle)
        {
            if (_experience > obstacle.difficulty)
            {
                obstacle = typeof (IDisposable);
            }
            else
            {
                // this block should never be accessed
                obstacle = typeof (IDisposable);
            }
        }

        public void UpdateBoard(string[] cards)
        {
            cards.Count();
            cards.Rank();
            cards.OrderBy(rank);
        }

        public string PullQueryOutOfAss()
        {
            var query = SqlCommandBuilder + _tableNames[GetIndex()];
            return query;
        }
    }
}
