using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class StringSplitter
    {
        private string stringCalc;
        private List<float> listValues = new List<float>();
        private List<string> listOperators = new List<string>();
        public string StringCalc
        {
            get
            {
                return stringCalc;
            }

            set
            {
                stringCalc = value;
            }
        }

        public List<float> ListValues
        {
            get
            {
                return listValues;
            }

            set
            {
                listValues = value;
            }
        }

        public List<string> ListOperators
        {
            get
            {
                return listOperators;
            }

            set
            {
                listOperators = value;
            }
        }

        public void execute()
        {
            this.findSeparators();
            this.splitText();
        }

        private void splitText()
        {
            char[] separators = new char[] { '+', '-', '/', '*' };
            string[] values = this.stringCalc.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (var sub in values)
            {
                listValues.Add(Int32.Parse(sub));
            }
        }

        private void findSeparators()
        {
            for(int i = 0; i < this.stringCalc.Length; i++)
            {
                if(this.stringCalc[i] == '+' || this.stringCalc[i] == '-' || this.stringCalc[i] == '*' || this.stringCalc[i] == '/')
                {
                    listOperators.Add(Char.ToString(this.stringCalc[i]));
                }
            }
        }
    }
}