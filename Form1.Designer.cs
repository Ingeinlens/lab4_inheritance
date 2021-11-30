
namespace WinFormsApp1
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRefill = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.txtOut = new System.Windows.Forms.RichTextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.txtLine2 = new System.Windows.Forms.RichTextBox();
            this.txtLine1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnRefill
            // 
            this.btnRefill.Location = new System.Drawing.Point(12, 8);
            this.btnRefill.Name = "btnRefill";
            this.btnRefill.Size = new System.Drawing.Size(315, 43);
            this.btnRefill.TabIndex = 0;
            this.btnRefill.Text = "Перезаписать";
            this.btnRefill.UseVisualStyleBackColor = true;
            this.btnRefill.Click += new System.EventHandler(this.btnRefill_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo.Location = new System.Drawing.Point(12, 59);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(315, 42);
            this.txtInfo.TabIndex = 1;
            this.txtInfo.Text = "";
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(12, 353);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(315, 115);
            this.txtOut.TabIndex = 2;
            this.txtOut.Text = "";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(12, 474);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(315, 54);
            this.btnGet.TabIndex = 3;
            this.btnGet.Text = "Взять";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtLine2
            // 
            this.txtLine2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLine2.Location = new System.Drawing.Point(12, 109);
            this.txtLine2.Name = "txtLine2";
            this.txtLine2.ReadOnly = true;
            this.txtLine2.Size = new System.Drawing.Size(315, 115);
            this.txtLine2.TabIndex = 4;
            this.txtLine2.Text = "";
            // 
            // txtLine1
            // 
            this.txtLine1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLine1.Location = new System.Drawing.Point(12, 232);
            this.txtLine1.Name = "txtLine1";
            this.txtLine1.ReadOnly = true;
            this.txtLine1.Size = new System.Drawing.Size(315, 115);
            this.txtLine1.TabIndex = 5;
            this.txtLine1.Text = "";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 540);
            this.Controls.Add(this.txtLine1);
            this.Controls.Add(this.txtLine2);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnRefill);
            this.Name = "Form";
            this.Text = "Автомат";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefill;
        private System.Windows.Forms.RichTextBox txtInfo;
        private System.Windows.Forms.RichTextBox txtOut;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.RichTextBox txtLine2;
        private System.Windows.Forms.RichTextBox txtLine1;
    }
}

