
namespace MaciejLendzionLab1ZadDom
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonAddWorm = new System.Windows.Forms.Button();
            this.buttonAddHook = new System.Windows.Forms.Button();
            this.buttonAddLine = new System.Windows.Forms.Button();
            this.buttonAddNet = new System.Windows.Forms.Button();
            this.buttonAddBait = new System.Windows.Forms.Button();
            this.labelOwnedMoney = new System.Windows.Forms.Label();
            this.labelWormUpgradeCost = new System.Windows.Forms.Label();
            this.labelHookUpgradeCost = new System.Windows.Forms.Label();
            this.labelLineUpgradeCost = new System.Windows.Forms.Label();
            this.labelNetUpgradeCost = new System.Windows.Forms.Label();
            this.labelBaitUpgradeCost = new System.Windows.Forms.Label();
            this.buttonWormUpgrade = new System.Windows.Forms.Button();
            this.buttonHookUpgrade = new System.Windows.Forms.Button();
            this.buttonLineUpgrade = new System.Windows.Forms.Button();
            this.buttonNetUpgrade = new System.Windows.Forms.Button();
            this.buttonBaitUpgrade = new System.Windows.Forms.Button();
            this.buttonCastFishingRod = new System.Windows.Forms.Button();
            this.buttonUseBait = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelWormNumber = new System.Windows.Forms.Label();
            this.labelHookNumber = new System.Windows.Forms.Label();
            this.labelLineNumber = new System.Windows.Forms.Label();
            this.labelNetNumber = new System.Windows.Forms.Label();
            this.labelBaitNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddWorm
            // 
            this.buttonAddWorm.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddWorm.FlatAppearance.BorderSize = 0;
            this.buttonAddWorm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddWorm.Location = new System.Drawing.Point(306, 12);
            this.buttonAddWorm.Name = "buttonAddWorm";
            this.buttonAddWorm.Size = new System.Drawing.Size(36, 35);
            this.buttonAddWorm.TabIndex = 0;
            this.buttonAddWorm.UseVisualStyleBackColor = false;
            this.buttonAddWorm.Click += new System.EventHandler(this.buttonAddWorm_Click);
            // 
            // buttonAddHook
            // 
            this.buttonAddHook.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddHook.FlatAppearance.BorderSize = 0;
            this.buttonAddHook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddHook.Location = new System.Drawing.Point(451, 12);
            this.buttonAddHook.Name = "buttonAddHook";
            this.buttonAddHook.Size = new System.Drawing.Size(36, 35);
            this.buttonAddHook.TabIndex = 1;
            this.buttonAddHook.UseVisualStyleBackColor = false;
            this.buttonAddHook.Click += new System.EventHandler(this.buttonAddHook_Click);
            // 
            // buttonAddLine
            // 
            this.buttonAddLine.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddLine.FlatAppearance.BorderSize = 0;
            this.buttonAddLine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddLine.Location = new System.Drawing.Point(592, 12);
            this.buttonAddLine.Name = "buttonAddLine";
            this.buttonAddLine.Size = new System.Drawing.Size(36, 35);
            this.buttonAddLine.TabIndex = 2;
            this.buttonAddLine.UseVisualStyleBackColor = false;
            this.buttonAddLine.Click += new System.EventHandler(this.buttonAddLine_Click);
            // 
            // buttonAddNet
            // 
            this.buttonAddNet.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddNet.FlatAppearance.BorderSize = 0;
            this.buttonAddNet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddNet.Location = new System.Drawing.Point(735, 12);
            this.buttonAddNet.Name = "buttonAddNet";
            this.buttonAddNet.Size = new System.Drawing.Size(36, 35);
            this.buttonAddNet.TabIndex = 3;
            this.buttonAddNet.UseVisualStyleBackColor = false;
            this.buttonAddNet.Click += new System.EventHandler(this.buttonAddNet_Click);
            // 
            // buttonAddBait
            // 
            this.buttonAddBait.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddBait.FlatAppearance.BorderSize = 0;
            this.buttonAddBait.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddBait.Location = new System.Drawing.Point(885, 12);
            this.buttonAddBait.Name = "buttonAddBait";
            this.buttonAddBait.Size = new System.Drawing.Size(36, 35);
            this.buttonAddBait.TabIndex = 4;
            this.buttonAddBait.UseVisualStyleBackColor = false;
            this.buttonAddBait.Click += new System.EventHandler(this.buttonAddBait_Click);
            // 
            // labelOwnedMoney
            // 
            this.labelOwnedMoney.AutoSize = true;
            this.labelOwnedMoney.BackColor = System.Drawing.Color.Transparent;
            this.labelOwnedMoney.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOwnedMoney.Location = new System.Drawing.Point(29, 45);
            this.labelOwnedMoney.Name = "labelOwnedMoney";
            this.labelOwnedMoney.Size = new System.Drawing.Size(112, 39);
            this.labelOwnedMoney.TabIndex = 5;
            this.labelOwnedMoney.Text = "00000";
            // 
            // labelWormUpgradeCost
            // 
            this.labelWormUpgradeCost.AutoSize = true;
            this.labelWormUpgradeCost.BackColor = System.Drawing.Color.Transparent;
            this.labelWormUpgradeCost.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWormUpgradeCost.Location = new System.Drawing.Point(65, 146);
            this.labelWormUpgradeCost.Name = "labelWormUpgradeCost";
            this.labelWormUpgradeCost.Size = new System.Drawing.Size(95, 34);
            this.labelWormUpgradeCost.TabIndex = 6;
            this.labelWormUpgradeCost.Text = "00000";
            // 
            // labelHookUpgradeCost
            // 
            this.labelHookUpgradeCost.AutoSize = true;
            this.labelHookUpgradeCost.BackColor = System.Drawing.Color.Transparent;
            this.labelHookUpgradeCost.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHookUpgradeCost.Location = new System.Drawing.Point(65, 215);
            this.labelHookUpgradeCost.Name = "labelHookUpgradeCost";
            this.labelHookUpgradeCost.Size = new System.Drawing.Size(95, 34);
            this.labelHookUpgradeCost.TabIndex = 7;
            this.labelHookUpgradeCost.Text = "00000";
            // 
            // labelLineUpgradeCost
            // 
            this.labelLineUpgradeCost.AutoSize = true;
            this.labelLineUpgradeCost.BackColor = System.Drawing.Color.Transparent;
            this.labelLineUpgradeCost.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLineUpgradeCost.Location = new System.Drawing.Point(65, 282);
            this.labelLineUpgradeCost.Name = "labelLineUpgradeCost";
            this.labelLineUpgradeCost.Size = new System.Drawing.Size(95, 34);
            this.labelLineUpgradeCost.TabIndex = 8;
            this.labelLineUpgradeCost.Text = "00000";
            // 
            // labelNetUpgradeCost
            // 
            this.labelNetUpgradeCost.AutoSize = true;
            this.labelNetUpgradeCost.BackColor = System.Drawing.Color.Transparent;
            this.labelNetUpgradeCost.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNetUpgradeCost.Location = new System.Drawing.Point(65, 347);
            this.labelNetUpgradeCost.Name = "labelNetUpgradeCost";
            this.labelNetUpgradeCost.Size = new System.Drawing.Size(95, 34);
            this.labelNetUpgradeCost.TabIndex = 9;
            this.labelNetUpgradeCost.Text = "00000";
            // 
            // labelBaitUpgradeCost
            // 
            this.labelBaitUpgradeCost.AutoSize = true;
            this.labelBaitUpgradeCost.BackColor = System.Drawing.Color.Transparent;
            this.labelBaitUpgradeCost.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaitUpgradeCost.Location = new System.Drawing.Point(65, 413);
            this.labelBaitUpgradeCost.Name = "labelBaitUpgradeCost";
            this.labelBaitUpgradeCost.Size = new System.Drawing.Size(95, 34);
            this.labelBaitUpgradeCost.TabIndex = 10;
            this.labelBaitUpgradeCost.Text = "00000";
            // 
            // buttonWormUpgrade
            // 
            this.buttonWormUpgrade.BackColor = System.Drawing.Color.White;
            this.buttonWormUpgrade.BackgroundImage = global::MaciejLendzionLab1ZadDom.Properties.Resources.worm_upgrades;
            this.buttonWormUpgrade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonWormUpgrade.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWormUpgrade.Location = new System.Drawing.Point(4, 139);
            this.buttonWormUpgrade.Name = "buttonWormUpgrade";
            this.buttonWormUpgrade.Size = new System.Drawing.Size(55, 54);
            this.buttonWormUpgrade.TabIndex = 11;
            this.buttonWormUpgrade.Text = "1";
            this.buttonWormUpgrade.UseVisualStyleBackColor = false;
            this.buttonWormUpgrade.Click += new System.EventHandler(this.buttonWormUpgrade_Click);
            // 
            // buttonHookUpgrade
            // 
            this.buttonHookUpgrade.BackgroundImage = global::MaciejLendzionLab1ZadDom.Properties.Resources.hook_upgrade;
            this.buttonHookUpgrade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHookUpgrade.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHookUpgrade.Location = new System.Drawing.Point(4, 208);
            this.buttonHookUpgrade.Name = "buttonHookUpgrade";
            this.buttonHookUpgrade.Size = new System.Drawing.Size(55, 54);
            this.buttonHookUpgrade.TabIndex = 12;
            this.buttonHookUpgrade.Text = "1";
            this.buttonHookUpgrade.UseVisualStyleBackColor = true;
            this.buttonHookUpgrade.Click += new System.EventHandler(this.buttonHookUpgrade_Click);
            // 
            // buttonLineUpgrade
            // 
            this.buttonLineUpgrade.BackgroundImage = global::MaciejLendzionLab1ZadDom.Properties.Resources.line_upgrade;
            this.buttonLineUpgrade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLineUpgrade.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLineUpgrade.Location = new System.Drawing.Point(4, 275);
            this.buttonLineUpgrade.Name = "buttonLineUpgrade";
            this.buttonLineUpgrade.Size = new System.Drawing.Size(55, 54);
            this.buttonLineUpgrade.TabIndex = 13;
            this.buttonLineUpgrade.Text = "1";
            this.buttonLineUpgrade.UseVisualStyleBackColor = true;
            this.buttonLineUpgrade.Click += new System.EventHandler(this.buttonLineUpgrade_Click);
            // 
            // buttonNetUpgrade
            // 
            this.buttonNetUpgrade.BackgroundImage = global::MaciejLendzionLab1ZadDom.Properties.Resources.net_upgrade;
            this.buttonNetUpgrade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNetUpgrade.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNetUpgrade.Location = new System.Drawing.Point(4, 343);
            this.buttonNetUpgrade.Name = "buttonNetUpgrade";
            this.buttonNetUpgrade.Size = new System.Drawing.Size(55, 54);
            this.buttonNetUpgrade.TabIndex = 14;
            this.buttonNetUpgrade.Text = "1";
            this.buttonNetUpgrade.UseVisualStyleBackColor = true;
            this.buttonNetUpgrade.Click += new System.EventHandler(this.buttonNetUpgrade_Click);
            // 
            // buttonBaitUpgrade
            // 
            this.buttonBaitUpgrade.BackgroundImage = global::MaciejLendzionLab1ZadDom.Properties.Resources.bait_upgrade;
            this.buttonBaitUpgrade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBaitUpgrade.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBaitUpgrade.Location = new System.Drawing.Point(4, 406);
            this.buttonBaitUpgrade.Name = "buttonBaitUpgrade";
            this.buttonBaitUpgrade.Size = new System.Drawing.Size(55, 54);
            this.buttonBaitUpgrade.TabIndex = 15;
            this.buttonBaitUpgrade.Text = "1";
            this.buttonBaitUpgrade.UseVisualStyleBackColor = true;
            this.buttonBaitUpgrade.Click += new System.EventHandler(this.buttonBaitUpgrade_Click);
            // 
            // buttonCastFishingRod
            // 
            this.buttonCastFishingRod.BackgroundImage = global::MaciejLendzionLab1ZadDom.Properties.Resources.button_but;
            this.buttonCastFishingRod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCastFishingRod.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCastFishingRod.Location = new System.Drawing.Point(36, 469);
            this.buttonCastFishingRod.Name = "buttonCastFishingRod";
            this.buttonCastFishingRod.Size = new System.Drawing.Size(136, 43);
            this.buttonCastFishingRod.TabIndex = 16;
            this.buttonCastFishingRod.Text = "Zarzuć wędkę";
            this.buttonCastFishingRod.UseVisualStyleBackColor = true;
            this.buttonCastFishingRod.Click += new System.EventHandler(this.buttonCastFishingRod_Click);
            // 
            // buttonUseBait
            // 
            this.buttonUseBait.BackgroundImage = global::MaciejLendzionLab1ZadDom.Properties.Resources.button_but;
            this.buttonUseBait.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUseBait.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUseBait.Location = new System.Drawing.Point(36, 518);
            this.buttonUseBait.Name = "buttonUseBait";
            this.buttonUseBait.Size = new System.Drawing.Size(136, 43);
            this.buttonUseBait.TabIndex = 17;
            this.buttonUseBait.Text = "Użyj zanęty";
            this.buttonUseBait.UseVisualStyleBackColor = true;
            this.buttonUseBait.Click += new System.EventHandler(this.buttonUseBait_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelWormNumber
            // 
            this.labelWormNumber.AutoSize = true;
            this.labelWormNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelWormNumber.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWormNumber.Location = new System.Drawing.Point(254, 17);
            this.labelWormNumber.Name = "labelWormNumber";
            this.labelWormNumber.Size = new System.Drawing.Size(46, 23);
            this.labelWormNumber.TabIndex = 18;
            this.labelWormNumber.Text = "000";
            // 
            // labelHookNumber
            // 
            this.labelHookNumber.AutoSize = true;
            this.labelHookNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelHookNumber.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHookNumber.Location = new System.Drawing.Point(399, 17);
            this.labelHookNumber.Name = "labelHookNumber";
            this.labelHookNumber.Size = new System.Drawing.Size(46, 23);
            this.labelHookNumber.TabIndex = 19;
            this.labelHookNumber.Text = "000";
            // 
            // labelLineNumber
            // 
            this.labelLineNumber.AutoSize = true;
            this.labelLineNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelLineNumber.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLineNumber.Location = new System.Drawing.Point(540, 17);
            this.labelLineNumber.Name = "labelLineNumber";
            this.labelLineNumber.Size = new System.Drawing.Size(46, 23);
            this.labelLineNumber.TabIndex = 20;
            this.labelLineNumber.Text = "000";
            // 
            // labelNetNumber
            // 
            this.labelNetNumber.AutoSize = true;
            this.labelNetNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelNetNumber.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNetNumber.Location = new System.Drawing.Point(683, 17);
            this.labelNetNumber.Name = "labelNetNumber";
            this.labelNetNumber.Size = new System.Drawing.Size(46, 23);
            this.labelNetNumber.TabIndex = 21;
            this.labelNetNumber.Text = "000";
            // 
            // labelBaitNumber
            // 
            this.labelBaitNumber.AutoSize = true;
            this.labelBaitNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelBaitNumber.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaitNumber.Location = new System.Drawing.Point(833, 17);
            this.labelBaitNumber.Name = "labelBaitNumber";
            this.labelBaitNumber.Size = new System.Drawing.Size(46, 23);
            this.labelBaitNumber.TabIndex = 22;
            this.labelBaitNumber.Text = "000";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(958, 594);
            this.Controls.Add(this.labelBaitNumber);
            this.Controls.Add(this.labelNetNumber);
            this.Controls.Add(this.labelLineNumber);
            this.Controls.Add(this.labelHookNumber);
            this.Controls.Add(this.labelWormNumber);
            this.Controls.Add(this.buttonUseBait);
            this.Controls.Add(this.buttonCastFishingRod);
            this.Controls.Add(this.buttonBaitUpgrade);
            this.Controls.Add(this.buttonNetUpgrade);
            this.Controls.Add(this.buttonLineUpgrade);
            this.Controls.Add(this.buttonHookUpgrade);
            this.Controls.Add(this.buttonWormUpgrade);
            this.Controls.Add(this.labelBaitUpgradeCost);
            this.Controls.Add(this.labelNetUpgradeCost);
            this.Controls.Add(this.labelLineUpgradeCost);
            this.Controls.Add(this.labelHookUpgradeCost);
            this.Controls.Add(this.labelWormUpgradeCost);
            this.Controls.Add(this.labelOwnedMoney);
            this.Controls.Add(this.buttonAddBait);
            this.Controls.Add(this.buttonAddNet);
            this.Controls.Add(this.buttonAddLine);
            this.Controls.Add(this.buttonAddHook);
            this.Controls.Add(this.buttonAddWorm);
            this.Name = "FormMain";
            this.Text = "Fanatyk wędkarstwa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonAddHook;
        private System.Windows.Forms.Button buttonAddLine;
        private System.Windows.Forms.Button buttonAddNet;
        private System.Windows.Forms.Button buttonAddBait;
        private System.Windows.Forms.Label labelOwnedMoney;
        private System.Windows.Forms.Label labelWormUpgradeCost;
        private System.Windows.Forms.Label labelHookUpgradeCost;
        private System.Windows.Forms.Label labelLineUpgradeCost;
        private System.Windows.Forms.Label labelNetUpgradeCost;
        private System.Windows.Forms.Label labelBaitUpgradeCost;
        private System.Windows.Forms.Button buttonWormUpgrade;
        private System.Windows.Forms.Button buttonHookUpgrade;
        private System.Windows.Forms.Button buttonLineUpgrade;
        private System.Windows.Forms.Button buttonNetUpgrade;
        private System.Windows.Forms.Button buttonBaitUpgrade;
        private System.Windows.Forms.Button buttonCastFishingRod;
        private System.Windows.Forms.Button buttonUseBait;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelWormNumber;
        private System.Windows.Forms.Label labelHookNumber;
        private System.Windows.Forms.Label labelLineNumber;
        private System.Windows.Forms.Label labelNetNumber;
        private System.Windows.Forms.Label labelBaitNumber;
        private System.Windows.Forms.Button buttonAddWorm;
    }
}

