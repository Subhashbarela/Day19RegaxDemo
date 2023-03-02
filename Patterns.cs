﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegaxDemoConcept
{
    internal class Patterns
    {
        public static string REGEX_PIN = "^(?=.*[A-Z])(?=.*\\d).{8,}$";

        public bool validate(string name)
        {
            return Regex.IsMatch(name, REGEX_PIN);
        }
    }
}
