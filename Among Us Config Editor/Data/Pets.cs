using Among_Us_Config_Editor.Properties;
using System.Collections.Generic;
using System.Drawing;

namespace Among_Us_Config_Editor.Data
{
    public class Pets
    {
        public class Pet
            : IData
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public Image ImageResource => (Image)Resources.ResourceManager.GetObject($"pet_{Id}");
        }

        public static IEnumerable<Pet> Values { get; set; }
          = new List<Pet>() {
                new Pet()
                {
                    Id = 0,
                    Name = "No Pet"
                },
                new Pet()
                {
                    Id = 1,
                    Name = "Brainslug"
                },
                new Pet()
                {
                    Id = 2,
                    Name = "Mini Crewmate"
                },
                new Pet()
                {
                    Id = 3,
                    Name = "Dog"
                },
                new Pet()
                {
                    Id = 4,
                    Name = "Henry"
                },
                new Pet()
                {
                    Id = 5,
                    Name = "Hamster"
                },
                new Pet()
                {
                    Id = 6,
                    Name = "Robot"
                },
                new Pet()
                {
                    Id = 7,
                    Name = "UFO"
                },
                new Pet()
                {
                    Id = 8,
                    Name = "Ellie"
                },
                new Pet()
                {
                    Id = 9,
                    Name = "Squig"
                },
                new Pet()
                {
                    Id = 10,
                    Name = "Bedcrab"
                },
                new Pet()
                {
                    Id = 11,
                    Name = "Glitch Pet"
                }
          };
    }
}
