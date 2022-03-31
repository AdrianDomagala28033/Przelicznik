
namespace ProjektPrzelicznik
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Rodzaj = new System.Windows.Forms.Label();
            this.jednostkaZrodlowa = new System.Windows.Forms.Label();
            this.jednostkaDocelowa = new System.Windows.Forms.Label();
            this.wartosc = new System.Windows.Forms.Label();
            this.wynik = new System.Windows.Forms.Label();
            this.rodzajPrzeliczniki = new System.Windows.Forms.ComboBox();
            this.jednostkaWejsciowa = new System.Windows.Forms.ComboBox();
            this.jednostkaWyjsciowa = new System.Windows.Forms.ComboBox();
            this.przelicz = new System.Windows.Forms.Button();
            this.wynikLabel = new System.Windows.Forms.Label();
            this.numericWartosc = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericWartosc)).BeginInit();
            this.SuspendLayout();
            // 
            // Rodzaj
            // 
            this.Rodzaj.AutoSize = true;
            this.Rodzaj.Location = new System.Drawing.Point(14, 17);
            this.Rodzaj.Name = "Rodzaj";
            this.Rodzaj.Size = new System.Drawing.Size(42, 15);
            this.Rodzaj.TabIndex = 0;
            this.Rodzaj.Text = "Rodzaj";
            // 
            // jednostkaZrodlowa
            // 
            this.jednostkaZrodlowa.AutoSize = true;
            this.jednostkaZrodlowa.Location = new System.Drawing.Point(14, 81);
            this.jednostkaZrodlowa.Name = "jednostkaZrodlowa";
            this.jednostkaZrodlowa.Size = new System.Drawing.Size(110, 15);
            this.jednostkaZrodlowa.TabIndex = 1;
            this.jednostkaZrodlowa.Text = "Jednostka źródłowa";
            // 
            // jednostkaDocelowa
            // 
            this.jednostkaDocelowa.AutoSize = true;
            this.jednostkaDocelowa.Location = new System.Drawing.Point(14, 153);
            this.jednostkaDocelowa.Name = "jednostkaDocelowa";
            this.jednostkaDocelowa.Size = new System.Drawing.Size(113, 15);
            this.jednostkaDocelowa.TabIndex = 2;
            this.jednostkaDocelowa.Text = "Jednostka docelowa";
            // 
            // wartosc
            // 
            this.wartosc.AutoSize = true;
            this.wartosc.Location = new System.Drawing.Point(14, 222);
            this.wartosc.Name = "wartosc";
            this.wartosc.Size = new System.Drawing.Size(50, 15);
            this.wartosc.TabIndex = 3;
            this.wartosc.Text = "Wartość";
            // 
            // wynik
            // 
            this.wynik.AutoSize = true;
            this.wynik.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wynik.Location = new System.Drawing.Point(395, 99);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(78, 30);
            this.wynik.TabIndex = 4;
            this.wynik.Text = "Wynik:";
            // 
            // rodzajPrzeliczniki
            // 
            this.rodzajPrzeliczniki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rodzajPrzeliczniki.FormattingEnabled = true;
            this.rodzajPrzeliczniki.Location = new System.Drawing.Point(14, 35);
            this.rodzajPrzeliczniki.Name = "rodzajPrzeliczniki";
            this.rodzajPrzeliczniki.Size = new System.Drawing.Size(333, 23);
            this.rodzajPrzeliczniki.TabIndex = 5;
            this.rodzajPrzeliczniki.SelectedIndexChanged += new System.EventHandler(this.rodzajPrzeliczniki_SelectedIndexChanged);
            // 
            // jednostkaWejsciowa
            // 
            this.jednostkaWejsciowa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jednostkaWejsciowa.FormattingEnabled = true;
            this.jednostkaWejsciowa.Location = new System.Drawing.Point(14, 99);
            this.jednostkaWejsciowa.Name = "jednostkaWejsciowa";
            this.jednostkaWejsciowa.Size = new System.Drawing.Size(333, 23);
            this.jednostkaWejsciowa.TabIndex = 6;
            // 
            // jednostkaWyjsciowa
            // 
            this.jednostkaWyjsciowa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jednostkaWyjsciowa.FormattingEnabled = true;
            this.jednostkaWyjsciowa.Location = new System.Drawing.Point(14, 171);
            this.jednostkaWyjsciowa.Name = "jednostkaWyjsciowa";
            this.jednostkaWyjsciowa.Size = new System.Drawing.Size(333, 23);
            this.jednostkaWyjsciowa.TabIndex = 7;
            // 
            // przelicz
            // 
            this.przelicz.Location = new System.Drawing.Point(14, 302);
            this.przelicz.Name = "przelicz";
            this.przelicz.Size = new System.Drawing.Size(331, 69);
            this.przelicz.TabIndex = 10;
            this.przelicz.Text = "Przelicz";
            this.przelicz.UseVisualStyleBackColor = true;
            this.przelicz.Click += new System.EventHandler(this.przelicz_Click);
            // 
            // wynikLabel
            // 
            this.wynikLabel.AutoSize = true;
            this.wynikLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wynikLabel.Location = new System.Drawing.Point(483, 171);
            this.wynikLabel.Name = "wynikLabel";
            this.wynikLabel.Size = new System.Drawing.Size(78, 45);
            this.wynikLabel.TabIndex = 12;
            this.wynikLabel.Text = "0,00";
            // 
            // numericWartosc
            // 
            this.numericWartosc.Location = new System.Drawing.Point(14, 240);
            this.numericWartosc.Name = "numericWartosc";
            this.numericWartosc.Size = new System.Drawing.Size(333, 23);
            this.numericWartosc.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericWartosc);
            this.Controls.Add(this.wynikLabel);
            this.Controls.Add(this.przelicz);
            this.Controls.Add(this.jednostkaWyjsciowa);
            this.Controls.Add(this.jednostkaWejsciowa);
            this.Controls.Add(this.rodzajPrzeliczniki);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.wartosc);
            this.Controls.Add(this.jednostkaDocelowa);
            this.Controls.Add(this.jednostkaZrodlowa);
            this.Controls.Add(this.Rodzaj);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericWartosc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Rodzaj;
        private System.Windows.Forms.Label jednostkaZrodlowa;
        private System.Windows.Forms.Label jednostkaDocelowa;
        private System.Windows.Forms.Label wartosc;
        private System.Windows.Forms.Label wynik;
        private System.Windows.Forms.ComboBox rodzajPrzeliczniki;
        private System.Windows.Forms.ComboBox jednostkaWejsciowa;
        private System.Windows.Forms.ComboBox jednostkaWyjsciowa;
        private System.Windows.Forms.Button przelicz;
        private System.Windows.Forms.Label wynikLabel;
        private System.Windows.Forms.NumericUpDown numericWartosc;
    }
}

