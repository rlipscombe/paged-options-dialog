using System.Drawing;

namespace PagedOptionsDialog
{
    internal class GeneralOptionsPage : PropertyPage
    {
        public override string Title
        {
            get { return "General"; }
        }

        public override Image Image
        {
            get { return new Bitmap(GetType(), "Bitmaps.GeneralOptionsPage.bmp"); }
        }
    }
}