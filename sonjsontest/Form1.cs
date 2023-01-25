using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net;
using System.Net.Sockets;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.IO.Ports;
using System.IO;
namespace sonjsontest
{

    public partial class Form1 : Form
    {

        public Form1()
        {

            client = new HttpClient();
            client.BaseAddress = new Uri("http://İP");

            //GirisBilgileri girisBilgileri = new GirisBilgileri("test", "123");
            //string cevap = Api_Post("/api/giris", girisBilgileri);

            InitializeComponent();
            getAvailablePorts();
        }
        private void getAvailablePorts()
        {
            string[] ports = SerialPort.GetPortNames();
            comportcombobox.Items.AddRange(ports);
        }

        private HttpClient client;
        public class SunucuSaati
        {
        public int saat;
        public int dakika;
        public int saniye;
        public int milisaniye;
            public SunucuSaati(int _saat, int _dakika, int _saniye, int _milisaniye)
            {
                saat = _saat;
                dakika = _dakika;
                saniye = _saniye;
                milisaniye = _milisaniye;
            }
        }


        public class TelemetriVerisi
        {
            public int takim_numarasi;
            public float IHA_enlem;
            public float IHA_boylam;
            public float IHA_irtifa;
            public float IHA_dikilme;
            public float IHA_yonelme;
            public float IHA_yatis;
            public float IHA_hiz;
            public int IHA_batarya;
            public bool IHA_otonom;
            public bool IHA_kilitlenme;
            public int Hedef_merkez_X;
            public int Hedef_merkez_Y;
            public int Hedef_genislik;
            public int Hedef_yukseklik;
            public SunucuSaati GPSSaati;
        }
        public class Kilitlenme_Bilgisi
        {
            public SunucuSaati kilitlenmeBaslangicZamani;
            public SunucuSaati kilitlenmeBitisZamani;
            public bool otonom_kilitlenme;
        }
        public class KonumBilgisi
        {
            public int takim_numarasi;
            public float IHA_enlem;
            public float IHA_boylam;
            public float IHA_irtifa;
            public float IHA_dikilme;
            public float IHA_yonelme;
            public float IHA_yatis;
            public float IHA_hiz;
            public int zaman_farki;
            public KonumBilgisi(int _takim_numarasi,
                float _IHA_enlem, float _IHA_boylam,
                float _IHA_irtifa, float _IHA_dikilme,
                float _IHA_yonelme, float _IHA_yatis,
                float _IHA_hiz, int _zaman_farki)
            {
                    takim_numarasi = _takim_numarasi;
                    IHA_enlem = _IHA_enlem;
                    IHA_boylam = _IHA_boylam;
                    IHA_irtifa = _IHA_irtifa;
                    IHA_dikilme = _IHA_dikilme;
                    IHA_yonelme = _IHA_yonelme;
                    IHA_yatis = _IHA_yatis;
                    IHA_hiz = _IHA_hiz;
                    zaman_farki = _zaman_farki;
            }
        }
        public class TakimBilgileri
        {
            public SunucuSaati sunucuSaati;
            public List<KonumBilgisi> konumBilgileri;

            public TakimBilgileri(List<KonumBilgisi> _konumBilgileri)
            {
                konumBilgileri = _konumBilgileri;
                sunucuSaati = new SunucuSaati(9,8,7,6);
            }
        }
            
            string Api_Post(string adres, object model)
        {
            try
            {
                var json = JsonConvert.SerializeObject(model);
                var icerik = new StringContent(json, Encoding.UTF8, "application/json");
                var sorgu_cevap = client.PostAsync(adres, icerik).Result;

                if (sorgu_cevap.IsSuccessStatusCode)
                {
                    var cevap = sorgu_cevap.Content.ReadAsStringAsync().Result;

                    return cevap;
                }
                else
                {
                    return sorgu_cevap.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return null;
        }
        string Api_Get(String adres)
        {
            try
            {
                var sorgu_cevap = client.GetAsync(adres).Result;

                if (sorgu_cevap.IsSuccessStatusCode)
                {
                    var cevap = sorgu_cevap.Content.ReadAsStringAsync().Result;

                    return cevap;
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return null;
        }
        class QRkoordinat
        {
            public float qrEnlem;
            public float qrBoylam;
            public QRkoordinat() { }
        }
        public class KamikazeBilgisi
        {
            public string qrMetini;
            public SunucuSaati kamikazeBaslangicZamani;
            public SunucuSaati kamikazeBitisZamani;

            public KamikazeBilgisi() { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saatal.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelemetriVerisi telemetri_verisi = new TelemetriVerisi();

            telemetri_verisi.takim_numarasi = 46;
            telemetri_verisi.IHA_enlem = 41.454554f;
            telemetri_verisi.IHA_boylam = 25.16188f;
            telemetri_verisi.IHA_irtifa = 60;
            telemetri_verisi.IHA_dikilme = 14f;
            telemetri_verisi.IHA_yonelme = 1.2f;
            telemetri_verisi.IHA_yatis = 25f;
            telemetri_verisi.IHA_hiz = 23;
            telemetri_verisi.IHA_batarya = 20;
            telemetri_verisi.IHA_otonom = true;
            telemetri_verisi.IHA_kilitlenme = true;
            telemetri_verisi.Hedef_merkez_X = 200;
            telemetri_verisi.Hedef_merkez_Y = 400;
            telemetri_verisi.Hedef_genislik = 50;
            telemetri_verisi.Hedef_yukseklik = 100;
            telemetri_verisi.GPSSaati = new SunucuSaati(9, 8, 7, 6);

            string sunucuverisi = (string)Api_Post("/api/telemetri_gonder", telemetri_verisi);
            var data = JsonConvert.DeserializeObject<TakimBilgileri>(sunucuverisi);
            string jsonData = JsonConvert.SerializeObject(data);
            richTextBox1.AppendText(jsonData);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kilitlenme_Bilgisi kilitlenme_Bilgisi = new Kilitlenme_Bilgisi();
            kilitlenme_Bilgisi.kilitlenmeBaslangicZamani = new SunucuSaati(1, 2, 3, 4);
            kilitlenme_Bilgisi.kilitlenmeBitisZamani = new SunucuSaati(9, 8, 7, 6);
            kilitlenme_Bilgisi.otonom_kilitlenme = true;

            string json = JsonConvert.SerializeObject(kilitlenme_Bilgisi);
            string cevapkilitlenme = Api_Post("/api/kilitlenme_bilgisi", kilitlenme_Bilgisi);
            richTextBox1.Text = json;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = 5;
            string json = JsonConvert.SerializeObject(x);
            string cevap = Api_Post("/api/asd", json);
            richTextBox1.Text = cevap;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            KamikazeBilgisi kamikaze_bilgisi = new KamikazeBilgisi();

            kamikaze_bilgisi.kamikazeBaslangicZamani = new SunucuSaati(9, 8, 7, 6);
            kamikaze_bilgisi.kamikazeBaslangicZamani = new SunucuSaati(9, 8, 7, 6);
            kamikaze_bilgisi.qrMetini = "teknofest2022";

            string cevapkamikaze = Api_Post("/api/kamikaze_bilgisi", kamikaze_bilgisi);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string cevapqrkoordinat = Api_Get("/api/qr_koordinati");
            QRkoordinat qrkoordinat = JsonConvert.DeserializeObject<QRkoordinat>(cevapqrkoordinat);
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        private void OpenPortButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (comportcombobox.Text == "" || boudratecombobox.Text == "")
                {
                    label14.Text = "Please select port settings";
                    label14.ForeColor = Color.Red;
                }
                else
                {
                    serialPort1.PortName = comportcombobox.Text;
                    serialPort1.BaudRate = Convert.ToInt32(boudratecombobox.Text);
                    serialPort1.Open();
                    progressBar1.Value = 100;
                    SendButton.Enabled = true;
                    textBox1.Enabled = true;
                    OpenPortButton.Enabled = false;
                    ClosePortButton.Enabled = true;
                    label14.Text = ("Serial Port Connected");
                    label14.ForeColor = Color.Green;
                    SerialportTimer.Start();
                }
            }
            catch (UnauthorizedAccessException)
            {
                label14.ForeColor = Color.Red;
                label14.Text = "Unauthorized Access";
            }
        }

        private void ClosePortButton_Click(object sender, EventArgs e)
        {

            serialPort1.Close();
            progressBar1.Value = 0;
            OpenPortButton.Enabled = true;
            SendButton.Enabled = false;
            textBox1.Enabled = false;
            label12.ForeColor = Color.Red;
            label12.ForeColor = Color.Red;
            label12.Text = ("Serial Port Disconnected");
        }

        private void SerialportTimer_Tick(object sender, EventArgs e)
        {
            label12.Text = "Receiving Data";
            label12.ForeColor = Color.Green;
            try
            {
                string veri = serialPort1.ReadExisting();
                if (veri == (""))
                {

                }
                else
                {
                    richTextBox1.Text += Environment.NewLine + veri;
                }

            }
            catch (Exception)
            {
                label12.ForeColor = Color.Red;
                label12.Text = "Error";
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
            serialPort1.WriteLine(textBox1.Text);
            }
            else
            {
                MessageBox.Show("önce port açmalısın");
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void saatal_Tick(object sender, EventArgs e)
        {

                string cevap = Api_Get("/api/sunucusaati");
                SunucuSaati sistemSaati = JsonConvert.DeserializeObject<SunucuSaati>(cevap);
                //LABELA SAATİ YAZDIRMA KISMI
                label1.Text = "Sunucu Saati " + sistemSaati.saat + ":" + sistemSaati.dakika + ":" + sistemSaati.saniye + ":" + sistemSaati.milisaniye;


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
