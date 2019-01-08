using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirusGame
{
    class Question
    {
        public int QuestionID;
        public string currentQuestion;
        public string Choice1Text;
        public string Choice2Text;
        public int Choice1Virus;
        public int Choice1Rep;
        public int Choice2Virus;
        public int Choice2Rep;
        public string Message;

        public Question(int qid, string cq, string c1t, string c2t, int c1v, int c1r, int c2v, int c2r, string m)
        {
            QuestionID = qid;
            currentQuestion = cq;
            Choice1Text = c1t;
            Choice2Text = c2t;
            Choice1Virus = c1v;
            Choice1Rep = c1r;
            Choice2Virus = c2v;
            Choice2Rep = c2r;
            Message = m;
            
        }
    }
}
