using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GelismisHesapMakinesi
{
    public partial class Form1 : Form

    {
        private char _islem; // + , - , * , / işlemlerinin hangisine bastığını hafızada tutmaya yarayan char
        private bool _EkranTemizleme; // ekran temizlensin mi? (evet / hayır)
        private double _ilkSayi;         // ekrana girilen ilk sayıyı hafızada tutan int  
        


        public Form1()
        {
            InitializeComponent();
        }

        private void BirButton_Click(object sender, EventArgs e)
        {
            if (_EkranTemizleme)
            {
                EkranLabel.Text = " "; // ekran temizleme doğru ise ekranı temizle. (Bunu yapmamızın sebebi bir işarete bastığımızda ekranı temizlesin)
                _EkranTemizleme = false; // Bunu yapmamızın sebebi sayıya bastığımızda bir daha ekranı silmesin diye.
            }

            if (EkranLabel.Text == "0") // ekranda 0 varsa siler.
                EkranLabel.Text = " ";

            EkranLabel.Text += "1";
        }

        private void ikiButton_Click(object sender, EventArgs e)
        {
            if (_EkranTemizleme)
            {
                EkranLabel.Text = " "; // ekran temizleme doğru ise ekranı temizle. (Bunu yapmamızın sebebi bir işarete bastığımızda ekranı temizlesin)
                _EkranTemizleme = false; // Bunu yapmamızın sebebi sayıya bastığımızda bir daha ekranı silmesin diye.
            }

            if (EkranLabel.Text == "0")
                EkranLabel.Text = " ";

            EkranLabel.Text += "2";
        }

        private void UcButton_Click(object sender, EventArgs e)
        {
            if (_EkranTemizleme)
            {
                EkranLabel.Text = " "; // ekran temizleme doğru ise ekranı temizle. (Bunu yapmamızın sebebi bir işarete bastığımızda ekranı temizlesin)
                _EkranTemizleme = false; // Bunu yapmamızın sebebi sayıya bastığımızda bir daha ekranı silmesin diye.
            }
            if (EkranLabel.Text == "0")
                EkranLabel.Text = " ";

            EkranLabel.Text += "3";
        }

        private void DortButton_Click(object sender, EventArgs e)
        {
            if (_EkranTemizleme)
            {
                EkranLabel.Text = " "; // ekran temizleme doğru ise ekranı temizle. (Bunu yapmamızın sebebi bir işarete bastığımızda ekranı temizlesin)
                _EkranTemizleme = false; // Bunu yapmamızın sebebi sayıya bastığımızda bir daha ekranı silmesin diye.
            }
            if (EkranLabel.Text == "0")
                EkranLabel.Text = " ";

            EkranLabel.Text += "4";
        }

        private void BesButton_Click(object sender, EventArgs e)
        {
            if (_EkranTemizleme)
            {
                EkranLabel.Text = " "; // ekran temizleme doğru ise ekranı temizle. (Bunu yapmamızın sebebi bir işarete bastığımızda ekranı temizlesin)
                _EkranTemizleme = false; // Bunu yapmamızın sebebi sayıya bastığımızda bir daha ekranı silmesin diye.
            }
            if (EkranLabel.Text == "0")
                EkranLabel.Text = " ";

            EkranLabel.Text += "5";
        }

        private void AltiButton_Click(object sender, EventArgs e)
        {
            if (_EkranTemizleme)
            {
                EkranLabel.Text = " "; // ekran temizleme doğru ise ekranı temizle. (Bunu yapmamızın sebebi bir işarete bastığımızda ekranı temizlesin)
                _EkranTemizleme = false; // Bunu yapmamızın sebebi sayıya bastığımızda bir daha ekranı silmesin diye.
            }
            if (EkranLabel.Text == "0")
                EkranLabel.Text = " ";

            EkranLabel.Text += "6";
        }

        private void YediButton_Click(object sender, EventArgs e)
        {
            if (_EkranTemizleme)
            {
                EkranLabel.Text = " "; // ekran temizleme doğru ise ekranı temizle. (Bunu yapmamızın sebebi bir işarete bastığımızda ekranı temizlesin)
                _EkranTemizleme = false; // Bunu yapmamızın sebebi sayıya bastığımızda bir daha ekranı silmesin diye.
            }
            if (EkranLabel.Text == "0")
                EkranLabel.Text = " ";

            EkranLabel.Text += "7";
        }

        private void SekizButton_Click(object sender, EventArgs e)
        {
            if (_EkranTemizleme)
            {
                EkranLabel.Text = " "; // ekran temizleme doğru ise ekranı temizle. (Bunu yapmamızın sebebi bir işarete bastığımızda ekranı temizlesin)
                _EkranTemizleme = false; // Bunu yapmamızın sebebi sayıya bastığımızda bir daha ekranı silmesin diye.
            }
            if (EkranLabel.Text == "0")
                EkranLabel.Text = " ";

            EkranLabel.Text += "8";
        }

        private void DokuzButton_Click(object sender, EventArgs e)
        {
            if (_EkranTemizleme)
            {
                EkranLabel.Text = " "; // ekran temizleme doğru ise ekranı temizle. (Bunu yapmamızın sebebi bir işarete bastığımızda ekranı temizlesin)
                _EkranTemizleme = false; // Bunu yapmamızın sebebi sayıya bastığımızda bir daha ekranı silmesin diye.
            }
            if (EkranLabel.Text == "0")
                EkranLabel.Text = " ";

            EkranLabel.Text += "9";
        }

        private void SifirButton_Click(object sender, EventArgs e)
        {
            if (_EkranTemizleme)
            {
                EkranLabel.Text = " "; // ekran temizleme doğru ise ekranı temizle. (Bunu yapmamızın sebebi bir işarete bastığımızda ekranı temizlesin)
                _EkranTemizleme = false; // Bunu yapmamızın sebebi sayıya bastığımızda bir daha ekranı silmesin diye.
            }
            if (EkranLabel.Text == "0")
                EkranLabel.Text = " ";

            EkranLabel.Text += "0";
        }

        private void ToplamaButton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _EkranTemizleme = true;
            _ilkSayi = Convert.ToDouble(EkranLabel.Text);

        }

        private void CikartmaButton_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _EkranTemizleme = true;
            _ilkSayi = Convert.ToDouble(EkranLabel.Text);

        }

        private void CarpmaButton_Click(object sender, EventArgs e)
        {
            _islem = 'x';
            _EkranTemizleme = true;
            _ilkSayi = Convert.ToDouble(EkranLabel.Text);

        }

        private void BolmeButton_Click(object sender, EventArgs e)
        {
            _islem = '÷';
            _EkranTemizleme = true;
            _ilkSayi = Convert.ToDouble(EkranLabel.Text);

        }

        private void EsittirButton_Click(object sender, EventArgs e)
        {
            double ikinciSayi = Convert.ToDouble(EkranLabel.Text); // 1. sayıyı girdikten sonra işlemlerin herhangibirine tıklatıktan sonra 2. sayıyı tutar.
            double sonuc;
            switch (_islem)
            {
                case '+':// Toplama işlemi

                    sonuc = _ilkSayi + ikinciSayi;
                    break;

                case '-': // çıkarma işlemi

                    sonuc = _ilkSayi - ikinciSayi;
                    break;
                case 'x':// çarpma işlemi

                    sonuc = _ilkSayi * ikinciSayi;
                    break;
                case '÷': // bölme işlemi

                    sonuc = _ilkSayi / ikinciSayi;
                    break;
                case '^': // x üzeri y işlemi

                    double result = double.Parse(EkranLabel.Text);
                    result = Math.Pow(_ilkSayi, result);
                    sonuc = result;
                    break;

                case '!': // 10 üzeri y işlemi

                    double result2 = double.Parse(EkranLabel.Text);
                    result2 = Math.Pow(10, result2);
                    sonuc = result2;
                    break;

                default: // case lerden birine girmeyince sonucu 0 a eşitlel ve çık

                    sonuc = 0;
                    break;
            }
          
                EkranLabel.Text = Convert.ToString(sonuc);
        }

        private void TemizlemeButton_Click(object sender, EventArgs e)
        {
            EkranLabel.Text = " ";
            _EkranTemizleme = false;
            _ilkSayi = 0;
        }


        private void SinxButton_Click(object sender, EventArgs e)
        {
            double result = double.Parse(EkranLabel.Text);
            result = Math.Sin(Math.PI*result/180);
            EkranLabel.Text = result.ToString();
            _EkranTemizleme = true;
            _ilkSayi = Convert.ToDouble(EkranLabel.Text);
        }


        private void CosxButton_Click(object sender, EventArgs e)
        {
            double result = double.Parse(EkranLabel.Text);
            result = Math.Cos(Math.PI*result/180);
            EkranLabel.Text = result.ToString();
            _EkranTemizleme = true;
            _ilkSayi = Convert.ToDouble(EkranLabel.Text);
        }


        private void TanxButton_Click(object sender, EventArgs e)
        {
            double result = double.Parse(EkranLabel.Text);
            result = Math.Tan(Math.PI*result/180);
            EkranLabel.Text = result.ToString();
            _EkranTemizleme = true;
            _ilkSayi = Convert.ToDouble(EkranLabel.Text);
        }


        private void CotxButton_Click(object sender, EventArgs e)
        {
            double result = double.Parse(EkranLabel.Text);
            result = Math.Tan(Math.PI*result/180);
            EkranLabel.Text = (1/result).ToString();// tanx.cotx=1 eşitliğinden dolayı cotx'i kolay yoldan hesaplayabiliriz.
            _EkranTemizleme = true;
            _ilkSayi = Convert.ToDouble(EkranLabel.Text);
        }


        private void LnButton_Click(object sender, EventArgs e)
        {
            double result = double.Parse(EkranLabel.Text);
            result = Math.Log(result);
            EkranLabel.Text = result.ToString();
            _EkranTemizleme = true;
            _ilkSayi = Convert.ToDouble(EkranLabel.Text);
        }


        private void LogButton_Click(object sender, EventArgs e)
        {
            double result = double.Parse(EkranLabel.Text);
            result = Math.Log10(result);
            EkranLabel.Text = result.ToString();
            _EkranTemizleme = true;
            _ilkSayi = Convert.ToDouble(EkranLabel.Text);
        }


        private void XuzeriButton_Click(object sender, EventArgs e)
        {

            _islem = '^';
            _EkranTemizleme = true;
            _ilkSayi = Convert.ToDouble(EkranLabel.Text);
           
        }


        private void OnUzeriButton_Click(object sender, EventArgs e)
        {
            EkranLabel.Text = "10";
            _islem = '!';
            _EkranTemizleme = true;
            _ilkSayi = Convert.ToDouble(EkranLabel.Text);
        }
    }
}
