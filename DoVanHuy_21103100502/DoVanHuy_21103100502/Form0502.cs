using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoVanHuy_21103100502
{
    public partial class Form0502 : Form
    {
        private List<Skill> skills = new List<Skill>();
        private List<PlayerSkill> playerSkills = new List<PlayerSkill>();
        public Form0502()
        {
            InitializeComponent();
            
        }
        private void buttonLoad_0502_Click(object sender, EventArgs e)
        {
            try
            {
                LoadSkills("SkillDB.txt");
                LoadPlayerSkills("PlayerSkill.txt");
                richTextBox1_0502.AppendText("Data loaded successfully.\n\n");

                // Display skills
                richTextBox1_0502.AppendText("Skills:\n");
                foreach (var skill in skills)
                {
                    richTextBox1_0502.AppendText($"ID: {skill.SkillId}, Name: {skill.SkillName}, Effectiveness: {skill.Effectiveness}, Rank: {skill.Rank}\n");
                }

                // Display player skills
                richTextBox1_0502.AppendText("\nPlayer Skills:\n");
                foreach (var player in playerSkills)
                {
                    richTextBox1_0502.AppendText($"Player ID: {player.PlayerId}, Name: {player.PlayerName}, Skill ID: {player.SkillId}, Mastery: {player.Mastery}\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading files: " + ex.Message);
            }
        }

        private void LoadSkills(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines.Skip(1)) 
            {
                var parts = line.Split(new[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length != 4)
                {
                    throw new FormatException("Invalid format in SkillDB.txt");
                }

                var skill = new Skill
                {
                    SkillId = int.Parse(parts[0]),
                    SkillName = parts[1],
                    Effectiveness = int.Parse(parts[2]),
                    Rank = parts[3]
                };

                skills.Add(skill);
            }
        }

        private void LoadPlayerSkills(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines.Skip(1)) 
            {
                var parts = line.Split(new[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length != 4)
                {
                    throw new FormatException("Invalid format in PlayerSkills.txt");
                }

                var playerSkill = new PlayerSkill
                {
                    PlayerId = int.Parse(parts[0]),
                    PlayerName = parts[1],
                    SkillId = int.Parse(parts[2]),
                    Mastery = int.Parse(parts[3])
                };

                playerSkills.Add(playerSkill);
            }
        }

        private void buttonModify_0502_Click(object sender, EventArgs e)
        {
            var player = playerSkills.FirstOrDefault(p => p.PlayerId == 2);
            if (player != null)
            {
                player.Mastery = 88;
                richTextBox1_0502.AppendText("Player's mastery updated to 88.\n");
                SavePlayerSkills("PlayerSkills.txt");
                LoadPlayerSkills("PlayerSkills.txt");
                richTextBox1_0502.AppendText("\nPlayer Skills:\n");
                foreach (var player1 in playerSkills)
                {
                    richTextBox1_0502.AppendText($"Player ID: {player1.PlayerId}, Name: {player1.PlayerName}, Skill ID: {player1.SkillId}, Mastery: {player1.Mastery}\n");
                }
            }
            else
            {
                MessageBox.Show("Player with ID 2 not found.");
            }
        }

        private void SavePlayerSkills(string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine("player_id\tplayer_name\tskill_id\tmastery");
                foreach (var player in playerSkills)
                {
                    writer.WriteLine($"{player.PlayerId}\t{player.PlayerName}\t{player.SkillId}\t{player.Mastery}");
                }
            }
        }

        private void buttonStats_0502_Click(object sender, EventArgs e)
        {
            var countA = playerSkills.Count(p => skills.First(s => s.SkillId == p.SkillId).Rank == "A");
            richTextBox1_0502.AppendText($"Number of players with skill rank 'A': {countA}\n");
        }
    }

    public class Skill
    {
        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public int Effectiveness { get; set; }
        public string Rank { get; set; }
    }

    public class PlayerSkill
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int SkillId { get; set; }
        public int Mastery { get; set; }
    }
}
