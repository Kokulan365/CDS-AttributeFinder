using System.Windows.Forms;

namespace AttributeFinder
{
    public class ListViewItemCustom : ListViewItem
    {
        public string EntityDisplayName { get; set; }
        public string AttributeLogicalName { get; set; }

        public ListViewItemCustom(string ItemName) : base(ItemName)
        {

        }
    }
}