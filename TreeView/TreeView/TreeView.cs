using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView
{
    public partial class TreeView : Form
    {
        string connectionString = "Data Source=NIKITA;Initial Catalog=UnityAccess;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public TreeView()
        {
            InitializeComponent();
            //loadButton_Click(null, null);
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            using(var connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();

                var cmd = new SqlCommand("SELECT * FROM clan;", connection);

                using(var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        TreeNode node = new TreeNode(dr["clan_name"].ToString());
                        ContextMenuStrip selector = new ContextMenuStrip();

                        ToolStripMenuItem addNode = new ToolStripMenuItem("Добавить игрока");
                        selector.Items.AddRange(new[] { addNode });
                        addNode.Click += AddPlayer_Click;

                        node.ContextMenuStrip = selector;
                        treeView1.Nodes.Add(node);
                        LoadPlayers(int.Parse(dr["clan_id"].ToString()), node);
                    }
                }

            }
            loadButton.Enabled = false;
        }

        private void LoadPlayers(int clanId, TreeNode n)
        {
            using (var connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();

                var cmd = new SqlCommand("SELECT * FROM player WHERE clan_id = @clan_id;", connection);
                cmd.Parameters.AddWithValue("@clan_id", clanId);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        TreeNode node = new TreeNode(dr["username"].ToString());
                        ContextMenuStrip selector = new ContextMenuStrip();

                        ToolStripMenuItem addNode = new ToolStripMenuItem("Добавить персонажа");
                        ToolStripMenuItem changeNode = new ToolStripMenuItem("Изменить игрока");
                        ToolStripMenuItem delete = new ToolStripMenuItem("Удалить игрока");
                        addNode.Click += AddCharacter_Click;
                        changeNode.Click += UpdatePlayer_Click;
                        delete.Click += DeletePlayer_Click;
                        selector.Items.AddRange(new[] { addNode, changeNode, delete });

                        node.ContextMenuStrip = selector;

                        n.Nodes.Add(node);
                        LoadCharacters(int.Parse(dr["player_id"].ToString()), node);
                    }
                }

            }
        }

        private void LoadCharacters(int playerId, TreeNode n)
        {
            using (var connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();

                var cmd = new SqlCommand("SELECT * FROM character WHERE player_id = @player_id;", connection);
                cmd.Parameters.AddWithValue("@player_id", playerId);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        TreeNode node = new TreeNode(dr["character_name"].ToString());
                        ContextMenuStrip selector = new ContextMenuStrip();

                        ToolStripMenuItem changeNode = new ToolStripMenuItem("Изменить персонажа");
                        ToolStripMenuItem delete = new ToolStripMenuItem("Удалить персонажа");
                        changeNode.Click += UpdateCharacter_Click;
                        delete.Click += DeleteCharacter_Click;
                        selector.Items.AddRange(new[] {changeNode, delete });

                        node.ContextMenuStrip = selector;
                        n.Nodes.Add(node);
                        LoadCharacterInfo(int.Parse(dr["character_id"].ToString()), node);
                    }
                }

            }
        }

        private void LoadCharacterInfo(int characterId, TreeNode n)
        {
            using (var connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();

                var cmd = new SqlCommand("SELECT * FROM character WHERE character_id = @character_id;", connection);
                cmd.Parameters.AddWithValue("@character_id", characterId);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        TreeNode node = new TreeNode($"Класс: {dr["class"]}");
                        n.Nodes.Add(node);
                        node = new TreeNode($"Здоровье: {dr["health"]}");
                        n.Nodes.Add(node);
                        node = new TreeNode($"Уровень: {dr["character_level"]}");
                        n.Nodes.Add(node);
                    }
                }

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void AddPlayer_Click (object sender, EventArgs e)
        {
            addPlayer.Visible = true;
        }

        private void AddCharacter_Click(object sender, EventArgs e)
        {
            addCharacter.Visible = true;
            classBox.SelectedIndex = 0;
        }

        private void UpdatePlayer_Click(object sender, EventArgs e)
        {
            updatePlayer.Visible = true;
            updateName.Text = treeView1.SelectedNode.Text;
        }
        private void UpdateCharacter_Click(object sender, EventArgs e)
        {
            updateCharacter.Visible = true;
            updateCharName.Text = treeView1.SelectedNode.Text;
            CharacterInfo();
        }

        private void DeleteCharacter_Click(object sender, EventArgs e)
        {
            DeleteCharacter(treeView1.SelectedNode.Text);
            treeView1.Nodes.Clear();
            loadButton_Click(null, null);
            MessageBox.Show("Персонаж успешно удален!");
        }

        private void DeletePlayer_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < treeView1.SelectedNode.Nodes.Count; i++)
            {
                DeleteCharacter(treeView1.SelectedNode.Nodes[i].Text);
            }
            using (var connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();

                SqlCommand sqlQuery = new SqlCommand($"DELETE FROM player WHERE username = '{treeView1.SelectedNode.Text}';", connection);
                sqlQuery.ExecuteNonQuery();
                treeView1.Nodes.Clear();
                loadButton_Click(null, null);
                MessageBox.Show("Игрок успешно удален!");

            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            addPlayer.Visible = false;
            addCharacter.Visible = false;
            updatePlayer.Visible = false;
            updateCharacter.Visible = false;
            treeView1.SelectedNode = e.Node;
        }

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            if(playerName.Text != "")
            {
                foreach (TreeNode tn in treeView1.Nodes)
                {
                    foreach (TreeNode tnx in tn.Nodes)
                    {
                        if (playerName.Text == tnx.Text)
                        {
                            MessageBox.Show("Игрок с таким именем уже существует!");
                            return;
                        }
                    }
                }
                using (var connection = new SqlConnection())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();

                    int clanId = 1;

                    var cmd = new SqlCommand($"SELECT clan_id FROM clan WHERE clan_name = '{treeView1.SelectedNode.Text}';", connection);


                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            clanId = int.Parse(dr["clan_id"].ToString());
                        }
                    }

                    SqlCommand sqlQuery = new SqlCommand($"INSERT INTO player(username, clan_id) VALUES('{playerName.Text}', {clanId});", connection);
                    sqlQuery.ExecuteNonQuery();
                    treeView1.Nodes.Clear();
                    loadButton_Click(null, null);
                    MessageBox.Show("Игрок успешно добавлен!");
                    addPlayer.Visible = false;
                }
            }
        }

        private void characterCreateButton_Click(object sender, EventArgs e)
        {
            if (characterName.Text != "")
            {
                foreach (TreeNode tn in treeView1.Nodes)
                {
                    foreach (TreeNode tnx in tn.Nodes)
                    {
                        foreach (TreeNode tnxv in tnx.Nodes)
                        {
                            if (characterName.Text == tnxv.Text)
                            {
                                MessageBox.Show("Персонаж с таким именем уже существует!");
                                return;
                            }
                        }
                    }
                }
                using (var connection = new SqlConnection())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();

                    int playerId = 0;

                    var cmd = new SqlCommand($"SELECT player_id FROM player WHERE username = '{treeView1.SelectedNode.Text}';", connection);


                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            playerId = int.Parse(dr["player_id"].ToString());
                        }
                    }

                    SqlCommand sqlQuery = new SqlCommand($"INSERT INTO character(character_name, class, health, character_level, player_id) VALUES('{characterName.Text}', '{classBox.Text}', {healthBox.Value}, {levelBox.Value}, {playerId});", connection);
                    sqlQuery.ExecuteNonQuery();
                    treeView1.Nodes.Clear();
                    loadButton_Click(null, null);
                    MessageBox.Show("Персонаж успешно добавлен!");
                    addCharacter.Visible = false;
                }
            }
        }

        private void updatePlayerButton_Click(object sender, EventArgs e)
        {
            if (updateName.Text != "")
            {
                foreach (TreeNode tn in treeView1.Nodes)
                {
                    foreach (TreeNode tnx in tn.Nodes)
                    {
                        if (treeView1.SelectedNode.Text == updateName.Text)
                        {
                            MessageBox.Show("Вы ничего не изменили.");
                            return;
                        }
                        else if (updateName.Text == tnx.Text)
                        {
                            MessageBox.Show("Игрок с таким именем уже существует!");
                            return;
                        }
                    }
                }
                using (var connection = new SqlConnection())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();

                    SqlCommand sqlQuery = new SqlCommand($"UPDATE player SET username = '{updateName.Text}' WHERE username = '{treeView1.SelectedNode.Text}';", connection);
                    sqlQuery.ExecuteNonQuery();
                    treeView1.Nodes.Clear();
                    loadButton_Click(null, null);
                    MessageBox.Show("Игрок успешно обновлен!");
                    updatePlayer.Visible = false;
                }
            }
        }

        private void CharacterInfo()
        {
            using (var connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();

                var cmd = new SqlCommand("SELECT * FROM character WHERE character_name = @character_name;", connection);
                cmd.Parameters.AddWithValue("@character_name", updateCharName.Text);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        updateClass.Text = dr["class"].ToString();
                        updateHealth.Value = int.Parse(dr["health"].ToString());
                        updateLevel.Value = int.Parse(dr["character_level"].ToString());
                    }
                }

            }
        }

        private void updateCharButton_Click(object sender, EventArgs e)
        {
            if (updateCharName.Text != "")
            {
                foreach (TreeNode tn in treeView1.Nodes)
                {
                    foreach (TreeNode tnx in tn.Nodes)
                    {
                        foreach (TreeNode tnxv in tnx.Nodes)
                        {
                            if(treeView1.SelectedNode.Text == updateCharName.Text)
                            {

                            }
                            else if(updateCharName.Text == tnxv.Text)
                            {
                                MessageBox.Show("Персонаж с таким именем уже существует!");
                                return;
                            }
                        }
                    }
                }
                using (var connection = new SqlConnection())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();

                    SqlCommand sqlQuery = new SqlCommand($"UPDATE character SET character_name = '{updateCharName.Text}', class = '{updateClass.Text}', health = {updateHealth.Value}, character_level = {updateLevel.Value} WHERE character_name = '{treeView1.SelectedNode.Text}';", connection);
                    sqlQuery.ExecuteNonQuery();
                    treeView1.Nodes.Clear();
                    loadButton_Click(null, null);
                    MessageBox.Show("Персонаж успешно обновлен!");
                    updateCharacter.Visible = false;
                }
            }
        }

        private void DeleteCharacter(string name)
        {
            using (var connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();

                SqlCommand sqlQuery = new SqlCommand($"DELETE FROM character WHERE character_name = '{name}';", connection);
                sqlQuery.ExecuteNonQuery();
            }
        }
    }
}
