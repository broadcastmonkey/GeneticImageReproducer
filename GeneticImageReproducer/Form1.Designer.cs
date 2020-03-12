namespace GeneticImageReproducer
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
            this.btnRunSimulation = new System.Windows.Forms.Button();
            this.btnCreateTestImage = new System.Windows.Forms.Button();
            this.panelImage = new System.Windows.Forms.Panel();
            this.btnCalculateFitness = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnP1 = new System.Windows.Forms.Button();
            this.btnP3 = new System.Windows.Forms.Button();
            this.btnP2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRunSimulation
            // 
            this.btnRunSimulation.Location = new System.Drawing.Point(12, 12);
            this.btnRunSimulation.Name = "btnRunSimulation";
            this.btnRunSimulation.Size = new System.Drawing.Size(153, 78);
            this.btnRunSimulation.TabIndex = 0;
            this.btnRunSimulation.Text = "run simulation";
            this.btnRunSimulation.UseVisualStyleBackColor = true;
            this.btnRunSimulation.Click += new System.EventHandler(this.btnRunSimulation_Click);
            // 
            // btnCreateTestImage
            // 
            this.btnCreateTestImage.Location = new System.Drawing.Point(12, 346);
            this.btnCreateTestImage.Name = "btnCreateTestImage";
            this.btnCreateTestImage.Size = new System.Drawing.Size(153, 78);
            this.btnCreateTestImage.TabIndex = 1;
            this.btnCreateTestImage.Text = "test image";
            this.btnCreateTestImage.UseVisualStyleBackColor = true;
            this.btnCreateTestImage.Click += new System.EventHandler(this.btnCreateTestImage_Click);
            // 
            // panelImage
            // 
            this.panelImage.Location = new System.Drawing.Point(247, 12);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(512, 512);
            this.panelImage.TabIndex = 2;
            // 
            // btnCalculateFitness
            // 
            this.btnCalculateFitness.Location = new System.Drawing.Point(12, 445);
            this.btnCalculateFitness.Name = "btnCalculateFitness";
            this.btnCalculateFitness.Size = new System.Drawing.Size(153, 78);
            this.btnCalculateFitness.TabIndex = 3;
            this.btnCalculateFitness.Text = "calculate fitness";
            this.btnCalculateFitness.UseVisualStyleBackColor = true;
            this.btnCalculateFitness.Click += new System.EventHandler(this.btnCalculateFitness_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(779, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 512);
            this.panel1.TabIndex = 3;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(1297, 41);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(148, 482);
            this.txtLog.TabIndex = 4;
            // 
            // btnP1
            // 
            this.btnP1.Location = new System.Drawing.Point(12, 105);
            this.btnP1.Name = "btnP1";
            this.btnP1.Size = new System.Drawing.Size(62, 49);
            this.btnP1.TabIndex = 5;
            this.btnP1.Text = "P1";
            this.btnP1.UseVisualStyleBackColor = true;
            this.btnP1.Click += new System.EventHandler(this.btnP1_Click);
            // 
            // btnP3
            // 
            this.btnP3.Location = new System.Drawing.Point(148, 105);
            this.btnP3.Name = "btnP3";
            this.btnP3.Size = new System.Drawing.Size(62, 49);
            this.btnP3.TabIndex = 6;
            this.btnP3.Text = "P3";
            this.btnP3.UseVisualStyleBackColor = true;
            this.btnP3.Click += new System.EventHandler(this.btnP3_Click);
            // 
            // btnP2
            // 
            this.btnP2.Location = new System.Drawing.Point(80, 105);
            this.btnP2.Name = "btnP2";
            this.btnP2.Size = new System.Drawing.Size(62, 49);
            this.btnP2.TabIndex = 7;
            this.btnP2.Text = "P2";
            this.btnP2.UseVisualStyleBackColor = true;
            this.btnP2.Click += new System.EventHandler(this.btnP2_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1537, 556);
            this.Controls.Add(this.btnP2);
            this.Controls.Add(this.btnP3);
            this.Controls.Add(this.btnP1);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCalculateFitness);
            this.Controls.Add(this.panelImage);
            this.Controls.Add(this.btnCreateTestImage);
            this.Controls.Add(this.btnRunSimulation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRunSimulation;
        private System.Windows.Forms.Button btnCreateTestImage;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.Button btnCalculateFitness;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnP1;
        private System.Windows.Forms.Button btnP3;
        private System.Windows.Forms.Button btnP2;
    }
}

