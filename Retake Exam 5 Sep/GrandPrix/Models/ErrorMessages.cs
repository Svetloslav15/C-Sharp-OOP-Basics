using System;
using System.Collections.Generic;
using System.Text;

namespace GrandPrix.Models
{
    public static class ErrorMessages
    {
        public static string BlownTyre => "Blown Tyre";
        public static string OutOfFuel => "Out of fuel";
        public static string Crash => "Crashed";
        public static string InvalidLAPS => "There is no time! On lap {0}.";
    }
}