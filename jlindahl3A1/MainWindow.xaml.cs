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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace jlindahl3A1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox0.Text = Ex3aLoops.Calc0(inputTextBox0A.Text, inputTextBox0B.Text, inputTextBox0C.Text);
            resultTextBox1.Text = Ex3aLoops.Calc1(inputTextBox1A.Text, inputTextBox1B.Text, inputTextBox1C.Text);
            resultTextBox2.Text = Ex3aLoops.Calc2(inputTextBox2A.Text, inputTextBox2B.Text, inputTextBox2C.Text);
            resultTextBox3.Text = Ex3aLoops.Calc3(inputTextBox3A.Text, inputTextBox3B.Text, inputTextBox3C.Text);
            resultTextBox4.Text = Ex3aLoops.Calc4(inputTextBox4A.Text, inputTextBox4B.Text, inputTextBox4C.Text);
            resultTextBox5.Text = Ex3aLoops.Calc5(inputTextBox5A.Text, inputTextBox5B.Text, inputTextBox5C.Text);
            resultTextBox6.Text = Ex3aLoops.Calc6(inputTextBox6A.Text, inputTextBox6B.Text);
            resultTextBox7.Text = Ex3aLoops.Calc7(inputTextBox7A.Text, inputTextBox7B.Text);
            resultTextBox8.Text = Ex3aLoops.Calc8(inputTextBox8A.Text, inputTextBox8B.Text);
        }
    }
}
