using System.Drawing;

namespace Among_Us_Config_Editor.Data
{
    public interface IData
    {
        public int Id { get; set; }

        public string AmongUsValue { get; set; }

        public string DisplayValue { get; set; }
    }
}
