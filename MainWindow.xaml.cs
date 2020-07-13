using System;
using System.Collections;
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

namespace SortedL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList testSortedList;
        public MainWindow()
        {
            InitializeComponent();
            testSortedList = new SortedList();
        }
        
        //Event Click
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            testSortedList.Add(int.Parse(txtKey.Text),txtValue.Text); //ต้องการให้เก็บค่า key เป็น integer
            MessageBox.Show("Add Key : " + txtKey.Text + "and Add Value :" + txtValue.Text +" Complete");          
            txtKey.Clear();
            txtValue.Clear();
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            ICollection showSortedKey = testSortedList.Keys;
            foreach (int showKey in showSortedKey)
            {
                //MessageBox.Show(testSortedList[showKey].ToString());
                sortedListBox.Items.Add(testSortedList[showKey]); //เพิ่มข้อมูล SortedList ใน listBox
            }
            
        }
    }
}
