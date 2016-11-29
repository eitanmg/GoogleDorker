namespace WindowsFormsApplication2
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
            this.QueryTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WLTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LinkToGuide = new System.Windows.Forms.LinkLabel();
            this.allPagesCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // QueryTextBox
            // 
            this.QueryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QueryTextBox.Location = new System.Drawing.Point(31, 36);
            this.QueryTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.QueryTextBox.Multiline = true;
            this.QueryTextBox.Name = "QueryTextBox";
            this.QueryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.QueryTextBox.Size = new System.Drawing.Size(760, 229);
            this.QueryTextBox.TabIndex = 0;
            this.QueryTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 584);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dork Google!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your query in textbox";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // WLTextBox
            // 
            this.WLTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WLTextBox.Location = new System.Drawing.Point(31, 294);
            this.WLTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.WLTextBox.Multiline = true;
            this.WLTextBox.Name = "WLTextBox";
            this.WLTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.WLTextBox.Size = new System.Drawing.Size(760, 231);
            this.WLTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Whitelist Domains";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LinkToGuide
            // 
            this.LinkToGuide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LinkToGuide.AutoSize = true;
            this.LinkToGuide.Location = new System.Drawing.Point(12, 648);
            this.LinkToGuide.Name = "LinkToGuide";
            this.LinkToGuide.Size = new System.Drawing.Size(140, 13);
            this.LinkToGuide.TabIndex = 5;
            this.LinkToGuide.TabStop = true;
            this.LinkToGuide.Text = "How to use this application?";
            this.LinkToGuide.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkToGuide_LinkClicked);
            // 
            // allPagesCB
            // 
            this.allPagesCB.AutoSize = true;
            this.allPagesCB.Location = new System.Drawing.Point(317, 545);
            this.allPagesCB.Name = "allPagesCB";
            this.allPagesCB.Size = new System.Drawing.Size(166, 17);
            this.allPagesCB.TabIndex = 6;
            this.allPagesCB.Text = "Scan only first page per query";
            this.allPagesCB.UseVisualStyleBackColor = true;
            this.allPagesCB.CheckedChanged += new System.EventHandler(this.allPagesCB_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 670);
            this.Controls.Add(this.allPagesCB);
            this.Controls.Add(this.LinkToGuide);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WLTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.QueryTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Google Dork";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QueryTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WLTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel LinkToGuide;
        private System.Windows.Forms.CheckBox allPagesCB;
    }
}

