using Among_Us_Config_Editor.Properties;
using System.Collections.Generic;
using System.Drawing;

namespace Among_Us_Config_Editor.Data
{
    public class Colors
    {
        public class Color
            : IData
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public Image ImageResource => (Image)Resources.ResourceManager.GetObject($"color_{Id}");
        }

        public static IEnumerable<Color> Values { get; set; }
            = new List<Color>() {
                new Color()
                {
                    Id = 0,
                    Name = "Red"
                },
                new Color()
                {
                    Id = 1,
                    Name = "Blue"
                },
                new Color()
                {
                    Id = 2,
                    Name = "Green"
                },
                new Color()
                {
                    Id = 3,
                    Name = "Pink"
                },
                new Color()
                {
                    Id = 4,
                    Name = "Orange"
                },
                new Color()
                {
                    Id = 5,
                    Name = "Yellow"
                },
                new Color()
                {
                    Id = 6,
                    Name = "Black"
                },
                new Color()
                {
                    Id = 7,
                    Name = "White"
                },
                new Color()
                {
                    Id = 8,
                    Name = "Purple"
                },
                new Color()
                {
                    Id = 9,
                    Name = "Brown"
                },
                new Color()
                {
                    Id = 10,
                    Name = "Cyan"
                },
                new Color()
                {
                    Id = 11,
                    Name = "Lime"
                },
                new Color()
                {
                    Id = 12,
                    Name = "Maroon"
                },
                new Color()
                {
                    Id = 13,
                    Name = "Rose"
                },
                new Color()
                {
                    Id = 14,
                    Name = "Banana"
                },
                new Color()
                {
                    Id = 15,
                    Name = "Gray"
                },
                new Color()
                {
                    Id = 16,
                    Name = "Tan"
                },
                new Color()
                {
                    Id = 17,
                    Name = "Coral"
                },
                new Color()
                {
                    Id = 18,
                    Name = "Fortegreen (Glitch)"
                }
            };
    }
}
