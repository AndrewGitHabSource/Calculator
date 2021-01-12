using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Calculator
    {
        private List<float> listValues = new List<float>();
        private List<string> listOperators = new List<string>();
        public Calculator(List<float> values, List<string> operators)
        {
            this.listValues = values;
            this.listOperators = operators;
        }

        public string calculate()
        {
            string resultString = "0";
            int index = 0;
            float result = listValues.ElementAt(index);

            foreach (string operate in listOperators)
            {
                switch (operate)
                {
                    case "+":
                        result += listValues.ElementAt(index + 1);
                        break;
                    case "-":
                        result -= listValues.ElementAt(index + 1);
                        break;
                    case "*":
                        result *= listValues.ElementAt(index + 1);
                        break;
                    case "/":
                        result /= listValues.ElementAt(index + 1);
                        break;
                }

                index++;
            }

            resultString = result.ToString();

            return resultString;
        }
    }
}