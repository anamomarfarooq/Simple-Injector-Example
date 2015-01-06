using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleInjector;


namespace SimpleInjectorExample
{
    public interface IDisplay
    {
        void Display(string _text);
    }

    public class DisplayText : IDisplay
    {
        public void Display(string text)
        {
            MessageBox.Show("Text is: " + text);
        }
    }
    public partial class Form1 : Form
    {
        private readonly IDisplay _display;

        public Form1(IDisplay display)
        {
            _display = display;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _display.Display(DisplayBox.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
