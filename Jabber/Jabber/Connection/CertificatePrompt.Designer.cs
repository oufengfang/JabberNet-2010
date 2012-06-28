
#if !__MonoCS__
    #define UI_OK
#endif

namespace Jabber.Connection
{
    public partial class CertificatePrompt
    {
#if UI_OK
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAllow = new System.Windows.Forms.Button();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblBegin = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(77, 13);
            label1.TabIndex = 2;
            label1.Text = "Subject Name:";
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 36);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(63, 13);
            label2.TabIndex = 3;
            label2.Text = "Begin Date:";
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 64);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(55, 13);
            label3.TabIndex = 4;
            label3.Text = "End Date:";
            //
            // panel2
            //
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnAllow);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 44);
            this.panel2.TabIndex = 1;
            //
            // btnCancel
            //
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(413, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            //
            // btnAllow
            //
            this.btnAllow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAllow.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAllow.Location = new System.Drawing.Point(332, 9);
            this.btnAllow.Name = "btnAllow";
            this.btnAllow.Size = new System.Drawing.Size(75, 23);
            this.btnAllow.TabIndex = 1;
            this.btnAllow.Text = "Allow Once";
            this.btnAllow.UseVisualStyleBackColor = true;
            //
            // lblSubject
            //
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(126, 9);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(43, 13);
            this.lblSubject.TabIndex = 5;
            this.lblSubject.Text = "Subject";
            //
            // lblBegin
            //
            this.lblBegin.AutoSize = true;
            this.lblBegin.Location = new System.Drawing.Point(126, 36);
            this.lblBegin.Name = "lblBegin";
            this.lblBegin.Size = new System.Drawing.Size(34, 13);
            this.lblBegin.TabIndex = 6;
            this.lblBegin.Text = "Begin";
            //
            // lblEnd
            //
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(126, 64);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(26, 13);
            this.lblEnd.TabIndex = 7;
            this.lblEnd.Text = "End";
            //
            // btnShow
            //
            this.btnShow.Location = new System.Drawing.Point(14, 90);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "Trust...";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            //
            // CertificatePrompt
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(500, 178);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblBegin);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.panel2);
            this.Name = "CertificatePrompt";
            this.Text = "Invalid Certificate";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblBegin;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAllow;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Panel panel2;
#endif
    }
}