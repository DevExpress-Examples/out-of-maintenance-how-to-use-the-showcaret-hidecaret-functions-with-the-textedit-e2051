namespace Q248138 {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.testEdit = new DevExpress.XtraEditors.TextEdit();
            this.hideButton = new DevExpress.XtraEditors.SimpleButton();
            this.showButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.testEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // testEdit
            // 
            this.testEdit.Location = new System.Drawing.Point(12, 12);
            this.testEdit.Name = "testEdit";
            this.testEdit.Size = new System.Drawing.Size(156, 22);
            this.testEdit.TabIndex = 0;
            // 
            // hideButton
            // 
            this.hideButton.AllowFocus = false;
            this.hideButton.Location = new System.Drawing.Point(12, 40);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(75, 23);
            this.hideButton.TabIndex = 1;
            this.hideButton.Text = "Hide Caret";
            this.hideButton.Click += new System.EventHandler(this.OnHideCaretClick);
            // 
            // showButton
            // 
            this.showButton.AllowFocus = false;
            this.showButton.Location = new System.Drawing.Point(93, 40);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show Caret";
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 67);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.hideButton);
            this.Controls.Add(this.testEdit);
            this.Name = "MainForm";
            this.Text = "DX Sample";
            ((System.ComponentModel.ISupportInitialize)(this.testEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit testEdit;
        private DevExpress.XtraEditors.SimpleButton hideButton;
        private DevExpress.XtraEditors.SimpleButton showButton;

    }
}

