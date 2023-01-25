
namespace sonjsontest
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.GPSSaati = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Hedefgenislik = new System.Windows.Forms.Label();
            this.MerkezY = new System.Windows.Forms.Label();
            this.MerkezX = new System.Windows.Forms.Label();
            this.Kilitlenme = new System.Windows.Forms.Label();
            this.Otonom = new System.Windows.Forms.Label();
            this.Batarya = new System.Windows.Forms.Label();
            this.Hiz = new System.Windows.Forms.Label();
            this.yatis = new System.Windows.Forms.Label();
            this.Yonelme = new System.Windows.Forms.Label();
            this.Dikilme = new System.Windows.Forms.Label();
            this.İrtifa = new System.Windows.Forms.Label();
            this.Boylam = new System.Windows.Forms.Label();
            this.Enlem = new System.Windows.Forms.Label();
            this.takimnumarasi = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comportlabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.baudratelabel = new System.Windows.Forms.Label();
            this.comportcombobox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.boudratecombobox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ClosePortButton = new System.Windows.Forms.Button();
            this.OpenPortButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SerialportTimer = new System.Windows.Forms.Timer(this.components);
            this.saatal = new System.Windows.Forms.Timer(this.components);
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(356, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Saat al";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(342, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(12, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "telemetri gönderme";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(342, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(177, 452);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Kilitlenme";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(12, 481);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(157, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Kamikaze";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Location = new System.Drawing.Point(177, 481);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(157, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = "qr koordinat isteği";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.button8);
            this.groupBox5.Controls.Add(this.button9);
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(476, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(184, 340);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Teknofest API bağlanıtısı";
            // 
            // button8
            // 
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(6, 109);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(83, 22);
            this.button8.TabIndex = 9;
            this.button8.Text = "Bağlantıyı kes";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(95, 109);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(83, 22);
            this.button9.TabIndex = 8;
            this.button9.Text = "Bağlan";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 83);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(169, 20);
            this.textBox3.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(9, 64);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(28, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Şifre";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox6.ForeColor = System.Drawing.Color.Black;
            this.groupBox6.Location = new System.Drawing.Point(6, 134);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(172, 201);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Api Verileri";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(7, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Sunucu Saati";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Zaman Farkı :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(6, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Takım numarası :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "IHA Yatış :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "IHA Enlem :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "IHA Yön :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "IHA Boylam :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "IHA Dikilme :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "IHA Dikilme :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(6, 22);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Kullanıcı adı";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.GPSSaati);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.Hedefgenislik);
            this.groupBox4.Controls.Add(this.MerkezY);
            this.groupBox4.Controls.Add(this.MerkezX);
            this.groupBox4.Controls.Add(this.Kilitlenme);
            this.groupBox4.Controls.Add(this.Otonom);
            this.groupBox4.Controls.Add(this.Batarya);
            this.groupBox4.Controls.Add(this.Hiz);
            this.groupBox4.Controls.Add(this.yatis);
            this.groupBox4.Controls.Add(this.Yonelme);
            this.groupBox4.Controls.Add(this.Dikilme);
            this.groupBox4.Controls.Add(this.İrtifa);
            this.groupBox4.Controls.Add(this.Boylam);
            this.groupBox4.Controls.Add(this.Enlem);
            this.groupBox4.Controls.Add(this.takimnumarasi);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(185, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(267, 196);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Telemetri verileri";
            // 
            // GPSSaati
            // 
            this.GPSSaati.AutoSize = true;
            this.GPSSaati.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GPSSaati.ForeColor = System.Drawing.Color.Black;
            this.GPSSaati.Location = new System.Drawing.Point(7, 163);
            this.GPSSaati.Name = "GPSSaati";
            this.GPSSaati.Size = new System.Drawing.Size(59, 13);
            this.GPSSaati.TabIndex = 15;
            this.GPSSaati.Text = "GPSSaati :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(125, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Hedef_Yüksekllik :";
            // 
            // Hedefgenislik
            // 
            this.Hedefgenislik.AutoSize = true;
            this.Hedefgenislik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Hedefgenislik.ForeColor = System.Drawing.Color.Black;
            this.Hedefgenislik.Location = new System.Drawing.Point(125, 143);
            this.Hedefgenislik.Name = "Hedefgenislik";
            this.Hedefgenislik.Size = new System.Drawing.Size(83, 13);
            this.Hedefgenislik.TabIndex = 13;
            this.Hedefgenislik.Text = "Hedef_genislik :";
            // 
            // MerkezY
            // 
            this.MerkezY.AutoSize = true;
            this.MerkezY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MerkezY.ForeColor = System.Drawing.Color.Black;
            this.MerkezY.Location = new System.Drawing.Point(125, 123);
            this.MerkezY.Name = "MerkezY";
            this.MerkezY.Size = new System.Drawing.Size(58, 13);
            this.MerkezY.TabIndex = 12;
            this.MerkezY.Text = "Merkez-Y :";
            // 
            // MerkezX
            // 
            this.MerkezX.AutoSize = true;
            this.MerkezX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MerkezX.ForeColor = System.Drawing.Color.Black;
            this.MerkezX.Location = new System.Drawing.Point(125, 103);
            this.MerkezX.Name = "MerkezX";
            this.MerkezX.Size = new System.Drawing.Size(58, 13);
            this.MerkezX.TabIndex = 11;
            this.MerkezX.Text = "Merkez-X :";
            // 
            // Kilitlenme
            // 
            this.Kilitlenme.AutoSize = true;
            this.Kilitlenme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kilitlenme.ForeColor = System.Drawing.Color.Black;
            this.Kilitlenme.Location = new System.Drawing.Point(125, 83);
            this.Kilitlenme.Name = "Kilitlenme";
            this.Kilitlenme.Size = new System.Drawing.Size(57, 13);
            this.Kilitlenme.TabIndex = 10;
            this.Kilitlenme.Text = "Kilitlenme :";
            // 
            // Otonom
            // 
            this.Otonom.AutoSize = true;
            this.Otonom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Otonom.ForeColor = System.Drawing.Color.Black;
            this.Otonom.Location = new System.Drawing.Point(125, 63);
            this.Otonom.Name = "Otonom";
            this.Otonom.Size = new System.Drawing.Size(50, 13);
            this.Otonom.TabIndex = 9;
            this.Otonom.Text = "Otonom :";
            // 
            // Batarya
            // 
            this.Batarya.AutoSize = true;
            this.Batarya.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Batarya.ForeColor = System.Drawing.Color.Black;
            this.Batarya.Location = new System.Drawing.Point(125, 43);
            this.Batarya.Name = "Batarya";
            this.Batarya.Size = new System.Drawing.Size(49, 13);
            this.Batarya.TabIndex = 8;
            this.Batarya.Text = "Batarya :";
            // 
            // Hiz
            // 
            this.Hiz.AutoSize = true;
            this.Hiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Hiz.ForeColor = System.Drawing.Color.Black;
            this.Hiz.Location = new System.Drawing.Point(125, 23);
            this.Hiz.Name = "Hiz";
            this.Hiz.Size = new System.Drawing.Size(28, 13);
            this.Hiz.TabIndex = 7;
            this.Hiz.Text = "Hız :";
            // 
            // yatis
            // 
            this.yatis.AutoSize = true;
            this.yatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yatis.ForeColor = System.Drawing.Color.Black;
            this.yatis.Location = new System.Drawing.Point(7, 143);
            this.yatis.Name = "yatis";
            this.yatis.Size = new System.Drawing.Size(36, 13);
            this.yatis.TabIndex = 6;
            this.yatis.Text = "Yatış :";
            // 
            // Yonelme
            // 
            this.Yonelme.AutoSize = true;
            this.Yonelme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yonelme.ForeColor = System.Drawing.Color.Black;
            this.Yonelme.Location = new System.Drawing.Point(7, 123);
            this.Yonelme.Name = "Yonelme";
            this.Yonelme.Size = new System.Drawing.Size(54, 13);
            this.Yonelme.TabIndex = 5;
            this.Yonelme.Text = "Yönelme :";
            // 
            // Dikilme
            // 
            this.Dikilme.AutoSize = true;
            this.Dikilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Dikilme.ForeColor = System.Drawing.Color.Black;
            this.Dikilme.Location = new System.Drawing.Point(7, 103);
            this.Dikilme.Name = "Dikilme";
            this.Dikilme.Size = new System.Drawing.Size(47, 13);
            this.Dikilme.TabIndex = 4;
            this.Dikilme.Text = "Dikilme :";
            // 
            // İrtifa
            // 
            this.İrtifa.AutoSize = true;
            this.İrtifa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İrtifa.ForeColor = System.Drawing.Color.Black;
            this.İrtifa.Location = new System.Drawing.Point(7, 83);
            this.İrtifa.Name = "İrtifa";
            this.İrtifa.Size = new System.Drawing.Size(33, 13);
            this.İrtifa.TabIndex = 3;
            this.İrtifa.Text = "İrtifa :";
            // 
            // Boylam
            // 
            this.Boylam.AutoSize = true;
            this.Boylam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Boylam.ForeColor = System.Drawing.Color.Black;
            this.Boylam.Location = new System.Drawing.Point(7, 63);
            this.Boylam.Name = "Boylam";
            this.Boylam.Size = new System.Drawing.Size(47, 13);
            this.Boylam.TabIndex = 2;
            this.Boylam.Text = "Boylam :";
            // 
            // Enlem
            // 
            this.Enlem.AutoSize = true;
            this.Enlem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Enlem.ForeColor = System.Drawing.Color.Black;
            this.Enlem.Location = new System.Drawing.Point(7, 43);
            this.Enlem.Name = "Enlem";
            this.Enlem.Size = new System.Drawing.Size(42, 13);
            this.Enlem.TabIndex = 1;
            this.Enlem.Text = "Enlem :";
            // 
            // takimnumarasi
            // 
            this.takimnumarasi.AutoSize = true;
            this.takimnumarasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.takimnumarasi.ForeColor = System.Drawing.Color.Black;
            this.takimnumarasi.Location = new System.Drawing.Point(7, 23);
            this.takimnumarasi.Name = "takimnumarasi";
            this.takimnumarasi.Size = new System.Drawing.Size(83, 13);
            this.takimnumarasi.TabIndex = 0;
            this.takimnumarasi.Text = "takım numarası :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.comportlabel);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.baudratelabel);
            this.groupBox3.Controls.Add(this.comportcombobox);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.boudratecombobox);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.ClosePortButton);
            this.groupBox3.Controls.Add(this.OpenPortButton);
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(12, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(458, 434);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SeriPort Bağlantısı";
            // 
            // comportlabel
            // 
            this.comportlabel.AutoSize = true;
            this.comportlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comportlabel.ForeColor = System.Drawing.Color.Black;
            this.comportlabel.Location = new System.Drawing.Point(11, 19);
            this.comportlabel.Name = "comportlabel";
            this.comportlabel.Size = new System.Drawing.Size(53, 13);
            this.comportlabel.TabIndex = 12;
            this.comportlabel.Text = "COM Port";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(11, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "label12";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(6, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 211);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Telemetri verileri";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(6, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(209, 185);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // baudratelabel
            // 
            this.baudratelabel.AutoSize = true;
            this.baudratelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baudratelabel.ForeColor = System.Drawing.Color.Black;
            this.baudratelabel.Location = new System.Drawing.Point(9, 60);
            this.baudratelabel.Name = "baudratelabel";
            this.baudratelabel.Size = new System.Drawing.Size(55, 13);
            this.baudratelabel.TabIndex = 13;
            this.baudratelabel.Text = "BaudRate";
            // 
            // comportcombobox
            // 
            this.comportcombobox.FormattingEnabled = true;
            this.comportcombobox.Location = new System.Drawing.Point(8, 35);
            this.comportcombobox.Name = "comportcombobox";
            this.comportcombobox.Size = new System.Drawing.Size(163, 21);
            this.comportcombobox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.SendButton);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(237, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 213);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Telemetri test";
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 11.25F, System.Drawing.FontStyle.Bold);
            this.SendButton.ForeColor = System.Drawing.Color.Black;
            this.SendButton.Location = new System.Drawing.Point(6, 175);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(159, 28);
            this.SendButton.TabIndex = 1;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 149);
            this.textBox1.TabIndex = 0;
            // 
            // boudratecombobox
            // 
            this.boudratecombobox.FormattingEnabled = true;
            this.boudratecombobox.Items.AddRange(new object[] {
            "9600"});
            this.boudratecombobox.Location = new System.Drawing.Point(11, 77);
            this.boudratecombobox.Name = "boudratecombobox";
            this.boudratecombobox.Size = new System.Drawing.Size(160, 21);
            this.boudratecombobox.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(11, 175);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "label14";
            // 
            // ClosePortButton
            // 
            this.ClosePortButton.BackColor = System.Drawing.Color.White;
            this.ClosePortButton.Enabled = false;
            this.ClosePortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ClosePortButton.ForeColor = System.Drawing.Color.Black;
            this.ClosePortButton.Location = new System.Drawing.Point(95, 110);
            this.ClosePortButton.Name = "ClosePortButton";
            this.ClosePortButton.Size = new System.Drawing.Size(76, 31);
            this.ClosePortButton.TabIndex = 6;
            this.ClosePortButton.Text = "Port Kapat";
            this.ClosePortButton.UseVisualStyleBackColor = false;
            this.ClosePortButton.Click += new System.EventHandler(this.ClosePortButton_Click);
            // 
            // OpenPortButton
            // 
            this.OpenPortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OpenPortButton.ForeColor = System.Drawing.Color.Black;
            this.OpenPortButton.Location = new System.Drawing.Point(8, 110);
            this.OpenPortButton.Name = "OpenPortButton";
            this.OpenPortButton.Size = new System.Drawing.Size(81, 31);
            this.OpenPortButton.TabIndex = 5;
            this.OpenPortButton.Text = "Port Aç";
            this.OpenPortButton.UseVisualStyleBackColor = true;
            this.OpenPortButton.Click += new System.EventHandler(this.OpenPortButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(14, 147);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(84, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // SerialportTimer
            // 
            this.SerialportTimer.Tick += new System.EventHandler(this.SerialportTimer_Tick);
            // 
            // saatal
            // 
            this.saatal.Interval = 300;
            this.saatal.Tick += new System.EventHandler(this.saatal_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(665, 512);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Yer Kontrol";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label GPSSaati;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Hedefgenislik;
        private System.Windows.Forms.Label MerkezY;
        private System.Windows.Forms.Label MerkezX;
        private System.Windows.Forms.Label Kilitlenme;
        private System.Windows.Forms.Label Otonom;
        private System.Windows.Forms.Label Batarya;
        private System.Windows.Forms.Label Hiz;
        private System.Windows.Forms.Label yatis;
        private System.Windows.Forms.Label Yonelme;
        private System.Windows.Forms.Label Dikilme;
        private System.Windows.Forms.Label İrtifa;
        private System.Windows.Forms.Label Boylam;
        private System.Windows.Forms.Label Enlem;
        private System.Windows.Forms.Label takimnumarasi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label comportlabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label baudratelabel;
        private System.Windows.Forms.ComboBox comportcombobox;
        private System.Windows.Forms.ComboBox boudratecombobox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button ClosePortButton;
        private System.Windows.Forms.Button OpenPortButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer SerialportTimer;
        private System.Windows.Forms.Timer saatal;
    }
}

