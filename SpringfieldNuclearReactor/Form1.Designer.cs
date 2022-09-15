namespace SpringfieldNuclearReactor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLable = new System.Windows.Forms.Label();
            this.reactor1Label = new System.Windows.Forms.Label();
            this.reactor2Label = new System.Windows.Forms.Label();
            this.reactor1StateLabel = new System.Windows.Forms.Label();
            this.reactor2StateLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.startReactorButton = new System.Windows.Forms.Button();
            this.reactor1Timer = new System.Windows.Forms.Timer(this.components);
            this.reactor2Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // titleLable
            // 
            this.titleLable.BackColor = System.Drawing.Color.Silver;
            this.titleLable.Font = new System.Drawing.Font("Engravers MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLable.Location = new System.Drawing.Point(-1, -1);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(541, 68);
            this.titleLable.TabIndex = 0;
            this.titleLable.Text = "Springfield Nuclear Reactor Control Panel";
            this.titleLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLable.Click += new System.EventHandler(this.titleLable_Click);
            // 
            // reactor1Label
            // 
            this.reactor1Label.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactor1Label.Location = new System.Drawing.Point(12, 123);
            this.reactor1Label.Name = "reactor1Label";
            this.reactor1Label.Size = new System.Drawing.Size(262, 23);
            this.reactor1Label.TabIndex = 1;
            this.reactor1Label.Text = "Reactor 1";
            this.reactor1Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // reactor2Label
            // 
            this.reactor2Label.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactor2Label.Location = new System.Drawing.Point(268, 123);
            this.reactor2Label.Name = "reactor2Label";
            this.reactor2Label.Size = new System.Drawing.Size(259, 23);
            this.reactor2Label.TabIndex = 2;
            this.reactor2Label.Text = "Reactor 2";
            this.reactor2Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // reactor1StateLabel
            // 
            this.reactor1StateLabel.BackColor = System.Drawing.Color.LawnGreen;
            this.reactor1StateLabel.Location = new System.Drawing.Point(45, 168);
            this.reactor1StateLabel.Name = "reactor1StateLabel";
            this.reactor1StateLabel.Size = new System.Drawing.Size(191, 156);
            this.reactor1StateLabel.TabIndex = 3;
            this.reactor1StateLabel.Click += new System.EventHandler(this.leftReactorClick);
            // 
            // reactor2StateLabel
            // 
            this.reactor2StateLabel.BackColor = System.Drawing.Color.LawnGreen;
            this.reactor2StateLabel.Location = new System.Drawing.Point(299, 168);
            this.reactor2StateLabel.Name = "reactor2StateLabel";
            this.reactor2StateLabel.Size = new System.Drawing.Size(191, 156);
            this.reactor2StateLabel.TabIndex = 4;
            this.reactor2StateLabel.Click += new System.EventHandler(this.rightReactorClick);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Silver;
            this.outputLabel.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(-2, 467);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(542, 52);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.Text = "Reactors Nominal";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // startReactorButton
            // 
            this.startReactorButton.BackColor = System.Drawing.Color.Honeydew;
            this.startReactorButton.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startReactorButton.Location = new System.Drawing.Point(145, 409);
            this.startReactorButton.Name = "startReactorButton";
            this.startReactorButton.Size = new System.Drawing.Size(243, 55);
            this.startReactorButton.TabIndex = 6;
            this.startReactorButton.Text = "Start Reactors";
            this.startReactorButton.UseVisualStyleBackColor = false;
            this.startReactorButton.Click += new System.EventHandler(this.startReactorButton_Click);
            // 
            // reactor1Timer
            // 
            this.reactor1Timer.Tick += new System.EventHandler(this.reactor1Timer_Tick);
            // 
            // reactor2Timer
            // 
            this.reactor2Timer.Interval = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(539, 516);
            this.Controls.Add(this.startReactorButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.reactor2StateLabel);
            this.Controls.Add(this.reactor1StateLabel);
            this.Controls.Add(this.reactor2Label);
            this.Controls.Add(this.reactor1Label);
            this.Controls.Add(this.titleLable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Springfield Nuclear Reactor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.Label reactor1Label;
        private System.Windows.Forms.Label reactor2Label;
        private System.Windows.Forms.Label reactor1StateLabel;
        private System.Windows.Forms.Label reactor2StateLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button startReactorButton;
        private System.Windows.Forms.Timer reactor1Timer;
        private System.Windows.Forms.Timer reactor2Timer;
    }
}

