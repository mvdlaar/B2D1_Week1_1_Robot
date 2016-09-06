namespace Test
{
    partial class RobotForm
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
            this.btInitialiseer = new System.Windows.Forms.Button();
            this.gbxInitialisatie = new System.Windows.Forms.GroupBox();
            this.lblInitieleRichting = new System.Windows.Forms.Label();
            this.lblInitielePlaats = new System.Windows.Forms.Label();
            this.gbxMethoden = new System.Windows.Forms.GroupBox();
            this.btGaNaar = new System.Windows.Forms.Button();
            this.btZetEenStap = new System.Windows.Forms.Button();
            this.nudInitielePlaats = new System.Windows.Forms.NumericUpDown();
            this.nudBestemming = new System.Windows.Forms.NumericUpDown();
            this.nudInitieleRichting = new System.Windows.Forms.NumericUpDown();
            this.gbxInitialisatie.SuspendLayout();
            this.gbxMethoden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitielePlaats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBestemming)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitieleRichting)).BeginInit();
            this.SuspendLayout();
            // 
            // btInitialiseer
            // 
            this.btInitialiseer.Location = new System.Drawing.Point(315, 17);
            this.btInitialiseer.Name = "btInitialiseer";
            this.btInitialiseer.Size = new System.Drawing.Size(75, 23);
            this.btInitialiseer.TabIndex = 0;
            this.btInitialiseer.Text = "Initialiseer";
            this.btInitialiseer.UseVisualStyleBackColor = true;
            this.btInitialiseer.Click += new System.EventHandler(this.btInitialiseer_Click);
            // 
            // gbxInitialisatie
            // 
            this.gbxInitialisatie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxInitialisatie.AutoSize = true;
            this.gbxInitialisatie.Controls.Add(this.nudInitieleRichting);
            this.gbxInitialisatie.Controls.Add(this.nudInitielePlaats);
            this.gbxInitialisatie.Controls.Add(this.lblInitieleRichting);
            this.gbxInitialisatie.Controls.Add(this.lblInitielePlaats);
            this.gbxInitialisatie.Controls.Add(this.btInitialiseer);
            this.gbxInitialisatie.Location = new System.Drawing.Point(12, 12);
            this.gbxInitialisatie.Name = "gbxInitialisatie";
            this.gbxInitialisatie.Size = new System.Drawing.Size(414, 59);
            this.gbxInitialisatie.TabIndex = 2;
            this.gbxInitialisatie.TabStop = false;
            this.gbxInitialisatie.Text = "Initialisatie";
            // 
            // lblInitieleRichting
            // 
            this.lblInitieleRichting.AutoSize = true;
            this.lblInitieleRichting.Location = new System.Drawing.Point(155, 22);
            this.lblInitieleRichting.Name = "lblInitieleRichting";
            this.lblInitieleRichting.Size = new System.Drawing.Size(49, 13);
            this.lblInitieleRichting.TabIndex = 6;
            this.lblInitieleRichting.Text = "Richting:";
            // 
            // lblInitielePlaats
            // 
            this.lblInitielePlaats.AutoSize = true;
            this.lblInitielePlaats.Location = new System.Drawing.Point(6, 22);
            this.lblInitielePlaats.Name = "lblInitielePlaats";
            this.lblInitielePlaats.Size = new System.Drawing.Size(39, 13);
            this.lblInitielePlaats.TabIndex = 4;
            this.lblInitielePlaats.Text = "Plaats:";
            // 
            // gbxMethoden
            // 
            this.gbxMethoden.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxMethoden.AutoSize = true;
            this.gbxMethoden.Controls.Add(this.nudBestemming);
            this.gbxMethoden.Controls.Add(this.btGaNaar);
            this.gbxMethoden.Controls.Add(this.btZetEenStap);
            this.gbxMethoden.Location = new System.Drawing.Point(12, 77);
            this.gbxMethoden.Name = "gbxMethoden";
            this.gbxMethoden.Size = new System.Drawing.Size(414, 76);
            this.gbxMethoden.TabIndex = 3;
            this.gbxMethoden.TabStop = false;
            this.gbxMethoden.Text = "Methoden";
            // 
            // btGaNaar
            // 
            this.btGaNaar.Location = new System.Drawing.Point(224, 33);
            this.btGaNaar.Name = "btGaNaar";
            this.btGaNaar.Size = new System.Drawing.Size(75, 23);
            this.btGaNaar.TabIndex = 1;
            this.btGaNaar.Text = "Ga naar:";
            this.btGaNaar.UseVisualStyleBackColor = true;
            this.btGaNaar.Click += new System.EventHandler(this.btGaNaar_Click);
            // 
            // btZetEenStap
            // 
            this.btZetEenStap.Location = new System.Drawing.Point(51, 34);
            this.btZetEenStap.Name = "btZetEenStap";
            this.btZetEenStap.Size = new System.Drawing.Size(105, 23);
            this.btZetEenStap.TabIndex = 0;
            this.btZetEenStap.Text = "Zet Een Stap";
            this.btZetEenStap.UseVisualStyleBackColor = true;
            this.btZetEenStap.Click += new System.EventHandler(this.btZetEenStap_Click);
            // 
            // nudInitielePlaats
            // 
            this.nudInitielePlaats.Location = new System.Drawing.Point(51, 20);
            this.nudInitielePlaats.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.nudInitielePlaats.Minimum = new decimal(new int[] {
            276447232,
            23283,
            0,
            -2147483648});
            this.nudInitielePlaats.Name = "nudInitielePlaats";
            this.nudInitielePlaats.Size = new System.Drawing.Size(73, 20);
            this.nudInitielePlaats.TabIndex = 8;
            // 
            // nudBestemming
            // 
            this.nudBestemming.Location = new System.Drawing.Point(315, 37);
            this.nudBestemming.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.nudBestemming.Minimum = new decimal(new int[] {
            276447232,
            23283,
            0,
            -2147483648});
            this.nudBestemming.Name = "nudBestemming";
            this.nudBestemming.Size = new System.Drawing.Size(75, 20);
            this.nudBestemming.TabIndex = 2;
            this.nudBestemming.Value = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            // 
            // nudInitieleRichting
            // 
            this.nudInitieleRichting.Location = new System.Drawing.Point(210, 20);
            this.nudInitieleRichting.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudInitieleRichting.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudInitieleRichting.Name = "nudInitieleRichting";
            this.nudInitieleRichting.Size = new System.Drawing.Size(70, 20);
            this.nudInitieleRichting.TabIndex = 9;
            this.nudInitieleRichting.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // RobotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 161);
            this.Controls.Add(this.gbxMethoden);
            this.Controls.Add(this.gbxInitialisatie);
            this.Name = "RobotForm";
            this.Text = "Robot (B2D1 Week 1 Opdracht1)";
            this.gbxInitialisatie.ResumeLayout(false);
            this.gbxInitialisatie.PerformLayout();
            this.gbxMethoden.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudInitielePlaats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBestemming)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitieleRichting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btInitialiseer;
        private System.Windows.Forms.GroupBox gbxInitialisatie;
        private System.Windows.Forms.Label lblInitieleRichting;
        private System.Windows.Forms.Label lblInitielePlaats;
        private System.Windows.Forms.GroupBox gbxMethoden;
        private System.Windows.Forms.Button btGaNaar;
        private System.Windows.Forms.Button btZetEenStap;
        private System.Windows.Forms.NumericUpDown nudInitielePlaats;
        private System.Windows.Forms.NumericUpDown nudBestemming;
        private System.Windows.Forms.NumericUpDown nudInitieleRichting;
    }
}

