using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Xem_Ngay.ultility
{
    public class RegexUtil
    {
        private static Regex REGEX_NUMBER = new Regex(@"^[\d]+((\.|\,)\d+)?$");
        private static Regex REGEX_NAM = new Regex(@"^[1|2][9|0]\d{2}$");

        public static bool isNumber(String sNumber)
        {
            return REGEX_NUMBER.IsMatch(sNumber);
        }
        public static bool laNam(String sNumber)
        {
            return REGEX_NAM.IsMatch(sNumber);
        }
        public static bool laToaDo(String sNumber)
        {
            if (REGEX_NUMBER.IsMatch(sNumber) == false) return false;
            double doSo = Convert.ToDouble(sNumber);
            if (doSo >= 0 && doSo <= 359.9999999999) return true;
            return false;
        }
    }
}
