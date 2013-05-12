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

        public virtual void OnSetActive()
        {
            // Nothing by default.
        }

        public virtual void OnApply()
        {
            // Nothing by default.
        }
    }
}