using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectOne
{
    public class ProjectClass
    {

        int Bullet = 0;
        int Chances = 2;
        private object score_Text;
        private string score;

        public void ShootHead()
        {
            //If the projectile is in the barrel, shoot it at head
            if (Bullet == 5)
            {
                MessageBox.Show("No Longer Have!");
            }
            else
            {
                MessageBox.Show(" The Gun Is Rotated");
                Bullet = Bullet + 1;
            }


        }
        public void ShootAway()
        {
            //if I have chances
            if (Chances > 0)
            {
                if (Bullet == 5)
                {
                    MessageBox.Show("You are Sucessfull");
                }
                else
                {
                    //If you are not shooting, the gun hang
                    MessageBox.Show("The Gun Is Rotated");
                    Bullet = Bullet + 1;
                }
            }
        }
        public void ReFill()
        {
            Random rand = new Random();
            Bullet = rand.Next(0, 5);
            MessageBox.Show("Weapon Spining");

        }

        public void Spin()
        {

            Random rand = new Random();
            Bullet = rand.Next(0, 5);
            MessageBox.Show("Weapon Spinning");
        }


        public void Marks()
        {
            Bullet = 0;
            MessageBox.Show("Your bullet empty reload reload....! ");

        }

    }
}


    
