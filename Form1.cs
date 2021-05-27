using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HAP
{
    public partial class MainForm : Form
    {
        //Фориула находится в методе HAP, все остальное готово
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (
            nameBox.Text == "" ||
            otchBox.Text == "" ||
            surBox.Text == "" ||
            ageBox.Text == "" ||
            genBox.SelectedIndex == -1 ||
            bilBox.Text == "" ||
            creatineBox.Text == "" ||
            lpBox.Text == "" ||
            kdrlgBox.Text == "" ||
            fvBox.Text == "" ||
            ttgBox.Text == "" ||
            ishemiaBox.SelectedIndex == -1 ||
            depresBox.SelectedIndex == -1 ||
            aldesteronBox.Text == ""
            )
            {
                MessageBox.Show("Пустые обязательные поля!");
            }
            else
            {

                if (
           checkDouble(ageBox.Text, "Возраст") ||       
           checkDouble(bilBox.Text, "Билирубин") ||          
           checkDouble(creatineBox.Text, "Креатин") ||
           checkDouble(lpBox.Text, "ЛП") ||
           checkDouble(kdrlgBox.Text, "КДРЛЖ") ||        
           checkDouble(fvBox.Text, "ФВ") ||
           checkDouble(ttgBox.Text, "ТТГ") ||         
           checkDouble(aldesteronBox.Text, "Альдостерон"))
                {
                    Сalculation(depresBox.SelectedIndex, Double.Parse(creatineBox.Text), Double.Parse(kdrlgBox.Text),
                        ishemiaBox.SelectedIndex, Double.Parse(lpBox.Text), Double.Parse(fvBox.Text),
                        Double.Parse(aldesteronBox.Text), Double.Parse(ttgBox.Text), Double.Parse(bilBox.Text));
                }
            }

        }

        public bool checkDouble(string str, string message)
        {
            double num;
            if (!Double.TryParse(str, out num))
            {
                MessageBox.Show("В поле " + message + " некорректное значение");
                return false;
            }
            else
                return true;
        }


        public void Сalculation(int depresion, double creatine, double kdrlg, int ishemia, double lp, double fv,
            double aldesteron, double ttg, double bilirubin)
        {
            //Депрессия
            double X1o; //Основная
            double X1k; //Контрольная
            //Креатин
            double X2o;
            double X2k;
            //КДР ЛЖ
            double X3o;
            double X3k;
            //Ишемия
            double X4o;
            double X4k;
            //Размер ЛП
            double X5o;
            double X5k;
            //ФВ ЛЖ
            double X6o;
            double X6k;
            //Альдестерон
            double X7o;
            double X7k;
            //ТТГ
            double X8o;
            double X8k;
            //Билирубин
            double X9o;
            double X9k;

            if (depresion == 1)
            {
                X1o = 0.003;
                X1k = 0.071;
            }
            else
            {
                X1o = 0.051;
                X1k = 0.928;
            }

            if(creatine <= 0.11)
            {
                X2o = 0.888;
                X2k = 0.928;
            }
            else if (creatine <= 0.139)
            {
                X2o = 0.055;
                X2k = 0.042;
            }
            else
            {
                X2o = 0.055;
                X2k = 0.028;
            }

            if(kdrlg <= 4.9)
            {
                X3o = 0.444;
                X3k = 0.714;
            }
            else if(kdrlg <= 5.9)
            {
                X3o = 0.388;
                X3k = 0.257;
            }
            else
            {
                X3o = 0.166;
                X3k = 0.028;
            }

            if(ishemia == 1)
            {
                X4o = 0.944;
                X4k = 0.828;
            }
            else
            {
                X4o = 0.055;
                X4k = 0.171;
            }

            if(lp <= 3.7)
            {
                X5o = 0.277;
                X5k = 0.571;
            }
            else if(lp <= 4.1)
            {
                X5o = 0.277;
                X5k = 0.171;
            }
            else
            {
                X5o = 0.444;
                X5k = 0.257;
            }    


            if(fv <= 44)
            {
                X6o = 0.277;
                X6k = 0.1;
            }
            else if (fv  <= 54)
            {
                X6o = 0.222;
                X6k = 0.242;
            }
            else
            {
                X6o = 0.5;
                X6k = 0.657;
            }

            if(aldesteron <= 100)
            {
                X7o = 0.184;
                X7k = 0.266;
            }
            else if(aldesteron <= 200)
            {
                X7o = 0.276;
                X7k = 0.133;
            }
            else if(aldesteron <= 300)
            {
                X7o = 0.171;
                X7k = 0.333;
            }
            else
            {
                X7o = 0.236;
                X7k = 0.266;
            }

            if(ttg <= 1.0)
            {
                X8o = 0.277;
                X8k = 0.571;
            }
            else if(ttg <= 4)
            {
                X8o = 0.277;
                X8k = 0.171;
            }
            else
            {
                X8o = 0.444;
                X8k = 0.257;
            }


            if(bilirubin <= 11.9)
            {
                X9o = 0.833;
                X9k = 0.614;
            }
            else if(bilirubin <= 17)
            {
                X9o = 0.111;
                X9k = 0.328;
            }
            else
            {
                X9o = 0.055;
                X9k = 0.057;
            }

            decimal osn = Convert.ToDecimal(0.205 * X1o * X2o * X3o * X4o * X5o * X6o * X7o * X8o * X9o);
            decimal contrl = Convert.ToDecimal(0.795*X1k * X2k * X3k * X4k * X5k * X6k * X7k * X8k * X9k);
            decimal hap = osn / (osn+contrl);

            MessageBox.Show("Вероятность инфаркта = " + hap);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void aldesteronBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void depresBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
