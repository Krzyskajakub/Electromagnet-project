using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace elektromagnes
{
    public partial class Form1 : Form
    {
        ElektromagnesNurnikowy EK1 = new ElektromagnesNurnikowy();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnZakmnij_Click(object sender, EventArgs e)
        {
           Close();

         /*   Elektromagnes Elektro = new Elektromagnes();
            Elektro.NapiecieZasilania = 230;
            
            tbInfo.AppendText(Elektro.NapiecieZasilania.ToString());
            */

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbInfo.AppendText("Uruchamianie programu \r\n");
            tbInfo.AppendText("Program do obliczenia elektromagnesu \r\n");
            tbInfo.AppendText("Jakub Krzyśka \n");
            tbInfo.AppendText("EIUM \n");
            tbInfo.AppendText("125858 \n");
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOblicz_Click(object sender, EventArgs e)
        {
            tbInfo.Clear();
            tbInfo.AppendText("Obliczenia w toku... \r\n");

            tbInfo.AppendText("Podane Dane: \r\n");

            EK1.NapiecieZasilania = float.Parse(tbNapiecie.Text);
            tbInfo.AppendText("Napiecie zasilania: " + EK1.NapiecieZasilania.ToString() + "[V] \r\n");

            EK1.SilaObciazenia = float.Parse(tbSila.Text);
            tbInfo.AppendText("Sila: " + EK1.SilaObciazenia.ToString() + "[N] \r\n");

            EK1.SzczelinaPowietrzna = float.Parse(tbSzczelina.Text);
            tbInfo.AppendText("Szerokosc Szczeliny Roboczej: " + EK1.SzczelinaPowietrzna.ToString() + "[m] \r\n");

            EK1.Indukcja = float.Parse(tbIndukcja.Text);
            tbInfo.AppendText("Indukcja:  " + EK1.Indukcja.ToString() + "[T] \r\n");

            EK1.SzczelinaPasozytnicza = float.Parse(tbSzczelinap.Text);
            tbInfo.AppendText("Mi zero:  " + EK1.SzczelinaPasozytnicza.ToString() + "[ ] \r\n");

            EK1.TemperaturaOtoczenia = float.Parse(tbTempotocz.Text);
            tbInfo.AppendText("xp:  " + EK1.TemperaturaOtoczenia.ToString() + "[m] \r\n");

            EK1.TemperaturaMax = float.Parse(tbTempmax.Text);
            tbInfo.AppendText("k:  " + EK1.TemperaturaMax.ToString() + "[m] \r\n");

            EK1.PrzenikalnoscProznia = float.Parse(tbPrzenikalnosc.Text);
            tbInfo.AppendText("y:  " + EK1.PrzenikalnoscProznia.ToString() + "[ ] \r\n");

            EK1.StalaY = float.Parse(tbY.Text);
            tbInfo.AppendText("Temperatura max:  " + EK1.StalaY.ToString() + "[*C] \r\n");

            EK1.StalaK = float.Parse(tbK.Text);
            tbInfo.AppendText("Temperatura otoczenia:  " + EK1.StalaK.ToString() + "[*C] \r\n");

            tbInfo.AppendText("*************************************************************************************************************************************\n" );
            tbInfo.AppendText("Wymiary magnesu:");


            EK1.D1 = Single.Parse(tbD.Text);
            tbInfo.AppendText("Średnica:  "+ EK1.D1.ToString() + " [m]\n");
            

            EK1.Hs = Single.Parse(tbHs.Text);
            tbInfo.AppendText("Wysokość stopy: " + EK1.Hs.ToString() + " [m]\n");

            EK1.H = Single.Parse(tbH.Text);
            tbInfo.AppendText("Wysokość: " + EK1.H.ToString() + " [m]\n");
            
            EK1.Hp = Single.Parse(tbHp.Text);
            tbInfo.AppendText("Wysokość pokrywy: " + EK1.Hp.ToString() + " [m]\n");
            
            
            EK1.importBH();
            EK1.importWire();
            EK1.plotBH(chartBh);

            if (EK1.Calculate())
            {
                tbInfo.AppendText("Obliczenia przebiegły pomyślnie \n");
                if (EK1.RealJ > EK1.Jd)
                {
                    String napis = "Prąd przekroczył wartość dopuszczalną!";
                    tbInfo.AppendText(napis + "\n");
                    MessageBox.Show(napis);
                }

                tbInfo.AppendText("Szerokość cewki: " + Math.Round(EK1.C, 4).ToString() + " [m]\n");

                tbInfo.AppendText("Wysokość całkowita : " + Math.Round(EK1.Hz, 4).ToString() + " [M]\n");

                tbInfo.AppendText("*************************************************************************************************************************************\n");
                tbInfo.AppendText("Pola Powierzchni: \n");

                tbInfo.AppendText("Pole powierzchni nura: "+ Math.Round(EK1.Sn, 5).ToString()+ " [M^2]\n");

                tbInfo.AppendText("Pole powierzchni obudowy: " + Math.Round(EK1.Sn, 5).ToString()+" []\n");

                tbInfo.AppendText("Pole Szczeliny: " +  Math.Round(EK1.So, 6).ToString() + " []\n");

                tbInfo.AppendText("*************************************************************************************************************************************\n");
                tbInfo.AppendText(" Oblicznia strumienia magnetycznego\n");
                tbInfo.AppendText("Strumień : " + Math.Round(EK1.Fi, 7).ToString() + " []\n");

                tbInfo.AppendText("*************************************************************************************************************************************\n"); 
                tbInfo.AppendText("Obliczenia indukcji\n");
                tbInfo.AppendText("Pokrywa: " + Math.Round(EK1.Bp, 6).ToString() + " []\n");

                tbInfo.AppendText("Obudowy: " + EK1.Bo.ToString() + " []\n");

                tbInfo.AppendText("Szczelina pasożytnicza: " + Math.Round(EK1.Bsp, 2).ToString() + "[T]\n");

                tbInfo.AppendText("*************************************************************************************************************************************\n");
                tbInfo.AppendText("Obliczenia natężenia pól \n");

                tbInfo.AppendText("Szczelina: " + EK1.OHs.ToString() + " [A/m]\n");

                tbInfo.AppendText("Nur: " + EK1.OHn.ToString() + " [A/m]\n");

                tbInfo.AppendText("Pokrywa: " + EK1.OHp.ToString() + " [A/m]\n");

                tbInfo.AppendText("Obudowa: " + EK1.OHo.ToString() + " [A/m]\n");

                tbInfo.AppendText("Szczelina powietrzna: " + EK1.OHsp.ToString() + " [A/m]\n");

                tbInfo.AppendText("*************************************************************************************************************************************\n");
                tbInfo.AppendText("Przepływ prądu: \n");

                tbInfo.AppendText("Stopa: " + Math.Round(EK1.Vst, 2).ToString() + " [A]\n");

                tbInfo.AppendText("Nur: " + Math.Round(EK1.Vn, 2).ToString() + " [A]\n");

                tbInfo.AppendText("Szczelina: " + Math.Round(EK1.Vs, 2).ToString() + " [A]\n");

                tbInfo.AppendText("Pokrywa: " + Math.Round(EK1.Vp, 2).ToString() + " [A]\n");

                tbInfo.AppendText("Obudowa: " + Math.Round(EK1.Vo, 2).ToString() + " [A]\n");

                tbInfo.AppendText("*************************************************************************************************************************************\n");
                tbInfo.AppendText("Obliczenia przewodu; \n");

                tbInfo.AppendText("Liczba zwojów: " + EK1.Z.ToString() + " [Liczba zwojów]\n");

                tbInfo.AppendText("Średnica przewodu: " + EK1.Dpo.ToString() + " [m]\n");

                tbInfo.AppendText("So: " + EK1.So.ToString() + " []\n");

                tbInfo.AppendText("Pole powierzchni miedzi: " + Math.Round(EK1.Scu, 6).ToString() + " [m^2]\n");

                tbInfo.AppendText("Gęstość prądu: " + Math.Round(EK1.J).ToString() + " [A/m^2] \n");

                tbInfo.AppendText("*************************************************************************************************************************************\n");
                tbInfo.AppendText("Obliczenia liczby zwojów: \n");

                tbInfo.AppendText("Średnia długość: " + Math.Round(EK1.Lsr, 2).ToString() + " [m]\n");

                tbInfo.AppendText("Prąd: " + Math.Round(EK1.Id, 2).ToString() + " [A]\n");

                EK1.Dpo = EK1.Dpo * 1000;
                tbInfo.AppendText("Średnica przewodu: " + Math.Round(EK1.Dpo, 3).ToString() + " [mm]\n");

                EK1.Spo = EK1.Spo * 1000000;
                tbInfo.AppendText("Pole powierzchni przewodu: " + Math.Round(EK1.Spo, 3).ToString() + " [mm^2] \n");

            }
            else
            {
                String napis = "Wystąpił błąd!";
                tbInfo.AppendText(napis + "\n");
                MessageBox.Show(napis);
            }

            tbInfo.AppendText("*************************************************************************************************************************************\n");
            tbInfo.AppendText("Koniec obliczeń \n");
            tbInfo.AppendText("*************************************************************************************************************************************\n");





        }

                          
       


        private void TpStructure_Paint(object sender, PaintEventArgs e)
        {
            int wysokosc = TbStructure.Height;
            int szerokosc = TbStructure.Width;
            label11.Text = "Wysokosc:" + wysokosc.ToString() + "Szerokosc:" + szerokosc.ToString() ;

            Pen p1 = new Pen (Color.Black, 3);

            Point[] pole1 =
            {
                (new Point(szerokosc*18/40, wysokosc*3/20)),
                (new Point(szerokosc*6/20,  wysokosc*3/20)),
                (new Point(szerokosc*6/20,  wysokosc*8/10)),
                (new Point(szerokosc*18/40, wysokosc*8/10))
            };

            Point[] pole2 =
            {
                (new Point(szerokosc*22/40,wysokosc*3/20)),
                (new Point(szerokosc*14/20, wysokosc*3/20)),
                (new Point(szerokosc*14/20, wysokosc*8/10)),
                (new Point(szerokosc*22/40, wysokosc*8/10))
            };

            Point[] pole3 =
            {
                (new Point(szerokosc*18/40, wysokosc*1/10)),
                (new Point(szerokosc*22/40, wysokosc*1/10)),
                (new Point(szerokosc*22/40, wysokosc*7/10)),
                (new Point(szerokosc*18/40, wysokosc*7/10))
            };

            Point[] pole4 =
            {
                (new Point(szerokosc*18/40, wysokosc*3/20)),
                (new Point(szerokosc*5/20,  wysokosc*3/20)),
                (new Point(szerokosc*5/20,  wysokosc*17/20)),
                (new Point(szerokosc*15/20, wysokosc*17/20)),
                (new Point(szerokosc*15/20, wysokosc*3/20)),
                (new Point(szerokosc*22/40, wysokosc*3/20)),
                (new Point(szerokosc*22/40, wysokosc/5)),
                (new Point(szerokosc*14/20, wysokosc/5)),
                (new Point(szerokosc*14/20, wysokosc*4/5)),
                (new Point(szerokosc*6/20,  wysokosc*4/5)),
                (new Point(szerokosc*6/20,  wysokosc/5)),
                (new Point(szerokosc*18/40, wysokosc/5)),
            };

            Point[] pole5 =
           {
                (new Point(szerokosc*18/40, wysokosc*16/20)),
                (new Point(szerokosc*22/40, wysokosc*16/20)),
                (new Point(szerokosc*22/40, wysokosc*14/20)),
                (new Point(szerokosc*18/40, wysokosc*14/20))
            };


            e.Graphics.DrawPolygon(p1, pole1);
            e.Graphics.DrawPolygon(p1, pole2);
            e.Graphics.DrawPolygon(p1, pole3);
            e.Graphics.DrawPolygon(p1, pole4);
            e.Graphics.DrawPolygon(p1, pole5);

            p1.Dispose();

            
        }

        private void btnSavePicture_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd1 = new SaveFileDialog();
            sfd1.Filter = "Bitmap files|*.bmp|EMF files|*.emf|JPEG files|*.jpeg";
            sfd1.InitialDirectory = Application.StartupPath;

            if (sfd1.ShowDialog() == DialogResult.OK)
            {
                    Bitmap bmp1 = new Bitmap(TbStructure.Width, TbStructure.Height);
                    TbStructure.DrawToBitmap(bmp1, (new Rectangle(0, 0, bmp1.Width, bmp1.Height)));
                    switch (sfd1.FilterIndex)
                    {
                        case 1:
                            bmp1.Save(sfd1.FileName, ImageFormat.Bmp);
                            break;
                        case 2:
                            bmp1.Save(sfd1.FileName, ImageFormat.Emf);
                            break;
                        case 3:
                            bmp1.Save(sfd1.FileName, ImageFormat.Jpeg);
                            break;
                    }
                
            }
        }
    }
}
