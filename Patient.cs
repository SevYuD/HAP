using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAP
{
    class Patient
    {
        private string name;
        private string surname;
        private string otchestvo;
        private byte povtIm;
        private byte gender;
        private byte IMinAnamnes;
        private byte SDinAnamnes;
        private int age;
        private float IMT;
        private byte smoking;
        private byte Hb;
        private byte leycocits;
        private byte SOE;
        private byte gluk;
        private byte oProtein;
        private byte biliburin;
        private byte ALAT;
        private byte ASAT;
        private byte creatin;
        private byte HC;
        private byte LPNP;
        private byte LPVP;
        private byte triglicirin;
        private byte indAterog;
        private byte SKF;
        private byte KcR;
        private byte LP;
        private byte KDRLG;
        private byte TMPG;
        private byte TZSLG;
        private byte FV;
        private byte ishemia;
        private byte HSN;
        private byte FKHCN;
        private byte depres;
        private byte TTG;
        private byte T4;
        private byte alphaINF;
        private byte gammaINF;
        private byte IL1;
        private byte IL8;
        private byte IL4;
        private byte IL6;
        private byte IL10;
        private byte NTproBNP;
        private byte FNO;
        private byte aldester;
        private byte leptin;
        private byte adiponectin;
        private float HbValue;
        private float leycocitsValue;
        private float SOEValue;
        private float glukValue;
        private float oProteinValue;
        private float biliburinValue;
        private float ALATValue;
        private float ASATValue;
        private float creatinValue;
        private float HCValue;
        private float LPNPValue;
        private float LPVPValue;
        private float triglicirinValue;
        private float indAterogValue;
        private float SKFValue;
        private float KcRValue;
        private float LPValue;
        private float KDRLGValue;
        private float TMPGValue;
        private float TZSLGValue;
        private float FVValue;
        private float depresValue;
        private float TTGValue;
        private float T4Value;
        private float alphaINFValue;
        private float gammaINFValue;
        private float IL1Value;
        private float IL8Value;
        private float IL4Value;
        private float IL6Value;
        private float IL10Value;
        private float NTproBNPValue;
        private float FNOValue;
        private float aldesterValue;
        private float leptinValue;
        private float adiponectinValue;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Otchestvo { get => otchestvo; set => otchestvo = value; }
        public byte PovtIm { get => povtIm; set => povtIm = value; }
        public byte Gender { get => gender; set => gender = value; }
        public byte IMinAnamnes1 { get => IMinAnamnes; set => IMinAnamnes = value; }
        public byte SDinAnamnes1 { get => SDinAnamnes; set => SDinAnamnes = value; }
        public int Age { get => age; set => age = value; }
        public float IMT1 { get => IMT; set => IMT = value; }
        public byte Smoking { get => smoking; set => smoking = value; }
        public byte Hb1 { get => Hb; set => Hb = value; }
        public byte Leycocits { get => leycocits; set => leycocits = value; }
        public byte SOE1 { get => SOE; set => SOE = value; }
        public byte Gluk { get => gluk; set => gluk = value; }
        public byte OProtein { get => oProtein; set => oProtein = value; }
        public byte Biliburin { get => biliburin; set => biliburin = value; }
        public byte ALAT1 { get => ALAT; set => ALAT = value; }
        public byte ASAT1 { get => ASAT; set => ASAT = value; }
        public byte Creatin { get => creatin; set => creatin = value; }
        public byte HC1 { get => HC; set => HC = value; }
        public byte LPNP1 { get => LPNP; set => LPNP = value; }
        public byte LPVP1 { get => LPVP; set => LPVP = value; }
        public byte Triglicirin { get => triglicirin; set => triglicirin = value; }
        public byte IndAterog { get => indAterog; set => indAterog = value; }
        public byte SKF1 { get => SKF; set => SKF = value; }
        public byte KcR1 { get => KcR; set => KcR = value; }
        public byte LP1 { get => LP; set => LP = value; }
        public byte KDRLG1 { get => KDRLG; set => KDRLG = value; }
        public byte TMPG1 { get => TMPG; set => TMPG = value; }
        public byte TZSLG1 { get => TZSLG; set => TZSLG = value; }
        public byte FV1 { get => FV; set => FV = value; }
        public byte Ishemia { get => ishemia; set => ishemia = value; }
        public byte HSN1 { get => HSN; set => HSN = value; }
        public byte FKHCN1 { get => FKHCN; set => FKHCN = value; }
        public byte Depres { get => depres; set => depres = value; }
        public byte TTG1 { get => TTG; set => TTG = value; }
        public byte T41 { get => T4; set => T4 = value; }
        public byte AlphaINF { get => alphaINF; set => alphaINF = value; }
        public byte GammaINF { get => gammaINF; set => gammaINF = value; }
        public byte IL11 { get => IL1; set => IL1 = value; }
        public byte IL81 { get => IL8; set => IL8 = value; }
        public byte IL41 { get => IL4; set => IL4 = value; }
        public byte IL61 { get => IL6; set => IL6 = value; }
        public byte IL101 { get => IL10; set => IL10 = value; }
        public byte NTproBNP1 { get => NTproBNP; set => NTproBNP = value; }
        public byte FNO1 { get => FNO; set => FNO = value; }
        public byte Aldester { get => aldester; set => aldester = value; }
        public byte Leptin { get => leptin; set => leptin = value; }
        public byte Adiponectin { get => adiponectin; set => adiponectin = value; }
        public float HbValue1 { get => HbValue; set => HbValue = value; }
        public float LeycocitsValue { get => leycocitsValue; set => leycocitsValue = value; }
        public float SOEValue1 { get => SOEValue; set => SOEValue = value; }
        public float GlukValue { get => glukValue; set => glukValue = value; }
        public float OProteinValue { get => oProteinValue; set => oProteinValue = value; }
        public float BiliburinValue { get => biliburinValue; set => biliburinValue = value; }
        public float ALATValue1 { get => ALATValue; set => ALATValue = value; }
        public float ASATValue1 { get => ASATValue; set => ASATValue = value; }
        public float CreatinValue { get => creatinValue; set => creatinValue = value; }
        public float HCValue1 { get => HCValue; set => HCValue = value; }
        public float LPNPValue1 { get => LPNPValue; set => LPNPValue = value; }
        public float LPVPValue1 { get => LPVPValue; set => LPVPValue = value; }
        public float TriglicirinValue { get => triglicirinValue; set => triglicirinValue = value; }
        public float IndAterogValue { get => indAterogValue; set => indAterogValue = value; }
        public float SKFValue1 { get => SKFValue; set => SKFValue = value; }
        public float KcRValue1 { get => KcRValue; set => KcRValue = value; }
        public float LPValue1 { get => LPValue; set => LPValue = value; }
        public float KDRLGValue1 { get => KDRLGValue; set => KDRLGValue = value; }
        public float TMPGValue1 { get => TMPGValue; set => TMPGValue = value; }
        public float TZSLGValue1 { get => TZSLGValue; set => TZSLGValue = value; }
        public float FVValue1 { get => FVValue; set => FVValue = value; }
        public float DepresValue { get => depresValue; set => depresValue = value; }
        public float TTGValue1 { get => TTGValue; set => TTGValue = value; }
        public float T4Value1 { get => T4Value; set => T4Value = value; }
        public float AlphaINFValue { get => alphaINFValue; set => alphaINFValue = value; }
        public float GammaINFValue { get => gammaINFValue; set => gammaINFValue = value; }
        public float IL1Value1 { get => IL1Value; set => IL1Value = value; }
        public float IL8Value1 { get => IL8Value; set => IL8Value = value; }
        public float IL4Value1 { get => IL4Value; set => IL4Value = value; }
        public float IL6Value1 { get => IL6Value; set => IL6Value = value; }
        public float IL10Value1 { get => IL10Value; set => IL10Value = value; }
        public float NTproBNPValue1 { get => NTproBNPValue; set => NTproBNPValue = value; }
        public float FNOValue1 { get => FNOValue; set => FNOValue = value; }
        public float AldesterValue { get => aldesterValue; set => aldesterValue = value; }
        public float LeptinValue { get => leptinValue; set => leptinValue = value; }
        public float AdiponectinValue { get => adiponectinValue; set => adiponectinValue = value; }
    }
}
