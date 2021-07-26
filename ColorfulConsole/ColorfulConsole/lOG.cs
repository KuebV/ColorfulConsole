using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorfulConsole
{
    public class Log
    {
        public static void Info(string text) => ColorfulConsole.WriteLine(text, ConsoleColor.Cyan);
        public static void Error(string text) => ColorfulConsole.WriteLine(string.Format("[Error] {0}", text), ConsoleColor.Red);
        public static void Debug(string text) => ColorfulConsole.Write(string.Format("[Debug] {0}", text), ConsoleColor.Yellow);
    }
}
