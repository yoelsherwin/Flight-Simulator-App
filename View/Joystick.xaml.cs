﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FlightSimulator.View
{
    /// <summary>
    /// Interaction logic for Joystick.xaml
    /// </summary>
    public partial class Joystick : Page
    {
        public Joystick()
        {
            InitializeComponent();
        }
        private void centerKnob_Completed(Object sender, EventArgs e) { }

        private void KnobBase_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
    
}
