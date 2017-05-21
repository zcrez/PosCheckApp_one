namespace WizardDemo
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
            this.demoWizard = new WizardBase.WizardControl();
            this.start = new WizardBase.StartStep();
            this.middleStep = new WizardBase.IntermediateStep();
            this.finish = new WizardBase.FinishStep();
            this.startStep1 = new WizardBase.StartStep();
            this.SuspendLayout();
            // 
            // demoWizard
            // 
            this.demoWizard.BackButtonEnabled = true;
            this.demoWizard.BackButtonVisible = true;
            this.demoWizard.CancelButtonEnabled = true;
            this.demoWizard.CancelButtonVisible = true;
            this.demoWizard.HelpButtonEnabled = true;
            this.demoWizard.HelpButtonVisible = true;
            this.demoWizard.Location = new System.Drawing.Point(0, 0);
            this.demoWizard.Name = "demoWizard";
            this.demoWizard.NextButtonEnabled = true;
            this.demoWizard.NextButtonVisible = true;
            this.demoWizard.Size = new System.Drawing.Size(524, 367);
            this.demoWizard.WizardSteps.Add(this.start);
            this.demoWizard.WizardSteps.Add(this.middleStep);
            this.demoWizard.WizardSteps.Add(this.finish);
            this.demoWizard.CancelButtonClick += new System.EventHandler(this.demoWizard_CancelButtonClick);
            this.demoWizard.FinishButtonClick += new System.EventHandler(this.demoWizard_FinishButtonClick);
            // 
            // start
            // 
            this.start.BindingImage = ((System.Drawing.Image)(resources.GetObject("start.BindingImage")));
            this.start.Icon = ((System.Drawing.Image)(resources.GetObject("start.Icon")));
            this.start.Name = "start";
            this.start.Subtitle = "This is just a demo of the wizard control";
            this.start.SubtitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.start.Title = "Welcome to the Demowizard.";
            this.start.TitleFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            // 
            // middleStep
            // 
            this.middleStep.BindingImage = ((System.Drawing.Image)(resources.GetObject("middleStep.BindingImage")));
            this.middleStep.Name = "middleStep";
            this.middleStep.SubtitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.middleStep.Title = "New WizardControl step.";
            this.middleStep.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            // 
            // finish
            // 
            this.finish.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("finish.BackgroundImage")));
            this.finish.Name = "finish";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 364);
            this.Controls.Add(this.demoWizard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private WizardBase.WizardControl demoWizard;
        private WizardBase.StartStep start;
        private WizardBase.IntermediateStep middleStep;
        private WizardBase.FinishStep finish;
        private WizardBase.StartStep startStep1;
    }
}

