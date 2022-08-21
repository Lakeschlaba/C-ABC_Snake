﻿using System;
using System.Collections.Generic;
using System.Media;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace ABC_Snake
{
    /// <summary>
    /// Interaktionslogik für gameover.xaml
    /// </summary>
    public partial class gameover : Window
    { 
        SoundPlayer backgroundSound = new SoundPlayer(@"C:\Users\gereo\Documents\ProgrammeC#\ABC_Snake\ABC_Snake_Game\Sounds\YiJianMei.wav"); //Soundfile für den Hintergrund

        public gameover()
        {
            InitializeComponent();
            backgroundSound.PlayLooping(); //Spilet den Sound ab und das in einem Loop
        }

        private void PlayAgainBtn_Click(object sender, RoutedEventArgs e) //Wird Button namens PlayAgainBtn geklickt wird diese Methode ausgeführt
        {
            MainWindow mainwindow = new MainWindow();
            mainwindow.Show(); //MainWindow Fenster wird ausgeführt
            backgroundSound.Stop(); //Stopt den Sound
            this.Close(); //Alles andere schließt sich
        }
        private void ExitBtn_Click(object sender, RoutedEventArgs e) //Wird Button namens ExitBtn geklickt wird diese Methode ausgeführt
        {
            backgroundSound.Stop(); //Stopt den Sound
            this.Close(); //Alles schließt sich
        }
    }
}