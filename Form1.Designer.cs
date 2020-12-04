namespace SourceModManager
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
            this.ButtonModInit = new System.Windows.Forms.Button();
            this.BrowseFileForMod = new System.Windows.Forms.Button();
            this.modPath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonModInit
            // 
            this.ButtonModInit.Location = new System.Drawing.Point(562, 49);
            this.ButtonModInit.Name = "ButtonModInit";
            this.ButtonModInit.Size = new System.Drawing.Size(210, 23);
            this.ButtonModInit.TabIndex = 0;
            this.ButtonModInit.Text = "Check Mod";
            this.ButtonModInit.UseVisualStyleBackColor = true;
            this.ButtonModInit.Click += new System.EventHandler(this.ButtonModInit_Click);
            // 
            // BrowseFileForMod
            // 
            this.BrowseFileForMod.Location = new System.Drawing.Point(746, 20);
            this.BrowseFileForMod.Name = "BrowseFileForMod";
            this.BrowseFileForMod.Size = new System.Drawing.Size(26, 23);
            this.BrowseFileForMod.TabIndex = 1;
            this.BrowseFileForMod.Text = "...";
            this.BrowseFileForMod.UseVisualStyleBackColor = true;
            this.BrowseFileForMod.Click += new System.EventHandler(this.BrowseFileForMod_Click);
            // 
            // modPath
            // 
            this.modPath.Location = new System.Drawing.Point(562, 23);
            this.modPath.Name = "modPath";
            this.modPath.Size = new System.Drawing.Size(178, 20);
            this.modPath.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 176);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.modPath);
            this.Controls.Add(this.BrowseFileForMod);
            this.Controls.Add(this.ButtonModInit);
            this.Name = "Form1";
            this.Text = "Source Mod Manager - by Safariminer - github.com/Safariminer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonModInit;
        private System.Windows.Forms.Button BrowseFileForMod;
        private System.Windows.Forms.TextBox modPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

