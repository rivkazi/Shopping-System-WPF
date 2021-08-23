﻿using BL.AprioriIMP;
using Shopping_system.View_Model;
using System;
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
using System.Windows.Shapes;

namespace Shopping_system.View
{
    /// <summary>
    /// Interaction logic for AssocRulesWindow.xaml
    /// </summary>
    public partial class AssocRulesUC : UserControl
    {
        public AprioriVM currentVM { get; set; }
        public AssocRulesUC()
        {
            InitializeComponent();
            currentVM = new AprioriVM();

            DataContext = currentVM;
        }
    }
}
