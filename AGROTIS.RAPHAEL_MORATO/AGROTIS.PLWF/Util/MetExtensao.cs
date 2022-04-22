using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGROTIS.PLWF.Util
{
    public static class MetExtensao
    {
        public static int ToInt(this string txt)
        {
            return ConvertStringToInt(txt);
        }
        private static int ConvertStringToInt(string text)
        {
            int result = 0;
            if (string.IsNullOrEmpty(text))
            {
                return result;
            }
            else
            {
                int.TryParse(text, out result);
                return result;
            }
        }

        public static decimal ToDecimal(this string txt)
        {
            return ConvertStringToDecimal(txt);
        }
        private static decimal ConvertStringToDecimal(string text)
        {
            decimal result = 0;
            if (string.IsNullOrEmpty(text))
            {
                return result;
            }
            else
            {
                decimal.TryParse(text, out result);
                return result;
            }
        }
    }
}
