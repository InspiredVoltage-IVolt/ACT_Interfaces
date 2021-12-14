using System.Drawing;
using System.Drawing.Imaging;

namespace ACT.Core.Interfaces.Imaging
{
    public interface I_ImagingHelper : ACT.Core.Interfaces.Common.I_Plugin
    {
        Dictionary<string, ImageCodecInfo> Encoders { get; }
        Bitmap ResizeImage(Image Img, int Width, int Height);
        bool SaveJPG(string Path, Image Image, int Quality);
        ImageCodecInfo GetEncoderInfo(string mimeType);
    }


}
