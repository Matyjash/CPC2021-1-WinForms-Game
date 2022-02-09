
namespace MaciejLendzionLab1ZadDom
{
    partial class FormInfoWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfoWindow));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonSell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe Script", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(144, 34);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(206, 57);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Udało się!";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfo.Location = new System.Drawing.Point(29, 91);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(156, 30);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "Złapałeś rybę!";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.BackColor = System.Drawing.Color.Transparent;
            this.labelType.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelType.Location = new System.Drawing.Point(29, 121);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(91, 25);
            this.labelType.TabIndex = 2;
            this.labelType.Text = "Gatunek:";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.BackColor = System.Drawing.Color.Transparent;
            this.labelWeight.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWeight.Location = new System.Drawing.Point(29, 146);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(61, 25);
            this.labelWeight.TabIndex = 3;
            this.labelWeight.Text = "Waga:";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.BackColor = System.Drawing.Color.Transparent;
            this.labelSize.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSize.Location = new System.Drawing.Point(29, 171);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(93, 25);
            this.labelSize.TabIndex = 4;
            this.labelSize.Text = "Rozmiar:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelPrice.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrice.Location = new System.Drawing.Point(29, 196);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(59, 25);
            this.labelPrice.TabIndex = 5;
            this.labelPrice.Text = "Cena:";
            // 
            // buttonSell
            // 
            this.buttonSell.BackColor = System.Drawing.Color.Transparent;
            this.buttonSell.FlatAppearance.BorderSize = 5;
            this.buttonSell.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSell.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSell.Location = new System.Drawing.Point(264, 171);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(117, 42);
            this.buttonSell.TabIndex = 6;
            this.buttonSell.Text = "Sprzedaj";
            this.buttonSell.UseVisualStyleBackColor = false;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // FormInfoWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(411, 243);
            this.Controls.Add(this.buttonSell);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormInfoWindow";
            this.Text = "Nowa zdobycz!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonSell;
    }
}