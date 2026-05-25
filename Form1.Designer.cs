namespace Yahtzee_cheat_app
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.cmbWorp = new System.Windows.Forms.ComboBox();
            this.lblInstructie = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();

            // Nieuwe Controls voor Dobbelstenen & Acties
            this.txtD1 = new System.Windows.Forms.TextBox();
            this.txtD2 = new System.Windows.Forms.TextBox();
            this.txtD3 = new System.Windows.Forms.TextBox();
            this.txtD4 = new System.Windows.Forms.TextBox();
            this.txtD5 = new System.Windows.Forms.TextBox();

            this.btnHold1 = new System.Windows.Forms.Button();
            this.btnHold2 = new System.Windows.Forms.Button();
            this.btnHold3 = new System.Windows.Forms.Button();
            this.btnHold4 = new System.Windows.Forms.Button();
            this.btnHold5 = new System.Windows.Forms.Button();

            this.btnWisVrije = new System.Windows.Forms.Button();
            this.btnApplyScore = new System.Windows.Forms.Button();

            // Scorecard textboxes
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();

            this.txt3K = new System.Windows.Forms.TextBox();
            this.txt4K = new System.Windows.Forms.TextBox();
            this.txtFH = new System.Windows.Forms.TextBox();
            this.txtSS = new System.Windows.Forms.TextBox();
            this.txtLS = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();

            // Labels
            this.lbl1 = new System.Windows.Forms.Label(); this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label(); this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label(); this.lbl6 = new System.Windows.Forms.Label();
            this.lbl3K = new System.Windows.Forms.Label(); this.lbl4K = new System.Windows.Forms.Label();
            this.lblFH = new System.Windows.Forms.Label(); this.lblSS = new System.Windows.Forms.Label();
            this.lblLS = new System.Windows.Forms.Label(); this.lblY = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblUpperScore = new System.Windows.Forms.Label(); this.lblBonus = new System.Windows.Forms.Label();
            this.lblTotalScore = new System.Windows.Forms.Label(); this.lblStatusTitle = new System.Windows.Forms.Label();
            this.lblLowerTitle = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // 
            // TOP INSTRUCTIE & INPUTS
            // 
            this.lblInstructie.AutoSize = true;
            this.lblInstructie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblInstructie.Location = new System.Drawing.Point(30, 20);
            this.lblInstructie.Text = "Huidige Dobbelstenen (1-6):";

            // Textboxen (Dobbelstenen)
            int dStartX = 34; int dY = 50; int dSize = 40; int dSpace = 50;
            System.Drawing.Font dFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);

            this.txtD1.Location = new System.Drawing.Point(dStartX, dY); this.txtD1.Size = new System.Drawing.Size(dSize, dSize); this.txtD1.Font = dFont; this.txtD1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center; this.txtD1.MaxLength = 1;
            this.txtD2.Location = new System.Drawing.Point(dStartX + dSpace * 1, dY); this.txtD2.Size = new System.Drawing.Size(dSize, dSize); this.txtD2.Font = dFont; this.txtD2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center; this.txtD2.MaxLength = 1;
            this.txtD3.Location = new System.Drawing.Point(dStartX + dSpace * 2, dY); this.txtD3.Size = new System.Drawing.Size(dSize, dSize); this.txtD3.Font = dFont; this.txtD3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center; this.txtD3.MaxLength = 1;
            this.txtD4.Location = new System.Drawing.Point(dStartX + dSpace * 3, dY); this.txtD4.Size = new System.Drawing.Size(dSize, dSize); this.txtD4.Font = dFont; this.txtD4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center; this.txtD4.MaxLength = 1;
            this.txtD5.Location = new System.Drawing.Point(dStartX + dSpace * 4, dY); this.txtD5.Size = new System.Drawing.Size(dSize, dSize); this.txtD5.Font = dFont; this.txtD5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center; this.txtD5.MaxLength = 1;

            // Hold Buttons
            int hY = 95; int hSizeX = 40; int hSizeY = 25;
            System.Drawing.Font hFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);

            this.btnHold1.Location = new System.Drawing.Point(dStartX, hY); this.btnHold1.Size = new System.Drawing.Size(hSizeX, hSizeY); this.btnHold1.Font = hFont; this.btnHold1.Text = "VRIJ"; this.btnHold1.BackColor = System.Drawing.Color.LightGray; this.btnHold1.Click += new System.EventHandler(this.btnHold_Click);
            this.btnHold2.Location = new System.Drawing.Point(dStartX + dSpace * 1, hY); this.btnHold2.Size = new System.Drawing.Size(hSizeX, hSizeY); this.btnHold2.Font = hFont; this.btnHold2.Text = "VRIJ"; this.btnHold2.BackColor = System.Drawing.Color.LightGray; this.btnHold2.Click += new System.EventHandler(this.btnHold_Click);
            this.btnHold3.Location = new System.Drawing.Point(dStartX + dSpace * 2, hY); this.btnHold3.Size = new System.Drawing.Size(hSizeX, hSizeY); this.btnHold3.Font = hFont; this.btnHold3.Text = "VRIJ"; this.btnHold3.BackColor = System.Drawing.Color.LightGray; this.btnHold3.Click += new System.EventHandler(this.btnHold_Click);
            this.btnHold4.Location = new System.Drawing.Point(dStartX + dSpace * 3, hY); this.btnHold4.Size = new System.Drawing.Size(hSizeX, hSizeY); this.btnHold4.Font = hFont; this.btnHold4.Text = "VRIJ"; this.btnHold4.BackColor = System.Drawing.Color.LightGray; this.btnHold4.Click += new System.EventHandler(this.btnHold_Click);
            this.btnHold5.Location = new System.Drawing.Point(dStartX + dSpace * 4, hY); this.btnHold5.Size = new System.Drawing.Size(hSizeX, hSizeY); this.btnHold5.Font = hFont; this.btnHold5.Text = "VRIJ"; this.btnHold5.BackColor = System.Drawing.Color.LightGray; this.btnHold5.Click += new System.EventHandler(this.btnHold_Click);

            // Actie Knoppen Bovenin
            this.btnWisVrije.Location = new System.Drawing.Point(295, 50);
            this.btnWisVrije.Size = new System.Drawing.Size(150, 36);
            this.btnWisVrije.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnWisVrije.Text = "WIS VRIJE (ROLL)";
            this.btnWisVrije.Click += new System.EventHandler(this.btnWisVrije_Click);

            this.cmbWorp.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbWorp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorp.Items.AddRange(new object[] { "Worp 1", "Worp 2", "Worp 3 (Scoren)" });
            this.cmbWorp.Location = new System.Drawing.Point(295, 93);
            this.cmbWorp.Size = new System.Drawing.Size(150, 30);

            this.btnCalculate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.Location = new System.Drawing.Point(460, 50);
            this.btnCalculate.Size = new System.Drawing.Size(180, 70);
            this.btnCalculate.Text = "GEEF ADVIES 🧠";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // TITELS VOOR KOLOMMEN
            this.lblStatusTitle.AutoSize = true; this.lblStatusTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold); this.lblStatusTitle.Location = new System.Drawing.Point(30, 140); this.lblStatusTitle.Text = "UPPER SECTION";
            this.lblLowerTitle.AutoSize = true; this.lblLowerTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold); this.lblLowerTitle.Location = new System.Drawing.Point(400, 140); this.lblLowerTitle.Text = "LOWER SECTION";

            // SCORECARD (Linker & Rechterkolom) - Zelfde posities, iets lager
            int startXLeft = 34; int startY = 180; int stepY = 48; int boxWidth = 80; int boxHeight = 30;

            this.lbl1.Text = "1'en (Ones):"; this.lbl1.Location = new System.Drawing.Point(startXLeft, startY); this.lbl1.Font = new System.Drawing.Font("Segoe UI", 12F); this.lbl1.Size = new System.Drawing.Size(140, 25);
            this.txt1.Location = new System.Drawing.Point(startXLeft + 150, startY - 3); this.txt1.Size = new System.Drawing.Size(boxWidth, boxHeight); this.txt1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl2.Text = "2'en (Twos):"; this.lbl2.Location = new System.Drawing.Point(startXLeft, startY += stepY); this.lbl2.Font = new System.Drawing.Font("Segoe UI", 12F); this.lbl2.Size = new System.Drawing.Size(140, 25);
            this.txt2.Location = new System.Drawing.Point(startXLeft + 150, startY - 3); this.txt2.Size = new System.Drawing.Size(boxWidth, boxHeight); this.txt2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl3.Text = "3'en (Threes):"; this.lbl3.Location = new System.Drawing.Point(startXLeft, startY += stepY); this.lbl3.Font = new System.Drawing.Font("Segoe UI", 12F); this.lbl3.Size = new System.Drawing.Size(140, 25);
            this.txt3.Location = new System.Drawing.Point(startXLeft + 150, startY - 3); this.txt3.Size = new System.Drawing.Size(boxWidth, boxHeight); this.txt3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl4.Text = "4'en (Fours):"; this.lbl4.Location = new System.Drawing.Point(startXLeft, startY += stepY); this.lbl4.Font = new System.Drawing.Font("Segoe UI", 12F); this.lbl4.Size = new System.Drawing.Size(140, 25);
            this.txt4.Location = new System.Drawing.Point(startXLeft + 150, startY - 3); this.txt4.Size = new System.Drawing.Size(boxWidth, boxHeight); this.txt4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl5.Text = "5'en (Fives):"; this.lbl5.Location = new System.Drawing.Point(startXLeft, startY += stepY); this.lbl5.Font = new System.Drawing.Font("Segoe UI", 12F); this.lbl5.Size = new System.Drawing.Size(140, 25);
            this.txt5.Location = new System.Drawing.Point(startXLeft + 150, startY - 3); this.txt5.Size = new System.Drawing.Size(boxWidth, boxHeight); this.txt5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl6.Text = "6'en (Sixes):"; this.lbl6.Location = new System.Drawing.Point(startXLeft, startY += stepY); this.lbl6.Font = new System.Drawing.Font("Segoe UI", 12F); this.lbl6.Size = new System.Drawing.Size(140, 25);
            this.txt6.Location = new System.Drawing.Point(startXLeft + 150, startY - 3); this.txt6.Size = new System.Drawing.Size(boxWidth, boxHeight); this.txt6.Font = new System.Drawing.Font("Segoe UI", 12F);

            this.lblUpperScore.Text = "Upper Totaal: 0"; this.lblUpperScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold); this.lblUpperScore.Location = new System.Drawing.Point(startXLeft, startY += 55); this.lblUpperScore.Size = new System.Drawing.Size(220, 25);
            this.lblBonus.Text = "Bonus (>=63): 0"; this.lblBonus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold); this.lblBonus.Location = new System.Drawing.Point(startXLeft, startY += 30); this.lblBonus.Size = new System.Drawing.Size(220, 25);

            int startXRight = 400; startY = 180;
            this.lbl3K.Text = "3 of a Kind:"; this.lbl3K.Location = new System.Drawing.Point(startXRight, startY); this.lbl3K.Font = new System.Drawing.Font("Segoe UI", 12F); this.lbl3K.Size = new System.Drawing.Size(140, 25);
            this.txt3K.Location = new System.Drawing.Point(startXRight + 150, startY - 3); this.txt3K.Size = new System.Drawing.Size(boxWidth, boxHeight); this.txt3K.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl4K.Text = "4 of a Kind:"; this.lbl4K.Location = new System.Drawing.Point(startXRight, startY += stepY); this.lbl4K.Font = new System.Drawing.Font("Segoe UI", 12F); this.lbl4K.Size = new System.Drawing.Size(140, 25);
            this.txt4K.Location = new System.Drawing.Point(startXRight + 150, startY - 3); this.txt4K.Size = new System.Drawing.Size(boxWidth, boxHeight); this.txt4K.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblFH.Text = "Full House:"; this.lblFH.Location = new System.Drawing.Point(startXRight, startY += stepY); this.lblFH.Font = new System.Drawing.Font("Segoe UI", 12F); this.lblFH.Size = new System.Drawing.Size(140, 25);
            this.txtFH.Location = new System.Drawing.Point(startXRight + 150, startY - 3); this.txtFH.Size = new System.Drawing.Size(boxWidth, boxHeight); this.txtFH.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSS.Text = "Sm. Straight:"; this.lblSS.Location = new System.Drawing.Point(startXRight, startY += stepY); this.lblSS.Font = new System.Drawing.Font("Segoe UI", 12F); this.lblSS.Size = new System.Drawing.Size(140, 25);
            this.txtSS.Location = new System.Drawing.Point(startXRight + 150, startY - 3); this.txtSS.Size = new System.Drawing.Size(boxWidth, boxHeight); this.txtSS.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblLS.Text = "Lg. Straight:"; this.lblLS.Location = new System.Drawing.Point(startXRight, startY += stepY); this.lblLS.Font = new System.Drawing.Font("Segoe UI", 12F); this.lblLS.Size = new System.Drawing.Size(140, 25);
            this.txtLS.Location = new System.Drawing.Point(startXRight + 150, startY - 3); this.txtLS.Size = new System.Drawing.Size(boxWidth, boxHeight); this.txtLS.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblY.Text = "Yahtzee:"; this.lblY.Location = new System.Drawing.Point(startXRight, startY += stepY); this.lblY.Font = new System.Drawing.Font("Segoe UI", 12F); this.lblY.Size = new System.Drawing.Size(140, 25);
            this.txtY.Location = new System.Drawing.Point(startXRight + 150, startY - 3); this.txtY.Size = new System.Drawing.Size(boxWidth, boxHeight); this.txtY.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblC.Text = "Chance:"; this.lblC.Location = new System.Drawing.Point(startXRight, startY += stepY); this.lblC.Font = new System.Drawing.Font("Segoe UI", 12F); this.lblC.Size = new System.Drawing.Size(140, 25);
            this.txtC.Location = new System.Drawing.Point(startXRight + 150, startY - 3); this.txtC.Size = new System.Drawing.Size(boxWidth, boxHeight); this.txtC.Font = new System.Drawing.Font("Segoe UI", 12F);

            this.lblTotalScore.Text = "EINDTOTAAL: 0"; this.lblTotalScore.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold); this.lblTotalScore.Location = new System.Drawing.Point(startXRight, startY += 55); this.lblTotalScore.Size = new System.Drawing.Size(250, 35); this.lblTotalScore.ForeColor = System.Drawing.Color.DarkBlue;

            // OUTPUT ADVIESBOX & TOEPASSEN KNOP
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblResult.BackColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(34, 570);
            this.lblResult.Size = new System.Drawing.Size(460, 100);
            this.lblResult.Text = "Vul je dobbelstenen in en klik op GEEF ADVIES.";
            this.lblResult.Padding = new System.Windows.Forms.Padding(10);

            this.btnApplyScore.BackColor = System.Drawing.Color.LightGreen;
            this.btnApplyScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnApplyScore.Location = new System.Drawing.Point(510, 570);
            this.btnApplyScore.Size = new System.Drawing.Size(170, 100);
            this.btnApplyScore.Text = "SCHRIJF OP\nKAART 📝";
            this.btnApplyScore.UseVisualStyleBackColor = false;
            this.btnApplyScore.Enabled = false;
            this.btnApplyScore.Click += new System.EventHandler(this.btnApplyScore_Click);

            // Form Eigenschappen
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 700);

            // Nieuwe controls toevoegen
            this.Controls.Add(this.txtD1); this.Controls.Add(this.txtD2); this.Controls.Add(this.txtD3); this.Controls.Add(this.txtD4); this.Controls.Add(this.txtD5);
            this.Controls.Add(this.btnHold1); this.Controls.Add(this.btnHold2); this.Controls.Add(this.btnHold3); this.Controls.Add(this.btnHold4); this.Controls.Add(this.btnHold5);
            this.Controls.Add(this.btnWisVrije); this.Controls.Add(this.btnApplyScore);

            this.Controls.Add(this.lblLowerTitle); this.Controls.Add(this.lblStatusTitle);
            this.Controls.Add(this.lblInstructie);
            this.Controls.Add(this.cmbWorp); this.Controls.Add(this.btnCalculate); this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lbl1); this.Controls.Add(this.txt1); this.Controls.Add(this.lbl2); this.Controls.Add(this.txt2);
            this.Controls.Add(this.lbl3); this.Controls.Add(this.txt3); this.Controls.Add(this.lbl4); this.Controls.Add(this.txt4);
            this.Controls.Add(this.lbl5); this.Controls.Add(this.txt5); this.Controls.Add(this.lbl6); this.Controls.Add(this.txt6);
            this.Controls.Add(this.lblUpperScore); this.Controls.Add(this.lblBonus);
            this.Controls.Add(this.lbl3K); this.Controls.Add(this.txt3K); this.Controls.Add(this.lbl4K); this.Controls.Add(this.txt4K);
            this.Controls.Add(this.lblFH); this.Controls.Add(this.txtFH); this.Controls.Add(this.lblSS); this.Controls.Add(this.txtSS);
            this.Controls.Add(this.lblLS); this.Controls.Add(this.txtLS); this.Controls.Add(this.lblY); this.Controls.Add(this.txtY);
            this.Controls.Add(this.lblC); this.Controls.Add(this.txtC); this.Controls.Add(this.lblTotalScore);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "Actuarial Yahtzee Smart Tracker Pro";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtD1, txtD2, txtD3, txtD4, txtD5;
        private System.Windows.Forms.Button btnHold1, btnHold2, btnHold3, btnHold4, btnHold5;
        private System.Windows.Forms.Button btnWisVrije, btnApplyScore;

        private System.Windows.Forms.ComboBox cmbWorp;
        private System.Windows.Forms.Label lblInstructie;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;

        private System.Windows.Forms.TextBox txt1, txt2, txt3, txt4, txt5, txt6;
        private System.Windows.Forms.TextBox txt3K, txt4K, txtFH, txtSS, txtLS, txtY, txtC;
        private System.Windows.Forms.Label lbl1, lbl2, lbl3, lbl4, lbl5, lbl6;
        private System.Windows.Forms.Label lbl3K, lbl4K, lblFH, lblSS, lblLS, lblY, lblC;
        private System.Windows.Forms.Label lblUpperScore, lblBonus, lblTotalScore, lblStatusTitle, lblLowerTitle;
    }
}