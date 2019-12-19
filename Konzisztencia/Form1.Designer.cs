namespace Konzisztencia
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
            this.startButton = new System.Windows.Forms.Button();
            this.consistencyLabel = new System.Windows.Forms.Label();
            this.consLabel = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.termekLabel1 = new System.Windows.Forms.Label();
            this.termekLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(253, 66);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(86, 35);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // consistencyLabel
            // 
            this.consistencyLabel.AutoSize = true;
            this.consistencyLabel.Location = new System.Drawing.Point(26, 77);
            this.consistencyLabel.Name = "consistencyLabel";
            this.consistencyLabel.Size = new System.Drawing.Size(83, 13);
            this.consistencyLabel.TabIndex = 1;
            this.consistencyLabel.Text = "Inkonzisztencia:";
            // 
            // consLabel
            // 
            this.consLabel.AutoSize = true;
            this.consLabel.Location = new System.Drawing.Point(107, 77);
            this.consLabel.Name = "consLabel";
            this.consLabel.Size = new System.Drawing.Size(0, 13);
            this.consLabel.TabIndex = 2;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(253, 21);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(83, 20);
            this.numericUpDown.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hányszor ér többet az első termék a másodiknál?";
            // 
            // termekLabel1
            // 
            this.termekLabel1.AutoSize = true;
            this.termekLabel1.Location = new System.Drawing.Point(37, 42);
            this.termekLabel1.Name = "termekLabel1";
            this.termekLabel1.Size = new System.Drawing.Size(45, 13);
            this.termekLabel1.TabIndex = 5;
            this.termekLabel1.Text = "termek1";
            // 
            // termekLabel2
            // 
            this.termekLabel2.AutoSize = true;
            this.termekLabel2.Location = new System.Drawing.Point(148, 42);
            this.termekLabel2.Name = "termekLabel2";
            this.termekLabel2.Size = new System.Drawing.Size(45, 13);
            this.termekLabel2.TabIndex = 6;
            this.termekLabel2.Text = "termek2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 113);
            this.Controls.Add(this.termekLabel2);
            this.Controls.Add(this.termekLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.consLabel);
            this.Controls.Add(this.consistencyLabel);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label consistencyLabel;
        private System.Windows.Forms.Label consLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label termekLabel1;
        private System.Windows.Forms.Label termekLabel2;
    }
}

