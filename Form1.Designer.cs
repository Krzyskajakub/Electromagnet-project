using System;
using System.Windows.Forms;

namespace elektromagnes
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnZamknij = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbHp = new System.Windows.Forms.TextBox();
            this.tbH = new System.Windows.Forms.TextBox();
            this.tbHs = new System.Windows.Forms.TextBox();
            this.tbD = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbK = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.tbPrzenikalnosc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbTempmax = new System.Windows.Forms.TextBox();
            this.tbTempotocz = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSzczelinap = new System.Windows.Forms.TextBox();
            this.tbIndukcja = new System.Windows.Forms.TextBox();
            this.tbSzczelina = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSila = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNapiecie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCharakterystyka = new System.Windows.Forms.TabPage();
            this.chartBh = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TbStructure = new System.Windows.Forms.TabPage();
            this.btnOblicz = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSavePicture = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbCharakterystyka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZamknij
            // 
            this.btnZamknij.ForeColor = System.Drawing.Color.Red;
            this.btnZamknij.Location = new System.Drawing.Point(816, 562);
            this.btnZamknij.Margin = new System.Windows.Forms.Padding(4);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(100, 28);
            this.btnZamknij.TabIndex = 0;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tbCharakterystyka);
            this.tabControl1.Controls.Add(this.TbStructure);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(779, 576);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbInfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(771, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbInfo
            // 
            this.tbInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbInfo.Location = new System.Drawing.Point(4, 4);
            this.tbInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbInfo.Size = new System.Drawing.Size(763, 539);
            this.tbInfo.TabIndex = 0;
            this.tbInfo.TextChanged += new System.EventHandler(this.tbInfo_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(771, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dane Wejściowe";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbHp);
            this.groupBox4.Controls.Add(this.tbH);
            this.groupBox4.Controls.Add(this.tbHs);
            this.groupBox4.Controls.Add(this.tbD);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(435, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(314, 228);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wymiary Elektromagnesu";
            // 
            // tbHp
            // 
            this.tbHp.Location = new System.Drawing.Point(208, 155);
            this.tbHp.Name = "tbHp";
            this.tbHp.Size = new System.Drawing.Size(100, 22);
            this.tbHp.TabIndex = 7;
            this.tbHp.Text = "0,063";
            // 
            // tbH
            // 
            this.tbH.Location = new System.Drawing.Point(208, 115);
            this.tbH.Name = "tbH";
            this.tbH.Size = new System.Drawing.Size(100, 22);
            this.tbH.TabIndex = 6;
            this.tbH.Text = "0,0347";
            // 
            // tbHs
            // 
            this.tbHs.Location = new System.Drawing.Point(208, 69);
            this.tbHs.Name = "tbHs";
            this.tbHs.Size = new System.Drawing.Size(100, 22);
            this.tbHs.TabIndex = 5;
            this.tbHs.Text = "0,01";
            // 
            // tbD
            // 
            this.tbD.Location = new System.Drawing.Point(208, 24);
            this.tbD.Name = "tbD";
            this.tbD.Size = new System.Drawing.Size(100, 22);
            this.tbD.TabIndex = 4;
            this.tbD.Text = "0,045";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 157);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(155, 17);
            this.label15.TabIndex = 3;
            this.label15.Text = "Wysokość obudowy [m]";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 17);
            this.label14.TabIndex = 2;
            this.label14.Text = "Wysokość cewki [m]";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Wysokość stopy [m]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Średnica D [m]";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbK);
            this.groupBox3.Controls.Add(this.tbY);
            this.groupBox3.Controls.Add(this.tbPrzenikalnosc);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(21, 359);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(387, 123);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // tbK
            // 
            this.tbK.Location = new System.Drawing.Point(233, 82);
            this.tbK.Margin = new System.Windows.Forms.Padding(4);
            this.tbK.Name = "tbK";
            this.tbK.Size = new System.Drawing.Size(132, 22);
            this.tbK.TabIndex = 5;
            this.tbK.Text = "0,5";
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(233, 49);
            this.tbY.Margin = new System.Windows.Forms.Padding(4);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(132, 22);
            this.tbY.TabIndex = 4;
            this.tbY.Text = "5,86";
            // 
            // tbPrzenikalnosc
            // 
            this.tbPrzenikalnosc.Location = new System.Drawing.Point(233, 16);
            this.tbPrzenikalnosc.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrzenikalnosc.Name = "tbPrzenikalnosc";
            this.tbPrzenikalnosc.Size = new System.Drawing.Size(132, 22);
            this.tbPrzenikalnosc.TabIndex = 3;
            this.tbPrzenikalnosc.Text = "0,0000012566";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 91);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Stała k";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 57);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Stała y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Przenikalność w prózni";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbTempmax);
            this.groupBox2.Controls.Add(this.tbTempotocz);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(21, 256);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(387, 95);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Temperatura pracy";
            // 
            // tbTempmax
            // 
            this.tbTempmax.Location = new System.Drawing.Point(233, 58);
            this.tbTempmax.Margin = new System.Windows.Forms.Padding(4);
            this.tbTempmax.Name = "tbTempmax";
            this.tbTempmax.Size = new System.Drawing.Size(132, 22);
            this.tbTempmax.TabIndex = 3;
            this.tbTempmax.Text = "150";
            // 
            // tbTempotocz
            // 
            this.tbTempotocz.Location = new System.Drawing.Point(233, 28);
            this.tbTempotocz.Margin = new System.Windows.Forms.Padding(4);
            this.tbTempotocz.Name = "tbTempotocz";
            this.tbTempotocz.Size = new System.Drawing.Size(132, 22);
            this.tbTempotocz.TabIndex = 2;
            this.tbTempotocz.Text = "20";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Temperatura maksymalna[C]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Temperatura otoczenia [C]";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbSzczelinap);
            this.groupBox1.Controls.Add(this.tbIndukcja);
            this.groupBox1.Controls.Add(this.tbSzczelina);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbSila);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbNapiecie);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(387, 228);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametry Elektromagnesu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Szczelina Pasożytnicza[m]";
            // 
            // tbSzczelinap
            // 
            this.tbSzczelinap.Location = new System.Drawing.Point(233, 187);
            this.tbSzczelinap.Margin = new System.Windows.Forms.Padding(4);
            this.tbSzczelinap.Name = "tbSzczelinap";
            this.tbSzczelinap.Size = new System.Drawing.Size(132, 22);
            this.tbSzczelinap.TabIndex = 8;
            this.tbSzczelinap.Text = "0,0002";
            // 
            // tbIndukcja
            // 
            this.tbIndukcja.Location = new System.Drawing.Point(233, 149);
            this.tbIndukcja.Margin = new System.Windows.Forms.Padding(4);
            this.tbIndukcja.Name = "tbIndukcja";
            this.tbIndukcja.Size = new System.Drawing.Size(132, 22);
            this.tbIndukcja.TabIndex = 7;
            this.tbIndukcja.Text = "0,7";
            // 
            // tbSzczelina
            // 
            this.tbSzczelina.Location = new System.Drawing.Point(233, 110);
            this.tbSzczelina.Margin = new System.Windows.Forms.Padding(4);
            this.tbSzczelina.Name = "tbSzczelina";
            this.tbSzczelina.Size = new System.Drawing.Size(132, 22);
            this.tbSzczelina.TabIndex = 6;
            this.tbSzczelina.Text = "0,001";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Indukcja[T]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Szczelina Powietrzna[m]";
            // 
            // tbSila
            // 
            this.tbSila.Location = new System.Drawing.Point(233, 25);
            this.tbSila.Margin = new System.Windows.Forms.Padding(4);
            this.tbSila.Name = "tbSila";
            this.tbSila.Size = new System.Drawing.Size(132, 22);
            this.tbSila.TabIndex = 3;
            this.tbSila.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Siła obciążenia[N]";
            // 
            // tbNapiecie
            // 
            this.tbNapiecie.Location = new System.Drawing.Point(233, 66);
            this.tbNapiecie.Margin = new System.Windows.Forms.Padding(4);
            this.tbNapiecie.Name = "tbNapiecie";
            this.tbNapiecie.Size = new System.Drawing.Size(132, 22);
            this.tbNapiecie.TabIndex = 1;
            this.tbNapiecie.Text = "12";
            this.tbNapiecie.TextChanged += new System.EventHandler(this.tbNapiecie_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Napięcie[V]";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbCharakterystyka
            // 
            this.tbCharakterystyka.Controls.Add(this.chartBh);
            this.tbCharakterystyka.Location = new System.Drawing.Point(4, 25);
            this.tbCharakterystyka.Name = "tbCharakterystyka";
            this.tbCharakterystyka.Size = new System.Drawing.Size(771, 547);
            this.tbCharakterystyka.TabIndex = 3;
            this.tbCharakterystyka.Text = "Charakterystyka B(h)";
            this.tbCharakterystyka.UseVisualStyleBackColor = true;
            // 
            // chartBh
            // 
            chartArea1.Name = "ChartArea1";
            this.chartBh.ChartAreas.Add(chartArea1);
            this.chartBh.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartBh.Legends.Add(legend1);
            this.chartBh.Location = new System.Drawing.Point(0, 0);
            this.chartBh.Name = "chartBh";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartBh.Series.Add(series1);
            this.chartBh.Size = new System.Drawing.Size(771, 547);
            this.chartBh.TabIndex = 0;
            this.chartBh.Text = "chart1";
            this.chartBh.Click += new System.EventHandler(this.chartBh_Click);
            // 
            // TbStructure
            // 
            this.TbStructure.Location = new System.Drawing.Point(4, 25);
            this.TbStructure.Name = "TbStructure";
            this.TbStructure.Size = new System.Drawing.Size(771, 547);
            this.TbStructure.TabIndex = 2;
            this.TbStructure.Text = "Structure";
            this.TbStructure.UseVisualStyleBackColor = true;
            this.TbStructure.Click += new System.EventHandler(this.TbStructure_Click);
            this.TbStructure.Paint += new System.Windows.Forms.PaintEventHandler(this.TpStructure_Paint);
            // 
            // btnOblicz
            // 
            this.btnOblicz.Location = new System.Drawing.Point(816, 62);
            this.btnOblicz.Margin = new System.Windows.Forms.Padding(4);
            this.btnOblicz.Name = "btnOblicz";
            this.btnOblicz.Size = new System.Drawing.Size(100, 28);
            this.btnOblicz.TabIndex = 2;
            this.btnOblicz.Text = "Oblicz";
            this.btnOblicz.UseVisualStyleBackColor = true;
            this.btnOblicz.Click += new System.EventHandler(this.btnOblicz_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(816, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Zapis do Pliku";
            // 
            // btnSavePicture
            // 
            this.btnSavePicture.Location = new System.Drawing.Point(829, 162);
            this.btnSavePicture.Name = "btnSavePicture";
            this.btnSavePicture.Size = new System.Drawing.Size(75, 23);
            this.btnSavePicture.TabIndex = 4;
            this.btnSavePicture.Text = "Zapisz";
            this.btnSavePicture.UseVisualStyleBackColor = true;
            this.btnSavePicture.Click += new System.EventHandler(this.btnSavePicture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(925, 614);
            this.Controls.Add(this.btnSavePicture);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnOblicz);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnZamknij);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Elektromagnes1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbCharakterystyka.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartBh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void chartBh_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TbStructure_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
                
        private void tbNapiecie_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNapiecie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOblicz;
        private System.Windows.Forms.TextBox tbSila;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIndukcja;
        private System.Windows.Forms.TextBox tbSzczelina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbK;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.TextBox tbPrzenikalnosc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbTempmax;
        private System.Windows.Forms.TextBox tbTempotocz;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSzczelinap;
        private System.Windows.Forms.TabPage TbStructure;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBh;
        private System.Windows.Forms.TabPage tbCharakterystyka;
        private GroupBox groupBox4;
        private TextBox tbHp;
        private TextBox tbH;
        private TextBox tbHs;
        private TextBox tbD;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Button btnSavePicture;
    }
}

