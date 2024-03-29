﻿using Newtonsoft.Json;

namespace CrediTVAppSetup.dto
{
    public class AdbCommand
    {
        public AdbCommand(string command)
        {
            Command = command;
            Args = new List<string>();
        }
        public AdbCommand(string command, params string[] args)
        {
            Command = command;
            Args = new List<string>(args);
        }
        [JsonProperty("command")]
        public string Command { get; set; }
        [JsonProperty("args")]
        public List<string> Args { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
