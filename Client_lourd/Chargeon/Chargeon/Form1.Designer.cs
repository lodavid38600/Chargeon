namespace Chargeon
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDelBorne = new System.Windows.Forms.Button();
            this.btnAddBorne = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelBorne);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddBorne);
            this.splitContainer1.Size = new System.Drawing.Size(1067, 554);
            this.splitContainer1.SplitterDistance = 354;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnDelBorne
            // 
            this.btnDelBorne.Location = new System.Drawing.Point(16, 91);
            this.btnDelBorne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelBorne.Name = "btnDelBorne";
            this.btnDelBorne.Size = new System.Drawing.Size(319, 42);
            this.btnDelBorne.TabIndex = 1;
            this.btnDelBorne.Text = "Supprimer borne";
            this.btnDelBorne.UseVisualStyleBackColor = true;
            this.btnDelBorne.Click += new System.EventHandler(this.ShowForm3);
            // 
            // btnAddBorne
            // 
            this.btnAddBorne.Location = new System.Drawing.Point(16, 15);
            this.btnAddBorne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddBorne.Name = "btnAddBorne";
            this.btnAddBorne.Size = new System.Drawing.Size(319, 42);
            this.btnAddBorne.TabIndex = 0;
            this.btnAddBorne.Text = "Ajouter borne";
            this.btnAddBorne.UseVisualStyleBackColor = true;
            this.btnAddBorne.Click += new System.EventHandler(this.ShowForm2);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 433);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Afficher bornes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ShowForm4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnAddBorne;
		private System.Windows.Forms.Button btnDelBorne;
        private System.Windows.Forms.Button button1;
    }
}

