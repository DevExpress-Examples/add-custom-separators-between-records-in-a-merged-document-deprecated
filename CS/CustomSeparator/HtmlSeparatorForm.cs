using System.Windows.Forms;
// ...

namespace CustomSeparator {
    public partial class HtmlSeparatorForm : Form {
        public HtmlSeparatorForm() {
            InitializeComponent();
        }

        public string Result { get { return memoEdit1.Text; } }

        private void memoEdit1_EditValueChanged(object sender, System.EventArgs e) {

        }
    }
}
