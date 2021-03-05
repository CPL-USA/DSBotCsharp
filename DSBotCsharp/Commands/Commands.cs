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
            DiscordEmbedBuilder embedBuilder = new DiscordEmbedBuilder
            {
                Title = $"```PING:{ctx.Client.Ping}```",
                Author = new DiscordEmbedBuilder.EmbedAuthor
                {
                    IconUrl = ctx.User.AvatarUrl,
                    Name = ctx.User.Username,
                    
                },
                Color = DiscordColor.Yellow,

            };
            await ctx.RespondAsync(embedBuilder);
        }

        [Command("shaman")]
        public async Task Shaman(CommandContext text)
        {
                DiscordEmbedBuilder embed = new DiscordEmbedBuilder
                {
                    Description = "**A fucking boar!**",
                    ImageUrl = "https://media.giphy.com/media/mgmqtuvSDog9zT9zfW/giphy.gif",
                    Color = DiscordColor.Black,
                };
            await text.RespondAsync(embed);
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
                    Color = DiscordColor.Red,
                };
                await punch.RespondAsync(Embed);
            }
            else
            {
                await punch.RespondAsync("```YAML\nУкажите пользователя!```");
            }
        }

        [Command("clear")]
   
        public async Task Clear(CommandContext clear, int count=1 )
        {

            await CommandsHelper.ClearChat(clear.Channel, count);
            await clear.RespondAsync($"```{clear.User.Username} удалил {count} сообщений.```");
        }

        [Command("avatar")]
        public async Task ExecuteCommandAvatar(CommandContext context, DiscordMember member = null)
        {
            if (context.Channel.Name == context.Channel.Name)
            {
                DiscordEmbedBuilder embedBuilder = null;
                if (member != null)
                {
                    embedBuilder = new DiscordEmbedBuilder
                    {
                        Title = "Avatar",
                        ImageUrl = member.AvatarUrl,

                        Author = new DiscordEmbedBuilder.EmbedAuthor
                        {
                            IconUrl = member.AvatarUrl,
                            Name = member.Username,
                        },
                        Color = DiscordColor.CornflowerBlue,
                    };
                }
                else
                {
                    embedBuilder = new DiscordEmbedBuilder
                    {
                        Title = "Avatar",
                        ImageUrl = context.User.AvatarUrl,

                        Author = new DiscordEmbedBuilder.EmbedAuthor
                        {
                            IconUrl = context.User.AvatarUrl,
                            Name = context.User.Username,
                        },
                        Color = DiscordColor.CornflowerBlue,
                    };
                }

                await context.RespondAsync(embed: embedBuilder).ConfigureAwait(false);
            }
        }
    }


}
