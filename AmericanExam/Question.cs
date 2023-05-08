using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmericanExam
{
    public class Question
    {
        public bool Id { get; set; }
        public string Caption { get; set; }

        private List<string> _answers = new List<string>();

        public List<string> Answers
        {
            get { return _answers; }
            set { _answers  = value; }
        }

        public int CorrectAnswer { get; set; }
      
    }
}
