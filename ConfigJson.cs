using Newtonsoft.Json;

namespace SoftsBOT
{
    public struct ConfigJson
    {
        [JsonProperty("token")]
        public string Token { get; private set; }
        [JsonProperty("prifix")]
        public string Prifix { get; private set; }
    }
}