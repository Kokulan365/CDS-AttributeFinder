using System.ComponentModel;

namespace AttributeFinder.Model
{
    public class AttributeViewModel
    {
        [DisplayName("Display Name")]
        public string DisplayName { get; set; }
        [DisplayName("Logical Name")]
        public string LogicalName { get; set; }
        [DisplayName("Attribute Type")]
        public string AttributeType { get; set; }
        [DisplayName("Schema Name")]
        public string SchemaName { get; set; }

        [DisplayName("Entity Logical Name")]
        public string EntityLogicalName { get; set; }

        [DisplayName("Entity Display Name")]
        public string EntityDisplayName { get; set; }

    }
}
