namespace Client
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
            this.AddButtonWS = new System.Windows.Forms.Button();
            this.addButtonBasic = new System.Windows.Forms.Button();
            this.NumberTwo = new System.Windows.Forms.TextBox();
            this.NumberOne = new System.Windows.Forms.TextBox();
            this.DivButtonWS = new System.Windows.Forms.Button();
            this.SubButtonWS = new System.Windows.Forms.Button();
            this.MultButtonWS = new System.Windows.Forms.Button();
            this.DivButtonBasic = new System.Windows.Forms.Button();
            this.MultButtonBasic = new System.Windows.Forms.Button();
            this.SubButtonBasic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddButtonWS
            // 
            this.AddButtonWS.Location = new System.Drawing.Point(160, 142);
            this.AddButtonWS.Name = "AddButtonWS";
            this.AddButtonWS.Size = new System.Drawing.Size(75, 23);
            this.AddButtonWS.TabIndex = 0;
            this.AddButtonWS.Text = "Add (WS)";
            this.AddButtonWS.UseVisualStyleBackColor = true;
            this.AddButtonWS.Click += new System.EventHandler(this.AddButtonWS_Click);
            // 
            // addButtonBasic
            // 
            this.addButtonBasic.Location = new System.Drawing.Point(12, 142);
            this.addButtonBasic.Name = "addButtonBasic";
            this.addButtonBasic.Size = new System.Drawing.Size(75, 23);
            this.addButtonBasic.TabIndex = 1;
            this.addButtonBasic.Text = "Add (Basic)";
            this.addButtonBasic.UseVisualStyleBackColor = true;
            this.addButtonBasic.Click += new System.EventHandler(this.addButtonBasic_Click);
            // 
            // NumberTwo
            // 
            this.NumberTwo.Location = new System.Drawing.Point(160, 12);
            this.NumberTwo.Name = "NumberTwo";
            this.NumberTwo.Size = new System.Drawing.Size(112, 20);
            this.NumberTwo.TabIndex = 2;
            // 
            // NumberOne
            // 
            this.NumberOne.Location = new System.Drawing.Point(12, 12);
            this.NumberOne.Name = "NumberOne";
            this.NumberOne.Size = new System.Drawing.Size(110, 20);
            this.NumberOne.TabIndex = 3;
            // 
            // DivButtonWS
            // 
            this.DivButtonWS.Location = new System.Drawing.Point(160, 229);
            this.DivButtonWS.Name = "DivButtonWS";
            this.DivButtonWS.Size = new System.Drawing.Size(75, 23);
            this.DivButtonWS.TabIndex = 4;
            this.DivButtonWS.Text = "Div (WS)";
            this.DivButtonWS.UseVisualStyleBackColor = true;
            this.DivButtonWS.Click += new System.EventHandler(this.DivButtonWS_Click);
            // 
            // SubButtonWS
            // 
            this.SubButtonWS.Location = new System.Drawing.Point(160, 171);
            this.SubButtonWS.Name = "SubButtonWS";
            this.SubButtonWS.Size = new System.Drawing.Size(75, 23);
            this.SubButtonWS.TabIndex = 5;
            this.SubButtonWS.Text = "Sub (WS)";
            this.SubButtonWS.UseVisualStyleBackColor = true;
            this.SubButtonWS.Click += new System.EventHandler(this.SubButtonWS_Click);
            // 
            // MultButtonWS
            // 
            this.MultButtonWS.Location = new System.Drawing.Point(160, 200);
            this.MultButtonWS.Name = "MultButtonWS";
            this.MultButtonWS.Size = new System.Drawing.Size(75, 23);
            this.MultButtonWS.TabIndex = 6;
            this.MultButtonWS.Text = "Mult (WS)";
            this.MultButtonWS.UseVisualStyleBackColor = true;
            this.MultButtonWS.Click += new System.EventHandler(this.MultButtonWS_Click);
            // 
            // DivButtonBasic
            // 
            this.DivButtonBasic.Location = new System.Drawing.Point(12, 229);
            this.DivButtonBasic.Name = "DivButtonBasic";
            this.DivButtonBasic.Size = new System.Drawing.Size(75, 23);
            this.DivButtonBasic.TabIndex = 7;
            this.DivButtonBasic.Text = "Div (Basic)";
            this.DivButtonBasic.UseVisualStyleBackColor = true;
            this.DivButtonBasic.Click += new System.EventHandler(this.DivButtonBasic_Click);
            // 
            // MultButtonBasic
            // 
            this.MultButtonBasic.Location = new System.Drawing.Point(12, 200);
            this.MultButtonBasic.Name = "MultButtonBasic";
            this.MultButtonBasic.Size = new System.Drawing.Size(75, 23);
            this.MultButtonBasic.TabIndex = 8;
            this.MultButtonBasic.Text = "Mult (Basic)";
            this.MultButtonBasic.UseVisualStyleBackColor = true;
            this.MultButtonBasic.Click += new System.EventHandler(this.MultButtonBasic_Click);
            // 
            // SubButtonBasic
            // 
            this.SubButtonBasic.Location = new System.Drawing.Point(12, 171);
            this.SubButtonBasic.Name = "SubButtonBasic";
            this.SubButtonBasic.Size = new System.Drawing.Size(75, 23);
            this.SubButtonBasic.TabIndex = 9;
            this.SubButtonBasic.Text = "Sub (Basic)";
            this.SubButtonBasic.UseVisualStyleBackColor = true;
            this.SubButtonBasic.Click += new System.EventHandler(this.SubButtonBasic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubButtonBasic);
            this.Controls.Add(this.MultButtonBasic);
            this.Controls.Add(this.DivButtonBasic);
            this.Controls.Add(this.MultButtonWS);
            this.Controls.Add(this.SubButtonWS);
            this.Controls.Add(this.DivButtonWS);
            this.Controls.Add(this.NumberOne);
            this.Controls.Add(this.NumberTwo);
            this.Controls.Add(this.addButtonBasic);
            this.Controls.Add(this.AddButtonWS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButtonWS;
        private System.Windows.Forms.Button addButtonBasic;
        private System.Windows.Forms.TextBox NumberTwo;
        private System.Windows.Forms.TextBox NumberOne;
        private System.Windows.Forms.Button DivButtonWS;
        private System.Windows.Forms.Button SubButtonWS;
        private System.Windows.Forms.Button MultButtonWS;
        private System.Windows.Forms.Button DivButtonBasic;
        private System.Windows.Forms.Button MultButtonBasic;
        private System.Windows.Forms.Button SubButtonBasic;
        private System.Windows.Forms.Label label1;
    }
}

