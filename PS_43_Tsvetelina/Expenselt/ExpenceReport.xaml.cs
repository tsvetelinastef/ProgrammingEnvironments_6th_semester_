﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ExpenseIt
{
    /// <summary>
    /// Interaction logic for ExpenceReport.xaml
    /// </summary>
    public partial class ExpenceReport : Window
    {
        public ExpenceReport()
        {
            InitializeComponent();
        }

        public ExpenceReport(object data) : this()
        {
            this.DataContext = data;
        }
    }
}
