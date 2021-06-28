using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Mountain_Project
{
    public partial class MainForm : Form
    {
        List<Mount> spisok = new List<Mount>();
        public MainForm()
        {
            InitializeComponent();
            spisok.Add(new Mount() { name = "Эверест", hight = 8848, sh = "27°59’23″", dol = "86°55’37″", materik = "Евразия", god = 1953, alp = "Эдмунд Хиллари" });
            spisok.Add(new Mount() { name = "Чогори", hight = 8614, sh = "35°52′52″", dol = "76°30′48″", materik = "Евразия", god = 1954, alp = "Лино Лачеделли" });
            spisok.Add(new Mount() { name = "Канченджанга", hight = 8586, sh = "27°42′09″", dol = "88°08′54″", materik = "Евразия", god = 1955, alp = "Алексей Болтов" });
            spisok.Add(new Mount() { name = "Лхоцзе", hight = 8516, sh = "27°57′42″", dol = "86°56′00″", materik = "Евразия", god = 1956, alp = "Эрнст Райсс" });
            spisok.Add(new Mount() { name = "Макалу", hight = 8485, sh = "27°53′21″", dol = "87°05′19″", materik = "Евразия", god = 1955, alp = "Жан Кузи" });
            spisok.Add(new Mount() { name = "Чо-Ойю", hight = 8201, sh = "28°05′39″", dol = "86°39′39″", materik = "Евразия", god = 1954, alp = "Хербет Тихи" });
            spisok.Add(new Mount() { name = "Дхаулагири", hight = 8167, sh = "28°41′46″", dol = "83°29′43″", materik = "Евразия", god = 1960, alp = "Макс Эйзелин" });
            spisok.Add(new Mount() { name = "Манаслу", hight = 8156, sh = "28°33′00″", dol = "84°33′35″", materik = "Евразия", god = 1956, alp = "Юко Маки" });
            spisok.Add(new Mount() { name = "Нангапарбат", hight = 8125, sh = "35°14′21″", dol = "74°35′24″", materik = "Евразия", god = 1953, alp = "Герман Буль" });
            spisok.Add(new Mount() { name = "Аннапурна", hight = 8091, sh = "28°35′46″", dol = "83°49′13″", materik = "Евразия", god = 1950, alp = "Морис Эрцог" });

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = panel2.Location.X,
                b = panel2.Location.Y; 
            panel2.Location = new Point(209, 12);
                panel1.Location = new Point(a, b);
            
     
     

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = string.Format("{0,-12}{1,-10}{2,-10}{3,-10}", "Название", "Высота", "Материк", "Год открытия");
            textBox5.Text = string.Format("{0,-12}{1,-10}{2,-10}{3,-10}", "Название", "Высота", "Материк", "Год открытия");
            textBox9.Text = string.Format("{0,-18}{1,-10}{2,-10}{3,-10}", "Название", "Высота", "Материк", "Год открытия");
            textBox13.Text = string.Format("{0,-12}{1,-10}{2,-10}{3,-10}", "Название", "Высота", "Материк", "Год открытия");
            textBox17.Text = string.Format("{0,-12}{1,-10}{2,-10}{3,-10}", "Название", "Высота", "Материк", "Год открытия");
            textBox33.Text = string.Format("{0,-12}{1,-10}{2,-10}{3,-10}", "Название", "Высота", "Материк", "Год открытия");
            textBox21.Text = string.Format("{0,-15}{1,-10}{2,-10}{3,-10}", "Название", "Высота", "Материк", "Год открытия");
            textBox25.Text = string.Format("{0,-12}{1,-10}{2,-10}{3,-10}", "Название", "Высота", "Материк", "Год открытия");
            textBox29.Text = string.Format("{0,-18}{1,-10}{2,-10}{3,-10}", "Название", "Высота", "Материк", "Год открытия");
            textBox37.Text = string.Format("{0,-15}{1,-10}{2,-10}{3,-10}", "Название", "Высота", "Материк", "Год открытия");
            checkBox2.Checked= true;
            checkBox3.Checked =true;
            checkBox1.Checked = true;
            checkBox4.Checked = true;
            /*textGora1Kor.BackColor = Color.Transparent;
            textGora1Kor.BorderStyle = BorderStyle.None;*/
            textGora1Kor.Text = spisok[0].sh + "\n" + spisok[0].dol;
            textGora1Alp.Text = spisok[0].alp;
            textGora2Kor.Text = spisok[1].sh + "\n" + spisok[1].dol;
            textGora2Alp.Text = spisok[1].alp;
            textGora3Kor.Text = spisok[2].sh + "\n" + spisok[2].dol;
            textGora3Alp.Text = spisok[2].alp;
            textGora4Kor.Text = spisok[3].sh + "\n" + spisok[3].dol;
            textGora4Alp.Text = spisok[3].alp;
            textGora5Kor.Text = spisok[4].sh + "\n" + spisok[4].dol;
            textGora5Alp.Text = spisok[4].alp;
            textGora6Kor.Text = spisok[5].sh + "\n" + spisok[5].dol;
            textGora6Alp.Text = spisok[5].alp;
            textGora7Kor.Text = spisok[6].sh + "\n" + spisok[6].dol;
            textGora7Alp.Text = spisok[6].alp;
            textGora8Kor.Text = spisok[7].sh + "\n" + spisok[7].dol;
            textGora8Alp.Text = spisok[7].alp;
            textGora9Kor.Text = spisok[8].sh + "\n" + spisok[8].dol;
            textGora9Alp.Text = spisok[8].alp;
            textGora10Kor.Text = spisok[9].sh + "\n" + spisok[9].dol;
            textGora10Alp.Text = spisok[9].alp;
            

            Gora1text.Text = string.Format("{0,-14}{1,-12}{2,-11}{3,-10}", spisok[0].name, spisok[0].hight, spisok[0].materik, spisok[0].god);
            Gora2text.Text = string.Format("{0,-16}{1,-12}{2,-11}{3,-10}", spisok[1].name, spisok[1].hight, spisok[1].materik, spisok[1].god);
            Gora3text.Text = string.Format("{0,-14}{1,-12}{2,-11}{3,-10}", spisok[2].name, spisok[2].hight, spisok[2].materik, spisok[2].god);
            Gora4text.Text = string.Format("{0,-16}{1,-12}{2,-11}{3,-10}", spisok[3].name, spisok[3].hight, spisok[3].materik, spisok[3].god);
            Gora5text.Text = string.Format("{0,-15}{1,-12}{2,-11}{3,-10}", spisok[4].name, spisok[4].hight, spisok[4].materik, spisok[4].god);
            Gora6text.Text = string.Format("{0,-14}{1,-12}{2,-11}{3,-10}", spisok[5].name, spisok[5].hight, spisok[5].materik, spisok[5].god);
            Gora7text.Text = string.Format("{0,-14}{1,-12}{2,-11}{3,-10}", spisok[6].name, spisok[6].hight, spisok[6].materik, spisok[6].god);
            Gora8text.Text = string.Format("{0,-14}{1,-12}{2,-11}{3,-10}", spisok[7].name, spisok[7].hight, spisok[7].materik, spisok[7].god);
            Gora9text.Text = string.Format("{0,-14}{1,-12}{2,-11}{3,-10}", spisok[8].name, spisok[8].hight, spisok[8].materik, spisok[8].god);
            Gora10text.Text = string.Format("{0,-14}{1,-12}{2,-11}{3,-10}", spisok[9].name, spisok[9].hight, spisok[9].materik, spisok[9].god);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Gora1text.Text = "";
            Gora2text.Text = "";
            Gora3text.Text = "";
            Gora4text.Text = "";
            Gora5text.Text = "";
            Gora6text.Text = "";
            Gora7text.Text = "";
            Gora8text.Text = "";
            Gora9text.Text = "";
            Gora10text.Text = "";
            //Gora1text.Clear();
            if (checkBox1.Checked)
            {
                Gora1text.Text += string.Format("{0,-14}", spisok[0].name);
                Gora2text.Text += string.Format("{0,-14}", spisok[1].name);
                Gora3text.Text += string.Format("{0,-14}", spisok[2].name);
                Gora4text.Text += string.Format("{0,-16}", spisok[3].name);
                Gora5text.Text += string.Format("{0,-15}", spisok[4].name);
                Gora6text.Text += string.Format("{0,-14}", spisok[5].name);
                Gora7text.Text += string.Format("{0,-14}", spisok[6].name);
                Gora8text.Text += string.Format("{0,-14}", spisok[7].name);
                Gora9text.Text += string.Format("{0,-14}", spisok[8].name);
                Gora10text.Text += string.Format("{0,-14}", spisok[9].name);
            }
            else
            {
                Gora1text.Text += string.Format("{0,-23}", "");
                Gora2text.Text += string.Format("{0,-23}", "");
                Gora3text.Text += string.Format("{0,-29}", "");
                Gora4text.Text += string.Format("{0,-25}", "");
                Gora5text.Text += string.Format("{0,-24}", "");
                Gora6text.Text += string.Format("{0,-23}", "");
                Gora7text.Text += string.Format("{0,-26}", "");
                Gora8text.Text += string.Format("{0,-23}", "");
                Gora9text.Text += string.Format("{0,-29}", "");
                Gora10text.Text += string.Format("{0,-26}", "");
            }

            if (checkBox2.Checked)
            {
                Gora1text.Text += string.Format("{0,-12}", spisok[0].hight);
                Gora2text.Text += string.Format("{0,-12}", spisok[1].hight);
                Gora3text.Text += string.Format("{0,-12}", spisok[2].hight);
                Gora4text.Text += string.Format("{0,-12}", spisok[3].hight);
                Gora5text.Text += string.Format("{0,-12}", spisok[4].hight);
                Gora6text.Text += string.Format("{0,-12}", spisok[5].hight);
                Gora7text.Text += string.Format("{0,-12}", spisok[6].hight);
                Gora8text.Text += string.Format("{0,-12}", spisok[7].hight);
                Gora9text.Text += string.Format("{0,-12}", spisok[8].hight);
                Gora10text.Text += string.Format("{0,-12}", spisok[9].hight);
            }
            else 
            { 
                Gora1text.Text += string.Format("{0,-18}", "");
                Gora2text.Text += string.Format("{0,-18}", "");
                Gora3text.Text += string.Format("{0,-18}", "");
                Gora4text.Text += string.Format("{0,-18}", "");
                Gora5text.Text += string.Format("{0,-18}", "");
                Gora6text.Text += string.Format("{0,-18}", "");
                Gora7text.Text += string.Format("{0,-18}", "");
                Gora8text.Text += string.Format("{0,-18}", "");
                Gora9text.Text += string.Format("{0,-18}", "");
                Gora10text.Text += string.Format("{0,-18}", "");
            }

            if (checkBox3.Checked)
            {
                Gora1text.Text += string.Format("{0,-11}", spisok[0].materik);
                Gora2text.Text += string.Format("{0,-11}", spisok[1].materik);
                Gora3text.Text += string.Format("{0,-11}", spisok[2].materik);
                Gora4text.Text += string.Format("{0,-11}", spisok[3].materik);
                Gora5text.Text += string.Format("{0,-11}", spisok[4].materik);
                Gora6text.Text += string.Format("{0,-11}", spisok[5].materik);
                Gora7text.Text += string.Format("{0,-11}", spisok[6].materik);
                Gora8text.Text += string.Format("{0,-11}", spisok[7].materik);
                Gora9text.Text += string.Format("{0,-11}", spisok[8].materik);
                Gora10text.Text += string.Format("{0,-11}", spisok[9].materik);
            }
            else
            {
                Gora1text.Text += string.Format("{0,-21}", "");
                Gora2text.Text += string.Format("{0,-21}", "");
                Gora3text.Text += string.Format("{0,-21}", "");
                Gora4text.Text += string.Format("{0,-21}", "");
                Gora5text.Text += string.Format("{0,-21}", "");
                Gora6text.Text += string.Format("{0,-21}", "");
                Gora7text.Text += string.Format("{0,-21}", "");
                Gora8text.Text += string.Format("{0,-21}", "");
                Gora9text.Text += string.Format("{0,-21}", "");
                Gora10text.Text += string.Format("{0,-21}", "");

            }

            if (checkBox4.Checked)
            {
                Gora1text.Text += string.Format("{0,-10}", spisok[0].god);
                Gora2text.Text += string.Format("{0,-10}", spisok[1].god);
                Gora3text.Text += string.Format("{0,-10}", spisok[2].god);
                Gora4text.Text += string.Format("{0,-10}", spisok[3].god);
                Gora5text.Text += string.Format("{0,-10}", spisok[4].god);
                Gora6text.Text += string.Format("{0,-10}", spisok[5].god);
                Gora7text.Text += string.Format("{0,-10}", spisok[6].god);
                Gora8text.Text += string.Format("{0,-10}", spisok[7].god);
                Gora9text.Text += string.Format("{0,-10}", spisok[8].god);
                Gora10text.Text += string.Format("{0,-10}", spisok[9].god);
            }
            else
            {
                Gora1text.Text += string.Format("{0,-17}", "");
                Gora2text.Text += string.Format("{0,-17}", "");
                Gora3text.Text += string.Format("{0,-17}", "");
                Gora4text.Text += string.Format("{0,-17}", "");
                Gora5text.Text += string.Format("{0,-17}", "");
                Gora6text.Text += string.Format("{0,-17}", "");
                Gora7text.Text += string.Format("{0,-17}", "");
                Gora8text.Text += string.Format("{0,-17}", "");
                Gora9text.Text += string.Format("{0,-17}", "");
                Gora10text.Text += string.Format("{0,-17}", "");
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ru.wikipedia.org/wiki/Джомолунгма");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ru.wikipedia.org/wiki/Чогори");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        
            System.Diagnostics.Process.Start("https://ru.wikipedia.org/wiki/Канченджанга");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ru.wikipedia.org/wiki/Лхоцзе");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ru.wikipedia.org/wiki/Макалу");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ru.wikipedia.org/wiki/Чо-Ойю");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ru.wikipedia.org/wiki/Дхаулагири");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ru.wikipedia.org/wiki/Манаслу");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ru.wikipedia.org/wiki/Нангапарбат");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ru.wikipedia.org/wiki/Аннапурна");
        }

        
    }
}
