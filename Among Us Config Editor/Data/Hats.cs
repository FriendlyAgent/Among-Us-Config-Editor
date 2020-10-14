using Among_Us_Config_Editor.Properties;
using System.Collections.Generic;
using System.Drawing;

namespace Among_Us_Config_Editor
{
    public class Hats
    {
        public class Hat
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public Image ImageResource => (Image)Resources.ResourceManager.GetObject($"hat_{Id}");
        }

        public static IEnumerable<Hat> Values { get; set; }
           = new List<Hat>() {
                new Hat()
                {
                    Id = 0,
                    Name = "No Hat"
                },
                new Hat()
                {
                    Id = 1,
                    Name = "Astronaut Helmet"
                },
                new Hat()
                {
                    Id = 2,
                    Name = "Backwards Cap"
                },
                new Hat()
                {
                    Id = 3,
                    Name = "Brain Slug"
                },
                new Hat()
                {
                    Id = 4,
                    Name = "Bush Hat"
                },
                new Hat()
                {
                    Id = 5,
                    Name = "Captain Hat"
                },
                new Hat()
                {
                    Id = 6,
                    Name = "Double Top Hat"
                },
                new Hat()
                {
                    Id = 7,
                    Name = "Flowerpot Hat"
                },
                new Hat()
                {
                    Id = 8,
                    Name = "Goggles"
                },
                new Hat()
                {
                    Id = 9,
                    Name = "Hard Hat"
                },
                new Hat()
                {
                    Id = 10,
                    Name = "Military Hat"
                },
                new Hat()
                {
                    Id = 11,
                    Name = "Paper Hat"
                },
                new Hat()
                {
                    Id = 12,
                    Name = "Party Hat"
                },
                new Hat()
                {
                    Id = 13,
                    Name = "Police Hat"
                },
                new Hat()
                {
                    Id = 14,
                    Name = "Stethoscope"
                },
                new Hat()
                {
                    Id = 15,
                    Name = "Top Hat"
                },
                new Hat()
                {
                    Id = 16,
                    Name = "Towel Wizard"
                },
                new Hat()
                {
                    Id = 17,
                    Name = "Ushanka"
                },
                new Hat()
                {
                    Id = 18,
                    Name = "Viking"
                },
                new Hat()
                {
                    Id = 19,
                    Name = "Wall Guard Cap"
                },
                new Hat()
                {
                    Id = 20,
                    Name = "Snowman"
                },
                new Hat()
                {
                    Id = 21,
                    Name = "Antlers"
                },
                new Hat()
                {
                    Id = 22,
                    Name = "Christmas Lights Hat"
                },
                new Hat()
                {
                    Id = 23,
                    Name = "Santa Hat"
                },
                new Hat()
                {
                    Id = 24,
                    Name = "Christmas Tree Hat"
                },
                new Hat()
                {
                    Id = 25,
                    Name = "Present Hat"
                },
                new Hat()
                {
                    Id = 26,
                    Name = "Candy Canes Hat"
                },
                new Hat()
                {
                    Id = 27,
                    Name = "Elf Hat"
                },
                new Hat()
                {
                    Id = 28,
                    Name = "2019 Yellow Party Hat"
                },
                new Hat()
                {
                    Id = 29,
                    Name = "White Hat"
                },
                new Hat()
                {
                    Id = 30,
                    Name = "Crown"
                },
                new Hat()
                {
                    Id = 31,
                    Name = "Eyebrows"
                },
                new Hat()
                {
                    Id = 32,
                    Name = "Angel Halo"
                },
                new Hat()
                {
                    Id = 33,
                    Name = "Elf Cap"
                },
                new Hat()
                {
                    Id = 34,
                    Name = "Flat Cap"
                },
                new Hat()
                {
                    Id = 35,
                    Name = "Plunger"
                },
                new Hat()
                {
                    Id = 36,
                    Name = "Snorkel"
                },
                new Hat()
                {
                    Id = 37,
                    Name = "Stickmin Figure"
                },
                new Hat()
                {
                    Id = 38,
                    Name = "Straw Hat"
                },
                new Hat()
                {
                    Id = 39,
                    Name = "Sheriff Hat"
                },
                new Hat()
                {
                    Id = 40,
                    Name = "Eyeball Lamp"
                },
                new Hat()
                {
                    Id = 41,
                    Name = "Toilet Paper Hat"
                },
                new Hat()
                {
                    Id = 42,
                    Name = "Toppat Clan Leader Hat"
                },
                new Hat()
                {
                    Id = 43,
                    Name = "Black Fedora"
                },
                new Hat()
                {
                    Id = 44,
                    Name = "Ski Goggles"
                },
                new Hat()
                {
                    Id = 45,
                    Name = "Landing Headset"
                },
                new Hat()
                {
                    Id = 46,
                    Name = "MIRA Hazmat Mask"
                },
                new Hat()
                {
                    Id = 47,
                    Name = "Medical Mask"
                },
                new Hat()
                {
                    Id = 48,
                    Name = "MIRA Security Cap"
                },
                new Hat()
                {
                    Id = 49,
                    Name = "Safari Hat"
                },
                new Hat()
                {
                    Id = 50,
                    Name = "Banana Hat"
                },
                new Hat()
                {
                    Id = 51,
                    Name = "Beanie"
                },
                new Hat()
                {
                    Id = 52,
                    Name = "Bear Ears"
                },
                new Hat()
                {
                    Id = 53,
                    Name = "Cheese Hat"
                },
                new Hat()
                {
                    Id = 54,
                    Name = "Cherry Hat"
                },
                new Hat()
                {
                    Id = 55,
                    Name = "Egg Hat"
                },
                new Hat()
                {
                    Id = 56,
                    Name = "Green Fedora"
                },
                new Hat()
                {
                    Id = 57,
                    Name = "Flamingo Hat"
                },
                new Hat()
                {
                    Id = 58,
                    Name = "Flower Hat"
                },
                new Hat()
                {
                    Id = 59,
                    Name = "Knight Helmet"
                },
                new Hat()
                {
                    Id = 60,
                    Name = "Plant Hat"
                },
                new Hat()
                {
                    Id = 61,
                    Name = "Cat Head Hat"
                },
                new Hat()
                {
                    Id = 62,
                    Name = "Bat Wings"
                },
                new Hat()
                {
                    Id = 63,
                    Name = "Devil Horns"
                },
                new Hat()
                {
                    Id = 64,
                    Name = "Mohawk"
                },
                new Hat()
                {
                    Id = 65,
                    Name = "Pumpkin Hat"
                },
                new Hat()
                {
                    Id = 66,
                    Name = "Spooky Paper Bag Hat"
                },
                new Hat()
                {
                    Id = 67,
                    Name = "Witch Hat"
                },
                new Hat()
                {
                    Id = 68,
                    Name = "Wolf Ears"
                },
                new Hat()
                {
                    Id = 69,
                    Name = "Pirate Hat"
                },
                new Hat()
                {
                    Id = 70,
                    Name = "Plague Doctor Mask"
                },
                new Hat()
                {
                    Id = 71,
                    Name = "Knife Hat"
                },
                new Hat()
                {
                    Id = 72,
                    Name = "Hockey Mask"
                },
                new Hat()
                {
                    Id = 73,
                    Name = "Miner Gear Hat"
                },
                new Hat()
                {
                    Id = 74,
                    Name = "Miner Gear Hat"
                },
                new Hat()
                {
                    Id = 75,
                    Name = "Archaeologist Hat"
                },
                new Hat()
                {
                    Id = 76,
                    Name = "Antenna"
                },
                new Hat()
                {
                    Id = 77,
                    Name = "Balloon"
                },
                new Hat()
                {
                    Id = 78,
                    Name = "Bird Nest"
                },
                new Hat()
                {
                    Id = 79,
                    Name = "Black Bandanna"
                },
                new Hat()
                {
                    Id = 80,
                    Name = "Caution Sign Hat"
                },
                new Hat()
                {
                    Id = 81,
                    Name = "Chef Hat"
                },
                new Hat()
                {
                    Id = 82,
                    Name = "CCC Cap"
                },
                new Hat()
                {
                    Id = 83,
                    Name = "Do-rag"
                },
                new Hat()
                {
                    Id = 84,
                    Name = "Dum Sticky Note"
                },
                new Hat()
                {
                    Id = 85,
                    Name = "Fez"
                },
                new Hat()
                {
                    Id = 86,
                    Name = "General Hat"
                },
                new Hat()
                {
                    Id = 87,
                    Name = "Pompadour"
                },
                new Hat()
                {
                    Id = 88,
                    Name = "Hunter Hat"
                },
                new Hat()
                {
                    Id = 89,
                    Name = "Military Helmet"
                },
                new Hat()
                {
                    Id = 90,
                    Name = "Mini Crewmate"
                },
                new Hat()
                {
                    Id = 91,
                    Name = "Ninja Mask"
                },
                new Hat()
                {
                    Id = 92,
                    Name = "Ram Horns"
                },
                new Hat()
                {
                    Id = 93,
                    Name = "Snow Crewmate"
                }
           };
    }
}
