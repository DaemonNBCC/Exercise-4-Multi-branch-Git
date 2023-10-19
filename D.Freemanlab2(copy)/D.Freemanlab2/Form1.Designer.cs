namespace D.Freemanlab2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picMe = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnPicture = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.lblProduct2 = new System.Windows.Forms.Label();
            this.lblSum2 = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnMath = new System.Windows.Forms.Button();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMe)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picMe);
            this.groupBox1.Controls.Add(this.lblInfo);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnHide);
            this.groupBox1.Controls.Add(this.btnInfo);
            this.groupBox1.Controls.Add(this.btnPicture);
            this.groupBox1.Location = new System.Drawing.Point(12, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "About me";
            // 
            // picMe
            // 
            this.picMe.Image = ((System.Drawing.Image)(resources.GetObject("picMe.Image")));
            this.picMe.Location = new System.Drawing.Point(6, 22);
            this.picMe.Name = "picMe";
            this.picMe.Size = new System.Drawing.Size(275, 195);
            this.picMe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMe.TabIndex = 9;
            this.picMe.TabStop = false;
            this.picMe.Visible = false;
            this.picMe.Click += new System.EventHandler(this.picMe_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.SystemColors.Info;
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfo.Location = new System.Drawing.Point(287, 22);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(276, 195);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExit.Location = new System.Drawing.Point(569, 186);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 31);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnHide.Location = new System.Drawing.Point(569, 131);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(108, 31);
            this.btnHide.TabIndex = 3;
            this.btnHide.Text = "&Hide";
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnInfo.Location = new System.Drawing.Point(569, 77);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(108, 31);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.Text = "&Information";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnPicture
            // 
            this.btnPicture.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPicture.Location = new System.Drawing.Point(569, 22);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(108, 31);
            this.btnPicture.TabIndex = 1;
            this.btnPicture.Text = "&Picture";
            this.btnPicture.UseVisualStyleBackColor = false;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNumber2);
            this.groupBox2.Controls.Add(this.lblNumber1);
            this.groupBox2.Controls.Add(this.lblProduct2);
            this.groupBox2.Controls.Add(this.lblSum2);
            this.groupBox2.Controls.Add(this.lblProduct);
            this.groupBox2.Controls.Add(this.lblSum);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnMath);
            this.groupBox2.Controls.Add(this.txtBox2);
            this.groupBox2.Controls.Add(this.txtBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(695, 128);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Math";
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Location = new System.Drawing.Point(19, 86);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(72, 16);
            this.lblNumber2.TabIndex = 9;
            this.lblNumber2.Text = "Number 2:";
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Location = new System.Drawing.Point(20, 40);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(72, 16);
            this.lblNumber1.TabIndex = 8;
            this.lblNumber1.Text = "Number 1:";
            // 
            // lblProduct2
            // 
            this.lblProduct2.AutoSize = true;
            this.lblProduct2.Location = new System.Drawing.Point(284, 86);
            this.lblProduct2.Name = "lblProduct2";
            this.lblProduct2.Size = new System.Drawing.Size(60, 16);
            this.lblProduct2.TabIndex = 7;
            this.lblProduct2.Text = "Product:";
            // 
            // lblSum2
            // 
            this.lblSum2.AutoSize = true;
            this.lblSum2.Location = new System.Drawing.Point(284, 44);
            this.lblSum2.Name = "lblSum2";
            this.lblSum2.Size = new System.Drawing.Size(39, 16);
            this.lblSum2.TabIndex = 6;
            this.lblSum2.Text = "Sum:";
            // 
            // lblProduct
            // 
            this.lblProduct.BackColor = System.Drawing.SystemColors.Info;
            this.lblProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProduct.Location = new System.Drawing.Point(370, 71);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(134, 31);
            this.lblProduct.TabIndex = 5;
            // 
            // lblSum
            // 
            this.lblSum.BackColor = System.Drawing.SystemColors.Info;
            this.lblSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSum.Location = new System.Drawing.Point(370, 29);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(134, 31);
            this.lblSum.TabIndex = 4;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(569, 75);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(108, 31);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnMath
            // 
            this.btnMath.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMath.Location = new System.Drawing.Point(569, 29);
            this.btnMath.Name = "btnMath";
            this.btnMath.Size = new System.Drawing.Size(108, 31);
            this.btnMath.TabIndex = 3;
            this.btnMath.Text = "&Math";
            this.btnMath.UseVisualStyleBackColor = false;
            this.btnMath.Click += new System.EventHandler(this.btnMath_Click);
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(97, 79);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(142, 23);
            this.txtBox2.TabIndex = 2;
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(97, 33);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(142, 23);
            this.txtBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnPicture;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(719, 411);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 2 by D.Freeman";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMe)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnMath;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.PictureBox picMe;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label lblProduct2;
        private System.Windows.Forms.Label lblSum2;
    }
}

