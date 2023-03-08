using System.Collections.Generic;

namespace Among_Us_Config_Editor.Data
{
    public class Skins
    {
        public class Skin
            : IData
        {
            public int Id { get; set; }

            public string AmongUsValue { get; set; }

            public string DisplayValue { get; set; }
        }

        public static IEnumerable<Skin> Values { get; set; }
            = new List<Skin>() {
                new Skin()
                {
                    Id = 0,
                    AmongUsValue = "skin_None",
                    DisplayValue = "No Skin",
                }
            };
    }
}
