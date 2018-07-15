using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ScientificCalculation
{
    /// <summary>
    /// Buton mantığında çalışan gelişmiş bir hesap makinesi
    /// İcerisinde bir hesap makinesinde olması gereken butonların komutlarına ekstra olarak daha farklı özellik ve hesaplama komutları bulunur.
    /// </summary>
    internal class Calculator
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="whichRec"></param>
        public Calculator(int whichRec)
        {
            rec = whichRec;
            CalculatorReset();
        }

        //İşlemleri ifade eden sayılar
        public const int EXP = 1;
        public const int ROOT = 2;
        public const int CROSS = 3;
        public const int DIVISION = 4;
        public const int PLUS = 5;
        public const int MINUS = 6;

        //Hesap sınıfının ilk nesnesinde rec "0"a eşittir.
        //Ve ana hesabı o yapar.
        /// <summary>
        /// 
        /// </summary>
        private int rec;

        /// <summary>
        /// 
        /// </summary>
        private int whichNumber = 0;

        /// <summary>
        /// 
        /// </summary>
        private int whichOperation = 0;

        //Parantezleri sayan ve onu işlem önceliğine yazan değişken.
        /// <summary>
        /// 
        /// </summary>
        private int whichBracket = 0;

        /// <summary>
        /// 
        /// </summary>
        private int temporaryProcessingPriority = 0;

        /// <summary>
        /// Girilen son ifadenin işlem olup olmadığını kontrol eden boolean değişken
        /// </summary>
        private bool isHaveOperation = false;

        /// <summary>
        /// Girilen son ifadenin sayı olup olmadığını kontrol eden boolean değişken
        /// </summary>
        private bool isHaveNumber = false;

        /// <summary>
        /// Girilen sayının içinde virgül olup olmadığını kontrol eden boolean değişken
        /// </summary>
        private bool isHaveComma = false;

        /// <summary>
        /// Hesap sınıfının ilk kullanımı olduğunu henüz herhangi bir işlem yapılmadığını gösteren boolean değişken
        /// </summary>
        private bool isFirstStart = true;

        /// <summary>
        /// Sayının kendisinin "(-a)" halinde olup olmadığını kontrol eden boolean değişken
        /// </summary>
        private bool isHaveNegativeBracket = false;

        /// <summary>
        /// Sayı kontrol false halde iken bile işlem yapmaya yarayan boolean değer
        /// </summary>
        private bool isOperationHavePermit = false;


        //Geçici olarak kodu kullanabilmek için 100 değerini verdik. İleride dinamik dizi olarak kodlanıcak!
        /// <summary>
        /// 
        /// </summary>
        private bool[] isBracketsHaveOperation = new bool[100];
        

        /// <summary>
        /// 
        /// </summary>
        private List<double> memorizedNumbers = new List<double>();


        //Sayı kaç tane parantezin içinde onun tutulacağı list
        //İşlemlerin önceliği için (Not: İşleme tanımlanır, sayıya değil!)
        /// <summary>
        /// 
        /// </summary>
        private List<int> memorizedProcessPiority = new List<int>();


        /// <summary>
        /// 
        /// </summary>
        private List<int> memorizedOperations = new List<int>();


        /// <summary>
        /// Older types of calculators are usually used as a superset, after which an operation is performed and the operation before it, the line in which the number is read.
        /// </summary>
        private string operationScreen = "";

        /// <summary>
        /// Line in which the old type of calculator is generally used as a bottom line and the entered number is read before processing.
        /// </summary>
        private string resultScreen = "";

        /// <summary>
        /// This variable is updated before the process priority value changes each time.
        /// Default Value is True
        /// </summary>
        private bool wasEqualZeroTheTemporaryOperationPriorityInThePreviousStep = true;

        /// <summary>
        /// This variable is updated before the process priority value changes each time.
        /// Default Value is False
        /// </summary>
        private bool wasEqualTrueTheCriticalPointInThePreviousStep = false;

        private int theTotalHighestProcessPriorityInParenthesesGroup = 0;

        private int highestProcessPriorityInLastParanthesesGroup = 0;

        /// <summary>
        /// Displays the active rec button.
        /// </summary>
        public static string selectedRec = String.Empty;

        //ENCAPSULATİON------------------------------------------------------------------------

        /// <summary>
        /// Returns the value of the operation screen variable.
        /// Older types of calculators are usually used as a superset, after which an operation is performed and the operation before it, the line in which the number is read.
        /// </summary>
        public string OperationScreen
        {
            get
            {
                return operationScreen;
            }
        }


        /// <summary>
        /// sonuc_ekrani değişkeninin değerini döndürür.
        /// Eski tip hesap makinelerinin genelde alt satırı olarak kullanılan, girilen sayının işleme geçmeden okunduğu satır.
        /// </summary>
        public string ResultScreen
        {
            get
            {
                return resultScreen;
            }

        }

        public int Rec { get => rec;}
        public int WhichNumber { get => whichNumber;}
        public int WhichOperation { get => whichOperation;}
        public int WhichBracket { get => whichBracket;}
        public int TemporaryProcessingPriority { get => temporaryProcessingPriority;}
        public bool IsHaveOperation { get => isHaveOperation;}
        public bool IsHaveNumber { get => isHaveNumber;}
        public bool IsHaveComma { get => isHaveComma;}
        public bool IsFirstStart { get => isFirstStart;}
        public bool IsHaveNegativeBracket { get => isHaveNegativeBracket;}
        public bool IsOperationHavePermit { get => isOperationHavePermit;}
        public bool[] IsBracketsHaveOperation { get => isBracketsHaveOperation;}
        public List<double> MemorizedNumbers { get => memorizedNumbers;}
        public List<int> MemorizedProcessPiority { get => memorizedProcessPiority;}
        public List<int> MemorizedOperations { get => memorizedOperations;}

        //METHODS ----------------------------------------------------------------------------------

        /// <summary>
        /// Sonuç ekranındaki "(-a)" halindeki sayıyı "a" haline getirir.
        /// </summary>
        private void RemoveNegativeAndBracketsInResultScreen()
        {
            char[] tempChar = resultScreen.ToCharArray();

            //Eğer sayının başında eksi varsa
            if (resultScreen[0] == '(' && resultScreen[1] == '-')
            {
                int timer;
                for (timer = 2; timer < tempChar.Length - 1; timer++)
                {
                    //Sayının ilk rakamını al ve
                    if (timer == 2)
                    {
                        resultScreen = tempChar[timer].ToString();
                    }
                    //Devam eden rakamlarını yanına yaz
                    else
                    {
                        resultScreen += tempChar[timer].ToString();
                    }
                    //Bunun sonucunda "(-a)" halindeki "a" haline gelecek.
                    //Yeni değeri değişkene yaz.
                    isHaveNegativeBracket = false;
                }
            }
        }

        public static string DotNotationResultScreen(string resultScreen)
        {
            //ALGORTİMASI!
            // 0) SAYININ KENDİSİNİ AL (KENDİNDE EKSİ VARSA ONU ÇIKAR)
            // 1) VİRGÜLE KADAR OLAN SAYILARI AL
            // 2) SONDAN BAŞLAYARAK NOKTA YERLEŞTİR
            // 3) VİRGÜLDEN SONRA OLAN KISIMLA BİRLEŞTİREREK STRİNGE YAZ.
            // 4) SAYININ KENDİNDEN EKSİSİ VARSA ONU TEKRAR EKLE.

            bool isHaveSelfBracketing = IsHaveNumberSelfBracketing(resultScreen);
            string Number = String.Empty;

            if (isHaveSelfBracketing == true)
            {
                Number = NumberItselfAlwaysPositiveReturns(resultScreen);
            }
            else
            {
                Number = resultScreen;
            }

            string integerSection = String.Empty;
            string decimalSection = String.Empty;
            bool isHaveComma = IsHaveNumberComma(Number);
            integerSection = CommaFreeStateResultScreen(Number)[0];
            decimalSection = CommaFreeStateResultScreen(Number)[1];

            string integerSectionDotNotationInverted = String.Empty;
            string integerSectionDotNotation = String.Empty;
            char[] tempCharArray = integerSection.ToCharArray();
            int timer2 = 0;
            for (int timer = tempCharArray.Length-1; timer > -1; timer--)
            {
                if (timer == tempCharArray.Length-1)
                {
                    integerSectionDotNotationInverted = tempCharArray[timer].ToString();
                    timer2++;
                }
                else
                {
                    integerSectionDotNotationInverted += tempCharArray[timer].ToString();
                    timer2++;
                    if (timer2 % 3 == 0)
                    {
                        if (timer-1 != -1)
                        {
                            integerSectionDotNotationInverted += '.';
                        }
                    }
                }
            }

            for (int timer3 = integerSectionDotNotationInverted.Length - 1; timer3 > -1; timer3--)
            {
                if (timer3 == integerSectionDotNotationInverted.Length - 1)
                {
                    integerSectionDotNotation = integerSectionDotNotationInverted[timer3].ToString();
                }
                else
                {
                    integerSectionDotNotation += integerSectionDotNotationInverted[timer3].ToString();
                }
            }

            if (isHaveSelfBracketing == true)
            {
                if (isHaveComma == true)
                {
                    return "(-" + integerSectionDotNotation + "," + decimalSection + ")";
                }
                else
                {
                    return "(-" + integerSectionDotNotation + ")";
                }
            }
            else
            {
                if (isHaveComma == true)
                {
                    return integerSectionDotNotation + "," + decimalSection;
                }
                else
                {
                    return integerSectionDotNotation;
                }
            }
        }

        public static string[] CommaFreeStateResultScreen(string resultScreenNumberItSelf)
        {
            bool isHaveComma = false;
            int commaLocation = -1;
            char[] tempCharArray = resultScreenNumberItSelf.ToCharArray();
            string integerSection = String.Empty;
            string decimalSection = String.Empty;

            int timer = -1;
            foreach(char element in tempCharArray)
            {
                timer++;
                if (element == ',')
                {
                    commaLocation = timer;
                    isHaveComma = true;
                    break;
                }
            }

            for (int timer2 = 0; timer2 < (isHaveComma == true ? commaLocation : tempCharArray.Length); timer2++)
            {
                if (timer2 == 0)
                {
                    integerSection = tempCharArray[timer2].ToString();
                }
                else
                {
                    integerSection += tempCharArray[timer2].ToString();
                }
            }

            if (isHaveComma == true)
            {
                for (int timer3 = commaLocation + 1; timer3 < tempCharArray.Length; timer3++)
                {
                    if (timer3 == 1)
                    {
                        decimalSection = tempCharArray[timer3].ToString();
                    }
                    else
                    {
                        decimalSection += tempCharArray[timer3].ToString();
                    }
                }
            }

            string[] returns = new string[2];
            returns[0] = integerSection;
            returns[1] = isHaveComma == true ? decimalSection : String.Empty;
            return returns;


        }

        public static bool IsHaveNumberComma(string Number)
        {
            bool isHaveComma = false;
            int commaLocation = -1;
            char[] tempCharArray = Number.ToCharArray();
            string integerSection = String.Empty;
            string decimalSection = String.Empty;

            int timer = -1;
            foreach (char element in tempCharArray)
            {
                timer++;
                if (element == ',')
                {
                    commaLocation = timer;
                    isHaveComma = true;
                    break;
                }
            }
            return isHaveComma;
        }

        public static bool IsHaveNumberSelfBracketing(string Number)
        {
            char[] tempCharArray = Number.ToCharArray();
            // "(-a)" halindeki bir sayının kendisi "-a"dır. DİKKAT: "a" değil!
            //Sayının kendisindeki "-"den dolayı parantezi var mı?
            if (Number.Length > 2)
            {
                if (Number[0] == '(' && Number[1] == '-')
                {
                    return true;
                }
            }
            return false;
        }

        public static string NumberItself (string Number)
        {
            bool isHaveSelfBracketing = false;
            char[] tempCharArray = Number.ToCharArray();
            // "(-a)" halindeki bir sayının kendisi "-a"dır. DİKKAT: "a" değil!
            string numberItself = "";
            //Sayının kendisindeki "-"den dolayı parantezi var mı?
            if (Number.Length > 2)
            {
                if (Number[0] == '(' && Number[1] == '-')
                {
                    isHaveSelfBracketing = true;
                    int sayac;
                    for (sayac = 1; sayac < tempCharArray.Length - 1; sayac++)
                    {
                        if (sayac == 1)
                        {
                            numberItself = tempCharArray[sayac].ToString();
                        }
                        else
                        {
                            numberItself += tempCharArray[sayac].ToString();
                        }
                    }
                }
            }
            return isHaveSelfBracketing == true ? numberItself : Number;
        }

        public static string NumberItselfAlwaysPositiveReturns(string Number)
        {
            bool isHaveSelfBracketing = false;
            char[] tempCharArray = Number.ToCharArray();
            // "(-a)" halindeki bir sayının kendisi "-a"dır. DİKKAT: "a" değil!
            string numberItself = "";
            //Sayının kendisindeki "-"den dolayı parantezi var mı?
            if (Number.Length > 2)
            {
                if (Number[0] == '(' && Number[1] == '-')
                {
                    isHaveSelfBracketing = true;
                    int sayac;
                    for (sayac = 2; sayac < tempCharArray.Length - 1; sayac++)
                    {
                        if (sayac == 2)
                        {
                            numberItself = tempCharArray[sayac].ToString();
                        }
                        else
                        {
                            numberItself += tempCharArray[sayac].ToString();
                        }
                    }
                }
            }
            return isHaveSelfBracketing == true ? numberItself : Number;
        }
        /// <summary>
        /// The button used to enter numbers in the calculator.
        /// Enter a single digit (number) as a parameter.
        /// You can use the method repeatedly to write multiple-digit numbers.
        /// </summary>
        /// <param name="number">Is the number to be entered into the calculator, multi-step parameters can create problem please enter single-digit.</param>
        /// <returns>Returns the last state of the result screen.</returns>
        public string EnterNumber(int number)
        {
            //Eğer "0"a basıldı ise
            if (number == 0)
            {
                if (isHaveComma == true || isHaveNumber == true || isHaveOperation == true || isFirstStart == true)
                {
                    //Sadece sıfır yazıyorsa tekrardan sıfır eklememesi için
                    if (resultScreen != "0")
                    {
                        // Sayı "a" şeklindeyse
                        if (isHaveNegativeBracket == false)
                        {
                            resultScreen += "0";
                            isHaveNumber = true;
                            isHaveOperation = false;
                        }
                        //Sayı "(-a)" şeklindeyse
                        else
                        {
                            //Önce sayı "a" şekline getirilir.
                            //"(-a)" halindeki sayıyı "a" haline getirme işlemi (Başlangıç)
                            RemoveNegativeAndBracketsInResultScreen();
                            //"(-a)" halindeki sayıyı "a" haline getirme işlemi (Son)

                            //"0" sayının sonuna eklenir gerekli değişkenler ona göre değiştirilir.
                            resultScreen += "0";
                            isHaveNumber = true;
                            isHaveOperation = false;

                            // "a" halindeki sayıyı tekrar "(-a)" halibe getirme işlemi
                            resultScreen = "(-" + resultScreen + ")";
                            //Yeni değeri değişkene yaz.
                            isHaveNegativeBracket = true;
                        }
                    }
                }
                return resultScreen;
            }
            //Eğer "0"dan farklı bir rakama basıldı ise
            else
            {
                if (isHaveComma == true || isHaveNumber == true || isHaveOperation == true || isFirstStart == true)
                {
                    //Ekranda sadece 0 yazıyorsa sıfırı sil yeni sayıyı yaz.
                    if (resultScreen == "0")
                    {
                        resultScreen = number.ToString();
                    }
                    //Ekranda sadece 0 yazmıyorsa, yeni sayıyı ekranın sonuna ekle.
                    else
                    {
                        // Sayı "a" şeklindeyse
                        if (isHaveNegativeBracket == false)
                        {
                            resultScreen += number.ToString();
                            isHaveNumber = true;
                            isHaveOperation = false;
                        }
                        //Sayı "(-a)" şeklindeyse
                        else
                        {
                            //Önce sayı "a" şekline getirilir.
                            //"(-a)" halindeki sayıyı "a" haline getirme işlemi (Başlangıç)
                            RemoveNegativeAndBracketsInResultScreen();
                            //"(-a)" halindeki sayıyı "a" haline getirme işlemi (Son)

                            //"0" sayının sonuna eklenir gerekli değişkenler ona göre değiştirilir.
                            resultScreen += number.ToString();
                            isHaveNumber = true;
                            isHaveOperation = false;
                            // "a" halindeki sayıyı tekrar "(-a)" halibe getirme işlemi
                            resultScreen = "(-" + resultScreen + ")";
                            //Yeni değeri değişkene yaz.
                            isHaveNegativeBracket = true;
                        }
                    }
                }
                return resultScreen;
            }
        }


        /// <summary>
        /// Negative-Positive converter for UI.
        /// </summary>
        /// <returns>Returns result screen</returns>
        public string PositiveNegativeButton()
        {
            char[] GeciciChar = resultScreen.ToCharArray();

            //Hiç sayı yok ise eksi koymaması için
            //Eğer sayı yoksa
            if (resultScreen.Length == 0)
            {

            }
            //Eğer sayı varsa
            else
            {
                //Eğer sayının başında eksi varsa
                if (resultScreen[0] == '(' && resultScreen[1] == '-')
                {
                    int sayac;
                    for (sayac = 2; sayac < GeciciChar.Length - 1; sayac++)
                    {
                        //Sayının ilk rakamını al ve
                        if (sayac == 2)
                        {
                            resultScreen = GeciciChar[sayac].ToString();
                        }
                        //Devam eden rakamlarını yanına yaz
                        else
                        {
                            resultScreen += GeciciChar[sayac].ToString();
                        }
                        //Bunun sonucunda "(-a)" halindeki "a" haline gelecek.
                        //Yeni değeri değişkene yaz.
                        isHaveNegativeBracket = false;

                    }
                }
                //Eğer sayının başında eksi yoksa
                else
                {
                    // "a" halindeki sayıyı "(-a)" halibe getir.
                    resultScreen = "(-" + resultScreen + ")";
                    //Yeni değeri değişkene yaz.
                    isHaveNegativeBracket = true;
                }
            }
            return resultScreen;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string CommaButton()
        {
            bool isHaveSelfBracking = IsHaveNumberSelfBracketing(resultScreen);
            if ((isHaveNumber == true || isHaveOperation == true || isFirstStart == true) && isHaveComma == false)
            {
                if (isHaveSelfBracking == true)
                {
                    string tempResultScreen = NumberItself(resultScreen);
                    tempResultScreen += ",";
                    resultScreen = "(" + tempResultScreen + ")"; 
                    isHaveComma = true;
                    isHaveNumber = false;
                }
                else
                {
                    if (isHaveNumber == false)
                    {
                        resultScreen += "0,";
                        isHaveComma = true;
                        isHaveNumber = false;
                    }
                    else
                    {
                        resultScreen += ",";
                        isHaveComma = true;
                        isHaveNumber = false;
                    }
                }

            }
            return resultScreen;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string BracketOpenButton()
        {
            if (isHaveOperation == true && isHaveNumber == false || IsFirstStart == true)
            {
                //İSLEM NOKTASI
                if (temporaryProcessingPriority == 0 && wasEqualZeroTheTemporaryOperationPriorityInThePreviousStep == false)
                {
                    theTotalHighestProcessPriorityInParenthesesGroup += highestProcessPriorityInLastParanthesesGroup;
                    highestProcessPriorityInLastParanthesesGroup = 0;
                    whichBracket += theTotalHighestProcessPriorityInParenthesesGroup;
                }
                wasEqualZeroTheTemporaryOperationPriorityInThePreviousStep = temporaryProcessingPriority == 0 ? true : false;
                wasEqualTrueTheCriticalPointInThePreviousStep = temporaryProcessingPriority == 0 && wasEqualZeroTheTemporaryOperationPriorityInThePreviousStep == false ? true : false;
                temporaryProcessingPriority += 1;
                whichBracket ++;
                highestProcessPriorityInLastParanthesesGroup++;
                operationScreen += " ( ";
            }
            //FOR DEBUG
            Console.WriteLine("Which bracket now " + whichBracket);
            return operationScreen;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string BracketCloseButton()
        {
            //Parantezin içinde sadece sayı varsa parantezin kapatılamaması için.
            if (temporaryProcessingPriority > 0 && isHaveOperation == false && isBracketsHaveOperation[whichBracket] == true)
            {
                if (isHaveNumber == true)
                {
                    //Sayıyı hafızaya ekleme bölümü
                    memorizedNumbers.Add(Convert.ToDouble(NumberItself(resultScreen)));
                }

                //Sayıların kaydedileceği hafıza gözü bir sonraki işlemde arttırılacağı için burada arttırılmıyor.

                operationScreen += resultScreen;
                resultScreen = "";
                operationScreen += " ) ";

                wasEqualZeroTheTemporaryOperationPriorityInThePreviousStep = temporaryProcessingPriority == 0;
                wasEqualTrueTheCriticalPointInThePreviousStep = temporaryProcessingPriority == 0 && wasEqualZeroTheTemporaryOperationPriorityInThePreviousStep == false;

                //Parantez kapandıktan sonra bütün değerler false olduğu için yeni işlemin yapılmasına olanak sağlayan izin.
                isOperationHavePermit = true;
                isHaveNumber = false;
                isHaveComma = false;
                isHaveOperation = false;
                temporaryProcessingPriority -= 1;
                whichBracket--;

                //ALGORİTMA NOTLARINDAKİ KRİTİK NOKTA!!
                // (io_sifir == true && io_adim2_sifirdanfarkli == false) = (kritik_nokta == true)
                if (temporaryProcessingPriority == 0 && wasEqualZeroTheTemporaryOperationPriorityInThePreviousStep == false)
                {
                    whichBracket = 0;
                }
            }
            //FOR DEBUG
            Console.WriteLine("Which bracket now " + whichBracket);
            return operationScreen;
        }


        /// <summary>
        /// Delete from result screen string on minimum character size
        /// </summary>
        /// <returns>Error Code in ErrorEnumerators Class</returns>
        private ErrorEnumerators DeleteOneResultScreenString()
        {
            //Sayı "(-a)" şeklindeyse silme işlemi yapılabilmesi için önce sayı "a" haline getirilir.
            //Sonra sayı sayıdan silme işlemi yapılır.
            //Ve sayı tekrar "(-a)" haline döndürülür.
            if (isHaveNegativeBracket == true)
            {
                //Eğer parantezin içinde sadece bir rakam kaldı ise
                if (resultScreen[0] == '(' && resultScreen[1] == '-' && resultScreen[3] == ')')
                {
                    //Dört kere dört kere sil.
                    // Örn: (-7) yazıyor ise sil tuşuna basıldığında hepsini silecek.
                    for (int x = 1; x < 5; x++)
                    {
                        //Silme işlemi (Başlangıç)
                        char[] CharEkran = resultScreen.ToCharArray();
                        string YeniYazı = null;
                        //MessageBox.Show(Convert.ToString(txtEkran.Text.Length));
                        //MessageBox.Show(Convert.ToString(CharEkran[txtEkran.Text.Length-1]));
                        if (resultScreen.Length != 0)
                        {
                            //Virgül silindiyse eğer virgülkontrolü false yap.
                            if (CharEkran[resultScreen.Length - 1] == ',')
                            {
                                isHaveComma = false;
                                if (resultScreen != "")
                                {
                                    isHaveNumber = true;
                                }
                            }

                            //Son karakteri silme işlemi
                            CharEkran[(resultScreen.Length - 1)] = '\0';
                            //Son karakteri silinen char dizisini sitringe yazma
                            for (int sayac = 0; sayac < resultScreen.Length - 1; sayac++)
                            {
                                if (sayac == 0)
                                {
                                    YeniYazı = Convert.ToString(CharEkran[sayac]);
                                }
                                else
                                {
                                    YeniYazı += Convert.ToString(CharEkran[sayac]);
                                }
                            }
                            resultScreen = YeniYazı;

                            if (resultScreen == null)
                            {
                                resultScreen = "";
                            }

                            //Eğer herşeyi silmediysen
                            //Virgülden sonraki rakamların hepsi silindi ise sayıkontrolü false yap.
                            if (resultScreen.Length != 0)
                            {
                                if (CharEkran[(resultScreen.Length - 1)] == ',')
                                {
                                    isHaveNumber = false;
                                }
                            }
                            //Silinecek sayı kalmadıysa sayı kontrolu false ve islem kontrolu true yap.
                            if (resultScreen == "")
                            {
                                isHaveNumber = false;
                                if (operationScreen != "")
                                {
                                    isHaveOperation = true;
                                }
                                else
                                {
                                    isHaveOperation = false;
                                    isFirstStart = true;
                                }
                            }
                        }
                        else
                        {
                            return ErrorEnumerators.NUMBER_NOT_FOUND;
                        }
                        //Silme işlemi (Son)
                    }
                    isHaveNegativeBracket = false;
                }
                else
                {
                    //"(-a)" halindeki sayıyı "a" haline getirme işlemi (Başlangıç)
                    char[] GeciciChar = resultScreen.ToCharArray();

                    //Eğer sayının başında eksi varsa
                    if (resultScreen[0] == '(' && resultScreen[1] == '-')
                    {
                        int sayac;
                        for (sayac = 2; sayac < GeciciChar.Length - 1; sayac++)
                        {
                            //Sayının ilk rakamını al ve
                            if (sayac == 2)
                            {
                                resultScreen = GeciciChar[sayac].ToString();
                            }
                            //Devam eden rakamlarını yanına yaz
                            else
                            {
                                resultScreen += GeciciChar[sayac].ToString();
                            }
                            //Bunun sonucunda "(-a)" halindeki "a" haline gelecek.
                            //Yeni değeri değişkene yaz.
                            isHaveNegativeBracket = false;

                        }
                    }
                    //"(-a)" halindeki sayıyı "a" haline getirme işlemi (Son)

                    //Silme işlemi (Başlangıç)
                    char[] CharEkran = resultScreen.ToCharArray();
                    string YeniYazı = null;
                    //MessageBox.Show(Convert.ToString(txtEkran.Text.Length));
                    //MessageBox.Show(Convert.ToString(CharEkran[txtEkran.Text.Length-1]));
                    if (resultScreen.Length != 0)
                    {
                        //Virgül silindiyse eğer virgülkontrolü false yap.
                        if (CharEkran[resultScreen.Length - 1] == ',')
                        {
                            isHaveComma = false;
                            if (resultScreen != "")
                            {
                                isHaveNumber = true;
                            }
                        }

                        //Son karakteri silme işlemi
                        CharEkran[(resultScreen.Length - 1)] = '\0';
                        //Son karakteri silinen char dizisini sitringe yazma
                        for (int sayac = 0; sayac < resultScreen.Length - 1; sayac++)
                        {
                            if (sayac == 0)
                            {
                                YeniYazı = Convert.ToString(CharEkran[sayac]);
                            }
                            else
                            {
                                YeniYazı += Convert.ToString(CharEkran[sayac]);
                            }
                        }
                        resultScreen = YeniYazı;

                        if (resultScreen == null)
                        {
                            resultScreen = "";
                        }

                        //Eğer herşeyi silmediysen
                        //Virgülden sonraki rakamların hepsi silindi ise sayıkontrolü false yap.
                        if (resultScreen.Length != 0)
                        {
                            if (CharEkran[(resultScreen.Length - 1)] == ',')
                            {
                                isHaveNumber = false;
                            }
                        }
                        //Silinecek sayı kalmadıysa sayı kontrolu false ve islem kontrolu true yap.
                        if (resultScreen == "")
                        {
                            isHaveNumber = false;
                            if (resultScreen != "")
                            {
                                isHaveOperation = true;
                            }
                            else
                            {
                                isHaveOperation = false;
                                isFirstStart = true;
                            }
                        }
                    }
                    else
                    {
                        return ErrorEnumerators.NUMBER_NOT_FOUND;
                    }
                    //Silme işlemi (Son)

                    // "a" halindeki sayıyı "(-a)" halibe getirme işlemi
                    resultScreen = "(-" + resultScreen + ")";
                    //Yeni değeri değişkene yaz.
                    isHaveNegativeBracket = true;
                }
            }
            else
            {
                char[] CharEkran = resultScreen.ToCharArray();
                string YeniYazı = null;
                //MessageBox.Show(Convert.ToString(txtEkran.Text.Length));
                //MessageBox.Show(Convert.ToString(CharEkran[txtEkran.Text.Length-1]));
                if (resultScreen.Length != 0)
                {
                    //Virgül silindiyse eğer virgülkontrolü false yap.
                    if (CharEkran[resultScreen.Length - 1] == ',')
                    {
                        isHaveComma = false;
                        if (resultScreen != "")
                        {
                            isHaveNumber = true;
                        }
                    }

                    //Son karakteri silme işlemi
                    CharEkran[(resultScreen.Length - 1)] = '\0';
                    //Son karakteri silinen char dizisini sitringe yazma
                    for (int sayac = 0; sayac < resultScreen.Length - 1; sayac++)
                    {
                        if (sayac == 0)
                        {
                            YeniYazı = Convert.ToString(CharEkran[sayac]);
                        }
                        else
                        {
                            YeniYazı += Convert.ToString(CharEkran[sayac]);
                        }
                    }
                    resultScreen = YeniYazı;

                    if (resultScreen == null)
                    {
                        resultScreen = "";
                    }

                    //Eğer herşeyi silmediysen
                    //Virgülden sonraki rakamların hepsi silindi ise sayıkontrolü false yap.
                    if (resultScreen.Length != 0)
                    {
                        if (CharEkran[(resultScreen.Length - 1)] == ',')
                        {
                            isHaveNumber = false;
                        }
                    }
                    //Silinecek sayı kalmadıysa sayı kontrolu false ve islem kontrolu true yap.
                    if (resultScreen == "")
                    {
                        isHaveNumber = false;
                        if (operationScreen != "")
                        {
                            isHaveOperation = true;
                        }
                        else
                        {
                            isHaveOperation = false;
                            isFirstStart = true;
                        }
                    }
                }
                else
                {
                    return ErrorEnumerators.NUMBER_NOT_FOUND;
                }
            }
            return ErrorEnumerators.SUCCESSFUL;
        }


        /// <summary>
        /// Delete from operation screen string on minimum character size
        /// </summary>
        /// <returns>Error Code in ErrorEnumerators Class</returns>
        private ErrorEnumerators DeleteOneOperationScreenString()
        {
            char[] CharHesap = operationScreen.ToCharArray();
            string YenitxtHesap = null;

            if (operationScreen.Length != 0)
            {
                if (CharHesap[operationScreen.Length - 1] == ',')
                {
                    isHaveComma = false;
                }

                CharHesap[(operationScreen.Length - 1)] = '\0';
                for (int sayac = 0; sayac < operationScreen.Length - 1; sayac++)
                {
                    if (sayac == 0)
                    {
                        YenitxtHesap = Convert.ToString(CharHesap[sayac]);
                    }
                    else
                    {
                        YenitxtHesap += Convert.ToString(CharHesap[sayac]);
                    }
                }
                operationScreen = YenitxtHesap;
                return ErrorEnumerators.SUCCESSFUL;
            }
            else
            {
                return ErrorEnumerators.NUMBER_NOT_FOUND;
            }
        }


        /// <summary>
        /// Plus Operator for UI
        /// </summary>
        /// <returns>Returns operatorScreen</returns>
        public string PlusButton()
        {
            bool kendindenparantez = false;
            char[] GeciciChar = resultScreen.ToCharArray();
            string sayınınkendisi = "";
            //Sayının kendisindeki "-"den dolayı parantezi var mı?
            if (resultScreen.Length > 2)
            {
                if (resultScreen[0] == '(' && resultScreen[1] == '-')
                {
                    //Parentezi olan sayının kendisini ortaya çıkarma (Sadece parantez kalkar sayının başındaki eksi durur.
                    kendindenparantez = true;
                    int sayac;
                    for (sayac = 1; sayac < GeciciChar.Length - 1; sayac++)
                    {
                        if (sayac == 1)
                        {
                            sayınınkendisi = GeciciChar[sayac].ToString();
                        }
                        else
                        {
                            sayınınkendisi += GeciciChar[sayac].ToString();
                        }
                    }
                }
            }

            //Farklı bir işlem yoksa veya parantez yeni kapatıldığı için işlem izni varsa.
            if ((isHaveNumber == true && isHaveOperation == false) || isOperationHavePermit == true)
            {
                //Sonuç kısmı islem_izni olduğunda boş olur
                //Sonuç kısmı boşken işlemlerin hafızaya eklenmeye çalışılması hata oluşturacağı için.
                if (isOperationHavePermit == false)
                {
                    //Sayıyı hafızaya ekleme bölümü
                    if (kendindenparantez == false)
                        memorizedNumbers.Add(Convert.ToDouble(resultScreen));
                    if (kendindenparantez == true)
                        memorizedNumbers.Add(Convert.ToDouble(sayınınkendisi));
                    whichNumber++;
                }

                //İşlemleri hafızaya ekleme bölümü
                memorizedOperations.Add(PLUS);
                memorizedProcessPiority.Add(temporaryProcessingPriority);
                whichOperation++;

                operationScreen += resultScreen;
                resultScreen = "";
                operationScreen += " + ";
                isHaveNumber = false;
                isHaveComma = false;
                isHaveNegativeBracket = false;
                isHaveOperation = true;
                isFirstStart = false;
                isOperationHavePermit = false;

                //Aynı parantez içindeki işlem kontrolü
                if (temporaryProcessingPriority > 0)
                {
                    //İşlem önceliği 1 iken, parantez_islem_iceriyor_mu dizisinin 0. değişkeni kullanılır.
                    //Her zaman parantez_islem_iceriyor_mu dizisinin ilgili olduğu değişkenin hafızadaki yeri
                    //gecici islem önceliği değişkenin gösterdiği değerin bir altıdır.
                    isBracketsHaveOperation[whichBracket] = true;
                }
            }
            //Farklı bir işlem varsa (Son işlem değiştirilir.)
            else if (isHaveNumber == false && isHaveOperation == true)
            {
                memorizedOperations[whichOperation - 1] = PLUS;

                //ESKİ İŞLEMİ SİLME
                DeleteOneOperationScreenString();
                DeleteOneOperationScreenString();
                DeleteOneOperationScreenString();

                operationScreen += " + ";
                isHaveNumber = false;
                isHaveComma = false;
                isHaveNegativeBracket = false;
                isHaveOperation = true;
                isFirstStart = false;

                //Aynı parantez içindeki işlem kontrolü
                if (temporaryProcessingPriority > 0)
                {
                    //İşlem önceliği 1 iken, parantez_islem_iceriyor_mu dizisinin 0. değişkeni kullanılır.
                    //Her zaman parantez_islem_iceriyor_mu dizisinin ilgili olduğu değişkenin hafızadaki yeri
                    //gecici islem önceliği değişkenin gösterdiği değerin bir altıdır.
                    isBracketsHaveOperation[temporaryProcessingPriority - 1] = true;
                }
            }
            return operationScreen;
        }


        /// <summary>
        /// Minus Operator for UI
        /// </summary>
        /// <returns>Returns operatorScreen</returns>
        public string MinusButton()
        {
            bool kendindenparantez = false;
            char[] GeciciChar = resultScreen.ToCharArray();
            string sayınınkendisi = "";
            //Sayının kendisindeki "-"den dolayı parantezi var mı?
            if (resultScreen.Length > 2)
            {
                if (resultScreen[0] == '(' && resultScreen[1] == '-')
                {
                    //Sayı "(-a)" şeklindeyse değişkeni true yap.
                    kendindenparantez = true;
                    //Parentezi olan sayının kendisini ortaya çıkarma (Sadece parantez kalkar sayının başındaki eksi durur.
                    int sayac;
                    for (sayac = 1; sayac < GeciciChar.Length - 1; sayac++)
                    {
                        if (sayac == 1)
                        {
                            sayınınkendisi = GeciciChar[sayac].ToString();
                        }
                        else
                        {
                            sayınınkendisi += GeciciChar[sayac].ToString();
                        }
                    }
                }
            }

            //Farklı bir işlem yoksa veya parantez yeni kapatıldığı için işlem izni varsa.
            if ((isHaveNumber == true && isHaveOperation == false) || isOperationHavePermit == true)
            {

                //Sonuç kısmı islem_izni olduğunda boş olur
                //Sonuç kısmı boşken işlemlerin hafızaya eklenmeye çalışılması hata oluşturacağı için.
                if (isOperationHavePermit == false)
                {
                    //Sayıyı hafızaya ekleme bölümü
                    if (kendindenparantez == false)
                        memorizedNumbers.Add(Convert.ToDouble(resultScreen));
                    if (kendindenparantez == true)
                        memorizedNumbers.Add(Convert.ToDouble(sayınınkendisi));
                    whichNumber++;
                }

                //İşlemleri hafızaya ekleme bölümü
                memorizedOperations.Add(MINUS);
                memorizedProcessPiority.Add(temporaryProcessingPriority);
                whichOperation++;

                operationScreen += resultScreen;
                resultScreen = "";
                operationScreen += " - ";
                isHaveNumber = false;
                isHaveComma = false;
                isHaveNegativeBracket = false;
                isHaveOperation = true;
                isFirstStart = false;
                isOperationHavePermit = false;

                //Aynı parantez içindeki işlem kontrolü
                if (temporaryProcessingPriority > 0)
                {
                    //İşlem önceliği 1 iken, parantez_islem_iceriyor_mu dizisinin 0. değişkeni kullanılır.
                    //Her zaman parantez_islem_iceriyor_mu dizisinin ilgili olduğu değişkenin hafızadaki yeri
                    //gecici islem önceliği değişkenin gösterdiği değerin bir altıdır.
                    isBracketsHaveOperation[whichBracket] = true;
                }
            }
            //Farklı bir işlem varsa (Son işlem değiştirilir.)
            else if (isHaveNumber == false && isHaveOperation == true)
            {
                memorizedOperations[whichOperation - 1] = MINUS;

                //ESKİ İŞLEMİ SİLME
                DeleteOneOperationScreenString();
                DeleteOneOperationScreenString();
                DeleteOneOperationScreenString();

                operationScreen += " - ";
                isHaveNumber = false;
                isHaveComma = false;
                isHaveNegativeBracket = false;
                isHaveOperation = true;
                isFirstStart = false;

                //Aynı parantez içindeki işlem kontrolü
                if (temporaryProcessingPriority > 0)
                {
                    //İşlem önceliği 1 iken, parantez_islem_iceriyor_mu dizisinin 0. değişkeni kullanılır.
                    //Her zaman parantez_islem_iceriyor_mu dizisinin ilgili olduğu değişkenin hafızadaki yeri
                    //gecici islem önceliği değişkenin gösterdiği değerin bir altıdır.
                    isBracketsHaveOperation[whichBracket] = true;
                }
            }
            return operationScreen;
        }

        /// <summary>
        /// Cross Operator for UI
        /// </summary>
        /// <returns>Returns operatorScreen</returns>
        public string CrossButton()
        {
            bool kendindenparantez = false;
            char[] GeciciChar = resultScreen.ToCharArray();
            string sayınınkendisi = "";
            //Sayının kendisindeki "-"den dolayı parantezi var mı?
            if (resultScreen.Length > 2)
            {
                if (resultScreen[0] == '(' && resultScreen[1] == '-')
                {
                    //Sayı "(-a)" şeklindeyse değişkeni true yap.
                    kendindenparantez = true;
                    //Parentezi olan sayının kendisini ortaya çıkarma (Sadece parantez kalkar sayının başındaki eksi durur.
                    int sayac;
                    for (sayac = 1; sayac < GeciciChar.Length - 1; sayac++)
                    {
                        if (sayac == 1)
                        {
                            sayınınkendisi = GeciciChar[sayac].ToString();
                        }
                        else
                        {
                            sayınınkendisi += GeciciChar[sayac].ToString();
                        }
                    }
                }
            }

            //Farklı bir işlem yoksa veya parantez yeni kapatıldığı için işlem izni varsa.
            if ((isHaveNumber == true && isHaveOperation == false) || isOperationHavePermit == true)
            {

                //Sonuç kısmı islem_izni olduğunda boş olur
                //Sonuç kısmı boşken işlemlerin hafızaya eklenmeye çalışılması hata oluşturacağı için.
                if (isOperationHavePermit == false)
                {
                    //Sayıyı hafızaya ekleme bölümü
                    if (kendindenparantez == false)
                        memorizedNumbers.Add(Convert.ToDouble(resultScreen));
                    if (kendindenparantez == true)
                        memorizedNumbers.Add(Convert.ToDouble(sayınınkendisi));
                    whichNumber++;
                }

                //İşlemleri hafızaya ekleme bölümü
                memorizedOperations.Add(CROSS);
                memorizedProcessPiority.Add(temporaryProcessingPriority);
                whichOperation++;

                operationScreen += resultScreen;
                resultScreen = "";
                operationScreen += " * ";
                isHaveNumber = false;
                isHaveComma = false;
                isHaveNegativeBracket = false;
                isHaveOperation = true;
                isFirstStart = false;
                isOperationHavePermit = false;

                //Aynı parantez içindeki işlem kontrolü
                if (temporaryProcessingPriority > 0)
                {
                    //İşlem önceliği 1 iken, parantez_islem_iceriyor_mu dizisinin 0. değişkeni kullanılır.
                    //Her zaman parantez_islem_iceriyor_mu dizisinin ilgili olduğu değişkenin hafızadaki yeri
                    //gecici islem önceliği değişkenin gösterdiği değerin bir altıdır.
                    isBracketsHaveOperation[whichBracket] = true;
                }
            }
            //Farklı bir işlem varsa (Son işlem değiştirilir.)
            else if (isHaveNumber == false && isHaveOperation == true)
            {
                memorizedOperations[whichOperation - 1] = CROSS;

                //ESKİ İŞLEMİ SİLME
                DeleteOneOperationScreenString();
                DeleteOneOperationScreenString();
                DeleteOneOperationScreenString();

                operationScreen += " * ";
                isHaveNumber = false;
                isHaveComma = false;
                isHaveNegativeBracket = false;
                isHaveOperation = true;
                isFirstStart = false;

                //Aynı parantez içindeki işlem kontrolü
                if (temporaryProcessingPriority > 0)
                {
                    //İşlem önceliği 1 iken, parantez_islem_iceriyor_mu dizisinin 0. değişkeni kullanılır.
                    //Her zaman parantez_islem_iceriyor_mu dizisinin ilgili olduğu değişkenin hafızadaki yeri
                    //gecici islem önceliği değişkenin gösterdiği değerin bir altıdır.
                    isBracketsHaveOperation[whichBracket] = true;
                }
            }
            return operationScreen;
        }

        /// <summary>
        /// Division Operator for UI
        /// </summary>
        /// <returns>Returns operatorScreen</returns>
        public string DivisionButton()
        {
            bool kendindenparantez = false;
            char[] GeciciChar = resultScreen.ToCharArray();
            string sayınınkendisi = "";
            //Sayının kendisindeki "-"den dolayı parantezi var mı?
            if (resultScreen.Length > 2)
            {
                if (resultScreen[0] == '(' && resultScreen[1] == '-')
                {
                    //Sayı "(-a)" şeklindeyse değişkeni true yap.
                    kendindenparantez = true;
                    //Parentezi olan sayının kendisini ortaya çıkarma (Sadece parantez kalkar sayının başındaki eksi durur.
                    int sayac;
                    for (sayac = 1; sayac < GeciciChar.Length - 1; sayac++)
                    {
                        if (sayac == 1)
                        {
                            sayınınkendisi = GeciciChar[sayac].ToString();
                        }
                        else
                        {
                            sayınınkendisi += GeciciChar[sayac].ToString();
                        }
                    }
                }
            }

            //Farklı bir işlem yoksa veya parantez yeni kapatıldığı için işlem izni varsa.
            if ((isHaveNumber == true && isHaveOperation == false) || isOperationHavePermit == true)
            {

                //Sonuç kısmı islem_izni olduğunda boş olur
                //Sonuç kısmı boşken işlemlerin hafızaya eklenmeye çalışılması hata oluşturacağı için.
                if (isOperationHavePermit == false)
                {
                    //Sayıyı hafızaya ekleme bölümü
                    if (kendindenparantez == false)
                        memorizedNumbers.Add(Convert.ToDouble(resultScreen));
                    if (kendindenparantez == true)
                        memorizedNumbers.Add(Convert.ToDouble(sayınınkendisi));
                    whichNumber++;
                }

                //İşlemleri hafızaya ekleme bölümü
                memorizedOperations.Add(DIVISION);
                memorizedProcessPiority.Add(temporaryProcessingPriority);
                whichOperation++;

                operationScreen += resultScreen;
                resultScreen = "";
                operationScreen += " / ";
                isHaveNumber = false;
                isHaveComma = false;
                isHaveNegativeBracket = false;
                isHaveOperation = true;
                isFirstStart = false;
                isOperationHavePermit = false;

                //Aynı parantez içindeki işlem kontrolü
                if (temporaryProcessingPriority > 0)
                {
                    //İşlem önceliği 1 iken, parantez_islem_iceriyor_mu dizisinin 0. değişkeni kullanılır.
                    //Her zaman parantez_islem_iceriyor_mu dizisinin ilgili olduğu değişkenin hafızadaki yeri
                    //gecici islem önceliği değişkenin gösterdiği değerin bir altıdır.
                    isBracketsHaveOperation[whichBracket] = true;
                }
            }
            //Farklı bir işlem varsa (Son işlem değiştirilir.)
            else if (isHaveNumber == false && isHaveOperation == true)
            {
                memorizedOperations[whichOperation - 1] = DIVISION;

                //ESKİ İŞLEMİ SİLME
                DeleteOneOperationScreenString();
                DeleteOneOperationScreenString();
                DeleteOneOperationScreenString();

                operationScreen += " / ";
                isHaveNumber = false;
                isHaveComma = false;
                isHaveNegativeBracket = false;
                isHaveOperation = true;
                isFirstStart = false;

                //Aynı parantez içindeki işlem kontrolü
                if (temporaryProcessingPriority > 0)
                {
                    //İşlem önceliği 1 iken, parantez_islem_iceriyor_mu dizisinin 0. değişkeni kullanılır.
                    //Her zaman parantez_islem_iceriyor_mu dizisinin ilgili olduğu değişkenin hafızadaki yeri
                    //gecici islem önceliği değişkenin gösterdiği değerin bir altıdır.
                    isBracketsHaveOperation[whichBracket] = true;
                }
            }
            return operationScreen;
        }

        /// <summary>
        /// Delete Button for UI
        /// Delete a character from the result screen
        /// </summary>
        /// <returns>Result Screen</returns>
        public string DeleteButton()
        {
            ErrorEnumerators CONTROL = new ErrorEnumerators();
            CONTROL = DeleteOneResultScreenString();
            if (CONTROL != ErrorEnumerators.SUCCESSFUL)
            {
                Exception DeleteException = new Exception(selectedRec + " Result Screen is null so can not delete it again");
                throw DeleteException;
            }
            return ResultScreen;
        }

        /// <summary>
        /// Reset the default value in calculator class non-static variable
        /// </summary>
        public void CalculatorReset()
        {
            whichNumber = 0;
            whichOperation = 0;

            isHaveOperation = false;
            isHaveNumber = false;
            isHaveComma = false;
            isFirstStart = true;
            isHaveNegativeBracket = false;
            isOperationHavePermit = false;
            wasEqualZeroTheTemporaryOperationPriorityInThePreviousStep = true;
            wasEqualTrueTheCriticalPointInThePreviousStep = false;
            theTotalHighestProcessPriorityInParenthesesGroup = 0;
            highestProcessPriorityInLastParanthesesGroup = 0;

            operationScreen = "";
            resultScreen = "";

            for (int timer = 0; timer < isBracketsHaveOperation.Length; timer++)
            {
                isBracketsHaveOperation[timer] = false;
            }


            //The variable that counts parentheses and writes it to the process priority.
            temporaryProcessingPriority = 0;

            //Clearing all elements from lists
            memorizedProcessPiority.Clear();
            memorizedNumbers.Clear();
            memorizedOperations.Clear();

        }

    }
}
