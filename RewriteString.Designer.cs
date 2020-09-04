namespace PlenaDataTest
{
    partial class RewriteString
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
            this.textBoxStringToEvaluate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEvaluateString = new System.Windows.Forms.Button();
            this.textBoxResults = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxStringToEvaluate
            // 
            this.textBoxStringToEvaluate.Location = new System.Drawing.Point(13, 48);
            this.textBoxStringToEvaluate.Multiline = true;
            this.textBoxStringToEvaluate.Name = "textBoxStringToEvaluate";
            this.textBoxStringToEvaluate.Size = new System.Drawing.Size(610, 76);
            this.textBoxStringToEvaluate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter string to be evaluated";
            // 
            // buttonEvaluateString
            // 
            this.buttonEvaluateString.Location = new System.Drawing.Point(13, 131);
            this.buttonEvaluateString.Name = "buttonEvaluateString";
            this.buttonEvaluateString.Size = new System.Drawing.Size(101, 23);
            this.buttonEvaluateString.TabIndex = 2;
            this.buttonEvaluateString.Text = "Evaluate String";
            this.buttonEvaluateString.UseVisualStyleBackColor = true;
            this.buttonEvaluateString.Click += new System.EventHandler(this.buttonEvaluateString_Click);
            // 
            // textBoxResults
            // 
            this.textBoxResults.Location = new System.Drawing.Point(13, 200);
            this.textBoxResults.Multiline = true;
            this.textBoxResults.Name = "textBoxResults";
            this.textBoxResults.Size = new System.Drawing.Size(610, 97);
            this.textBoxResults.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Result of evaluation";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reset (Clear all text)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(702, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "(by Tom Knowlton)";
            // 
            // RewriteString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 338);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxResults);
            this.Controls.Add(this.buttonEvaluateString);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxStringToEvaluate);
            this.Name = "RewriteString";
            this.Text = "Rewrite String";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStringToEvaluate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEvaluateString;
        private System.Windows.Forms.TextBox textBoxResults;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}

