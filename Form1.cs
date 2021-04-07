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
    }
}
