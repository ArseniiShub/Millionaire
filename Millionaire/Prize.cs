using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire
{
    static class Prize
    {
        public static int GetPrize(int questionNum)
        {
            if (questionNum == 15)
                return 1000000;
            else if (questionNum >= 10)
                return 32000;
            else if (questionNum >= 5)
                return 1000;
            else return 0;
        }

        public static int GetCurrentPrize(int questionNum)
        {
            switch (questionNum)
            {
                case 0: case 1: case 2: case 3: return questionNum * 100;
                case 4: return 500;
                case 5: case 6: case 7: case 8: case 9: case 10: case 11: return GetCurrentPrize(questionNum - 1) * 2;
                case 12: return 125000;
                default: return GetCurrentPrize(questionNum - 1) * 2;
            }
        }
    }
}
