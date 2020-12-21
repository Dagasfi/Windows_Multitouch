using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace Ejercicio_3
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        CompositeTransform ct;
        public MainPage()
        {
            this.InitializeComponent();
            ct = new CompositeTransform();
            ct.ScaleX = 1.0;
            ct.ScaleY = 1.0;
            ct.Rotation = 0;
            image.ManipulationMode = ManipulationModes.Rotate | ManipulationModes.Scale;
            //SOLO permitimos o rotar o escalar.
        }

        private void image1_manipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            FrameworkElement source = (FrameworkElement)e.OriginalSource;
            ct.ScaleX *= e.Delta.Scale;
            ct.ScaleY *= e.Delta.Scale;

            ct.Rotation += e.Delta.Rotation;

            ct.CenterX = source.Width / 2.0;
            ct.CenterY = source.Height / 2.0;

            source.RenderTransform = ct;
        }
    }
}
