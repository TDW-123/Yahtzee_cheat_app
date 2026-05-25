using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Yahtzee_cheat_app
{
    public partial class Form1 : Form
    {
        private TextBox targetBoxToFill = null;
        private int valueToFill = 0;

        // Nieuw: Variabelen om de Yahtzee Bonus (100pt) onzichtbaar bij te houden
        private int yahtzeeBonusCount = 0;
        private bool isYahtzeeBonusAdvice = false;

        public Form1()
        {
            InitializeComponent();
            cmbWorp.SelectedIndex = 0;
            TextBox[] diceBoxes = { txtD1, txtD2, txtD3, txtD4, txtD5 };
            foreach (var box in diceBoxes)
            {
                box.TextChanged += DiceBox_TextChanged;
            }
        }

        private void DiceBox_TextChanged(object sender, EventArgs e)
        {
            TextBox currentBox = sender as TextBox;
            if (currentBox == null || string.IsNullOrEmpty(currentBox.Text)) return;

            // Bepaal index van huidige box
            TextBox[] diceBoxes = { txtD1, txtD2, txtD3, txtD4, txtD5 };
            Button[] holdButtons = { btnHold1, btnHold2, btnHold3, btnHold4, btnHold5 };
            int currentIndex = Array.IndexOf(diceBoxes, currentBox);

            // Spring naar de volgende VRIJE box
            for (int i = currentIndex + 1; i < 5; i++)
            {
                if (holdButtons[i].Text == "VRIJ")
                {
                    diceBoxes[i].Focus();
                    return;
                }
            }

            // Als we hier komen, zijn alle VRIJE boxen ingevuld: trigger advies
            btnCalculate_Click(null, EventArgs.Empty);
        }

        // --- UI INTERACTIE: DOBBELSTENEN VASTZETTEN ---
        private void btnHold_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "VRIJ")
            {
                btn.Text = "VAST";
                btn.BackColor = Color.Gold;
            }
            else
            {
                btn.Text = "VRIJ";
                btn.BackColor = Color.LightGray;
            }
        }

        // --- UI INTERACTIE: WIS VRIJE CIJFERS (ROLL) EN SCHUIF NAAR RECHTS ---
        // --- NIEUW: WIS VRIJE (ZONDER FOUTMELDING) ---
        private void btnWisVrije_Click(object sender, EventArgs e)
        {
            TextBox[] diceBoxes = { txtD1, txtD2, txtD3, txtD4, txtD5 };
            Button[] holdButtons = { btnHold1, btnHold2, btnHold3, btnHold4, btnHold5 };

            // Alleen de VRIJE wissen
            for (int i = 0; i < 5; i++)
            {
                if (holdButtons[i].Text == "VRIJ")
                {
                    diceBoxes[i].Text = "";
                }
            }

            // Verhoog de worp teller
            if (cmbWorp.SelectedIndex < 2) cmbWorp.SelectedIndex++;

            // Focus terug naar de eerste vrije box
            for (int i = 0; i < 5; i++)
            {
                if (holdButtons[i].Text == "VRIJ")
                {
                    diceBoxes[i].Focus();
                    break;
                }
            }
        }

        // --- BEREKEN ADVIES ---
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            List<int> dice = new List<int>();
            TextBox[] diceBoxes = { txtD1, txtD2, txtD3, txtD4, txtD5 };

            foreach (var box in diceBoxes)
            {
                if (int.TryParse(box.Text, out int val) && val >= 1 && val <= 6)
                {
                    dice.Add(val);
                }
            }

            if (dice.Count != 5)
            {
                MessageBox.Show("Vul in alle 5 de vakjes een getal in.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int worp = cmbWorp.SelectedIndex + 1;
            UpdateScores();

            targetBoxToFill = null;
            isYahtzeeBonusAdvice = false; // Reset voor we nieuw advies geven
            btnApplyScore.Enabled = false;

            if (worp == 1 || worp == 2)
            {
                lblResult.Text = GetHoldAdvice(dice);
            }
            else // Scoren
            {
                lblResult.Text = GetPlacementAdvice(dice);
                if (targetBoxToFill != null) btnApplyScore.Enabled = true;
            }
        }

        // --- ADVIES OPVOLGEN & OPSLAAN ---
        private void btnApplyScore_Click(object sender, EventArgs e)
        {
            if (targetBoxToFill != null)
            {
                targetBoxToFill.Text = valueToFill.ToString();

                // Als dit een Yahtzee bonus was, sla dit onzichtbaar op
                if (isYahtzeeBonusAdvice)
                {
                    yahtzeeBonusCount++;
                }

                UpdateScores();

                lblResult.Text = $"✅ Succes! Punten genoteerd. Klaar voor een nieuwe ronde.";

                TextBox[] diceBoxes = { txtD1, txtD2, txtD3, txtD4, txtD5 };
                Button[] holdButtons = { btnHold1, btnHold2, btnHold3, btnHold4, btnHold5 };

                foreach (var box in diceBoxes) box.Text = "";
                foreach (var btn in holdButtons) { btn.Text = "VRIJ"; btn.BackColor = Color.LightGray; }

                cmbWorp.SelectedIndex = 0;
                btnApplyScore.Enabled = false;
                targetBoxToFill = null;
                isYahtzeeBonusAdvice = false;
            }
        }

        private void UpdateScores()
        {
            int upperScore = GetUpperSum();
            lblUpperScore.Text = $"Upper Totaal: {upperScore}";
            int bonus = upperScore >= 63 ? 35 : 0;
            lblBonus.Text = $"Bonus (>=63): {bonus}";

            int lowerScore = 0;
            TextBox[] lowerBoxes = { txt3K, txt4K, txtFH, txtSS, txtLS, txtY, txtC };
            foreach (var box in lowerBoxes)
            {
                if (int.TryParse(box.Text, out int val)) lowerScore += val;
            }

            // Yahtzee bonus berekenen (100pt per stuk)
            int yahtzeeBonusScore = yahtzeeBonusCount * 100;
            int grandTotal = upperScore + bonus + lowerScore + yahtzeeBonusScore;

            if (yahtzeeBonusCount > 0)
            {
                lblTotalScore.Text = $"EINDTOTAAL: {grandTotal} (+{yahtzeeBonusCount}x Yahtzee Bonus!)";
            }
            else
            {
                lblTotalScore.Text = $"EINDTOTAAL: {grandTotal}";
            }
        }

        private bool IsOpen(TextBox box) { return string.IsNullOrWhiteSpace(box.Text); }
        private int GetUpperSum()
        {
            int sum = 0;
            TextBox[] upperBoxes = { txt1, txt2, txt3, txt4, txt5, txt6 };
            foreach (var box in upperBoxes) if (int.TryParse(box.Text, out int val)) sum += val;
            return sum;
        }
        private TextBox GetUpperBox(int number)
        {
            switch (number) { case 1: return txt1; case 2: return txt2; case 3: return txt3; case 4: return txt4; case 5: return txt5; case 6: return txt6; default: return txt1; }
        }

        // --- LOGICA: VASTHOUDEN ---
        private string GetHoldAdvice(List<int> dice)
        {
            var counts = dice.GroupBy(d => d).ToDictionary(g => g.Key, g => g.Count());
            int uniqueNumbers = counts.Count;
            bool bonusSecured = GetUpperSum() >= 63;

            if (!bonusSecured)
            {
                foreach (var num in new[] { 6, 5, 4 })
                {
                    if (counts.ContainsKey(num) && counts[num] >= 2 && IsOpen(GetUpperBox(num)))
                        return $"🔥 STRATEGIE: Zet alle {num}'en op VAST.\nReden: Focus op de 35-punten bonus.";
                }
            }

            if (IsOpen(txtLS) && uniqueNumbers >= 4)
            {
                var distinctDice = dice.Distinct().OrderBy(d => d).ToList();
                bool isOpenStraight = false;
                if (distinctDice.Count >= 4)
                {
                    for (int i = 0; i <= distinctDice.Count - 4; i++)
                        if (distinctDice[i + 3] - distinctDice[i] == 3) isOpenStraight = true;
                }
                if (isOpenStraight)
                    return $"🎲 STRATEGIE: Zet de opeenvolgende straat op VAST.\nReden: Dubbele kans op een Grote Straat.";
            }

            var multiples = counts.Where(c => c.Value >= 2).OrderByDescending(c => c.Value).ThenByDescending(c => c.Key).ToList();
            foreach (var mult in multiples)
            {
                // Let op: Nu checken we ook of txtY op "50" staat, want dan is vasthouden voor de bonus slim!
                if (IsOpen(GetUpperBox(mult.Key)) || IsOpen(txt3K) || IsOpen(txt4K) || IsOpen(txtFH) || IsOpen(txtY) || txtY.Text == "50")
                {
                    return $"💎 STANDAARD: Zet de {mult.Key}'en op VAST.\nReden: Basis voor de bovenkant, combinaties of een Yahtzee(bonus)!";
                }
            }

            return $"⚠️ NOOD: Zet de {dice.Max()} op VAST en wis de rest.\nReden: Zwakke hand en je combinaties zitten vol. Bouw op het hoogste getal.";
        }

        // --- LOGICA: SCOREN ---
        private string GetPlacementAdvice(List<int> dice)
        {
            var counts = dice.GroupBy(d => d).ToDictionary(g => g.Key, g => g.Count());
            int totalSum = dice.Sum();

            bool hasYahtzee = counts.Any(c => c.Value == 5);
            bool has4K = counts.Any(c => c.Value >= 4);
            bool has3K = counts.Any(c => c.Value >= 3);
            bool hasFH = counts.ContainsValue(3) && counts.ContainsValue(2);

            var distinct = dice.Distinct().OrderBy(d => d).ToList();
            bool hasLS = distinct.Count == 5 && (distinct.Last() - distinct.First() == 4);
            bool hasSS = (distinct.Contains(1) && distinct.Contains(2) && distinct.Contains(3) && distinct.Contains(4)) ||
                         (distinct.Contains(2) && distinct.Contains(3) && distinct.Contains(4) && distinct.Contains(5)) ||
                         (distinct.Contains(3) && distinct.Contains(4) && distinct.Contains(5) && distinct.Contains(6));

            // 1. DE YAHTZEE & YAHTZEE BONUS LOGICA
            if (hasYahtzee)
            {
                int yNum = dice[0];

                if (IsOpen(txtY))
                {
                    SetAdvice(txtY, 50, false);
                    return "🏆 VUL IN BIJ: Yahtzee (50 pt).";
                }
                else if (txtY.Text == "50")
                {
                    // YAHTZEE BONUS ACTIEF (100 pt extra)!
                    TextBox upperBox = GetUpperBox(yNum);

                    // Regel 1: Verplicht in de corresponderende Upper Box als deze vrij is.
                    if (IsOpen(upperBox))
                    {
                        SetAdvice(upperBox, totalSum, true);
                        return $"💯 YAHTZEE BONUS (100pt)! VERPLICHT: Vul in bij de {yNum}'en ({totalSum} pt).";
                    }

                    // Regel 2: Is de Upper Box al vol? JOKER TIJD!
                    if (IsOpen(txtLS)) { SetAdvice(txtLS, 40, true); return "💯 YAHTZEE BONUS (100pt)! JOKER: Vul in bij Lg. Straight (40 pt)."; }
                    if (IsOpen(txtSS)) { SetAdvice(txtSS, 30, true); return "💯 YAHTZEE BONUS (100pt)! JOKER: Vul in bij Sm. Straight (30 pt)."; }
                    if (IsOpen(txtFH)) { SetAdvice(txtFH, 25, true); return "💯 YAHTZEE BONUS (100pt)! JOKER: Vul in bij Full House (25 pt)."; }
                    if (IsOpen(txt4K)) { SetAdvice(txt4K, totalSum, true); return $"💯 YAHTZEE BONUS (100pt)! JOKER: Vul in bij 4 of a Kind ({totalSum} pt)."; }
                    if (IsOpen(txt3K)) { SetAdvice(txt3K, totalSum, true); return $"💯 YAHTZEE BONUS (100pt)! JOKER: Vul in bij 3 of a Kind ({totalSum} pt)."; }
                    if (IsOpen(txtC)) { SetAdvice(txtC, totalSum, true); return $"💯 YAHTZEE BONUS (100pt)! JOKER: Vul in bij Chance ({totalSum} pt)."; }

                    // Alles vol? Dan val je door naar de Kras/Opgeven logica onderaan, maar je krijgt de 100 punten wel als je de beurt vastlegt.
                }
            }

            // 2. NORMALE SCORES
            if (hasLS && IsOpen(txtLS)) { SetAdvice(txtLS, 40, false); return "📏 VUL IN BIJ: Large Straight (40 pt)."; }
            if (hasSS && IsOpen(txtSS)) { SetAdvice(txtSS, 30, false); return "📏 VUL IN BIJ: Small Straight (30 pt)."; }
            if (hasFH && IsOpen(txtFH)) { SetAdvice(txtFH, 25, false); return "🏠 VUL IN BIJ: Full House (25 pt)."; }

            foreach (var num in new[] { 6, 5, 4, 3, 2, 1 })
            {
                if (counts.ContainsKey(num) && counts[num] >= 3 && IsOpen(GetUpperBox(num)))
                {
                    SetAdvice(GetUpperBox(num), counts[num] * num, false);
                    return $"🔥 VUL IN BIJ: {num}'en ({counts[num] * num} pt).";
                }
            }

            if (has4K && IsOpen(txt4K)) { SetAdvice(txt4K, totalSum, false); return "🎲 VUL IN BIJ: 4 of a Kind."; }
            if (has3K && IsOpen(txt3K)) { SetAdvice(txt3K, totalSum, false); return "🎲 VUL IN BIJ: 3 of a Kind."; }

            // 3. KRAS EN OVERLEVING
            if (IsOpen(txt1)) { SetAdvice(txt1, counts.ContainsKey(1) ? counts[1] : 0, false); return "❌ OPGEVEN: Streep de 1'en weg (Kras/Laag)."; }
            if (IsOpen(txt2)) { SetAdvice(txt2, counts.ContainsKey(2) ? counts[2] * 2 : 0, false); return "❌ OPGEVEN: Streep de 2'en weg."; }
            if (IsOpen(txtC)) { SetAdvice(txtC, totalSum, false); return $"♻️ VUL IN BIJ: Chance ({totalSum} pt)."; }
            if (IsOpen(txt3)) { SetAdvice(txt3, counts.ContainsKey(3) ? counts[3] * 3 : 0, false); return "❌ OPGEVEN: Streep de 3'en weg."; }
            if (IsOpen(txt4)) { SetAdvice(txt4, counts.ContainsKey(4) ? counts[4] * 4 : 0, false); return "❌ OPGEVEN: Streep de 4'en weg."; }
            if (IsOpen(txtFH)) { SetAdvice(txtFH, 0, false); return "❌ KRAS: Full House (0 pt)."; }
            if (IsOpen(txtY)) { SetAdvice(txtY, 0, false); return "❌ KRAS: Yahtzee (0 pt)."; }

            return "Je moet handmatig een resterend vakje kiezen.";
        }

        private void SetAdvice(TextBox targetBox, int score, bool isBonus = false)
        {
            targetBoxToFill = targetBox;
            valueToFill = score;
            isYahtzeeBonusAdvice = isBonus;
        }
    }
}