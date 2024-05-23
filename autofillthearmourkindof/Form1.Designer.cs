namespace autofillthearmourkindof
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
            this.addtohumanmale = new System.Windows.Forms.Button();
            this.HumanMaleList = new System.Windows.Forms.ListBox();
            this.HumanMaleInput = new System.Windows.Forms.TextBox();
            this.Removefromhumanmalelist = new System.Windows.Forms.Button();
            this.Writetofile = new System.Windows.Forms.Button();
            this.HumanFemaleList = new System.Windows.Forms.ListBox();
            this.HumanFemaleInput = new System.Windows.Forms.TextBox();
            this.addtohumanfemale = new System.Windows.Forms.Button();
            this.removefromhumanfemale = new System.Windows.Forms.Button();
            this.StrongMaleList = new System.Windows.Forms.ListBox();
            this.StrongFemaleList = new System.Windows.Forms.ListBox();
            this.StrongFemaleInput = new System.Windows.Forms.TextBox();
            this.StrongMaleInput = new System.Windows.Forms.TextBox();
            this.AddtoStrongMale = new System.Windows.Forms.Button();
            this.RemoveFromStrongMale = new System.Windows.Forms.Button();
            this.AddtoStrongFemale = new System.Windows.Forms.Button();
            this.RemovefromStrongFemale = new System.Windows.Forms.Button();
            this.GithyankiMList = new System.Windows.Forms.ListBox();
            this.GithyankiMInput = new System.Windows.Forms.TextBox();
            this.AddtoDwarfM = new System.Windows.Forms.Button();
            this.RemoveFromDwarfM = new System.Windows.Forms.Button();
            this.RemoveFromDwarfF = new System.Windows.Forms.Button();
            this.AddtoDwarfF = new System.Windows.Forms.Button();
            this.GithyankiFInput = new System.Windows.Forms.TextBox();
            this.GithyankiFList = new System.Windows.Forms.ListBox();
            this.RemoveFromGithyankiM = new System.Windows.Forms.Button();
            this.AddtoGithyankiM = new System.Windows.Forms.Button();
            this.DwarfMInput = new System.Windows.Forms.TextBox();
            this.DwarfMList = new System.Windows.Forms.ListBox();
            this.RemoveFromGithyankiF = new System.Windows.Forms.Button();
            this.AddtoGithyankiF = new System.Windows.Forms.Button();
            this.DwarfFInput = new System.Windows.Forms.TextBox();
            this.DwarfFList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addtohumanmale
            // 
            this.addtohumanmale.Location = new System.Drawing.Point(12, 139);
            this.addtohumanmale.Name = "addtohumanmale";
            this.addtohumanmale.Size = new System.Drawing.Size(75, 23);
            this.addtohumanmale.TabIndex = 0;
            this.addtohumanmale.Text = "Add UUID";
            this.addtohumanmale.UseVisualStyleBackColor = true;
            this.addtohumanmale.Click += new System.EventHandler(this.button1_Click);
            // 
            // HumanMaleList
            // 
            this.HumanMaleList.FormattingEnabled = true;
            this.HumanMaleList.Location = new System.Drawing.Point(12, 12);
            this.HumanMaleList.Name = "HumanMaleList";
            this.HumanMaleList.Size = new System.Drawing.Size(187, 95);
            this.HumanMaleList.TabIndex = 1;
            // 
            // HumanMaleInput
            // 
            this.HumanMaleInput.Location = new System.Drawing.Point(12, 113);
            this.HumanMaleInput.Name = "HumanMaleInput";
            this.HumanMaleInput.Size = new System.Drawing.Size(187, 20);
            this.HumanMaleInput.TabIndex = 2;
            this.HumanMaleInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Removefromhumanmalelist
            // 
            this.Removefromhumanmalelist.Location = new System.Drawing.Point(109, 139);
            this.Removefromhumanmalelist.Name = "Removefromhumanmalelist";
            this.Removefromhumanmalelist.Size = new System.Drawing.Size(90, 23);
            this.Removefromhumanmalelist.TabIndex = 3;
            this.Removefromhumanmalelist.Text = "Remove UUID";
            this.Removefromhumanmalelist.UseVisualStyleBackColor = true;
            this.Removefromhumanmalelist.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Writetofile
            // 
            this.Writetofile.Location = new System.Drawing.Point(701, 575);
            this.Writetofile.Name = "Writetofile";
            this.Writetofile.Size = new System.Drawing.Size(75, 23);
            this.Writetofile.TabIndex = 4;
            this.Writetofile.Text = "save?";
            this.Writetofile.UseVisualStyleBackColor = true;
            this.Writetofile.Click += new System.EventHandler(this.Writetofile_Click);
            // 
            // HumanFemaleList
            // 
            this.HumanFemaleList.FormattingEnabled = true;
            this.HumanFemaleList.Location = new System.Drawing.Point(206, 13);
            this.HumanFemaleList.Name = "HumanFemaleList";
            this.HumanFemaleList.Size = new System.Drawing.Size(187, 95);
            this.HumanFemaleList.TabIndex = 5;
            // 
            // HumanFemaleInput
            // 
            this.HumanFemaleInput.Location = new System.Drawing.Point(206, 112);
            this.HumanFemaleInput.Name = "HumanFemaleInput";
            this.HumanFemaleInput.Size = new System.Drawing.Size(187, 20);
            this.HumanFemaleInput.TabIndex = 6;
            // 
            // addtohumanfemale
            // 
            this.addtohumanfemale.Location = new System.Drawing.Point(206, 139);
            this.addtohumanfemale.Name = "addtohumanfemale";
            this.addtohumanfemale.Size = new System.Drawing.Size(75, 23);
            this.addtohumanfemale.TabIndex = 7;
            this.addtohumanfemale.Text = "Add UUID";
            this.addtohumanfemale.UseVisualStyleBackColor = true;
            this.addtohumanfemale.Click += new System.EventHandler(this.addtohumanfemale_Click);
            // 
            // removefromhumanfemale
            // 
            this.removefromhumanfemale.Location = new System.Drawing.Point(307, 138);
            this.removefromhumanfemale.Name = "removefromhumanfemale";
            this.removefromhumanfemale.Size = new System.Drawing.Size(86, 23);
            this.removefromhumanfemale.TabIndex = 8;
            this.removefromhumanfemale.Text = "Remove UUID";
            this.removefromhumanfemale.UseVisualStyleBackColor = true;
            this.removefromhumanfemale.Click += new System.EventHandler(this.removefromhumanfemale_Click);
            // 
            // StrongMaleList
            // 
            this.StrongMaleList.FormattingEnabled = true;
            this.StrongMaleList.Location = new System.Drawing.Point(399, 13);
            this.StrongMaleList.Name = "StrongMaleList";
            this.StrongMaleList.Size = new System.Drawing.Size(187, 95);
            this.StrongMaleList.TabIndex = 9;
            // 
            // StrongFemaleList
            // 
            this.StrongFemaleList.FormattingEnabled = true;
            this.StrongFemaleList.Location = new System.Drawing.Point(592, 12);
            this.StrongFemaleList.Name = "StrongFemaleList";
            this.StrongFemaleList.Size = new System.Drawing.Size(187, 95);
            this.StrongFemaleList.TabIndex = 10;
            // 
            // StrongFemaleInput
            // 
            this.StrongFemaleInput.Location = new System.Drawing.Point(592, 113);
            this.StrongFemaleInput.Name = "StrongFemaleInput";
            this.StrongFemaleInput.Size = new System.Drawing.Size(187, 20);
            this.StrongFemaleInput.TabIndex = 11;
            // 
            // StrongMaleInput
            // 
            this.StrongMaleInput.Location = new System.Drawing.Point(399, 112);
            this.StrongMaleInput.Name = "StrongMaleInput";
            this.StrongMaleInput.Size = new System.Drawing.Size(187, 20);
            this.StrongMaleInput.TabIndex = 12;
            // 
            // AddtoStrongMale
            // 
            this.AddtoStrongMale.Location = new System.Drawing.Point(399, 139);
            this.AddtoStrongMale.Name = "AddtoStrongMale";
            this.AddtoStrongMale.Size = new System.Drawing.Size(75, 23);
            this.AddtoStrongMale.TabIndex = 13;
            this.AddtoStrongMale.Text = "Add UUID";
            this.AddtoStrongMale.UseVisualStyleBackColor = true;
            this.AddtoStrongMale.Click += new System.EventHandler(this.AddtoStrongMale_Click);
            // 
            // RemoveFromStrongMale
            // 
            this.RemoveFromStrongMale.Location = new System.Drawing.Point(497, 139);
            this.RemoveFromStrongMale.Name = "RemoveFromStrongMale";
            this.RemoveFromStrongMale.Size = new System.Drawing.Size(89, 23);
            this.RemoveFromStrongMale.TabIndex = 14;
            this.RemoveFromStrongMale.Text = "Remove UUID";
            this.RemoveFromStrongMale.UseVisualStyleBackColor = true;
            this.RemoveFromStrongMale.Click += new System.EventHandler(this.RemoveFromStrongMale_Click);
            // 
            // AddtoStrongFemale
            // 
            this.AddtoStrongFemale.Location = new System.Drawing.Point(592, 138);
            this.AddtoStrongFemale.Name = "AddtoStrongFemale";
            this.AddtoStrongFemale.Size = new System.Drawing.Size(75, 23);
            this.AddtoStrongFemale.TabIndex = 15;
            this.AddtoStrongFemale.Text = "Add UUID";
            this.AddtoStrongFemale.UseVisualStyleBackColor = true;
            this.AddtoStrongFemale.Click += new System.EventHandler(this.AddtoStrongFemale_Click);
            // 
            // RemovefromStrongFemale
            // 
            this.RemovefromStrongFemale.Location = new System.Drawing.Point(687, 139);
            this.RemovefromStrongFemale.Name = "RemovefromStrongFemale";
            this.RemovefromStrongFemale.Size = new System.Drawing.Size(89, 23);
            this.RemovefromStrongFemale.TabIndex = 16;
            this.RemovefromStrongFemale.Text = "Remove UUID";
            this.RemovefromStrongFemale.UseVisualStyleBackColor = true;
            this.RemovefromStrongFemale.Click += new System.EventHandler(this.RemovefromStrongFemale_Click);
            // 
            // GithyankiMList
            // 
            this.GithyankiMList.FormattingEnabled = true;
            this.GithyankiMList.Location = new System.Drawing.Point(12, 168);
            this.GithyankiMList.Name = "GithyankiMList";
            this.GithyankiMList.Size = new System.Drawing.Size(187, 95);
            this.GithyankiMList.TabIndex = 17;
            // 
            // GithyankiMInput
            // 
            this.GithyankiMInput.Location = new System.Drawing.Point(12, 269);
            this.GithyankiMInput.Name = "GithyankiMInput";
            this.GithyankiMInput.Size = new System.Drawing.Size(187, 20);
            this.GithyankiMInput.TabIndex = 18;
            // 
            // AddtoDwarfM
            // 
            this.AddtoDwarfM.Location = new System.Drawing.Point(399, 295);
            this.AddtoDwarfM.Name = "AddtoDwarfM";
            this.AddtoDwarfM.Size = new System.Drawing.Size(75, 23);
            this.AddtoDwarfM.TabIndex = 19;
            this.AddtoDwarfM.Text = "Add UUID";
            this.AddtoDwarfM.UseVisualStyleBackColor = true;
            this.AddtoDwarfM.Click += new System.EventHandler(this.AddtoDwarfM_Click);
            // 
            // RemoveFromDwarfM
            // 
            this.RemoveFromDwarfM.Location = new System.Drawing.Point(497, 294);
            this.RemoveFromDwarfM.Name = "RemoveFromDwarfM";
            this.RemoveFromDwarfM.Size = new System.Drawing.Size(90, 23);
            this.RemoveFromDwarfM.TabIndex = 20;
            this.RemoveFromDwarfM.Text = "Remove UUID";
            this.RemoveFromDwarfM.UseVisualStyleBackColor = true;
            this.RemoveFromDwarfM.Click += new System.EventHandler(this.RemoveFromDwarfM_Click);
            // 
            // RemoveFromDwarfF
            // 
            this.RemoveFromDwarfF.Location = new System.Drawing.Point(689, 295);
            this.RemoveFromDwarfF.Name = "RemoveFromDwarfF";
            this.RemoveFromDwarfF.Size = new System.Drawing.Size(90, 23);
            this.RemoveFromDwarfF.TabIndex = 24;
            this.RemoveFromDwarfF.Text = "Remove UUID";
            this.RemoveFromDwarfF.UseVisualStyleBackColor = true;
            this.RemoveFromDwarfF.Click += new System.EventHandler(this.RemoveFromDwarfF_Click);
            // 
            // AddtoDwarfF
            // 
            this.AddtoDwarfF.Location = new System.Drawing.Point(592, 295);
            this.AddtoDwarfF.Name = "AddtoDwarfF";
            this.AddtoDwarfF.Size = new System.Drawing.Size(75, 23);
            this.AddtoDwarfF.TabIndex = 23;
            this.AddtoDwarfF.Text = "Add UUID";
            this.AddtoDwarfF.UseVisualStyleBackColor = true;
            this.AddtoDwarfF.Click += new System.EventHandler(this.AddtoDwarfF_Click);
            // 
            // GithyankiFInput
            // 
            this.GithyankiFInput.Location = new System.Drawing.Point(206, 268);
            this.GithyankiFInput.Name = "GithyankiFInput";
            this.GithyankiFInput.Size = new System.Drawing.Size(187, 20);
            this.GithyankiFInput.TabIndex = 22;
            // 
            // GithyankiFList
            // 
            this.GithyankiFList.FormattingEnabled = true;
            this.GithyankiFList.Location = new System.Drawing.Point(206, 167);
            this.GithyankiFList.Name = "GithyankiFList";
            this.GithyankiFList.Size = new System.Drawing.Size(187, 95);
            this.GithyankiFList.TabIndex = 21;
            // 
            // RemoveFromGithyankiM
            // 
            this.RemoveFromGithyankiM.Location = new System.Drawing.Point(110, 295);
            this.RemoveFromGithyankiM.Name = "RemoveFromGithyankiM";
            this.RemoveFromGithyankiM.Size = new System.Drawing.Size(90, 23);
            this.RemoveFromGithyankiM.TabIndex = 28;
            this.RemoveFromGithyankiM.Text = "Remove UUID";
            this.RemoveFromGithyankiM.UseVisualStyleBackColor = true;
            this.RemoveFromGithyankiM.Click += new System.EventHandler(this.RemoveFromGithyankiM_Click);
            // 
            // AddtoGithyankiM
            // 
            this.AddtoGithyankiM.Location = new System.Drawing.Point(12, 295);
            this.AddtoGithyankiM.Name = "AddtoGithyankiM";
            this.AddtoGithyankiM.Size = new System.Drawing.Size(75, 23);
            this.AddtoGithyankiM.TabIndex = 27;
            this.AddtoGithyankiM.Text = "Add UUID";
            this.AddtoGithyankiM.UseVisualStyleBackColor = true;
            this.AddtoGithyankiM.Click += new System.EventHandler(this.AddtoGithyankiM_Click);
            // 
            // DwarfMInput
            // 
            this.DwarfMInput.Location = new System.Drawing.Point(399, 268);
            this.DwarfMInput.Name = "DwarfMInput";
            this.DwarfMInput.Size = new System.Drawing.Size(187, 20);
            this.DwarfMInput.TabIndex = 26;
            // 
            // DwarfMList
            // 
            this.DwarfMList.FormattingEnabled = true;
            this.DwarfMList.Location = new System.Drawing.Point(399, 167);
            this.DwarfMList.Name = "DwarfMList";
            this.DwarfMList.Size = new System.Drawing.Size(187, 95);
            this.DwarfMList.TabIndex = 25;
            // 
            // RemoveFromGithyankiF
            // 
            this.RemoveFromGithyankiF.Location = new System.Drawing.Point(303, 295);
            this.RemoveFromGithyankiF.Name = "RemoveFromGithyankiF";
            this.RemoveFromGithyankiF.Size = new System.Drawing.Size(90, 23);
            this.RemoveFromGithyankiF.TabIndex = 32;
            this.RemoveFromGithyankiF.Text = "Remove UUID";
            this.RemoveFromGithyankiF.UseVisualStyleBackColor = true;
            this.RemoveFromGithyankiF.Click += new System.EventHandler(this.RemoveFromGithyankiF_Click);
            // 
            // AddtoGithyankiF
            // 
            this.AddtoGithyankiF.Location = new System.Drawing.Point(206, 295);
            this.AddtoGithyankiF.Name = "AddtoGithyankiF";
            this.AddtoGithyankiF.Size = new System.Drawing.Size(75, 23);
            this.AddtoGithyankiF.TabIndex = 31;
            this.AddtoGithyankiF.Text = "Add UUID";
            this.AddtoGithyankiF.UseVisualStyleBackColor = true;
            this.AddtoGithyankiF.Click += new System.EventHandler(this.AddtoGithyankiF_Click);
            // 
            // DwarfFInput
            // 
            this.DwarfFInput.Location = new System.Drawing.Point(592, 269);
            this.DwarfFInput.Name = "DwarfFInput";
            this.DwarfFInput.Size = new System.Drawing.Size(187, 20);
            this.DwarfFInput.TabIndex = 30;
            // 
            // DwarfFList
            // 
            this.DwarfFList.FormattingEnabled = true;
            this.DwarfFList.Location = new System.Drawing.Point(592, 168);
            this.DwarfFList.Name = "DwarfFList";
            this.DwarfFList.Size = new System.Drawing.Size(187, 95);
            this.DwarfFList.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 610);
            this.Controls.Add(this.RemoveFromGithyankiF);
            this.Controls.Add(this.AddtoGithyankiF);
            this.Controls.Add(this.DwarfFInput);
            this.Controls.Add(this.DwarfFList);
            this.Controls.Add(this.RemoveFromGithyankiM);
            this.Controls.Add(this.AddtoGithyankiM);
            this.Controls.Add(this.DwarfMInput);
            this.Controls.Add(this.DwarfMList);
            this.Controls.Add(this.RemoveFromDwarfF);
            this.Controls.Add(this.AddtoDwarfF);
            this.Controls.Add(this.GithyankiFInput);
            this.Controls.Add(this.GithyankiFList);
            this.Controls.Add(this.RemoveFromDwarfM);
            this.Controls.Add(this.AddtoDwarfM);
            this.Controls.Add(this.GithyankiMInput);
            this.Controls.Add(this.GithyankiMList);
            this.Controls.Add(this.RemovefromStrongFemale);
            this.Controls.Add(this.AddtoStrongFemale);
            this.Controls.Add(this.RemoveFromStrongMale);
            this.Controls.Add(this.AddtoStrongMale);
            this.Controls.Add(this.StrongMaleInput);
            this.Controls.Add(this.StrongFemaleInput);
            this.Controls.Add(this.StrongFemaleList);
            this.Controls.Add(this.StrongMaleList);
            this.Controls.Add(this.removefromhumanfemale);
            this.Controls.Add(this.addtohumanfemale);
            this.Controls.Add(this.HumanFemaleInput);
            this.Controls.Add(this.HumanFemaleList);
            this.Controls.Add(this.Writetofile);
            this.Controls.Add(this.Removefromhumanmalelist);
            this.Controls.Add(this.HumanMaleInput);
            this.Controls.Add(this.HumanMaleList);
            this.Controls.Add(this.addtohumanmale);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addtohumanmale;
        private System.Windows.Forms.ListBox HumanMaleList;
        private System.Windows.Forms.TextBox HumanMaleInput;
        private System.Windows.Forms.Button Removefromhumanmalelist;
        private System.Windows.Forms.Button Writetofile;
        private System.Windows.Forms.ListBox HumanFemaleList;
        private System.Windows.Forms.TextBox HumanFemaleInput;
        private System.Windows.Forms.Button addtohumanfemale;
        private System.Windows.Forms.Button removefromhumanfemale;
        private System.Windows.Forms.ListBox StrongMaleList;
        private System.Windows.Forms.ListBox StrongFemaleList;
        private System.Windows.Forms.TextBox StrongFemaleInput;
        private System.Windows.Forms.TextBox StrongMaleInput;
        private System.Windows.Forms.Button AddtoStrongMale;
        private System.Windows.Forms.Button RemoveFromStrongMale;
        private System.Windows.Forms.Button AddtoStrongFemale;
        private System.Windows.Forms.Button RemovefromStrongFemale;
        private System.Windows.Forms.ListBox GithyankiMList;
        private System.Windows.Forms.TextBox GithyankiMInput;
        private System.Windows.Forms.Button AddtoDwarfM;
        private System.Windows.Forms.Button RemoveFromDwarfM;
        private System.Windows.Forms.Button RemoveFromDwarfF;
        private System.Windows.Forms.Button AddtoDwarfF;
        private System.Windows.Forms.TextBox GithyankiFInput;
        private System.Windows.Forms.ListBox GithyankiFList;
        private System.Windows.Forms.Button RemoveFromGithyankiM;
        private System.Windows.Forms.Button AddtoGithyankiM;
        private System.Windows.Forms.TextBox DwarfMInput;
        private System.Windows.Forms.ListBox DwarfMList;
        private System.Windows.Forms.Button RemoveFromGithyankiF;
        private System.Windows.Forms.Button AddtoGithyankiF;
        private System.Windows.Forms.TextBox DwarfFInput;
        private System.Windows.Forms.ListBox DwarfFList;
    }
}

