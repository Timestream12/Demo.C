namespace Demos
{
    partial class MakingControl
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
            this.myButton1 = new Demos.myButton();
            this.SuspendLayout();
            // 
            // myButton1
            // 
            this.myButton1.ButtonColor = System.Drawing.Color.White;
            this.myButton1.ButtonText = "Mike";
            this.myButton1.Location = new System.Drawing.Point(46, 75);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(173, 48);
            this.myButton1.TabIndex = 0;
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click);
            // 
            // MakingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(282, 254);
            this.Controls.Add(this.myButton1);
            this.Name = "MakingControl";
            this.Text = "MakingControl";
            this.ResumeLayout(false);

        }

        #endregion

        private myButton myButton1;
    }
}