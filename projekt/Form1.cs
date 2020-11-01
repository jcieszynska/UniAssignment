using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        } 

        int speed = 15;
        int pionowo = 1, poziomo = 1;
        
        private void poziom_Tick(object sender, EventArgs e)
        {
            if (pilka.Left < 10) 
                poziomo++; 
            else if ( pilka.Left > this.Width-pilka.Width-25) 
                poziomo--; 

            pilka.Left += (poziomo * speed);
        }
        bool _lewo = false, _prawo = false;
        private void tmrDeska_Tick(object sender, EventArgs e)
        {
            if (_prawo && deska.Left < (this.Width - deska.Width))
                deska.Left += 25; 
            else if ( _lewo && deska.Left > 0)
                deska.Left -= 25; 

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode==Keys.Left)
                _lewo = true;
            else if (e.KeyCode==Keys.Right)
                _prawo = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Left || e.KeyCode==Keys.Right)
                _lewo = _prawo = false;
        }

        private void pion_Tick(object sender, EventArgs e)
        {          
            if(pilka.Top < 10 )
                pionowo++; 
            else if (pilka.Top > this.Height - pilka.Height - deska.Height - 35)
            {
                if (pilka.Left<(deska.Left) || (pilka.Left + pilka.Width)>(deska.Left + deska.Width+5))
                {
                    pion.Enabled = poziom.Enabled = false;
                    MessageBox.Show("KONIEC GRY");
                }

                pionowo--;
            }
            pilka.Top += (pionowo * speed);

            int _wynik = 0;
            foreach (Control x in this.Controls)
                if (x is PictureBox && x.Tag == "block")
                {
                    if (pilka.Bounds.IntersectsWith(x.Bounds))
                    {

                        this.Controls.Remove(x);
                        pionowo = -pionowo;
                    }
                    _wynik++;
                    wynik.Text = Convert.ToString(_wynik);
                }
        }
    }
}
