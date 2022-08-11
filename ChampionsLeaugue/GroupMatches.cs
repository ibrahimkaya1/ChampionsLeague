using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChampionsLeaugue
{
    public partial class GroupMatches : Form
    {
        internal List<Team> listSubmit1;
        internal List<Team> listSubmit2;
        internal List<Team> listSubmit3;
        internal List<Team> listSubmit4;
        internal List<Team> listSubmit5;
        internal List<Team> listSubmit6;
        internal List<Team> listSubmit7;
        internal List<Team> listSubmit8;
        List<Team> teams = null;
        public GroupMatches()
        {
            InitializeComponent();
        }

        private void GroupMatches_Load(object sender, EventArgs e)
        {


        }

        private void GroupShow(List<Team> listSubmit1, ListBox box)
        {
            for (int i = 0; i < listSubmit1.Count; i++)
            {
                box.Items.Add(listSubmit1[i].TakimAdi);
            }
        }

        private void fikstur(List<Team> listSubmit1, ListBox box)
        {
            Random random = new Random();
            List<string> matches = new List<string>();
            var team1 = listSubmit1[3].TakimAdi;
            var team2 = listSubmit1[2].TakimAdi;
            var team3 = listSubmit1[1].TakimAdi;
            var team4 = listSubmit1[0].TakimAdi;
            int goalTeam1 = random.Next(9);
            int goalTeam2 = random.Next(9);
            int goalTeam3 = random.Next(9);
            int goalTeam4 = random.Next(9);
            int totalAG1 = 0, totalAG2 = 0, totalAG3 = 0, totalAG4 = 0;
            int totalYG1 = 0, totalYG2 = 0, totalYG3 = 0, totalYG4 = 0;
            int point1 = 0, point2 = 0, point3 = 0, point4 = 0;

            matches.Add("******************  1.MAÇLAR  ***************");
            matches.Add(team1 + "  " + goalTeam1 + "-" + goalTeam2 + "  " + team2);
            matches.Add(team3 + "  " + goalTeam3 + "-" + goalTeam4 + "  " + team4);
            totalAG1 = totalAG1 + goalTeam1;
            totalAG2 = totalAG2 + goalTeam2;
            totalAG3 = totalAG3 + goalTeam3;
            totalAG4 = totalAG4 + goalTeam4;
            totalYG1 = totalYG1 + goalTeam2;
            totalYG2 = totalYG2 + goalTeam1;
            totalYG3 = totalYG3 + goalTeam4;
            totalYG4 = totalYG4 + goalTeam3;

            if (goalTeam1 > goalTeam2) point1 = point1 + 3;
            else if (goalTeam2 > goalTeam1) point2 = point2 + 3;
            else { point1 = point1 + 1; point2 = point2 + 1; }

            if (goalTeam3 > goalTeam4) point3 = point3 + 3;
            else if (goalTeam4 > goalTeam3) point4 = point4 + 3;
            else { point3 = point3 + 1; point4 = point4 + 1; }

            matches.Add(" ");
            matches.Add("******************  2.MAÇLAR  ***************");

            goalTeam1 = random.Next(9);
            goalTeam2 = random.Next(9);
            goalTeam3 = random.Next(9);
            goalTeam4 = random.Next(9);

            matches.Add(team2 + "  " + goalTeam2 + "-" + goalTeam3 + "  " + team3);
            matches.Add(team4 + "  " + goalTeam4 + "-" + goalTeam1 + "  " + team1);

            totalAG1 = totalAG1 + goalTeam1;
            totalAG2 = totalAG2 + goalTeam2;
            totalAG3 = totalAG3 + goalTeam3;
            totalAG4 = totalAG4 + goalTeam4;
            totalYG1 = totalYG1 + goalTeam4;
            totalYG2 = totalYG2 + goalTeam3;
            totalYG3 = totalYG3 + goalTeam2;
            totalYG4 = totalYG4 + goalTeam1;

            if (goalTeam1 > goalTeam4) point1 = point1 + 3;
            else if (goalTeam4 > goalTeam1) point4 = point4 + 3;
            else { point1 = point1 + 1; point4 = point4 + 1; }

            if (goalTeam3 > goalTeam2) point3 = point3 + 3;
            else if (goalTeam2 > goalTeam3) point2 = point2 + 3;
            else { point3 = point3 + 1; point2 = point2 + 1; }

            matches.Add(" ");
            matches.Add("******************  3.MAÇLAR  ***************");

            goalTeam1 = random.Next(9);
            goalTeam2 = random.Next(9);
            goalTeam3 = random.Next(9);
            goalTeam4 = random.Next(9);

            matches.Add(team4 + "  " + goalTeam4 + "-" + goalTeam2 + "  " + team2);
            matches.Add(team3 + "  " + goalTeam3 + "-" + goalTeam1 + "  " + team1);

            totalAG1 = totalAG1 + goalTeam1;
            totalAG2 = totalAG2 + goalTeam2;
            totalAG3 = totalAG3 + goalTeam3;
            totalAG4 = totalAG4 + goalTeam4;
            totalYG1 = totalYG1 + goalTeam3;
            totalYG2 = totalYG2 + goalTeam4;
            totalYG3 = totalYG3 + goalTeam1;
            totalYG4 = totalYG4 + goalTeam2;

            if (goalTeam2 > goalTeam4) point2 = point2 + 3;
            else if (goalTeam4 > goalTeam2) point4 = point4 + 3;
            else { point2 = point2 + 1; point4 = point4 + 1; }

            if (goalTeam3 > goalTeam1) point3 = point3 + 3;
            else if (goalTeam1 > goalTeam3) point1 = point1 + 3;
            else { point3 = point3 + 1; point1 = point1 + 1; }

            matches.Add(" ");
            matches.Add("******************  4.MAÇLAR  ***************");

            goalTeam1 = random.Next(9);
            goalTeam2 = random.Next(9);
            goalTeam3 = random.Next(9);
            goalTeam4 = random.Next(9);

            matches.Add(team1 + "  " + goalTeam1 + "-" + goalTeam3 + "  " + team3);
            matches.Add(team2 + "  " + goalTeam2 + "-" + goalTeam4 + "  " + team4);

            totalAG1 = totalAG1 + goalTeam1;
            totalAG2 = totalAG2 + goalTeam2;
            totalAG3 = totalAG3 + goalTeam3;
            totalAG4 = totalAG4 + goalTeam4;
            totalYG1 = totalYG1 + goalTeam3;
            totalYG2 = totalYG2 + goalTeam4;
            totalYG3 = totalYG3 + goalTeam1;
            totalYG4 = totalYG4 + goalTeam2;

            if (goalTeam2 > goalTeam4) point2 = point2 + 3;
            else if (goalTeam4 > goalTeam2) point4 = point4 + 3;
            else { point2 = point2 + 1; point4 = point4 + 1; }

            if (goalTeam3 > goalTeam1) point3 = point3 + 3;
            else if (goalTeam1 > goalTeam3) point1 = point1 + 3;
            else { point3 = point3 + 1; point1 = point1 + 1; }

            matches.Add(" ");
            matches.Add("******************  5.MAÇLAR  ***************");

            goalTeam1 = random.Next(9);
            goalTeam2 = random.Next(9);
            goalTeam3 = random.Next(9);
            goalTeam4 = random.Next(9);

            matches.Add(team1 + "  " + goalTeam1 + "-" + goalTeam4 + "  " + team4);
            matches.Add(team3 + "  " + goalTeam3 + "-" + goalTeam2 + "  " + team2);

            totalAG1 = totalAG1 + goalTeam1;
            totalAG2 = totalAG2 + goalTeam2;
            totalAG3 = totalAG3 + goalTeam3;
            totalAG4 = totalAG4 + goalTeam4;
            totalYG1 = totalYG1 + goalTeam4;
            totalYG2 = totalYG2 + goalTeam3;
            totalYG3 = totalYG3 + goalTeam2;
            totalYG4 = totalYG4 + goalTeam1;

            if (goalTeam1 > goalTeam4) point1 = point1 + 3;
            else if (goalTeam4 > goalTeam1) point4 = point4 + 3;
            else { point1 = point1 + 1; point4 = point4 + 1; }

            if (goalTeam3 > goalTeam2) point3 = point3 + 3;
            else if (goalTeam2 > goalTeam3) point2 = point2 + 3;
            else { point3 = point3 + 1; point2 = point2 + 1; }

            matches.Add(" ");
            matches.Add("******************  6.MAÇLAR  ***************");

            goalTeam1 = random.Next(9);
            goalTeam2 = random.Next(9);
            goalTeam3 = random.Next(9);
            goalTeam4 = random.Next(9);

            matches.Add(team2 + "  " + goalTeam2 + "-" + goalTeam1 + "  " + team1);
            matches.Add(team4 + "  " + goalTeam4 + "-" + goalTeam3 + "  " + team3);

            totalAG1 = totalAG1 + goalTeam1;
            totalAG2 = totalAG2 + goalTeam2;
            totalAG3 = totalAG3 + goalTeam3;
            totalAG4 = totalAG4 + goalTeam4;
            totalYG1 = totalYG1 + goalTeam2;
            totalYG2 = totalYG2 + goalTeam1;
            totalYG3 = totalYG3 + goalTeam4;
            totalYG4 = totalYG4 + goalTeam3;

            if (goalTeam1 > goalTeam2) point1 = point1 + 3;
            else if (goalTeam2 > goalTeam1) point2 = point2 + 3;
            else { point1 = point1 + 1; point2 = point2 + 1; }

            if (goalTeam3 > goalTeam4) point3 = point3 + 3;
            else if (goalTeam4 > goalTeam3) point4 = point4 + 3;
            else { point3 = point3 + 1; point4 = point4 + 1; }

            matches.Add("***********************************");
            int avg1 = totalAG1 - totalYG1;
            int avg2 = totalAG2 - totalYG2;
            int avg3 = totalAG3 - totalYG3;
            int avg4 = totalAG4 - totalYG4;

            Team newTeam = null;

            teams = new List<Team>();
            newTeam = new Team(team1, point1, totalAG1, totalYG1, avg1);
            teams.Add(newTeam);
            newTeam = new Team(team2, point2, totalAG2, totalYG2, avg2);
            teams.Add(newTeam);
            newTeam = new Team(team3, point3, totalAG3, totalYG3, avg3);
            teams.Add(newTeam);
            newTeam = new Team(team4, point4, totalAG4, totalYG4, avg4);
            teams.Add(newTeam);

            int number;
            Team temp = null;
            for (int i = 0; i < teams.Count - 1; i++)
            {
                for (int j = i + 1; j < teams.Count; j++)
                {
                    if (teams[j].Point == teams[i].Point)
                    {
                        if (teams[j].Avarage == teams[i].Avarage)
                        {
                            if (teams[j].AGol == teams[i].AGol)
                            {
                                number = random.Next(2);
                                if (number == 0)
                                {
                                    temp = teams[j];
                                    teams[j] = teams[i];
                                    teams[i] = temp;
                                }
                            }
                            else if (teams[j].AGol > teams[i].AGol)
                            {
                                temp = teams[j];
                                teams[j] = teams[i];
                                teams[i] = temp;
                            }
                        }
                        else if (teams[j].Avarage > teams[i].Avarage)
                        {
                            temp = teams[j];
                            teams[j] = teams[i];
                            teams[i] = temp;
                        }
                    }
                    else if (teams[j].Point > teams[i].Point)
                    {
                        temp = teams[j];
                        teams[j] = teams[i];
                        teams[i] = temp;
                    }
                }
            }
            listBox1.Items.Clear();
            listBox1.Items.Add("TAKIM   PUAN  AG  YG AVG");
            for (int i = 0; i < teams.Count; i++)
            {
                listBox1.Items.Add(teams[i].TakimAdi + "  " + teams[i].Point + "  " + teams[i].AGol + "  " + teams[i].YGol + "  " + teams[i].Avarage);
                if (i < 2)
                {
                    listBox3.Items.Add(teams[i].TakimAdi);
                }
            }


            box.Items.Clear();
            for (int i = 0; i < matches.Count; i++)
            {
                box.Items.Add(matches[i]);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GroupShow(listSubmit1, listBox1);
            fikstur(listSubmit1, listBox2);
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GroupShow(listSubmit2, listBox1);
            fikstur(listSubmit2, listBox2);
            button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GroupShow(listSubmit3, listBox1);
            fikstur(listSubmit3, listBox2);
            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GroupShow(listSubmit4, listBox1);
            fikstur(listSubmit4, listBox2);
            button4.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GroupShow(listSubmit5, listBox1);
            fikstur(listSubmit5, listBox2);
            button5.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GroupShow(listSubmit6, listBox1);
            fikstur(listSubmit6, listBox2);
            button6.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GroupShow(listSubmit7, listBox1);
            fikstur(listSubmit7, listBox2);
            button7.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GroupShow(listSubmit8, listBox1);
            fikstur(listSubmit8, listBox2);
            button8.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Finaller finaller = new Finaller();
            finaller.listLast16 = listBox3;
            finaller.Show();
        }
    }
}
