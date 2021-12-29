using System.Drawing;
namespace ACT.Core.Interfaces.Graphics
{
    public interface I_TextureManager
    {
        object LoadImage(string filename, string ImageType, bool Save = false, string RefName = "");
        object GetImage(string name);
        object GetImage(string name, Rectangle rect);
        void SetDevice<T>(T MainDevice);
    }
}
