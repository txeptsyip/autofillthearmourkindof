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
            this.HumanMaleInput.Size = new System.Drawing.Size(100, 20);
            this.HumanMaleInput.TabIndex = 2;
            this.HumanMaleInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Removefromhumanmalelist
            // 
            this.Removefromhumanmalelist.Location = new System.Drawing.Point(93, 139);
            this.Removefromhumanmalelist.Name = "Removefromhumanmalelist";
            this.Removefromhumanmalelist.Size = new System.Drawing.Size(90, 23);
            this.Removefromhumanmalelist.TabIndex = 3;
            this.Removefromhumanmalelist.Text = "Remove UUID";
            this.Removefromhumanmalelist.UseVisualStyleBackColor = true;
            this.Removefromhumanmalelist.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Writetofile
            // 
            this.Writetofile.Location = new System.Drawing.Point(687, 415);
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
            this.HumanFemaleList.Size = new System.Drawing.Size(161, 95);
            this.HumanFemaleList.TabIndex = 5;
            // 
            // HumanFemaIenput
            // 
            this.HumanFemaleInput.Location = new System.Drawing.Point(206, 112);
            this.HumanFemaleInput.Name = "HumanFemaIenput";
            this.HumanFemaleInput.Size = new System.Drawing.Size(100, 20);
            this.HumanFemaleInput.TabIndex = 6;
            // 
            // addtohumanfemale
            // 
            this.addtohumanfemale.Location = new System.Drawing.Point(206, 139);
            this.addtohumanfemale.Name = "addtohumanfemale";
            this.addtohumanfemale.Size = new System.Drawing.Size(75, 23);
            this.addtohumanfemale.TabIndex = 7;
            this.addtohumanfemale.Text = "button1";
            this.addtohumanfemale.UseVisualStyleBackColor = true;
            this.addtohumanfemale.Click += new System.EventHandler(this.addtohumanfemale_Click);
            // 
            // removefromhumanfemale
            // 
            this.removefromhumanfemale.Location = new System.Drawing.Point(288, 139);
            this.removefromhumanfemale.Name = "removefromhumanfemale";
            this.removefromhumanfemale.Size = new System.Drawing.Size(75, 23);
            this.removefromhumanfemale.TabIndex = 8;
            this.removefromhumanfemale.Text = "button1";
            this.removefromhumanfemale.UseVisualStyleBackColor = true;
            this.removefromhumanfemale.Click += new System.EventHandler(this.removefromhumanfemale_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

