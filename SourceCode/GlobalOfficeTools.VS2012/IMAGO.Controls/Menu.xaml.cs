using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace IMAGO.Controls
{
    public partial class Menu : UserControl
    {
        #region Dependency Properties 
        //public static readonly DependencyProperty ItemSourceProperty = DependencyProperty.Register("ItemSource", typeof(IEnumerable), typeof(Menu), new PropertyMetadata(ItemSourcePropertyChanged));
        //public IEnumerable ItemSource
        //{
        //    get { return (IEnumerable)GetValue(ItemSourceProperty); }
        //    set { SetValue(ItemSourceProperty, value); }
        //}

        //public static void ItemSourcePropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        //{
        //}

        public static DependencyProperty MenuLabelProperty = DependencyProperty.Register("MenuLabel", typeof(string), typeof(Menu), new PropertyMetadata(null, MenuLabelPropertyChanged));
        public string MenuLabel
        {
            get { return (string)base.GetValue(MenuLabelProperty); }
            set { SetValue(MenuLabelProperty, value); }
        }

        public static void MenuLabelPropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
        }
        #endregion

        public Menu()
        {
            InitializeComponent();
        }

        
    }
}
