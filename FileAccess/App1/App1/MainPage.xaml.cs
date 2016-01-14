using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            Doit();
        }

        private async void Doit()
        {
            try
            {
                var folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Database");
                var file = await folder.GetFileAsync("DB.json");
                var x = file;
                //await(
                //    await FileUtils.GetLocalFolder().GetFolderAsync("Database")
                //    ).GetFileAsync("DB.json");
            }
            catch (FileNotFoundException d)
            {
                //await(
                //    await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///Database/DB.json"))).CopyAsync(await FileUtils.GetLocalFolder().GetFolderAsync("Database"));
            }

        }

        private object await(object p)
        {
            throw new NotImplementedException();
        }
    }
}

