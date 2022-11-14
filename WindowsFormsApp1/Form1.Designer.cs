namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.twBox = new System.Windows.Forms.GroupBox();
            this.twWzor = new System.Windows.Forms.TextBox();
            this.twDropDown = new System.Windows.Forms.ComboBox();
            this.twTextBox = new System.Windows.Forms.TextBox();
            this.drawBtn = new System.Windows.Forms.Button();
            this.distanceBox = new System.Windows.Forms.GroupBox();
            this.distanceNum = new System.Windows.Forms.NumericUpDown();
            this.promien2Box = new System.Windows.Forms.GroupBox();
            this.promien2num = new System.Windows.Forms.NumericUpDown();
            this.promien1Box = new System.Windows.Forms.GroupBox();
            this.promien1num = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.twBox.SuspendLayout();
            this.distanceBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distanceNum)).BeginInit();
            this.promien2Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.promien2num)).BeginInit();
            this.promien1Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.promien1num)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.twBox);
            this.panel1.Controls.Add(this.drawBtn);
            this.panel1.Controls.Add(this.distanceBox);
            this.panel1.Controls.Add(this.promien2Box);
            this.panel1.Controls.Add(this.promien1Box);
            this.panel1.Location = new System.Drawing.Point(13, 801);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1898, 241);
            this.panel1.TabIndex = 0;
            // 
            // twBox
            // 
            this.twBox.BackColor = System.Drawing.Color.White;
            this.twBox.Controls.Add(this.twWzor);
            this.twBox.Controls.Add(this.twDropDown);
            this.twBox.Controls.Add(this.twTextBox);
            this.twBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.twBox.Location = new System.Drawing.Point(648, 23);
            this.twBox.Margin = new System.Windows.Forms.Padding(4);
            this.twBox.Name = "twBox";
            this.twBox.Padding = new System.Windows.Forms.Padding(4);
            this.twBox.Size = new System.Drawing.Size(1218, 205);
            this.twBox.TabIndex = 7;
            this.twBox.TabStop = false;
            this.twBox.Text = "Twierdzenie";
            // 
            // twWzor
            // 
            this.twWzor.BackColor = System.Drawing.SystemColors.Control;
            this.twWzor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.twWzor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.twWzor.Location = new System.Drawing.Point(837, 88);
            this.twWzor.Margin = new System.Windows.Forms.Padding(4);
            this.twWzor.MaxLength = 50;
            this.twWzor.Multiline = true;
            this.twWzor.Name = "twWzor";
            this.twWzor.ReadOnly = true;
            this.twWzor.Size = new System.Drawing.Size(354, 103);
            this.twWzor.TabIndex = 2;
            this.twWzor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // twDropDown
            // 
            this.twDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.twDropDown.FormattingEnabled = true;
            this.twDropDown.Items.AddRange(new object[] {
            "Okręgi rozłączne zewnętrznie",
            "Okręgi styczne zewnętrznie",
            "Okręgi przecinające się",
            "Okręgi styczne wewnętrznie",
            "Okręgi rozłączne wewnętrznie"});
            this.twDropDown.Location = new System.Drawing.Point(32, 35);
            this.twDropDown.Margin = new System.Windows.Forms.Padding(4);
            this.twDropDown.Name = "twDropDown";
            this.twDropDown.Size = new System.Drawing.Size(1159, 37);
            this.twDropDown.TabIndex = 1;
            this.twDropDown.SelectedIndexChanged += new System.EventHandler(this.twDropDown_IndexChanged);
            // 
            // twTextBox
            // 
            this.twTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.twTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.twTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.twTextBox.Location = new System.Drawing.Point(32, 88);
            this.twTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.twTextBox.MaxLength = 50;
            this.twTextBox.Multiline = true;
            this.twTextBox.Name = "twTextBox";
            this.twTextBox.ReadOnly = true;
            this.twTextBox.Size = new System.Drawing.Size(797, 100);
            this.twTextBox.TabIndex = 0;
            this.twTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // drawBtn
            // 
            this.drawBtn.BackColor = System.Drawing.Color.White;
            this.drawBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.drawBtn.Location = new System.Drawing.Point(441, 22);
            this.drawBtn.Margin = new System.Windows.Forms.Padding(4);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(129, 96);
            this.drawBtn.TabIndex = 5;
            this.drawBtn.Text = "Rysuj";
            this.drawBtn.UseVisualStyleBackColor = false;
            this.drawBtn.Click += new System.EventHandler(this.drawBtn_Click);
            // 
            // distanceBox
            // 
            this.distanceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.distanceBox.Controls.Add(this.distanceNum);
            this.distanceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.distanceBox.Location = new System.Drawing.Point(25, 126);
            this.distanceBox.Margin = new System.Windows.Forms.Padding(4);
            this.distanceBox.Name = "distanceBox";
            this.distanceBox.Padding = new System.Windows.Forms.Padding(4);
            this.distanceBox.Size = new System.Drawing.Size(408, 92);
            this.distanceBox.TabIndex = 4;
            this.distanceBox.TabStop = false;
            this.distanceBox.Text = "Odległość między środkami";
            // 
            // distanceNum
            // 
            this.distanceNum.DecimalPlaces = 2;
            this.distanceNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.distanceNum.Location = new System.Drawing.Point(8, 31);
            this.distanceNum.Margin = new System.Windows.Forms.Padding(4);
            this.distanceNum.Name = "distanceNum";
            this.distanceNum.Size = new System.Drawing.Size(349, 45);
            this.distanceNum.TabIndex = 0;
            // 
            // promien2Box
            // 
            this.promien2Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.promien2Box.Controls.Add(this.promien2num);
            this.promien2Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.promien2Box.Location = new System.Drawing.Point(25, 23);
            this.promien2Box.Margin = new System.Windows.Forms.Padding(4);
            this.promien2Box.Name = "promien2Box";
            this.promien2Box.Padding = new System.Windows.Forms.Padding(4);
            this.promien2Box.Size = new System.Drawing.Size(200, 96);
            this.promien2Box.TabIndex = 3;
            this.promien2Box.TabStop = false;
            this.promien2Box.Text = "Promień 2";
            // 
            // promien2num
            // 
            this.promien2num.DecimalPlaces = 2;
            this.promien2num.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.promien2num.Location = new System.Drawing.Point(8, 31);
            this.promien2num.Margin = new System.Windows.Forms.Padding(4);
            this.promien2num.Name = "promien2num";
            this.promien2num.Size = new System.Drawing.Size(184, 45);
            this.promien2num.TabIndex = 0;
            // 
            // promien1Box
            // 
            this.promien1Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.promien1Box.Controls.Add(this.promien1num);
            this.promien1Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.promien1Box.Location = new System.Drawing.Point(233, 22);
            this.promien1Box.Margin = new System.Windows.Forms.Padding(4);
            this.promien1Box.Name = "promien1Box";
            this.promien1Box.Padding = new System.Windows.Forms.Padding(4);
            this.promien1Box.Size = new System.Drawing.Size(200, 96);
            this.promien1Box.TabIndex = 2;
            this.promien1Box.TabStop = false;
            this.promien1Box.Text = "Promień 1";
            this.promien1Box.Enter += new System.EventHandler(this.promien1Box_Enter);
            // 
            // promien1num
            // 
            this.promien1num.DecimalPlaces = 2;
            this.promien1num.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.promien1num.Location = new System.Drawing.Point(8, 31);
            this.promien1num.Margin = new System.Windows.Forms.Padding(4);
            this.promien1num.Name = "promien1num";
            this.promien1num.Size = new System.Drawing.Size(184, 45);
            this.promien1num.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panel1.ResumeLayout(false);
            this.twBox.ResumeLayout(false);
            this.twBox.PerformLayout();
            this.distanceBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.distanceNum)).EndInit();
            this.promien2Box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.promien2num)).EndInit();
            this.promien1Box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.promien1num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown promien1num;
        private System.Windows.Forms.GroupBox promien1Box;
        private System.Windows.Forms.GroupBox twBox;
        private System.Windows.Forms.TextBox twTextBox;
        private System.Windows.Forms.Button drawBtn;
        private System.Windows.Forms.GroupBox distanceBox;
        private System.Windows.Forms.NumericUpDown distanceNum;
        private System.Windows.Forms.GroupBox promien2Box;
        private System.Windows.Forms.NumericUpDown promien2num;
        private System.Windows.Forms.ComboBox twDropDown;
        private System.Windows.Forms.TextBox twWzor;
    }
}

