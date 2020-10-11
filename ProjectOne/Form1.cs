using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectOne
{
    public partial class Form1 : Form
    {
        ProjectClass PClass = new ProjectClass();

        public object Score_Text { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void ShootHead_Click(object sender, EventArgs e)
        {
            PClass.ShootHead();
            //I am excited to play this game
            SoundPlayer sound = new SoundPlayer(ProjectOne.Properties.Resources.GunFire);
            sound.Play();
        }

        private void ShootAway_Click(object sender, EventArgs e)
        {
            PClass.ShootAway();
            //I am excited to play this game
            SoundPlayer sound = new SoundPlayer(ProjectOne.Properties.Resources.LifeSave);
            sound.Play();
        }

        private void Quit_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Do you really want to quit this game?",
                "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {

            }
        }

        private void Spin_Click(object sender, EventArgs e)
        {
            PClass.Spin();
        }


        private void ReLoad_Click(object sender, EventArgs e)
        {
            PClass.Marks();
        }

        private void Score_Click(object sender, EventArgs e)
        {
            PClass.Marks();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Marks_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("you are sucessful in the game or Not?",
                "win", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                _ = MessageBox.Show("congralutation! YOU gain 10 points");
            }
            else if (dialog == DialogResult.No)
            {
                MessageBox.Show("oops! YOU lost your lucky chance");
            }
        }
        }
    }

