using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using GalaSoft.MvvmLight.Messaging;
using IMAGO.MvvmLib.Messages;
using IMAGO.MvvmLib.Navigation;

namespace GlobalOfficeTools.VS2012
{
    public partial class MainPage : UserControl
    {
        #region Public Properties
        [ImportMany("Window", AllowRecomposition = true)]
        public IEnumerable<Lazy<object, IMetadata>> _windowList { get; set; }
        #endregion

        #region Constructor 
        public MainPage()
        {
            CompositionInitializer.SatisfyImports(this);
            InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }        
        #endregion

        #region UserControl Events 
        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Register<ShowWindowMessage>(this, result =>
            {
                var oView = _windowList.Single(x => x.Metadata.Name == result.WindowName).Value;
                //this.fldPageTitle.Text = result.WindowTitle;
                this.mainContent.Child = oView as UIElement;
            });
        }
        #endregion
    }
}
