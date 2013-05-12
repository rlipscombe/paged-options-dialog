using System.Drawing;

namespace PagedOptionsDialog
{
    internal partial class EmailOptionsPage : PropertyPage
    {
        public EmailOptionsPage()
        {
            InitializeComponent();
        }

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