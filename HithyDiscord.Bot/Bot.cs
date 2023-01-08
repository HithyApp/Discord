using HithyDiscord.Bot.Events;

namespace HithyDiscord.Bot;

using DSharpPlus;

public class Bot
{
    private DiscordClient _client;
    
    public async Task StartBot()
    {
        await _client.ConnectAsync();
        await Task.Delay(-1);
    }
    
    public Bot(String token, String[] supportChannels)
    {
        MessageCreate.SupportChannels = supportChannels;
        
        _client = new DiscordClient(new DiscordConfiguration()
        {
            Token = token,
            TokenType = TokenType.Bot,
            Intents = DiscordIntents.AllUnprivileged
        });

        _client.MessageCreated += MessageCreate.MessageCreateEvent;
        
        StartBot().GetAwaiter().GetResult();
    }
}