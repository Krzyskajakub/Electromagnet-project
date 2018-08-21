using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elektromagnes
{
    class ElektromagnesNurnikowy : Elektromagnes
    {
        private double x;
        private double xp;
        private double k;
        private double hs;
        private double hp;
        private double sn;
        private double d;
        private double c;
        private double hz;
        private double dz;
        private double sp;
        private double so;
        private double ssp;
        private double su;
        private double fi;
        private double oHs;
        private double oHn;
        private double oHp;
        private double oHo;
        private double oHsp;
        private double vs;
        private double vst;
        private double vn;
        private double vp;
        private double vo;
        private double vsp;
        private double teta;



        //set and get fuctions
        public double X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public double Xp
        {
            get
            {
                return xp;
            }

            set
            {
                xp = value;
            }
        }

        public double K
        {
            get
            {
                return k;
            }

            set
            {
                k = value;
            }
        }

        public double Hp
        {
            get
            {
                return hp;
            }

            set
            {
                hp = value;
            }
        }

        public double Hs
        {
            get
            {
                return hs;
            }

            set
            {
                hs = value;
            }
        }

        public double Hz
        {
            get
            {
                return hz;
            }

            set
            {
                hz = value;
            }
        }

        public double Sn
        {
            get
            {
                return sn;
            }

            set
            {
                sn = value;
            }
        }

        public double D
        {
            get
            {
                return d;
            }

            set
            {
                d = value;
            }
        }

        public double C
        {
            get
            {
                return c;
            }

            set
            {
                c = value;
            }
        }

        public double Su
        {
            get
            {
                return su;
            }

            set
            {
                su = value;
            }
        }

        public double Sp
        {
            get
            {
                return sp;
            }

            set
            {
                sp = value;
            }
        }

        public double So
        {
            get
            {
                return so;
            }

            set
            {
                so = value;
            }
        }

        public double Ssp
        {
            get
            {
                return ssp;
            }

            set
            {
                ssp = value;
            }
        }

        public double Fi
        {
            get
            {
                return fi;
            }

            set
            {
                fi = value;
            }
        }


        public double Dz
        {
            get
            {
                return dz;
            }

            set
            {
                dz = value;
            }
        }

        public double OHs
        {
            get
            {
                return oHs;
            }

            set
            {
                oHs = value;
            }
        }

        public double OHsp1
        {
            get
            {
                return OHsp;
            }

            set
            {
                OHsp = value;
            }
        }

        public double OHo
        {
            get
            {
                return oHo;
            }

            set
            {
                oHo = value;
            }
        }

        public double OHp
        {
            get
            {
                return oHp;
            }

            set
            {
                oHp = value;
            }
        }

        public double OHn
        {
            get
            {
                return oHn;
            }

            set
            {
                oHn = value;
            }
        }

        public double OHsp
        {
            get
            {
                return oHsp;
            }

            set
            {
                oHsp = value;
            }
        }

        public double Vs
        {
            get
            {
                return vs;
            }

            set
            {
                vs = value;
            }
        }

        public double Vst
        {
            get
            {
                return vst;
            }

            set
            {
                vst = value;
            }
        }

        public double Vn
        {
            get
            {
                return vn;
            }

            set
            {
                vn = value;
            }
        }

        public double Vp
        {
            get
            {
                return vp;
            }

            set
            {
                vp = value;
            }
        }

        public double Vo
        {
            get
            {
                return vo;
            }

            set
            {
                vo = value;
            }
        }

        public double Vsp
        {
            get
            {
                return vsp;
            }

            set
            {
                vsp = value;
            }
        }

        public double Teta
        {
            get
            {
                return teta;
            }

            set
            {
                teta = value;
            }
        }

        //obliczenia
        public bool Calculate()
        {
            Geometria();
            Polepowierzchni();
            Strumien();
            Induction();
            NatęzeniePola();
            Przepływ();
            NatężrniePrzepływu();
            Cewka();
            Line();
            if (Indukcja == 0) return false;
            if (Sp == 0 || So == 0 || Ssp == 0) return false;
            if (Scu == 0) return false;
            if (TemperaturaMax == TemperaturaOtoczenia || Jd == 0 || Lsr == 0) return false;
            return true;
        }

        public void Geometria()
        {
            Sn = 2 * SilaObciazenia * PrzenikalnoscProznia / (Indukcja * Indukcja);
            D = Math.Sqrt(4 * Sn / Math.PI);
            C = (D1 - D) / 2;
            Hz = H + (2 * Hp);
            Dz = D1 + (2 * hp);
        }

        public void Polepowierzchni()
        {
            Sp = Hp * Math.PI * (D1 + D);
            So = Math.PI * ((Dz * Dz) - (D1 * D1)) / 4;
            Ssp = Math.PI * D * Hp;
            Su = C * H;
        }

        public void Strumien()
        {
            Fi = Indukcja * Sn;
        }

        public void Induction()
        {
            Bp = Fi / Sp;
            Bo = Fi / So;
            Bsp = Fi / Ssp;
        }

        public void NatęzeniePola()
        {
            OHs = Indukcja / PrzenikalnoscProznia;
            OHn = getH(Indukcja);
            OHp = getH(Bp);
            OHo = getH(Bo);
            OHsp = Bsp / PrzenikalnoscProznia;
        }


        public void Przepływ()
        {
            Vs = OHs * X;
            Vst = OHs * (X + Hp / 2);
            Vn = OHn * (H - Hs - X + Hp / 2);
            Vp = OHp * (D1 + Hp) / 2;
            Vo = OHo * (H + Hp);
            Vsp = OHsp * Xp;
            Teta = Vs + Vst + Vp + Vo + Vsp;
        }

        public void NatężrniePrzepływu()
        {
            Scu = StalaK * Su;
            J = Teta / Scu;
        }

        public void Cewka()
        {
            Lsr = Math.PI * (D + D1) / 2;
            Z = NapiecieZasilania * 58600000 / ((1 + 0.004 * (TemperaturaMax - TemperaturaOtoczenia)) * Jd * Lsr);
            Z = Math.Round(Z);
        }
        public void Line()
        {

            Id = Teta / Z;
            Spo = Id / Jd;
            Dpo = 2 * Math.Sqrt(Spo / Math.PI);
            Dpo = getWire(Dpo);
        }

    }
}


    

