using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorensVanHanoi
{
    public partial class frmInterface : Form
    {
        //
        //Vars
        //
        List<Rechthoek> pilaar1 = new List<Rechthoek>();
        List<Rechthoek> pilaar2 = new List<Rechthoek>();
        List<Rechthoek> pilaar3 = new List<Rechthoek>();
        Rechthoek r1 = new Rechthoek(100);
        Rechthoek r2 = new Rechthoek(120);
        Rechthoek r3 = new Rechthoek(140);
        Rechthoek r4 = new Rechthoek(160);
        Rechthoek r5 = new Rechthoek(180);
        Rechthoek r6 = new Rechthoek(200);
        Rechthoek r7 = new Rechthoek(220);
        Rechthoek r8 = new Rechthoek(240);
        Pen potlood = new Pen(Color.Gray, 10);
        SolidBrush brush = new SolidBrush(Color.Green);
        Graphics papier;
        bool clicked = false;
        bool pilar1Selected = false;
        bool pilar2Selected = false;
        bool pilar3Selected = false;
        bool isFirstPilaar1 = false;
        bool isFisrtPilaar2 = true;
        bool isFirstPilaar3 = true;
        int Zet = 0;

        public frmInterface()
        {
            InitializeComponent();

        }
        //
        //Me3thodes
        //
        private void Laad()
        {
            papier = pbOut.CreateGraphics();
            for (int i = 1; i <= 8; i++)
            {
                if (i == 8)
                {
                    pilaar1.Add(r1);
                }
                if (i == 7)
                {
                    pilaar1.Add(r2);
                }
                if (i == 6)
                {
                    pilaar1.Add(r3);
                }
                if (i == 5)
                {
                    pilaar1.Add(r4);
                }
                if (i == 4)
                {
                    pilaar1.Add(r5);
                }
                if (i == 3)
                {
                    pilaar1.Add(r6);
                }
                if (i == 2)
                {
                    pilaar1.Add(r7);
                }
                if (i == 1)
                {
                    pilaar1.Add(r8);
                }

            }
            Point punt = new Point(60, 500);
            for (int i = 0; i <8; i++)
            {
                papier.DrawRectangle(potlood, pilaar1[i].ToRectangle(punt));
                papier.FillRectangle(brush, pilaar1[i].ToRectangle(punt));
                punt = new Point(punt.X + 10, punt.Y - 60);
            }

        }

        private void Teken()
        {
            papier = pbOut.CreateGraphics();
            papier.Clear(pbOut.BackColor);
            Point pilar1 = new Point(60, 500);
            Point pilar2 = new Point(500, 500);
            Point pilar3 = new Point(900, 500);
            for (int i = 0; i < pilaar1.Count; i++)
            {
                papier.DrawRectangle(potlood, pilaar1[i].ToRectangle(pilar1));
                papier.FillRectangle(brush, pilaar1[i].ToRectangle(pilar1));
                pilar1 = new Point(pilar1.X + 10, pilar1.Y - 60);
            }
            for (int i = 0; i < pilaar2.Count; i++)
            {
                papier.DrawRectangle(potlood, pilaar2[i].ToRectangle(pilar2));
                papier.FillRectangle(brush, pilaar2[i].ToRectangle(pilar2));
                pilar2 = new Point(pilar2.X + 10, pilar2.Y - 60);
            }
            for (int i = 0; i < pilaar3.Count; i++)
            {
                papier.DrawRectangle(potlood, pilaar3[i].ToRectangle(pilar3));
                papier.FillRectangle(brush, pilaar3[i].ToRectangle(pilar3));
                pilar3 = new Point(pilar3.X + 10, pilar3.Y - 60);
            }
        }
        private void ListVerplaats(byte pilaarnummer)
        {
            if(pilaarnummer == 1)
            {
                if (pilar2Selected)
                {
                    if(isFirstPilaar1)
                    {
                        pilaar1.Add(pilaar2.Last());
                        pilaar2.RemoveAt(pilaar2.Count - 1);
                        isFirstPilaar1 = false;
                    }
                    else
                    {
                        if (pilaar1.Last().Size.Width > pilaar2.Last().Size.Width)
                        {
                            pilaar1.Add(pilaar2.Last());
                            pilaar2.RemoveAt(pilaar2.Count - 1);
                        }
                        else MessageBox.Show("Deze zet is ongeldig");
                    }
                }
                if (pilar3Selected)
                {
                    if (isFirstPilaar1)
                    {
                        pilaar1.Add(pilaar3.Last());
                        pilaar3.RemoveAt(pilaar3.Count - 1);
                        isFirstPilaar1 = false;
                    }
                    else
                    {
                        if (pilaar1.Last().Size.Width > pilaar3.Last().Size.Width)
                        {
                            pilaar1.Add(pilaar3.Last());
                            pilaar3.RemoveAt(pilaar3.Count - 1);
                        }
                    }
                }
                if (pilar1Selected)MessageBox.Show("Deze Pilaar is al ingeklikt");
                BooleanSwitch();
            }
            if(pilaarnummer == 2)
            {
                if (pilar1Selected)
                {
                    if (isFisrtPilaar2)
                    {
                        pilaar2.Add(pilaar1.Last());
                        pilaar1.RemoveAt(pilaar1.Count - 1);
                        isFisrtPilaar2 = false;
                    }
                    else
                    {
                        if (pilaar2.Last().Size.Width > pilaar1.Last().Size.Width)
                        {
                            pilaar2.Add(pilaar1.Last());
                            pilaar1.RemoveAt(pilaar1.Count - 1);
                        }
                        else MessageBox.Show("Deze zet is ongeldig");
                    }
                }
                if (pilar3Selected)
                {
                    if (isFisrtPilaar2)
                    {
                        pilaar2.Add(pilaar3.Last());
                        pilaar3.RemoveAt(pilaar3.Count - 1);
                    }
                    else
                    {
                        if(pilaar2.Last().Size.Width > pilaar3.Last().Size.Width)
                        {
                            pilaar2.Add(pilaar3.Last());
                            pilaar3.RemoveAt(pilaar3.Count - 1);
                        }
                    }
                }               
                if (pilar2Selected) MessageBox.Show("Deze Pilaar is al ingeklikt");
                BooleanSwitch();
            }
            if(pilaarnummer == 3)
            {
                if (pilar1Selected)
                {
                    if (isFirstPilaar3)
                    {
                        pilaar3.Add(pilaar1.Last());
                        pilaar1.RemoveAt(pilaar1.Count - 1);
                        isFirstPilaar3 = false;
                    }
                    else
                    {
                        if (pilaar3.Last().Size.Width > pilaar1.Last().Size.Width)
                        {
                            pilaar3.Add(pilaar1.Last());
                            pilaar1.RemoveAt(pilaar1.Count - 1);
                        }
                        else MessageBox.Show("Deze zet is ongeldig");
                    }
                }
                if (pilar2Selected)
                {
                    if (isFirstPilaar3)
                    {
                        pilaar3.Add(pilaar2.Last());
                        pilaar2.RemoveAt(pilaar2.Count - 1);
                        isFirstPilaar3 = false;
                    }
                    else
                    {
                        if (pilaar3.Last().Size.Width > pilaar2.Last().Size.Width)
                        {
                            pilaar3.Add(pilaar2.Last());
                            pilaar2.RemoveAt(pilaar2.Count - 1);
                        }
                        else MessageBox.Show("Deze zet is ongeldig");
                    }

                }
                if (pilar3Selected) MessageBox.Show("Deze Pilaar is al ingeklikt");
                BooleanSwitch();
            }
            BooleanSwitch();
        }
        private void BooleanSwitch()
        {
            clicked = false;
            pilar1Selected = false;
            pilar2Selected = false;
            pilar3Selected = false;
            if(pilaar1.Count == 0) { isFirstPilaar1 = true; }
            if(pilaar2.Count == 0) { isFisrtPilaar2 = true; }
            if(pilaar3.Count == 0) { isFirstPilaar3 = true; }
        }

        private void Verplaats(byte pilaarnummer)
        {
            if (clicked == false)
            {
                if (pilaarnummer == 1)
                {
                    if (pilaar1.Count != 0)
                    {
                        pilar1Selected = true;
                        clicked = true;
                    }
                    else MessageBox.Show("Er valt hier niets te tillen!");

                }
                if (pilaarnummer == 2)
                {
                    if (pilaar2.Count != 0)
                    {
                        pilar2Selected = true;
                        clicked = true;
                    }
                    else MessageBox.Show("Er valt hier niets te tillen!");

                }
                if (pilaarnummer == 3)
                {
                    if (pilaar3.Count != 0)
                    {
                        pilar3Selected = true;
                        clicked = true;
                    }
                    else MessageBox.Show("Er valt hier niets te tillen!");

                }
            }
            else if (clicked)
            {

                ListVerplaats(pilaarnummer);
                Teken();
                Zet++;
                lblZetO.Text = "Aantal zetten: " + Zet.ToString();
            }
            if (pilaar2.Count == 8 || pilaar3.Count == 8)
            {
                Win();
            }
        }
        private void Win()
        {
            MessageBox.Show("Gefeliciteerd met het winnen!");
        }
        //
        //Events
        //
        private void button1_Click(object sender, EventArgs e)
        {
            Laad();
            btnPilaar1.Enabled = true;
            btnPillaar2.Enabled = true;
            btnPilaar3.Enabled = true;
            btnStart.Enabled = false;
        }

        private void btnPilaar1_Click(object sender, EventArgs e)
        {
            Verplaats(1);
        }

        private void btnPillaar2_Click(object sender, EventArgs e)
        {
            Verplaats(2);
        }

        private void btnPilaar3_Click(object sender, EventArgs e)
        {
            Verplaats(3);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public class Rechthoek
    {

        //
        //Constructors
        //

        public Rechthoek()
        {
            Size = new Size(20, 10);
            _kleur = Color.Green;

        }

        public Rechthoek(int grootte)
        {
            Size = new Size(grootte, 50);
            _kleur = Color.Green;
        }

        //
        //Methodes
        //
        public Rectangle ToRectangle(Point location)
        {
            Rectangle rect = new Rectangle(location, Size);

            return rect;
        }


        //
        //Prive Vars
        //
        Color _kleur;

        //
        //Get-Setters
        //
        public Color Kleur { get { return _kleur; } }
        public Size Size { get; set; }
    }

}
