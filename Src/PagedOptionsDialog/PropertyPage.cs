using System.Drawing;
using System.Windows.Forms;

namespace PagedOptionsDialog
{
    public class PropertyPage : UserControl
    {
        public virtual string Title
        {
            get { return GetType().Name; }
        }

        public virtual Image Image
        {
            get { return null; }
        }
    }
}