using DSBotCsharp.Addons;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBotCsharp.Commands
{
    public class FCommands : BaseCommandModule
    {
        [Command("ping")]
        public async Task Ping(CommandContext ctx)
        {
            await ctx.RespondAsync($"Ping: **{ctx.Client.Ping}**" );
        }



        [Command("shaman")]

        public async Task Shaman(CommandContext text)
        {
            await text.RespondAsync("**Ля, Кабан** "+" https://media.giphy.com/media/mgmqtuvSDog9zT9zfW/giphy.gif");
        }

        [Command("punch")]

        public async Task Punch(CommandContext punch, DiscordMember member = null)
        {
            if (member!=null)
            {
                DiscordEmbedBuilder Embed = new DiscordEmbedBuilder
                {
                    Title = $"{punch.User.Username} ударил {member.Username}",
                    ImageUrl = CommandsHelper.GetRandomPunchURL(),
                };


                await punch.RespondAsync(Embed);
            }
            

        }


    }
}
