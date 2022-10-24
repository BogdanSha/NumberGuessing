using System.Drawing;

namespace Grayscale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bitmap Img = new Bitmap("Caption1.png");
            Bitmap GrayImg;
            int x, y;
            for(x = 0; x < Img.Width; x++)
                for(y = 0; y < Img.Height; y++)
                {
                    Color pixelColor=Img.GetPixel(x, y);
                    Color newColor=Color.FromArgb(pixelColor.R, 0,0);
                    Img.SetPixel(x, y, newColor);
                }
            GrayImg = Img;
        }
    }
}