namespace Project
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnOpenCustomerForm = new System.Windows.Forms.Button();
            this.btnOpenComplaintForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenCustomerForm
            // 
            this.btnOpenCustomerForm.Location = new System.Drawing.Point(50, 50);
            this.btnOpenCustomerForm.Name = "btnOpenCustomerForm";
            this.btnOpenCustomerForm.Size = new System.Drawing.Size(200, 50);
            this.btnOpenCustomerForm.TabIndex = 0;
            this.btnOpenCustomerForm.Text = "Open Customer Form";
            this.btnOpenCustomerForm.UseVisualStyleBackColor = true;
            this.btnOpenCustomerForm.Click += new System.EventHandler(this.btnOpenCustomerForm_Click);
            // 
            // btnOpenComplaintForm
            // 
            this.btnOpenComplaintForm.Location = new System.Drawing.Point(50, 120);
            this.btnOpenComplaintForm.Name = "btnOpenComplaintForm";
            this.btnOpenComplaintForm.Size = new System.Drawing.Size(200, 50);
            this.btnOpenComplaintForm.TabIndex = 1;
            this.btnOpenComplaintForm.Text = "Open Complaint Form";
            this.btnOpenComplaintForm.UseVisualStyleBackColor = true;
            this.btnOpenComplaintForm.Click += new System.EventHandler(this.btnOpenComplaintForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenComplaintForm);
            this.Controls.Add(this.btnOpenCustomerForm);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnOpenCustomerForm;
        private System.Windows.Forms.Button btnOpenComplaintForm;
    }
}
