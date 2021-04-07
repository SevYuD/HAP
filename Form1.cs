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
            povtIMBox.SelectedIndex == -1 ||
            sdBox.SelectedIndex == -1 ||
            imtBox.Text == "" ||
            smockBox.SelectedIndex == -1 ||
            hbBox.Text == "" ||
            leyBox.Text == "" ||
            glukBox.Text == "" ||
            soeBox.Text == "" ||
            protBox.Text == "" ||
            bilBox.Text == "" ||
            asatBox.Text == "" ||
            creatineBox.Text == "" ||
            lpnvBox.Text == "" ||
            lpBox.Text == "" ||
            triglizBox.Text == "" ||
            atBox.Text == "" ||
            skfBox.Text == "" ||
            kcpBox.Text == "" ||
            nt18.Text == "" ||
            kdrlgBox.Text == "" ||
            tmpgBox.Text == "" ||
            tzslgBox.Text == "" ||
            fvBox.Text == "" ||
            ttgBox.Text == "" ||
            ishemiaBox.SelectedIndex == -1 ||
            stHCNBox.SelectedIndex == -1 ||
            fkchnBox.SelectedIndex == -1 ||
            depresBox.SelectedIndex == -1 ||
            t4Box.Text == "" ||
            alphaBox.Text == "" ||
            hcObchBox.Text == "" ||
            il1Box.Text == "" ||
            il8Box.Text == "" ||
            il4Box.Text == "" ||
            il6Box.Text == "" ||
            gamaBox.Text == "" ||
            fnoBox.Text == "" ||
            aldesteronBox.Text == "" ||
            leptinBox.Text == "" ||
            adiponektinBox.Text == "" ||
            alatBox.Text == "" ||
            lpvpBox.Text == "" ||
            kdrpgBox.Text == ""
            )
            {
                MessageBox.Show("Пустые поля!");
            }

            if (checkDouble(nameBox.Text, "Имя") ||
       checkDouble(otchBox.Text, "Отчество") ||
       checkDouble(surBox.Text, "Фамилия")||
       checkDouble(ageBox.Text, "Возраст") ||
       checkDouble(imtBox.Text, "ИМТ") ||
       checkDouble(hbBox.Text, "Hb") ||
       checkDouble(leyBox.Text, "Лейкоциты") ||
       checkDouble(glukBox.Text, "Глюкоза") ||
       checkDouble(soeBox.Text, "СОЭ") ||
       checkDouble(protBox.Text, "О. Белок") ||
       checkDouble(bilBox.Text, "Билирубин") ||
       checkDouble(asatBox.Text, "АСАТ") ||
       checkDouble(creatineBox.Text, "Креатин") ||
       checkDouble(lpnvBox.Text, "") ||
       checkDouble(lpBox.Text, "ЛП") ||
       checkDouble(triglizBox.Text, "Триглиц") ||
       checkDouble(atBox.Text, "Инд. атерог.") ||
       checkDouble(skfBox.Text, "СКФ") ||
       checkDouble(kcpBox.Text, "КсР") ||
       checkDouble(nt18.Text, "NT-proBNP") ||
       checkDouble(kdrlgBox.Text, "КДРЛЖ") ||
       checkDouble(tmpgBox.Text, "ТМПЖ") ||
       checkDouble(tzslgBox.Text, "ТЗСЛЖ") ||
       checkDouble(fvBox.Text, "ФВ") ||
       checkDouble(ttgBox.Text, "ТТГ") ||
       checkDouble(t4Box.Text, "Т4 своб.") ||
       checkDouble(alphaBox.Text, "Альфа ИНФ") ||
       checkDouble(hcObchBox.Text, "ХС Общий") ||
       checkDouble(il1Box.Text, "ИЛ 1") ||
       checkDouble(il8Box.Text, "ИЛ 8") ||
       checkDouble(il4Box.Text, "ИЛ 4") ||
       checkDouble(il6Box.Text, "ИЛ 6") ||
       checkDouble(gamaBox.Text, "Гама ИНФ") ||
       checkDouble(fnoBox.Text, "ФНО альфа") ||
       checkDouble(aldesteronBox.Text, "Альдостерон") ||
       checkDouble(leptinBox.Text, "Ленптин") ||
       checkDouble(adiponektinBox.Text, "Адипонектин") ||
       checkDouble(alatBox.Text, "АЛАТ") ||
       checkDouble(lpvpBox.Text, "ЛПВП") ||
       checkDouble(kdrpgBox.Text, "КДРПЖ"))
            {
                
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


        public void HAP(double depresion, double creatine, double kdrlg, double ishemia, double lp, double fv,
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
                X1o = 0.003968;
                X1k = 0.071429;
            }
            else
            {
                X1o = 0.051587;
                X1k = 0.928571;
            }

            if(creatine <= 0.11)
            {
                X2o = 0.888889;
                X2k = 0.928571;
            }
            else if (creatine <= 0.139)
            {
                X2o = 0.055556;
                X2k = 0.042857;
            }
            else
            {
                X2o = 0.055556;
                X2k = 0.028571;
            }

            if(kdrlg <= 4.9)
            {
                X3o = 0.444444;
                X3k = 0.714286;
            }
            else if(kdrlg <= 5.9)
            {
                X3o = 0.388889;
                X3k = 0.257143;
            }
            else
            {
                X3o = 0.166667;
                X3k = 0.028571;
            }

            if(ishemia == 1)
            {
                X4o = 0.944444;
                X4k = 0.828571;
            }
            else
            {
                X4o = 0.055556;
                X4k = 0.171429;
            }

            if(lp <= 3.7)
            {
                X5o = 0.277778;
                X5k = 0.571429;
            }
            else if(lp <= 4.1)
            {
                X5o = 0.277778;
                X5k = 0.171429;
            }
            else
            {
                X5o = 0.444444;
                X5k = 0.257143;
            }    


            if(fv <= 44)
            {
                X6o = 0.277778;
                X6k = 0.1;
            }
            else if (fv  <= 54)
            {
                X6o = 0.222222;
                X6k = 0.242857;
            }
            else
            {
                X6o = 0.5;
                X6k = 0.657143;
            }

            if(aldesteron <= 100)
            {
                X7o = 0.184211;
                X7k = 0.266667;
            }
            else if(aldesteron <= 200)
            {
                X7o = 0.276316;
                X7k = 0.133333;
            }
            else if(aldesteron <= 300)
            {
                X7o = 0.171053;
                X7k = 0.333333;
            }
            else
            {
                X7o = 0.236842;
                X7k = 0.266667;
            }

            if(ttg <= 1.0)
            {
                X8o = 0.277778;
                X8k = 0.571429;
            }
            else if(ttg <= 4)
            {
                X8o = 0.277778;
                X8k = 0.171429;
            }
            else
            {
                X8o = 0.444444;
                X8k = 0.257143;
            }


            if(bilirubin <= 11.9)
            {
                X9o = 0.833333;
                X9k = 0.614286;
            }
            else if(bilirubin <= 17)
            {
                X9o = 0.111111;
                X9k = 0.328571;
            }
            else
            {
                X9o = 0.055556;
                X9k = 0.057143;
            }
        }

    }
}
