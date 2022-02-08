
namespace nc_excel
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ExcelVerilistView = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TabloOlusturCb = new Bunifu.Framework.UI.BunifuCheckbox();
            this.TabloTemizleCb = new Bunifu.Framework.UI.BunifuCheckbox();
            this.KlasorAcButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DosyaYoluTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.closeButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.minButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.KontrolButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BaslatButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExcelVerilistView
            // 
            this.ExcelVerilistView.BackColor = System.Drawing.Color.Purple;
            this.ExcelVerilistView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExcelVerilistView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExcelVerilistView.FullRowSelect = true;
            this.ExcelVerilistView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ExcelVerilistView.HideSelection = false;
            this.ExcelVerilistView.Location = new System.Drawing.Point(107, 191);
            this.ExcelVerilistView.Name = "ExcelVerilistView";
            this.ExcelVerilistView.Size = new System.Drawing.Size(376, 340);
            this.ExcelVerilistView.TabIndex = 3;
            this.ExcelVerilistView.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(558, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tabloyu Oluştur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(558, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tabloyu Temizle";
            // 
            // TabloOlusturCb
            // 
            this.TabloOlusturCb.BackColor = System.Drawing.Color.DarkMagenta;
            this.TabloOlusturCb.ChechedOffColor = System.Drawing.Color.DarkMagenta;
            this.TabloOlusturCb.Checked = false;
            this.TabloOlusturCb.CheckedOnColor = System.Drawing.Color.Magenta;
            this.TabloOlusturCb.ForeColor = System.Drawing.Color.White;
            this.TabloOlusturCb.Location = new System.Drawing.Point(759, 266);
            this.TabloOlusturCb.Name = "TabloOlusturCb";
            this.TabloOlusturCb.Size = new System.Drawing.Size(20, 20);
            this.TabloOlusturCb.TabIndex = 13;
            // 
            // TabloTemizleCb
            // 
            this.TabloTemizleCb.BackColor = System.Drawing.Color.DarkMagenta;
            this.TabloTemizleCb.ChechedOffColor = System.Drawing.Color.DarkMagenta;
            this.TabloTemizleCb.Checked = false;
            this.TabloTemizleCb.CheckedOnColor = System.Drawing.Color.Magenta;
            this.TabloTemizleCb.ForeColor = System.Drawing.Color.White;
            this.TabloTemizleCb.Location = new System.Drawing.Point(759, 322);
            this.TabloTemizleCb.Name = "TabloTemizleCb";
            this.TabloTemizleCb.Size = new System.Drawing.Size(20, 20);
            this.TabloTemizleCb.TabIndex = 14;
            // 
            // KlasorAcButton
            // 
            this.KlasorAcButton.ActiveBorderThickness = 1;
            this.KlasorAcButton.ActiveCornerRadius = 20;
            this.KlasorAcButton.ActiveFillColor = System.Drawing.Color.DarkMagenta;
            this.KlasorAcButton.ActiveForecolor = System.Drawing.Color.Black;
            this.KlasorAcButton.ActiveLineColor = System.Drawing.Color.Transparent;
            this.KlasorAcButton.BackColor = System.Drawing.Color.Indigo;
            this.KlasorAcButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("KlasorAcButton.BackgroundImage")));
            this.KlasorAcButton.ButtonText = "KLASOR SEC";
            this.KlasorAcButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KlasorAcButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KlasorAcButton.ForeColor = System.Drawing.Color.Black;
            this.KlasorAcButton.IdleBorderThickness = 1;
            this.KlasorAcButton.IdleCornerRadius = 20;
            this.KlasorAcButton.IdleFillColor = System.Drawing.Color.Magenta;
            this.KlasorAcButton.IdleForecolor = System.Drawing.Color.Black;
            this.KlasorAcButton.IdleLineColor = System.Drawing.Color.Transparent;
            this.KlasorAcButton.Location = new System.Drawing.Point(665, 89);
            this.KlasorAcButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.KlasorAcButton.Name = "KlasorAcButton";
            this.KlasorAcButton.Size = new System.Drawing.Size(114, 49);
            this.KlasorAcButton.TabIndex = 15;
            this.KlasorAcButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.KlasorAcButton.Click += new System.EventHandler(this.KlasorAcButton_Click_1);
            // 
            // DosyaYoluTextBox
            // 
            this.DosyaYoluTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DosyaYoluTextBox.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DosyaYoluTextBox.ForeColor = System.Drawing.Color.Black;
            this.DosyaYoluTextBox.HintForeColor = System.Drawing.Color.Black;
            this.DosyaYoluTextBox.HintText = "";
            this.DosyaYoluTextBox.isPassword = false;
            this.DosyaYoluTextBox.LineFocusedColor = System.Drawing.Color.DarkMagenta;
            this.DosyaYoluTextBox.LineIdleColor = System.Drawing.Color.Magenta;
            this.DosyaYoluTextBox.LineMouseHoverColor = System.Drawing.Color.DarkMagenta;
            this.DosyaYoluTextBox.LineThickness = 3;
            this.DosyaYoluTextBox.Location = new System.Drawing.Point(107, 89);
            this.DosyaYoluTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DosyaYoluTextBox.Name = "DosyaYoluTextBox";
            this.DosyaYoluTextBox.Size = new System.Drawing.Size(506, 49);
            this.DosyaYoluTextBox.TabIndex = 17;
            this.DosyaYoluTextBox.Text = "KLASOR SECIMI YAPIN";
            this.DosyaYoluTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // closeButton
            // 
            this.closeButton.ActiveBorderThickness = 1;
            this.closeButton.ActiveCornerRadius = 20;
            this.closeButton.ActiveFillColor = System.Drawing.Color.DarkMagenta;
            this.closeButton.ActiveForecolor = System.Drawing.Color.Black;
            this.closeButton.ActiveLineColor = System.Drawing.Color.Transparent;
            this.closeButton.BackColor = System.Drawing.Color.Indigo;
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.ButtonText = "X";
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.IdleBorderThickness = 1;
            this.closeButton.IdleCornerRadius = 20;
            this.closeButton.IdleFillColor = System.Drawing.Color.Indigo;
            this.closeButton.IdleForecolor = System.Drawing.Color.Black;
            this.closeButton.IdleLineColor = System.Drawing.Color.Transparent;
            this.closeButton.Location = new System.Drawing.Point(873, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(49, 39);
            this.closeButton.TabIndex = 18;
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeButton.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // minButton
            // 
            this.minButton.ActiveBorderThickness = 1;
            this.minButton.ActiveCornerRadius = 20;
            this.minButton.ActiveFillColor = System.Drawing.Color.DarkMagenta;
            this.minButton.ActiveForecolor = System.Drawing.Color.Black;
            this.minButton.ActiveLineColor = System.Drawing.Color.Transparent;
            this.minButton.BackColor = System.Drawing.Color.Indigo;
            this.minButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minButton.BackgroundImage")));
            this.minButton.ButtonText = "_";
            this.minButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minButton.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minButton.ForeColor = System.Drawing.Color.Black;
            this.minButton.IdleBorderThickness = 1;
            this.minButton.IdleCornerRadius = 20;
            this.minButton.IdleFillColor = System.Drawing.Color.Indigo;
            this.minButton.IdleForecolor = System.Drawing.Color.Black;
            this.minButton.IdleLineColor = System.Drawing.Color.Transparent;
            this.minButton.Location = new System.Drawing.Point(824, 0);
            this.minButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(49, 39);
            this.minButton.TabIndex = 19;
            this.minButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // KontrolButton
            // 
            this.KontrolButton.ActiveBorderThickness = 1;
            this.KontrolButton.ActiveCornerRadius = 20;
            this.KontrolButton.ActiveFillColor = System.Drawing.Color.DarkMagenta;
            this.KontrolButton.ActiveForecolor = System.Drawing.Color.Black;
            this.KontrolButton.ActiveLineColor = System.Drawing.Color.Transparent;
            this.KontrolButton.BackColor = System.Drawing.Color.Indigo;
            this.KontrolButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("KontrolButton.BackgroundImage")));
            this.KontrolButton.ButtonText = "KONTROL";
            this.KontrolButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KontrolButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KontrolButton.ForeColor = System.Drawing.Color.Black;
            this.KontrolButton.IdleBorderThickness = 1;
            this.KontrolButton.IdleCornerRadius = 20;
            this.KontrolButton.IdleFillColor = System.Drawing.Color.Magenta;
            this.KontrolButton.IdleForecolor = System.Drawing.Color.Black;
            this.KontrolButton.IdleLineColor = System.Drawing.Color.Transparent;
            this.KontrolButton.Location = new System.Drawing.Point(543, 425);
            this.KontrolButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.KontrolButton.Name = "KontrolButton";
            this.KontrolButton.Size = new System.Drawing.Size(114, 49);
            this.KontrolButton.TabIndex = 20;
            this.KontrolButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.KontrolButton.Click += new System.EventHandler(this.KontrolButton_Click_1);
            // 
            // BaslatButton
            // 
            this.BaslatButton.ActiveBorderThickness = 1;
            this.BaslatButton.ActiveCornerRadius = 20;
            this.BaslatButton.ActiveFillColor = System.Drawing.Color.DarkMagenta;
            this.BaslatButton.ActiveForecolor = System.Drawing.Color.Black;
            this.BaslatButton.ActiveLineColor = System.Drawing.Color.Transparent;
            this.BaslatButton.BackColor = System.Drawing.Color.Indigo;
            this.BaslatButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BaslatButton.BackgroundImage")));
            this.BaslatButton.ButtonText = "BASLAT";
            this.BaslatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BaslatButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BaslatButton.ForeColor = System.Drawing.Color.Black;
            this.BaslatButton.IdleBorderThickness = 1;
            this.BaslatButton.IdleCornerRadius = 20;
            this.BaslatButton.IdleFillColor = System.Drawing.Color.Magenta;
            this.BaslatButton.IdleForecolor = System.Drawing.Color.Black;
            this.BaslatButton.IdleLineColor = System.Drawing.Color.Transparent;
            this.BaslatButton.Location = new System.Drawing.Point(665, 425);
            this.BaslatButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BaslatButton.Name = "BaslatButton";
            this.BaslatButton.Size = new System.Drawing.Size(114, 49);
            this.BaslatButton.TabIndex = 21;
            this.BaslatButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BaslatButton.Click += new System.EventHandler(this.BaslatButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.minButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 70);
            this.panel1.TabIndex = 22;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_Event);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_Event);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_Event);
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.Purple;
            this.bunifuProgressBar1.BorderRadius = 5;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(518, 505);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.Magenta;
            this.bunifuProgressBar1.Size = new System.Drawing.Size(298, 26);
            this.bunifuProgressBar1.TabIndex = 23;
            this.bunifuProgressBar1.Value = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(922, 633);
            this.Controls.Add(this.bunifuProgressBar1);
            this.Controls.Add(this.BaslatButton);
            this.Controls.Add(this.KontrolButton);
            this.Controls.Add(this.DosyaYoluTextBox);
            this.Controls.Add(this.KlasorAcButton);
            this.Controls.Add(this.TabloTemizleCb);
            this.Controls.Add(this.TabloOlusturCb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExcelVerilistView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListView ExcelVerilistView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCheckbox TabloOlusturCb;
        private Bunifu.Framework.UI.BunifuCheckbox TabloTemizleCb;
        private Bunifu.Framework.UI.BunifuThinButton2 KlasorAcButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DosyaYoluTextBox;
        private Bunifu.Framework.UI.BunifuThinButton2 closeButton;
        private Bunifu.Framework.UI.BunifuThinButton2 minButton;
        private Bunifu.Framework.UI.BunifuThinButton2 KontrolButton;
        private Bunifu.Framework.UI.BunifuThinButton2 BaslatButton;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
    }
}

