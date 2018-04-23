using System;
using DevExpress.Snap.Core.Forms;
using DevExpress.Snap.Forms;
using DevExpress.XtraRichEdit.API.Native;
// ...

namespace CustomSeparator {
    public partial class MyMailMergeExportForm : MailMergeExportForm {
        public MyMailMergeExportForm(MailMergeExportFormControllerParameters controllerParameters)
            : base(controllerParameters) {
            InitializeComponent();
        }

        public enum SeparatorTypeEnum { Html = 0, RichText = 1 };
        public SeparatorTypeEnum SeparatorType { get { return (SeparatorTypeEnum)radioGroup1.SelectedIndex; } }
        public string HtmlSeparator { get { return htmlSeparatorForm.Result; } }
        public Document RichSeparator { get { return richSeparatorForm.Result; } }

        private void simpleButton3_Click(object sender, EventArgs e) {
            this.radioGroup1.SelectedIndex = 0;
            htmlSeparatorForm.ShowDialog();
        }

        private void simpleButton4_Click(object sender, EventArgs e) {
            this.radioGroup1.SelectedIndex = 1;
            richSeparatorForm.ShowDialog();
        }

        private HtmlSeparatorForm htmlSeparatorForm = new HtmlSeparatorForm();
        private RichSeparatorForm richSeparatorForm = new RichSeparatorForm();
    }
}
