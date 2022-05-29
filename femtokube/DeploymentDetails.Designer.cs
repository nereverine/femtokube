namespace femtokube
{
    partial class DeploymentDetails
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeploymentDetails));
            this.labelDeploymentName = new System.Windows.Forms.Label();
            this.labeluid = new System.Windows.Forms.Label();
            this.labelCreatedAt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBoxContainers = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxProgressing = new System.Windows.Forms.PictureBox();
            this.pictureBoxAvailable = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProgressing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvailable)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDeploymentName
            // 
            this.labelDeploymentName.AutoSize = true;
            this.labelDeploymentName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDeploymentName.Location = new System.Drawing.Point(22, 9);
            this.labelDeploymentName.Name = "labelDeploymentName";
            this.labelDeploymentName.Size = new System.Drawing.Size(165, 32);
            this.labelDeploymentName.TabIndex = 4;
            this.labelDeploymentName.Text = "Deployments";
            // 
            // labeluid
            // 
            this.labeluid.AutoSize = true;
            this.labeluid.Location = new System.Drawing.Point(40, 83);
            this.labeluid.Name = "labeluid";
            this.labeluid.Size = new System.Drawing.Size(38, 15);
            this.labeluid.TabIndex = 15;
            this.labeluid.Text = "label3";
            // 
            // labelCreatedAt
            // 
            this.labelCreatedAt.AutoSize = true;
            this.labelCreatedAt.Location = new System.Drawing.Point(84, 110);
            this.labelCreatedAt.Name = "labelCreatedAt";
            this.labelCreatedAt.Size = new System.Drawing.Size(38, 15);
            this.labelCreatedAt.TabIndex = 14;
            this.labelCreatedAt.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Created at:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "uid:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxContainers);
            this.groupBox3.Location = new System.Drawing.Point(40, 169);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Template Containers";
            // 
            // listBoxContainers
            // 
            this.listBoxContainers.FormattingEnabled = true;
            this.listBoxContainers.ItemHeight = 15;
            this.listBoxContainers.Location = new System.Drawing.Point(8, 15);
            this.listBoxContainers.Name = "listBoxContainers";
            this.listBoxContainers.Size = new System.Drawing.Size(186, 79);
            this.listBoxContainers.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBoxProgressing);
            this.groupBox2.Controls.Add(this.pictureBoxAvailable);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(40, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 91);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conditions";
            // 
            // pictureBoxProgressing
            // 
            this.pictureBoxProgressing.Image = global::femtokube.Properties.Resources.check;
            this.pictureBoxProgressing.Location = new System.Drawing.Point(21, 42);
            this.pictureBoxProgressing.Name = "pictureBoxProgressing";
            this.pictureBoxProgressing.Size = new System.Drawing.Size(31, 25);
            this.pictureBoxProgressing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxProgressing.TabIndex = 15;
            this.pictureBoxProgressing.TabStop = false;
            this.pictureBoxProgressing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxProgressing_MouseMove);
            // 
            // pictureBoxAvailable
            // 
            this.pictureBoxAvailable.Location = new System.Drawing.Point(142, 43);
            this.pictureBoxAvailable.Name = "pictureBoxAvailable";
            this.pictureBoxAvailable.Size = new System.Drawing.Size(31, 25);
            this.pictureBoxAvailable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAvailable.TabIndex = 7;
            this.pictureBoxAvailable.TabStop = false;
            this.pictureBoxAvailable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxAvailable_MouseMove);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(137, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Available";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Progressing";
            // 
            // DeploymentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(301, 384);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.labeluid);
            this.Controls.Add(this.labelCreatedAt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelDeploymentName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeploymentDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deployment Details";
            this.Load += new System.EventHandler(this.DeploymentDetails_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProgressing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvailable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelDeploymentName;
        private Label labeluid;
        private Label labelCreatedAt;
        private Label label2;
        private Label label3;
        private GroupBox groupBox3;
        private ListBox listBoxContainers;
        private GroupBox groupBox2;
        private PictureBox pictureBoxProgressing;
        private PictureBox pictureBoxAvailable;
        private Label label9;
        private Label label7;
        private ToolTip toolTip1;
    }
}