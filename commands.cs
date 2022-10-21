using Discord.Interactions;
using System.Threading.Tasks;

public class Commands : InteractionModuleBase<SocketInteractionContext>
{
    [SlashCommand("ping", "Displays the ping of the bot.")]
    public async Task Ping()
    {
        await RespondAsync($"The client latency is **{Bot.Client.Latency}** ms.");
    }

    [SlashCommand("remindme", "Reminds you about something.")]
    public async Task RemindMe()
    {
        await RespondAsync("What do you want to remind me about?")
    }
}