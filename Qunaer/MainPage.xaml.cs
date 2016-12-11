using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Newtonsoft.Json;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace Qunaer
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ViewModel.MainPageViewModel viewmodel;
        public MainPage()
        {
            this.InitializeComponent();
            viewmodel = new ViewModel.MainPageViewModel();
            this.DataContext = viewmodel;
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            await FirstStep();
        }

        private async Task FirstStep()
        {
            string json = await HttpRequest.HttpRequest.MainPageRequest(1, "三亚");
            Model.Tourlist tourlist;
            if (!System.String.IsNullOrWhiteSpace(json))
            {
                tourlist = JsonConvert.DeserializeObject<Model.Tourlist>(json);
                viewmodel.Tourlist = tourlist.data.books;
            }
        }
    }

    public class Converter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string param = parameter.ToString();
            if (parameter != null)
            {
                switch(param)
                {
                    case "时间":
                        {
                            return ("开始时间: " + value.ToString());
                        }
                    case "天数":
                        {
                            return ("旅程天数: " + value.ToString());
                        }
                }
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
