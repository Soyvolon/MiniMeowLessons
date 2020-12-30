using System;
using System.Collections.Generic;
using System.IO;

using Newtonsoft.Json;

namespace MiniMeowLessons.AppOne
{
    public class Program
    {
        static void Main(string[] args)
        {
            using FileStream fs = new(Path.Join("Config", "bot_config.json"), FileMode.Open);
            using StreamReader sr = new(fs);
            string json = sr.ReadToEnd();

            DiscordConfiguration config = JsonConvert.DeserializeObject<DiscordConfiguration>(json);
        }
    }
}
