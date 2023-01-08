using DSharpPlus;
using DSharpPlus.Entities;
using DSharpPlus.EventArgs;

namespace HithyDiscord.Bot.Events;

public static class MessageCreate
{
    public static String[]? SupportChannels;

    public static async Task MessageCreateEvent(DiscordClient client, MessageCreateEventArgs args)
    {
        if (SupportChannels.Contains(args.Channel.Id.ToString()) && !args.Author.IsBot)
        {
            await args.Channel.CreateThreadAsync(args.Message,
                ("Support - " + args.Author.Username),
                AutoArchiveDuration.ThreeDays);
        }
    }
}