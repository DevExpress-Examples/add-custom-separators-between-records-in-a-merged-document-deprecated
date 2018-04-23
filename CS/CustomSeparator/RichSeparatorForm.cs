using System.Windows.Forms;
using DevExpress.XtraRichEdit;
// ...

namespace CustomSeparator {
    public partial class RichSeparatorForm : DevExpress.XtraBars.Ribbon.RibbonForm {
        public RichSeparatorForm() {
            InitializeComponent();
            this.richEditControl1.Document.LoadDocument("separator.rtf",
                DocumentFormat.Rtf);
        }

        public DevExpress.XtraRichEdit.API.Native.Document Result { get { return richEditControl1.Document; } }

        private void btnCloseReturn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            this.Close();
        }
    }
}
