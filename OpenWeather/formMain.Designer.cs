namespace OpenWeather
{
    partial class formMain
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
            this.listShowWeather = new System.Windows.Forms.ListView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxCities = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listShowWeather
            // 
            this.listShowWeather.Location = new System.Drawing.Point(12, 102);
            this.listShowWeather.Name = "listShowWeather";
            this.listShowWeather.Size = new System.Drawing.Size(670, 327);
            this.listShowWeather.TabIndex = 0;
            this.listShowWeather.UseCompatibleStateImageBehavior = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(12, 60);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(134, 23);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxCities
            // 
            this.textBoxCities.Location = new System.Drawing.Point(12, 34);
            this.textBoxCities.Name = "textBoxCities";
            this.textBoxCities.Size = new System.Drawing.Size(134, 20);
            this.textBoxCities.TabIndex = 2;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.SystemColors.Control;
            this.label.Location = new System.Drawing.Point(12, 18);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(95, 13);
            this.label.TabIndex = 3;
            this.label.Text = "Enter a city name :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OpenWeather.Properties.Resources.clouds;
            this.pictureBox1.Location = new System.Drawing.Point(233, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(449, 87);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(694, 441);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBoxCities);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.listShowWeather);
            this.Name = "formMain";
            this.Text = "Open Weather";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listShowWeather;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxCities;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

