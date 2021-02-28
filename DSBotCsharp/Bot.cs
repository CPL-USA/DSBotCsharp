﻿using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBotCsharp
{
   public class Bot
    {
        public DiscordClient Client { get; private set; }
        public CommandsNextExtension commands { get; private set; }

  

        public async Task RunAsync()
        {




            DiscordConfiguration config = new DiscordConfiguration
            {
                Token = "ODE1MDM4MzA1NzI4NDYyODc5.YDmlkg.BdmbzzpNoOocbnsu9hbtm9YrrGk",
                TokenType = TokenType.Bot,
                AutoReconnect = true,
                MinimumLogLevel=Microsoft.Extensions.Logging.LogLevel.Debug,
            };

            Client = new DiscordClient(config);

            Client.Ready += onClientReady;

            CommandsNextConfiguration commandsConfig = new CommandsNextConfiguration
            {
                StringPrefixes = new string[] { "!" },
                EnableDms=false,
                EnableMentionPrefix = true,

            };

            commands = Client.UseCommandsNext(commandsConfig);

            await Client.ConnectAsync();

            await Task.Delay(-1);

        }

        private Task onClientReady(DiscordClient sender, ReadyEventArgs e)
        {
            return Task.CompletedTask;
        }

    }
}