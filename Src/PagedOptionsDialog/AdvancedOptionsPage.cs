using System.Drawing;

namespace PagedOptionsDialog
{
    internal class AdvancedOptionsPage : PropertyPage
    {
        public override string Title
        {
            get { return "Advanced"; }
        }

        public override Image Image
        {
            get { return new Bitmap(GetType(), "Bitmaps.AdvancedOptionsPage.bmp"); }
        }
    }
}