using System.Drawing;

namespace PagedOptionsDialog
{
    internal partial class GeneralOptionsPage : PropertyPage
    {
        public GeneralOptionsPage()
        {
            InitializeComponent();
        }

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