namespace PacMan
{
    partial class F_Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Menu));
            this.pb_title = new System.Windows.Forms.PictureBox();
            this.b_modeplaye1 = new System.Windows.Forms.Button();
            this.b_mode_player2 = new System.Windows.Forms.Button();
            this.b_about_game = new System.Windows.Forms.Button();
            this.pb_gif = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gif)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_title
            // 
            this.pb_title.BackColor = System.Drawing.Color.Transparent;
            this.pb_title.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_title.BackgroundImage")));
            this.pb_title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_title.Location = new System.Drawing.Point(124, 42);
            this.pb_title.Name = "pb_title";
            this.pb_title.Size = new System.Drawing.Size(580, 81);
            this.pb_title.TabIndex = 0;
            this.pb_title.TabStop = false;
            // 
            // b_modeplaye1
            // 
            this.b_modeplaye1.BackColor = System.Drawing.Color.Transparent;
            this.b_modeplaye1.FlatAppearance.BorderSize = 0;
            this.b_modeplaye1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_modeplaye1.Font = new System.Drawing.Font("Pixel Coleco", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_modeplaye1.ForeColor = System.Drawing.Color.Transparent;
            this.b_modeplaye1.Location = new System.Drawing.Point(336, 265);
            this.b_modeplaye1.Name = "b_modeplaye1";
            this.b_modeplaye1.Size = new System.Drawing.Size(152, 36);
            this.b_modeplaye1.TabIndex = 1;
            this.b_modeplaye1.Text = "PLAYER 1 ";
            this.b_modeplaye1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_modeplaye1.UseVisualStyleBackColor = false;
            // 
            // b_mode_player2
            // 
            this.b_mode_player2.BackColor = System.Drawing.Color.Transparent;
            this.b_mode_player2.FlatAppearance.BorderSize = 0;
            this.b_mode_player2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_mode_player2.Font = new System.Drawing.Font("Pixel Coleco", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_mode_player2.ForeColor = System.Drawing.Color.Transparent;
            this.b_mode_player2.Location = new System.Drawing.Point(336, 307);
            this.b_mode_player2.Name = "b_mode_player2";
            this.b_mode_player2.Size = new System.Drawing.Size(152, 36);
            this.b_mode_player2.TabIndex = 2;
            this.b_mode_player2.Text = "PLAYER 2";
            this.b_mode_player2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_mode_player2.UseVisualStyleBackColor = false;
            // 
            // b_about_game
            // 
            this.b_about_game.BackColor = System.Drawing.Color.Transparent;
            this.b_about_game.FlatAppearance.BorderSize = 0;
            this.b_about_game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_about_game.Font = new System.Drawing.Font("Pixel Coleco", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_about_game.ForeColor = System.Drawing.Color.Transparent;
            this.b_about_game.Location = new System.Drawing.Point(325, 349);
            this.b_about_game.Name = "b_about_game";
            this.b_about_game.Size = new System.Drawing.Size(152, 36);
            this.b_about_game.TabIndex = 3;
            this.b_about_game.Text = "ABOUT";
            this.b_about_game.UseVisualStyleBackColor = false;
            // 
            // pb_gif
            // 
            this.pb_gif.Location = new System.Drawing.Point(111, 129);
            this.pb_gif.Name = "pb_gif";
            this.pb_gif.Size = new System.Drawing.Size(607, 117);
            this.pb_gif.TabIndex = 4;
            this.pb_gif.TabStop = false;
            // 
            // F_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb_gif);
            this.Controls.Add(this.b_about_game);
            this.Controls.Add(this.b_mode_player2);
            this.Controls.Add(this.b_modeplaye1);
            this.Controls.Add(this.pb_title);
            this.Name = "F_Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.F_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_title;
        private System.Windows.Forms.Button b_modeplaye1;
        private System.Windows.Forms.Button b_mode_player2;
        private System.Windows.Forms.Button b_about_game;
        private System.Windows.Forms.PictureBox pb_gif;
    }
}

