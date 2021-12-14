using System.Drawing;

namespace ACT.Core.Interfaces.Graphics
{

    public interface I_Graphic
    {
        void InitGraphic(int Width, int Height);

        void AddImage(byte[] ImageData, string ImageType);

        void DrawImage(int x, int y);
        void DrawImage(int x, int y, int width, int height);
        void DrawImage(int x, int y, I_Effect[] Effects);

        void DrawRectangle(int x, int y, Rectangle r, System.Drawing.Color c, int LineWidth, bool InsideBoundry = true);
        void DrawLine(int x, int y, int x2, int y2, System.Drawing.Color c, int LineWidth, bool InsideBoundry = true);
    }
    public interface I_Effect
    {

    }
}
