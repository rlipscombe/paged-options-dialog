using System.Drawing;

namespace PagedOptionsDialog
{
    internal class EmailOptionsPage : PropertyPage
    {
        public override string Title
        {
            get { return "E-Mail"; }
        }

        public override Image Image
        {
            get { return new Bitmap(GetType(), "Bitmaps.EmailOptionsPage.bmp"); }
        }
    }
}