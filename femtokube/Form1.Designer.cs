namespace femtokube
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonServices = new System.Windows.Forms.Button();
            this.buttonDeployments = new System.Windows.Forms.Button();
            this.buttonPods = new System.Windows.Forms.Button();
            this.buttonNamespaces = new System.Windows.Forms.Button();
            this.buttonNodes = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelMemory1 = new System.Windows.Forms.Label();
            this.labelCPU1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelMemory2 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.labelCPU2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelMemory3 = new System.Windows.Forms.Label();
            this.labelCPU3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(320, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonServices);
            this.groupBox1.Controls.Add(this.buttonDeployments);
            this.groupBox1.Controls.Add(this.buttonPods);
            this.groupBox1.Controls.Add(this.buttonNamespaces);
            this.groupBox1.Controls.Add(this.buttonNodes);
            this.groupBox1.Location = new System.Drawing.Point(12, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonServices
            // 
            this.buttonServices.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonServices.Location = new System.Drawing.Point(658, 33);
            this.buttonServices.Name = "buttonServices";
            this.buttonServices.Size = new System.Drawing.Size(83, 47);
            this.buttonServices.TabIndex = 4;
            this.buttonServices.Text = "Services";
            this.buttonServices.UseVisualStyleBackColor = true;
            this.buttonServices.Click += new System.EventHandler(this.buttonServices_Click);
            // 
            // buttonDeployments
            // 
            this.buttonDeployments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDeployments.Location = new System.Drawing.Point(488, 33);
            this.buttonDeployments.Name = "buttonDeployments";
            this.buttonDeployments.Size = new System.Drawing.Size(120, 50);
            this.buttonDeployments.TabIndex = 3;
            this.buttonDeployments.Text = "Deployments";
            this.buttonDeployments.UseVisualStyleBackColor = true;
            this.buttonDeployments.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPods
            // 
            this.buttonPods.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPods.Location = new System.Drawing.Point(355, 31);
            this.buttonPods.Name = "buttonPods";
            this.buttonPods.Size = new System.Drawing.Size(76, 50);
            this.buttonPods.TabIndex = 2;
            this.buttonPods.Text = "Pods";
            this.buttonPods.UseVisualStyleBackColor = true;
            this.buttonPods.Click += new System.EventHandler(this.buttonPods_Click);
            // 
            // buttonNamespaces
            // 
            this.buttonNamespaces.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNamespaces.Location = new System.Drawing.Point(168, 31);
            this.buttonNamespaces.Name = "buttonNamespaces";
            this.buttonNamespaces.Size = new System.Drawing.Size(121, 50);
            this.buttonNamespaces.TabIndex = 1;
            this.buttonNamespaces.Text = "Namespaces";
            this.buttonNamespaces.UseVisualStyleBackColor = true;
            this.buttonNamespaces.Click += new System.EventHandler(this.buttonNamespaces_Click);
            // 
            // buttonNodes
            // 
            this.buttonNodes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNodes.Location = new System.Drawing.Point(31, 31);
            this.buttonNodes.Name = "buttonNodes";
            this.buttonNodes.Size = new System.Drawing.Size(76, 50);
            this.buttonNodes.TabIndex = 0;
            this.buttonNodes.Text = "Nodes";
            this.buttonNodes.UseVisualStyleBackColor = true;
            this.buttonNodes.Click += new System.EventHandler(this.buttonNodes_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelMemory1);
            this.groupBox2.Controls.Add(this.labelCPU1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(43, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Visible = false;
            // 
            // labelMemory1
            // 
            this.labelMemory1.AutoSize = true;
            this.labelMemory1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMemory1.Location = new System.Drawing.Point(127, 69);
            this.labelMemory1.Name = "labelMemory1";
            this.labelMemory1.Size = new System.Drawing.Size(63, 25);
            this.labelMemory1.TabIndex = 3;
            this.labelMemory1.Text = "label4";
            // 
            // labelCPU1
            // 
            this.labelCPU1.AutoSize = true;
            this.labelCPU1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCPU1.Location = new System.Drawing.Point(127, 32);
            this.labelCPU1.Name = "labelCPU1";
            this.labelCPU1.Size = new System.Drawing.Size(63, 25);
            this.labelCPU1.TabIndex = 2;
            this.labelCPU1.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Memory Usage:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "CPU Usage:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelMemory2);
            this.groupBox3.Controls.Add(this.labelError);
            this.groupBox3.Controls.Add(this.labelCPU2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(298, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            this.groupBox3.Visible = false;
            // 
            // labelMemory2
            // 
            this.labelMemory2.AutoSize = true;
            this.labelMemory2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMemory2.Location = new System.Drawing.Point(126, 68);
            this.labelMemory2.Name = "labelMemory2";
            this.labelMemory2.Size = new System.Drawing.Size(63, 25);
            this.labelMemory2.TabIndex = 3;
            this.labelMemory2.Text = "label4";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelError.Location = new System.Drawing.Point(-24, 38);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(234, 30);
            this.labelError.TabIndex = 6;
            this.labelError.Text = "Couldnt retrieve metrics";
            this.labelError.Visible = false;
            // 
            // labelCPU2
            // 
            this.labelCPU2.AutoSize = true;
            this.labelCPU2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCPU2.Location = new System.Drawing.Point(126, 32);
            this.labelCPU2.Name = "labelCPU2";
            this.labelCPU2.Size = new System.Drawing.Size(63, 25);
            this.labelCPU2.TabIndex = 2;
            this.labelCPU2.Text = "label4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Memory Usage:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "CPU Usage:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelMemory3);
            this.groupBox4.Controls.Add(this.labelCPU3);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(553, 96);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            this.groupBox4.Visible = false;
            // 
            // labelMemory3
            // 
            this.labelMemory3.AutoSize = true;
            this.labelMemory3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMemory3.Location = new System.Drawing.Point(127, 69);
            this.labelMemory3.Name = "labelMemory3";
            this.labelMemory3.Size = new System.Drawing.Size(63, 25);
            this.labelMemory3.TabIndex = 3;
            this.labelMemory3.Text = "label4";
            // 
            // labelCPU3
            // 
            this.labelCPU3.AutoSize = true;
            this.labelCPU3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCPU3.Location = new System.Drawing.Point(127, 32);
            this.labelCPU3.Name = "labelCPU3";
            this.labelCPU3.Size = new System.Drawing.Size(63, 25);
            this.labelCPU3.TabIndex = 2;
            this.labelCPU3.Text = "label4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(6, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 21);
            this.label10.TabIndex = 1;
            this.label10.Text = "Memory Usage:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(6, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "CPU Usage:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Metrics for the first 3 nodes of the cluster";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(12, 9);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(38, 15);
            this.labelAddress.TabIndex = 7;
            this.labelAddress.Text = "label5";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 342);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button buttonNodes;
        private Button buttonNamespaces;
        private Button buttonPods;
        private Button buttonDeployments;
        private Button buttonServices;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label labelMemory1;
        private Label labelCPU1;
        private GroupBox groupBox3;
        private Label labelMemory2;
        private Label labelCPU2;
        private Label label6;
        private Label label7;
        private GroupBox groupBox4;
        private Label labelMemory3;
        private Label labelCPU3;
        private Label label10;
        private Label label11;
        private Label label4;
        private Label labelError;
        private Label labelAddress;
    }
}