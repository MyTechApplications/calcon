using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mycalc
{
    public partial class Pythagorean_Triples_Calculator : Form
    {
       
        public Pythagorean_Triples_Calculator()
        {
            
            InitializeComponent();
        }
        //C# CODE FOR PYTHAGOREAN THEOREM CALCULATOR CALCON
        //CalCon Version Triangulum 1.0.0
        //Build 1907
        //TOTAL LINES OF CODE - 470
        //YOU CAN CONTRIBUTE TO THIS CODE
        //Last build compiled on 19-07-21
        //PYTHAGOREAN THEOREM Calculator - Internal Version 1.0.1907.0
        private void Pythagorean_Triples_Calculator_Load(object sender, EventArgs e)
        {
            comboBox2.SelectedItem = "Hypotenuse 'C'";
            comboBox1.SelectedItem = "Pythagorean Theorem";
            combo1();
            combo2();
            pnlsolvefora.Visible = false;
            button4.Visible = false;
            Menuicon.Visible = true;
            treeView2.Visible = false;

        }
        //Solve for Hypotenuse
        private void HypotenuseCalc()
        {
           
            var a = Double.Parse(sidea.Text);
            var b = Double.Parse(sideb.Text);
            var asq = a * a;
            var bsq = b * b;
            var csq = asq + bsq;
            solution.Text = "Hypotenuse 'C' = " + Convert.ToString(Math.Sqrt(csq));
        }
        //Solve for Side A
        private void Sideacalc()
        {
            var c = Double.Parse(textBox2.Text);
            var b = Double.Parse(textBox1.Text);
            var csq = c * c;
            var bsq = b * b;
            var asq = csq - bsq;
            label7.Text = "Side 'A' = " + Convert.ToString(Math.Sqrt(asq));
        }
        //Solve for Side B
        private void Sidebcalc()
        {
            Standard frm = new Standard();
            
            var c = Double.Parse(textBox4.Text);
            var b = Double.Parse(textBox3.Text);
            var csq = c * c;
            var bsq = b * b;
            var asq = csq - bsq;
            label9.Text = "Side 'B' = " + Convert.ToString(Math.Sqrt(asq));
        }
        //Solve for Pythagorean Triplet
        private void PythagoreanTriplet()
        {
            var a1 = Double.Parse(a.Text);
            var b1 = Double.Parse(b.Text);
            var c1 = Double.Parse(c.Text);
            var a2 = a1 * a1;
            var b2 = b1 * b1;
            var c2 = c1 * c1;

            if(a2 + b2 == c2)
            {
                label14.Text = "Yes, it is a pythagorean triplet";
            }
            else
            {
                label14.Text = "No, it is not a pythagorean triplet";
            }

        }
        private void calculatehypotenuse_Click(object sender, EventArgs e)
        {
            HypotenuseCalc();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo2();
        }
        private void combo1()
        {
             if(comboBox1.SelectedItem == "Pythagorean Theorem")
            {
                pnlpythagoreantheorem.Visible = true;
                pnlpythagoreantriples.Visible = false;
            }
            else if(comboBox1.SelectedItem == "Pythagorean Triples")
            {
                pnlpythagoreantheorem.Visible = false;
                pnlpythagoreantriples.Visible = true;

            }
        }
        private void combo2()
        {
            if (comboBox2.SelectedItem == "Hypotenuse 'C'")
            {
                pnlsolveforb.Visible = false;
                pnlsolvefora.Visible = false;
                pnlsolveforc.Visible = true;
            }
            else if (comboBox2.SelectedItem == "Side 'A'")
            {
                pnlsolveforb.Visible = false;
                pnlsolveforc.Visible = false;
                pnlsolvefora.Visible = true;
            }
            else if (comboBox2.SelectedItem == "Side 'B'")
            {
                pnlsolvefora.Visible = false;
                pnlsolveforc.Visible = false;
                pnlsolveforb.Visible = true;
            }
        }
        private void OpenMenu()
        {
            button4.Visible = true;
            Menuicon.Visible = false;
            Util.Animate(treeView2, Util.Effect.Slide, 150, 0);
        }
        private void CloseMenu()
        {
            button4.Visible = false;
            Menuicon.Visible = true;
            Util.Animate(treeView2, Util.Effect.Slide, 150, 0);
        }
        private void calculatesidea_Click(object sender, EventArgs e)
        {
            Sideacalc();
        }

        private void calculatesideb_Click(object sender, EventArgs e)
        {
            Sidebcalc();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PythagoreanTriplet();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CloseMenu();
        }

        private void Menuicon_Click(object sender, EventArgs e)
        {
            OpenMenu();
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView2.SelectedNode.Text == "Standard Calculator")
            {
                this.Hide();
                Standard frm = new Standard();
                frm.Show();
            }
            else if (treeView2.SelectedNode.Text == "Age Calculator")
            {
                this.Hide();
                AgeCalc frm = new AgeCalc();
                frm.Show();
            }
            else if (treeView2.SelectedNode.Text == "About")
            {

                About frm = new About();
                frm.Show();
            }
            else if (treeView2.SelectedNode.Text == "Percentage Calculator")
            {
                this.Hide();
                percentageof frm = new percentageof();
                frm.Show();
            }
            else if (treeView2.SelectedNode.Text == "More Calculators ")
            {
                this.Hide();
                More_Calculators frm = new More_Calculators();
                frm.Show();
            }
            else if (treeView2.SelectedNode.Text == "Help")
            {
                this.Hide();
                Helpassistant frm = new Helpassistant();
                frm.Show();
            }
            else if (treeView2.SelectedNode.Text == "Area ")
            {

                Area_Converter frm = new Area_Converter();
                frm.Show();
            }
            else if (treeView2.SelectedNode.Text == "Speed Calculator")
            {
                this.Hide();
                Form1 frm = new Form1();
                frm.Show();
            }
            else if (treeView2.SelectedNode.Text == "Length ")
            {
                this.Hide();
                Length frm = new Length();
                frm.Show();
            }
            else if (treeView2.SelectedNode.Text == "Volume")
            {
                this.Hide();
                Volume frm = new Volume();
                frm.Show();
            }
            else if (treeView2.SelectedNode.Text == "Temperature ")
            {
                this.Hide();
                Form2 frm = new Form2();
                frm.Show();
            }
            else if (treeView2.SelectedNode.Text == "Time ")
            {
                this.Hide();
                Time frm = new Time();
                frm.Show();
            }
            else if (treeView2.SelectedNode.Text == "Data ")
            {
                this.Hide();
                Data frm = new Data();
                frm.Show();
            }
            else if (treeView2.SelectedNode.Text == "Power")
            {
                this.Hide();
                Power frm = new Power();
                frm.Show();
            }
            else if (treeView2.SelectedNode.Text == "Mass ")
            {
                this.Hide();
                Weight frm = new Weight();
                frm.Show();
            }
        }

        private void b_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pythagorean_Triples_Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M)
            {
                if (treeView2.Visible == true)
                {
                    CloseMenu();
                }
                else
                {
                    OpenMenu();
                }
            }

            else if (e.Control && e.KeyCode == Keys.O)
            {
                Open frm = new Open();
                frm.Show();
            }

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)

        {

            KeyEventArgs e = new KeyEventArgs(keyData);

            if (e.Control && e.KeyCode == Keys.M)
            {

                if (treeView2.Visible == true)
                {
                    button4.Visible = false;
                    Menuicon.Visible = true;
                    Util.Animate(treeView2, Util.Effect.Slide, 150, 0);
                }
                else
                {
                    button4.Visible = true;
                    Menuicon.Visible = false;
                    Util.Animate(treeView2, Util.Effect.Slide, 150, 0);
                }
            }

            else if (e.Control && e.KeyCode == Keys.O)
            {
                Open frm = new Open();
                frm.Show();
            }
            else if (e.Shift && e.Control && e.KeyCode == Keys.E)
            {
                Close();
            }
            else if (e.Control && e.KeyCode == Keys.OemQuestion)
            {
                Helpassistant frm = new Helpassistant();
                frm.Show();
            }
            else if (e.Shift && e.Control && e.KeyCode == Keys.A)
            {
                About frm = new About();
                frm.Show();
            }

            return base.ProcessCmdKey(ref msg, keyData);

        }
        private void a_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                  (e.KeyChar != '.')
                  )
            {
                e.Handled = true;
            }
            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void b_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                  (e.KeyChar != '.')
                  )
            {
                e.Handled = true;
            }
            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void c_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                  (e.KeyChar != '.')
                  )
            {
                e.Handled = true;
            }
            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void sidea_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                  (e.KeyChar != '.')
                  )
            {
                e.Handled = true;
            }
            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void sideb_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                  (e.KeyChar != '.')
                  )
            {
                e.Handled = true;
            }
            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                  (e.KeyChar != '.')
                  )
            {
                e.Handled = true;
            }
            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                  (e.KeyChar != '.')
                  )
            {
                e.Handled = true;
            }
            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                  (e.KeyChar != '.')
                  )
            {
                e.Handled = true;
            }
            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                  (e.KeyChar != '.')
                  )
            {
                e.Handled = true;
            }
            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.M)
            {
                if (treeView2.Visible == true)
                {
                    CloseMenu();
                }
                else
                {
                    OpenMenu();
                }
            }
        }
    }
}
