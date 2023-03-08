using System.Collections.Generic;

namespace Among_Us_Config_Editor.Data
{
    public class Pets
    {
        public class Pet
            : IData
        {
            public int Id { get; set; }

            public string AmongUsValue { get; set; }

            public string DisplayValue { get; set; }
        }

        public static IEnumerable<Pet> Values { get; set; }
          = new List<Pet>() {
                new Pet()
                {
                    Id = 0,
                    AmongUsValue = "pet_EmptyPet",
                    DisplayValue = "No Pet"
                }
          };
    }
}
