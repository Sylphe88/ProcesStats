using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace ProcessInformation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<ProcessDisplay> pDisplay { get; set; }
        public string ProcCount { get; set; }
        
        public MainWindow()
        {
            pDisplay = new List<ProcessDisplay>();
            Process[] ProcList = Process.GetProcesses();
            foreach(Process p in ProcList)
            {
                try
                {
                    if(p.Id != 0) //Idle Process
                    {
                        pDisplay.Add(new ProcessDisplay(p.ProcessName, p.Id, p.StartTime));
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                   
            }
            ProcCount = String.Format("{0} processes", pDisplay.Count);
            pDisplay.Sort();
            //DataContext = this; //To estalish binding - already done in XAML
            InitializeComponent();
        }
    }
}
