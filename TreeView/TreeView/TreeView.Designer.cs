
namespace TreeView
{
    partial class TreeView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.loadButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.addPlayer = new System.Windows.Forms.Panel();
            this.AddPlayerButton = new System.Windows.Forms.Button();
            this.playerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addCharacter = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.levelBox = new System.Windows.Forms.NumericUpDown();
            this.healthBox = new System.Windows.Forms.NumericUpDown();
            this.classBox = new System.Windows.Forms.ComboBox();
            this.characterName = new System.Windows.Forms.TextBox();
            this.characterCreateButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCharacter = new System.Windows.Forms.Label();
            this.updatePlayer = new System.Windows.Forms.Panel();
            this.updatePlayerButton = new System.Windows.Forms.Button();
            this.updateName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.updateCharacter = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.updateLevel = new System.Windows.Forms.NumericUpDown();
            this.updateHealth = new System.Windows.Forms.NumericUpDown();
            this.updateClass = new System.Windows.Forms.ComboBox();
            this.updateCharName = new System.Windows.Forms.TextBox();
            this.updateCharButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addPlayer.SuspendLayout();
            this.addCharacter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthBox)).BeginInit();
            this.updatePlayer.SuspendLayout();
            this.updateCharacter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateHealth)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 13);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(217, 240);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(13, 259);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(110, 27);
            this.loadButton.TabIndex = 1;
            this.loadButton.Text = "Загрузить";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(129, 259);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(101, 27);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addPlayer
            // 
            this.addPlayer.Controls.Add(this.AddPlayerButton);
            this.addPlayer.Controls.Add(this.playerName);
            this.addPlayer.Controls.Add(this.label2);
            this.addPlayer.Controls.Add(this.label1);
            this.addPlayer.Location = new System.Drawing.Point(236, 11);
            this.addPlayer.Name = "addPlayer";
            this.addPlayer.Size = new System.Drawing.Size(205, 106);
            this.addPlayer.TabIndex = 3;
            this.addPlayer.Visible = false;
            // 
            // AddPlayerButton
            // 
            this.AddPlayerButton.Location = new System.Drawing.Point(64, 66);
            this.AddPlayerButton.Name = "AddPlayerButton";
            this.AddPlayerButton.Size = new System.Drawing.Size(75, 23);
            this.AddPlayerButton.TabIndex = 3;
            this.AddPlayerButton.Text = "Добавить";
            this.AddPlayerButton.UseVisualStyleBackColor = true;
            this.AddPlayerButton.Click += new System.EventHandler(this.AddPlayerButton_Click);
            // 
            // playerName
            // 
            this.playerName.Location = new System.Drawing.Point(52, 40);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(100, 20);
            this.playerName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя игрока:";
            // 
            // addCharacter
            // 
            this.addCharacter.Controls.Add(this.label7);
            this.addCharacter.Controls.Add(this.label6);
            this.addCharacter.Controls.Add(this.label5);
            this.addCharacter.Controls.Add(this.levelBox);
            this.addCharacter.Controls.Add(this.healthBox);
            this.addCharacter.Controls.Add(this.classBox);
            this.addCharacter.Controls.Add(this.characterName);
            this.addCharacter.Controls.Add(this.characterCreateButton);
            this.addCharacter.Controls.Add(this.label4);
            this.addCharacter.Controls.Add(this.labelCharacter);
            this.addCharacter.Location = new System.Drawing.Point(236, 8);
            this.addCharacter.Name = "addCharacter";
            this.addCharacter.Size = new System.Drawing.Size(205, 239);
            this.addCharacter.TabIndex = 4;
            this.addCharacter.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Уровень:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Здоровье:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Класс:";
            // 
            // levelBox
            // 
            this.levelBox.Location = new System.Drawing.Point(81, 120);
            this.levelBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.levelBox.Name = "levelBox";
            this.levelBox.Size = new System.Drawing.Size(43, 20);
            this.levelBox.TabIndex = 6;
            this.levelBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // healthBox
            // 
            this.healthBox.Location = new System.Drawing.Point(81, 90);
            this.healthBox.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.healthBox.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.healthBox.Name = "healthBox";
            this.healthBox.Size = new System.Drawing.Size(43, 20);
            this.healthBox.TabIndex = 5;
            this.healthBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // classBox
            // 
            this.classBox.FormattingEnabled = true;
            this.classBox.Items.AddRange(new object[] {
            "Маг",
            "Воин",
            "Рыцарь",
            "Лучник"});
            this.classBox.Location = new System.Drawing.Point(57, 58);
            this.classBox.Name = "classBox";
            this.classBox.Size = new System.Drawing.Size(100, 21);
            this.classBox.TabIndex = 4;
            // 
            // characterName
            // 
            this.characterName.Location = new System.Drawing.Point(57, 29);
            this.characterName.Name = "characterName";
            this.characterName.Size = new System.Drawing.Size(100, 20);
            this.characterName.TabIndex = 3;
            // 
            // characterCreateButton
            // 
            this.characterCreateButton.Location = new System.Drawing.Point(57, 161);
            this.characterCreateButton.Name = "characterCreateButton";
            this.characterCreateButton.Size = new System.Drawing.Size(75, 23);
            this.characterCreateButton.TabIndex = 2;
            this.characterCreateButton.Text = "Создать";
            this.characterCreateButton.UseVisualStyleBackColor = true;
            this.characterCreateButton.Click += new System.EventHandler(this.characterCreateButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Имя:";
            // 
            // labelCharacter
            // 
            this.labelCharacter.AutoSize = true;
            this.labelCharacter.Location = new System.Drawing.Point(33, 9);
            this.labelCharacter.Name = "labelCharacter";
            this.labelCharacter.Size = new System.Drawing.Size(115, 13);
            this.labelCharacter.TabIndex = 0;
            this.labelCharacter.Text = "Создание персонажа";
            // 
            // updatePlayer
            // 
            this.updatePlayer.Controls.Add(this.updatePlayerButton);
            this.updatePlayer.Controls.Add(this.updateName);
            this.updatePlayer.Controls.Add(this.label3);
            this.updatePlayer.Controls.Add(this.label8);
            this.updatePlayer.Location = new System.Drawing.Point(236, 8);
            this.updatePlayer.Name = "updatePlayer";
            this.updatePlayer.Size = new System.Drawing.Size(205, 106);
            this.updatePlayer.TabIndex = 3;
            this.updatePlayer.Visible = false;
            // 
            // updatePlayerButton
            // 
            this.updatePlayerButton.Location = new System.Drawing.Point(64, 66);
            this.updatePlayerButton.Name = "updatePlayerButton";
            this.updatePlayerButton.Size = new System.Drawing.Size(75, 23);
            this.updatePlayerButton.TabIndex = 3;
            this.updatePlayerButton.Text = "Обновить";
            this.updatePlayerButton.UseVisualStyleBackColor = true;
            this.updatePlayerButton.Click += new System.EventHandler(this.updatePlayerButton_Click);
            // 
            // updateName
            // 
            this.updateName.Location = new System.Drawing.Point(52, 40);
            this.updateName.Name = "updateName";
            this.updateName.Size = new System.Drawing.Size(100, 20);
            this.updateName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Имя игрока:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Изменение игрока";
            // 
            // updateCharacter
            // 
            this.updateCharacter.Controls.Add(this.label9);
            this.updateCharacter.Controls.Add(this.label10);
            this.updateCharacter.Controls.Add(this.label11);
            this.updateCharacter.Controls.Add(this.updateLevel);
            this.updateCharacter.Controls.Add(this.updateHealth);
            this.updateCharacter.Controls.Add(this.updateClass);
            this.updateCharacter.Controls.Add(this.updateCharName);
            this.updateCharacter.Controls.Add(this.updateCharButton);
            this.updateCharacter.Controls.Add(this.label12);
            this.updateCharacter.Controls.Add(this.label13);
            this.updateCharacter.Location = new System.Drawing.Point(236, 12);
            this.updateCharacter.Name = "updateCharacter";
            this.updateCharacter.Size = new System.Drawing.Size(202, 239);
            this.updateCharacter.TabIndex = 4;
            this.updateCharacter.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Уровень:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Здоровье:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Класс:";
            // 
            // updateLevel
            // 
            this.updateLevel.Location = new System.Drawing.Point(81, 120);
            this.updateLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updateLevel.Name = "updateLevel";
            this.updateLevel.Size = new System.Drawing.Size(43, 20);
            this.updateLevel.TabIndex = 6;
            this.updateLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // updateHealth
            // 
            this.updateHealth.Location = new System.Drawing.Point(81, 90);
            this.updateHealth.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.updateHealth.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.updateHealth.Name = "updateHealth";
            this.updateHealth.Size = new System.Drawing.Size(43, 20);
            this.updateHealth.TabIndex = 5;
            this.updateHealth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // updateClass
            // 
            this.updateClass.FormattingEnabled = true;
            this.updateClass.Items.AddRange(new object[] {
            "Маг",
            "Воин",
            "Рыцарь",
            "Лучник"});
            this.updateClass.Location = new System.Drawing.Point(57, 58);
            this.updateClass.Name = "updateClass";
            this.updateClass.Size = new System.Drawing.Size(100, 21);
            this.updateClass.TabIndex = 4;
            // 
            // updateCharName
            // 
            this.updateCharName.Location = new System.Drawing.Point(57, 29);
            this.updateCharName.Name = "updateCharName";
            this.updateCharName.Size = new System.Drawing.Size(100, 20);
            this.updateCharName.TabIndex = 3;
            // 
            // updateCharButton
            // 
            this.updateCharButton.Location = new System.Drawing.Point(57, 161);
            this.updateCharButton.Name = "updateCharButton";
            this.updateCharButton.Size = new System.Drawing.Size(75, 23);
            this.updateCharButton.TabIndex = 2;
            this.updateCharButton.Text = "Обновить";
            this.updateCharButton.UseVisualStyleBackColor = true;
            this.updateCharButton.Click += new System.EventHandler(this.updateCharButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Имя:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Обновление персонажа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление игрока";
            // 
            // TreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 298);
            this.Controls.Add(this.updateCharacter);
            this.Controls.Add(this.addCharacter);
            this.Controls.Add(this.updatePlayer);
            this.Controls.Add(this.addPlayer);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.treeView1);
            this.Name = "TreeView";
            this.Text = "TreeView";
            this.addPlayer.ResumeLayout(false);
            this.addPlayer.PerformLayout();
            this.addCharacter.ResumeLayout(false);
            this.addCharacter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthBox)).EndInit();
            this.updatePlayer.ResumeLayout(false);
            this.updatePlayer.PerformLayout();
            this.updateCharacter.ResumeLayout(false);
            this.updateCharacter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateHealth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel addPlayer;
        private System.Windows.Forms.Button AddPlayerButton;
        private System.Windows.Forms.TextBox playerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel addCharacter;
        private System.Windows.Forms.NumericUpDown levelBox;
        private System.Windows.Forms.NumericUpDown healthBox;
        private System.Windows.Forms.ComboBox classBox;
        private System.Windows.Forms.TextBox characterName;
        private System.Windows.Forms.Button characterCreateButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCharacter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel updatePlayer;
        private System.Windows.Forms.Button updatePlayerButton;
        private System.Windows.Forms.TextBox updateName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel updateCharacter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown updateLevel;
        private System.Windows.Forms.NumericUpDown updateHealth;
        private System.Windows.Forms.ComboBox updateClass;
        private System.Windows.Forms.TextBox updateCharName;
        private System.Windows.Forms.Button updateCharButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
    }
}

