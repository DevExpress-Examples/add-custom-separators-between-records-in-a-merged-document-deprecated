using System.Windows.Forms;
using DevExpress.XtraRichEdit;
// ...

namespace CustomSeparator {
    public partial class RichSeparatorForm : Form {
        public RichSeparatorForm() {
            InitializeComponent();
            this.richEditControl1.Document.LoadDocument(@"..\..\..\Data\separator.rtf",
                DocumentFormat.Rtf);
        }

        public DevExpress.XtraRichEdit.API.Native.Document Result { get { return richEditControl1.Document; } }
    }
}
