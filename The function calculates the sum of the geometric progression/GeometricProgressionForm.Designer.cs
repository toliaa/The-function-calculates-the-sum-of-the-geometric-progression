namespace The_function_calculates_the_sum_of_the_geometric_progression
{
    partial class GeometricProgressionForm
    {
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeometricProgressionForm));
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtFirstTerm = new System.Windows.Forms.TextBox();
            this.txtCommonRatio = new System.Windows.Forms.TextBox();
            this.txtNumberOfTerms = new System.Windows.Forms.TextBox();
            this.lblFirstTerm = new System.Windows.Forms.Label();
            this.lblCommonRatio = new System.Windows.Forms.Label();
            this.lblNumberOfTerms = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(204, 222);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 28);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtFirstTerm
            // 
            this.txtFirstTerm.Location = new System.Drawing.Point(204, 36);
            this.txtFirstTerm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstTerm.Name = "txtFirstTerm";
            this.txtFirstTerm.Size = new System.Drawing.Size(132, 22);
            this.txtFirstTerm.TabIndex = 1;
            // 
            // txtCommonRatio
            // 
            this.txtCommonRatio.Location = new System.Drawing.Point(204, 86);
            this.txtCommonRatio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCommonRatio.Name = "txtCommonRatio";
            this.txtCommonRatio.Size = new System.Drawing.Size(132, 22);
            this.txtCommonRatio.TabIndex = 2;
            // 
            // txtNumberOfTerms
            // 
            this.txtNumberOfTerms.Location = new System.Drawing.Point(204, 139);
            this.txtNumberOfTerms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumberOfTerms.Name = "txtNumberOfTerms";
            this.txtNumberOfTerms.Size = new System.Drawing.Size(132, 22);
            this.txtNumberOfTerms.TabIndex = 3;
            // 
            // lblFirstTerm
            // 
            this.lblFirstTerm.AutoSize = true;
            this.lblFirstTerm.Location = new System.Drawing.Point(53, 39);
            this.lblFirstTerm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstTerm.Name = "lblFirstTerm";
            this.lblFirstTerm.Size = new System.Drawing.Size(70, 16);
            this.lblFirstTerm.TabIndex = 4;
            this.lblFirstTerm.Text = "First Term:";
            // 
            // lblCommonRatio
            // 
            this.lblCommonRatio.AutoSize = true;
            this.lblCommonRatio.Location = new System.Drawing.Point(53, 90);
            this.lblCommonRatio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCommonRatio.Name = "lblCommonRatio";
            this.lblCommonRatio.Size = new System.Drawing.Size(99, 16);
            this.lblCommonRatio.TabIndex = 5;
            this.lblCommonRatio.Text = "Common Ratio:";
            // 
            // lblNumberOfTerms
            // 
            this.lblNumberOfTerms.AutoSize = true;
            this.lblNumberOfTerms.Location = new System.Drawing.Point(53, 143);
            this.lblNumberOfTerms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfTerms.Name = "lblNumberOfTerms";
            this.lblNumberOfTerms.Size = new System.Drawing.Size(114, 16);
            this.lblNumberOfTerms.TabIndex = 6;
            this.lblNumberOfTerms.Text = "Number of Terms:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(53, 276);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(45, 16);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 336);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblNumberOfTerms);
            this.Controls.Add(this.lblCommonRatio);
            this.Controls.Add(this.lblFirstTerm);
            this.Controls.Add(this.txtNumberOfTerms);
            this.Controls.Add(this.txtCommonRatio);
            this.Controls.Add(this.txtFirstTerm);
            this.Controls.Add(this.btnCalculate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Geometric Progression Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtFirstTerm;
        private System.Windows.Forms.TextBox txtCommonRatio;
        private System.Windows.Forms.TextBox txtNumberOfTerms;
        private System.Windows.Forms.Label lblFirstTerm;
        private System.Windows.Forms.Label lblCommonRatio;
        private System.Windows.Forms.Label lblNumberOfTerms;
        private System.Windows.Forms.Label lblResult;
        private System.ComponentModel.IContainer components;
    }
}
