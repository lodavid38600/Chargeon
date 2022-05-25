namespace Chargeon
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPuissance = new System.Windows.Forms.ComboBox();
            this.cbPriorite = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLong = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Interieur",
            "Exterieur"});
            this.cbType.Location = new System.Drawing.Point(256, 44);
            this.cbType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(160, 24);
            this.cbType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Puissance";
            // 
            // cbPuissance
            // 
            this.cbPuissance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPuissance.FormattingEnabled = true;
            this.cbPuissance.Items.AddRange(new object[] {
            "7,5 kW",
            "22 kW",
            "50 kW",
            "120 kW"});
            this.cbPuissance.Location = new System.Drawing.Point(256, 113);
            this.cbPuissance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPuissance.Name = "cbPuissance";
            this.cbPuissance.Size = new System.Drawing.Size(160, 24);
            this.cbPuissance.TabIndex = 6;
            // 
            // cbPriorite
            // 
            this.cbPriorite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPriorite.FormattingEnabled = true;
            this.cbPriorite.Items.AddRange(new object[] {
            "Faible",
            "Moyenne",
            "Haute"});
            this.cbPriorite.Location = new System.Drawing.Point(256, 171);
            this.cbPriorite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPriorite.Name = "cbPriorite";
            this.cbPriorite.Size = new System.Drawing.Size(160, 24);
            this.cbPriorite.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Priorité";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(557, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Latitude";
            // 
            // tbLat
            // 
            this.tbLat.Location = new System.Drawing.Point(647, 44);
            this.tbLat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLat.Name = "tbLat";
            this.tbLat.Size = new System.Drawing.Size(243, 22);
            this.tbLat.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(557, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Longitude";
            // 
            // tbLong
            // 
            this.tbLong.Location = new System.Drawing.Point(647, 105);
            this.tbLong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLong.Name = "tbLong";
            this.tbLong.Size = new System.Drawing.Size(243, 22);
            this.tbLong.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(256, 373);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(216, 76);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.CloseForm2);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(647, 373);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(216, 76);
            this.btnSend.TabIndex = 14;
            this.btnSend.Text = "Envoyer";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.AddBorne);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbLong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbLat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbPriorite);
            this.Controls.Add(this.cbPuissance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPuissance;
        private System.Windows.Forms.ComboBox cbPriorite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbLong;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSend;
    }
}