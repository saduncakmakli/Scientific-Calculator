using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientificCalculation
{
    public partial class Debug : Form
    {
        public Debug()
        {
            InitializeComponent();
        }

        private void Debug_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void Debug_Load(object sender, EventArgs e)
        {
            RefreshListBoxLogs();
            RefreshListViewMainRec();
            RefreshMainRec();
            RefleshMainScreens();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            RefreshListBoxLogs();
            RefreshListViewMainRec();
            RefreshMainRec();
            RefleshMainScreens();
        }

        private void btn_auto_refresh_Click(object sender, EventArgs e)
        {
            if (btn_auto_refresh.BackColor == Color.SlateGray)
            {
                btn_auto_refresh.BackColor = Color.MediumAquamarine;
                tmr_auto_refresh.Enabled = true;
            }
            else if (btn_auto_refresh.BackColor == Color.MediumAquamarine)
            {
                btn_auto_refresh.BackColor = Color.SlateGray;
                tmr_auto_refresh.Enabled = false;
            }
        }

        private void tmr_auto_refresh_Tick(object sender, EventArgs e)
        {
            RefreshListBoxLogs();
            RefreshListViewMainRec();
            RefreshMainRec();
            RefleshMainScreens();

        }

        private void RefreshListBoxLogs()
        {
            //Listbox'un Logs sınıfındaki değerler ile yeniden güncellenmesi için.
            lB_logs.Items.Clear();
            for (int sayac = 0; sayac < Logs.logs_record.Count; sayac++)
            {
                lB_logs.Items.Add(Logs.logs_record[sayac]);
            }

            lB_logs.SelectedIndex = lB_logs.Items.Count - 1;
            lB_logs.SetSelected(lB_logs.Items.Count - 1, false);
        }

        private void RefreshListViewMainRec()
        {
            //ListView için
            listviewMainRec.Items.Clear();
            for (int sayac = 0; sayac < CalculatorUI.mainCalculator.MemorizedNumbers.Count; sayac++)
            {
                ListViewItem listviewItem = new ListViewItem();
                listviewItem.Text = (sayac + 1).ToString();
                listviewItem.SubItems.Add(CalculatorUI.mainCalculator.MemorizedNumbers[sayac].ToString());
                //İşlemlerin tabloya sembolü ile aktarımı için
                //
                //Hatanın çözümü için parantez yeni kapatıldığında debugger listview, güncellemeyi durduracak, yeni işleme basıldığında tekrar başlayacak
                if (CalculatorUI.mainCalculator.MemorizedOperations.Count > sayac)
                {
                    if (CalculatorUI.mainCalculator.MemorizedOperations[sayac] == Calculator.EXP)
                    {
                        listviewItem.SubItems.Add("^");
                    }
                    else if (CalculatorUI.mainCalculator.MemorizedOperations[sayac] == Calculator.ROOT)
                    {
                        listviewItem.SubItems.Add("√¯");
                    }
                    else if (CalculatorUI.mainCalculator.MemorizedOperations[sayac] == Calculator.CROSS)
                    {
                        listviewItem.SubItems.Add("*");
                    }
                    else if (CalculatorUI.mainCalculator.MemorizedOperations[sayac] == Calculator.DIVISION)
                    {
                        listviewItem.SubItems.Add("/");
                    }
                    else if (CalculatorUI.mainCalculator.MemorizedOperations[sayac] == Calculator.PLUS)
                    {
                        listviewItem.SubItems.Add("+");
                    }
                    else if (CalculatorUI.mainCalculator.MemorizedOperations[sayac] == Calculator.MINUS)
                    {
                        listviewItem.SubItems.Add("-");
                    }
                    listviewItem.SubItems.Add(CalculatorUI.mainCalculator.MemorizedProcessPiority[sayac].ToString());
                    listviewMainRec.Items.Add(listviewItem);
                }
            }
        }

        private void RefreshMainRec()
        {
            lblMainRecIsFirstStart.ForeColor = CalculatorUI.mainCalculator.IsFirstStart ? Color.Green : Color.Red;
            lblMainRecIsHaveNumber.ForeColor = CalculatorUI.mainCalculator.IsHaveNumber ? Color.Green : Color.Red;
            lblMainRecIsHaveOperation.ForeColor = CalculatorUI.mainCalculator.IsHaveOperation ? Color.Green : Color.Red;
            lblMainRecIsHaveComma.ForeColor = CalculatorUI.mainCalculator.IsHaveComma ? Color.Green : Color.Red;
            lblMainRecIsHaveNegativeBracket.ForeColor = CalculatorUI.mainCalculator.IsHaveNegativeBracket ? Color.Green : Color.Red;
            lblMainRecIsOperationHavePermit.ForeColor = CalculatorUI.mainCalculator.IsOperationHavePermit ? Color.Green : Color.Red;

            lblMainRecWhichNumber.Text = "Which Number " + CalculatorUI.mainCalculator.WhichNumber;
            lblMainRecWhichOperation.Text = "Which Operation " + CalculatorUI.mainCalculator.WhichNumber;
            lblMainRecWhichBracket.Text = "Which Bracket " + CalculatorUI.mainCalculator.WhichBracket;
            lblMainRecTemporaryProcessingPriority.Text = "Current Process Priority Value " + CalculatorUI.mainCalculator.TemporaryProcessingPriority;
        }

        private void RefleshMainScreens()
        {
            tbMainIslem.Text = CalculatorUI.mainCalculator.OperationScreen;
            tbMainSonuc.Text = CalculatorUI.mainCalculator.ResultScreen;
        }

        private void CleanLogs()
        {
            //Eski logları temizleme işlemi
            int overage;
            overage = Logs.logs_record.Count - 26;
            if (overage > 0)
            {
                Logs.logs_record.RemoveRange(0, overage);
            }
        }

        private void btn_auto_log_clean_Click(object sender, EventArgs e)
        {
            if (btn_auto_log_clean.BackColor == Color.SlateGray)
            {
                btn_auto_log_clean.BackColor = Color.MediumAquamarine;
                tmr_auto_logs_clean.Enabled = true;
            }
            else if (btn_auto_log_clean.BackColor == Color.MediumAquamarine)
            {
                btn_auto_log_clean.BackColor = Color.SlateGray;
                tmr_auto_logs_clean.Enabled = false;
            }
        }

        private void tmr_auto_logs_clean_Tick(object sender, EventArgs e)
        {
            CleanLogs();
        }

        private void btn_logs_Click(object sender, EventArgs e)
        {
            if (btn_logs.BackColor == Color.SlateGray)
            {
                btn_logs.BackColor = Color.MediumAquamarine;
                lB_logs.Visible = true;
                btn_auto_log_clean.Visible = true;
            }
            else if (btn_logs.BackColor == Color.MediumAquamarine)
            {
                btn_logs.BackColor = Color.SlateGray;
                lB_logs.Visible = false;
                btn_auto_log_clean.Visible = false;
            }
            VisualOptimize();
        }

        private void btn_screens_Click(object sender, EventArgs e)
        {
            if (btn_screens.BackColor == Color.SlateGray)
            {
                btn_screens.BackColor = Color.MediumAquamarine;
                lblMainScreen.Visible = true;
                tbMainIslem.Visible = true;
                tbMainSonuc.Visible = true;
                tabControl1.Width = 929;

            }
            else if (btn_screens.BackColor == Color.MediumAquamarine)
            {
                btn_screens.BackColor = Color.SlateGray;
                lblMainScreen.Visible = false;
                tbMainIslem.Visible = false;
                tbMainSonuc.Visible = false;
                tabControl1.Width = 589;
            }
            VisualOptimize();
        }

        private void VisualOptimize()
        {
            if (btn_logs.BackColor == Color.SlateGray)
            {
                if (btn_screens.BackColor == Color.SlateGray)
                {
                    Debug.ActiveForm.Width = 620;
                    tabControl1.Location = new Point(9, 12);
                    btn_logs.Location = new Point(13, 419);
                    btn_refresh.Location = new Point(177, 419);
                    btn_auto_refresh.Location = new Point(301, 419);
                    btn_screens.Location = new Point(467, 419);
                }
                else
                {
                    Debug.ActiveForm.Width = 960;
                    tabControl1.Location = new Point(9, 12);
                    btn_logs.Location = new Point(13, 419);
                    btn_refresh.Location = new Point(177, 419);
                    btn_auto_refresh.Location = new Point(301, 419);
                    btn_screens.Location = new Point(467, 419);
                }
            }
            else
            {
                if (btn_screens.BackColor == Color.SlateGray)
                {
                    Debug.ActiveForm.Width = 910;
                    tabControl1.Location = new Point(299, 12);
                    btn_logs.Location = new Point(303, 419);
                    btn_refresh.Location = new Point(467, 419);
                    btn_auto_refresh.Location = new Point(591, 419);
                    btn_screens.Location = new Point(757, 419);
                }
                else
                {
                    Debug.ActiveForm.Width = 1256;
                    tabControl1.Location = new Point(299, 12);
                    btn_logs.Location = new Point(303, 419);
                    btn_refresh.Location = new Point(467, 419);
                    btn_auto_refresh.Location = new Point(591, 419);
                    btn_screens.Location = new Point(757, 419);
                }
            }
        }
    }
}
