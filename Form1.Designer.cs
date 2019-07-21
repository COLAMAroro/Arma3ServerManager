namespace ArmaServerSelector
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
            this.SelectModPath = new System.Windows.Forms.Button();
            this.ModDirPath = new System.Windows.Forms.TextBox();
            this.ModList = new System.Windows.Forms.CheckedListBox();
            this.SelectProfile = new System.Windows.Forms.Button();
            this.ProfilePath = new System.Windows.Forms.TextBox();
            this.ConfPath = new System.Windows.Forms.TextBox();
            this.SelectConfigFile = new System.Windows.Forms.Button();
            this.BinPath = new System.Windows.Forms.TextBox();
            this.SelectBin = new System.Windows.Forms.Button();
            this.Credit = new System.Windows.Forms.LinkLabel();
            this.SaveConf = new System.Windows.Forms.Button();
            this.LoadConf = new System.Windows.Forms.Button();
            this.Run = new System.Windows.Forms.Button();
            this.LabelArgs = new System.Windows.Forms.Label();
            this.OptionalArgs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SelectModPath
            // 
            this.SelectModPath.Location = new System.Drawing.Point(5, 5);
            this.SelectModPath.Name = "SelectModPath";
            this.SelectModPath.Size = new System.Drawing.Size(125, 23);
            this.SelectModPath.TabIndex = 0;
            this.SelectModPath.Text = "Select Mods Directory";
            this.SelectModPath.UseVisualStyleBackColor = true;
            this.SelectModPath.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ModDirPath
            // 
            this.ModDirPath.Location = new System.Drawing.Point(136, 7);
            this.ModDirPath.Name = "ModDirPath";
            this.ModDirPath.Size = new System.Drawing.Size(225, 20);
            this.ModDirPath.TabIndex = 1;
            this.ModDirPath.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // ModList
            // 
            this.ModList.FormattingEnabled = true;
            this.ModList.Location = new System.Drawing.Point(5, 33);
            this.ModList.Name = "ModList";
            this.ModList.Size = new System.Drawing.Size(356, 409);
            this.ModList.TabIndex = 2;
            this.ModList.SelectedIndexChanged += new System.EventHandler(this.ModList_SelectedIndexChanged);
            // 
            // SelectProfile
            // 
            this.SelectProfile.Location = new System.Drawing.Point(367, 7);
            this.SelectProfile.Name = "SelectProfile";
            this.SelectProfile.Size = new System.Drawing.Size(421, 20);
            this.SelectProfile.TabIndex = 3;
            this.SelectProfile.Text = "Select Profile Directory";
            this.SelectProfile.UseVisualStyleBackColor = true;
            this.SelectProfile.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // ProfilePath
            // 
            this.ProfilePath.Location = new System.Drawing.Point(367, 33);
            this.ProfilePath.Name = "ProfilePath";
            this.ProfilePath.Size = new System.Drawing.Size(421, 20);
            this.ProfilePath.TabIndex = 4;
            // 
            // ConfPath
            // 
            this.ConfPath.Location = new System.Drawing.Point(367, 98);
            this.ConfPath.Name = "ConfPath";
            this.ConfPath.Size = new System.Drawing.Size(421, 20);
            this.ConfPath.TabIndex = 6;
            this.ConfPath.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            // 
            // SelectConfigFile
            // 
            this.SelectConfigFile.Location = new System.Drawing.Point(367, 72);
            this.SelectConfigFile.Name = "SelectConfigFile";
            this.SelectConfigFile.Size = new System.Drawing.Size(421, 20);
            this.SelectConfigFile.TabIndex = 5;
            this.SelectConfigFile.Text = "Select Configuration File";
            this.SelectConfigFile.UseVisualStyleBackColor = true;
            this.SelectConfigFile.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // BinPath
            // 
            this.BinPath.Location = new System.Drawing.Point(367, 162);
            this.BinPath.Name = "BinPath";
            this.BinPath.Size = new System.Drawing.Size(421, 20);
            this.BinPath.TabIndex = 8;
            // 
            // SelectBin
            // 
            this.SelectBin.Location = new System.Drawing.Point(367, 136);
            this.SelectBin.Name = "SelectBin";
            this.SelectBin.Size = new System.Drawing.Size(421, 20);
            this.SelectBin.TabIndex = 7;
            this.SelectBin.Text = "Select Executable File";
            this.SelectBin.UseVisualStyleBackColor = true;
            this.SelectBin.Click += new System.EventHandler(this.SelectBin_Click);
            // 
            // Credit
            // 
            this.Credit.AutoSize = true;
            this.Credit.Location = new System.Drawing.Point(524, 236);
            this.Credit.Name = "Credit";
            this.Credit.Size = new System.Drawing.Size(124, 13);
            this.Credit.TabIndex = 9;
            this.Credit.TabStop = true;
            this.Credit.Text = "Made by @COLAMAroro";
            this.Credit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Credit_LinkClicked);
            // 
            // SaveConf
            // 
            this.SaveConf.Location = new System.Drawing.Point(367, 252);
            this.SaveConf.Name = "SaveConf";
            this.SaveConf.Size = new System.Drawing.Size(210, 62);
            this.SaveConf.TabIndex = 10;
            this.SaveConf.Text = "Save Configuration";
            this.SaveConf.UseVisualStyleBackColor = true;
            this.SaveConf.Click += new System.EventHandler(this.SaveConf_Click);
            // 
            // LoadConf
            // 
            this.LoadConf.Location = new System.Drawing.Point(583, 252);
            this.LoadConf.Name = "LoadConf";
            this.LoadConf.Size = new System.Drawing.Size(205, 62);
            this.LoadConf.TabIndex = 11;
            this.LoadConf.Text = "Load Configuration";
            this.LoadConf.UseVisualStyleBackColor = true;
            this.LoadConf.Click += new System.EventHandler(this.LoadConf_Click);
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(367, 320);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(421, 122);
            this.Run.TabIndex = 12;
            this.Run.Text = "Run the Server";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // LabelArgs
            // 
            this.LabelArgs.AutoSize = true;
            this.LabelArgs.Location = new System.Drawing.Point(524, 197);
            this.LabelArgs.Name = "LabelArgs";
            this.LabelArgs.Size = new System.Drawing.Size(105, 13);
            this.LabelArgs.TabIndex = 13;
            this.LabelArgs.Text = "Additional arguments";
            this.LabelArgs.Click += new System.EventHandler(this.Label1_Click);
            // 
            // OptionalArgs
            // 
            this.OptionalArgs.Location = new System.Drawing.Point(367, 213);
            this.OptionalArgs.Name = "OptionalArgs";
            this.OptionalArgs.Size = new System.Drawing.Size(421, 20);
            this.OptionalArgs.TabIndex = 14;
            this.OptionalArgs.TextChanged += new System.EventHandler(this.OptionalArgs_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OptionalArgs);
            this.Controls.Add(this.LabelArgs);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.LoadConf);
            this.Controls.Add(this.SaveConf);
            this.Controls.Add(this.Credit);
            this.Controls.Add(this.BinPath);
            this.Controls.Add(this.SelectBin);
            this.Controls.Add(this.ConfPath);
            this.Controls.Add(this.SelectConfigFile);
            this.Controls.Add(this.ProfilePath);
            this.Controls.Add(this.SelectProfile);
            this.Controls.Add(this.ModList);
            this.Controls.Add(this.ModDirPath);
            this.Controls.Add(this.SelectModPath);
            this.Name = "Form1";
            this.Text = "Arma 3 Mod Selector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectModPath;
        private System.Windows.Forms.TextBox ModDirPath;
        private System.Windows.Forms.CheckedListBox ModList;
        private System.Windows.Forms.Button SelectProfile;
        private System.Windows.Forms.TextBox ProfilePath;
        private System.Windows.Forms.TextBox ConfPath;
        private System.Windows.Forms.Button SelectConfigFile;
        private System.Windows.Forms.TextBox BinPath;
        private System.Windows.Forms.Button SelectBin;
        private System.Windows.Forms.LinkLabel Credit;
        private System.Windows.Forms.Button SaveConf;
        private System.Windows.Forms.Button LoadConf;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Label LabelArgs;
        private System.Windows.Forms.TextBox OptionalArgs;
    }
}

