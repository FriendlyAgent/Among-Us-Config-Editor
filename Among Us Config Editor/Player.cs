using Newtonsoft.Json;

namespace Among_Us_Config_Editor
{
    public class Account
    {
        [JsonProperty("loginStatus")]
        public int LoginStatus { get; set; }

        [JsonProperty("guardianEmail")]
        public string GuardianEmail { get; set; }

        [JsonProperty("deleteDeviceIDFailed")]
        public bool DeleteDeviceIDFailed { get; set; }
    }

    public class Customization
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("colorID")]
        public string ColorID { get; set; }

        [JsonProperty("pet")]
        public string Pet { get; set; }

        [JsonProperty("hat")]
        public string Hat { get; set; }

        [JsonProperty("skin")]
        public string Skin { get; set; }

        [JsonProperty("visor")]
        public string Visor { get; set; }

        [JsonProperty("namePlate")]
        public string NamePlate { get; set; }
    }

    public class Onboarding
    {
        [JsonProperty("privacyPolicyVersion")]
        public int PrivacyPolicyVersion { get; set; }

        [JsonProperty("viewedOnlineHelpMessage")]
        public bool ViewedOnlineHelpMessage { get; set; }

        [JsonProperty("viewedMinPlayerWarning")]
        public bool ViewedMinPlayerWarning { get; set; }

        [JsonProperty("alwaysShowMinPlayerWarning")]
        public bool AlwaysShowMinPlayerWarning { get; set; }
    }

    public class Stats
    {
        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("xp")]
        public int Xp { get; set; }

        [JsonProperty("xpForNextLevel")]
        public int XpForNextLevel { get; set; }
    }

    public class Player
    {
        [JsonProperty("account")]
        public Account Account { get; set; }

        [JsonProperty("customization")]
        public Customization Customization { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("onboarding")]
        public Onboarding Onboarding { get; set; }

        [JsonProperty("age")]
        public string Age { get; set; }

        [JsonProperty("store")]
        public string Store { get; set; }

        [JsonProperty("ads")]
        public string Ads { get; set; }

        [JsonProperty("dataVersion")]
        public int DataVersion { get; set; }
    }
}
