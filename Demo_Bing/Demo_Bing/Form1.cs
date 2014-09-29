using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Net; // for WebClient
using System.IO; // for MemoryStream
using System.Text;// for Encoding
using System.Web;
using Newtonsoft.Json;//for jsaon
using System.Threading; //mutil_thread
using System.Runtime.InteropServices;
//using System.Reflection;




namespace Demo_Bing
{

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                Thread Down_loading = new Thread(new ParameterizedThreadStart(Down_loading_Bing));

                Down_loading.IsBackground = true;

                Down_loading_para parain = new Down_loading_para();
                parain.textBox1 = textBox1;
                Down_loading.Start(parain);
            }


            else
            {
                MessageBox.Show("please select one seach engine!!!");
           
            }








   //        Down_loading.Join();
            



//             if (checkBox1.Checked)
//             {
//                 WebClient wc = new WebClient();
// 
//                 if (textBox1.Text.Length==0)
//                 {
//                     MessageBox.Show("Please Enter the key word");
//                 }
// 
//                 string savepath = ".\\"+textBox1.Text;
//                 Directory.CreateDirectory(savepath);
// 
//                 string tempSearchString_coding = HttpUtility.UrlEncode(textBox1.Text);
//                 for (int i =0;i<Global.NPAGE;i++)
//                 {
//                     text_page.Text = string.Format("{0}", i);
//                     string BingAPI = "http://cn.bing.com/images/async?q=" + tempSearchString_coding + "&async=content&first="+string.Format("{0}",150*i)+"&count=150";
// 
//                     byte[] aryByte = wc.DownloadData(BingAPI);
//                     MemoryStream  ms = new MemoryStream(aryByte);
//                     string html = string.Empty;
//                     using (StreamReader sr = new StreamReader(ms, Encoding.Default))
//                     {
//                         html = sr.ReadToEnd();
//                         
//                     }
//                     string[] stringSeparators = new string[] { "imgurl:&quot;", "&quot;,oh:&quot" };
// 
// 
//                     string[] ImageUrls = html.Split(stringSeparators, StringSplitOptions.None);
//                     
// 
//                     int begin_idx = ImageUrls[0].IndexOf("beg");
// 
//                     int end_idx = ImageUrls[0].IndexOf("\"", begin_idx + 5);
// 
//                     int start = int.Parse(ImageUrls[0].Substring(begin_idx+5,end_idx-begin_idx-5));
// 
//                     begin_idx = ImageUrls[0].IndexOf("end");
// 
//                     end_idx = ImageUrls[0].IndexOf("\"", begin_idx + 5);
// 
//                     int re_end = int.Parse(ImageUrls[0].Substring(begin_idx + 5, end_idx - begin_idx - 5));
// 
//                     Text_end.Text = string.Format("{0}", re_end);
// 
//         //          Bing_Head_json ja = (Bing_Head_json)JsonConvert.DeserializeObject(ImageUrls[0]+1, typeof(Bing_Head_json));
// 
//                     for (int j =1;j<ImageUrls.Length;j+=2)
//                     {
//                         text_imgnow.Text = string.Format("{0}", i*150+(j+1)/2-1);
//                         string ImgSavePath = savepath+"\\"+textBox1.Text+"_"+string.Format("{0}",i*150+(j+1)/2)+".jpg";
//                         string url_path =  ImageUrls[j];
// 
//                         Down_loading_para parain =new Down_loading_para();
//                         parain.wc =wc;
//                         parain.urls= new string[2];
//                         parain.urls[0] = url_path;
//                         parain.urls[1]= ImgSavePath;
// 
//                         Thread th_down = new Thread(new ParameterizedThreadStart(Down_loading_wc));
// 
//                         th_down.Start(parain);
//                         this.Refresh();
// 
//                         th_down.Join(5000);
// 
// //                          try
// //                          {
// //                              wc.DownloadFile(url_path, ImgSavePath); // using the DownloadFile function instead of DownloadData
// //                        //      ms = new MemoryStream(wc.DownloadData(parts[2]));
// //                        //      Image img = Image.FromStream(ms);
// //                        //      img.Save(ImgSavePath); 
// //                          }
// //                          catch (System.Exception ex)
// //                          {
// //                           //    MessageBox.Show(ex.Message + parts[2]);// catch the exception when the image is invalid
// // 
// //                          }
//                     }
// 
//                     if ((re_end +1)%150 !=0)
//                     {
//                         MessageBox.Show("Reaching the end of Index!");
//                         break;
//                     }
// 
//                 }
// 
// 
// 
// 
// 
//             }
//             else 
//             {
//                 MessageBox.Show("Please select Bing");         
// 
//             }



        }

        private void Down_loading_Bing(object parain)
        {
            if (checkBox_xunlei.Checked)
            {
                Thunder_SDK.XLInitDownloadEngine();
            }

            Down_loading_para para = (Down_loading_para)parain;

//             if (para.checkBox1.Checked)
//             {
                WebClient wc = new WebClient();

                if (para.textBox1.Text.Length == 0)
                {
                    MessageBox.Show("Please Enter the key word");
                }

                string savepath = ".\\" + para.textBox1.Text;
                Directory.CreateDirectory(savepath);

                string tempSearchString_coding = HttpUtility.UrlEncode(para.textBox1.Text);
                for (int i = 0; i < Global.NPAGE; i++)
                {
                    string text_page = string.Format("{0}", i);
                    SafeSetText_pageidx(text_page);

                    string BingAPI = "http://cn.bing.com/images/async?q=" + tempSearchString_coding + "&async=content&first=" + string.Format("{0}", 150 * i) + "&count=150";

                    byte[] aryByte = wc.DownloadData(BingAPI);
                    MemoryStream ms = new MemoryStream(aryByte);
                    string html = string.Empty;
                    using (StreamReader sr = new StreamReader(ms, Encoding.Default))
                    {
                        html = sr.ReadToEnd();

                    }
                    string[] stringSeparators = new string[] { "imgurl:&quot;", "&quot;,oh:&quot" };


                    string[] ImageUrls = html.Split(stringSeparators, StringSplitOptions.None);


                    int begin_idx = ImageUrls[0].IndexOf("beg");

                    int end_idx = ImageUrls[0].IndexOf("\"", begin_idx + 5);

                    int start = int.Parse(ImageUrls[0].Substring(begin_idx + 5, end_idx - begin_idx - 5));

                    begin_idx = ImageUrls[0].IndexOf("end");

                    end_idx = ImageUrls[0].IndexOf("\"", begin_idx + 5);

                    int re_end = int.Parse(ImageUrls[0].Substring(begin_idx + 5, end_idx - begin_idx - 5));

               //     para.Text_end.Text = string.Format("{0}", re_end);
                    String set_textend = string.Format("{0}",re_end);

                    SafeSetText_textend(set_textend);
                    continue;

//                     _SafeSetTextCall call = delegate(string s)
//                     {
//                         para.Text_end.Text = string.Format("{0}", re_end);
//                     };

             //       this.Invoke(call, string.Format("{0}", re_end));


             //       Bing_Head_json ja = (Bing_Head_json)JsonConvert.DeserializeObject(ImageUrls[0]+1, typeof(Bing_Head_json));

                    for (int j = 1; j < ImageUrls.Length; j += 2)
                    {
                        string text_imgnow = string.Format("{0}", i * 150 + (j + 1) / 2 - 1);

                        SafeSetText_imgnow(text_imgnow);
                        string ImgSavePath = savepath + "\\" + para.textBox1.Text + "_" + string.Format("{0}", i * 150 + (j + 1) / 2) + ".jpg";
                        string url_path = ImageUrls[j];


                        if (checkBox_xunlei.Checked)
                        {
                            Int32 lTaskId=0;
                            Int32 dwRet = Thunder_SDK.XLURLDownloadToFile(ImgSavePath, url_path, "", ref lTaskId);


                            float last = 0;

                            do
                            {
                                Thread.Sleep(500);
                                last += 0.5F;



                                Int64 ullFileSize = 0;
                                Int64 ullRecvSize = 0;
                                int lStatus = -1;

                                dwRet = Thunder_SDK.XLQueryTaskInfo(lTaskId, ref lStatus, ref ullFileSize, ref ullRecvSize);
                                if (Thunder_SDK.XL_SUCCESS == dwRet)
                                {
                                    if (last > 5 && 0 == ullFileSize||last>60)
                                    {
                                        lStatus = 12;
                                    }

                                    if (11 == lStatus)
                                    {       
                                        break;
                                    }

                                    if (12 == lStatus)
                                    {
                                        break;
                                    }                     

                                }
                            } while (Thunder_SDK.XL_SUCCESS == dwRet);
                            Thunder_SDK.XLStopTask(lTaskId);//搜索程序

                        }
                        else
                        {

                            try
                            {
                                wc.DownloadFile(url_path, ImgSavePath); // using the DownloadFile function instead of DownloadData
                                //      ms = new MemoryStream(wc.DownloadData(parts[2]));
                                //      Image img = Image.FromStream(ms);
                                //      img.Save(ImgSavePath); 
                                //    MessageBox.Show("down_load_success!");
                            }
                            catch (System.Exception ex)
                            {
                                //    MessageBox.Show(ex.Message + parts[2]);// catch the exception when the image is invalid

                            }
                        }
//                         Down_loading_para parain = new Down_loading_para();
//                         parain.wc = wc;
//                         parain.urls = new string[2];
//                         parain.urls[0] = url_path;
//                         parain.urls[1] = ImgSavePath;
// 
//                         Thread th_down = new Thread(new ParameterizedThreadStart(Down_loading_wc));

  //                      th_down.Start(parain);
   //                     this.Refresh();

  //                      th_down.Join(5000);

//                          try
//                          {
//                              wc.DownloadFile(url_path, ImgSavePath); // using the DownloadFile function instead of DownloadData
//                        //      ms = new MemoryStream(wc.DownloadData(parts[2]));
//                        //      Image img = Image.FromStream(ms);
//                        //      img.Save(ImgSavePath); 
//                          }
//                          catch (System.Exception ex)
//                          {
//                           //    MessageBox.Show(ex.Message + parts[2]);// catch the exception when the image is invalid
// 
//                          }

                    }

                    if ((re_end + 2) % 150 != 0&&re_end !=149)
                    {
                        MessageBox.Show("Reaching the end of Index!");
                        break;
                    }

                }

            }
//             else
//             {
//                 MessageBox.Show("Please select Bing");
// 
//             }

// 
// 
// 
//             Down_loading_para js = (Down_loading_para)x;
//             WebClient wc = js.wc;
//             string imageurl = js.urls[0];
//             string ImgSavePath = js.urls[1];


     //   }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SafeSetText_textend(string text)
        {
            if (this.InvokeRequired)
            {
                _SafeSetTextCall call = delegate(string s)
                {
                    this.Text_end.Text = s;
                };

                this.Invoke(call, text);
            }
            else
                this.Text_end.Text = text;
        }

        private void SafeSetText_imgnow(string text)
        {
            if (this.InvokeRequired)
            {
                _SafeSetTextCall call = delegate(string s)
                {
                    this.text_imgnow.Text = s;
                };

                this.Invoke(call, text);
            }
            else
                this.text_imgnow.Text = text;
        }

        private void SafeSetText_pageidx(string text)
        {
            if (this.InvokeRequired)
            {
                _SafeSetTextCall call = delegate(string s)
                {
                    this.text_page.Text = s;
                };

                this.Invoke(call, text);
            }
            else
                this.text_page.Text = text;
        }



        private delegate void _SafeSetTextCall(string text);

        private void checkBox_xunlei_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_xunlei.Checked)
            {

            }
            else
            {
                Thunder_SDK.XLUninitDownloadEngine();
            }

        }




 /*       private delegate void _SafeSetTextCall(string text); */


    }
}






public class Bing_Head_json
{
    public int beg { get; set; }
    public int end { get; set; }
}

public class Down_loading_para
{
    public CheckBox checkBox1;
    public TextBox textBox1;
  //  public Label text_page;
  //  public Label Text_end;
  //  public Label text_imgnow;


  //  public string[] urls;
}

class Global
{
    public static int NPAGE = 20;
}
class Thunder_SDK
{
    enum enumTaskStatus
    {
        enumTaskStatus_Connect = 0,                 // 已经建立连接
        enumTaskStatus_Download = 2,                // 开始下载 
        enumTaskStatus_Pause = 10,                  // 暂停
        enumTaskStatus_Success = 11,                // 成功下载
        enumTaskStatus_Fail = 12,                   // 下载失败
    };
    public const int XL_SUCCESS = 0;
    public const int XL_ERROR_FAIL = 0x10000000;
    // 尚未进行初始化
    public const int XL_ERROR_UNINITAILIZE = XL_ERROR_FAIL + 1;
    // 不支持的协议，目前只支持HTTP
    public const int XL_ERROR_UNSPORTED_PROTOCOL = XL_ERROR_FAIL + 2;
    // 初始化托盘图标失败
    public const int XL_ERROR_INIT_TASK_TRAY_ICON_FAIL = XL_ERROR_FAIL + 3;
    // 添加托盘图标失败
    public const int XL_ERROR_ADD_TASK_TRAY_ICON_FAIL = XL_ERROR_FAIL + 4;
    // 指针为空
    public const int XL_ERROR_POINTER_IS_NULL = XL_ERROR_FAIL + 5;
    // 字符串是空串
    public const int XL_ERROR_STRING_IS_EMPTY = XL_ERROR_FAIL + 6;
    // 传入的路径没有包含文件名
    public const int XL_ERROR_PATH_DONT_INCLUDE_FILENAME = XL_ERROR_FAIL + 7;
    // 创建目录失败
    public const int XL_ERROR_CREATE_DIRECTORY_FAIL = XL_ERROR_FAIL + 8;
    // 内存不足
    public const int XL_ERROR_MEMORY_ISNT_ENOUGH = XL_ERROR_FAIL + 9;
    // 参数不合法
    public const int XL_ERROR_INVALID_ARG = XL_ERROR_FAIL + 10;
    // 任务不存在
    public const int XL_ERROR_TASK_DONT_EXIST = XL_ERROR_FAIL + 11;
    // 文件名不合法
    public const int XL_ERROR_FILE_NAME_INVALID = XL_ERROR_FAIL + 12;
    // 没有实现
    public const int XL_ERROR_NOTIMPL = XL_ERROR_FAIL + 13;
    // 已经创建的任务数达到最大任务数，无法继续创建任务
    public const int XL_ERROR_TASKNUM_EXCEED_MAXNUM = XL_ERROR_FAIL + 14;
    // 任务类型未知
    public const int XL_ERROR_INVALID_TASK_TYPE = XL_ERROR_FAIL + 15;
    // 文件已经存在
    public const int XL_ERROR_FILE_ALREADY_EXIST = XL_ERROR_FAIL + 16;
    // 文件不存在
    public const int XL_ERROR_FILE_DONT_EXIST = XL_ERROR_FAIL + 17;
    // 读取cfg文件失败
    public const int XL_ERROR_READ_CFG_FILE_FAIL = XL_ERROR_FAIL + 18;
    // 写入cfg文件失败
    public const int XL_ERROR_WRITE_CFG_FILE_FAIL = XL_ERROR_FAIL + 19;
    // 无法继续任务，可能是不支持断点续传，也有可能是任务已经失败
    // 通过查询任务状态，确定错误原因。
    public const int XL_ERROR_CANNOT_CONTINUE_TASK = XL_ERROR_FAIL + 20;
    // 无法暂停任务，可能是不支持断点续传，也有可能是任务已经失败
    // 通过查询任务状态，确定错误原因。
    public const int XL_ERROR_CANNOT_PAUSE_TASK = XL_ERROR_FAIL + 21;
    // 缓冲区太小
    public const int XL_ERROR_BUFFER_TOO_SMALL = XL_ERROR_FAIL + 22;
    // 调用XLInitDownloadEngine的线程，在调用XLUninitDownloadEngine之前已经结束。
    // 初始化下载引擎线程，在调用XLUninitDownloadEngine之前，必须保持执行状态。
    public const int XL_ERROR_INIT_THREAD_EXIT_TOO_EARLY = XL_ERROR_FAIL + 23;

    [DllImport("XLDownload.dll", EntryPoint = "XLInitDownloadEngine")]
    public static extern bool XLInitDownloadEngine();
    [DllImport("XLDownload.dll", EntryPoint = "XLURLDownloadToFile", CharSet = CharSet.Unicode)]
    public static extern Int32 XLURLDownloadToFile(string pszFileName, string pszUrl, string pszRefUrl, ref Int32 lTaskId);
    [DllImport("XLDownload.dll")]
    public static extern Int32 XLQueryTaskInfo(Int32 lTaskId, ref Int32 plStatus, ref Int64 pullFileSize, ref Int64 pullRecvSize);
    [DllImport("XLDownload.dll")]
    public static extern Int32 XLPauseTask(Int32 lTaskId, ref Int32 lNewTaskId);
    [DllImport("XLDownload.dll")]
    public static extern Int32 XLContinueTask(Int32 lTaskId);
    [DllImport("XLDownload.dll")]
    public static extern void XLStopTask(Int32 lTaskId);
    [DllImport("XLDownload.dll")]
    public static extern bool XLUninitDownloadEngine();
}