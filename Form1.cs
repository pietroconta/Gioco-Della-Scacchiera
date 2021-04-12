using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scacchieragioco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int rr = 0, cc = 0;
        int rrr = 0, ccc = 0;
        int pntut = 0, pntpc = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            tab_s.Rows[0].Cells[0].Selected = false; //tolgo l'evidenziatura di defualt
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn_turnosucc.Visible = true;
            btn_inizia.Visible = false;
            tab_s.RowCount = 6;
            tab_s.ColumnCount = 6;

            for (int r = 0; r < 6; r++)
            {

                for (int c = 0; c < 6; c++) //ridimensiono le celle
                {
                    tab_s.Rows[r].Height = 35;
                    tab_s.Columns[c].Width = 35;

                }
            }

            for (int r = 0; r < 6; r++)
            {

                for (int c = 0; c < 6; c++)
                {

                    if (r % 2 == 0) 
                    {
                        if (c % 2 == 0) //vadoa a fare la scacchiera
                            tab_s.Rows[r].Cells[c].Style.BackColor = Color.Black;
                        else
                            tab_s.Rows[r].Cells[c].Style.BackColor = Color.White;
                    }

                    else 
                    {

                        if (c % 2 != 0)
                            tab_s.Rows[r].Cells[c].Style.BackColor = Color.Black;
                        else
                            tab_s.Rows[r].Cells[c].Style.BackColor = Color.White;
                    }

                }
            }
        }
        private void puliscitab()
        {

            for (int r = 0; r < 6; r++)
            {

                for (int c = 0; c < 6; c++)
                { //pulisco la tab


                    tab_s.Rows[r].Cells[c].Value = "";

                }

            }

        }
        private void btn_turnosucc_Click(object sender, EventArgs e)
        {
            puliscitab();

            rr = rnd.Next(0, 6);
            cc = rnd.Next(0, 6);

            if (tab_s.Rows[rr].Cells[cc].Style.BackColor == Color.White) //se la X é presente in una cella nera la X é bianca
                tab_s.Rows[rr].Cells[cc].Style.ForeColor = Color.Black;
            else
                tab_s.Rows[rr].Cells[cc].Style.ForeColor = Color.White; //viceversa l:98

            tab_s.Rows[rr].Cells[cc].Value = "X";


            do
            {
                rrr = rnd.Next(0, 6);
                ccc = rnd.Next(0, 6);
            }
            while (rrr == rr && ccc == cc);

            if (tab_s.Rows[rrr].Cells[ccc].Style.BackColor == Color.White)
                tab_s.Rows[rrr].Cells[ccc].Style.ForeColor = Color.Black;
            else
                tab_s.Rows[rrr].Cells[ccc].Style.ForeColor = Color.White;
            tab_s.Rows[rrr].Cells[ccc].Value = "X";

            assegnpnt();
        }

        private void assegnpnt()
        { //assegno i punti a utente e pc

            if (tab_s.Rows[rr].Cells[cc].Style.BackColor == tab_s.Rows[rrr].Cells[ccc].Style.BackColor)
                pntut += 1;

            else
                pntpc += 1;

            lbl_gioc.Text = "Punti Giocatore: " + pntut;
            lbl_pc.Text = "Punti Pc: " + pntpc;

            //controllo se ha vinto l'utente 
            if (pntut == 5)
            {

                MessageBox.Show("Ha vinto l'utente :)");               
                btn_inizia.Visible = true;
                btn_turnosucc.Visible = false;
                puliscitab();

                pntut = 0;
                pntpc = 0;

                lbl_gioc.Text = "Punti Giocatore:";
                lbl_pc.Text = "Punti Pc:";
                for (int r = 0; r < 6; r++)
                {

                    for (int c = 0; c < 6; c++)
                    {


                        tab_s.Rows[r].Cells[c].Style.BackColor = Color.White;

                    }

                }

            }
            // controllo se ha vinto il pc 
            else if (pntpc == 5)
            {

                MessageBox.Show("Ha vinto il pc :(");              
                btn_inizia.Visible = true;
                btn_turnosucc.Visible = false;
                puliscitab();

                pntut = 0;
                pntpc = 0;

                lbl_gioc.Text = "Punti Giocatore:";
                lbl_pc.Text = "Punti Pc:";
                for (int r = 0; r < 6; r++)
                {

                    for (int c = 0; c < 6; c++)
                    {


                        tab_s.Rows[r].Cells[c].Style.BackColor = Color.White;

                    }

                }


            }


        }

       
    }
   
    
}
