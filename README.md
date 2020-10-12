# ProductAI
The ProductAI is used **ProductAI.dll** to detect the product. If you want to use this library, please download the **sample code and this [link](https://drive.google.com/file/d/1U4aMRyRxnsZ4DVlN8py1bGgq2fG4Egzg/view?usp=sharing)** first. **The weight file must be placed to directory of model.**

## Sample Code
```C#
private void Initial()
{
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
```
