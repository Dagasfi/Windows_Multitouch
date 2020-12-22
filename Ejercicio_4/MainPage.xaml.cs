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

namespace Ejercicio_4
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        List<CompositeTransform> Images;
        CompositeTransform ctA = new CompositeTransform();
        CompositeTransform ctB = new CompositeTransform();
        CompositeTransform ctC = new CompositeTransform();

        Dictionary<string, CompositeTransform> asociacionImgCT;
        public MainPage()
        {
            this.InitializeComponent();
            asociacionImgCT = new Dictionary<string, CompositeTransform>();
            asociacionImgCT.Add("image", ctA);
            asociacionImgCT.Add("image2", ctB);
            asociacionImgCT.Add("image3", ctC);

            foreach (KeyValuePair<string, CompositeTransform> kvp in asociacionImgCT)
            {
                kvp.Value.ScaleX = 1.0;
                kvp.Value.ScaleY = 1.0;
                kvp.Value.Rotation = 0;
            }

            image.ManipulationMode = ManipulationModes.Rotate | ManipulationModes.Scale | ManipulationModes.TranslateX | ManipulationModes.TranslateY | ManipulationModes.TranslateInertia;
            image2.ManipulationMode = ManipulationModes.Rotate | ManipulationModes.Scale | ManipulationModes.TranslateX | ManipulationModes.TranslateY | ManipulationModes.TranslateInertia;
            image3.ManipulationMode = ManipulationModes.Rotate | ManipulationModes.Scale | ManipulationModes.TranslateX | ManipulationModes.TranslateY | ManipulationModes.TranslateInertia;
            //PERMITIMOS ESCALAR, ROTAR y TRANSALDARconInercia(MOVER).
        }

        private void manipulationdeltaHandler(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            FrameworkElement source = (FrameworkElement)e.OriginalSource;
            CompositeTransform ct = asociacionImgCT[source.Name];
            ct.ScaleX *= e.Delta.Scale;
            ct.ScaleY *= e.Delta.Scale;

            ct.Rotation += e.Delta.Rotation;

            ct.CenterX = source.Width / 2.0;
            ct.CenterY = source.Height / 2.0;

            ct.TranslateX += e.Delta.Translation.X;
            ct.TranslateY += e.Delta.Translation.Y;

            source.RenderTransform = ct;
        }

        private void image2_manipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            manipulationdeltaHandler(sender, e);
        }

        private void image1_manipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            manipulationdeltaHandler(sender, e);
        }

        private void image3_manipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            manipulationdeltaHandler(sender, e);
        }
    }
}
