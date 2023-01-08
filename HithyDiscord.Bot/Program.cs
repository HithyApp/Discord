using dotenv.net;
using HithyDiscord.Bot;

DotEnv.Load();
var env = DotEnv.Read();

if (env.ContainsKey("TOKEN") && env.ContainsKey("SUPPORT_CHANNELS"))
{
    new Bot(env["TOKEN"], env["SUPPORT_CHANNELS"].Split(","));
}
else
{
    Console.WriteLine("Please provide all needed env-variables!");
}