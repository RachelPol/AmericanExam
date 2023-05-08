using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmericanExam
{
    public class Exam
    {
        public string DisplayName { get; set; }

        private List<Question> _questions = new List<Question>();

        public List<Question> Questions
        {
            get { return _questions; }
            set { _questions = value; }
        }
    }
}
