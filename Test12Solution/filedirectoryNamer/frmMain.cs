using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace filedirectoryNamer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnExcute_Click(object sender, EventArgs e)
        {
            // 폴더 정보 확인

            // 변경 대상에 따라 작업

            // 작업 분류에 따라 작업 진행

            // 확장자는 작업 분류 작업중 참조

            string sPath = txtMainPath.Text.Trim().Trim();
            string sBefore = txtBefore.Text;
            string sAfter = txtAfter.Text;

            if(sPath.Length == 0)
            {
                vAlert("선택, 입력된 폴더가 없네요.");
                return;
            }
            if (!Directory.Exists(sPath))
            {
                vAlert("없는 폴더 경로. 경로 다시 확인.");
                return;
            }
            if (sAfter.Trim().Length == 0)
            {
                if (MessageBox.Show("변경, 추가 값이 없네. 공란 추가나 선택 단어 지우는거야?", "진행 확인"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1
                    ) == System.Windows.Forms.DialogResult.No)
                    return;
            }

            DirectoryInfo diFolderInfo = new DirectoryInfo(sPath);

            if (target_rbtnFile.Checked == true)
            {
                bWorkFile(diFolderInfo);
            }
            else if (target_rbtnFolder.Checked == true)
            {
                bWorkFolder(diFolderInfo);
            }
            else if (target_rbtnBoth.Checked == true)
            {
                bWorkFile(diFolderInfo);
                bWorkFolder(diFolderInfo);
            }
        }

        private bool bWorkFile(DirectoryInfo diInfo)
        {
            try
            {
                FileInfo[] targetInfo;
                string sTargetNm = "";

                string sBefore = txtBefore.Text;
                string sAfter = txtAfter.Text;

                if (wtype_rbtnTrade.Checked == true)
                {
                    targetInfo = diInfo.GetFiles("*" + txtBefore.Text + "*", SearchOption.TopDirectoryOnly);
                }
                else
                {
                    targetInfo = diInfo.GetFiles();
                }

                for (int i = 0; i < targetInfo.Length; i++)
                {
                    if (wtype_rbtnFront.Checked == true)
                    {
                        targetInfo[i].MoveTo(diInfo.FullName + "\\"
                            + sAfter + targetInfo[i].Name);
                    }
                    else if (wtype_rbtnBack.Checked == true)
                    {
                        if (Extension_rbtnIn.Checked == true)
                        {
                            targetInfo[i].MoveTo(diInfo.FullName + "\\"
                                + targetInfo[i].Name + sAfter);
                        }
                        else if (Extension_rbtnPass.Checked == true)
                        {
                            targetInfo[i].MoveTo(diInfo.FullName + "\\"
                                + targetInfo[i].Name.Substring(0, targetInfo[i].Name.LastIndexOf(".")) + sAfter + targetInfo[i].Extension
                                );
                        }
                    }
                    else if (wtype_rbtnTrade.Checked == true)
                    {
                        if (Extension_rbtnIn.Checked == true)
                        {
                            sTargetNm = targetInfo[i].Name;
                        }
                        else if (Extension_rbtnPass.Checked == true)
                        {
                            sTargetNm = targetInfo[i].Name.Substring(0, targetInfo[i].Name.LastIndexOf("."));
                        }

                        sTargetNm = sTargetNm.Replace(sBefore, sAfter);
                        
                        if (Extension_rbtnIn.Checked == true)
                        {
                            targetInfo[i].MoveTo(diInfo.FullName + "\\"
                                + sTargetNm);
                        }
                        else if (Extension_rbtnPass.Checked == true)
                        {
                            targetInfo[i].MoveTo(diInfo.FullName + "\\"
                                + sTargetNm + targetInfo[i].Extension
                                );
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                vAlert(ex.Message);
                return false;
            }
        }

        private bool bWorkFolder(DirectoryInfo diInfo)
        {
            try
            {
                DirectoryInfo[] targetInfo;
                string sTargetNm = "";

                string sBefore = txtBefore.Text;
                string sAfter = txtAfter.Text;

                if (wtype_rbtnTrade.Checked == true)
                {
                    targetInfo = diInfo.GetDirectories("*" + txtBefore.Text + "*", SearchOption.TopDirectoryOnly);
                }
                else
                {
                    targetInfo = diInfo.GetDirectories();
                }

                for (int i = 0; i < targetInfo.Length; i++)
                {
                    if (wtype_rbtnFront.Checked == true)
                    {
                        sTargetNm = sAfter + targetInfo[i].Name;
                    }
                    else if (wtype_rbtnBack.Checked == true)
                    {
                        sTargetNm = targetInfo[i].Name + sAfter;
                    }
                    else if (wtype_rbtnTrade.Checked == true)
                    {
                        sTargetNm = targetInfo[i].Name.Replace(sBefore, sAfter);
                    }

                    if (Exists_rbtnIn.Checked == true)
                    {
                        if (Directory.Exists(diInfo.FullName + "\\" + sTargetNm))
                        {
                            DirectoryInfo myInfo = new DirectoryInfo(diInfo.FullName + "\\" + targetInfo[i].Name);
                            DirectoryInfo[] myDir = myInfo.GetDirectories();
                            FileInfo[] myFile = myInfo.GetFiles();

                            for (int k = 0; k < myDir.Length; k++)
                            {
                                myDir[k].MoveTo(diInfo.FullName + "\\" + sTargetNm + "\\" + myDir[k].Name);
                            }
                            for (int k = 0; k < myFile.Length; k++)
                            {
                                myFile[k].MoveTo(diInfo.FullName + "\\" + sTargetNm + "\\" + myFile[k].Name);
                            }
                        }
                        targetInfo[i].Delete(false);
                    }

                    if (targetInfo[i].FullName != diInfo.FullName + sTargetNm)
                    {
                        try
                        {
                            if (Directory.Exists(diInfo.FullName + "\\" + targetInfo[i].Name))
                                targetInfo[i].MoveTo(diInfo.FullName + "\\" + sTargetNm);
                        }
                        catch (Exception ex)
                        {
                            vAlert(ex.Message);
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                vAlert(ex.Message);
                return false;
            }
        }

        private void vAlert(string sContent)
        {
            MessageBox.Show(sContent, "뭔가 문제냐..");
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            vMainPathBring();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            vFormClear();
        }

        private void 폴더선택ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vMainPathBring();
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 프로그램정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sInfo = "";
            sInfo = "재미삼아"
                + "\r\n20120429.01"
                + "\r\n폴더 일일이 변경 하기 귀찮아서..";
            MessageBox.Show(sInfo, "버전 확인");
        }

        private void vMainPathBring()
        {
            if (txtMainPath.Text.Trim().Length != 0)
                fDialog.SelectedPath = txtMainPath.Text.Trim();

            fDialog.ShowDialog();

            txtMainPath.Text = fDialog.SelectedPath;
            //txtMainPath.ReadOnly = true;
        }

        private void vFormClear()
        {
            txtMainPath.Text = "";
            txtBefore.Text = "";
            txtAfter.Text = "";

            target_rbtnFile.Checked = true;
            wtype_rbtnFront.Checked = true;
            Extension_rbtnPass.Checked = true;

            //txtMainPath.ReadOnly = false;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("종료 하시겠습니까?", "종료 확인"
            //    , MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
            //    == System.Windows.Forms.DialogResult.No)
            //    e.Cancel = true;
        }

        private void btnBeforeClr_Click(object sender, EventArgs e)
        {
            txtBefore.Text = "";
        }

        private void btnAfterClr_Click(object sender, EventArgs e)
        {
            txtAfter.Text = "";
        }

        private void btnWordDel_Click(object sender, EventArgs e)
        {

            // 폴더 정보 확인

            // 변경 대상에 따라 작업

            // 작업 분류에 따라 작업 진행

            // 확장자는 작업 분류 작업중 참조

            try
            {
                string sPath = txtMainPath.Text.Trim().Trim();

                if (numLength.Value == 0)
                    return;

                if (sPath.Length == 0)
                {
                    vAlert("선택, 입력된 폴더가 없네요.");
                    return;
                }
                if (!Directory.Exists(sPath))
                {
                    vAlert("없는 폴더 경로. 경로 다시 확인.");
                    return;
                }

                DirectoryInfo diFolderInfo = new DirectoryInfo(sPath);

                FileInfo[] targetInfo;
                string sTargetNm = "";

                targetInfo = diFolderInfo.GetFiles();

                int iLen = (int)(numStart.Value + numLength.Value);
                int iStart = (int)numStart.Value;
                int iLength = (int)numLength.Value;

                for (int iFile = 0; iFile < targetInfo.Length; iFile++)
                {
                    sTargetNm = targetInfo[iFile].Name.Trim();
                    string sTargetResult = "";
                    for (int iTargetLen = 0; iTargetLen < sTargetNm.Length; iTargetLen++)
                    {
                        if (iTargetLen < iStart || (iTargetLen + 1) > (iStart + iLength))
                        {
                            sTargetResult += sTargetNm.Substring(iTargetLen, 1);
                        }
                    }

                    targetInfo[iFile].MoveTo(diFolderInfo.FullName + "\\" + sTargetResult);
                }

                diFolderInfo = null;
                targetInfo = null;
            }
            catch (Exception ex)
            {
                vAlert(ex.Message);
            }
        }
    }
}
