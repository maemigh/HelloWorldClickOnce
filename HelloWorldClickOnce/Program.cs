using System;
using System.Windows.Forms;

namespace HelloWorldClickOnce
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

    public class MainForm : Form
    {
        public MainForm()
        {
            this.Text = "Hello World ClickOnce App";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = 300;
            this.Height = 200;

            Label helloLabel = new Label();
            helloLabel.Text = "Hello, World!";
            helloLabel.AutoSize = true;
            helloLabel.Location = new System.Drawing.Point(100, 80);

            this.Controls.Add(helloLabel);
        }
    }
}