using AttributeFinder.Model;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Metadata.Query;
using System.Collections.Generic;
using System.Linq;

namespace AttributeFinder.Helpers
{
    public static class MetaDataHelper
    {
        private static readonly string[] EntityMetadataProperties = { "LogicalName", "DisplayName", "Attributes", "PrimaryIdAttribute", "ObjectTypeCode", "SchemaName" };
        private static readonly string[] AttributeMetadataProperties = { "DisplayName", "LogicalName", "AttributeType", "IsValidForRead", "AttributeOf", "IsCustomAttribute", "SchemaName" };

        public static List<AttributeViewModel> LoadAttributes(IOrganizationService service)
        {
            List<AttributeViewModel> attributeCollection = new List<AttributeViewModel>();

            EntityQueryExpression entityQueryExpression = new EntityQueryExpression
            {
                Properties = new MetadataPropertiesExpression
                {
                    AllProperties = false,
                    PropertyNames = { "LogicalName", "DisplayName", "Attributes", "PrimaryIdAttribute", "ObjectTypeCode", "SchemaName" }
                },
                AttributeQuery = new AttributeQueryExpression
                {
                    Properties = new MetadataPropertiesExpression(AttributeMetadataProperties)
                    {
                        AllProperties = false
                    }
                },
            };

            RetrieveMetadataChangesRequest retrieveMetadataChangesRequest = new RetrieveMetadataChangesRequest
            {
                Query = entityQueryExpression,
                ClientVersionStamp = null
            };

            var response = (RetrieveMetadataChangesResponse)service.Execute(retrieveMetadataChangesRequest);

            if (response.EntityMetadata != null && response.EntityMetadata.Any())
            {
                foreach (var entityMetadata in response.EntityMetadata)
                {
                    attributeCollection.AddRange(ConvertToAttributesViewModel(entityMetadata));
                }
            }

            //attributeCollection.OrderBy(x => x.).ToList();

            return attributeCollection;
        }

        public static List<AttributeViewModel> ConvertToAttributesViewModel(EntityMetadata entityMetada)
        {
            List<AttributeViewModel> attributes = new List<AttributeViewModel>();

            foreach (var attribute in entityMetada.Attributes)
            {
                attributes.Add(new AttributeViewModel() {
                    DisplayName = attribute.DisplayName.UserLocalizedLabel != null
                            ? attribute.DisplayName.UserLocalizedLabel.Label
                            : "No Display Name",
                    LogicalName = attribute.LogicalName,
                    AttributeType = attribute.AttributeType.HasValue ? attribute.AttributeType.ToString() : "Type Not Identified",
                    SchemaName = attribute.SchemaName,
                    EntityDisplayName = entityMetada.DisplayName.UserLocalizedLabel != null
        ? entityMetada.DisplayName.UserLocalizedLabel.Label
        : "N/A",
                    EntityLogicalName = entityMetada.LogicalName
                });

                
                //var item =  new ListViewItemCustom(attributeVM.DisplayName);
                //item.SubItems.Add(attribute.LogicalName);
                //item.SubItems.Add(attributeVM.AttributeType);
                //item.SubItems.Add(attributeVM.EntityDisplayName);
                //item.SubItems.Add(attributeVM.EntityLogicalName);
                //item.Tag = attributeVM;
                //item.EntityDisplayName = attributeVM.EntityDisplayName;
                //item.AttributeLogicalName = attributeVM.LogicalName;
                //attributes.Add(item);
            }

            return attributes;
        }

        //public static EntityMetadataCollection LoadAttributes(IOrganizationService service, string entityLogicalName)
        //{
        //    EntityQueryExpression entityQueryExpression = new EntityQueryExpression
        //    {
        //        Criteria = new MetadataFilterExpression
        //        {
        //            Conditions =
        //            {
        //                new MetadataConditionExpression("LogicalName", MetadataConditionOperator.Equals, entityLogicalName)
        //            }
        //        },
        //        Properties = new MetadataPropertiesExpression
        //        {
        //            AllProperties = false,
        //            PropertyNames = { "Attributes" }
        //        },
        //        AttributeQuery = new AttributeQueryExpression
        //        {
        //            Properties = new MetadataPropertiesExpression(AttributeMetadataProperties)
        //            {
        //                AllProperties = false
        //            }
        //        },
        //    };

        //    RetrieveMetadataChangesRequest retrieveMetadataChangesRequest = new RetrieveMetadataChangesRequest
        //    {
        //        Query = entityQueryExpression,
        //        ClientVersionStamp = null
        //    };

        //    var response = (RetrieveMetadataChangesResponse)service.Execute(retrieveMetadataChangesRequest);

        //    return response.EntityMetadata;
        //}

        //public static IEnumerable<string> GetFormsDefinitions(int objectTypeCode, IOrganizationService service)
        //{
        //    var qe = new QueryExpression("systemform")
        //    {
        //        ColumnSet = new ColumnSet("formxml"),
        //        Criteria = new FilterExpression
        //        {
        //            Conditions =
        //            {
        //                new ConditionExpression("objecttypecode", ConditionOperator.Equal, objectTypeCode),
        //                new ConditionExpression("type", ConditionOperator.In, new[] {2, 7})
        //            }
        //        }
        //    };

        //    return service.RetrieveMultiple(qe).Entities.Select(e => e.GetAttributeValue<string>("formxml"));
        //}

        //public static IEnumerable<AttributeMetadata> FilterAttributes(AttributeMetadata[] attributes)
        //{
        //    return attributes.Where(a =>
        //                    a.AttributeOf == null
        //                    && a.AttributeType.Value != AttributeTypeCode.Virtual
        //                    && a.AttributeType.Value != AttributeTypeCode.PartyList
        //                    && a.IsValidForRead.Value
        //                    && a.LogicalName.IndexOf("composite") < 0
        //                    ).OrderBy(a => a.LogicalName);
        //}

        //public static AttributeMetadata GetMetadataAttribute(AttributeMetadata[] attributes, string attributeName)
        //{
        //    return attributes.Where(a => a.LogicalName == attributeName).FirstOrDefault();
        //}
    }
}
