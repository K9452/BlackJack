using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        public Deck currentdeck { get; set; }
        public Hand player_hand { get; set; }
        public Hand dealer_hand { get; set; }
        public int numcards { get; set; }
        public Form1()
        {
            InitializeComponent();

            button1.Visible = true; // jako button on näkyvä
            button2.Visible = false; // löynti buttoni on piilotettu
            button3.Visible = false; // jää buttoni on piilotettu
            pictureBox1.Visible = true; // näyttää ensimmäisen kortin paikann
            PictureBox2.Visible = false; // näytetään toinen kortti
            pictureBox3.visible = false; // piilotetaan loput
            pictureBox4.visible = false; // piilotetaan loput
            pictureBox5.visible = false; // piilotetaan loput
            pictureBox6.visible = false; // piilotetaan loput
            pictureBox7.visible = false; // piilotetaan loput
            pictureBox8.visible = false; // piilotetaan loput
            pictureBox9.visible = false; // piilotetaan loput
            pictureBox10.visible = false; // piilotetaan loput
            pictureBox11.visible = false; // piilotetaan loput
            pictureBox12.visible = false; // piilotetaan loput


        }

       
    }
}
