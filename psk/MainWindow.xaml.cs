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

namespace psk
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<MyDataType> txtList = new List<MyDataType>();
        List<MyDataType> txtList2 = new List<MyDataType>();
        bool q = false;
        int count =99999999;
        int count1 = 0;
        public class MyDataType
        {
            public char name;
            public int count;
        }
    
        public MainWindow()
        {
            InitializeComponent();
            txtList.Add(new MyDataType() { name = ' ', count = 1 });
        }
   
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            char nam = ' ';
            foreach (var item in text.Text)
            {
                q = false;
                foreach(var itm in txtList)
                {
                    if(itm.name == item)
                    {
                        q = true;
                        nam = itm.name;
                      
                    }
                    else if(itm.name != item && q == false)
                    {
                        q = false;
                       
                    }
                }
                if(q == true)
                {
                    txtList.Find(t => t.name == nam).count++;
                }
                else
                {
                    txtList.Add(new MyDataType() { name = item, count = 1 });
                }
            }
            foreach (var item in sl.Text)
            {
                q = false;
                foreach (var itm in txtList2)
                {
                    if (itm.name == item)
                    {
                        q = true;
                        nam = itm.name;

                    }
                    else if (itm.name != item && q == false)
                    {
                        q = false;

                    }
                }
                if (q == true)
                {
                    txtList2.Find(t => t.name == nam).count++;
                }
                else
                {
                    txtList2.Add(new MyDataType() { name = item, count = 1 });
                }
            }

            foreach(var itm2 in txtList2)
            {
                foreach(var itm in txtList)
                {
                    if (itm.name == itm2.name)
                    {
                        count1 = itm.count / itm2.count;
                        if (count1 < count) { count = count1; }

                    }
                    else if (itm.name != itm2.name && q == false)
                    {
   

                    }
                }
            }
            MessageBox.Show(count.ToString());
            }
        

            //text.Text = "";
            //foreach(var itm in txtList)
            //{
            //    text.Text += itm.name + " " + itm.count + "\n";
            //}
        }
    }

