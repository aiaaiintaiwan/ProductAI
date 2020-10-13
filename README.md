# ProductAI
The ProductAI is used **ProductAI.dll** to detect the product. If you want to use this library, please download **sample code and the [weights](https://drive.google.com/file/d/1fO5FkQXADNik-m7zpTiGdxGuH8BOqJSj/view?usp=sharing)** first.

## Train and Test
IF you want to detect the product, please download the link.
* [Weights](https://drive.google.com/file/d/1fO5FkQXADNik-m7zpTiGdxGuH8BOqJSj/view?usp=sharing) : **The weight file must be placed to directory of model.**
* [Train Image](https://drive.google.com/file/d/1Zw9WyKVUqHIM5QQmP27i8tfrzkc8qwpT/view?usp=sharing)
* [Test Image](https://drive.google.com/file/d/1_r45yU8AHSbe4NMLPbx2KmVibIMXdttT/view?usp=sharing)

## System requirements
* .Net Framework 4.6.1 or .Net standard 2.0
* Microsoft Visual C++ Redistributable for Visual Studio 2015, 2017 and 2019 x64
### GPU requirements (optional)
It is important to use the mentioned version 10.2
1. Install the latest Nvidia driver for your graphic device
2. Install Nvidia CUDA Toolkit 10.2 (must be installed add a hardware driver for cuda support)
3. Download Nvidia cuDNN v7.6.5 for CUDA 10.2
4. Copy the cudnn64_7.dll from the output directory of point 2. into the project folder.

## Eample Code
Step 1. Initial
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
  List<DrawItem> DrawItems = e.ProductList;
}
```
Step 2. Detect from Image **(File Path)**
```C#
private void browseBtn_Click(object sender, EventArgs e)
{
  bmp.Save(@".detect.bmp");
  ProductAI.ProductAI.Detect(@".detect.bmp");
}
```
Step 3. Result
```C#
private void ProductAI_OnDetectFinished(object sender, ProductItemEventArgs e)
{
  List<DrawItem> DrawItems = e.ProductList;
}
```
