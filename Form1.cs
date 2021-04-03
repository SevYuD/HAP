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
