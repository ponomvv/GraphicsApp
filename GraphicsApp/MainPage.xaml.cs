﻿using System;
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
using Windows.UI;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace GraphicsApp
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            //Цвет кнопки с помощью кода
            this.InitializeComponent();
            Button myButton2 = new Button();
            Color redColor = Color.FromArgb(255, 255, 0, 0);
            SolidColorBrush buttonBrush = new SolidColorBrush(redColor);
            myButton2.Content = "HELLO2";
            myButton2.Margin = new Thickness(10);
            myButton2.Background = buttonBrush;
            stackPanel.Children.Add(myButton2);
        }
    }
}
