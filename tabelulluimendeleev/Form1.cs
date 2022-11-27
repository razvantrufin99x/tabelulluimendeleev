using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tabelulluimendeleev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public List<elementchimic> tabelulelementelor = new List<elementchimic>();
        public int nrel = 10 * 19;

        public void setLabel(string s)
        {
            label1.Text = s;
        }

        public int[,] pozitieelemente = 
            {
{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
{0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2},
{0,3,4,0,0,0,0,0,0,0,0,0,0,5,6,7,8,9,10},
{0,11,12,0,0,0,0,0,0,0,0,0,0,13,14,15,16,17,18},
{0,19,21,21,22,23,24,25,26,27,28,29,30,31,32,33,34,34,36},
{0,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54},
{0,55,56,0,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86},
{0,87,88,0,104,105,106,107,108,109,110,111,112,113,114,115,116,117,118},
{0,0,0,0,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71},
{0,0,0,0,89,90,91,92,93,94,95,96,97,98,99,100,101,102,103},
};

        public string[,] elementele = { 
{"0","0","0"},
{"1","Hidrogen","H"},
{"2","Heliu","He"},
{"3","Litiu","Li"},
{"4","Beriliu","Be"},
{"5","Bor","B"},
{"6","Carbon","C"},
{"7","Azot, Nitrogen","N"},
{"8","Oxigen","O"},
{"9","Fluor","F"},
{"10","Neon","Ne"},
{"11","Sodiu, Natriu","Na"},
{"12","Magneziu","Mg"},
{"13","Aluminiu","Al"},
{"14","Siliciu","Si"},
{"15","Fosfor","P"},
{"16","Sulf","S"},
{"17","Clor","Cl"},
{"18","Argon","Ar"},
{"19","Potasiu, Kaliu","K"},
{"20","Calciu","Ca"},
{"21","Scandiu","Sc"},
{"22","Titan","Ti"},
{"23","Vanadiu","V"},
{"24","Crom","Cr"},
{"25","Mangan","Mn"},
{"26","Fier","Fe"},
{"27","Cobalt","Co"},
{"28","Nichel","Ni"},
{"29","Cupru","Cu"},
{"30","Zinc","Zn"},
{"31","Galiu","Ga"},
{"32","Germaniu","Ge"},
{"33","Arsen","As"},
{"34","Seleniu","Se"},
{"35","Brom","Br"},
{"36","Kripton","Kr"},
{"37","Rubidiu","Rb"},
{"38","Stronțiu","Sr"},
{"39","Ytriu","Y"},
{"40","Zirconiu","Zr"},
{"41","Niobiu","Nb"},
{"42","Molibden","Mo"},
{"43","Technețiu","Tc"},
{"44","Ruteniu","Ru"},
{"45","Rodiu","Rh"},
{"46","Paladiu","Pd"},
{"47","Argint","Ag"},
{"48","Cadmiu","Cd"},
{"49","Indiu","In"},
{"50","Staniu","Sn"},
{"51","Stibiu, Antimoniu","Sb"},
{"52","Telur","Te"},
{"53","Iod","I"},
{"54","Xenon","Xe"},
{"55","Cesiu","Cs"},
{"56","Bariu","Ba"},
{"57","Lantan","La"},
{"58","Ceriu","Ce"},
{"59","Praseodim","Pr"},
{"60","Neodim","Nd"},
{"61","Promețiu","Pm"},
{"62","Samariu","Sm"},
{"63","Europiu","Eu"},
{"64","Gadoliniu","Gd"},
{"65","Terbiu","Tb"},
{"66","Disprosiu","Dy"},
{"67","Holmiu","Ho"},
{"68","Erbiu","Er"},
{"69","Tuliu","Tm"},
{"70","Yterbiu","Yb"},
{"71","Lutețiu","Lu"},
{"72","Hafniu","Hf"},
{"73","Tantal","Ta"},
{"74","Wolfram, Tungsten","W"},
{"75","Reniu","Re"},
{"76","Osmiu","Os"},
{"77","Iridiu","Ir"},
{"78","Platină","Pt"},
{"79","Aur","Au"},
{"80","Mercur","Hg"},
{"81","Taliu","Tl"},
{"82","Plumb","Pb"},
{"83","Bismut","Bi"},
{"84","Poloniu","Po"},
{"85","Astatin","At"},
{"86","Radon","Rn"},
{"87","Franciu","Fr"},
{"88","Radiu","Ra"},
{"89","Actiniu","Ac"},
{"90","Thoriu","Th"},
{"91","Protactiniu","Pa"},
{"92","Uraniu","U"},
{"93","Neptuniu","Np"},
{"94","Plutoniu","Pu"},
{"95","Americiu","Am"},
{"96","Curiu","Cm"},
{"97","Berkeliu","Bk"},
{"98","Californiu","Cf"},
{"99","Einsteiniu","Es"},
{"100","Fermiu","Fm"},
{"101","Mendeleviu","Md"},
{"102","Nobeliu","No"},
{"103","Lawrenciu","Lr"},
{"104","Rutherfordiu","Rf"},
{"105","Dubniu","Db"},
{"106","Seaborgiu","Sg"},
{"107","Bohriu","Bh"},
{"108","Hassiu","Hs"},
{"109","Meitneriu","Mt"},
{"110","Darmstadtiu","Ds"},
{"111","Roentgeniu","Rg"},
{"112","Coperniciu","Cn"},
{"113","Nihoniu","Nh"},
{"114","Fleroviu","Fl"},
{"115","Moscoviu","Mc"},
{"116","Livermoniu","Lv"},
{"117","Tennessine","Ts"},
{"118","Oganesson","Og"},
{"119","Ununenniu","Uue"},
{"120","Unbinilium","Ubn"},
{"tabel","elemente chimice","mendeleev"}


                                      };

        public void loadelements()
        {
            tabelulelementelor.Add(new elementchimic());
            for (int el = 1; el < 122; el++)
            {
                tabelulelementelor.Add(new elementchimic());

            }
        }
        public void drawtheT()
        {
            // merge bine 
            int ii = 1;
            int v = 0;
           for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k < 19; k++)
                {
                    
                    if (pozitieelemente[i, k] != 0)
                    {
                        v = pozitieelemente[i, k];
                        Controls.Add(tabelulelementelor[ii]);

                        Controls[ii].Left = k + tabelulelementelor[ii].Width * k + 5;
                        Controls[ii].Top = i + tabelulelementelor[ii].Height * i + 5;
                        tabelulelementelor[ii].setLabel((ii).ToString());
                        Controls[ii].Show();

                        tabelulelementelor[ii].setLabel(elementele[v, 0] + " \r\n " + elementele[v, 1] + " \r\n " + elementele[v, 2]);
                        
                        ii++;
                    }
                   
                }
            }
           
           
        }

        public void drawtheT2()
        {
            int j = 1;
            int ii = 1;
            for (int i = 0; i < nrel; i++)
            {
               
                Controls.Add(tabelulelementelor[i]);

                Controls[i].Left = tabelulelementelor[i].Width * ii + 5;
                Controls[i].Top = tabelulelementelor[i].Height * j + 5;
                tabelulelementelor[i].setLabel(i.ToString());
                Controls[i].Show();

                tabelulelementelor[i].setLabel(elementele[i, 0] + " \r\n " + elementele[i, 1] + " \r\n " + elementele[i, 2]);
                //tabelulelementelor[i].setLabel(elementele[i, 2]);

                ii++;
                if (i % 20 == 0) { j++; ii = 1; }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadelements();
            drawtheT();
            label1.Left = 308;
            label1.Top = 10;
        }
    }
}
