
namespace PosCheckApp
{
    partial class projWard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(projWard));
            this.intermediateStep1 = new WizardBase.IntermediateStep();
            this.finishStep1 = new WizardBase.FinishStep();
            this.finishStep2 = new WizardBase.FinishStep();
            this.startStep1 = new WizardBase.StartStep();
            this.startStep2 = new WizardBase.StartStep();
            this.finishStep3 = new WizardBase.FinishStep();
            this.wizardControl1 = new WizardBase.WizardControl();
            this.startStep3 = new WizardBase.StartStep();
            this.intermediateStep2 = new WizardBase.IntermediateStep();
            this.finishStep4 = new WizardBase.FinishStep();
            this.projPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.projName = new System.Windows.Forms.TextBox();
            this.flyHeight = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_imagePath = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_posFile = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelimages = new System.Windows.Forms.Label();
            this.labelPos = new System.Windows.Forms.Label();
            this.startStep3.SuspendLayout();
            this.intermediateStep2.SuspendLayout();
            this.finishStep4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // intermediateStep1
            // 
            this.intermediateStep1.BindingImage = ((System.Drawing.Image)(resources.GetObject("intermediateStep1.BindingImage")));
            this.intermediateStep1.Name = "intermediateStep1";
            this.intermediateStep1.SubtitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.intermediateStep1.Title = "New WizardControl step.";
            this.intermediateStep1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            // 
            // finishStep1
            // 
            this.finishStep1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("finishStep1.BackgroundImage")));
            this.finishStep1.Name = "finishStep1";
            // 
            // finishStep2
            // 
            this.finishStep2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("finishStep2.BackgroundImage")));
            this.finishStep2.Name = "finishStep2";
            // 
            // startStep1
            // 
            this.startStep1.BindingImage = ((System.Drawing.Image)(resources.GetObject("startStep1.BindingImage")));
            this.startStep1.Icon = ((System.Drawing.Image)(resources.GetObject("startStep1.Icon")));
            this.startStep1.Name = "startStep1";
            this.startStep1.SubtitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.startStep1.Title = "Welcome to the DemoWizard.";
            this.startStep1.TitleFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            // 
            // startStep2
            // 
            this.startStep2.BindingImage = ((System.Drawing.Image)(resources.GetObject("startStep2.BindingImage")));
            this.startStep2.Icon = ((System.Drawing.Image)(resources.GetObject("startStep2.Icon")));
            this.startStep2.Name = "startStep2";
            this.startStep2.SubtitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.startStep2.Title = "Welcome to the DemoWizard.";
            this.startStep2.TitleFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            // 
            // finishStep3
            // 
            this.finishStep3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("finishStep3.BackgroundImage")));
            this.finishStep3.Name = "finishStep3";
            // 
            // wizardControl1
            // 
            this.wizardControl1.BackButtonEnabled = true;
            this.wizardControl1.BackButtonText = "< 上一步";
            this.wizardControl1.BackButtonVisible = true;
            this.wizardControl1.CancelButtonEnabled = true;
            this.wizardControl1.CancelButtonText = "取消";
            this.wizardControl1.CancelButtonVisible = true;
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.FinishButtonText = "建立工程";
            this.wizardControl1.HelpButtonEnabled = true;
            this.wizardControl1.HelpButtonVisible = true;
            this.wizardControl1.Location = new System.Drawing.Point(0, 0);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.NextButtonEnabled = false;
            this.wizardControl1.NextButtonText = "下一步 >";
            this.wizardControl1.NextButtonVisible = true;
            this.wizardControl1.Size = new System.Drawing.Size(653, 543);
            this.wizardControl1.WizardSteps.Add(this.startStep3);
            this.wizardControl1.WizardSteps.Add(this.intermediateStep2);
            this.wizardControl1.WizardSteps.Add(this.finishStep4);
            this.wizardControl1.CancelButtonClick += new System.EventHandler(this.wizardControl1_CancelButtonClick);
            this.wizardControl1.FinishButtonClick += new System.EventHandler(this.wizardControl1_FinishButtonClick);
            // 
            // startStep3
            // 
            this.startStep3.BindingImage = ((System.Drawing.Image)(resources.GetObject("startStep3.BindingImage")));
            this.startStep3.Controls.Add(this.flyHeight);
            this.startStep3.Controls.Add(this.projPath);
            this.startStep3.Controls.Add(this.label1);
            this.startStep3.Controls.Add(this.label2);
            this.startStep3.Controls.Add(this.button1);
            this.startStep3.Controls.Add(this.label4);
            this.startStep3.Controls.Add(this.label3);
            this.startStep3.Controls.Add(this.projName);
            this.startStep3.Icon = ((System.Drawing.Image)(resources.GetObject("startStep3.Icon")));
            this.startStep3.Name = "startStep3";
            this.startStep3.Subtitle = "该向导帮你创建一个新项目";
            this.startStep3.SubtitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.startStep3.Title = "新建像控项目";
            this.startStep3.TitleFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            // 
            // intermediateStep2
            // 
            this.intermediateStep2.BindingImage = ((System.Drawing.Image)(resources.GetObject("intermediateStep2.BindingImage")));
            this.intermediateStep2.Controls.Add(this.labelPos);
            this.intermediateStep2.Controls.Add(this.labelimages);
            this.intermediateStep2.Controls.Add(this.btn_posFile);
            this.intermediateStep2.Controls.Add(this.label6);
            this.intermediateStep2.Controls.Add(this.btn_imagePath);
            this.intermediateStep2.Controls.Add(this.label5);
            this.intermediateStep2.Name = "intermediateStep2";
            this.intermediateStep2.Subtitle = "照片与POS的对应";
            this.intermediateStep2.SubtitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.intermediateStep2.Title = "导入照片和POS信息";
            this.intermediateStep2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            // 
            // finishStep4
            // 
            this.finishStep4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("finishStep4.BackgroundImage")));
            this.finishStep4.Controls.Add(this.label7);
            this.finishStep4.Name = "finishStep4";
            // 
            // projPath
            // 
            this.projPath.Location = new System.Drawing.Point(257, 253);
            this.projPath.Name = "projPath";
            this.projPath.Size = new System.Drawing.Size(290, 21);
            this.projPath.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "本步在于选择照片文件夹,设置工程名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "工程名:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "浏览";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "文件夹:";
            // 
            // projName
            // 
            this.projName.Location = new System.Drawing.Point(257, 195);
            this.projName.Name = "projName";
            this.projName.Size = new System.Drawing.Size(371, 21);
            this.projName.TabIndex = 15;
            this.projName.TextChanged += new System.EventHandler(this.projName_TextChanged);
            // 
            // flyHeight
            // 
            this.flyHeight.Location = new System.Drawing.Point(257, 310);
            this.flyHeight.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.flyHeight.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.flyHeight.Name = "flyHeight";
            this.flyHeight.Size = new System.Drawing.Size(120, 21);
            this.flyHeight.TabIndex = 18;
            this.flyHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "飞行高度：";
            // 
            // btn_imagePath
            // 
            this.btn_imagePath.Location = new System.Drawing.Point(205, 152);
            this.btn_imagePath.Name = "btn_imagePath";
            this.btn_imagePath.Size = new System.Drawing.Size(90, 23);
            this.btn_imagePath.TabIndex = 19;
            this.btn_imagePath.Text = "请选择文件夹";
            this.btn_imagePath.UseVisualStyleBackColor = true;
            this.btn_imagePath.Click += new System.EventHandler(this.btn_imagePath_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "原始航片导入:";
            // 
            // btn_posFile
            // 
            this.btn_posFile.Location = new System.Drawing.Point(205, 273);
            this.btn_posFile.Name = "btn_posFile";
            this.btn_posFile.Size = new System.Drawing.Size(112, 23);
            this.btn_posFile.TabIndex = 22;
            this.btn_posFile.Text = "请选择pos文件";
            this.btn_posFile.UseVisualStyleBackColor = true;
            this.btn_posFile.Click += new System.EventHandler(this.btn_posFile_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "Pos文件信息导入:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(383, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "照片与POS位置还未对齐，请于图形工程界面对齐位置后，再保存工程。";
            // 
            // labelimages
            // 
            this.labelimages.Location = new System.Drawing.Point(145, 217);
            this.labelimages.Name = "labelimages";
            this.labelimages.Size = new System.Drawing.Size(387, 23);
            this.labelimages.TabIndex = 23;
            // 
            // labelPos
            // 
            this.labelPos.Location = new System.Drawing.Point(145, 324);
            this.labelPos.Name = "labelPos";
            this.labelPos.Size = new System.Drawing.Size(387, 23);
            this.labelPos.TabIndex = 23;
            // 
            // projWard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(653, 543);
            this.Controls.Add(this.wizardControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "projWard";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "新建";
            this.Load += new System.EventHandler(this.projWard_Load);
            this.startStep3.ResumeLayout(false);
            this.startStep3.PerformLayout();
            this.intermediateStep2.ResumeLayout(false);
            this.intermediateStep2.PerformLayout();
            this.finishStep4.ResumeLayout(false);
            this.finishStep4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WizardBase.IntermediateStep intermediateStep1;
        private WizardBase.FinishStep finishStep1;
        private WizardBase.FinishStep finishStep2;
        private WizardBase.StartStep startStep1;
        private WizardBase.FinishStep finishStep3;
        private WizardBase.StartStep startStep2;
        private WizardBase.WizardControl wizardControl1;
        private WizardBase.StartStep startStep3;
        private WizardBase.IntermediateStep intermediateStep2;
        private WizardBase.FinishStep finishStep4;
        private System.Windows.Forms.TextBox projPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox projName;
        private System.Windows.Forms.NumericUpDown flyHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_posFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_imagePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelPos;
        private System.Windows.Forms.Label labelimages;
    }
}