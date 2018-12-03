namespace WindowsFormsApplication1
{
    partial class DummyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DummyForm));
            this.buttonA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonA.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonA.ForeColor = System.Drawing.Color.LightGray;
            this.buttonA.Location = new System.Drawing.Point(321, 603);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(185, 79);
            this.buttonA.TabIndex = 0;
            this.buttonA.Text = "Choice A";
            this.buttonA.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightYellow;
            this.label1.Font = new System.Drawing.Font("Ink Free", 20F);
            this.label1.Location = new System.Drawing.Point(238, 65);
            this.label1.MaximumSize = new System.Drawing.Size(625, 250);
            this.label1.MinimumSize = new System.Drawing.Size(625, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(625, 250);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.confused;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(913, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 290);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // buttonB
            // 
            this.buttonB.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonB.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonB.ForeColor = System.Drawing.Color.LightGray;
            this.buttonB.Location = new System.Drawing.Point(617, 603);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(185, 79);
            this.buttonB.TabIndex = 5;
            this.buttonB.Text = "Choice B";
            this.buttonB.UseVisualStyleBackColor = false;
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonC.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.ForeColor = System.Drawing.Color.LightGray;
            this.buttonC.Location = new System.Drawing.Point(904, 603);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(185, 79);
            this.buttonC.TabIndex = 6;
            this.buttonC.Text = "Choice C";
            this.buttonC.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightYellow;
            this.label2.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 301);
            this.label2.MaximumSize = new System.Drawing.Size(625, 250);
            this.label2.MinimumSize = new System.Drawing.Size(625, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(625, 250);
            this.label2.TabIndex = 7;
            this.label2.Text = "Choice A) something\r\nChoice B) something\r\nChoice C) something";
            // 
            // DummyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(1384, 790);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DummyForm";
            this.Text = "DummyForm";
            this.Load += new System.EventHandler(this.DummyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        System.Windows.Forms.Button buttonA;
        System.Windows.Forms.Label label1;
        System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Label label2;
    }
}