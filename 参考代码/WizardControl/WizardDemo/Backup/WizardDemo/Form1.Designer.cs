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
            this.SuspendLayout();
            // 
            // demoWizard
            // 
            this.demoWizard.BackButtonEnabled = false;
            this.demoWizard.BackButtonVisible = true;
            this.demoWizard.CancelButtonEnabled = true;
            this.demoWizard.CancelButtonVisible = true;
            this.demoWizard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.demoWizard.HelpButtonEnabled = true;
            this.demoWizard.HelpButtonVisible = true;
            this.demoWizard.Location = new System.Drawing.Point(0, 0);
            this.demoWizard.Name = "demoWizard";
            this.demoWizard.NextButtonEnabled = true;
            this.demoWizard.NextButtonVisible = true;
            this.demoWizard.Size = new System.Drawing.Size(524, 394);
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
            this.start.Title = "Welcome to the Demowizard.";
            // 
            // middleStep
            // 
            this.middleStep.BindingImage = ((System.Drawing.Image)(resources.GetObject("middleStep.BindingImage")));
            this.middleStep.Name = "middleStep";
            this.middleStep.Title = "New WizardControl step.";
            // 
            // finish
            // 
            this.finish.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("finish.BackgroundImage")));
            this.finish.Name = "finish";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 394);
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
    }
}

