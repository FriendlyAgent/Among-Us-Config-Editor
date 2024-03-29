﻿using System.Collections.Generic;

namespace Among_Us_Config_Editor.Data
{
    public class Hats
    {
        public class Hat
            : IData
        {
            public int Id { get; set; }

            public string AmongUsValue { get; set; }

            public string DisplayValue { get; set; }
        }

        public static IEnumerable<Hat> Values { get; set; }
           = new List<Hat>() {
                new Hat()
                {
                    Id = 0,
                    AmongUsValue = "hat_NoHat",
                    DisplayValue = "No Hat"
                }
           };
    }
}
