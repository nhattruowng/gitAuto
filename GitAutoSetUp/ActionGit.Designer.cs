using System.ComponentModel;

namespace GitAutoSetUp
{
    partial class ActionGit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linkchoice = new System.Windows.Forms.Button();
            this.gitinitlb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnpush = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.chbAddAll = new System.Windows.Forms.CheckBox();
            this.txtRepo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addNewRepo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPull = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(73, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseMnemonic = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(522, 29);
            this.textBox1.TabIndex = 2;
            // 
            // linkchoice
            // 
            this.linkchoice.Location = new System.Drawing.Point(712, 36);
            this.linkchoice.Name = "linkchoice";
            this.linkchoice.Size = new System.Drawing.Size(122, 35);
            this.linkchoice.TabIndex = 3;
            this.linkchoice.Text = "browser";
            this.linkchoice.UseVisualStyleBackColor = true;
            this.linkchoice.Click += new System.EventHandler(this.linkchoice_Click);
            // 
            // gitinitlb
            // 
            this.gitinitlb.Font = new System.Drawing.Font("Arial Narrow", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gitinitlb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gitinitlb.Location = new System.Drawing.Point(6, 65);
            this.gitinitlb.Name = "gitinitlb";
            this.gitinitlb.Size = new System.Drawing.Size(128, 32);
            this.gitinitlb.TabIndex = 4;
            this.gitinitlb.Text = "Init";
            this.gitinitlb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gitinitlb.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Add";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseMnemonic = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(244, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Commit";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(244, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "branch";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseMnemonic = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(53, 341);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(825, 233);
            this.textBox2.TabIndex = 9;
            // 
            // btnpush
            // 
            this.btnpush.Location = new System.Drawing.Point(756, 300);
            this.btnpush.Name = "btnpush";
            this.btnpush.Size = new System.Drawing.Size(122, 35);
            this.btnpush.TabIndex = 10;
            this.btnpush.Text = "push";
            this.btnpush.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(134, 60);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 46);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = ".git";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(372, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(331, 29);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(372, 119);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(331, 29);
            this.textBox4.TabIndex = 13;
            // 
            // chbAddAll
            // 
            this.chbAddAll.Checked = true;
            this.chbAddAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAddAll.Location = new System.Drawing.Point(134, 112);
            this.chbAddAll.Name = "chbAddAll";
            this.chbAddAll.Size = new System.Drawing.Size(104, 46);
            this.chbAddAll.TabIndex = 14;
            this.chbAddAll.Text = "all file";
            this.chbAddAll.UseVisualStyleBackColor = true;
            // 
            // txtRepo
            // 
            this.txtRepo.Location = new System.Drawing.Point(134, 22);
            this.txtRepo.Name = "txtRepo";
            this.txtRepo.Size = new System.Drawing.Size(516, 29);
            this.txtRepo.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 32);
            this.label5.TabIndex = 15;
            this.label5.Text = "repo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.UseMnemonic = false;
            // 
            // addNewRepo
            // 
            this.addNewRepo.Location = new System.Drawing.Point(674, 19);
            this.addNewRepo.Name = "addNewRepo";
            this.addNewRepo.Size = new System.Drawing.Size(122, 35);
            this.addNewRepo.TabIndex = 17;
            this.addNewRepo.Text = "newRepo";
            this.addNewRepo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.chbAddAll);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.gitinitlb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.addNewRepo);
            this.groupBox1.Controls.Add(this.txtRepo);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(47, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 217);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(723, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 35);
            this.button2.TabIndex = 19;
            this.button2.Text = "cmt";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(723, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 35);
            this.button1.TabIndex = 18;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPull
            // 
            this.btnPull.Location = new System.Drawing.Point(53, 300);
            this.btnPull.Name = "btnPull";
            this.btnPull.Size = new System.Drawing.Size(122, 35);
            this.btnPull.TabIndex = 19;
            this.btnPull.Text = "pull";
            this.btnPull.UseVisualStyleBackColor = true;
            // 
            // ActionGit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 600);
            this.Controls.Add(this.btnPull);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnpush);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.linkchoice);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActionGit";
            this.ShowIcon = false;
            this.Text = "ActionGit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnPull;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.TextBox txtRepo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addNewRepo;

        private System.Windows.Forms.CheckBox chbAddAll;

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;

        private System.Windows.Forms.Button btnpush;
        private System.Windows.Forms.CheckBox checkBox1;

        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.Label gitinitlb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button linkchoice;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}