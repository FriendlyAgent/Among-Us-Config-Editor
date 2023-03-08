using Newtonsoft.Json;
using System.Collections.Generic;

namespace Among_Us_Config_Editor
{
    public class Accessibility
    {
        [JsonProperty("colorBlindMode")]
        public bool ColorBlindMode { get; set; }
    }

    public class Audio
    {
        [JsonProperty("musicVolume")]
        public double MusicVolume { get; set; }

        [JsonProperty("sfxVolume")]
        public double SfxVolume { get; set; }
    }

    public class Gameplay
    {
        [JsonProperty("screenShake")]
        public bool ScreenShake { get; set; }

        [JsonProperty("streamerMode")]
        public bool StreamerMode { get; set; }
    }

    public class Input
    {
        [JsonProperty("inputMode")]
        public int InputMode { get; set; }

        [JsonProperty("mouseMovementEnabled")]
        public bool MouseMovementEnabled { get; set; }

        [JsonProperty("touchJoystickSize")]
        public double TouchJoystickSize { get; set; }
    }

    public class Language
    {
        [JsonProperty("currentLanguage")]
        public Languages CurrentLanguage { get; set; }
    }

    public class Multiplayer
    {
        [JsonProperty("crossPlay")]
        public bool CrossPlay { get; set; }

        [JsonProperty("allowFriendInvites")]
        public bool AllowFriendInvites { get; set; }

        [JsonProperty("censorChat")]
        public bool CensorChat { get; set; }

        [JsonProperty("chatMode")]
        public int ChatMode { get; set; }

        [JsonProperty("quickChatFavorites")]
        public List<object> QuickChatFavorites { get; set; }

        [JsonProperty("hostOptions")]
        public string HostOptions { get; set; }

        [JsonProperty("searchOptions")]
        public string SearchOptions { get; set; }
    }

    public class Video
    {
        [JsonProperty("vsync")]
        public bool Vsync { get; set; }
    }

    public class Settings
    {
        [JsonProperty("gameplay")]
        public Gameplay Gameplay { get; set; }

        [JsonProperty("accessibility")]
        public Accessibility Accessibility { get; set; }

        [JsonProperty("audio")]
        public Audio Audio { get; set; }

        [JsonProperty("video")]
        public Video Video { get; set; }

        [JsonProperty("language")]
        public Language Language { get; set; }

        [JsonProperty("input")]
        public Input Input { get; set; }

        [JsonProperty("multiplayer")]
        public Multiplayer Multiplayer { get; set; }

        [JsonProperty("dataVersion")]
        public int DataVersion { get; set; }
    }
}