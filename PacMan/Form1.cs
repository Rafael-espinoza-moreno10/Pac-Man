using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacMan
{
    public partial class F_Menu : Form
    {
        public F_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void F_Menu_Load(object sender, EventArgs e)
        {
            pb_gif.Image = Image.FromFile(@"C:\Users\Usuario\OneDrive\Escritorio\Juegos\PacMan\PacMan\Assets\Start_Menu.gif"); // se carga la animacion del gif del menu de incio.
            pb_gif.SizeMode = PictureBoxSizeMode.StretchImage;

        }
    }
}
