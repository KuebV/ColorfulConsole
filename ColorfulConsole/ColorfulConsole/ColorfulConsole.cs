using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorfulConsole
{
    public class ColorfulConsole
    {
        public static void WriteLine(string text, ConsoleColor? TextColor = null, bool stayColored = false)
        {
            if (text == null) return;
            if (TextColor != null)
            {
                Console.ForegroundColor = TextColor.Value;
            }
            Console.WriteLine(text);

            if (!stayColored)
                Console.ForegroundColor = ConsoleColor.White;

        }

        public static void Write(string text, ConsoleColor? TextColor = null, bool stayColored = false)
        {
            if (text == null) return;
            if (TextColor != null)
            {
                Console.ForegroundColor = TextColor.Value;
            }
            Console.Write(text);

            if (!stayColored)
                Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
