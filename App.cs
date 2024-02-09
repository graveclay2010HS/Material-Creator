#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Media.Imaging;
using System.Drawing.Imaging;
using System.Windows.Media;
using System.Windows.Forms;
using static System.Console;

#endregion

namespace Material_Creator
{
    class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication a)
        {

            //Tab name & Panel name
            string tabName = "Material Creator";
            string panelName = "Architecture";

            //Create your tab and panel
            a.CreateRibbonTab(tabName);
            RibbonPanel riBBon = a.CreateRibbonPanel(tabName, panelName);

            //Get the Assembly path
            string thisPath = Assembly.GetExecutingAssembly().Location;

            //define PushButtonData
            PushButtonData pbData1 = new PushButtonData("cmdMaterials", "Materials", thisPath, "Material_Creator.Materials");
            BitmapImage pdIamge1 = new BitmapImage(new Uri("pack://application:,,,/Material Creator;component/Resources/Materials.png"));
            pbData1.LargeImage = pdIamge1;

            //add Pushbutton to Your Panal
            PushButton pbButton1 = riBBon.AddItem(pbData1) as PushButton;

            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication a)
        {
            return Result.Succeeded;
        }
    }
}