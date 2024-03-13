using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {

        double result = 0;
        string operation = string.Empty;

        bool drag = false;
        Point startPoint = new Point(0,0);

        public Calculator()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e) { Close(); }

        private void ceBtn_Click(object sender, EventArgs e)
        {
            result = 0;
            TxtDisplay.Text = string.Empty;
        }

        private void BtnOperation_Click(object sender, EventArgs e)
        {
            //Jeśli użytkownik jeszcze nie wpisał żadnej wartości to musimy cofnąć operację
            if (TxtDisplay.Text.Length == 0) return;

            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(TxtDisplay.Text);
            TxtDisplay.Text = "";

        }

        private void equalsBtn_Click(object sender, EventArgs e)
        {
            //Jeśli użytkownik jeszcze nie wpisał żadnej wartości to musimy cofnąć operację
            if (TxtDisplay.Text.Length == 0) return;

            switch (operation) 
            {
                case "+":
                    {
                        result += double.Parse(TxtDisplay.Text);
                        TxtDisplay.Text = result.ToString();
                        return;
                    }
                case "-":
                    {
                        result -= double.Parse(TxtDisplay.Text);
                        TxtDisplay.Text = result.ToString();
                        return;
                    }
                case "x":
                    {
                        result *= double.Parse(TxtDisplay.Text);
                        TxtDisplay.Text = result.ToString();
                        return;
                    }
                case "/":
                    {
                        //Sprawdzamy czy to nie jest przypadkiem dzielenie na 0
                        if (TxtDisplay.Text == "0")
                        {
                            MessageBox.Show("You can not divide by 0", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        result /= double.Parse(TxtDisplay.Text);
                        TxtDisplay.Text = result.ToString();
                        return;
                    }
            }
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(TxtDisplay.Text))
            {
                //Jeśli to jest liczba ujemna od -1 do -9, to po usuwamy znak minus razem z liczbą
                if (TxtDisplay.Text.Contains("-") && TxtDisplay.Text.Length == 2)
                {
                    TxtDisplay.Text = string.Empty;
                    return;
                }
                TxtDisplay.Text = TxtDisplay.Text.Remove(TxtDisplay.Text.Length -1);
            }
        }

        private void BtnNum_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //Problem z przecinkiem
            if (button.Text == "," && string.IsNullOrEmpty(TxtDisplay.Text)) return;
            if (button.Text == "," && TxtDisplay.Text.Contains(",")) return;

            //Jesli display zawiera tylko 0, to nadpisujemy wartość
            if (TxtDisplay.Text == "0" && button.Text != ",")
            {
                TxtDisplay.Text = button.Text;
                return;
            }
            TxtDisplay.Text += button.Text;
        }

        private void hide_Click(object sender, EventArgs e) { WindowState = FormWindowState.Minimized; }

        private void PnlUp_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void PnlUp_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startPoint.X, p.Y-startPoint.Y);
            }
        }

        private void PnlUp_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}
