# ProductAI
The ProductAI is used **ProductAI.dll** to detect the product. If you want to use this library, please download the **sample code and this [link](https://drive.google.com/file/d/1U4aMRyRxnsZ4DVlN8py1bGgq2fG4Egzg/view?usp=sharing)** first. **The weight file must be placed to directory of model.**

##System requirements
* .Net Framework 4.6.1 or .Net standard 2.0
* Microsoft Visual C++ Redistributable for Visual Studio 2015, 2017 and 2019 x64

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
