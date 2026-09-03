using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dalek_V_Cybermen
{
    [Serializable]
    public class Player_Class
    {
        //player variables
        private string _username;
        private string _yearGroup;
        private int _quizScore;
        private int _gameScore;
        private string _favSubject;
        private int _totQues;
        private string _playerDif;

        //default constructor
        public Player_Class()
        {
            Username = "";
            QuizScore = 0;
            GameScore = 0;
            FavSubject = "";
            TotQues = 0;
            YearGroup = "";
            PlayerDif = "";
        }

        //field constructor
        public Player_Class(string username, int quizScore, int gameScore, string favSubject, int totQues, string yearGroup, string playerDif)
        {
            Username = username;
            QuizScore = quizScore;
            GameScore = gameScore;
            FavSubject = favSubject;
            TotQues = totQues;
            YearGroup = yearGroup;
            PlayerDif = playerDif;
        }

        //getters and setters
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public int QuizScore
        {
            get { return _quizScore; }
            set { _quizScore = value; }
        }
        public int GameScore
        {
            get { return _gameScore; }
            set { _gameScore = value; }
        }

        public string FavSubject
        {
            get { return _favSubject; }
            set { _favSubject = value; }
        }

        public int TotQues
        {
            get { return _totQues; }
            set { _totQues = value; }
        }

        public string YearGroup
        {
            get { return _yearGroup; }
            set { _yearGroup = value; }
        }

        public string PlayerDif
        {
            get { return _playerDif; }
            set { _playerDif = value; }
        }
    }
}
