using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SimulationOfEvolution2
{
    public partial class Form1 : Form
    {
        public const int WIDTHCELL = 10; // Ширина клетки
        public const int HIGHTCELL = 10; // Высота клетки

        public bool Time = false;

        Bitmap BitMap;
        Graphics G;

        World World;

        public Form1()
        {
            InitializeComponent();
        }

        public void Print()
        {
            BitMap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            G = Graphics.FromImage(BitMap);

            World.Print(G);

            pictureBox1.Image = BitMap;
            GC.Collect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            World = new World(pictureBox1.Width/ WIDTHCELL, pictureBox1.Height/ HIGHTCELL);
            Print();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) Time = !Time;

            GraphicTimer.Enabled = Time;
            LogicTimer.Enabled = Time;

            if (Time) label1.Text = "Симуляция: В процессе";
            else label1.Text = "Симуляция: Пауза";
        }

        private void GraphicTimer_Tick(object sender, EventArgs e)
        {
            Print();
        }
    }
}
