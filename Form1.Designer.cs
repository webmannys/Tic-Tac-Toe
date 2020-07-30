/* 
 * Manpreet Sangha
 * CS 39
 * Project: Tic Tac Toe Game
 */

namespace Tic_Tac_Toe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newplayer_panel = new System.Windows.Forms.Panel();
            this.game_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.current_player_label = new System.Windows.Forms.Label();
            this.ticbox_bottom_right = new System.Windows.Forms.TextBox();
            this.ticbox_bottom_middle = new System.Windows.Forms.TextBox();
            this.ticbox_bottom_left = new System.Windows.Forms.TextBox();
            this.ticbox_middle_right = new System.Windows.Forms.TextBox();
            this.ticbox_middle_middle = new System.Windows.Forms.TextBox();
            this.ticbox_middle_left = new System.Windows.Forms.TextBox();
            this.ticbox_top_right = new System.Windows.Forms.TextBox();
            this.ticbox_top_middle = new System.Windows.Forms.TextBox();
            this.ticbox_top_left = new System.Windows.Forms.TextBox();
            this.player2_label = new System.Windows.Forms.Label();
            this.player1_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.whogoesfirst_combobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.whosx_combobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.player1_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.newplayer_panel.SuspendLayout();
            this.game_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitGameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1137, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // exitGameToolStripMenuItem
            // 
            this.exitGameToolStripMenuItem.Name = "exitGameToolStripMenuItem";
            this.exitGameToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.exitGameToolStripMenuItem.Text = "Exit Game";
            this.exitGameToolStripMenuItem.Click += new System.EventHandler(this.ExitGameToolStripMenuItem_Click);
            // 
            // newplayer_panel
            // 
            this.newplayer_panel.Controls.Add(this.button1);
            this.newplayer_panel.Controls.Add(this.whogoesfirst_combobox);
            this.newplayer_panel.Controls.Add(this.label4);
            this.newplayer_panel.Controls.Add(this.whosx_combobox);
            this.newplayer_panel.Controls.Add(this.label3);
            this.newplayer_panel.Controls.Add(this.player1_txtbox);
            this.newplayer_panel.Controls.Add(this.label2);
            this.newplayer_panel.Controls.Add(this.label1);
            this.newplayer_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newplayer_panel.Location = new System.Drawing.Point(299, 381);
            this.newplayer_panel.Name = "newplayer_panel";
            this.newplayer_panel.Size = new System.Drawing.Size(551, 327);
            this.newplayer_panel.TabIndex = 1;
            this.newplayer_panel.Visible = false;
            // 
            // game_panel
            // 
            this.game_panel.Controls.Add(this.current_player_label);
            this.game_panel.Controls.Add(this.ticbox_bottom_right);
            this.game_panel.Controls.Add(this.ticbox_bottom_middle);
            this.game_panel.Controls.Add(this.ticbox_bottom_left);
            this.game_panel.Controls.Add(this.ticbox_middle_right);
            this.game_panel.Controls.Add(this.ticbox_middle_middle);
            this.game_panel.Controls.Add(this.ticbox_middle_left);
            this.game_panel.Controls.Add(this.ticbox_top_right);
            this.game_panel.Controls.Add(this.ticbox_top_middle);
            this.game_panel.Controls.Add(this.ticbox_top_left);
            this.game_panel.Controls.Add(this.player2_label);
            this.game_panel.Controls.Add(this.player1_label);
            this.game_panel.Location = new System.Drawing.Point(642, 48);
            this.game_panel.Name = "game_panel";
            this.game_panel.Size = new System.Drawing.Size(545, 327);
            this.game_panel.TabIndex = 2;
            this.game_panel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 324);
            this.panel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "How many Players?";
            // 
            // current_player_label
            // 
            this.current_player_label.AutoSize = true;
            this.current_player_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_player_label.Location = new System.Drawing.Point(3, 68);
            this.current_player_label.Name = "current_player_label";
            this.current_player_label.Size = new System.Drawing.Size(143, 25);
            this.current_player_label.TabIndex = 11;
            this.current_player_label.Text = "Current Player:";
            // 
            // ticbox_bottom_right
            // 
            this.ticbox_bottom_right.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ticbox_bottom_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticbox_bottom_right.Location = new System.Drawing.Point(333, 244);
            this.ticbox_bottom_right.MaxLength = 1;
            this.ticbox_bottom_right.Name = "ticbox_bottom_right";
            this.ticbox_bottom_right.Size = new System.Drawing.Size(70, 53);
            this.ticbox_bottom_right.TabIndex = 10;
            this.ticbox_bottom_right.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ticbox_bottom_right.TextChanged += new System.EventHandler(this.Ticbox_bottom_right_TextChanged);
            // 
            // ticbox_bottom_middle
            // 
            this.ticbox_bottom_middle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ticbox_bottom_middle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticbox_bottom_middle.Location = new System.Drawing.Point(257, 244);
            this.ticbox_bottom_middle.MaxLength = 1;
            this.ticbox_bottom_middle.Name = "ticbox_bottom_middle";
            this.ticbox_bottom_middle.Size = new System.Drawing.Size(70, 53);
            this.ticbox_bottom_middle.TabIndex = 9;
            this.ticbox_bottom_middle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ticbox_bottom_middle.TextChanged += new System.EventHandler(this.Ticbox_bottom_middle_TextChanged);
            // 
            // ticbox_bottom_left
            // 
            this.ticbox_bottom_left.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ticbox_bottom_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticbox_bottom_left.Location = new System.Drawing.Point(179, 243);
            this.ticbox_bottom_left.MaxLength = 1;
            this.ticbox_bottom_left.Name = "ticbox_bottom_left";
            this.ticbox_bottom_left.Size = new System.Drawing.Size(70, 53);
            this.ticbox_bottom_left.TabIndex = 8;
            this.ticbox_bottom_left.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ticbox_bottom_left.TextChanged += new System.EventHandler(this.Ticbox_bottom_left_TextChanged);
            // 
            // ticbox_middle_right
            // 
            this.ticbox_middle_right.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ticbox_middle_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticbox_middle_right.Location = new System.Drawing.Point(333, 184);
            this.ticbox_middle_right.MaxLength = 1;
            this.ticbox_middle_right.Name = "ticbox_middle_right";
            this.ticbox_middle_right.Size = new System.Drawing.Size(70, 53);
            this.ticbox_middle_right.TabIndex = 7;
            this.ticbox_middle_right.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ticbox_middle_right.TextChanged += new System.EventHandler(this.Ticbox_middle_right_TextChanged);
            // 
            // ticbox_middle_middle
            // 
            this.ticbox_middle_middle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ticbox_middle_middle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticbox_middle_middle.Location = new System.Drawing.Point(257, 184);
            this.ticbox_middle_middle.MaxLength = 1;
            this.ticbox_middle_middle.Name = "ticbox_middle_middle";
            this.ticbox_middle_middle.Size = new System.Drawing.Size(70, 53);
            this.ticbox_middle_middle.TabIndex = 6;
            this.ticbox_middle_middle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ticbox_middle_middle.TextChanged += new System.EventHandler(this.Ticbox_middle_middle_TextChanged);
            // 
            // ticbox_middle_left
            // 
            this.ticbox_middle_left.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ticbox_middle_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticbox_middle_left.Location = new System.Drawing.Point(179, 183);
            this.ticbox_middle_left.MaxLength = 1;
            this.ticbox_middle_left.Name = "ticbox_middle_left";
            this.ticbox_middle_left.Size = new System.Drawing.Size(70, 53);
            this.ticbox_middle_left.TabIndex = 5;
            this.ticbox_middle_left.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ticbox_middle_left.TextChanged += new System.EventHandler(this.Ticbox_middle_left_TextChanged);
            // 
            // ticbox_top_right
            // 
            this.ticbox_top_right.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ticbox_top_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticbox_top_right.Location = new System.Drawing.Point(333, 124);
            this.ticbox_top_right.MaxLength = 1;
            this.ticbox_top_right.Name = "ticbox_top_right";
            this.ticbox_top_right.Size = new System.Drawing.Size(70, 53);
            this.ticbox_top_right.TabIndex = 4;
            this.ticbox_top_right.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ticbox_top_right.TextChanged += new System.EventHandler(this.Ticbox_top_right_TextChanged);
            // 
            // ticbox_top_middle
            // 
            this.ticbox_top_middle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ticbox_top_middle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticbox_top_middle.Location = new System.Drawing.Point(257, 124);
            this.ticbox_top_middle.MaxLength = 1;
            this.ticbox_top_middle.Name = "ticbox_top_middle";
            this.ticbox_top_middle.Size = new System.Drawing.Size(70, 53);
            this.ticbox_top_middle.TabIndex = 3;
            this.ticbox_top_middle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ticbox_top_middle.TextChanged += new System.EventHandler(this.Ticbox_top_middle_TextChanged);
            // 
            // ticbox_top_left
            // 
            this.ticbox_top_left.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ticbox_top_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticbox_top_left.Location = new System.Drawing.Point(179, 124);
            this.ticbox_top_left.MaxLength = 1;
            this.ticbox_top_left.Name = "ticbox_top_left";
            this.ticbox_top_left.Size = new System.Drawing.Size(70, 53);
            this.ticbox_top_left.TabIndex = 2;
            this.ticbox_top_left.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ticbox_top_left.TextChanged += new System.EventHandler(this.Ticbox_top_left_TextChanged);
            // 
            // player2_label
            // 
            this.player2_label.AutoSize = true;
            this.player2_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2_label.Location = new System.Drawing.Point(4, 33);
            this.player2_label.Name = "player2_label";
            this.player2_label.Size = new System.Drawing.Size(106, 29);
            this.player2_label.TabIndex = 1;
            this.player2_label.Text = "Player 2:";
            // 
            // player1_label
            // 
            this.player1_label.AutoSize = true;
            this.player1_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1_label.Location = new System.Drawing.Point(4, 4);
            this.player1_label.Name = "player1_label";
            this.player1_label.Size = new System.Drawing.Size(106, 29);
            this.player1_label.TabIndex = 0;
            this.player1_label.Text = "Player 1:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 56);
            this.button1.TabIndex = 8;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // whogoesfirst_combobox
            // 
            this.whogoesfirst_combobox.FormattingEnabled = true;
            this.whogoesfirst_combobox.Items.AddRange(new object[] {
            "Player1",
            "Player2"});
            this.whogoesfirst_combobox.Location = new System.Drawing.Point(209, 187);
            this.whogoesfirst_combobox.Name = "whogoesfirst_combobox";
            this.whogoesfirst_combobox.Size = new System.Drawing.Size(121, 37);
            this.whogoesfirst_combobox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Who goes first";
            // 
            // whosx_combobox
            // 
            this.whosx_combobox.FormattingEnabled = true;
            this.whosx_combobox.Items.AddRange(new object[] {
            "Player1",
            "Player2"});
            this.whosx_combobox.Location = new System.Drawing.Point(209, 124);
            this.whosx_combobox.Name = "whosx_combobox";
            this.whosx_combobox.Size = new System.Drawing.Size(121, 37);
            this.whosx_combobox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Who will be X";
            // 
            // player1_txtbox
            // 
            this.player1_txtbox.Location = new System.Drawing.Point(209, 22);
            this.player1_txtbox.Name = "player1_txtbox";
            this.player1_txtbox.Size = new System.Drawing.Size(307, 34);
            this.player1_txtbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player 2 Name: Computer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player 1 Name";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(203, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(203, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 746);
            this.Controls.Add(this.newplayer_panel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.game_panel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.newplayer_panel.ResumeLayout(false);
            this.newplayer_panel.PerformLayout();
            this.game_panel.ResumeLayout(false);
            this.game_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitGameToolStripMenuItem;
        private System.Windows.Forms.Panel newplayer_panel;
        private System.Windows.Forms.ComboBox whosx_combobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox player1_txtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox whogoesfirst_combobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ticbox_middle_left;
        private System.Windows.Forms.TextBox ticbox_top_right;
        private System.Windows.Forms.TextBox ticbox_top_middle;
        private System.Windows.Forms.TextBox ticbox_top_left;
        private System.Windows.Forms.Label player2_label;
        private System.Windows.Forms.Label player1_label;
        private System.Windows.Forms.TextBox ticbox_bottom_right;
        private System.Windows.Forms.TextBox ticbox_bottom_middle;
        private System.Windows.Forms.TextBox ticbox_bottom_left;
        private System.Windows.Forms.TextBox ticbox_middle_right;
        private System.Windows.Forms.TextBox ticbox_middle_middle;
        private System.Windows.Forms.Panel game_panel;
        private System.Windows.Forms.Label current_player_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

