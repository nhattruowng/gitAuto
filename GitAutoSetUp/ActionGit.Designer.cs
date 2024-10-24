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
            this.pathForder = new System.Windows.Forms.TextBox();
            this.linkchoice = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.messiger = new System.Windows.Forms.TextBox();
            this.btnpush = new System.Windows.Forms.Button();
            this.txtbranch = new System.Windows.Forms.TextBox();
            this.txtCommit = new System.Windows.Forms.TextBox();
            this.chbAddAll = new System.Windows.Forms.CheckBox();
            this.txtRepo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addRepo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnClone = new System.Windows.Forms.Button();
            this.btnchange = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPull = new System.Windows.Forms.Button();
            this.treeBranch = new System.Windows.Forms.ComboBox();
            this.btnauthen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(53, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseMnemonic = false;
            // 
            // pathForder
            // 
            this.pathForder.Location = new System.Drawing.Point(175, 36);
            this.pathForder.Name = "pathForder";
            this.pathForder.Size = new System.Drawing.Size(522, 29);
            this.pathForder.TabIndex = 2;
            this.pathForder.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.label4.Location = new System.Drawing.Point(223, 119);
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
            this.label2.Location = new System.Drawing.Point(185, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "branch";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseMnemonic = false;
            // 
            // messiger
            // 
            this.messiger.Location = new System.Drawing.Point(53, 369);
            this.messiger.Multiline = true;
            this.messiger.Name = "messiger";
            this.messiger.ReadOnly = true;
            this.messiger.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messiger.Size = new System.Drawing.Size(861, 233);
            this.messiger.TabIndex = 9;
            // 
            // btnpush
            // 
            this.btnpush.Location = new System.Drawing.Point(786, 311);
            this.btnpush.Name = "btnpush";
            this.btnpush.Size = new System.Drawing.Size(122, 45);
            this.btnpush.TabIndex = 10;
            this.btnpush.Text = "push";
            this.btnpush.UseVisualStyleBackColor = true;
            this.btnpush.Click += new System.EventHandler(this.btnpush_Click);
            // 
            // txtbranch
            // 
            this.txtbranch.Location = new System.Drawing.Point(319, 69);
            this.txtbranch.Name = "txtbranch";
            this.txtbranch.Size = new System.Drawing.Size(331, 29);
            this.txtbranch.TabIndex = 12;
            // 
            // txtCommit
            // 
            this.txtCommit.Location = new System.Drawing.Point(353, 119);
            this.txtCommit.Name = "txtCommit";
            this.txtCommit.Size = new System.Drawing.Size(415, 29);
            this.txtCommit.TabIndex = 13;
            // 
            // chbAddAll
            // 
            this.chbAddAll.Location = new System.Drawing.Point(128, 114);
            this.chbAddAll.Name = "chbAddAll";
            this.chbAddAll.Size = new System.Drawing.Size(104, 46);
            this.chbAddAll.TabIndex = 14;
            this.chbAddAll.Text = "all file";
            this.chbAddAll.UseVisualStyleBackColor = true;
            this.chbAddAll.CheckedChanged += new System.EventHandler(this.chbAddAll_CheckedChanged);
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
            // addRepo
            // 
            this.addRepo.AllowDrop = true;
            this.addRepo.Location = new System.Drawing.Point(665, 19);
            this.addRepo.Name = "addRepo";
            this.addRepo.Size = new System.Drawing.Size(113, 35);
            this.addRepo.TabIndex = 17;
            this.addRepo.Text = "add Repo";
            this.addRepo.UseVisualStyleBackColor = true;
            this.addRepo.Click += new System.EventHandler(this.addRepo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCommit);
            this.groupBox1.Controls.Add(this.btnClone);
            this.groupBox1.Controls.Add(this.btnchange);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCommit);
            this.groupBox1.Controls.Add(this.chbAddAll);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtbranch);
            this.groupBox1.Controls.Add(this.addRepo);
            this.groupBox1.Controls.Add(this.txtRepo);
            this.groupBox1.Location = new System.Drawing.Point(47, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(867, 217);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // btnCommit
            // 
            this.btnCommit.AllowDrop = true;
            this.btnCommit.AutoEllipsis = true;
            this.btnCommit.Location = new System.Drawing.Point(788, 119);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(73, 35);
            this.btnCommit.TabIndex = 21;
            this.btnCommit.Text = "+";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnClone
            // 
            this.btnClone.AllowDrop = true;
            this.btnClone.AutoEllipsis = true;
            this.btnClone.Location = new System.Drawing.Point(784, 19);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(73, 35);
            this.btnClone.TabIndex = 20;
            this.btnClone.Text = "clone";
            this.btnClone.UseVisualStyleBackColor = true;
            this.btnClone.Click += new System.EventHandler(this.btnClone_Click);
            // 
            // btnchange
            // 
            this.btnchange.AllowDrop = true;
            this.btnchange.AutoEllipsis = true;
            this.btnchange.Location = new System.Drawing.Point(788, 67);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(73, 35);
            this.btnchange.TabIndex = 19;
            this.btnchange.Text = "đổi";
            this.btnchange.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.AutoEllipsis = true;
            this.button1.Location = new System.Drawing.Point(695, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 35);
            this.button1.TabIndex = 18;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPull
            // 
            this.btnPull.AllowDrop = true;
            this.btnPull.AutoEllipsis = true;
            this.btnPull.Location = new System.Drawing.Point(234, 311);
            this.btnPull.Name = "btnPull";
            this.btnPull.Size = new System.Drawing.Size(122, 45);
            this.btnPull.TabIndex = 19;
            this.btnPull.Text = "pull";
            this.btnPull.UseVisualStyleBackColor = true;
            this.btnPull.Click += new System.EventHandler(this.btnPull_Click);
            // 
            // treeBranch
            // 
            this.treeBranch.FormattingEnabled = true;
            this.treeBranch.Location = new System.Drawing.Point(53, 318);
            this.treeBranch.Name = "treeBranch";
            this.treeBranch.Size = new System.Drawing.Size(175, 32);
            this.treeBranch.TabIndex = 21;
            this.treeBranch.SelectedIndexChanged += new System.EventHandler(this.treeBranch_SelectedIndexChanged_1);
            // 
            // btnauthen
            // 
            this.btnauthen.AllowDrop = true;
            this.btnauthen.AutoEllipsis = true;
            this.btnauthen.Location = new System.Drawing.Point(901, 12);
            this.btnauthen.Name = "btnauthen";
            this.btnauthen.Size = new System.Drawing.Size(73, 35);
            this.btnauthen.TabIndex = 22;
            this.btnauthen.Text = "aut";
            this.btnauthen.UseVisualStyleBackColor = true;
            this.btnauthen.Click += new System.EventHandler(this.btnauthen_Click);
            // 
            // ActionGit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 633);
            this.Controls.Add(this.btnauthen);
            this.Controls.Add(this.treeBranch);
            this.Controls.Add(this.btnPull);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnpush);
            this.Controls.Add(this.messiger);
            this.Controls.Add(this.linkchoice);
            this.Controls.Add(this.pathForder);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActionGit";
            this.ShowIcon = false;
            this.Text = "ActionGit";
            this.Load += new System.EventHandler(this.ActionGit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnauthen;

        private System.Windows.Forms.Button btnCommit;

        private System.Windows.Forms.Button btnClone;
        
        private System.Windows.Forms.ComboBox treeBranch;

        private System.Windows.Forms.Button btnchange;

        private System.Windows.Forms.Button btnPull;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.TextBox txtRepo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addRepo;

        private System.Windows.Forms.CheckBox chbAddAll;

        private System.Windows.Forms.TextBox txtbranch;
        private System.Windows.Forms.TextBox txtCommit;

        private System.Windows.Forms.Button btnpush;

        private System.Windows.Forms.TextBox messiger;

        private System.Windows.Forms.Label pull;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button linkchoice;

        private System.Windows.Forms.TextBox pathForder;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}