
namespace AnimatedGame
{
    partial class MenuScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.infobutton = new System.Windows.Forms.Button();
            this.twoPlayer = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.PlayerTwoLabel = new System.Windows.Forms.Label();
            this.PlayerOneLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.White;
            this.titleLabel.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(57, 84);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(300, 117);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "TANKS";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(57, 557);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(300, 64);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // infobutton
            // 
            this.infobutton.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infobutton.Location = new System.Drawing.Point(57, 459);
            this.infobutton.Name = "infobutton";
            this.infobutton.Size = new System.Drawing.Size(300, 64);
            this.infobutton.TabIndex = 3;
            this.infobutton.Text = "How To Play";
            this.infobutton.UseVisualStyleBackColor = true;
            this.infobutton.Click += new System.EventHandler(this.infobutton_Click_1);
            // 
            // twoPlayer
            // 
            this.twoPlayer.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.twoPlayer.Location = new System.Drawing.Point(57, 361);
            this.twoPlayer.Name = "twoPlayer";
            this.twoPlayer.Size = new System.Drawing.Size(300, 64);
            this.twoPlayer.TabIndex = 4;
            this.twoPlayer.Text = "2-Player";
            this.twoPlayer.UseVisualStyleBackColor = true;
            this.twoPlayer.Click += new System.EventHandler(this.twoPlayer_Click_1);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputLabel.Location = new System.Drawing.Point(630, 55);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(309, 583);
            this.outputLabel.TabIndex = 5;
            // 
            // PlayerTwoLabel
            // 
            this.PlayerTwoLabel.BackColor = System.Drawing.Color.Snow;
            this.PlayerTwoLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerTwoLabel.Location = new System.Drawing.Point(217, 232);
            this.PlayerTwoLabel.Name = "PlayerTwoLabel";
            this.PlayerTwoLabel.Size = new System.Drawing.Size(140, 100);
            this.PlayerTwoLabel.TabIndex = 7;
            this.PlayerTwoLabel.Text = "Player Two Wins:";
            this.PlayerTwoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PlayerOneLabel
            // 
            this.PlayerOneLabel.BackColor = System.Drawing.Color.Snow;
            this.PlayerOneLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerOneLabel.Location = new System.Drawing.Point(57, 232);
            this.PlayerOneLabel.Name = "PlayerOneLabel";
            this.PlayerOneLabel.Size = new System.Drawing.Size(140, 100);
            this.PlayerOneLabel.TabIndex = 8;
            this.PlayerOneLabel.Text = "Player One Wins:";
            this.PlayerOneLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.PlayerOneLabel);
            this.Controls.Add(this.PlayerTwoLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.twoPlayer);
            this.Controls.Add(this.infobutton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.titleLabel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(1000, 700);
            this.Load += new System.EventHandler(this.MenuScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button infobutton;
        private System.Windows.Forms.Button twoPlayer;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label PlayerTwoLabel;
        private System.Windows.Forms.Label PlayerOneLabel;
    }
}
