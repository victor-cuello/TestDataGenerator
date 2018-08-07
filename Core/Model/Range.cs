using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
   public class Range
    {
        public Range()
        {
        }

        public string GenerateTestRange(char initialCondition, int startValue, int endValue, char lastCondition)
        {
           List<string> result = new List<string>();
          var valor = string.Empty;
            if (initialCondition == '[' && lastCondition == '[')
            {
                for (int i = startValue; i < endValue; i++)
                {
                    result.Add(i.ToString());
                }
            }

            if (initialCondition == ']' && lastCondition == ']')
            {
                for (int i = startValue; i <= endValue; i++)
                {
                     result.Add(i.ToString());
                }
            }

             if (initialCondition == '[' && lastCondition == ']')
            {
                for (int i = startValue; i < endValue; i++)
                {
                     result.Add(i.ToString());
                }
            }

            valor = string.Join(",",result.ToArray());

            return  valor;
           //valor.Join(',',result.ToArray()).ToString();
           //result.ToString();
        }

    }
}
