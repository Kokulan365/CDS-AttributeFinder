using AttributeFinder.Enum;
using AttributeFinder.GridViewColumnSort;
using AttributeFinder.Model;
using McTools.Xrm.Connection;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Args;

namespace AttributeFinder
{
    public partial class MyPluginControl : PluginControlBase
    {
        private Settings mySettings;

        private readonly List<AttributeViewModel> fullListOfAttributes = new List<AttributeViewModel>();


        public MyPluginControl()
        {
            InitializeComponent();
        }

        private void WhoAmI()
        {
            Service.Execute(new WhoAmIRequest());
        }
        private void MyPluginControl_Load(object sender, EventArgs e)
        {
            ExecuteMethod(WhoAmI);

            gwAttributes.Visible = false;
            lblMessage.Visible = true;

            // Loads or creates the settings for the plugin
            if (!SettingsManager.Instance.TryLoad(GetType(), out mySettings))
            {
                mySettings = new Settings();

                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
            }
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        private void tsbSample_Click(object sender, EventArgs e)
        {
            // The ExecuteMethod method handles connecting to an
            // organization if XrmToolBox is not yet connected
            ExecuteMethod(GetAccounts);
        }

        private void GetAccounts()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Getting accounts",
                Work = (worker, args) =>
                {
                    args.Result = Service.RetrieveMultiple(new QueryExpression("account")
                    {
                        TopCount = 50
                    });
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    var result = args.Result as EntityCollection;
                    if (result != null)
                    {
                        MessageBox.Show($"Found {result.Entities.Count} accounts");
                    }
                }
            });
        }

        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPluginControl_OnCloseTool(object sender, EventArgs e)
        {
            // Before leaving, save the settings
            SettingsManager.Instance.Save(GetType(), mySettings);
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            if (mySettings != null && detail != null)
            {
                mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);
            }
        }

        public event EventHandler<StatusBarMessageEventArgs> SendMessageToStatusBar;


        private void tsbClose_Click_1(object sender, EventArgs e)
        {
            CloseTool();
        }

        private void tsb_Click(object sender, EventArgs e)
        {
            ExecuteMethod(LoadAttributes);
        }

        public void LoadAttributes()
        {

            fullListOfAttributes.Clear(); // Clear all the existing ones
            lvAttributes.Items.Clear();
            lvAttributes.Enabled = false;
            tsbClose.Enabled = false;
            tsbLoadAttributes.Enabled = false;
            gwAttributes.Enabled = false;

            DisplayMessageCentralPanel(MessageType.Infor, "Loading attributes from Dynamics 365. Please wait...");
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading attributes please wait...",
                Work = (w, e) =>
                {
                    e.Result = Helpers.MetaDataHelper.LoadAttributes(Service);
                },
                PostWorkCallBack = e =>
                {
                    if (e.Error != null)
                    {
                        MessageBox.Show(e.Error.ToString());
                    }

                    fullListOfAttributes.AddRange((List<AttributeViewModel>)e.Result);

                    cbxListEntities.DataSource =  fullListOfAttributes.Select(x => x.EntityLogicalName).Distinct().OrderBy(y  => y).ToList();
                    cbxListAttributeTypes.DataSource =
                        fullListOfAttributes.Select(x => x.AttributeType).Distinct().OrderBy(y =>  y).ToList();

                    txtSearch.Enabled = true;
                    DisplayMessageCentralPanel(MessageType.Infor,
                        $"Attributes have been loaded successfully. " +
                        $"{Environment.NewLine} {Environment.NewLine} Found total of {fullListOfAttributes.Count} attributes. " +
                        $"{Environment.NewLine} {Environment.NewLine} Please use the Search bar to find attributes you are looking for.");

                    gwAttributes.DataSource = fullListOfAttributes;
                    gwAttributes.Refresh();
                    gwAttributes.Enabled = true;

                    tsbClose.Enabled = true;
                    tsbLoadAttributes.Enabled = true;
                },
                ProgressChanged = e =>
                {
                    SendMessageToStatusBar?.Invoke(this, new StatusBarMessageEventArgs(e.UserState.ToString()));
                }
            });
        }

        private void BindAttributes(List<AttributeViewModel> argListAttributes)
        {
            SortableBindingList<AttributeViewModel> listAttributes = new SortableBindingList<AttributeViewModel>(argListAttributes);

            gwAttributes.DataSource = listAttributes;

            gwAttributes.RowsDefaultCellStyle.BackColor = Color.FromArgb(152, 189, 249);
            gwAttributes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 235, 244);

            foreach (DataGridViewColumn column in gwAttributes.Columns)
            {
                column.Width = 200;
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
            gwAttributes.Refresh();
            lblMessage.Visible = false;
            gwAttributes.Visible = true;

            txtSearch.Focus();
        }


        private void DisplayMessageCentralPanel(MessageType type, string Mesage)
        {
            gwAttributes.Visible = false;
            lblMessage.Visible = true;
            lblMessage.Text = Mesage;
            if (type == MessageType.Success)
                lblMessage.ForeColor = Color.DarkGreen;
            else if (type == MessageType.Error)
                lblMessage.ForeColor = Color.DarkRed;
            else
            {
                lblMessage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled = true;

                lvAttributes.Items.Clear();

                if (txtSearch.Text.Length == 0)
                {
                    BindAttributes(fullListOfAttributes);
                }
                else
                {

                    var searchTerms = txtSearch.Text.ToLower().Replace("*", ".*");
                    var itemsFound = fullListOfAttributes
                        .Where(i => Regex.IsMatch(i.LogicalName, searchTerms) || Regex.IsMatch(i.DisplayName,searchTerms)).ToList();

                    if (itemsFound.Any())
                    {
                        // Order the items by Entity Display name
                        var orderedItems = itemsFound.OrderBy(x =>x.EntityDisplayName).ToList();
                        BindAttributes(orderedItems);
                    }
                    else
                    {
                        DisplayMessageCentralPanel(MessageType.Infor,
                            $"No attributes found with the search term : {txtSearch.Text}. {Environment.NewLine} {Environment.NewLine} Please adjust your search terms and try again.");
                    }
                }
            }
        }

        private void lvAttributes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxFilterByEntity_CheckedChanged(object sender, EventArgs e)
        {
            cbxListEntities.Enabled = cbxEnableEntityFiltering.Checked;
            cbxEnableEntityPrefixFiltering.Enabled = cbxEnableEntityFiltering.Checked;
            grbFilterEntities.Enabled = cbxEnableEntityFiltering.Checked;
        }

        private void cbxEnableAttributeFiltering_CheckedChanged(object sender, EventArgs e)
        {
            cbxListAttributeTypes.Enabled = cbxEnableAttributeFiltering.Checked;
            cbxEnableAttributePrefixFilter.Enabled = cbxEnableAttributeFiltering.Checked;
            grbFilterAttributes.Enabled = cbxEnableAttributeFiltering.Checked;
        }

        private void cbxEnableEntityPrefixFiltering_CheckedChanged(object sender, EventArgs e)
        {
            txtEntityPrefixFilter.Enabled = cbxEnableEntityPrefixFiltering.Checked;
        }

        private void cbxEnableAttributePrefixFilter_CheckedChanged(object sender, EventArgs e)
        {
            txtAttributePrefixFilter.Enabled = cbxEnableAttributePrefixFilter.Checked;
        }
    }
}