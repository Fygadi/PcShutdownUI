using System.Diagnostics;

namespace PcShutdownUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitialiseShutdownButton_MouseClick(object sender, MouseEventArgs e)
        {
            int time = (int.Parse(MinutesTextBox.Text) * 60);
            var psi = new ProcessStartInfo("shutdown", $"/s /t {time}");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }

        private void AbbordShutdownButton_MouseClick(object sender, MouseEventArgs e)
        {
            var psi = new ProcessStartInfo("shutdown", "-a");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }

        private void MinutesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}