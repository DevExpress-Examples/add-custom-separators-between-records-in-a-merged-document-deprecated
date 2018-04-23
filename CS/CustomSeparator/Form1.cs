using System;
using System.Data.OleDb;
using System.Windows.Forms;
using DevExpress.Snap;
using DevExpress.Snap.Core.API;
using DevExpress.Snap.Core.Forms;
using DevExpress.Snap.Core.Options;
using System.Data;
using System.Data.SqlClient;

namespace CustomSeparator {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            ribbonControl1.SelectedPage = this.mailMergeRibbonPage1;
        }
        #region #SnapMailMergeExportOptions
        // Provide a user interface to select a custom separator.
        private void snapControl1_MailMergeExportFormShowing(object sender, MailMergeExportFormShowingEventArgs e) {

            SnapMailMergeExportOptions eOptions = e.Options;

            MailMergeExportFormControllerParameters controllerParameters =
                new MailMergeExportFormControllerParameters(this.snapControl1, eOptions);
            eOptions.RecordSeparator = RecordSeparator.Custom;
            e.Handled = true;

            using (MyMailMergeExportForm mergeForm =
                new MyMailMergeExportForm(controllerParameters)) {
                mergeForm.LookAndFeel.ParentLookAndFeel = this.snapControl1.LookAndFeel;
                e.DialogResult = mergeForm.ShowDialog(this);
                switch (mergeForm.SeparatorType) {
                    case MyMailMergeExportForm.SeparatorTypeEnum.Html:
                        eOptions.CustomSeparator.HtmlText = mergeForm.HtmlSeparator;
                        break;
                    case MyMailMergeExportForm.SeparatorTypeEnum.RichText:
                        eOptions.CustomSeparator.Text = string.Empty;
                        eOptions.CustomSeparator.AppendDocumentContent(
                            mergeForm.RichSeparator.Range);
                        break;
                }
            }
        }
        #endregion #SnapMailMergeExportOptions

        #region #FormLoad
        // Register a Snap data source and open a document template.
        private void Form1_Load(object sender, EventArgs e) {
            // Load a template.
            this.snapControl1.Document.LoadDocument("template.snx", SnapDocumentFormat.Snap);
            // After loading a template, add data sources to the collection.
            this.snapControl1.DataSources.Add("MyDS", CreateDataSource());
            // And specify the data source used for mail merge (the Categories table of the MyDS data source).
            this.snapControl1.Options.SnapMailMergeVisualOptions.DataSourceName = "MyDS";
            this.snapControl1.Options.SnapMailMergeVisualOptions.DataMember = "Categories";
        }

        private static object CreateDataSource() {
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Categories; SELECT * FROM Products",
                new SqlConnection(Properties.Settings.Default.NWindConnectionString));
            adapter.TableMappings.Add("Table", "Categories");
            adapter.TableMappings.Add("Table1", "Products");
            adapter.Fill(ds);
            ds.Relations.Add("CategoriesProducts", 
                ds.Tables["Categories"].Columns["CategoryId"], ds.Tables["Products"].Columns["CategoryId"]);
            return ds;
        }
        #endregion #FormLoad
    }
}
