using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using IMAGO.MvvmLib.Navigation;

namespace GlobalOfficeTools.VS2012.Entities
{
    [ExportWindow("EntitiesList")]
    public partial class EntitiesList : UserControl
    {
        public EntitiesList()
        {
            InitializeComponent();
        }
    }
}
