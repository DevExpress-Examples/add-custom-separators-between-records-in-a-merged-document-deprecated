using System;
using System.Data.OleDb;
using System.Windows.Forms;
using CustomSeparator.nwindDataSetTableAdapters;
using DevExpress.Snap;
using DevExpress.Snap.Core.API;
using DevExpress.Snap.Core.Forms;
using DevExpress.Snap.Core.Options;
// ...

namespace CustomSeparator {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        // Provide a user interface to select a custom separator.
        private void snapControl1_MailMergeExportFormShowing(object sender,
            MailMergeExportFormShowingEventArgs e) {
            MailMergeExportFormControllerParameters controllerParameters =
                new MailMergeExportFormControllerParameters(this.snapControl1, e.Options);
            e.Options.RecordSeparator = RecordSeparator.Custom;
            e.Handled = true;

            using (MyMailMergeExportForm mergeForm =
                new MyMailMergeExportForm(controllerParameters)) {
                mergeForm.LookAndFeel.ParentLookAndFeel = this.snapControl1.LookAndFeel;
                e.DialogResult = mergeForm.ShowDialog(this);
                switch (mergeForm.SeparatorType) {
                    case MyMailMergeExportForm.SeparatorTypeEnum.Html:
                        e.Options.CustomSeparator.HtmlText = mergeForm.HtmlSeparator;
                        break;
                    case MyMailMergeExportForm.SeparatorTypeEnum.RichText:
                        e.Options.CustomSeparator.Text = string.Empty;
                        e.Options.CustomSeparator.AppendDocumentContent(
                            mergeForm.RichSeparator.Range);
                        break;
                }
            }
        }

        // Register a Snap data source and open a document template.
        private void Form1_Load(object sender, EventArgs e) {
            this.snapControl1.DataSources.Add(string.Empty, CreateDataSource());
            this.snapControl1.Options.SnapMailMergeVisualOptions.DataSourceName = string.Empty;
            this.snapControl1.Document.LoadDocument(@"..\..\..\Data\template.snx",
                SnapDocumentFormat.Snap);
        }

        // Specify and populate a new data source.
        private static object CreateDataSource() {
            var dataSource = new nwindDataSet();
            var connection = new OleDbConnection();
            connection.ConnectionString = Properties.Settings.Default.nwindConnectionString;

            CategoriesTableAdapter categories = new CategoriesTableAdapter();
            categories.Connection = connection;
            categories.Fill(dataSource.Categories);

            ProductsTableAdapter products = new ProductsTableAdapter();
            products.Connection = connection;
            products.Fill(dataSource.Products);

            var bindingSource = new BindingSource();
            bindingSource.DataSource = dataSource;
            bindingSource.DataMember = "Categories";
            return bindingSource;
        }
    }
}
