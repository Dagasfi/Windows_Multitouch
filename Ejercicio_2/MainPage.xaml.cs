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

namespace Ejercicio_2
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }


        private void image1_pointer_entered(object sender, PointerRoutedEventArgs e)
        {
            double x = e.GetCurrentPoint(image).Position.X;
            double y = e.GetCurrentPoint(image).Position.Y;
            this.listView.Items.Insert(0, "[ENTER] x: " + x + ", y: " + y);
        }

        private void image1_pointer_exited(object sender, PointerRoutedEventArgs e)
        {
            double x = e.GetCurrentPoint(image).Position.X;
            double y = e.GetCurrentPoint(image).Position.Y;
            this.listView.Items.Insert(0, "[OUT] x: " + x + ", y: " + y);
        }

        private void image1_pointer_moved(object sender, PointerRoutedEventArgs e)
        {
            double x = e.GetCurrentPoint(image).Position.X;
            double y = e.GetCurrentPoint(image).Position.Y;
            this.listView.Items.Insert(0, "[MOVE] x: " + x + ", y: " + y);
        }

        private void image1_pointer_pressed(object sender, PointerRoutedEventArgs e)
        {
            double x = e.GetCurrentPoint(image).Position.X;
            double y = e.GetCurrentPoint(image).Position.Y;
            this.listView.Items.Insert(0, "[PRESS] x: " + x + ", y: " + y);
        }

        private void image1_pointer_released(object sender, PointerRoutedEventArgs e)
        {
            double x = e.GetCurrentPoint(image).Position.X;
            double y = e.GetCurrentPoint(image).Position.Y;
            this.listView.Items.Insert(0, "[RELEASE] x: " + x + ", y: " + y);
        }

        private void image1_pointer_wheel(object sender, PointerRoutedEventArgs e)
        {
            double x = e.GetCurrentPoint(image).Position.X;
            double y = e.GetCurrentPoint(image).Position.Y;
            this.listView.Items.Insert(0, "[WHEEL] x: " + x + ", y: " + y);
        }

        private void image1_doubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            // hacer la imagen totalmente visible.
            image.Opacity = 1;
        }

        private void image1_tapped(object sender, TappedRoutedEventArgs e)
        {
            //Bajar la transparencia un 10%.
            image.Opacity = image.Opacity - 0.1;
        }

        private void image1_holding(object sender, HoldingRoutedEventArgs e)
        {
            //Borrar el listview.
            this.listView.Items.Clear();
        }
    }
}

