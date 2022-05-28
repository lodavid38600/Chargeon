namespace Chargeon
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.cbNumSerie = new System.Windows.Forms.ComboBox();
            this.tbLong = new System.Windows.Forms.TextBox();
            this.tbLat = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbPuissance = new System.Windows.Forms.ComboBox();
            this.cbPriorite = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbNumSerie
            // 
            this.cbNumSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumSerie.FormattingEnabled = true;
            this.cbNumSerie.Location = new System.Drawing.Point(459, 35);
            this.cbNumSerie.Name = "cbNumSerie";
            this.cbNumSerie.Size = new System.Drawing.Size(121, 24);
            this.cbNumSerie.TabIndex = 0;
            this.cbNumSerie.SelectedIndexChanged += new System.EventHandler(this.cbNumSerie_SelectedIndexChanged);
            // 
            // tbLong
            // 
            this.tbLong.Location = new System.Drawing.Point(704, 202);
            this.tbLong.Name = "tbLong";
            this.tbLong.Size = new System.Drawing.Size(134, 22);
            this.tbLong.TabIndex = 4;
            // 
            // tbLat
            // 
            this.tbLat.Location = new System.Drawing.Point(704, 114);
            this.tbLat.Name = "tbLat";
            this.tbLat.Size = new System.Drawing.Size(134, 22);
            this.tbLat.TabIndex = 6;
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Interieur",
            "Exterieur"});
            this.cbType.Location = new System.Drawing.Point(149, 111);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(138, 24);
            this.cbType.TabIndex = 7;
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
            this.cbPuissance.Location = new System.Drawing.Point(149, 200);
            this.cbPuissance.Name = "cbPuissance";
            this.cbPuissance.Size = new System.Drawing.Size(138, 24);
            this.cbPuissance.TabIndex = 8;
            // 
            // cbPriorite
            // 
            this.cbPriorite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPriorite.FormattingEnabled = true;
            this.cbPriorite.Items.AddRange(new object[] {
            "Basse",
            "Moyenne",
            "Haute"});
            this.cbPriorite.Location = new System.Drawing.Point(149, 285);
            this.cbPriorite.Name = "cbPriorite";
            this.cbPriorite.Size = new System.Drawing.Size(138, 24);
            this.cbPriorite.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Numéro de série :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Puissance : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Priorité : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(627, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Latitude : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(615, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Longitude : ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Location = new System.Drawing.Point(618, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 59);
            this.button1.TabIndex = 16;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.updateBorne);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Location = new System.Drawing.Point(149, 422);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 59);
            this.button2.TabIndex = 17;
            this.button2.Text = "Retour";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.CloseForm5);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPriorite);
            this.Controls.Add(this.cbPuissance);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.tbLat);
            this.Controls.Add(this.tbLong);
            this.Controls.Add(this.cbNumSerie);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Chargeon | Modifier borne";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNumSerie;
        private System.Windows.Forms.TextBox tbLong;
        private System.Windows.Forms.TextBox tbLat;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbPuissance;
        private System.Windows.Forms.ComboBox cbPriorite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}