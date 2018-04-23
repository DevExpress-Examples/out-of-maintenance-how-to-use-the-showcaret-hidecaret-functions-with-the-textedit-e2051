using System;
using DevExpress.XtraEditors;
using System.Runtime.InteropServices;

namespace Q248138 {
    public partial class MainForm : XtraForm {
        public MainForm() {
            InitializeComponent();
        }

        private bool IsMaskBoxAvailable(TextEdit editor) {
            return editor.MaskBox != null && editor.MaskBox.Visible && editor.MaskBox.IsHandleCreated;
        }

        [DllImport("user32.dll")]
        internal static extern bool HideCaret(IntPtr hWnd);
        [DllImport("user32.dll")]
        internal static extern bool ShowCaret(IntPtr hWnd);

        private void OnHideCaretClick(object sender, EventArgs e) {
            if (IsMaskBoxAvailable(testEdit)) HideCaret(testEdit.MaskBox.Handle);
        }

        private void showButton_Click(object sender, EventArgs e) {
            if (IsMaskBoxAvailable(testEdit)) ShowCaret(testEdit.MaskBox.Handle);
        }
    }
}