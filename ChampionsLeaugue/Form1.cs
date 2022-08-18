using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChampionsLeaugue
{
    public partial class Form1 : Form
    {
        List<Team> teams;
        List<ListBox> bags = new List<ListBox>();
        List<Team> ListBag1 = new List<Team>();
        List<Team> ListBag2 = new List<Team>();
        List<Team> ListBag3 = new List<Team>();
        List<Team> ListBag4 = new List<Team>();

        List<Team> ListGroupA = new List<Team>();
        List<Team> ListGroupB = new List<Team>();
        List<Team> ListGroupC = new List<Team>();
        List<Team> ListGroupD = new List<Team>();
        List<Team> ListGroupE = new List<Team>();
        List<Team> ListGroupF = new List<Team>();
        List<Team> ListGroupG = new List<Team>();
        List<Team> ListGroupH = new List<Team>();
        public Form1()
        {
            InitializeComponent();
        }

        private void listBag1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            Team newTeam = null;

            teams = new List<Team>();
            newTeam = new Team("Bayern Munich", "Almanya");
            teams.Add(newTeam);
            newTeam = new Team("Sevilla", "İspanya");
            teams.Add(newTeam);
            newTeam = new Team("Real Madrid", "İspanya");
            teams.Add(newTeam);
            newTeam = new Team("Liverpool", "İngiltere");
            teams.Add(newTeam);
            newTeam = new Team("Juventus", "İtalya");
            teams.Add(newTeam);
            newTeam = new Team("Paris Saint-Germain", "Fransa");
            teams.Add(newTeam);
            newTeam = new Team("Zenit", "Rusya");
            teams.Add(newTeam);
            newTeam = new Team("Porto", "Portekiz");
            teams.Add(newTeam);
            newTeam = new Team("Barcelona", "İspanya");
            teams.Add(newTeam);
            newTeam = new Team("Atlético Madrid", "İspanya");
            teams.Add(newTeam);
            newTeam = new Team("Manchester City", "İngiltere");
            teams.Add(newTeam);
            newTeam = new Team("Manchester United", "İngiltere");
            teams.Add(newTeam);
            newTeam = new Team("Borussia Dortmund", "Almanya");
            teams.Add(newTeam);
            newTeam = new Team("Shakhtar Donetsk", "Ukrayna");
            teams.Add(newTeam);
            newTeam = new Team("Chelsea", "İngiltere");
            teams.Add(newTeam);
            newTeam = new Team("Ajax", "Hollanda");
            teams.Add(newTeam);
            newTeam = new Team("Dynamo Kiev", "Ukrayna");
            teams.Add(newTeam);
            newTeam = new Team("Red Bull Salzburg", "Almanya");
            teams.Add(newTeam);
            newTeam = new Team("RB Leipzig", "Almanya");
            teams.Add(newTeam);
            newTeam = new Team("Internazionale", "İtalya");
            teams.Add(newTeam);
            newTeam = new Team("Olympiacos", "Yunanistan");
            teams.Add(newTeam);
            newTeam = new Team("Lazio", "İtalya");
            teams.Add(newTeam);
            newTeam = new Team("Krasnodar", "Rusya");
            teams.Add(newTeam);
            newTeam = new Team("Atalanta", "İtalya");
            teams.Add(newTeam);
            newTeam = new Team("Lokomotiv Moskova", "Rusya");
            teams.Add(newTeam);
            newTeam = new Team("Marseille", "Fransa");
            teams.Add(newTeam);
            newTeam = new Team("Club Brugge", "Belçika");
            teams.Add(newTeam);
            newTeam = new Team("Bor. Mönchengladbach", "Almanya");
            teams.Add(newTeam);
            newTeam = new Team("Galatasaray", "Türkiye");
            teams.Add(newTeam);
            newTeam = new Team("Midtjylland", "Danimarka");
            teams.Add(newTeam);
            newTeam = new Team("Rennes", "Fransa");
            teams.Add(newTeam);
            newTeam = new Team("Ferencváros", "Macaristan");
            teams.Add(newTeam);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Random random = new Random();
            List<int> selectedTeams = new List<int>();


            for (int i = 0; i < teams.Count; i++)
            {
                int selectedTeam = random.Next(0, teams.Count);
                if (selectedTeams.Contains(selectedTeam))
                {
                    i--;
                }
                else
                {
                    selectedTeams.Add(selectedTeam);
                }
            }
            for (int i = 0; i < selectedTeams.Count; i++)
            {
                if (i < 8)
                {
                    ListBag1.Add(teams[selectedTeams[i]]);
                }
                else if (i < 16)
                {
                    ListBag2.Add(teams[selectedTeams[i]]);
                }
                else if (i < 24)
                {
                    ListBag3.Add(teams[selectedTeams[i]]);
                }
                else
                {
                    ListBag4.Add(teams[selectedTeams[i]]);
                }
            }

            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (j == 0)
                    {
                        listBag1.Items.Add(ListBag1[i]);
                    }
                    else if (j == 1)
                    {
                        listBag2.Items.Add(ListBag2[i]);
                    }
                    else if (j == 2)
                    {
                        listBag3.Items.Add(ListBag3[i]);
                    }
                    else
                    {
                        listBag4.Items.Add(ListBag4[i]);
                    }

                }
            }
            bags.Add(listBag1);
            bags.Add(listBag2);
            bags.Add(listBag3);
            bags.Add(listBag4);

        }
        private static bool ControlCountry(List<Team> team1, Team team2)
        {
            bool durum = false;
            for (int i = 0; i < team1.Count; i++)
            {
                Team grupTakim = team1[i];
                if (grupTakim.TakimUlkesi == team2.TakimUlkesi)
                {
                    durum = true;
                    break;
                }
            }
            return durum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            List<int> selectedTeams = new List<int>();
            int selectedTeam;

            for (int i = 0; i < 4; i++)
            {
                selectedTeams.Clear();
                for (int j = 0; j < 8; j++)
                {
                    selectedTeam = random.Next(0, teams.Count / 4);

                    if (selectedTeams.Contains(selectedTeam))
                    {
                        j--;
                    }
                    else
                    {
                        selectedTeams.Add(selectedTeam);
                    }
                }
                bool controlCountry = false;
                for (int k = 0; k < 8; k++)
                {
                    if (i == 0 && k == 0) controlCountry = ControlCountry(ListGroupA, ListBag1[selectedTeams[k]]);
                    if (i == 0 && k == 1) controlCountry = ControlCountry(ListGroupB, ListBag1[selectedTeams[k]]);
                    if (i == 0 && k == 2) controlCountry = ControlCountry(ListGroupC, ListBag1[selectedTeams[k]]);
                    if (i == 0 && k == 3) controlCountry = ControlCountry(ListGroupD, ListBag1[selectedTeams[k]]);
                    if (i == 0 && k == 4) controlCountry = ControlCountry(ListGroupE, ListBag1[selectedTeams[k]]);
                    if (i == 0 && k == 5) controlCountry = ControlCountry(ListGroupF, ListBag1[selectedTeams[k]]);
                    if (i == 0 && k == 6) controlCountry = ControlCountry(ListGroupG, ListBag1[selectedTeams[k]]);
                    if (i == 0 && k == 7) controlCountry = ControlCountry(ListGroupH, ListBag1[selectedTeams[k]]);
                    if (i == 1 && k == 0) controlCountry = ControlCountry(ListGroupA, ListBag2[selectedTeams[k]]);
                    if (i == 1 && k == 1) controlCountry = ControlCountry(ListGroupB, ListBag2[selectedTeams[k]]);
                    if (i == 1 && k == 2) controlCountry = ControlCountry(ListGroupC, ListBag2[selectedTeams[k]]);
                    if (i == 1 && k == 3) controlCountry = ControlCountry(ListGroupD, ListBag2[selectedTeams[k]]);
                    if (i == 1 && k == 4) controlCountry = ControlCountry(ListGroupE, ListBag2[selectedTeams[k]]);
                    if (i == 1 && k == 5) controlCountry = ControlCountry(ListGroupF, ListBag2[selectedTeams[k]]);
                    if (i == 1 && k == 6) controlCountry = ControlCountry(ListGroupG, ListBag2[selectedTeams[k]]);
                    if (i == 1 && k == 7) controlCountry = ControlCountry(ListGroupH, ListBag2[selectedTeams[k]]);
                    if (i == 2 && k == 0) controlCountry = ControlCountry(ListGroupA, ListBag3[selectedTeams[k]]);
                    if (i == 2 && k == 1) controlCountry = ControlCountry(ListGroupB, ListBag3[selectedTeams[k]]);
                    if (i == 2 && k == 2) controlCountry = ControlCountry(ListGroupC, ListBag3[selectedTeams[k]]);
                    if (i == 2 && k == 3) controlCountry = ControlCountry(ListGroupD, ListBag3[selectedTeams[k]]);
                    if (i == 2 && k == 4) controlCountry = ControlCountry(ListGroupE, ListBag3[selectedTeams[k]]);
                    if (i == 2 && k == 5) controlCountry = ControlCountry(ListGroupF, ListBag3[selectedTeams[k]]);
                    if (i == 2 && k == 6) controlCountry = ControlCountry(ListGroupG, ListBag3[selectedTeams[k]]);
                    if (i == 2 && k == 7) controlCountry = ControlCountry(ListGroupH, ListBag3[selectedTeams[k]]);
                    if (i == 3 && k == 0) controlCountry = ControlCountry(ListGroupA, ListBag4[selectedTeams[k]]);
                    if (i == 3 && k == 1) controlCountry = ControlCountry(ListGroupB, ListBag4[selectedTeams[k]]);
                    if (i == 3 && k == 2) controlCountry = ControlCountry(ListGroupC, ListBag4[selectedTeams[k]]);
                    if (i == 3 && k == 3) controlCountry = ControlCountry(ListGroupD, ListBag4[selectedTeams[k]]);
                    if (i == 3 && k == 4) controlCountry = ControlCountry(ListGroupE, ListBag4[selectedTeams[k]]);
                    if (i == 3 && k == 5) controlCountry = ControlCountry(ListGroupF, ListBag4[selectedTeams[k]]);
                    if (i == 3 && k == 6) controlCountry = ControlCountry(ListGroupG, ListBag4[selectedTeams[k]]);
                    if (i == 3 && k == 7) controlCountry = ControlCountry(ListGroupH, ListBag4[selectedTeams[k]]);

                    if (controlCountry)
                    {
                        break;
                    }
                }
                if (!controlCountry)
                {
                    if (i == 0)
                    {
                        ListGroupA.Add(ListBag1[selectedTeams[0]]);
                        ListGroupB.Add(ListBag1[selectedTeams[1]]);
                        ListGroupC.Add(ListBag1[selectedTeams[2]]);
                        ListGroupD.Add(ListBag1[selectedTeams[3]]);
                        ListGroupE.Add(ListBag1[selectedTeams[4]]);
                        ListGroupF.Add(ListBag1[selectedTeams[5]]);
                        ListGroupG.Add(ListBag1[selectedTeams[6]]);
                        ListGroupH.Add(ListBag1[selectedTeams[7]]);
                    }
                    if (i == 1)
                    {
                        ListGroupA.Add(ListBag2[selectedTeams[0]]);
                        ListGroupB.Add(ListBag2[selectedTeams[1]]);
                        ListGroupC.Add(ListBag2[selectedTeams[2]]);
                        ListGroupD.Add(ListBag2[selectedTeams[3]]);
                        ListGroupE.Add(ListBag2[selectedTeams[4]]);
                        ListGroupF.Add(ListBag2[selectedTeams[5]]);
                        ListGroupG.Add(ListBag2[selectedTeams[6]]);
                        ListGroupH.Add(ListBag2[selectedTeams[7]]);
                    }
                    if (i == 2)
                    {
                        ListGroupA.Add(ListBag3[selectedTeams[0]]);
                        ListGroupB.Add(ListBag3[selectedTeams[1]]);
                        ListGroupC.Add(ListBag3[selectedTeams[2]]);
                        ListGroupD.Add(ListBag3[selectedTeams[3]]);
                        ListGroupE.Add(ListBag3[selectedTeams[4]]);
                        ListGroupF.Add(ListBag3[selectedTeams[5]]);
                        ListGroupG.Add(ListBag3[selectedTeams[6]]);
                        ListGroupH.Add(ListBag3[selectedTeams[7]]);
                    }
                    if (i == 3)
                    {
                        ListGroupA.Add(ListBag4[selectedTeams[0]]);
                        ListGroupB.Add(ListBag4[selectedTeams[1]]);
                        ListGroupC.Add(ListBag4[selectedTeams[2]]);
                        ListGroupD.Add(ListBag4[selectedTeams[3]]);
                        ListGroupE.Add(ListBag4[selectedTeams[4]]);
                        ListGroupF.Add(ListBag4[selectedTeams[5]]);
                        ListGroupG.Add(ListBag4[selectedTeams[6]]);
                        ListGroupH.Add(ListBag4[selectedTeams[7]]);
                    }


                }
                else
                {
                    i--;
                }
            }
           
            
            for(int i = 0; i < 4; i++)
            {
                listGroupA.Items.Add(ListGroupA[i]);
                listGroupB.Items.Add(ListGroupB[i]);
                listGroupC.Items.Add(ListGroupC[i]);
                listGroupD.Items.Add(ListGroupD[i]);
                listGroupE.Items.Add(ListGroupE[i]);
                listGroupF.Items.Add(ListGroupF[i]);
                listGroupG.Items.Add(ListGroupG[i]);
                listGroupH.Items.Add(ListGroupH[i]);
            }
             



        }

        private void button3_Click(object sender, EventArgs e)
        {
            GroupMatches groupMatches = new GroupMatches();
            groupMatches.listSubmit1 = ListGroupA;
            groupMatches.listSubmit2 = ListGroupB;
            groupMatches.listSubmit3 = ListGroupC;
            groupMatches.listSubmit4 = ListGroupD;
            groupMatches.listSubmit5 = ListGroupE;
            groupMatches.listSubmit6 = ListGroupF;
            groupMatches.listSubmit7 = ListGroupG;
            groupMatches.listSubmit8 = ListGroupH;
            groupMatches.Show();

        }
    }
    }

