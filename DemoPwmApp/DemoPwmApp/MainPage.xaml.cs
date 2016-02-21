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
using GIS = GHIElectronics.UWP.Shields;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DemoPwmApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private GIS.FEZHAT hat;

        public MainPage()
        {
            this.InitializeComponent();
            Setup();
        }
        private async void Setup()
        {
            this.hat = await GIS.FEZHAT.CreateAsync();
            // Motors typically require a frequency in excess of 10KHz
            // Servos typically require 50Hz.

            this.hat.S1.SetLimits(500, 2400, 0, 180);
            this.hat.S2.SetLimits(500, 2400, 0, 180);

            //Other sensors
            Debug.WriteLine($"Light: {this.hat.GetLightLevel()}");
            Debug.WriteLine($"Temp: {this.hat.GetTemperature()}");

            double x, y, z;
            this.hat.GetAcceleration(out x, out y, out z);
            Debug.WriteLine($"Accel: ({x:N2}, {y:N2}, {z:N2})");
        }

        private void slA_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            double val = e.NewValue / 100.0;
            this.hat.MotorA.Speed = val;
        }

        private void slB_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            double val = e.NewValue / 100.0;
            this.hat.MotorB.Speed = val;
        }
    }
}
