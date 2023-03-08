using System.Collections.Generic;

namespace Among_Us_Config_Editor.Data
{
    public class Colors
    {
        public class Color
            : IData
        {
            public int Id { get; set; }

            public string AmongUsValue { get; set; }

            public string DisplayValue { get; set; }

        }

        public static IEnumerable<Color> Values { get; set; }
            = new List<Color>() {
                new Color()
                {
                    Id = 0,
                    AmongUsValue = "0",
                    DisplayValue = "Red",

                },
                new Color()
                {
                    Id = 1,
                    AmongUsValue = "1",
                    DisplayValue = "Blue"
                },
                new Color()
                {
                    Id = 2,
                    AmongUsValue = "2",
                    DisplayValue = "Green"
                },
                new Color()
                {
                    Id = 3,
                    AmongUsValue = "3",
                    DisplayValue = "Pink"
                },
                new Color()
                {
                    Id = 4,
                    AmongUsValue = "4",
                    DisplayValue = "Orange"
                },
                new Color()
                {
                    Id = 5,
                    AmongUsValue = "5",
                    DisplayValue = "Yellow"
                },
                new Color()
                {
                    Id = 6,
                    AmongUsValue = "6",
                    DisplayValue = "Black"
                },
                new Color()
                {
                    Id = 7,
                    AmongUsValue = "7",
                    DisplayValue = "White"
                },
                new Color()
                {
                    Id = 8,
                    AmongUsValue = "8",
                    DisplayValue = "Purple"
                },
                new Color()
                {
                    Id = 9,
                    AmongUsValue = "9",
                    DisplayValue = "Brown"
                },
                new Color()
                {
                    Id = 10,
                    AmongUsValue = "10",
                    DisplayValue = "Cyan"
                },
                new Color()
                {
                    Id = 11,
                    AmongUsValue = "11",
                    DisplayValue = "Lime"
                },
                new Color()
                {
                    Id = 12,
                    AmongUsValue = "12",
                    DisplayValue = "Maroon"
                },
                new Color()
                {
                    Id= 13,
                    AmongUsValue = "13",
                    DisplayValue = "Rose"
                },
                new Color()
                {
                    Id= 14,
                    AmongUsValue = "14",
                    DisplayValue = "Banana"
                },
                new Color()
                {
                    Id = 15,
                    AmongUsValue = "15",
                    DisplayValue = "Gray"
                },
                new Color()
                {
                    Id = 16,
                    AmongUsValue = "16",
                    DisplayValue = "Tan"
                },
                new Color()
                {
                    Id = 17,
                    AmongUsValue = "17",
                    DisplayValue = "Coral"
                },
                new Color()
                {
                    Id = 18,
                    AmongUsValue = "18",
                    DisplayValue = "Fortegreen (Glitch)"
                }
            };
    }
}
