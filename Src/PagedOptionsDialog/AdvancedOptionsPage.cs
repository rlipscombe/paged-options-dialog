using System.Drawing;

namespace PagedOptionsDialog
{
    internal partial class AdvancedOptionsPage : PropertyPage
    {
        public AdvancedOptionsPage()
        {
            InitializeComponent();
        }

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