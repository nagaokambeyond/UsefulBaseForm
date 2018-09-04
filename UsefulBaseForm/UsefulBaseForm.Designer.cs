namespace SimpleMethods.UsefulBaseForm
{
    partial class UsefulBaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // UsefulBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.KeyPreview = true;
            this.Name = "UsefulBaseForm";
            this.Text = "UsefulBaseForm";
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.UsefulBaseForm_ControlAdded);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsefulBaseForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
    }
}