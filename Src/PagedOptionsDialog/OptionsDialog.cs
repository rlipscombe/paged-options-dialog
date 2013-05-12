using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PagedOptionsDialog
{
    public partial class OptionsDialog : Form
    {
        private PropertyPage _activePage;
        public IList<PropertyPage> Pages { get; private set; }

        public OptionsDialog()
        {
            Pages = new List<PropertyPage>();

            InitializeComponent();
        }

        private void OptionsDialog_Load(object sender, System.EventArgs e)
        {
            var defaultImage = new Bitmap(GetType(), "Bitmaps.DefaultOptionsPage.bmp");
            imageList.Images.Add(defaultImage);

            AddPageControls();
            SelectFirstListItem();
        }

        private void SelectFirstListItem()
        {
            if (listView.Items.Count != 0)
                listView.Items[0].Selected = true;
        }

        private void AddPageControls()
        {
            var maxPageSize = pagePanel.Size;
            foreach (var page in Pages)
            {
                AddPage(page, ref maxPageSize);
            }

            SizeToFit(maxPageSize);
            CenterToParent();
        }

        private void SizeToFit(Size maxPageSize)
        {
            var newSize = new Size();
            newSize.Width = maxPageSize.Width + (Width - pagePanel.Width);
            newSize.Height = maxPageSize.Height + (Height - pagePanel.Height);

            Size = newSize;
        }

        private void AddPage(PropertyPage page, ref Size maxPageSize)
        {
            pagePanel.Controls.Add(page);

            AddListItemForPage(page);

            // Adjust to fit the largest child page.
            if (page.Width > maxPageSize.Width)
                maxPageSize.Width = page.Width;
            if (page.Height > maxPageSize.Height)
                maxPageSize.Height = page.Height;

            // Set page.Dock *after* looking at its size.
            page.Dock = DockStyle.Fill;
            page.Visible = false;
        }

        private void AddListItemForPage(PropertyPage page)
        {
            int imageIndex = 0;

            var image = page.Image;
            if (image != null)
            {
                imageList.Images.Add(image);
                imageIndex = imageList.Images.Count - 1;
            }

            var item = new ListViewItem(page.Title, imageIndex);
            item.Tag = page;

            listView.Items.Add(item);
        }

        private void listView_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (_activePage != null)
                _activePage.Visible = false;

            if (listView.SelectedItems.Count != 0)
            {
                var selectedItem = listView.SelectedItems[0];
                var page = (PropertyPage)selectedItem.Tag;
                _activePage = page;
            }

            if (_activePage != null)
            {
                _activePage.Visible = true;
                _activePage.OnSetActive();
            }
        }

        private void okButton_Click(object sender, System.EventArgs e)
        {
            foreach (var propertyPage in Pages)
            {
                propertyPage.OnApply();
            }
        }
    }
}
