using DSharpPlus.CommandsNext;
using DSharpPlus.Entities;
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
            "https://media.giphy.com/media/l2JJF43VQ2OTwwcOk/giphy.gif",
            "https://media.giphy.com/media/sRgD8LyikpFO8/giphy.gif",
            "https://media.giphy.com/media/8wzzij0RpFJBK/giphy.gif",
            "https://media.giphy.com/media/HPn7afVVAZbCSVeeYX/giphy.gif"

        };

        public static Random random = new Random();

        public static string GetRandomPunchURL()
        {
            return punch[random.Next(0, punch.Length)];
        }

        public static async Task ClearChat(DiscordChannel discordChannel,int count=1)
        {
            await discordChannel.DeleteMessagesAsync(discordChannel.GetMessagesAsync(count).Result);
        }

      
    }
}
