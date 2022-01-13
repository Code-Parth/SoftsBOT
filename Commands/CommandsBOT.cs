using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using DSharpPlus.Interactivity.Extensions;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SoftsBOT.Commands
{
    public class CommandsBOT : BaseCommandModule
    {
        [Command("ping")]
        [Description("Returns Pong")]
        public async Task Ping(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Pong").ConfigureAwait(false);
        }

        [Command("responseMessage")]
        public async Task ResponseMessage(CommandContext ctx)
        {
            var interactivity = ctx.Client.GetInteractivity();
            var message = await interactivity.WaitForMessageAsync(x => x.Channel == ctx.Channel).ConfigureAwait(false);
            await ctx.Channel.SendMessageAsync(message.Result.Content);
        }

        [Command("responseEmoji")]
        public async Task ResponseEmoji(CommandContext ctx)
        {
            var interactivity = ctx.Client.GetInteractivity();
            var message = await interactivity.WaitForReactionAsync(x => x.Channel == ctx.Channel).ConfigureAwait(false);
            await ctx.Channel.SendMessageAsync(message.Result.Emoji);
        }

        //Error Code is Updating
        //[Command("poll")]
        //public async Task Poll(CommandContext ctx ,TimeSpan duration ,params DiscordEmoji[] EmojiOptions)
        //{
        //    var interactivity = ctx.Client.GetInteractivity();
        //    var options = EmojiOptions.Select(x => x.ToString());
        //    var pollEmbed = new DiscordEmbedBuilder
        //    {
        //        Title = "Poll",
        //        Description = string.Join(" ", options)
        //    };
        //    var pollMessage = await ctx.Channel.SendMessageAsync(embed : pollEmbed).ConfigureAwait(false);
        //    foreach(var option in EmojiOptions)
        //    {
        //        await pollMessage.CreateReactionAsync(option).ConfigureAwait(false);
        //    }
        //    var result = await interactivity.CollectReactionsAsync(pollMessage, duration).ConfigureAwait(false);
        //    var distinctResult = result.Distinct();
        //    var results = distinctResult.Select(x => $"{x.Emoji}:{x.Total}");
        //    await ctx.Channel.SendMessageAsync(string.Join("\n", results)).ConfigureAwait(false);
        //}
    }
}