using System.Drawing;

namespace Among_Us_Config_Editor.Data
{
    public interface IData
    {
        public string Name { get; set; }

        public Image ImageResource { get; }
    }
}
