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
    public partial class CalculatorUI : Form
    {
        //Objects
        internal static Calculator mainCalculator = new Calculator(0);
        internal static Calculator aCalculator = new Calculator(1);
        internal static Calculator bCalculator = new Calculator(2);
        internal static Calculator cCalculator = new Calculator(3);
        internal static Calculator dCalculator = new Calculator(4);
        internal static Calculator eCalculator = new Calculator(5);
        internal static Calculator fCalculator = new Calculator(6);
        Debug debug = new Debug();

        bool isVersiyonActivePassive;

        public CalculatorUI()
        {
            Logs.logs_record.Add("Form Component Initialized.");
            InitializeComponent();
        }

        private void CalculatorUI_Load(object sender, EventArgs e)
        {
            Calculator.selectedRec = String.Empty;
            Logs.logs_record.Add("Form Loaded.");
        }

        private void NumberButtons_Click(object sender, EventArgs e)
        {
            //Hangi rakama basıldığının tespiti için.
            string number_string;
            char number_string2;
            int number;

            number_string = sender.ToString();
            number_string2 = Convert.ToChar(number_string[number_string.Length - 1]);
            number = (int)char.GetNumericValue(number_string2);

            Logs.logs_record.Add("Pressed "+ number + " button.");


            if (Calculator.selectedRec == String.Empty)
                tb_sonuc.Text = mainCalculator.EnterNumber(number);
            else if (Calculator.selectedRec == "A")
                tb_sonuc.Text = aCalculator.EnterNumber(Convert.ToInt32(number));
            else if (Calculator.selectedRec == "B")
                tb_sonuc.Text = bCalculator.EnterNumber(Convert.ToInt32(number));
            else if (Calculator.selectedRec == "C")
                tb_sonuc.Text = cCalculator.EnterNumber(Convert.ToInt32(number));
            else if (Calculator.selectedRec == "D")
                tb_sonuc.Text = dCalculator.EnterNumber(Convert.ToInt32(number));
            else if (Calculator.selectedRec == "E")
                tb_sonuc.Text = eCalculator.EnterNumber(Convert.ToInt32(number));
            else if (Calculator.selectedRec == "F")
                tb_sonuc.Text = fCalculator.EnterNumber(Convert.ToInt32(number));

            //Optionsla istenirse kapatma özelliği gelecek.
            tb_sonuc.Text = Calculator.DotNotationResultScreen(tb_sonuc.Text);
        }

        private void PositiveNegativeButton_Click(object sender, EventArgs e)
        {
            if (Calculator.selectedRec == String.Empty)
            {
                tb_sonuc.Text = mainCalculator.PositiveNegativeButton();
            }

            else if (Calculator.selectedRec == "A")
            {
                tb_sonuc.Text = aCalculator.PositiveNegativeButton();
            }

            else if (Calculator.selectedRec == "B")
            {
                tb_sonuc.Text = bCalculator.PositiveNegativeButton();
            }

            else if (Calculator.selectedRec == "C")
            {
                tb_sonuc.Text = cCalculator.PositiveNegativeButton();
            }

            else if (Calculator.selectedRec == "D")
            {
                tb_sonuc.Text = dCalculator.PositiveNegativeButton();
            }

            else if (Calculator.selectedRec == "E")
            {
                tb_sonuc.Text = eCalculator.PositiveNegativeButton();
            }

            else if (Calculator.selectedRec == "F")
            {
                tb_sonuc.Text = fCalculator.PositiveNegativeButton();
            }

            Logs.logs_record.Add("Pressed positive/negative brackets button.");

            //Optionsla istenirse kapatma özelliği gelecek.
            tb_sonuc.Text = Calculator.DotNotationResultScreen(tb_sonuc.Text);
        }

        private void CommaButton_Click(object sender, EventArgs e)
        {
            if (Calculator.selectedRec == String.Empty)
            {
                tb_sonuc.Text = mainCalculator.CommaButton();
            }

            else if (Calculator.selectedRec == "A")
            {
                tb_sonuc.Text = aCalculator.CommaButton();
            }

            else if (Calculator.selectedRec == "B")
            {
                tb_sonuc.Text = bCalculator.CommaButton();
            }

            else if (Calculator.selectedRec == "C")
            {
                tb_sonuc.Text = cCalculator.CommaButton();
            }

            else if (Calculator.selectedRec == "D")
            {
                tb_sonuc.Text = dCalculator.CommaButton();
            }

            else if (Calculator.selectedRec == "E")
            {
                tb_sonuc.Text = eCalculator.CommaButton();
            }

            else if (Calculator.selectedRec == "F")
            {
                tb_sonuc.Text = fCalculator.CommaButton();
            }

            Logs.logs_record.Add("Pressed Comma Button.");

            //Optionsla istenirse kapatma özelliği gelecek.
            tb_sonuc.Text = Calculator.DotNotationResultScreen(tb_sonuc.Text);
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            string temp_tb_islem = String.Empty;
            switch (Calculator.selectedRec)
            {
                case (""):
                    temp_tb_islem = mainCalculator.PlusButton();
                    if (temp_tb_islem != String.Empty)
                    {
                        tb_islem.Text = temp_tb_islem;
                        tb_sonuc.Text = String.Empty;
                    }
                    break;

                case ("A"):
                    temp_tb_islem = aCalculator.PlusButton();
                    if (temp_tb_islem != String.Empty)
                    {
                        tb_islem.Text = temp_tb_islem;
                        tb_sonuc.Text = String.Empty;
                    }
                    break;

                case ("B"):
                    temp_tb_islem = bCalculator.PlusButton();
                    if (temp_tb_islem != String.Empty)
                    {
                        tb_islem.Text = temp_tb_islem;
                        tb_sonuc.Text = String.Empty;
                    }
                    break;

                case ("C"):
                    temp_tb_islem = cCalculator.PlusButton();
                    if (temp_tb_islem != String.Empty)
                    {
                        tb_islem.Text = temp_tb_islem;
                        tb_sonuc.Text = String.Empty;
                    }
                    break;

                case ("D"):
                    temp_tb_islem = dCalculator.PlusButton();
                    if (temp_tb_islem != String.Empty)
                    {
                        tb_islem.Text = temp_tb_islem;
                        tb_sonuc.Text = String.Empty;
                    }
                    break;

                case ("E"):
                    temp_tb_islem = eCalculator.PlusButton();
                    if (temp_tb_islem != String.Empty)
                    {
                        tb_islem.Text = temp_tb_islem;
                        tb_sonuc.Text = String.Empty;
                    }
                    break;

                case ("F"):
                    temp_tb_islem = fCalculator.PlusButton();
                    if (temp_tb_islem != String.Empty)
                    {
                        tb_islem.Text = temp_tb_islem;
                        tb_sonuc.Text = String.Empty;
                    }
                    break;
            }

            //İmleci sona almak için
            tb_islem.ScrollToCaret();
            tb_islem.Select(tb_islem.Text.Length, tb_islem.Lines.Length);

            Logs.logs_record.Add("Pressed Plus Button.");
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            string temp_tb_islem = String.Empty;
            switch (Calculator.selectedRec)
            {
                case (""):
                    temp_tb_islem = mainCalculator.MinusButton();
                    if (temp_tb_islem != String.Empty)
                    {
                        tb_islem.Text = temp_tb_islem;
                        tb_sonuc.Text = String.Empty;
                    }
                    break;

                case ("A"):
                    temp_tb_islem = aCalculator.MinusButton();
                    if (temp_tb_islem != String.Empty)
                    {
                        tb_islem.Text = temp_tb_islem;
                        tb_sonuc.Text = String.Empty;
                    }
                    break;

                case ("B"):
                    temp_tb_islem = bCalculator.MinusButton();
                    if (temp_tb_islem != String.Empty)
                    {
                        tb_islem.Text = temp_tb_islem;
                        tb_sonuc.Text = String.Empty;
                    }
                    break;

                case ("C"):
                    temp_tb_islem = cCalculator.MinusButton();
                    if (temp_tb_islem != String.Empty)
                    {
                        tb_islem.Text = temp_tb_islem;
                        tb_sonuc.Text = String.Empty;
                    }
                    break;

                case ("D"):
                    temp_tb_islem = dCalculator.MinusButton();
                    if (temp_tb_islem != String.Empty)
                    {
                        tb_islem.Text = temp_tb_islem;
                        tb_sonuc.Text = String.Empty;
                    }
                    break;

                case ("E"):
                    temp_tb_islem = eCalculator.MinusButton();
                    if (temp_tb_islem != String.Empty)
                    {
                        tb_islem.Text = temp_tb_islem;
                        tb_sonuc.Text = String.Empty;
                    }
                    break;

                case ("F"):
                    temp_tb_islem = fCalculator.MinusButton();
                    if (temp_tb_islem != String.Empty)
                    {
                        tb_islem.Text = temp_tb_islem;
                        tb_sonuc.Text = String.Empty;
                    }
                    break;
            }

            //İmleci sona almak için
            tb_islem.ScrollToCaret();
            tb_islem.Select(tb_islem.Text.Length, tb_islem.Lines.Length);

            Logs.logs_record.Add("Pressed Minus Button.");
        }

        private void CrossButton_Click(object sender, EventArgs e)
        {
            string temp_tb_islem = String.Empty;
            switch (Calculator.selectedRec)
            {
                case (""):
                    temp_tb_islem = mainCalculator.CrossButton();
                    if (temp_tb_islem != String.Empty)
                    {
                        tb_islem.Text = temp_tb_islem;
                        tb_sonuc.Text = String.Empty;
                    }
                    break;

                case ("A"):
                    temp_tb_islem = aCalculator.CrossButton();
                    if (temp_tb_islem != String.Empty)
                    {
                        tb_islem.Text = temp_tb_islem;
                        tb_sonuc.Text = String.Empty;
                    }
                    break;

                case ("B"):
                    temp_tb_islem = bCalculator.CrossButton();
                    if (temp_tb_islem != String.Empty)
                    {
                        tb_islem.Text = temp_tb_islem;
                        tb_sonuc.Text = String.Empty;
                    }
                    break;

                case ("C"):
                    temp_tb_islem = cCalculator.CrossButton();
                    if (temp_tb_islem != String.Empty)
                    {
                        tb_islem.Text = temp_tb_islem;
                        tb_sonuc.Text = String.Empty;
                    }
                    break;

                case ("D"):
                    temp_tb_islem = dCalculator.CrossButton();
                    if (temp_tb_islem != String.Empty)
                    {
                        tb_islem.Text = temp_tb_islem;
                        tb_sonuc.Text = String.Empty;
                    }
                    break;

                case ("E"):
                    temp_tb_islem = eCalculator.CrossButton();
                    if (temp_tb_islem != String.Empty)
                    {
                        tb_islem.Text = temp_tb_islem;
                        tb_sonuc.Text = String.Empty;
                    }
                    break;

                case ("F"):
                    temp_tb_islem = fCalculator.CrossButton();
                    if (temp_tb_islem != String.Empty)
                    {
                        tb_islem.Text = temp_tb_islem;
                        tb_sonuc.Text = String.Empty;
                    }
                    break;
            }

            //İmleci sona almak için
            tb_islem.ScrollToCaret();
            tb_islem.Select(tb_islem.Text.Length, tb_islem.Lines.Length);

            Logs.logs_record.Add("Pressed Cross Button.");
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            string temp_tb_islem = String.Empty;
            switch (Calculator.selectedRec)
            {
                case (""):
                    temp_tb_islem = mainCalculator.DivisionButton();
                    if (temp_tb_islem != String.Empty)
                    {
                        tb_islem.Text = temp_tb_islem;
                        tb_sonuc.Text = String.Empty;
                    }
                    break;

                case ("A"):
                    temp_tb_islem = aCalculator.DivisionButton();
                    if (temp_tb_islem != String.Empty)
                    {
                        tb_islem.Text = temp_tb_islem;
                        tb_sonuc.Text = String.Empty;
                    }
                    break;

                case ("B"):
                    temp_tb_islem = bCalculator.DivisionButton();
                    if (temp_tb_islem != String.Empty)
                    {
                        tb_islem.Text = temp_tb_islem;
                        tb_sonuc.Text = String.Empty;
                    }
                    break;

                case ("C"):
                    temp_tb_islem = cCalculator.DivisionButton();
                    if (temp_tb_islem != String.Empty)
                    {
                        tb_islem.Text = temp_tb_islem;
                        tb_sonuc.Text = String.Empty;
                    }
                    break;

                case ("D"):
                    temp_tb_islem = dCalculator.DivisionButton();
                    if (temp_tb_islem != String.Empty)
                    {
                        tb_islem.Text = temp_tb_islem;
                        tb_sonuc.Text = String.Empty;
                    }
                    break;

                case ("E"):
                    temp_tb_islem = eCalculator.DivisionButton();
                    if (temp_tb_islem != String.Empty)
                    {
                        tb_islem.Text = temp_tb_islem;
                        tb_sonuc.Text = String.Empty;
                    }
                    break;

                case ("F"):
                    temp_tb_islem = fCalculator.DivisionButton();
                    if (temp_tb_islem != String.Empty)
                    {
                        tb_islem.Text = temp_tb_islem;
                        tb_sonuc.Text = String.Empty;
                    }
                    break;
            }

            //İmleci sona almak için
            tb_islem.ScrollToCaret();
            tb_islem.Select(tb_islem.Text.Length, tb_islem.Lines.Length);

            Logs.logs_record.Add("Pressed Division Button.");
        }

        private void ExpButton_Click(object sender, EventArgs e)
        {

        }

        private void RootButton_Click(object sender, EventArgs e)
        {

        }

        private void RecAButton_Click(object sender, EventArgs e)
        {
            Logs.logs_record.Add("Pressed REC A button.");
            if (Calculator.selectedRec != "A")
            {
                button_rec_A.BackColor = Color.MediumAquamarine;
                Calculator.selectedRec = "A";
                tb_sonuc.Text = aCalculator.ResultScreen;
                tb_islem.Text = aCalculator.OperationScreen;
                Logs.logs_record.Add("A Calculator is active.");
            }
            else
            {
                button_rec_A.BackColor = Color.SlateGray;
                Calculator.selectedRec = String.Empty;
                tb_sonuc.Text = mainCalculator.ResultScreen;
                tb_islem.Text = mainCalculator.OperationScreen;
                Logs.logs_record.Add("A Calculator is passive.");
                Logs.logs_record.Add("Main Calculator is active.");
            }
            button_rec_B.BackColor = Color.SlateGray;
            button_rec_C.BackColor = Color.SlateGray;
            button_rec_D.BackColor = Color.SlateGray;
            button_rec_E.BackColor = Color.SlateGray;
            button_rec_F.BackColor = Color.SlateGray;
        }

        private void RecBButton_Click(object sender, EventArgs e)
        {
            Logs.logs_record.Add("Pressed REC B button.");
            if (Calculator.selectedRec != "B")
            {
                button_rec_B.BackColor = Color.MediumAquamarine;
                Calculator.selectedRec = "B";
                tb_sonuc.Text = bCalculator.ResultScreen;
                tb_islem.Text = bCalculator.OperationScreen;
                Logs.logs_record.Add("B Calculator is active.");
            }
            else
            {
                button_rec_B.BackColor = Color.SlateGray;
                Calculator.selectedRec = String.Empty;
                tb_sonuc.Text = mainCalculator.ResultScreen;
                tb_islem.Text = mainCalculator.OperationScreen;
                Logs.logs_record.Add("B Calculator is passive.");
                Logs.logs_record.Add("Main Calculator is active.");
            }
            button_rec_A.BackColor = Color.SlateGray;
            button_rec_C.BackColor = Color.SlateGray;
            button_rec_D.BackColor = Color.SlateGray;
            button_rec_E.BackColor = Color.SlateGray;
            button_rec_F.BackColor = Color.SlateGray;
        }

        private void RecCButton_Click(object sender, EventArgs e)
        {
            Logs.logs_record.Add("Pressed REC C button.");
            if (Calculator.selectedRec != "C")
            {
                button_rec_C.BackColor = Color.MediumAquamarine;
                Calculator.selectedRec = "C";
                tb_sonuc.Text = cCalculator.ResultScreen;
                tb_islem.Text = cCalculator.OperationScreen;
                Logs.logs_record.Add("C Calculator is active.");
            }
            else
            {
                button_rec_C.BackColor = Color.SlateGray;
                Calculator.selectedRec = String.Empty;
                tb_sonuc.Text = mainCalculator.ResultScreen;
                tb_islem.Text = mainCalculator.OperationScreen;
                Logs.logs_record.Add("C Calculator is passive.");
                Logs.logs_record.Add("Main Calculator is active.");
            }
            button_rec_B.BackColor = Color.SlateGray;
            button_rec_A.BackColor = Color.SlateGray;
            button_rec_D.BackColor = Color.SlateGray;
            button_rec_E.BackColor = Color.SlateGray;
            button_rec_F.BackColor = Color.SlateGray;
        }

        private void RecDButton_Click(object sender, EventArgs e)
        {
            Logs.logs_record.Add("Pressed REC D button.");
            if (Calculator.selectedRec != "D")
            {
                button_rec_D.BackColor = Color.MediumAquamarine;
                Calculator.selectedRec = "D";
                tb_sonuc.Text = dCalculator.ResultScreen;
                tb_islem.Text = dCalculator.OperationScreen;
                Logs.logs_record.Add("D Calculator is active.");
            }
            else
            {
                button_rec_D.BackColor = Color.SlateGray;
                Calculator.selectedRec = String.Empty;
                tb_sonuc.Text = mainCalculator.ResultScreen;
                tb_islem.Text = mainCalculator.OperationScreen;
                Logs.logs_record.Add("D Calculator is passive.");
                Logs.logs_record.Add("Main Calculator is active.");
            }
            button_rec_B.BackColor = Color.SlateGray;
            button_rec_C.BackColor = Color.SlateGray;
            button_rec_A.BackColor = Color.SlateGray;
            button_rec_E.BackColor = Color.SlateGray;
            button_rec_F.BackColor = Color.SlateGray;
        }

        private void RecEButton_Click(object sender, EventArgs e)
        {
            Logs.logs_record.Add("Pressed REC E button.");
            if (Calculator.selectedRec != "E")
            {
                button_rec_E.BackColor = Color.MediumAquamarine;
                Calculator.selectedRec = "E";
                tb_sonuc.Text = eCalculator.ResultScreen;
                tb_islem.Text = eCalculator.OperationScreen;
                Logs.logs_record.Add("E Calculator is active.");
            }
            else
            {
                button_rec_E.BackColor = Color.SlateGray;
                Calculator.selectedRec = String.Empty;
                tb_sonuc.Text = mainCalculator.ResultScreen;
                tb_islem.Text = mainCalculator.OperationScreen;
                Logs.logs_record.Add("E Calculator is passive.");
                Logs.logs_record.Add("Main Calculator is active.");
            }
            button_rec_B.BackColor = Color.SlateGray;
            button_rec_C.BackColor = Color.SlateGray;
            button_rec_D.BackColor = Color.SlateGray;
            button_rec_A.BackColor = Color.SlateGray;
            button_rec_F.BackColor = Color.SlateGray;
        }

        private void RecFButton_Click(object sender, EventArgs e)
        {
            Logs.logs_record.Add("Pressed REC F button.");
            if (Calculator.selectedRec != "F")
            {
                button_rec_F.BackColor = Color.MediumAquamarine;
                Calculator.selectedRec = "F";
                tb_sonuc.Text = fCalculator.ResultScreen;
                tb_islem.Text = fCalculator.OperationScreen;
                Logs.logs_record.Add("F Calculator is active.");
            }
            else
            {
                button_rec_F.BackColor = Color.SlateGray;
                Calculator.selectedRec = String.Empty;
                tb_sonuc.Text = mainCalculator.ResultScreen;
                tb_islem.Text = mainCalculator.OperationScreen;
                Logs.logs_record.Add("F Calculator is passive.");
                Logs.logs_record.Add("Main Calculator is active.");
            }

            button_rec_B.BackColor = Color.SlateGray;
            button_rec_C.BackColor = Color.SlateGray;
            button_rec_D.BackColor = Color.SlateGray;
            button_rec_E.BackColor = Color.SlateGray;
            button_rec_A.BackColor = Color.SlateGray;
        }

        private void RecRecordButton_Click(object sender, EventArgs e)
        {

        }

        private void RecClearButton_Click(object sender, EventArgs e)
        {
            tb_sonuc.Text = String.Empty;
            tb_islem.Text = String.Empty;

            Logs.logs_record.Add("Pressed Rec Clear Button.");
            if (button_rec_A.BackColor == Color.MediumAquamarine)
            {
                aCalculator.CalculatorReset();
                Logs.logs_record.Add("Recordable Number A is Cleared.");
            }
                
            else if (button_rec_B.BackColor == Color.MediumAquamarine)
            {
                bCalculator.CalculatorReset();
                Logs.logs_record.Add("Recordable Number B is Cleared.");
            }
                
            else if (button_rec_C.BackColor == Color.MediumAquamarine)
            {
                cCalculator.CalculatorReset();
                Logs.logs_record.Add("Recordable Number C is Cleared.");
            }

            else if (button_rec_D.BackColor == Color.MediumAquamarine)
            {
                dCalculator.CalculatorReset();
                Logs.logs_record.Add("Recordable Number D is Cleared.");
            }
                
            else if (button_rec_E.BackColor == Color.MediumAquamarine)
            {
                eCalculator.CalculatorReset();
                Logs.logs_record.Add("Recordable Number E is Cleared.");
            }

            else if (button_rec_F.BackColor == Color.MediumAquamarine)
            {
                fCalculator.CalculatorReset();
                Logs.logs_record.Add("Recordable Number F is Cleared.");
            }
            
            else
            {
                mainCalculator.CalculatorReset();
                Logs.logs_record.Add("Main Calculation is Cleared.");
            }
        }

        private void VersionLabel_DoubleClick(object sender, EventArgs e)
        {
            Logs.logs_record.Add("Double Pressed Versiyon Text.");
            if (isVersiyonActivePassive == true)
            {
                Logs.logs_record.Add("DEBUG MODE OFF.");
                isVersiyonActivePassive = false;
                lb_version.BackColor = Color.White;
                debug.Hide();
            }
            else
            {
                Logs.logs_record.Add("DEBUG MODE ON!");
                isVersiyonActivePassive = true;
                lb_version.BackColor = Color.Red;
                debug.Show();
            }
        }

        private void BracketOpenButton_Click(object sender, EventArgs e)
        {
            Logs.logs_record.Add("Pressed Brackets Open Button.");
            if (Calculator.selectedRec == String.Empty)
            {
                tb_islem.Text = mainCalculator.BracketOpenButton();
                tb_sonuc.Text = mainCalculator.ResultScreen;
            }

            else if (Calculator.selectedRec == "A")
            {
                tb_islem.Text = aCalculator.BracketOpenButton();
                tb_sonuc.Text = aCalculator.ResultScreen;
            }

            else if (Calculator.selectedRec == "B")
            {
                tb_islem.Text = bCalculator.BracketOpenButton();
                tb_sonuc.Text = bCalculator.ResultScreen;
            }

            else if (Calculator.selectedRec == "C")
            {
                tb_islem.Text = cCalculator.BracketOpenButton();
                tb_sonuc.Text = cCalculator.ResultScreen;
            }

            else if (Calculator.selectedRec == "D")
            {
                tb_islem.Text = dCalculator.BracketOpenButton();
                tb_sonuc.Text = dCalculator.ResultScreen;
            }

            else if (Calculator.selectedRec == "E")
            {
                tb_islem.Text = eCalculator.BracketOpenButton();
                tb_sonuc.Text = eCalculator.ResultScreen;
            }

            else if (Calculator.selectedRec == "F")
            {
                tb_islem.Text = fCalculator.BracketOpenButton();
                tb_sonuc.Text = fCalculator.ResultScreen;
            }
        }

        private void BracketsCloseButton_Click(object sender, EventArgs e)
        {
            Logs.logs_record.Add("Pressed Brackets Close Button.");
            if (Calculator.selectedRec == String.Empty)
            {
                tb_islem.Text = mainCalculator.BracketCloseButton();
                tb_sonuc.Text = mainCalculator.ResultScreen;
            }

            else if (Calculator.selectedRec == "A")
            {
                tb_islem.Text = aCalculator.BracketCloseButton();
                tb_sonuc.Text = aCalculator.ResultScreen;
            }

            else if (Calculator.selectedRec == "B")
            {
                tb_islem.Text = bCalculator.BracketCloseButton();
                tb_sonuc.Text = bCalculator.ResultScreen;
            }

            else if (Calculator.selectedRec == "C")
            {
                tb_islem.Text = cCalculator.BracketCloseButton();
                tb_sonuc.Text = cCalculator.ResultScreen;
            }

            else if (Calculator.selectedRec == "D")
            {
                tb_islem.Text = dCalculator.BracketCloseButton();
                tb_sonuc.Text = dCalculator.ResultScreen;
            }

            else if (Calculator.selectedRec == "E")
            {
                tb_islem.Text = eCalculator.BracketCloseButton();
                tb_sonuc.Text = eCalculator.ResultScreen;
            }

            else if (Calculator.selectedRec == "F")
            {
                tb_islem.Text = fCalculator.BracketCloseButton();
                tb_sonuc.Text = fCalculator.ResultScreen;
            }
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            Logs.logs_record.Add("Calculator is cleared.");
            tb_islem.Text = String.Empty;
            tb_sonuc.Text = String.Empty;
            mainCalculator.CalculatorReset();
            aCalculator.CalculatorReset();
            bCalculator.CalculatorReset();
            cCalculator.CalculatorReset();
            dCalculator.CalculatorReset();
            eCalculator.CalculatorReset();
            fCalculator.CalculatorReset();
        }

        private void button_DEL_Click(object sender, EventArgs e)
        {
            Logs.logs_record.Add("Pressed DEL button.");
            switch (Calculator.selectedRec)
            {
                case (""):
                    try
                    {
                        tb_sonuc.Text = mainCalculator.DeleteButton();
                        Logs.logs_record.Add("Deleted a character from the main result screen.");
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.StackTrace +"\n"+ exception.Message);
                        Logs.logs_record.Add(exception.Message);
                    }
                    break;

                case ("A"):
                    try
                    {
                        tb_sonuc.Text = aCalculator.DeleteButton();
                        Logs.logs_record.Add("Deleted a character from the A result screen.");
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.StackTrace + "\n" + exception.Message);
                        Logs.logs_record.Add(exception.Message);
                    }
                    break;

                case ("B"):
                    try
                    {
                        tb_sonuc.Text = bCalculator.DeleteButton();
                        Logs.logs_record.Add("Deleted a character from the B result screen.");
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.StackTrace + "\n" + exception.Message);
                        Logs.logs_record.Add(exception.Message);
                    }
                    break;

                case ("C"):
                    try
                    {
                        tb_sonuc.Text = cCalculator.DeleteButton();
                        Logs.logs_record.Add("Deleted a character from the C result screen.");
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.StackTrace + "\n" + exception.Message);
                        Logs.logs_record.Add(exception.Message);
                    }
                    break;

                case ("D"):
                    try
                    {
                        tb_sonuc.Text = dCalculator.DeleteButton();
                        Logs.logs_record.Add("Deleted a character from the D result screen.");
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.StackTrace + "\n" + exception.Message);
                        Logs.logs_record.Add(exception.Message);
                    }
                    break;

                case ("E"):
                    try
                    {
                        tb_sonuc.Text = eCalculator.DeleteButton();
                        Logs.logs_record.Add("Deleted a character from the E result screen.");
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.StackTrace + "\n" + exception.Message);
                        Logs.logs_record.Add(exception.Message);
                    }
                    break;

                case ("F"):
                    try
                    {
                        tb_sonuc.Text = fCalculator.DeleteButton();
                        Logs.logs_record.Add("Deleted a character from the F result screen.");
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.StackTrace + "\n" + exception.Message);
                        Logs.logs_record.Add(exception.Message);
                    }
                    break;
            }

            //Optionsla istenirse kapatma özelliği gelecek.
            tb_sonuc.Text = Calculator.DotNotationResultScreen(tb_sonuc.Text);
        }

        private void button_CE_Click(object sender, EventArgs e)
        {

        }

        private void button_help_MouseDown(object sender, MouseEventArgs e)
        {
            help_label_1.Visible = true;
            help_label_2.Visible = true;
            help_label_3.Visible = true;
        }

        private void button_help_MouseUp(object sender, MouseEventArgs e)
        {
            help_label_1.Visible = false;
            help_label_2.Visible = false;
            help_label_3.Visible = false;
        }

        private void CalculatorUI_Activated(object sender, EventArgs e)
        {
            //Forumun genişlik ve yüksekliğinin hatalı çıkması geçici çözüm
            ActiveForm.Width = 420;
            ActiveForm.Height = 620;
        }

        //ALTGR, CTRL, SHIFT TUSLARININ GUNCEL DURUMU
        private bool special_key_altGr = false;
        private bool special_key_ctrl = false;
        private bool special_key_shift = false;
        //TUSLARI YAKALAYAN METHOD
        private void CalculatorUI_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //112 F1
            //18 AltGr
            //17 Ctrl
            //16 Shift
            if (e.KeyValue == 18 || e.KeyValue == 17 || e.KeyValue == 16 || e.KeyValue == 112)
            {
                return;
            }

            Console.WriteLine(e.KeyValue);

            if (special_key_altGr == false && special_key_ctrl == false && special_key_shift == false)
            {
                switch (e.KeyCode)
                {
                    case (Keys.D0):
                    case (Keys.NumPad0):
                        NumberButtons_Click("0", null);
                        break;

                    case (Keys.D1):
                    case (Keys.NumPad1):
                        NumberButtons_Click("1", null);
                        break;

                    case (Keys.D2):
                    case (Keys.NumPad2):
                        NumberButtons_Click("2", null);
                        break;

                    case (Keys.D3):
                    case (Keys.NumPad3):
                        NumberButtons_Click("3", null);
                        break;

                    case (Keys.D4):
                    case (Keys.NumPad4):
                        NumberButtons_Click("4", null);
                        break;

                    case (Keys.D5):
                    case (Keys.NumPad5):
                        NumberButtons_Click("5", null);
                        break;

                    case (Keys.D6):
                    case (Keys.NumPad6):
                        NumberButtons_Click("6", null);
                        break;

                    case (Keys.D7):
                    case (Keys.NumPad7):
                        NumberButtons_Click("7", null);
                        break;

                    case (Keys.D8):
                    case (Keys.NumPad8):
                        NumberButtons_Click("8", null);
                        break;

                    case (Keys.D9):
                    case (Keys.NumPad9):
                        NumberButtons_Click("9", null);
                        break;

                    case (Keys.Oemcomma):
                        CommaButton_Click(null, null);
                        break;

                    case (Keys.Divide):
                        DivisionButton_Click(null, null);
                        break;

                    case (Keys.Multiply):
                        CrossButton_Click(null, null);
                        break;

                    case (Keys.OemMinus):
                    case (Keys.Subtract):
                        MinusButton_Click(null, null);
                        break;

                    case (Keys.Oemplus):
                    case (Keys.Add):
                        PlusButton_Click(null, null);
                        break;

                    case (Keys.A):
                        RecAButton_Click(null, null);
                        break;

                    case (Keys.B):
                        RecBButton_Click(null, null);
                        break;

                    case (Keys.C):
                        RecCButton_Click(null, null);
                        break;

                    case (Keys.D):
                        RecDButton_Click(null, null);
                        break;

                    case (Keys.E):
                        RecEButton_Click(null, null);
                        break;

                    case (Keys.F):
                        RecFButton_Click(null, null);
                        break;
                }

                switch (e.KeyValue)
                {
                    case (188):
                    case (110):
                        CommaButton_Click(null, null);
                        break;

                    case (111):
                        DivisionButton_Click(null, null);
                        break;

                    case (106):
                        CrossButton_Click(null, null);
                        break;

                    case (109):
                        MinusButton_Click(null, null);
                        break;

                    case (107):
                        PlusButton_Click(null, null);
                        break;

                    case (223):
                        CrossButton_Click(null, null);
                        break;

                    case (8):
                    case (46):
                        button_DEL_Click(null, null);
                        break;
                }
            }

            //ALTGR AÇIKKEN
            if (special_key_altGr == true && special_key_ctrl == false && special_key_shift == false)
            {
                /*
                switch (e.KeyValue)
                {

                }
                */
            }

            //CTRL AÇIKKEN
            if (special_key_ctrl == true && special_key_altGr == false && special_key_shift == false)
            {
                /*
                switch (e.KeyValue)
                {

                }
                */
            }

            //SHIFT AÇIKKEN
            if (special_key_shift == true && special_key_altGr == false && special_key_ctrl == false)
            {
                switch (e.KeyValue)
                {
                    case (52):
                        PlusButton_Click(null, null);
                        break;

                    case (55):
                        DivisionButton_Click(null, null);
                        break;

                    case (56):
                        BracketOpenButton_Click(null, null);
                        break;
                        
                    case (57):
                        BracketsCloseButton_Click(null, null);
                        break;

                    case (48):
                        button_equals_Click(null, null);
                        break;
                }
            }
        }

        private void CalculatorUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 18)
            {
                special_key_altGr = true;
            }

            if (e.KeyValue == 17)
            {
                special_key_ctrl = true;
            }

            if (e.KeyValue == 16)
            {
                special_key_shift = true;
            }

            if (e.KeyCode == Keys.F1)
            {
                button_help_MouseDown(null, null);
            }

        }

        private void CalculatorUI_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 18)
            {
                special_key_altGr = false;
            }

            if (e.KeyValue == 17)
            {
                special_key_ctrl = false;
            }

            if (e.KeyValue == 16)
            {
                special_key_shift = false;
            }

            if (e.KeyCode == Keys.F1)
            {
                button_help_MouseUp(null, null);
            }
        }

        private void button_equals_Click(object sender, EventArgs e)
        {

        }

    }
}

