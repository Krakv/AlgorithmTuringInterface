using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmTuringInterface
{
    public class Data
    {
        public static string[] quantities = { "Q1", "Q2", "Q3", "Q4", "Q5" };
        public static Dictionary<string, List<string>> actions = new Dictionary<string, List<string>>();
        public static Dictionary<long, string> tape = new Dictionary<long, string>();
    }
}
