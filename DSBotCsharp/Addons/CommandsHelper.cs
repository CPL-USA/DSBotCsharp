using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBotCsharp.Addons
{
    public class CommandsHelper
    {
        public static string[] punch =
        {
            "https://media.giphy.com/media/l0HlLFVBqUVwxSOzu/giphy.gif",
            "https://media.giphy.com/media/xT0BKiwgIPGShJNi0g/giphy.gif",
        };

        public static Random random = new Random();

        public static string GetRandomPunchURL()
        {
            return punch[random.Next(0, punch.Length)];
        }
    }
}
