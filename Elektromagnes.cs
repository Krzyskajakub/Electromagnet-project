using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;



namespace elektromagnes
{
    class Elektromagnes
    {

        private double napiecieZasilania;
        private double silaObciazenia;
        private double szczelinaPowietrzna;
        private double indukcja;
        private double szczelinaPasozytnicza;
        private double temperaturaOtoczenia;
        private double temperaturaMax;
        private double przenikalnoscProznia;
        private double stalaY;
        private double stalaK;
        private double D;
        private double h;
        private double scu;
        private double j;
        private double jd = 5000000;
        private double lsr;
        private double z;
        private double id;
        private double spo;
        private double dpo;
        private double realR;
        private double realI;
        private double realJ;
        private double realTeta;
        private double bp;
        private double bo;
        private double bsp;

        public float[] Wire;
        public float[,] BH;


        public void importBH()
        {
            String fileNameBH = "BH.txt";
            FileStream fileBH = new FileStream(fileNameBH, FileMode.Open);
            StreamReader srBH = new StreamReader(fileBH);
            ArrayList arrayText = new ArrayList();
            string dataText = "";

            try
            {
                while (dataText != null)
                {
                    dataText = srBH.ReadLine();
                    if (dataText != null)
                        arrayText.Add(dataText);
                }
            }

            finally
            {
                fileBH.Close();
            }

            int lw = arrayText.Count;
            int lk = 2;
            BH = new float[lw, lk];
            for (int i = 0; i < lw; i++)
            {
                string wiersz = arrayText[i].ToString();
                wiersz = wiersz.Replace('.', ',');
                string[] elementyWiersza = wiersz.Split('\t');
                for (int j = 0; j < lk; j++)
                    BH[i, j] = Single.Parse(elementyWiersza[j]);
            }

        }

        public void plotBH(Chart chartBh)
        {
            Axis axisX = chartBh.ChartAreas[0].AxisX;
            axisX.Title = "H [A/m]";
            axisX.Interval = 50000;
            axisX.Minimum = 0;
            axisX.Maximum = 300000;
            axisX.Crossing = 0;

            Axis axisY = chartBh.ChartAreas[0].AxisY;
            axisY.Title = "B [T]";
            axisY.LabelStyle.Format = "0.00";
            axisY.Interval = 0.2;
            axisY.Minimum = 0;
            axisY.Maximum = 2.6;
            axisY.Crossing = 0;

            chartBh.Series.Clear();

            Series seriaBH = chartBh.Series.Add("B=f(h)");
            seriaBH.ChartType = SeriesChartType.Line;
            seriaBH.BorderWidth = 1;
            seriaBH.Color = System.Drawing.Color.Red;

            for (int i = 0; i < BH.GetLength(0); i++)
                seriaBH.Points.AddXY(BH[i, 0], BH[i, 1]);
        }

        public void importWire()
        {
            String fileNameWire = "drut.txt";
            FileStream fileWire = new FileStream(fileNameWire, FileMode.Open);
            StreamReader srWire = new StreamReader(fileWire);

            ArrayList arrayText = new ArrayList();                          //konstruktor
            string dataText = "";            // array text kazdy element jest  1 wierszem z pliku 
            try
            {
                while (dataText != null)
                {
                    dataText = srWire.ReadLine();                          //odczyt 
                    if (dataText != null)
                        arrayText.Add(dataText);                            // dodanie do tablicy
                }
            }
            finally
            {
                fileWire.Close();
            }

            int lw = arrayText.Count;

            Wire = new float[lw];
            for (int i = 0; i < lw; i++)
            {
                string wiersz = arrayText[i].ToString();                //pobranie 1 calego wiersza
                wiersz = wiersz.Replace('.', ',');                      //zamiana kropek na przecinki
                Wire[i] = Single.Parse(wiersz);
            }
        }

        public double getH(double B)
        {


            double Bmin = 0;
            double Bmax = 0;
            double H1 = 0;
            double H2 = 0;

            for (int i = 0; i < BH.GetLength(0); i++)
            {
                if ((i + 1) < BH.GetLength(0))
                {
                    Bmin = BH[i, 1];
                    Bmax = BH[i + 1, 1];                                 // Wiersz nr i, kolumna 1
                }
                if (B > Bmin && B < Bmax)
                {
                    H1 = BH[i, 0];
                    H2 = BH[i + 1, 0];
                    break;
                }
            }


            double Hx = H1 + (H2 - H1) / (Bmax - Bmin) * (B - Bmin);
            return Hx;
        }

        public double getWire(double W)
                {
                    W = 1000 * W;
                    double WireMax = 0;
                    double WireMin = 0;
                    for (int i = 0; i < Wire.GetLength(0); i++)
                    {
                        if ((i + 1) < Wire.GetLength(0))
                        {
                            WireMin = Wire[i];
                            WireMax = Wire[i + 1];
                        }
                        if (W > WireMin && W < WireMax) break;
                    }
                   

                    if (W - WireMin > WireMax - W) return WireMin / 1000;
                    else return WireMax / 1000;

                }

                public double getB(double H)
                {

                    double Hmin = 0;
                    double Hmax = 0;
                    double B1 = 0;
                    double B2 = 0;

                    for (int i = 0; i < BH.GetLength(0); i++)
                    {
                        if ((i + 1) < BH.GetLength(0))
                        {
                            Hmin = BH[i, 0];
                            Hmax = BH[i + 1, 0];                                                            // nr wiersza, 1 kolumna 
                        }
                        if (H > Hmin && H < Hmax)
                        {
                            B1 = BH[i, 1];
                            B2 = BH[i + 1, 1];
                            break;
                        }
                    }

                    
                    double Bx = B1 + (B2 - B1) / (Hmax - Hmin) * (H - Hmin);
                    return Bx;
                }

               

          

        public double NapiecieZasilania
        {
            get
            {
                return napiecieZasilania;
            }

            set
            {
                if (value > 0)
                {
                    napiecieZasilania = value;
                }
                else
                {
                    MessageBox.Show("Wartosc napiecia zasilania musi byc dodatnia!");
                }
            }
        }

        public  double SilaObciazenia
        {
            get
            {
                return silaObciazenia;
            }

            set
            {
                if (value > 0)
                {
                    silaObciazenia = value;
                }
                else
                {
                    MessageBox.Show("Wartosc Siły musi byc dodatnia!");
                }
            }
            
            
        }

        public double SzczelinaPowietrzna
        {
            get
            {
                return szczelinaPowietrzna;
            }

            set
            {
                if (value > 0)
                {
                    szczelinaPowietrzna = value;
                }
                else
                {
                    MessageBox.Show("Wartosc szczeliny powietrznej musi byc dodatnia!");
                }
            }
        }

        public double Indukcja
        {
            get
            {
                return indukcja;
            }

            set
            {
                if (value > 0)
                {
                    indukcja = value;
                }
                else
                {
                    MessageBox.Show("Wartosc indukcji musi byc dodatnia!");
                }
            }
        }

        public double SzczelinaPasozytnicza
        {
            get
            {
                return szczelinaPasozytnicza;
            }

            set
            {
                if (value > 0)
                {
                    szczelinaPasozytnicza = value;
                }
                else
                {
                    MessageBox.Show("Wartosc szczeliny pasozytniczej musi byc dodatnia!");
                }
            }
        }

        public double TemperaturaOtoczenia
        {
            get
            {
                return temperaturaOtoczenia;
            }

            set
            {
                temperaturaOtoczenia = value;
                                
            }
        }

        public double TemperaturaMax
        {
            get
            {
                return temperaturaMax;
            }

            set
            {
                 temperaturaMax = value;
            }
        }


        public double PrzenikalnoscProznia
        {
            get
            {
                return przenikalnoscProznia;
            }

            set
            {
                if (value > 0)
                {
                   przenikalnoscProznia = value;
                }
                else
                {
                    MessageBox.Show("Wartosc musi byc dodatnia!");
                }
            }
        }

        public double StalaY
        {
            get
            {
                return stalaY;
            }

            set
            {
                if (value > 0)
                {
                    stalaY = value;
                }
                else
                {
                    MessageBox.Show("Wartosc musi byc dodatnia!");
                }
            }
        }


        public double StalaK
        {
            get
            {
                return stalaK;
            }

            set
            {
                if (value > 0)
                {
                    stalaK = value;
                }
                else
                {
                    MessageBox.Show("Wartosc musi byc dodatnia!");
                }
            }

        }
        public double D1
        {
            get
            {
                return D;
            }

            set
            {
                D = value;
            }
        }


        public double H { get => h; set => h = value; }
        public double Scu { get => scu; set => scu = value; }
        public double J { get => j; set => j = value; }
        public double Jd { get => jd; set => jd = value; }
        public double Lsr { get => lsr; set => lsr = value; }
        public double Z { get => z; set => z = value; }
        public double Id { get => id; set => id = value; }
        public double Spo { get => spo; set => spo = value; }
        public double Dpo { get => dpo; set => dpo = value; }
        public double RealR { get => realR; set => realR = value; }
        public double RealI { get => realI; set => realI = value; }
        public double RealJ { get => realJ; set => realJ = value; }
        public double RealTeta { get => realTeta; set => realTeta = value; }
        public double Bp { get => bp; set => bp = value; }
        public double Bo { get => bo; set => bo = value; }
        public double Bsp { get => bsp; set => bsp = value; }
    }

}
