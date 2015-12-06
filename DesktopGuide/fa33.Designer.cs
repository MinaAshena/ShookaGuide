namespace DesktopGuide
{
    partial class fa33
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
            this.label2 = new DesktopGuide.Controls.MyLabel();
            this.label3 = new DesktopGuide.Controls.MyLabel();
            this.label16 = new DesktopGuide.Controls.MyLabel();
            this.label23 = new DesktopGuide.Controls.MyLabel();
            this.arrow6 = new DesktopGuide.Controls.Arrow();
            this.main = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.main)).BeginInit();
            this.main.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Text = "راهنمای سربرگ لیست مخاطبین";
            // 
            // prevButton
            // 
            this.toolTip1.SetToolTip(this.prevButton, "بازگشت به صفحه قبلی");
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(373, 251);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(370, 264);
            this.label2.TabIndex = 2;
            this.label2.Text = "با استفاده از این گزینه می توانید کاربر مورد نظر را به لیست مخاطبان خود اضافه نما" +
    "یید و همواره وضعیت آنها را(آنلاین، آفلاین، مشغول و ...) مشاهده نمایید.\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(738, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "-1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(1, 215);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 18);
            this.label16.TabIndex = 31;
            this.label16.Text = "1";
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(316, 567);
            this.label23.Name = "label23";
            this.label23.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label23.Size = new System.Drawing.Size(472, 24);
            this.label23.TabIndex = 50;
            this.label23.Text = "با کلیک بر هر کادر چشمک زن، راهنمای اجزای درون آن نشان داده خواهد شد.";
            // 
            // arrow6
            // 
            this.arrow6._CapSize = 10F;
            this.arrow6._Direction = DesktopGuide.Controls.Arrow.Direction.PrimaryDiagonalToButtom;
            this.arrow6._FilledCap = false;
            this.arrow6._LineWidth = 1F;
            this.arrow6._transparentParent = this.main;
            this.arrow6.BackColor = System.Drawing.Color.Transparent;
            this.arrow6.ForeColor = System.Drawing.Color.SteelBlue;
            this.arrow6.Location = new System.Drawing.Point(-19, 122);
            this.arrow6.Name = "arrow6";
            this.arrow6.Size = new System.Drawing.Size(37, 26);
            this.arrow6.TabIndex = 44;
            // 
            // main
            // 
            this.main.BackColor = System.Drawing.Color.Transparent;
            this.main.Controls.Add(this.arrow6);
            this.main.Image = global::DesktopGuide.Properties.Resources.Farsi_Contact_Search;
            this.main.Location = new System.Drawing.Point(19, 93);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(348, 494);
            this.main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.main.TabIndex = 20;
            this.main.TabStop = false;
            // 
            // fa33
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.main);
            this.Name = "fa33";
            this.Controls.SetChildIndex(this.main, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.label23, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.prevButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.main)).EndInit();
            this.main.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.MyLabel label2;
        private Controls.MyLabel label3;
        private Controls.MyLabel label16;
        private Controls.MyLabel label23;
        private Controls.Arrow arrow6;
        private System.Windows.Forms.PictureBox main;
    }
}

