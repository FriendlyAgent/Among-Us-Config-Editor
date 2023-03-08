using System.Collections.Generic;

namespace Among_Us_Config_Editor.Data
{
    public class Visors
    {
        public class Visor
            : IData
        {          
            public int Id { get; set; }

            public string AmongUsValue { get; set; }

            public string DisplayValue { get; set; }
        }

        public static IEnumerable<Visor> Values { get; set; }
            = new List<Visor>() {
                new Visor()
                {
                    Id = 0,
                    AmongUsValue = "visor_EmptyVisor",
                    DisplayValue = "No Visor"
                }
            };
    }
}
