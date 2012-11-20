using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace NATControl
{
    public sealed partial class ColorItemCtrl : UserControl
    {
        public ColorItemCtrl(string clrname, Color clr)
        {
            this.InitializeComponent();
            txtblkName.Text = clrname;
            txtblkRgb.Text  = String.Format("{0:X2} {1:X2} {2:X2}", clr.R, clr.G, clr.B);
            rectangle.Fill  = new SolidColorBrush(clr);
        }
    }
}
