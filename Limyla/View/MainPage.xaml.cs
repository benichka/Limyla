using System;
using Limyla.ViewModels;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Limyla
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        /// <summary>ViewModel to associate to the page</summary>
        public PageXViewModel ViewModel { get; set; } = new PageXViewModel();

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainPage()
        {
            this.InitializeComponent();
            ViewModel = new PageXViewModel();
        }

        /// <summary>
        /// When navigated to this page
        /// </summary>
        /// <param name="e">Navigation parameters</param>
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            // When executing on a phone
            if (Windows.Foundation.Metadata.ApiInformation.IsTypePresent("Windows.Phone.UI.Input.HardwareButtons"))
            {
                var statusBar = Windows.UI.ViewManagement.StatusBar.GetForCurrentView();

                // If we want to set the color
                statusBar.BackgroundColor = Windows.UI.Colors.Transparent;
                statusBar.ForegroundColor = Windows.UI.Colors.Red;

                // If we want to hide the status bars
                await statusBar.HideAsync();
            }
        }
    }
}
