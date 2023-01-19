using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolKits
{
    public partial class Main : Form
    {        
        FileInfo[] Files;
        

        string CorrectTime = DateTime.Now.ToString();
        string str;

        public Main()
        {
            InitializeComponent();
            CountImages(ImageFolderPathTxt.Text);
            DeleteAllFilesDestination();
            LoadFileToList();
        }

        #region Xoá các thư mục output trước
        private void DeleteAllFilesDestination()
        {
            //Kiểm tra thư mục output
            string dest = OutPutImgTxt.Text; // @"D:\2025\chep\";
            //Tạo biến đếm
            int j = 0;
            //Kiểm tra xem thư mục output có tồn tại?
            if (Directory.Exists(dest))
            {
                //Nếu có
                //Lặp tạo 8 folders theo 8 hướng
                for (int i = 0; i < 8; i++)
                {
                    //Tăng biến đếm 2
                    j = j + 1;
                    //Lấy thông tin thư mục con dirX (X chạy từ 1-8)
                    string subFolder = dest + @"\dir" + j;
                    //Kiểm tra có tồn tại dir X ko
                    if (Directory.Exists(subFolder))
                    {
                        DirectoryInfo dI = new DirectoryInfo(subFolder);
                        foreach (FileInfo itemdI in dI.GetFiles())
                        {
                            itemdI.Delete();
                        }
                        //Nếu có thì xoá
                        Directory.Delete(subFolder);
                        Directory.CreateDirectory(dest + @"\" + "dir" + j);
                    }
                    else
                    {                        
                        Directory.CreateDirectory(dest + @"\" + "dir" + j);
                    }
                    //Sau đó tạo lại
                    string outputFolder = dest + @"\output\";
                    if (Directory.Exists(outputFolder))
                    {
                        DirectoryInfo dIO = new DirectoryInfo(outputFolder);
                        foreach (FileInfo itemdIO in dIO.GetFiles())
                        {
                            itemdIO.Delete();
                        }
                        //Nếu có thì xoá
                        Directory.Delete(outputFolder);                        
                    }

                    Directory.CreateDirectory(dest + @"\output\");

                    string TgaFolder = dest + @"\tga\";
                    if (Directory.Exists(TgaFolder))
                    {
                        DirectoryInfo dIOA = new DirectoryInfo(TgaFolder);
                        foreach (FileInfo itemdIOA in dIOA.GetFiles())
                        {
                            itemdIOA.Delete();
                        }
                        //Nếu có thì xoá
                        Directory.Delete(TgaFolder);
                    }

                    Directory.CreateDirectory(dest + @"\tga\");
                }
                
            }
            else
            {
                //Trường hợp không có thư mục "chep" (output)
                //tạo thư mục
                Directory.CreateDirectory(dest);
                //Tương tự trên
                for (int i = 0; i < 8; i++)
                {
                    j = j + 1;
                    string subFolder = dest + @"\dir" + j;
                    if (Directory.Exists(subFolder))
                    {
                        Directory.Delete(subFolder);
                    }
                    Directory.CreateDirectory(dest + @"\" + "dir" + j);
                }
                Directory.CreateDirectory(dest + @"\output");
            }            
        }
        #endregion

        #region Chọn đường dẫn folder image đã extract
        private void ImageFolderPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                ImageFolderPathTxt.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }  
        }
        #endregion

        #region Tổng số images
        private void TotalImages_Click(object sender, EventArgs e)
        {
            //string DuPaths = ImageFolderPathTxt.Text;
            //TotalImagesInFolderTxt.Text = CountImages(DuPaths);
        }
        #endregion

        #region Đếm images
        private string CountImages(string ImagePathOri)
        {
            if (checkNull(ImagePathOri) == true)
            {
                return "";
            }
            else
            {
                DirectoryInfo dCount = new DirectoryInfo(ImagePathOri);
                FileInfo[] fCount = dCount.GetFiles("*", SearchOption.TopDirectoryOnly);
                TotalImagesInFolderTxt.Text = fCount.Length.ToString();
                return fCount.Length.ToString();
            }
        }
        #endregion

        #region kiểm tra null 
        public static bool checkNull(string s)
        {
            return (s == null || s == String.Empty) ? true : false;
        }
        #endregion 

        #region Text change đường dẫn nguồn
        private void ImageFolderPathTxt_TextChanged(object sender, EventArgs e)
        {
            string abc = ImageFolderPathTxt.Text;
            if (abc == null)
            {
            }
            else
            {
                CountImages(abc);
            }
        }
        #endregion 

        #region Load file to list
        private void LoadFileToList()
        {
            string getDir = ImageFolderPathTxt.Text;          
            try
            {
                if (getDir == null)
                {
                }
                else
                {
                    FileNameListBox.Items.Clear();
                    DirectoryInfo dirABC = new DirectoryInfo(getDir);
                    Files = dirABC.GetFiles("*");
                    str = "";
                    int db = 0;
                    foreach (FileInfo file in Files)
                    {
                        db++;
                        FileNameListBox.Items.Add(file);
                        str = str + ", " + file.Name;
                    }
                }
            }
            catch (Exception)
            {                
                throw;
            }            
        }
        #endregion

        #region Text change 
        private void TotalImagesInFolderTxt_TextChanged(object sender, EventArgs e)
        {
            string ttt = TotalImagesInFolderTxt.Text;
            if (ttt == null)
            {
            }
            else
            {
                int totalImg = Int32.Parse(TotalImagesInFolderTxt.Text);
                int dirNum = Convert.ToInt32(NumDirBox.Value);
                FramePerDirTxt.Text = (totalImg / dirNum).ToString();
            }

        }
        #endregion

        #region Copy
        private void BtnCopyRename_Click(object sender, EventArgs e)
        {
            DialogResult lkResult = MessageBox.Show("Hãy xoá dữ liệu cũ!", "Warning!", MessageBoxButtons.YesNo);
            if (lkResult == DialogResult.Yes)
            {
                DeleteAllFilesDestination();
                
                string SourceFolder = ImageFolderPathTxt.Text;
                //Provide Destination Folder path
                string DestinationFolder = OutPutImgTxt.Text; // @"D:\2025\chep\";

                var files = new DirectoryInfo(SourceFolder).GetFiles("*.*");

                string[] fileARR = Directory.GetFiles(SourceFolder);
                int nCounter = 0;
                int nDirection = Convert.ToInt32(NumDirBox.Value);
                int nEachFrame = Convert.ToInt32(FramePerDirTxt.Text);
                int[] nDirectFromTo = { nEachFrame, nEachFrame * 2, nEachFrame * 3, nEachFrame * 4, nEachFrame * 5, nEachFrame * 6, nEachFrame * 7, nEachFrame * 8 };

                Thread ab1 = new Thread(() =>
                {
                    CopyFilesFirst(nDirectFromTo[0], fileARR, DestinationFolder, nCounter);
                });
                ab1.IsBackground = false;
                ab1.Start();

                Thread ab2 = new Thread(() =>
                {
                    CopyFiles2(nDirectFromTo[1], fileARR, DestinationFolder, nCounter);
                });
                ab2.IsBackground = false;
                ab2.Start();

                Thread ab3 = new Thread(() =>
                {
                    CopyFiles3(nDirectFromTo[2], fileARR, DestinationFolder, nCounter);
                });
                ab3.IsBackground = false;
                ab3.Start();

                Thread ab4 = new Thread(() =>
                {
                    CopyFiles4(nDirectFromTo[3], fileARR, DestinationFolder, nCounter);
                });
                ab4.IsBackground = false;
                ab4.Start();

                Thread ab5 = new Thread(() =>
                {
                    CopyFiles5(nDirectFromTo[4], fileARR, DestinationFolder, nCounter);
                });
                ab5.IsBackground = false;
                ab5.Start();

                Thread ab6 = new Thread(() =>
                {
                    CopyFiles6(nDirectFromTo[5], fileARR, DestinationFolder, nCounter);
                });
                ab6.IsBackground = false;
                ab6.Start();

                Thread ab7 = new Thread(() =>
                {
                    CopyFiles7(nDirectFromTo[6], fileARR, DestinationFolder, nCounter);
                });
                ab7.IsBackground = false;
                ab7.Start();

                Thread ab8 = new Thread(() =>
                {
                    CopyFiles8(nDirectFromTo[7], fileARR, DestinationFolder, nCounter);
                });
                ab8.IsBackground = false;
                ab8.Start();

                toolStripStatusLabel2.Text = "Done!";
                
            }

            if (lkResult == DialogResult.No)
            {
                
                return;
            }

            

            
            
            
            
        }
        #endregion

        #region Invoke
        public void AppendToolTip(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendToolTip), new object[] { value });
                return;
            }
            toolStripStatusLabel1.Text += value;
        }
        #endregion

        #region Các hàm xử lý thread theo 8 folder
        private void CopyFilesFirst(int nDirectFromTo, string[] fileARR, string Dest, int nCounter)
        {
            try
            {
                for (int i = 0; i < nDirectFromTo; i++)
                {
                    FileInfo fInfo1 = new FileInfo(fileARR[i]);
                    nCounter = nCounter + 1;
                    string fName1 = Path.GetFileNameWithoutExtension(fileARR[i]);
                    string fExt = Path.GetExtension(fileARR[i]);
                    fInfo1.CopyTo(Dest + @"\dir1\" + fName1.Replace(fName1, nCounter.ToString()) + fExt);
                }


                FileInfo fInfor2 = new FileInfo(fileARR[nDirectFromTo - 2]);
                string fNameA = Path.GetFileNameWithoutExtension(fileARR[nDirectFromTo - 2]);
                string fExtA = Path.GetExtension(fileARR[nDirectFromTo - 2]);
                string numNext = (nDirectFromTo + 1).ToString();
                fInfor2.CopyTo(Dest + @"\dir1\" + fNameA.Replace(fNameA, numNext) + ".png");

                FileInfo fInfor3 = new FileInfo(fileARR[nDirectFromTo - 1]);
                string fNameA3 = Path.GetFileNameWithoutExtension(fileARR[nDirectFromTo - 1]);
                string fExtA3 = Path.GetExtension(fileARR[nDirectFromTo - 1]);
                string numNext3 = (nDirectFromTo + 2).ToString();
                fInfor3.CopyTo(Dest + @"\dir1\" + fNameA3.Replace(fNameA3, numNext3) + ".png");

                string srcP = Dest+@"\dir1\";
                string outputP = Dest + @"\output\";
                Thread.Sleep(1000);
                var allFiles = Directory.GetFiles(srcP, "*.*", SearchOption.AllDirectories);
                foreach (string newPath in allFiles)
                {
                    File.Copy(newPath, newPath.Replace(srcP, outputP), true);
                } 
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void CopyFiles2(int nDirectFromTo, string[] fileARR, string DestinationFolder, int nCounter)
        {
            int nDir_From = nDirectFromTo - 12;
            nCounter = nDir_From + 2;
            try
            {
                for (int i = nDir_From; i < nDirectFromTo; i++)
                {
                    FileInfo fInfo1 = new FileInfo(fileARR[i]);
                    nCounter = nCounter + 1;
                    string fName1 = Path.GetFileNameWithoutExtension(fileARR[i]);
                    string fExt = Path.GetExtension(fileARR[i]);
                    fInfo1.CopyTo(DestinationFolder + @"\dir2\" + fName1.Replace(fName1, nCounter.ToString()) + fExt);
                    
                }

                FileInfo fInfor2 = new FileInfo(fileARR[nDirectFromTo - 2]);
                string fNameA = Path.GetFileNameWithoutExtension(fileARR[nDirectFromTo - 2]);
                string fExtA = Path.GetExtension(fileARR[nDirectFromTo - 2]);
                string numNext = (nDirectFromTo + 3).ToString();
                fInfor2.CopyTo(DestinationFolder + @"\dir2\" + fNameA.Replace(fNameA, numNext) + ".png");

                FileInfo fInfor3 = new FileInfo(fileARR[nDirectFromTo - 1]);
                string fNameA3 = Path.GetFileNameWithoutExtension(fileARR[nDirectFromTo - 1]);
                string fExtA3 = Path.GetExtension(fileARR[nDirectFromTo - 1]);
                string numNext3 = (nDirectFromTo + 4).ToString();
                fInfor3.CopyTo(DestinationFolder + @"\dir2\" + fNameA3.Replace(fNameA3, numNext3) + ".png");

                string srcP = DestinationFolder + @"\dir2\";
                string outputP = DestinationFolder + @"\output\";
                Thread.Sleep(1000);
                var allFiles = Directory.GetFiles(srcP, "*.*", SearchOption.AllDirectories);
                foreach (string newPath in allFiles)
                {
                    File.Copy(newPath, newPath.Replace(srcP, outputP), true);
                } 
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void CopyFiles3(int nDirectFromTo, string[] fileARR, string DestinationFolder, int nCounter)
        {
            int nDir_From = nDirectFromTo - 12;
            nCounter = nDir_From + 4;
            try
            {
                for (int i = nDir_From; i < nDirectFromTo; i++)
                {
                    FileInfo fInfo1 = new FileInfo(fileARR[i]);
                    nCounter = nCounter + 1;
                    string fName1 = Path.GetFileNameWithoutExtension(fileARR[i]);
                    string fExt = Path.GetExtension(fileARR[i]);
                    fInfo1.CopyTo(DestinationFolder + @"\dir3\" + fName1.Replace(fName1, nCounter.ToString()) + fExt);
                }

                FileInfo fInfor2 = new FileInfo(fileARR[nDirectFromTo - 2]);
                string fNameA = Path.GetFileNameWithoutExtension(fileARR[nDirectFromTo - 2]);
                string fExtA = Path.GetExtension(fileARR[nDirectFromTo - 2]);
                string numNext = (nDirectFromTo + 5).ToString();
                fInfor2.CopyTo(DestinationFolder + @"\dir3\" + fNameA.Replace(fNameA, numNext) + ".png");

                FileInfo fInfor3 = new FileInfo(fileARR[nDirectFromTo - 1]);
                string fNameA3 = Path.GetFileNameWithoutExtension(fileARR[nDirectFromTo - 1]);
                string fExtA3 = Path.GetExtension(fileARR[nDirectFromTo - 1]);
                string numNext3 = (nDirectFromTo + 6).ToString();
                fInfor3.CopyTo(DestinationFolder + @"\dir3\" + fNameA3.Replace(fNameA3, numNext3) + ".png");

                string srcP = DestinationFolder + @"\dir3\";
                string outputP = DestinationFolder + @"\output\";
                Thread.Sleep(1000);
                var allFiles = Directory.GetFiles(srcP, "*.*", SearchOption.AllDirectories);
                foreach (string newPath in allFiles)
                {
                    File.Copy(newPath, newPath.Replace(srcP, outputP), true);
                } 
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void CopyFiles4(int nDirectFromTo, string[] fileARR, string DestinationFolder, int nCounter)
        {
            int nDir_From = nDirectFromTo - 12;
            nCounter = nDir_From + 6;
            try
            {
                for (int i = nDir_From; i < nDirectFromTo; i++)
                {
                    FileInfo fInfo1 = new FileInfo(fileARR[i]);
                    nCounter = nCounter + 1;
                    string fName1 = Path.GetFileNameWithoutExtension(fileARR[i]);
                    string fExt = Path.GetExtension(fileARR[i]);
                    fInfo1.CopyTo(DestinationFolder + @"\dir4\" + fName1.Replace(fName1, nCounter.ToString()) + fExt);
                }

                FileInfo fInfor2 = new FileInfo(fileARR[nDirectFromTo - 2]);
                string fNameA = Path.GetFileNameWithoutExtension(fileARR[nDirectFromTo - 2]);
                string fExtA = Path.GetExtension(fileARR[nDirectFromTo - 2]);
                string numNext = (nDirectFromTo + 7).ToString();
                fInfor2.CopyTo(DestinationFolder + @"\dir4\" + fNameA.Replace(fNameA, numNext) + ".png");

                FileInfo fInfor3 = new FileInfo(fileARR[nDirectFromTo - 1]);
                string fNameA3 = Path.GetFileNameWithoutExtension(fileARR[nDirectFromTo - 1]);
                string fExtA3 = Path.GetExtension(fileARR[nDirectFromTo - 1]);
                string numNext3 = (nDirectFromTo + 8).ToString();
                fInfor3.CopyTo(DestinationFolder + @"\dir4\" + fNameA3.Replace(fNameA3, numNext3) + ".png");

                string srcP = DestinationFolder + @"\dir4\";
                string outputP = DestinationFolder + @"\output\";
                Thread.Sleep(1000);
                var allFiles = Directory.GetFiles(srcP, "*.*", SearchOption.AllDirectories);
                foreach (string newPath in allFiles)
                {
                    File.Copy(newPath, newPath.Replace(srcP, outputP), true);
                } 
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void CopyFiles5(int nDirectFromTo, string[] fileARR, string DestinationFolder, int nCounter)
        {
            int nDir_From = nDirectFromTo - 12;
            nCounter = nDir_From + 8;
            try
            {
                for (int i = nDir_From; i < nDirectFromTo; i++)
                {
                    FileInfo fInfo1 = new FileInfo(fileARR[i]);
                    nCounter = nCounter + 1;
                    string fName1 = Path.GetFileNameWithoutExtension(fileARR[i]);
                    string fExt = Path.GetExtension(fileARR[i]);
                    fInfo1.CopyTo(DestinationFolder + @"\dir5\" + fName1.Replace(fName1, nCounter.ToString()) + fExt);
                }

                FileInfo fInfor2 = new FileInfo(fileARR[nDirectFromTo - 2]);
                string fNameA = Path.GetFileNameWithoutExtension(fileARR[nDirectFromTo - 2]);
                string fExtA = Path.GetExtension(fileARR[nDirectFromTo - 2]);
                string numNext = (nDirectFromTo + 9).ToString();
                fInfor2.CopyTo(DestinationFolder + @"\dir5\" + fNameA.Replace(fNameA, numNext) + ".png");

                FileInfo fInfor3 = new FileInfo(fileARR[nDirectFromTo - 1]);
                string fNameA3 = Path.GetFileNameWithoutExtension(fileARR[nDirectFromTo - 1]);
                string fExtA3 = Path.GetExtension(fileARR[nDirectFromTo - 1]);
                string numNext3 = (nDirectFromTo + 10).ToString();
                fInfor3.CopyTo(DestinationFolder + @"\dir5\" + fNameA3.Replace(fNameA3, numNext3) + ".png");

                string srcP = DestinationFolder + @"\dir5\";
                string outputP = DestinationFolder + @"\output\";
                Thread.Sleep(1000);
                var allFiles = Directory.GetFiles(srcP, "*.*", SearchOption.AllDirectories);
                foreach (string newPath in allFiles)
                {
                    File.Copy(newPath, newPath.Replace(srcP, outputP), true);
                } 
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void CopyFiles6(int nDirectFromTo, string[] fileARR, string DestinationFolder, int nCounter)
        {
            int nDir_From = nDirectFromTo - 12;
            nCounter = nDir_From + 10;
            try
            {
                for (int i = nDir_From; i < nDirectFromTo; i++)
                {
                    FileInfo fInfo1 = new FileInfo(fileARR[i]);
                    nCounter = nCounter + 1;
                    string fName1 = Path.GetFileNameWithoutExtension(fileARR[i]);
                    string fExt = Path.GetExtension(fileARR[i]);
                    fInfo1.CopyTo(DestinationFolder + @"\dir6\" + fName1.Replace(fName1, nCounter.ToString()) + fExt);
                }

                FileInfo fInfor2 = new FileInfo(fileARR[nDirectFromTo - 2]);
                string fNameA = Path.GetFileNameWithoutExtension(fileARR[nDirectFromTo - 2]);
                string fExtA = Path.GetExtension(fileARR[nDirectFromTo - 2]);
                string numNext = (nDirectFromTo + 11).ToString();
                fInfor2.CopyTo(DestinationFolder + @"\dir6\" + fNameA.Replace(fNameA, numNext) + ".png");

                FileInfo fInfor3 = new FileInfo(fileARR[nDirectFromTo - 1]);
                string fNameA3 = Path.GetFileNameWithoutExtension(fileARR[nDirectFromTo - 1]);
                string fExtA3 = Path.GetExtension(fileARR[nDirectFromTo - 1]);
                string numNext3 = (nDirectFromTo + 12).ToString();
                fInfor3.CopyTo(DestinationFolder + @"\dir6\" + fNameA3.Replace(fNameA3, numNext3) + ".png");

                string srcP = DestinationFolder + @"\dir6\";
                string outputP = DestinationFolder + @"\output\";
                Thread.Sleep(1000);
                var allFiles = Directory.GetFiles(srcP, "*.*", SearchOption.AllDirectories);
                foreach (string newPath in allFiles)
                {
                    File.Copy(newPath, newPath.Replace(srcP, outputP), true);
                } 
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void CopyFiles7(int nDirectFromTo, string[] fileARR, string DestinationFolder, int nCounter)
        {
            int nDir_From = nDirectFromTo - 12;
            nCounter = nDir_From + 12;
            try
            {
                for (int i = nDir_From; i < nDirectFromTo; i++)
                {
                    FileInfo fInfo1 = new FileInfo(fileARR[i]);
                    nCounter = nCounter + 1;
                    string fName1 = Path.GetFileNameWithoutExtension(fileARR[i]);
                    string fExt = Path.GetExtension(fileARR[i]);
                    fInfo1.CopyTo(DestinationFolder + @"\dir7\" + fName1.Replace(fName1, nCounter.ToString()) + fExt);
                }

                FileInfo fInfor2 = new FileInfo(fileARR[nDirectFromTo - 2]);
                string fNameA = Path.GetFileNameWithoutExtension(fileARR[nDirectFromTo - 2]);
                string fExtA = Path.GetExtension(fileARR[nDirectFromTo - 2]);
                string numNext = (nDirectFromTo + 13).ToString();
                fInfor2.CopyTo(DestinationFolder + @"\dir7\" + fNameA.Replace(fNameA, numNext) + ".png");

                FileInfo fInfor3 = new FileInfo(fileARR[nDirectFromTo - 1]);
                string fNameA3 = Path.GetFileNameWithoutExtension(fileARR[nDirectFromTo - 1]);
                string fExtA3 = Path.GetExtension(fileARR[nDirectFromTo - 1]);
                string numNext3 = (nDirectFromTo + 14).ToString();
                fInfor3.CopyTo(DestinationFolder + @"\dir7\" + fNameA3.Replace(fNameA3, numNext3) + ".png");

                string srcP = DestinationFolder + @"\dir7\";
                string outputP = DestinationFolder + @"\output\";
                Thread.Sleep(1000);
                var allFiles = Directory.GetFiles(srcP, "*.*", SearchOption.AllDirectories);
                foreach (string newPath in allFiles)
                {
                    File.Copy(newPath, newPath.Replace(srcP, outputP), true);
                } 
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void CopyFiles8(int nDirectFromTo, string[] fileARR, string DestinationFolder, int nCounter)
        {
            int nDir_From = nDirectFromTo - 12;
            nCounter = nDir_From + 14;
            try
            {
                for (int i = nDir_From; i < nDirectFromTo; i++)
                {
                    FileInfo fInfo1 = new FileInfo(fileARR[i]);
                    nCounter = nCounter + 1;
                    string fName1 = Path.GetFileNameWithoutExtension(fileARR[i]);
                    string fExt = Path.GetExtension(fileARR[i]);
                    fInfo1.CopyTo(DestinationFolder + @"\dir8\" + fName1.Replace(fName1, nCounter.ToString()) + fExt);
                }

                FileInfo fInfor2 = new FileInfo(fileARR[nDirectFromTo - 2]);
                string fNameA = Path.GetFileNameWithoutExtension(fileARR[nDirectFromTo - 2]);
                string fExtA = Path.GetExtension(fileARR[nDirectFromTo - 2]);
                string numNext = (nDirectFromTo + 15).ToString();
                fInfor2.CopyTo(DestinationFolder + @"\dir8\" + fNameA.Replace(fNameA, numNext) + ".png");

                FileInfo fInfor3 = new FileInfo(fileARR[nDirectFromTo - 1]);
                string fNameA3 = Path.GetFileNameWithoutExtension(fileARR[nDirectFromTo - 1]);
                string fExtA3 = Path.GetExtension(fileARR[nDirectFromTo - 1]);
                string numNext3 = (nDirectFromTo + 16).ToString();
                fInfor3.CopyTo(DestinationFolder + @"\dir8\" + fNameA3.Replace(fNameA3, numNext3) + ".png");

                string srcP = DestinationFolder + @"\dir8\";
                string outputP = DestinationFolder + @"\output\";
                Thread.Sleep(1000);
                var allFiles = Directory.GetFiles(srcP, "*.*", SearchOption.AllDirectories);
                foreach (string newPath in allFiles)
                {
                    File.Copy(newPath, newPath.Replace(srcP, outputP), true);
                } 
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        private void BtnLoadFileOutPut_Click(object sender, EventArgs e)
        {
            string getDir = OutPutImgTxt.Text + @"\output\";
            try
            {
                if (getDir == null)
                {                    
                }
                else
                {
                    FileNameDestinationListBox.Items.Clear();
                    DirectoryInfo dirABC = new DirectoryInfo(getDir);
                    Files = dirABC.GetFiles("*");
                    str = "";
                    int db = 0;
                    foreach (FileInfo file in Files)
                    {
                        db++;
                        FileNameDestinationListBox.Sorted = true;
                        FileNameDestinationListBox.Items.Add(file);
                        str = str + ", " + file.Name;
                    }
                    
                }
            }
            catch (Exception)
            {
                throw;
            }     
        }

        private void BtnClearOutPut_Click(object sender, EventArgs e)
        {
            string destOut = OutPutImgTxt.Text + @"\output\";// +@"\output\"; // @D:\2025\chep\;
            if (Directory.Exists(destOut))
            {
                DirectoryInfo dI = new DirectoryInfo(destOut);
                foreach (FileInfo itemdI in dI.GetFiles())
                {
                    itemdI.Delete();
                }
                FileNameDestinationListBox.Items.Clear();
               
            }
            else
            {
             
            }
        }

        private void BtnOpenSprViewer_Click(object sender, EventArgs e)
        {
            ProcessStartInfo prInfo = new ProcessStartInfo();
            prInfo.FileName = @"jxSPRviewer.exe";
            Process.Start(prInfo);
            toolStripStatusLabel2.Text = "Bạn mở Spr Viewer!";
        }

        private void BtnOpenSprTool_Click(object sender, EventArgs e)
        {
            string sourceDir = OutPutImgTxt.Text + @"\tga\";
            string SprDir = Directory.GetCurrentDirectory() + @"\sprtool\spr\"; 

            string[] textFiles = Directory.GetFiles(sourceDir);

            foreach (string textFile in textFiles)
            {
                string fileName = textFile.Substring(sourceDir.Length);

                File.Copy(Path.Combine(sourceDir, fileName),
                        Path.Combine(SprDir, fileName), true);
            }
            

            DialogResult lkResult = MessageBox.Show("Đang chép file TGA qua tool spr!", "Warning!", MessageBoxButtons.YesNo);
            if (lkResult == DialogResult.Yes)
            {
                ProcessStartInfo prInfo = new ProcessStartInfo();
                prInfo.FileName = Directory.GetCurrentDirectory() + @"\sprtool\spr.exe";
                Process.Start(prInfo);
                toolStripStatusLabel2.Text = "Bạn mở Spr Tool!";
            }
            if (lkResult == DialogResult.No)
            {
                return;
            }

        }

        private void BtnOpenBatchPhoto_Click(object sender, EventArgs e)
        {
            string BatchPhotoPath = BatchPhotoPathTxt.Text;
            ProcessStartInfo prInfo = new ProcessStartInfo();
            prInfo.FileName = BatchPhotoPath;
            Process.Start(prInfo);
            toolStripStatusLabel2.Text = "Bạn mở Batch Photo!";
        }

       



        
    }
}
