namespace ProjectDreieck
{
    partial class Triangulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Triangulator));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sideABox = new System.Windows.Forms.TextBox();
            this.sideBBox = new System.Windows.Forms.TextBox();
            this.sideCBox = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.Label();
            this.updateDescriptionBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Side a length:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Side b length:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Side c length:";
            // 
            // sideABox
            // 
            this.sideABox.Location = new System.Drawing.Point(98, 22);
            this.sideABox.Name = "sideABox";
            this.sideABox.Size = new System.Drawing.Size(100, 20);
            this.sideABox.TabIndex = 6;
            this.sideABox.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.sideABox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AcceptOnlyNumbers);
            // 
            // sideBBox
            // 
            this.sideBBox.Location = new System.Drawing.Point(98, 52);
            this.sideBBox.Name = "sideBBox";
            this.sideBBox.Size = new System.Drawing.Size(100, 20);
            this.sideBBox.TabIndex = 7;
            this.sideBBox.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.sideBBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AcceptOnlyNumbers);
            // 
            // sideCBox
            // 
            this.sideCBox.Location = new System.Drawing.Point(98, 83);
            this.sideCBox.Name = "sideCBox";
            this.sideCBox.Size = new System.Drawing.Size(100, 20);
            this.sideCBox.TabIndex = 8;
            this.sideCBox.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.sideCBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AcceptOnlyNumbers);
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(23, 139);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(230, 13);
            this.description.TabIndex = 9;
            this.description.Text = "Please submit lengths for the sides of a triangle.";
            // 
            // Triangulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 288);
            this.Controls.Add(this.description);
            this.Controls.Add(this.sideCBox);
            this.Controls.Add(this.sideBBox);
            this.Controls.Add(this.sideABox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Triangulator";
            this.Text = "Triangulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sideABox;
        private System.Windows.Forms.TextBox sideBBox;
        private System.Windows.Forms.TextBox sideCBox;
        private System.Windows.Forms.Label description;
    }
}

