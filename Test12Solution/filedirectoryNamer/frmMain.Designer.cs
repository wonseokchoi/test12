namespace filedirectoryNamer
{
    partial class frmMain
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
            this.fDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.txtMainPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFolder = new System.Windows.Forms.Button();
            this.wtype_rbtnFront = new System.Windows.Forms.RadioButton();
            this.wtype_rbtnBack = new System.Windows.Forms.RadioButton();
            this.wtype_rbtnTrade = new System.Windows.Forms.RadioButton();
            this.target_rbtnFile = new System.Windows.Forms.RadioButton();
            this.target_rbtnFolder = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.target_rbtnBoth = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAfter = new System.Windows.Forms.TextBox();
            this.txtBefore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAfterClr = new System.Windows.Forms.Button();
            this.btnBeforeClr = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.폴더선택ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로그램정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Extension_rbtnPass = new System.Windows.Forms.RadioButton();
            this.Extension_rbtnIn = new System.Windows.Forms.RadioButton();
            this.btnExcute = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Exists_rbtnPass = new System.Windows.Forms.RadioButton();
            this.Exists_rbtnIn = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnWordDel = new System.Windows.Forms.Button();
            this.numStart = new System.Windows.Forms.NumericUpDown();
            this.numLength = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMainPath
            // 
            this.txtMainPath.Location = new System.Drawing.Point(12, 46);
            this.txtMainPath.Name = "txtMainPath";
            this.txtMainPath.Size = new System.Drawing.Size(247, 21);
            this.txtMainPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "변경을 원하는 폴더를 선택하세요.";
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(265, 29);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(75, 38);
            this.btnFolder.TabIndex = 2;
            this.btnFolder.Text = "폴더 선택";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // wtype_rbtnFront
            // 
            this.wtype_rbtnFront.AutoSize = true;
            this.wtype_rbtnFront.Checked = true;
            this.wtype_rbtnFront.Location = new System.Drawing.Point(6, 20);
            this.wtype_rbtnFront.Name = "wtype_rbtnFront";
            this.wtype_rbtnFront.Size = new System.Drawing.Size(75, 16);
            this.wtype_rbtnFront.TabIndex = 3;
            this.wtype_rbtnFront.TabStop = true;
            this.wtype_rbtnFront.Text = "앞에 추가";
            this.wtype_rbtnFront.UseVisualStyleBackColor = true;
            // 
            // wtype_rbtnBack
            // 
            this.wtype_rbtnBack.AutoSize = true;
            this.wtype_rbtnBack.Location = new System.Drawing.Point(112, 20);
            this.wtype_rbtnBack.Name = "wtype_rbtnBack";
            this.wtype_rbtnBack.Size = new System.Drawing.Size(75, 16);
            this.wtype_rbtnBack.TabIndex = 3;
            this.wtype_rbtnBack.Text = "뒤에 추가";
            this.wtype_rbtnBack.UseVisualStyleBackColor = true;
            // 
            // wtype_rbtnTrade
            // 
            this.wtype_rbtnTrade.AutoSize = true;
            this.wtype_rbtnTrade.Location = new System.Drawing.Point(218, 20);
            this.wtype_rbtnTrade.Name = "wtype_rbtnTrade";
            this.wtype_rbtnTrade.Size = new System.Drawing.Size(103, 16);
            this.wtype_rbtnTrade.TabIndex = 3;
            this.wtype_rbtnTrade.Text = "동일 단어 변경";
            this.wtype_rbtnTrade.UseVisualStyleBackColor = true;
            // 
            // target_rbtnFile
            // 
            this.target_rbtnFile.AutoSize = true;
            this.target_rbtnFile.Checked = true;
            this.target_rbtnFile.Location = new System.Drawing.Point(6, 20);
            this.target_rbtnFile.Name = "target_rbtnFile";
            this.target_rbtnFile.Size = new System.Drawing.Size(47, 16);
            this.target_rbtnFile.TabIndex = 3;
            this.target_rbtnFile.TabStop = true;
            this.target_rbtnFile.Text = "파일";
            this.target_rbtnFile.UseVisualStyleBackColor = true;
            // 
            // target_rbtnFolder
            // 
            this.target_rbtnFolder.AutoSize = true;
            this.target_rbtnFolder.Location = new System.Drawing.Point(112, 20);
            this.target_rbtnFolder.Name = "target_rbtnFolder";
            this.target_rbtnFolder.Size = new System.Drawing.Size(71, 16);
            this.target_rbtnFolder.TabIndex = 3;
            this.target_rbtnFolder.Text = "디렉터리";
            this.target_rbtnFolder.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.target_rbtnBoth);
            this.groupBox1.Controls.Add(this.target_rbtnFolder);
            this.groupBox1.Controls.Add(this.target_rbtnFile);
            this.groupBox1.Location = new System.Drawing.Point(346, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 47);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "변경 대상";
            // 
            // target_rbtnBoth
            // 
            this.target_rbtnBoth.AutoSize = true;
            this.target_rbtnBoth.Location = new System.Drawing.Point(218, 20);
            this.target_rbtnBoth.Name = "target_rbtnBoth";
            this.target_rbtnBoth.Size = new System.Drawing.Size(47, 16);
            this.target_rbtnBoth.TabIndex = 3;
            this.target_rbtnBoth.Text = "둘다";
            this.target_rbtnBoth.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.wtype_rbtnFront);
            this.groupBox2.Controls.Add(this.wtype_rbtnBack);
            this.groupBox2.Controls.Add(this.wtype_rbtnTrade);
            this.groupBox2.Location = new System.Drawing.Point(346, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 47);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "작업 분류";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAfter);
            this.groupBox3.Controls.Add(this.txtBefore);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnAfterClr);
            this.groupBox3.Controls.Add(this.btnBeforeClr);
            this.groupBox3.Location = new System.Drawing.Point(12, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 109);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "작업 내용";
            // 
            // txtAfter
            // 
            this.txtAfter.Location = new System.Drawing.Point(6, 71);
            this.txtAfter.Name = "txtAfter";
            this.txtAfter.Size = new System.Drawing.Size(241, 21);
            this.txtAfter.TabIndex = 0;
            // 
            // txtBefore
            // 
            this.txtBefore.Location = new System.Drawing.Point(6, 32);
            this.txtBefore.Name = "txtBefore";
            this.txtBefore.Size = new System.Drawing.Size(241, 21);
            this.txtBefore.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "변경, 추가 내용";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "원본 내용";
            // 
            // btnAfterClr
            // 
            this.btnAfterClr.Location = new System.Drawing.Point(253, 67);
            this.btnAfterClr.Name = "btnAfterClr";
            this.btnAfterClr.Size = new System.Drawing.Size(75, 27);
            this.btnAfterClr.TabIndex = 2;
            this.btnAfterClr.Text = "Clear";
            this.btnAfterClr.UseVisualStyleBackColor = true;
            this.btnAfterClr.Click += new System.EventHandler(this.btnAfterClr_Click);
            // 
            // btnBeforeClr
            // 
            this.btnBeforeClr.Location = new System.Drawing.Point(253, 28);
            this.btnBeforeClr.Name = "btnBeforeClr";
            this.btnBeforeClr.Size = new System.Drawing.Size(75, 27);
            this.btnBeforeClr.TabIndex = 2;
            this.btnBeforeClr.Text = "Clear";
            this.btnBeforeClr.UseVisualStyleBackColor = true;
            this.btnBeforeClr.Click += new System.EventHandler(this.btnBeforeClr_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(690, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem1
            // 
            this.파일ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.폴더선택ToolStripMenuItem,
            this.프로그램정보ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.파일ToolStripMenuItem1.Name = "파일ToolStripMenuItem1";
            this.파일ToolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem1.Text = "파일";
            // 
            // 폴더선택ToolStripMenuItem
            // 
            this.폴더선택ToolStripMenuItem.Name = "폴더선택ToolStripMenuItem";
            this.폴더선택ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.폴더선택ToolStripMenuItem.Text = "폴더 선택";
            this.폴더선택ToolStripMenuItem.Click += new System.EventHandler(this.폴더선택ToolStripMenuItem_Click);
            // 
            // 프로그램정보ToolStripMenuItem
            // 
            this.프로그램정보ToolStripMenuItem.Name = "프로그램정보ToolStripMenuItem";
            this.프로그램정보ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.프로그램정보ToolStripMenuItem.Text = "프로그램 정보";
            this.프로그램정보ToolStripMenuItem.Click += new System.EventHandler(this.프로그램정보ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(265, 224);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 27);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Clear 입력, 선택 값 초기화";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Extension_rbtnPass);
            this.groupBox4.Controls.Add(this.Extension_rbtnIn);
            this.groupBox4.Location = new System.Drawing.Point(346, 145);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(328, 47);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "확장자 어떻게 (파일만)";
            // 
            // Extension_rbtnPass
            // 
            this.Extension_rbtnPass.AutoSize = true;
            this.Extension_rbtnPass.Checked = true;
            this.Extension_rbtnPass.Location = new System.Drawing.Point(6, 20);
            this.Extension_rbtnPass.Name = "Extension_rbtnPass";
            this.Extension_rbtnPass.Size = new System.Drawing.Size(87, 16);
            this.Extension_rbtnPass.TabIndex = 3;
            this.Extension_rbtnPass.TabStop = true;
            this.Extension_rbtnPass.Text = "확장자 무시";
            this.Extension_rbtnPass.UseVisualStyleBackColor = true;
            // 
            // Extension_rbtnIn
            // 
            this.Extension_rbtnIn.AutoSize = true;
            this.Extension_rbtnIn.Location = new System.Drawing.Point(112, 20);
            this.Extension_rbtnIn.Name = "Extension_rbtnIn";
            this.Extension_rbtnIn.Size = new System.Drawing.Size(87, 16);
            this.Extension_rbtnIn.TabIndex = 3;
            this.Extension_rbtnIn.Text = "확장자 포함";
            this.Extension_rbtnIn.UseVisualStyleBackColor = true;
            // 
            // btnExcute
            // 
            this.btnExcute.Location = new System.Drawing.Point(12, 73);
            this.btnExcute.Name = "btnExcute";
            this.btnExcute.Size = new System.Drawing.Size(328, 30);
            this.btnExcute.TabIndex = 2;
            this.btnExcute.Text = "변경";
            this.btnExcute.UseVisualStyleBackColor = true;
            this.btnExcute.Click += new System.EventHandler(this.btnExcute_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Exists_rbtnPass);
            this.groupBox5.Controls.Add(this.Exists_rbtnIn);
            this.groupBox5.Location = new System.Drawing.Point(346, 203);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(328, 47);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "중복시 파일 옮김 (디렉터리만)";
            // 
            // Exists_rbtnPass
            // 
            this.Exists_rbtnPass.AutoSize = true;
            this.Exists_rbtnPass.Checked = true;
            this.Exists_rbtnPass.Location = new System.Drawing.Point(6, 20);
            this.Exists_rbtnPass.Name = "Exists_rbtnPass";
            this.Exists_rbtnPass.Size = new System.Drawing.Size(75, 16);
            this.Exists_rbtnPass.TabIndex = 3;
            this.Exists_rbtnPass.TabStop = true;
            this.Exists_rbtnPass.Text = "중복 오류";
            this.Exists_rbtnPass.UseVisualStyleBackColor = true;
            // 
            // Exists_rbtnIn
            // 
            this.Exists_rbtnIn.AutoSize = true;
            this.Exists_rbtnIn.Location = new System.Drawing.Point(112, 20);
            this.Exists_rbtnIn.Name = "Exists_rbtnIn";
            this.Exists_rbtnIn.Size = new System.Drawing.Size(115, 16);
            this.Exists_rbtnIn.TabIndex = 3;
            this.Exists_rbtnIn.Text = "중복시 폴더 합침";
            this.Exists_rbtnIn.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.numLength);
            this.groupBox6.Controls.Add(this.numStart);
            this.groupBox6.Controls.Add(this.btnWordDel);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Location = new System.Drawing.Point(346, 256);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(328, 47);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "단어 제거";
            // 
            // btnWordDel
            // 
            this.btnWordDel.Location = new System.Drawing.Point(249, 14);
            this.btnWordDel.Name = "btnWordDel";
            this.btnWordDel.Size = new System.Drawing.Size(75, 27);
            this.btnWordDel.TabIndex = 2;
            this.btnWordDel.Text = "실행";
            this.btnWordDel.UseVisualStyleBackColor = true;
            this.btnWordDel.Click += new System.EventHandler(this.btnWordDel_Click);
            // 
            // numStart
            // 
            this.numStart.Location = new System.Drawing.Point(65, 19);
            this.numStart.Name = "numStart";
            this.numStart.Size = new System.Drawing.Size(53, 21);
            this.numStart.TabIndex = 7;
            // 
            // numLength
            // 
            this.numLength.Location = new System.Drawing.Point(187, 19);
            this.numLength.Name = "numLength";
            this.numLength.Size = new System.Drawing.Size(53, 21);
            this.numLength.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "시작지점";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "삭제 길이";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(690, 312);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExcute);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMainPath);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "파일, 폴더 이름 변경기";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fDialog;
        private System.Windows.Forms.TextBox txtMainPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.RadioButton wtype_rbtnFront;
        private System.Windows.Forms.RadioButton wtype_rbtnBack;
        private System.Windows.Forms.RadioButton wtype_rbtnTrade;
        private System.Windows.Forms.RadioButton target_rbtnFile;
        private System.Windows.Forms.RadioButton target_rbtnFolder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAfter;
        private System.Windows.Forms.TextBox txtBefore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 폴더선택ToolStripMenuItem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton target_rbtnBoth;
        private System.Windows.Forms.ToolStripMenuItem 프로그램정보ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton Extension_rbtnPass;
        private System.Windows.Forms.RadioButton Extension_rbtnIn;
        private System.Windows.Forms.Button btnExcute;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton Exists_rbtnPass;
        private System.Windows.Forms.RadioButton Exists_rbtnIn;
        private System.Windows.Forms.Button btnAfterClr;
        private System.Windows.Forms.Button btnBeforeClr;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown numLength;
        private System.Windows.Forms.NumericUpDown numStart;
        private System.Windows.Forms.Button btnWordDel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}