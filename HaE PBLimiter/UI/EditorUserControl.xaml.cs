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

namespace HaE_PBLimiter
{
    /// <summary>
    /// Interaction logic for EditorUserControl.xaml
    /// </summary>
    public partial class EditorUserControl : UserControl
    {
        public EditorUserControl()
        {
            InitializeComponent();

            Data.Unloaded += DataGrid_Unloaded;
        }

        void DataGrid_Unloaded(object sender, RoutedEventArgs e)
        {
            var grid = (DataGrid)sender;
            grid.CommitEdit(DataGridEditingUnit.Row, true);
        }
    }
}
