using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Hesap_Makinesi_Calculator
{
    public partial class Form1 : Form
    {
        private char _islem;
        bool _ekrantemizlenecekmi;
        double _sayi1;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sonucekrani_Button.Text == "0") sonucekrani_Button.Text = "";
            sonucekrani_Button.Text += "9";
        }

        private void rakam8_Button_Click(object sender, EventArgs e)
        {
            if (sonucekrani_Button.Text == "0") sonucekrani_Button.Text = "";
            sonucekrani_Button.Text += "8";
        }

        private void rakam7_Button_Click(object sender, EventArgs e)
        {
            if (sonucekrani_Button.Text == "0") sonucekrani_Button.Text = "";
            sonucekrani_Button.Text += "7";
        }

        private void rakam6_Button_Click(object sender, EventArgs e)
        {
            if (sonucekrani_Button.Text == "0") sonucekrani_Button.Text = "";
            sonucekrani_Button.Text += "6";
        }

        private void rakam5_Button_Click(object sender, EventArgs e)
        {
            if (sonucekrani_Button.Text == "0")
                sonucekrani_Button.Text = "";
            sonucekrani_Button.Text += "5";
        }

        private void rakam4_Button_Click(object sender, EventArgs e)
        {
            if (sonucekrani_Button.Text == "0")
                sonucekrani_Button.Text = "";
            sonucekrani_Button.Text += "4";
        }

        private void rakam3_Button_Click(object sender, EventArgs e)
        {
            if (sonucekrani_Button.Text == "0")
                sonucekrani_Button.Text = "";
            sonucekrani_Button.Text += "3";
        }

        private void rakam2_Button_Click(object sender, EventArgs e)
        {
            if (sonucekrani_Button.Text == "0")
                sonucekrani_Button.Text = "";
            sonucekrani_Button.Text += "2";
        }

        private void rakam1_Button_Click(object sender, EventArgs e)
        {
            if (sonucekrani_Button.Text == "0")
                sonucekrani_Button.Text = "";
            sonucekrani_Button.Text += "1";
        }

        private void rakam0_Button_Click(object sender, EventArgs e)
        {
            if (sonucekrani_Button.Text == "0")
                sonucekrani_Button.Text = "";
            sonucekrani_Button.Text += "0";
        }

        private void topla_Button_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantemizlenecekmi = false;
            _sayi1 = Convert.ToDouble(sonucekrani_Button.Text);
            sonucekrani_Button.Text = "";
        }
        private void cikarma_Button_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekrantemizlenecekmi = false;
            _sayi1 = Convert.ToDouble(sonucekrani_Button.Text);
            sonucekrani_Button.Text = "";
        }

        private void carpma_Button_Click(object sender, EventArgs e)
        {
            _islem = '*';            
            _ekrantemizlenecekmi = false;
            _sayi1 = Convert.ToDouble(sonucekrani_Button.Text);
            sonucekrani_Button.Text = "";
        }

        private void bolme_Button_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantemizlenecekmi = false;
            _sayi1 = Convert.ToDouble(sonucekrani_Button.Text);
            sonucekrani_Button.Text = "";
        }

        private void esittir_Button_Click(object sender, EventArgs e)
        {
            double _sayi2 = Convert.ToInt32(sonucekrani_Button.Text);
            double sonuc = 0;
            switch (_islem)
            {
                case '+':
                    sonuc = _sayi1 + _sayi2;                   
                    break;
                case '-':
                    sonuc = _sayi1 - _sayi2;
                    break;
                case '*':
                    sonuc = _sayi1 * _sayi2;
                    break;
                case '/':
                    sonuc = _sayi1 / _sayi2;
                    break;
            }
            sonucekrani_Button.Text = Convert.ToString(sonuc);
        }

        private void temizle_Button_Click(object sender, EventArgs e)
        {
            sonucekrani_Button.Text = "";
        }   
    }
}
