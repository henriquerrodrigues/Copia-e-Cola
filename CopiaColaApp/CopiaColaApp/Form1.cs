using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CopiaColaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Obtém o tamanho da tela principal
            var screen = Screen.PrimaryScreen.WorkingArea;

            // Posiciona o formulário no canto inferior direito
            this.Location = new Point(
                screen.Right - this.Width,
                screen.Bottom - this.Height
                );
        }

        private void CopiarTexto_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                Clipboard.SetText(btn.Text);
                ToolTip tip = new ToolTip();
                tip.Show("Copiado!", btn, 0, -20, 1000);
                btn.BackColor = Color.LightGreen;
                btn.BackColor = SystemColors.Control;
            }
        }


    }
}
