using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebCam;
using ImageViewer;
using ProductAI;

namespace CheckoutSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            waitTimeNud.Value = Properties.Settings.Default.WaitSec;

            _ImageViewer = new ScalablePB();
            _ImageViewer.ShowCrosshair = false;
            _ImageViewer.ShowOrigin = false;
            _ImageViewer.Dock = DockStyle.Fill;
            _ImageViewer.Paint += ImageViewer_Paint;
            container.Controls.Add(_ImageViewer);

            _DrawColors = new Color[]
            {
                Color.Red,
                Color.Blue,
                Color.DarkOrange,
                Color.Green,
                Color.Maroon,
                Color.Purple,
            };

            if (!Directory.Exists(_SaveImgPath))
                Directory.CreateDirectory(_SaveImgPath);

            _camera = new Camera(Properties.Settings.Default.AddValue, Properties.Settings.Default.WebIP);
            _camera.OnTriggerEvent += Camera_OnTriggerEvent;
            _camera.OnFrameEvent += Camera_OnFrameEvent;

            string path = @".";
            ProductAI.ProductAI.Initial(path + Properties.Settings.Default.AI_ProductList,
                path + Properties.Settings.Default.AI_cfg,
                path + Properties.Settings.Default.AI_weights,
                path + Properties.Settings.Default.AI_names);

            ProductAI.ProductAI.OnDetectFinished += ProductAI_OnDetectFinished;
        }

        private void ProductAI_OnDetectFinished(object sender, ProductItemEventArgs e)
        {
            if (this.InvokeRequired)
            {
                EventHandler<ProductItemEventArgs> update = new EventHandler<ProductItemEventArgs>(ProductAI_OnDetectFinished);
                try { this.Invoke(update, sender, e); } catch { }
            }
            else
            {
                _DrawItems = e.ProductList;

                if (_IsShowRecord && !_IsYoloRecord)
                {
                    _DrawItems.Clear();
                }
                else
                {
                    _ImageViewer.Refresh();
                    if (_IsShowRecord && _IsYoloRecord)
                        _IsYoloRecord = false;
                }

                if (_IsStopVideo)
                {
                    Bitmap bmp = new Bitmap(_ImageViewer.Image);
                    if (10 == historyListBox.Items.Count)
                    {
                        historyListBox.Items.RemoveAt(9);
                        _CheckTime.RemoveAt(9);
                    }

                    string str = DateTime.Now.ToString("yyyy/MM/dd/ HH:mm:ss");
                    if (0 == historyListBox.Items.Count)
                    {
                        historyListBox.Items.Add(new History(bmp));
                        _CheckTime.Add(str);
                    }
                    else
                    {
                        historyListBox.Items.Insert(0, new History(bmp));
                        _CheckTime.Insert(0, str);
                    }

                    timeLB.Text = "結帳時間: " + str;
                    timeLB.Visible = true;

                    if (!waitThd.IsBusy)
                        waitThd.RunWorkerAsync();

                    _IsStopVideo = false;
                }

                yoloMSLB.Text = e.ProcTime.ToString();
                _IsCapReady = true;
                _IsLockBtn = false;
            }
        }

        private void Camera_OnFrameEvent(object sender, ImageEventArgs e)
        {
            if (this.InvokeRequired)
            {
                if (null == e.Image) return;

                EventHandler<ImageEventArgs> update = new EventHandler<ImageEventArgs>(Camera_OnFrameEvent);
                try { this.Invoke(update, sender, e); } catch { }
            }
            else
            {
                imgMSLB.Text = e.ProcTime;
                if (_IsStopVideo && _camera.IsShowFrame)
                {
                    _camera.IsShowFrame = false;
                    Stopwatch watch = new Stopwatch();
                    watch.Start();
                    e.Image = _camera.AdjustBrightness(e.Image);
                    watch.Stop();
                    e.Image.Save(_SavePath);
                    //Console.WriteLine(watch.ElapsedMilliseconds.ToString());

                    if (!_IsShowRecord)
                    {
                        if (null != _ImageViewer.Image)
                            _ImageViewer.Image.Dispose();

                        _ImageViewer.Image = e.Image;
                        ProductAI.ProductAI.Detect(_SavePath);
                    }
                    else
                    {
                        _IsStopVideo = false;
                        _IsLockBtn = false;
                    }
                }
                else if (_camera.IsShowFrame)
                {
                    if (!_IsShowRecord)
                    {
                        if (null != _ImageViewer.Image)
                            _ImageViewer.Image.Dispose();

                        _ImageViewer.Image = e.Image;
                    }
                    _IsLockBtn = false;
                }
            }
        }

        private void Camera_OnTriggerEvent(object sender, ImageEventArgs e)
        {
            if (this.InvokeRequired)
            {
                if (null == e.Image) return;

                EventHandler<ImageEventArgs> update = new EventHandler<ImageEventArgs>(Camera_OnTriggerEvent);
                try { this.Invoke(update, sender, e); } catch { }
            }
            else
            {
                imgMSLB.Text = e.ProcTime;

                if (!_IsShowRecord)
                {
                    if (_IsFocusCap && !contCapChk.Checked)
                    {
                        if (null != _ImageViewer.Image)
                            _ImageViewer.Image.Dispose();
                        _ImageViewer.Image = e.Image;

                        _camera.IsShowFrame = _IsShowFrame;
                        _IsFocusCap = false;
                    }
                    else
                    {
                        if (null != _ImageViewer.Image)
                            _ImageViewer.Image.Dispose();
                        _ImageViewer.Image = e.Image;

                        if (contCapChk.Checked)
                        {
                            if (!ProductAI.ProductAI.IsBusy)
                            {
                                e.Image.Save(_SavePath);
                                ProductAI.ProductAI.Detect(_SavePath);
                            }
                            else
                            {
                                _IsCapReady = true;
                            }
                        }
                        else
                        {
                            _IsCapReady = true;
                        }
                    }
                }
            }
        }

        private string _SaveImgPath = Application.StartupPath + "//SaveImg//";
        private string _SavePath = Application.StartupPath + "//backImg.bmp";
        private string _ProductPath = Application.StartupPath + "//BackBmp//";
        private Camera _camera;
        private ScalablePB _ImageViewer;
        private readonly ImageConverter _ImageConverter = new ImageConverter();
        private bool _IsStopVideo = false;
        private bool _IsShowFrame = false;
        private bool _IsFocusCap = false;
        private bool _IsLockBtn = false;
        private bool _IsCapReady = true;
        private bool _IsShowRecord = false;
        private bool _IsYoloRecord = false;
        private List<DrawItem> _DrawItems = new List<DrawItem>();
        private List<string> _CheckTime = new List<string>();
        private Color[] _DrawColors;
        private string _CheckoutStr { get { return checkoutBtn.Text; } }
        private bool _IsShowConfidence { get { return confidenceChk.Checked; } }

        private void ImageViewer_Paint(object sender, PaintEventArgs e)
        {
            itemListBox.Items.Clear();
            picLB.Text = "(0件)";
            addListBox.Visible = addLB.Visible = false;
            if (null != _DrawItems && 0 != _DrawItems.Count())
            {
                int total = 0;
                int count = 0;
                for (int i = 0; i < _DrawItems.Count; i++)
                {
                    for (int j = 0; j < _DrawItems[i].Rectangles.Count; j++)
                    {
                        int width = _ImageViewer.Image.Width;
                        int height = _ImageViewer.Image.Height;
                        Point startPt = _ImageViewer.ImgPtToDispPt(new Point(_DrawItems[i].Rectangles[j].X < 0 ? 0 : _DrawItems[i].Rectangles[j].X, _DrawItems[i].Rectangles[j].Y < 0 ? 0 : _DrawItems[i].Rectangles[j].Y));
                        Point endPt = _ImageViewer.ImgPtToDispPt(new Point(_DrawItems[i].Rectangles[j].X + _DrawItems[i].Rectangles[j].Width > width ? width - 1 : _DrawItems[i].Rectangles[j].X + _DrawItems[i].Rectangles[j].Width, _DrawItems[i].Rectangles[j].Y + _DrawItems[i].Rectangles[j].Height >= height ? height - 1 : _DrawItems[i].Rectangles[j].Y + _DrawItems[i].Rectangles[j].Height));
                        e.Graphics.DrawRectangle(new Pen(_DrawColors[i % _DrawColors.Length], (float)5.0 * _ImageViewer.ScaleFactor), PointToRectangle(startPt, endPt));

                        string str = _IsShowConfidence ? ((int)_DrawItems[i].Confidence[j]).ToString("F0") + "-" : "";
                        e.Graphics.DrawString(str + _DrawItems[i].Name, new Font("微軟正黑體", (float)32.0 * _ImageViewer.ScaleFactor, FontStyle.Bold), new SolidBrush(_DrawColors[i % _DrawColors.Length]), new PointF(startPt.X, startPt.Y - 50 * _ImageViewer.ScaleFactor));
                        count++;
                    }

                    itemListBox.Items.Add(new Display((Bitmap)_ImageConverter.ConvertFrom(File.ReadAllBytes(_ProductPath + _DrawItems[i].BarCode + ".bmp")), _DrawItems[i].Name, _DrawItems[i].Rectangles.Count, _DrawItems[i].Rectangles.Count * _DrawItems[i].Price));
                    total += _DrawItems[i].Rectangles.Count * _DrawItems[i].Price;

                }
                addListBox.Visible = addLB.Visible = true;
                picLB.Text = "(" + count + "件)";
                totalLB.Text = checkoutBtn.Text = "$" + total.ToString("N0");
            }
        }

        private Rectangle PointToRectangle(Point pt1, Point pt2)
        {
            return new Rectangle(Math.Min(pt1.X, pt2.X), Math.Min(pt1.Y, pt2.Y), Math.Abs(pt1.X - pt2.X), Math.Abs(pt1.Y - pt2.Y)); ;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            addListBox.Items.Add(new Display((Bitmap)_ImageConverter.ConvertFrom(File.ReadAllBytes(_ProductPath + "candy.bmp")), "棒棒糖", 1, 0));
            ctrlVisibleLB_Click(null, null);
            _camera.Video();

            testLB_Click(null, null);
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                if (null != _ImageViewer.Image)
                    _ImageViewer.Image.Dispose();

                _DrawItems.Clear();
                itemListBox.Items.Clear();
                timeLB.Visible = addListBox.Visible = addLB.Visible = false;
                checkoutBtn.Text = "結帳";
                _ImageViewer.Image = (Bitmap)_ImageConverter.ConvertFrom(File.ReadAllBytes(openFileDialog.FileName));
                _ImageViewer.Image.Save(_SavePath);

                if (!ProductAI.ProductAI.IsBusy)
                    ProductAI.ProductAI.Detect(_SavePath);
            }
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            if (_IsLockBtn || _IsShowRecord || _IsFocusCap || contCapChk.Checked) return;

            if ("結帳" == checkoutBtn.Text)
            {
                _IsStopVideo = true;
                checkoutBtn.Text = "$0";
                _IsLockBtn = true;
            }
            else
            {
                _camera.IsShowFrame = true;
                _DrawItems.Clear();
                itemListBox.Items.Clear();
                timeLB.Visible = addListBox.Visible = addLB.Visible = false;
                totalLB.Text = "$0";
                checkoutBtn.Text = "結帳";
                _IsLockBtn = true;
            }
        }

        private void container_SizeChanged(object sender, EventArgs e)
        {
            _ImageViewer.FitWindow();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _camera.IsShowFrame = false;
            _camera.OnFrameEvent -= Camera_OnFrameEvent;
            _camera.OnTriggerEvent -= Camera_OnTriggerEvent;
            _camera.Exit();
        }

        private void update_Tick(object sender, EventArgs e)
        {
            if (_IsCapReady && !_IsShowRecord)
            {
                _IsCapReady = false;

                if (_IsFocusCap)
                {
                    _camera.Capture(true);
                    _IsFocusCap = false;
                }
                else
                    _camera.Capture();
            }
        }

        private void contCapChk_CheckedChanged(object sender, EventArgs e)
        {
            if (contCapChk.Checked)
            {
                _camera.Video(true);
                _IsCapReady = true;
                update.Enabled = true;
            }
            else
            {
                update.Enabled = false;
                _IsCapReady = true;
                _camera.Video(false);
                _camera.IsShowFrame = "結帳" == checkoutBtn.Text ? true : false;
            }
        }

        private void saveImgBtn_Click(object sender, EventArgs e)
        {
            if (null == _ImageViewer || null == _ImageViewer.Image) return;

            Bitmap bmp = new Bitmap(_ImageViewer.Image);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                if (null != _DrawItems && 0 != _DrawItems.Count())
                {
                    for (int i = 0; i < _DrawItems.Count; i++)
                    {
                        for (int j = 0; j < _DrawItems[i].Rectangles.Count; j++)
                        {
                            int width = _ImageViewer.Image.Width;
                            int height = _ImageViewer.Image.Height;
                            Point startPt = new Point(_DrawItems[i].Rectangles[j].X < 0 ? 0 : _DrawItems[i].Rectangles[j].X, _DrawItems[i].Rectangles[j].Y < 0 ? 0 : _DrawItems[i].Rectangles[j].Y);
                            Point endPt = new Point(_DrawItems[i].Rectangles[j].X + _DrawItems[i].Rectangles[j].Width > width ? width - 1 : _DrawItems[i].Rectangles[j].X + _DrawItems[i].Rectangles[j].Width, _DrawItems[i].Rectangles[j].Y + _DrawItems[i].Rectangles[j].Height >= height ? height - 1 : _DrawItems[i].Rectangles[j].Y + _DrawItems[i].Rectangles[j].Height);
                            g.DrawRectangle(new Pen(_DrawColors[i % _DrawColors.Length], (float)5.0), PointToRectangle(startPt, endPt));
                            g.DrawString(((int)_DrawItems[i].Confidence[j]).ToString() + "-" + _DrawItems[i].Name, new Font("微軟正黑體", (float)32.0, FontStyle.Bold), new SolidBrush(_DrawColors[i % _DrawColors.Length]), new PointF(startPt.X, startPt.Y));
                        }
                    }
                }
            }
            bmp.Save(_SaveImgPath + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".bmp");
            bmp.Dispose();
        }

        private void testLB_Click(object sender, EventArgs e)
        {
            ContorlVisible(!contCapChk.Visible);
        }

        private void ContorlVisible(bool isVisible)
        {
            capAFBtn.Visible = isVisible;
            saveBtn.Visible = isVisible;
            browseBtn.Visible = isVisible;
            saveImgBtn.Visible = isVisible;
            contCapChk.Visible = isVisible;
            yoloMSLB.Visible = isVisible;
            imgMSLB.Visible = isVisible;
            confidenceChk.Visible = isVisible;
            waitTimeNud.Visible = isVisible;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (null == _ImageViewer || null == _ImageViewer.Image) return;

            Bitmap bmp = new Bitmap(_ImageViewer.Image);
            bmp.Save(_SaveImgPath + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".bmp");
            bmp.Dispose();
        }

        private void capAFBtn_Click(object sender, EventArgs e)
        {
            if (_IsShowRecord) return;

            if (!contCapChk.Checked)
            {
                _IsShowFrame = _camera.IsShowFrame;
                _camera.IsShowFrame = false;
                _camera.Capture(true);
            }
            _IsFocusCap = true;
        }

        private void ctrlVisibleLB_Click(object sender, EventArgs e)
        {
            if (mainSC.Panel2Collapsed)
            {
                ctrlVisibleLB.Text = @"▶ ▶ ▶";
                mainSC.Panel2Collapsed = false;
                _IsShowRecord = true;
            }
            else
            {
                ctrlVisibleLB.Text = @"◀ ◀ ◀";
                mainSC.Panel2Collapsed = true;
                _IsShowRecord = false;
                _IsYoloRecord = false;

                if ("結帳" == checkoutBtn.Text)
                {
                    _DrawItems.Clear();
                    timeLB.Visible = false;
                    _camera.IsShowFrame = true;
                }
                else
                {
                    timeLB.Visible = true;
                    _camera.IsShowFrame = false;
                }
            }
        }

        private void historyListBox_Click(object sender, EventArgs e)
        {
            if (-1 == historyListBox.SelectedIndex || historyListBox.SelectedIndex >= historyListBox.Items.Count)
                return;

            if (_IsYoloRecord)
                return;

            if (!ProductAI.ProductAI.IsBusy)
            {
                _IsYoloRecord = true;
                _DrawItems.Clear();
                timeLB.Text = "結帳時間: " + _CheckTime[historyListBox.SelectedIndex];
                timeLB.Visible = true;

                if (null != _ImageViewer.Image)
                    _ImageViewer.Image.Dispose();

                Bitmap bmp = new Bitmap(((History)historyListBox.Items[historyListBox.SelectedIndex]).Image);
                bmp.Save(_SavePath);
                _ImageViewer.Image = bmp;
                ProductAI.ProductAI.Detect(_SavePath);
            }
            else
            {
                _IsYoloRecord = false;
            }
        }

        private void waitThd_DoWork(object sender, DoWorkEventArgs e)
        {
            Stopwatch stop = new Stopwatch();
            stop.Start();

            while (true)
            {
                SpinWait.SpinUntil(() => false, 100);

                if (_CheckoutStr == "結帳")
                {
                    break;
                }
                else
                {
                    if (stop.Elapsed.TotalSeconds > Properties.Settings.Default.WaitSec)
                    {
                        if (_CheckoutStr != "結帳")
                        {
                            this.Invoke(new EventHandler<EventArgs>(checkoutBtn_Click), sender, null);
                        }
                        break;
                    }
                }
            }
            stop.Stop();
        }

        private void waitTimeNud_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.WaitSec = (int)waitTimeNud.Value;
        }
    }
}
