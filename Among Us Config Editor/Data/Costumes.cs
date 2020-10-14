using Among_Us_Config_Editor.Properties;
using System.Collections.Generic;
using System.Drawing;

namespace Among_Us_Config_Editor.Data
{
    public class Costumes
    {
        public class Costume
            : IData
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public Image ImageResource => (Image)Resources.ResourceManager.GetObject($"costume_{Id}");
        }

        public static IEnumerable<Costume> Values { get; set; }
            = new List<Costume>() {
                new Costume()
                {
                    Id = 0,
                    Name = "No Costume"
                },
                new Costume()
                {
                    Id = 1,
                    Name = "Astronaut"
                },
                new Costume()
                {
                    Id = 2,
                    Name = "Captain"
                },
                new Costume()
                {
                    Id = 3,
                    Name = "Mechanic"
                },
                new Costume()
                {
                    Id = 4,
                    Name = "Military"
                },
                new Costume()
                {
                    Id = 5,
                    Name = "Police"
                },
                new Costume()
                {
                    Id = 6,
                    Name = "Doctor"
                },
                new Costume()
                {
                    Id = 7,
                    Name = "Black Suit"
                },
                new Costume()
                {
                    Id = 8,
                    Name = "White Suit"
                },
                new Costume()
                {
                    Id = 9,
                    Name = "Wall Guard Suit"
                },
                new Costume()
                {
                    Id = 10,
                    Name = "MIRA Hazmat"
                },
                new Costume()
                {
                    Id = 11,
                    Name = "MIRA Security Guard"
                },
                new Costume()
                {
                    Id = 12,
                    Name = "MIRA Landing"
                },
                new Costume()
                {
                    Id = 13,
                    Name = "Miner Gear"
                },
                new Costume()
                {
                    Id = 14,
                    Name = "Winter Gear"
                },
                new Costume()
                {
                    Id = 15,
                    Name = "Archaelogist"
                }
    };
    }
}
