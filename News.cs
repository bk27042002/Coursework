using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    class News : IComparable<News>
    {
        private string _heading;
        private DateTime _date;
        private string _author;
        private string _body;
        private int _votes;

        public string Heading { get { return _heading; } }
        public string Author { get { return _author; } }
        public string Body { get { return _body; } }
        public DateTime Date { get { return _date.Date; } }
        public int Votes { get { return _votes; } }
        public string SaveString { get { return _heading + ";" + _date.ToString() + ";" + _author + ";" + _body + ";" + _votes.ToString(); } }
        public string OutString { get { return _date.ToShortDateString() + " " + _author + " " + _heading + " Голосов: " + _votes.ToString(); } }
        public string HeadString { get { return _date.ToShortDateString() + " " + _heading + " " + _votes.ToString(); } }
        public News() { }

        public News(string heading, DateTime date, string author, string body, int votes)
        {
            _heading = heading;
            _date = date;
            _author = author;
            _body = body;
            _votes = votes;
        }

        public bool Compare(News news)
        {
            if (_heading == news._heading && _date == news._date && _author == news._author)
                return true;
            return false;
        }

        public News(string info)
        {
            string[] infoParts = info.Split(';');
            _heading = infoParts[0];
            _date = DateTime.Parse(infoParts[1]);
            _author = infoParts[2];
            _body = infoParts[3];
            _votes = Int32.Parse(infoParts[4]);
        }

        public void GiveVote()
        {
            _votes++;
        }

        public int CompareTo(News other)
        {
            if (_votes > other._votes)
                return -1;
            if (_votes == other._votes)
                return 0;
            return 1;
        }
    }
}
