using System.Drawing;
using System.Windows.Forms;

namespace Sudoku
{
    partial class GameField
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.ntb33 = new SingleDigitCenteredTextBox();
            this.ntb32 = new SingleDigitCenteredTextBox();
            this.ntb31 = new SingleDigitCenteredTextBox();
            this.ntb23 = new SingleDigitCenteredTextBox();
            this.ntb22 = new SingleDigitCenteredTextBox();
            this.ntb21 = new SingleDigitCenteredTextBox();
            this.ntb13 = new SingleDigitCenteredTextBox();
            this.ntb12 = new SingleDigitCenteredTextBox();
            this.ntb11 = new SingleDigitCenteredTextBox();
            this.numericTextBox1 = new SingleDigitCenteredTextBox();
            this.numericTextBox2 = new SingleDigitCenteredTextBox();
            this.numericTextBox3 = new SingleDigitCenteredTextBox();
            this.numericTextBox4 = new SingleDigitCenteredTextBox();
            this.numericTextBox5 = new SingleDigitCenteredTextBox();
            this.numericTextBox6 = new SingleDigitCenteredTextBox();
            this.numericTextBox7 = new SingleDigitCenteredTextBox();
            this.numericTextBox8 = new SingleDigitCenteredTextBox();
            this.numericTextBox9 = new SingleDigitCenteredTextBox();
            this.numericTextBox10 = new SingleDigitCenteredTextBox();
            this.numericTextBox11 = new SingleDigitCenteredTextBox();
            this.numericTextBox12 = new SingleDigitCenteredTextBox();
            this.numericTextBox13 = new SingleDigitCenteredTextBox();
            this.numericTextBox14 = new SingleDigitCenteredTextBox();
            this.numericTextBox15 = new SingleDigitCenteredTextBox();
            this.numericTextBox16 = new SingleDigitCenteredTextBox();
            this.numericTextBox17 = new SingleDigitCenteredTextBox();
            this.numericTextBox18 = new SingleDigitCenteredTextBox();
            this.numericTextBox19 = new SingleDigitCenteredTextBox();
            this.numericTextBox20 = new SingleDigitCenteredTextBox();
            this.numericTextBox21 = new SingleDigitCenteredTextBox();
            this.numericTextBox22 = new SingleDigitCenteredTextBox();
            this.numericTextBox23 = new SingleDigitCenteredTextBox();
            this.numericTextBox24 = new SingleDigitCenteredTextBox();
            this.numericTextBox25 = new SingleDigitCenteredTextBox();
            this.numericTextBox26 = new SingleDigitCenteredTextBox();
            this.numericTextBox27 = new SingleDigitCenteredTextBox();
            this.numericTextBox28 = new SingleDigitCenteredTextBox();
            this.numericTextBox29 = new SingleDigitCenteredTextBox();
            this.numericTextBox30 = new SingleDigitCenteredTextBox();
            this.numericTextBox31 = new SingleDigitCenteredTextBox();
            this.numericTextBox32 = new SingleDigitCenteredTextBox();
            this.numericTextBox33 = new SingleDigitCenteredTextBox();
            this.numericTextBox34 = new SingleDigitCenteredTextBox();
            this.numericTextBox35 = new SingleDigitCenteredTextBox();
            this.numericTextBox36 = new SingleDigitCenteredTextBox();
            this.numericTextBox37 = new SingleDigitCenteredTextBox();
            this.numericTextBox38 = new SingleDigitCenteredTextBox();
            this.numericTextBox39 = new SingleDigitCenteredTextBox();
            this.numericTextBox40 = new SingleDigitCenteredTextBox();
            this.numericTextBox41 = new SingleDigitCenteredTextBox();
            this.numericTextBox42 = new SingleDigitCenteredTextBox();
            this.numericTextBox43 = new SingleDigitCenteredTextBox();
            this.numericTextBox44 = new SingleDigitCenteredTextBox();
            this.numericTextBox45 = new SingleDigitCenteredTextBox();
            this.numericTextBox46 = new SingleDigitCenteredTextBox();
            this.numericTextBox47 = new SingleDigitCenteredTextBox();
            this.numericTextBox48 = new SingleDigitCenteredTextBox();
            this.numericTextBox49 = new SingleDigitCenteredTextBox();
            this.numericTextBox50 = new SingleDigitCenteredTextBox();
            this.numericTextBox51 = new SingleDigitCenteredTextBox();
            this.numericTextBox52 = new SingleDigitCenteredTextBox();
            this.numericTextBox53 = new SingleDigitCenteredTextBox();
            this.numericTextBox54 = new SingleDigitCenteredTextBox();
            this.numericTextBox55 = new SingleDigitCenteredTextBox();
            this.numericTextBox56 = new SingleDigitCenteredTextBox();
            this.numericTextBox57 = new SingleDigitCenteredTextBox();
            this.numericTextBox58 = new SingleDigitCenteredTextBox();
            this.numericTextBox59 = new SingleDigitCenteredTextBox();
            this.numericTextBox60 = new SingleDigitCenteredTextBox();
            this.numericTextBox61 = new SingleDigitCenteredTextBox();
            this.numericTextBox62 = new SingleDigitCenteredTextBox();
            this.numericTextBox63 = new SingleDigitCenteredTextBox();
            this.numericTextBox64 = new SingleDigitCenteredTextBox();
            this.numericTextBox65 = new SingleDigitCenteredTextBox();
            this.numericTextBox66 = new SingleDigitCenteredTextBox();
            this.numericTextBox67 = new SingleDigitCenteredTextBox();
            this.numericTextBox68 = new SingleDigitCenteredTextBox();
            this.numericTextBox69 = new SingleDigitCenteredTextBox();
            this.numericTextBox70 = new SingleDigitCenteredTextBox();
            this.numericTextBox71 = new SingleDigitCenteredTextBox();
            this.numericTextBox72 = new SingleDigitCenteredTextBox();
            this.SuspendLayout();
            // 
            // ntb33
            // 
            this.ntb33.AllowSpace = false;
            this.ntb33.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntb33.Location = new System.Drawing.Point(84, 84);
            this.ntb33.MaxLength = 1;
            this.ntb33.Multiline = false;
            this.ntb33.Name = "ntb33";
            this.ntb33.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ntb33.Size = new System.Drawing.Size(30, 30);
            this.ntb33.TabIndex = 8;
            this.ntb33.Text = "";
            // 
            // ntb32
            // 
            this.ntb32.AllowSpace = false;
            this.ntb32.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntb32.Location = new System.Drawing.Point(48, 84);
            this.ntb32.MaxLength = 1;
            this.ntb32.Multiline = false;
            this.ntb32.Name = "ntb32";
            this.ntb32.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ntb32.Size = new System.Drawing.Size(30, 30);
            this.ntb32.TabIndex = 7;
            this.ntb32.Text = "";
            // 
            // ntb31
            // 
            this.ntb31.AllowSpace = false;
            this.ntb31.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntb31.Location = new System.Drawing.Point(12, 84);
            this.ntb31.MaxLength = 1;
            this.ntb31.Multiline = false;
            this.ntb31.Name = "ntb31";
            this.ntb31.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ntb31.Size = new System.Drawing.Size(30, 30);
            this.ntb31.TabIndex = 6;
            this.ntb31.Text = "";
            // 
            // ntb23
            // 
            this.ntb23.AllowSpace = false;
            this.ntb23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntb23.Location = new System.Drawing.Point(84, 48);
            this.ntb23.MaxLength = 1;
            this.ntb23.Multiline = false;
            this.ntb23.Name = "ntb23";
            this.ntb23.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ntb23.Size = new System.Drawing.Size(30, 30);
            this.ntb23.TabIndex = 5;
            this.ntb23.Text = "";
            // 
            // ntb22
            // 
            this.ntb22.AllowSpace = false;
            this.ntb22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntb22.Location = new System.Drawing.Point(48, 48);
            this.ntb22.MaxLength = 1;
            this.ntb22.Multiline = false;
            this.ntb22.Name = "ntb22";
            this.ntb22.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ntb22.Size = new System.Drawing.Size(30, 30);
            this.ntb22.TabIndex = 4;
            this.ntb22.Text = "";
            // 
            // ntb21
            // 
            this.ntb21.AllowSpace = false;
            this.ntb21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntb21.Location = new System.Drawing.Point(12, 48);
            this.ntb21.MaxLength = 1;
            this.ntb21.Multiline = false;
            this.ntb21.Name = "ntb21";
            this.ntb21.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ntb21.Size = new System.Drawing.Size(30, 30);
            this.ntb21.TabIndex = 3;
            this.ntb21.Text = "";
            // 
            // ntb13
            // 
            this.ntb13.AllowSpace = false;
            this.ntb13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntb13.Location = new System.Drawing.Point(84, 12);
            this.ntb13.MaxLength = 1;
            this.ntb13.Multiline = false;
            this.ntb13.Name = "ntb13";
            this.ntb13.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ntb13.Size = new System.Drawing.Size(30, 30);
            this.ntb13.TabIndex = 2;
            this.ntb13.Text = "";
            // 
            // ntb12
            // 
            this.ntb12.AllowSpace = false;
            this.ntb12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntb12.Location = new System.Drawing.Point(48, 12);
            this.ntb12.MaxLength = 1;
            this.ntb12.Multiline = false;
            this.ntb12.Name = "ntb12";
            this.ntb12.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ntb12.Size = new System.Drawing.Size(30, 30);
            this.ntb12.TabIndex = 1;
            this.ntb12.Text = "";
            // 
            // ntb11
            // 
            this.ntb11.AllowSpace = false;
            this.ntb11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntb11.Location = new System.Drawing.Point(12, 12);
            this.ntb11.MaxLength = 1;
            this.ntb11.Multiline = false;
            this.ntb11.Name = "ntb11";
            this.ntb11.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ntb11.Size = new System.Drawing.Size(30, 30);
            this.ntb11.TabIndex = 0;
            this.ntb11.Text = "";
            // 
            // numericTextBox1
            // 
            this.numericTextBox1.AllowSpace = false;
            this.numericTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox1.Location = new System.Drawing.Point(84, 200);
            this.numericTextBox1.MaxLength = 1;
            this.numericTextBox1.Multiline = false;
            this.numericTextBox1.Name = "numericTextBox1";
            this.numericTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox1.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox1.TabIndex = 17;
            this.numericTextBox1.Text = "";
            // 
            // numericTextBox2
            // 
            this.numericTextBox2.AllowSpace = false;
            this.numericTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox2.Location = new System.Drawing.Point(48, 200);
            this.numericTextBox2.MaxLength = 1;
            this.numericTextBox2.Multiline = false;
            this.numericTextBox2.Name = "numericTextBox2";
            this.numericTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox2.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox2.TabIndex = 16;
            this.numericTextBox2.Text = "";
            // 
            // numericTextBox3
            // 
            this.numericTextBox3.AllowSpace = false;
            this.numericTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox3.Location = new System.Drawing.Point(12, 200);
            this.numericTextBox3.MaxLength = 1;
            this.numericTextBox3.Multiline = false;
            this.numericTextBox3.Name = "numericTextBox3";
            this.numericTextBox3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox3.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox3.TabIndex = 15;
            this.numericTextBox3.Text = "";
            // 
            // numericTextBox4
            // 
            this.numericTextBox4.AllowSpace = false;
            this.numericTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox4.Location = new System.Drawing.Point(84, 164);
            this.numericTextBox4.MaxLength = 1;
            this.numericTextBox4.Multiline = false;
            this.numericTextBox4.Name = "numericTextBox4";
            this.numericTextBox4.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox4.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox4.TabIndex = 14;
            this.numericTextBox4.Text = "";
            // 
            // numericTextBox5
            // 
            this.numericTextBox5.AllowSpace = false;
            this.numericTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox5.Location = new System.Drawing.Point(48, 164);
            this.numericTextBox5.MaxLength = 1;
            this.numericTextBox5.Multiline = false;
            this.numericTextBox5.Name = "numericTextBox5";
            this.numericTextBox5.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox5.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox5.TabIndex = 13;
            this.numericTextBox5.Text = "";
            // 
            // numericTextBox6
            // 
            this.numericTextBox6.AllowSpace = false;
            this.numericTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox6.Location = new System.Drawing.Point(12, 164);
            this.numericTextBox6.MaxLength = 1;
            this.numericTextBox6.Multiline = false;
            this.numericTextBox6.Name = "numericTextBox6";
            this.numericTextBox6.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox6.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox6.TabIndex = 12;
            this.numericTextBox6.Text = "";
            // 
            // numericTextBox7
            // 
            this.numericTextBox7.AllowSpace = false;
            this.numericTextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox7.Location = new System.Drawing.Point(84, 128);
            this.numericTextBox7.MaxLength = 1;
            this.numericTextBox7.Multiline = false;
            this.numericTextBox7.Name = "numericTextBox7";
            this.numericTextBox7.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox7.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox7.TabIndex = 11;
            this.numericTextBox7.Text = "";
            // 
            // numericTextBox8
            // 
            this.numericTextBox8.AllowSpace = false;
            this.numericTextBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox8.Location = new System.Drawing.Point(48, 128);
            this.numericTextBox8.MaxLength = 1;
            this.numericTextBox8.Multiline = false;
            this.numericTextBox8.Name = "numericTextBox8";
            this.numericTextBox8.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox8.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox8.TabIndex = 10;
            this.numericTextBox8.Text = "";
            // 
            // numericTextBox9
            // 
            this.numericTextBox9.AllowSpace = false;
            this.numericTextBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox9.Location = new System.Drawing.Point(12, 128);
            this.numericTextBox9.MaxLength = 1;
            this.numericTextBox9.Multiline = false;
            this.numericTextBox9.Name = "numericTextBox9";
            this.numericTextBox9.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox9.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox9.TabIndex = 9;
            this.numericTextBox9.Text = "";
            // 
            // numericTextBox10
            // 
            this.numericTextBox10.AllowSpace = false;
            this.numericTextBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox10.Location = new System.Drawing.Point(84, 316);
            this.numericTextBox10.MaxLength = 1;
            this.numericTextBox10.Multiline = false;
            this.numericTextBox10.Name = "numericTextBox10";
            this.numericTextBox10.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox10.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox10.TabIndex = 26;
            this.numericTextBox10.Text = "";
            // 
            // numericTextBox11
            // 
            this.numericTextBox11.AllowSpace = false;
            this.numericTextBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox11.Location = new System.Drawing.Point(48, 316);
            this.numericTextBox11.MaxLength = 1;
            this.numericTextBox11.Multiline = false;
            this.numericTextBox11.Name = "numericTextBox11";
            this.numericTextBox11.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox11.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox11.TabIndex = 25;
            this.numericTextBox11.Text = "";
            // 
            // numericTextBox12
            // 
            this.numericTextBox12.AllowSpace = false;
            this.numericTextBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox12.Location = new System.Drawing.Point(12, 316);
            this.numericTextBox12.MaxLength = 1;
            this.numericTextBox12.Multiline = false;
            this.numericTextBox12.Name = "numericTextBox12";
            this.numericTextBox12.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox12.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox12.TabIndex = 24;
            this.numericTextBox12.Text = "";
            // 
            // numericTextBox13
            // 
            this.numericTextBox13.AllowSpace = false;
            this.numericTextBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox13.Location = new System.Drawing.Point(84, 280);
            this.numericTextBox13.MaxLength = 1;
            this.numericTextBox13.Multiline = false;
            this.numericTextBox13.Name = "numericTextBox13";
            this.numericTextBox13.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox13.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox13.TabIndex = 23;
            this.numericTextBox13.Text = "";
            // 
            // numericTextBox14
            // 
            this.numericTextBox14.AllowSpace = false;
            this.numericTextBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox14.Location = new System.Drawing.Point(48, 280);
            this.numericTextBox14.MaxLength = 1;
            this.numericTextBox14.Multiline = false;
            this.numericTextBox14.Name = "numericTextBox14";
            this.numericTextBox14.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox14.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox14.TabIndex = 22;
            this.numericTextBox14.Text = "";
            // 
            // numericTextBox15
            // 
            this.numericTextBox15.AllowSpace = false;
            this.numericTextBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox15.Location = new System.Drawing.Point(12, 280);
            this.numericTextBox15.MaxLength = 1;
            this.numericTextBox15.Multiline = false;
            this.numericTextBox15.Name = "numericTextBox15";
            this.numericTextBox15.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox15.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox15.TabIndex = 21;
            this.numericTextBox15.Text = "";
            // 
            // numericTextBox16
            // 
            this.numericTextBox16.AllowSpace = false;
            this.numericTextBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox16.Location = new System.Drawing.Point(84, 244);
            this.numericTextBox16.MaxLength = 1;
            this.numericTextBox16.Multiline = false;
            this.numericTextBox16.Name = "numericTextBox16";
            this.numericTextBox16.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox16.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox16.TabIndex = 20;
            this.numericTextBox16.Text = "";
            // 
            // numericTextBox17
            // 
            this.numericTextBox17.AllowSpace = false;
            this.numericTextBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox17.Location = new System.Drawing.Point(48, 244);
            this.numericTextBox17.MaxLength = 1;
            this.numericTextBox17.Multiline = false;
            this.numericTextBox17.Name = "numericTextBox17";
            this.numericTextBox17.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox17.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox17.TabIndex = 19;
            this.numericTextBox17.Text = "";
            // 
            // numericTextBox18
            // 
            this.numericTextBox18.AllowSpace = false;
            this.numericTextBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox18.Location = new System.Drawing.Point(12, 244);
            this.numericTextBox18.MaxLength = 1;
            this.numericTextBox18.Multiline = false;
            this.numericTextBox18.Name = "numericTextBox18";
            this.numericTextBox18.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox18.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox18.TabIndex = 18;
            this.numericTextBox18.Text = "";
            // 
            // numericTextBox19
            // 
            this.numericTextBox19.AllowSpace = false;
            this.numericTextBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox19.Location = new System.Drawing.Point(200, 316);
            this.numericTextBox19.MaxLength = 1;
            this.numericTextBox19.Multiline = false;
            this.numericTextBox19.Name = "numericTextBox19";
            this.numericTextBox19.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox19.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox19.TabIndex = 53;
            this.numericTextBox19.Text = "";
            // 
            // numericTextBox20
            // 
            this.numericTextBox20.AllowSpace = false;
            this.numericTextBox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox20.Location = new System.Drawing.Point(164, 316);
            this.numericTextBox20.MaxLength = 1;
            this.numericTextBox20.Multiline = false;
            this.numericTextBox20.Name = "numericTextBox20";
            this.numericTextBox20.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox20.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox20.TabIndex = 52;
            this.numericTextBox20.Text = "";
            // 
            // numericTextBox21
            // 
            this.numericTextBox21.AllowSpace = false;
            this.numericTextBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox21.Location = new System.Drawing.Point(128, 316);
            this.numericTextBox21.MaxLength = 1;
            this.numericTextBox21.Multiline = false;
            this.numericTextBox21.Name = "numericTextBox21";
            this.numericTextBox21.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox21.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox21.TabIndex = 51;
            this.numericTextBox21.Text = "";
            // 
            // numericTextBox22
            // 
            this.numericTextBox22.AllowSpace = false;
            this.numericTextBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox22.Location = new System.Drawing.Point(200, 280);
            this.numericTextBox22.MaxLength = 1;
            this.numericTextBox22.Multiline = false;
            this.numericTextBox22.Name = "numericTextBox22";
            this.numericTextBox22.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox22.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox22.TabIndex = 50;
            this.numericTextBox22.Text = "";
            // 
            // numericTextBox23
            // 
            this.numericTextBox23.AllowSpace = false;
            this.numericTextBox23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox23.Location = new System.Drawing.Point(164, 280);
            this.numericTextBox23.MaxLength = 1;
            this.numericTextBox23.Multiline = false;
            this.numericTextBox23.Name = "numericTextBox23";
            this.numericTextBox23.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox23.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox23.TabIndex = 49;
            this.numericTextBox23.Text = "";
            // 
            // numericTextBox24
            // 
            this.numericTextBox24.AllowSpace = false;
            this.numericTextBox24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox24.Location = new System.Drawing.Point(128, 280);
            this.numericTextBox24.MaxLength = 1;
            this.numericTextBox24.Multiline = false;
            this.numericTextBox24.Name = "numericTextBox24";
            this.numericTextBox24.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox24.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox24.TabIndex = 48;
            this.numericTextBox24.Text = "";
            // 
            // numericTextBox25
            // 
            this.numericTextBox25.AllowSpace = false;
            this.numericTextBox25.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox25.Location = new System.Drawing.Point(200, 244);
            this.numericTextBox25.MaxLength = 1;
            this.numericTextBox25.Multiline = false;
            this.numericTextBox25.Name = "numericTextBox25";
            this.numericTextBox25.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox25.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox25.TabIndex = 47;
            this.numericTextBox25.Text = "";
            // 
            // numericTextBox26
            // 
            this.numericTextBox26.AllowSpace = false;
            this.numericTextBox26.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox26.Location = new System.Drawing.Point(164, 244);
            this.numericTextBox26.MaxLength = 1;
            this.numericTextBox26.Multiline = false;
            this.numericTextBox26.Name = "numericTextBox26";
            this.numericTextBox26.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox26.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox26.TabIndex = 46;
            this.numericTextBox26.Text = "";
            // 
            // numericTextBox27
            // 
            this.numericTextBox27.AllowSpace = false;
            this.numericTextBox27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox27.Location = new System.Drawing.Point(128, 244);
            this.numericTextBox27.MaxLength = 1;
            this.numericTextBox27.Multiline = false;
            this.numericTextBox27.Name = "numericTextBox27";
            this.numericTextBox27.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox27.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox27.TabIndex = 45;
            this.numericTextBox27.Text = "";
            // 
            // numericTextBox28
            // 
            this.numericTextBox28.AllowSpace = false;
            this.numericTextBox28.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox28.Location = new System.Drawing.Point(200, 200);
            this.numericTextBox28.MaxLength = 1;
            this.numericTextBox28.Multiline = false;
            this.numericTextBox28.Name = "numericTextBox28";
            this.numericTextBox28.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox28.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox28.TabIndex = 44;
            this.numericTextBox28.Text = "";
            // 
            // numericTextBox29
            // 
            this.numericTextBox29.AllowSpace = false;
            this.numericTextBox29.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox29.Location = new System.Drawing.Point(164, 200);
            this.numericTextBox29.MaxLength = 1;
            this.numericTextBox29.Multiline = false;
            this.numericTextBox29.Name = "numericTextBox29";
            this.numericTextBox29.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox29.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox29.TabIndex = 43;
            this.numericTextBox29.Text = "";
            // 
            // numericTextBox30
            // 
            this.numericTextBox30.AllowSpace = false;
            this.numericTextBox30.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox30.Location = new System.Drawing.Point(128, 200);
            this.numericTextBox30.MaxLength = 1;
            this.numericTextBox30.Multiline = false;
            this.numericTextBox30.Name = "numericTextBox30";
            this.numericTextBox30.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox30.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox30.TabIndex = 42;
            this.numericTextBox30.Text = "";
            // 
            // numericTextBox31
            // 
            this.numericTextBox31.AllowSpace = false;
            this.numericTextBox31.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox31.Location = new System.Drawing.Point(200, 164);
            this.numericTextBox31.MaxLength = 1;
            this.numericTextBox31.Multiline = false;
            this.numericTextBox31.Name = "numericTextBox31";
            this.numericTextBox31.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox31.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox31.TabIndex = 41;
            this.numericTextBox31.Text = "";
            // 
            // numericTextBox32
            // 
            this.numericTextBox32.AllowSpace = false;
            this.numericTextBox32.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox32.Location = new System.Drawing.Point(164, 164);
            this.numericTextBox32.MaxLength = 1;
            this.numericTextBox32.Multiline = false;
            this.numericTextBox32.Name = "numericTextBox32";
            this.numericTextBox32.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox32.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox32.TabIndex = 40;
            this.numericTextBox32.Text = "";
            // 
            // numericTextBox33
            // 
            this.numericTextBox33.AllowSpace = false;
            this.numericTextBox33.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox33.Location = new System.Drawing.Point(128, 164);
            this.numericTextBox33.MaxLength = 1;
            this.numericTextBox33.Multiline = false;
            this.numericTextBox33.Name = "numericTextBox33";
            this.numericTextBox33.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox33.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox33.TabIndex = 39;
            this.numericTextBox33.Text = "";
            // 
            // numericTextBox34
            // 
            this.numericTextBox34.AllowSpace = false;
            this.numericTextBox34.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox34.Location = new System.Drawing.Point(200, 128);
            this.numericTextBox34.MaxLength = 1;
            this.numericTextBox34.Multiline = false;
            this.numericTextBox34.Name = "numericTextBox34";
            this.numericTextBox34.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox34.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox34.TabIndex = 38;
            this.numericTextBox34.Text = "";
            // 
            // numericTextBox35
            // 
            this.numericTextBox35.AllowSpace = false;
            this.numericTextBox35.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox35.Location = new System.Drawing.Point(164, 128);
            this.numericTextBox35.MaxLength = 1;
            this.numericTextBox35.Multiline = false;
            this.numericTextBox35.Name = "numericTextBox35";
            this.numericTextBox35.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox35.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox35.TabIndex = 37;
            this.numericTextBox35.Text = "";
            // 
            // numericTextBox36
            // 
            this.numericTextBox36.AllowSpace = false;
            this.numericTextBox36.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox36.Location = new System.Drawing.Point(128, 128);
            this.numericTextBox36.MaxLength = 1;
            this.numericTextBox36.Multiline = false;
            this.numericTextBox36.Name = "numericTextBox36";
            this.numericTextBox36.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox36.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox36.TabIndex = 36;
            this.numericTextBox36.Text = "";
            // 
            // numericTextBox37
            // 
            this.numericTextBox37.AllowSpace = false;
            this.numericTextBox37.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox37.Location = new System.Drawing.Point(200, 84);
            this.numericTextBox37.MaxLength = 1;
            this.numericTextBox37.Multiline = false;
            this.numericTextBox37.Name = "numericTextBox37";
            this.numericTextBox37.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox37.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox37.TabIndex = 35;
            this.numericTextBox37.Text = "";
            // 
            // numericTextBox38
            // 
            this.numericTextBox38.AllowSpace = false;
            this.numericTextBox38.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox38.Location = new System.Drawing.Point(164, 84);
            this.numericTextBox38.MaxLength = 1;
            this.numericTextBox38.Multiline = false;
            this.numericTextBox38.Name = "numericTextBox38";
            this.numericTextBox38.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox38.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox38.TabIndex = 34;
            this.numericTextBox38.Text = "";
            // 
            // numericTextBox39
            // 
            this.numericTextBox39.AllowSpace = false;
            this.numericTextBox39.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox39.Location = new System.Drawing.Point(128, 84);
            this.numericTextBox39.MaxLength = 1;
            this.numericTextBox39.Multiline = false;
            this.numericTextBox39.Name = "numericTextBox39";
            this.numericTextBox39.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox39.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox39.TabIndex = 33;
            this.numericTextBox39.Text = "";
            // 
            // numericTextBox40
            // 
            this.numericTextBox40.AllowSpace = false;
            this.numericTextBox40.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox40.Location = new System.Drawing.Point(200, 48);
            this.numericTextBox40.MaxLength = 1;
            this.numericTextBox40.Multiline = false;
            this.numericTextBox40.Name = "numericTextBox40";
            this.numericTextBox40.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox40.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox40.TabIndex = 32;
            this.numericTextBox40.Text = "";
            // 
            // numericTextBox41
            // 
            this.numericTextBox41.AllowSpace = false;
            this.numericTextBox41.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox41.Location = new System.Drawing.Point(164, 48);
            this.numericTextBox41.MaxLength = 1;
            this.numericTextBox41.Multiline = false;
            this.numericTextBox41.Name = "numericTextBox41";
            this.numericTextBox41.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox41.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox41.TabIndex = 31;
            this.numericTextBox41.Text = "";
            // 
            // numericTextBox42
            // 
            this.numericTextBox42.AllowSpace = false;
            this.numericTextBox42.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox42.Location = new System.Drawing.Point(128, 48);
            this.numericTextBox42.MaxLength = 1;
            this.numericTextBox42.Multiline = false;
            this.numericTextBox42.Name = "numericTextBox42";
            this.numericTextBox42.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox42.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox42.TabIndex = 30;
            this.numericTextBox42.Text = "";
            // 
            // numericTextBox43
            // 
            this.numericTextBox43.AllowSpace = false;
            this.numericTextBox43.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox43.Location = new System.Drawing.Point(200, 12);
            this.numericTextBox43.MaxLength = 1;
            this.numericTextBox43.Multiline = false;
            this.numericTextBox43.Name = "numericTextBox43";
            this.numericTextBox43.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox43.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox43.TabIndex = 29;
            this.numericTextBox43.Text = "";
            // 
            // numericTextBox44
            // 
            this.numericTextBox44.AllowSpace = false;
            this.numericTextBox44.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox44.Location = new System.Drawing.Point(164, 12);
            this.numericTextBox44.MaxLength = 1;
            this.numericTextBox44.Multiline = false;
            this.numericTextBox44.Name = "numericTextBox44";
            this.numericTextBox44.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox44.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox44.TabIndex = 28;
            this.numericTextBox44.Text = "";
            // 
            // numericTextBox45
            // 
            this.numericTextBox45.AllowSpace = false;
            this.numericTextBox45.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox45.Location = new System.Drawing.Point(128, 12);
            this.numericTextBox45.MaxLength = 1;
            this.numericTextBox45.Multiline = false;
            this.numericTextBox45.Name = "numericTextBox45";
            this.numericTextBox45.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox45.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox45.TabIndex = 27;
            this.numericTextBox45.Text = "";
            // 
            // numericTextBox46
            // 
            this.numericTextBox46.AllowSpace = false;
            this.numericTextBox46.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox46.Location = new System.Drawing.Point(316, 316);
            this.numericTextBox46.MaxLength = 1;
            this.numericTextBox46.Multiline = false;
            this.numericTextBox46.Name = "numericTextBox46";
            this.numericTextBox46.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox46.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox46.TabIndex = 80;
            this.numericTextBox46.Text = "";
            // 
            // numericTextBox47
            // 
            this.numericTextBox47.AllowSpace = false;
            this.numericTextBox47.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox47.Location = new System.Drawing.Point(280, 316);
            this.numericTextBox47.MaxLength = 1;
            this.numericTextBox47.Multiline = false;
            this.numericTextBox47.Name = "numericTextBox47";
            this.numericTextBox47.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox47.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox47.TabIndex = 79;
            this.numericTextBox47.Text = "";
            // 
            // numericTextBox48
            // 
            this.numericTextBox48.AllowSpace = false;
            this.numericTextBox48.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox48.Location = new System.Drawing.Point(244, 316);
            this.numericTextBox48.MaxLength = 1;
            this.numericTextBox48.Multiline = false;
            this.numericTextBox48.Name = "numericTextBox48";
            this.numericTextBox48.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox48.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox48.TabIndex = 78;
            this.numericTextBox48.Text = "";
            // 
            // numericTextBox49
            // 
            this.numericTextBox49.AllowSpace = false;
            this.numericTextBox49.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox49.Location = new System.Drawing.Point(316, 280);
            this.numericTextBox49.MaxLength = 1;
            this.numericTextBox49.Multiline = false;
            this.numericTextBox49.Name = "numericTextBox49";
            this.numericTextBox49.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox49.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox49.TabIndex = 77;
            this.numericTextBox49.Text = "";
            // 
            // numericTextBox50
            // 
            this.numericTextBox50.AllowSpace = false;
            this.numericTextBox50.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox50.Location = new System.Drawing.Point(280, 280);
            this.numericTextBox50.MaxLength = 1;
            this.numericTextBox50.Multiline = false;
            this.numericTextBox50.Name = "numericTextBox50";
            this.numericTextBox50.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox50.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox50.TabIndex = 76;
            this.numericTextBox50.Text = "";
            // 
            // numericTextBox51
            // 
            this.numericTextBox51.AllowSpace = false;
            this.numericTextBox51.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox51.Location = new System.Drawing.Point(244, 280);
            this.numericTextBox51.MaxLength = 1;
            this.numericTextBox51.Multiline = false;
            this.numericTextBox51.Name = "numericTextBox51";
            this.numericTextBox51.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox51.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox51.TabIndex = 75;
            this.numericTextBox51.Text = "";
            // 
            // numericTextBox52
            // 
            this.numericTextBox52.AllowSpace = false;
            this.numericTextBox52.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox52.Location = new System.Drawing.Point(316, 244);
            this.numericTextBox52.MaxLength = 1;
            this.numericTextBox52.Multiline = false;
            this.numericTextBox52.Name = "numericTextBox52";
            this.numericTextBox52.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox52.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox52.TabIndex = 74;
            this.numericTextBox52.Text = "";
            // 
            // numericTextBox53
            // 
            this.numericTextBox53.AllowSpace = false;
            this.numericTextBox53.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox53.Location = new System.Drawing.Point(280, 244);
            this.numericTextBox53.MaxLength = 1;
            this.numericTextBox53.Multiline = false;
            this.numericTextBox53.Name = "numericTextBox53";
            this.numericTextBox53.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox53.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox53.TabIndex = 73;
            this.numericTextBox53.Text = "";
            // 
            // numericTextBox54
            // 
            this.numericTextBox54.AllowSpace = false;
            this.numericTextBox54.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox54.Location = new System.Drawing.Point(244, 244);
            this.numericTextBox54.MaxLength = 1;
            this.numericTextBox54.Multiline = false;
            this.numericTextBox54.Name = "numericTextBox54";
            this.numericTextBox54.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox54.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox54.TabIndex = 72;
            this.numericTextBox54.Text = "";
            // 
            // numericTextBox55
            // 
            this.numericTextBox55.AllowSpace = false;
            this.numericTextBox55.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox55.Location = new System.Drawing.Point(316, 200);
            this.numericTextBox55.MaxLength = 1;
            this.numericTextBox55.Multiline = false;
            this.numericTextBox55.Name = "numericTextBox55";
            this.numericTextBox55.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox55.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox55.TabIndex = 71;
            this.numericTextBox55.Text = "";
            // 
            // numericTextBox56
            // 
            this.numericTextBox56.AllowSpace = false;
            this.numericTextBox56.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox56.Location = new System.Drawing.Point(280, 200);
            this.numericTextBox56.MaxLength = 1;
            this.numericTextBox56.Multiline = false;
            this.numericTextBox56.Name = "numericTextBox56";
            this.numericTextBox56.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox56.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox56.TabIndex = 70;
            this.numericTextBox56.Text = "";
            // 
            // numericTextBox57
            // 
            this.numericTextBox57.AllowSpace = false;
            this.numericTextBox57.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox57.Location = new System.Drawing.Point(244, 200);
            this.numericTextBox57.MaxLength = 1;
            this.numericTextBox57.Multiline = false;
            this.numericTextBox57.Name = "numericTextBox57";
            this.numericTextBox57.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox57.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox57.TabIndex = 69;
            this.numericTextBox57.Text = "";
            // 
            // numericTextBox58
            // 
            this.numericTextBox58.AllowSpace = false;
            this.numericTextBox58.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox58.Location = new System.Drawing.Point(316, 164);
            this.numericTextBox58.MaxLength = 1;
            this.numericTextBox58.Multiline = false;
            this.numericTextBox58.Name = "numericTextBox58";
            this.numericTextBox58.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox58.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox58.TabIndex = 68;
            this.numericTextBox58.Text = "";
            // 
            // numericTextBox59
            // 
            this.numericTextBox59.AllowSpace = false;
            this.numericTextBox59.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox59.Location = new System.Drawing.Point(280, 164);
            this.numericTextBox59.MaxLength = 1;
            this.numericTextBox59.Multiline = false;
            this.numericTextBox59.Name = "numericTextBox59";
            this.numericTextBox59.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox59.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox59.TabIndex = 67;
            this.numericTextBox59.Text = "";
            // 
            // numericTextBox60
            // 
            this.numericTextBox60.AllowSpace = false;
            this.numericTextBox60.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox60.Location = new System.Drawing.Point(244, 164);
            this.numericTextBox60.MaxLength = 1;
            this.numericTextBox60.Multiline = false;
            this.numericTextBox60.Name = "numericTextBox60";
            this.numericTextBox60.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox60.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox60.TabIndex = 66;
            this.numericTextBox60.Text = "";
            // 
            // numericTextBox61
            // 
            this.numericTextBox61.AllowSpace = false;
            this.numericTextBox61.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox61.Location = new System.Drawing.Point(316, 128);
            this.numericTextBox61.MaxLength = 1;
            this.numericTextBox61.Multiline = false;
            this.numericTextBox61.Name = "numericTextBox61";
            this.numericTextBox61.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox61.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox61.TabIndex = 65;
            this.numericTextBox61.Text = "";
            // 
            // numericTextBox62
            // 
            this.numericTextBox62.AllowSpace = false;
            this.numericTextBox62.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox62.Location = new System.Drawing.Point(280, 128);
            this.numericTextBox62.MaxLength = 1;
            this.numericTextBox62.Multiline = false;
            this.numericTextBox62.Name = "numericTextBox62";
            this.numericTextBox62.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox62.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox62.TabIndex = 64;
            this.numericTextBox62.Text = "";
            // 
            // numericTextBox63
            // 
            this.numericTextBox63.AllowSpace = false;
            this.numericTextBox63.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox63.Location = new System.Drawing.Point(244, 128);
            this.numericTextBox63.MaxLength = 1;
            this.numericTextBox63.Multiline = false;
            this.numericTextBox63.Name = "numericTextBox63";
            this.numericTextBox63.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox63.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox63.TabIndex = 63;
            this.numericTextBox63.Text = "";
            // 
            // numericTextBox64
            // 
            this.numericTextBox64.AllowSpace = false;
            this.numericTextBox64.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox64.Location = new System.Drawing.Point(316, 84);
            this.numericTextBox64.MaxLength = 1;
            this.numericTextBox64.Multiline = false;
            this.numericTextBox64.Name = "numericTextBox64";
            this.numericTextBox64.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox64.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox64.TabIndex = 62;
            this.numericTextBox64.Text = "";
            // 
            // numericTextBox65
            // 
            this.numericTextBox65.AllowSpace = false;
            this.numericTextBox65.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox65.Location = new System.Drawing.Point(280, 84);
            this.numericTextBox65.MaxLength = 1;
            this.numericTextBox65.Multiline = false;
            this.numericTextBox65.Name = "numericTextBox65";
            this.numericTextBox65.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox65.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox65.TabIndex = 61;
            this.numericTextBox65.Text = "";
            // 
            // numericTextBox66
            // 
            this.numericTextBox66.AllowSpace = false;
            this.numericTextBox66.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox66.Location = new System.Drawing.Point(244, 84);
            this.numericTextBox66.MaxLength = 1;
            this.numericTextBox66.Multiline = false;
            this.numericTextBox66.Name = "numericTextBox66";
            this.numericTextBox66.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox66.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox66.TabIndex = 60;
            this.numericTextBox66.Text = "";
            // 
            // numericTextBox67
            // 
            this.numericTextBox67.AllowSpace = false;
            this.numericTextBox67.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox67.Location = new System.Drawing.Point(316, 48);
            this.numericTextBox67.MaxLength = 1;
            this.numericTextBox67.Multiline = false;
            this.numericTextBox67.Name = "numericTextBox67";
            this.numericTextBox67.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox67.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox67.TabIndex = 59;
            this.numericTextBox67.Text = "";
            // 
            // numericTextBox68
            // 
            this.numericTextBox68.AllowSpace = false;
            this.numericTextBox68.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox68.Location = new System.Drawing.Point(280, 48);
            this.numericTextBox68.MaxLength = 1;
            this.numericTextBox68.Multiline = false;
            this.numericTextBox68.Name = "numericTextBox68";
            this.numericTextBox68.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox68.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox68.TabIndex = 58;
            this.numericTextBox68.Text = "";
            // 
            // numericTextBox69
            // 
            this.numericTextBox69.AllowSpace = false;
            this.numericTextBox69.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox69.Location = new System.Drawing.Point(244, 48);
            this.numericTextBox69.MaxLength = 1;
            this.numericTextBox69.Multiline = false;
            this.numericTextBox69.Name = "numericTextBox69";
            this.numericTextBox69.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox69.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox69.TabIndex = 57;
            this.numericTextBox69.Text = "";
            // 
            // numericTextBox70
            // 
            this.numericTextBox70.AllowSpace = false;
            this.numericTextBox70.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox70.Location = new System.Drawing.Point(316, 12);
            this.numericTextBox70.MaxLength = 1;
            this.numericTextBox70.Multiline = false;
            this.numericTextBox70.Name = "numericTextBox70";
            this.numericTextBox70.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox70.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox70.TabIndex = 56;
            this.numericTextBox70.Text = "";
            // 
            // numericTextBox71
            // 
            this.numericTextBox71.AllowSpace = false;
            this.numericTextBox71.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox71.Location = new System.Drawing.Point(280, 12);
            this.numericTextBox71.MaxLength = 1;
            this.numericTextBox71.Multiline = false;
            this.numericTextBox71.Name = "numericTextBox71";
            this.numericTextBox71.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox71.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox71.TabIndex = 55;
            this.numericTextBox71.Text = "";
            // 
            // numericTextBox72
            // 
            this.numericTextBox72.AllowSpace = false;
            this.numericTextBox72.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTextBox72.Location = new System.Drawing.Point(244, 12);
            this.numericTextBox72.MaxLength = 1;
            this.numericTextBox72.Multiline = false;
            this.numericTextBox72.Name = "numericTextBox72";
            this.numericTextBox72.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.numericTextBox72.Size = new System.Drawing.Size(30, 30);
            this.numericTextBox72.TabIndex = 54;
            this.numericTextBox72.Text = "";
            // 
            // GameField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 355);
            this.Controls.Add(this.numericTextBox46);
            this.Controls.Add(this.numericTextBox47);
            this.Controls.Add(this.numericTextBox48);
            this.Controls.Add(this.numericTextBox49);
            this.Controls.Add(this.numericTextBox50);
            this.Controls.Add(this.numericTextBox51);
            this.Controls.Add(this.numericTextBox52);
            this.Controls.Add(this.numericTextBox53);
            this.Controls.Add(this.numericTextBox54);
            this.Controls.Add(this.numericTextBox55);
            this.Controls.Add(this.numericTextBox56);
            this.Controls.Add(this.numericTextBox57);
            this.Controls.Add(this.numericTextBox58);
            this.Controls.Add(this.numericTextBox59);
            this.Controls.Add(this.numericTextBox60);
            this.Controls.Add(this.numericTextBox61);
            this.Controls.Add(this.numericTextBox62);
            this.Controls.Add(this.numericTextBox63);
            this.Controls.Add(this.numericTextBox64);
            this.Controls.Add(this.numericTextBox65);
            this.Controls.Add(this.numericTextBox66);
            this.Controls.Add(this.numericTextBox67);
            this.Controls.Add(this.numericTextBox68);
            this.Controls.Add(this.numericTextBox69);
            this.Controls.Add(this.numericTextBox70);
            this.Controls.Add(this.numericTextBox71);
            this.Controls.Add(this.numericTextBox72);
            this.Controls.Add(this.numericTextBox19);
            this.Controls.Add(this.numericTextBox20);
            this.Controls.Add(this.numericTextBox21);
            this.Controls.Add(this.numericTextBox22);
            this.Controls.Add(this.numericTextBox23);
            this.Controls.Add(this.numericTextBox24);
            this.Controls.Add(this.numericTextBox25);
            this.Controls.Add(this.numericTextBox26);
            this.Controls.Add(this.numericTextBox27);
            this.Controls.Add(this.numericTextBox28);
            this.Controls.Add(this.numericTextBox29);
            this.Controls.Add(this.numericTextBox30);
            this.Controls.Add(this.numericTextBox31);
            this.Controls.Add(this.numericTextBox32);
            this.Controls.Add(this.numericTextBox33);
            this.Controls.Add(this.numericTextBox34);
            this.Controls.Add(this.numericTextBox35);
            this.Controls.Add(this.numericTextBox36);
            this.Controls.Add(this.numericTextBox37);
            this.Controls.Add(this.numericTextBox38);
            this.Controls.Add(this.numericTextBox39);
            this.Controls.Add(this.numericTextBox40);
            this.Controls.Add(this.numericTextBox41);
            this.Controls.Add(this.numericTextBox42);
            this.Controls.Add(this.numericTextBox43);
            this.Controls.Add(this.numericTextBox44);
            this.Controls.Add(this.numericTextBox45);
            this.Controls.Add(this.numericTextBox10);
            this.Controls.Add(this.numericTextBox11);
            this.Controls.Add(this.numericTextBox12);
            this.Controls.Add(this.numericTextBox13);
            this.Controls.Add(this.numericTextBox14);
            this.Controls.Add(this.numericTextBox15);
            this.Controls.Add(this.numericTextBox16);
            this.Controls.Add(this.numericTextBox17);
            this.Controls.Add(this.numericTextBox18);
            this.Controls.Add(this.numericTextBox1);
            this.Controls.Add(this.numericTextBox2);
            this.Controls.Add(this.numericTextBox3);
            this.Controls.Add(this.numericTextBox4);
            this.Controls.Add(this.numericTextBox5);
            this.Controls.Add(this.numericTextBox6);
            this.Controls.Add(this.numericTextBox7);
            this.Controls.Add(this.numericTextBox8);
            this.Controls.Add(this.numericTextBox9);
            this.Controls.Add(this.ntb33);
            this.Controls.Add(this.ntb32);
            this.Controls.Add(this.ntb31);
            this.Controls.Add(this.ntb23);
            this.Controls.Add(this.ntb22);
            this.Controls.Add(this.ntb21);
            this.Controls.Add(this.ntb13);
            this.Controls.Add(this.ntb12);
            this.Controls.Add(this.ntb11);
            this.Name = "GameField";
            this.Text = "Sudoku";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SingleDigitCenteredTextBox ntb11;
        private SingleDigitCenteredTextBox ntb12;
        private SingleDigitCenteredTextBox ntb13;
        private SingleDigitCenteredTextBox ntb21;
        private SingleDigitCenteredTextBox ntb22;
        private SingleDigitCenteredTextBox ntb23;
        private SingleDigitCenteredTextBox ntb31;
        private SingleDigitCenteredTextBox ntb32;
        private SingleDigitCenteredTextBox ntb33;
        private SingleDigitCenteredTextBox numericTextBox1;
        private SingleDigitCenteredTextBox numericTextBox2;
        private SingleDigitCenteredTextBox numericTextBox3;
        private SingleDigitCenteredTextBox numericTextBox4;
        private SingleDigitCenteredTextBox numericTextBox5;
        private SingleDigitCenteredTextBox numericTextBox6;
        private SingleDigitCenteredTextBox numericTextBox7;
        private SingleDigitCenteredTextBox numericTextBox8;
        private SingleDigitCenteredTextBox numericTextBox9;
        private SingleDigitCenteredTextBox numericTextBox10;
        private SingleDigitCenteredTextBox numericTextBox11;
        private SingleDigitCenteredTextBox numericTextBox12;
        private SingleDigitCenteredTextBox numericTextBox13;
        private SingleDigitCenteredTextBox numericTextBox14;
        private SingleDigitCenteredTextBox numericTextBox15;
        private SingleDigitCenteredTextBox numericTextBox16;
        private SingleDigitCenteredTextBox numericTextBox17;
        private SingleDigitCenteredTextBox numericTextBox18;
        private SingleDigitCenteredTextBox numericTextBox19;
        private SingleDigitCenteredTextBox numericTextBox20;
        private SingleDigitCenteredTextBox numericTextBox21;
        private SingleDigitCenteredTextBox numericTextBox22;
        private SingleDigitCenteredTextBox numericTextBox23;
        private SingleDigitCenteredTextBox numericTextBox24;
        private SingleDigitCenteredTextBox numericTextBox25;
        private SingleDigitCenteredTextBox numericTextBox26;
        private SingleDigitCenteredTextBox numericTextBox27;
        private SingleDigitCenteredTextBox numericTextBox28;
        private SingleDigitCenteredTextBox numericTextBox29;
        private SingleDigitCenteredTextBox numericTextBox30;
        private SingleDigitCenteredTextBox numericTextBox31;
        private SingleDigitCenteredTextBox numericTextBox32;
        private SingleDigitCenteredTextBox numericTextBox33;
        private SingleDigitCenteredTextBox numericTextBox34;
        private SingleDigitCenteredTextBox numericTextBox35;
        private SingleDigitCenteredTextBox numericTextBox36;
        private SingleDigitCenteredTextBox numericTextBox37;
        private SingleDigitCenteredTextBox numericTextBox38;
        private SingleDigitCenteredTextBox numericTextBox39;
        private SingleDigitCenteredTextBox numericTextBox40;
        private SingleDigitCenteredTextBox numericTextBox41;
        private SingleDigitCenteredTextBox numericTextBox42;
        private SingleDigitCenteredTextBox numericTextBox43;
        private SingleDigitCenteredTextBox numericTextBox44;
        private SingleDigitCenteredTextBox numericTextBox45;
        private SingleDigitCenteredTextBox numericTextBox46;
        private SingleDigitCenteredTextBox numericTextBox47;
        private SingleDigitCenteredTextBox numericTextBox48;
        private SingleDigitCenteredTextBox numericTextBox49;
        private SingleDigitCenteredTextBox numericTextBox50;
        private SingleDigitCenteredTextBox numericTextBox51;
        private SingleDigitCenteredTextBox numericTextBox52;
        private SingleDigitCenteredTextBox numericTextBox53;
        private SingleDigitCenteredTextBox numericTextBox54;
        private SingleDigitCenteredTextBox numericTextBox55;
        private SingleDigitCenteredTextBox numericTextBox56;
        private SingleDigitCenteredTextBox numericTextBox57;
        private SingleDigitCenteredTextBox numericTextBox58;
        private SingleDigitCenteredTextBox numericTextBox59;
        private SingleDigitCenteredTextBox numericTextBox60;
        private SingleDigitCenteredTextBox numericTextBox61;
        private SingleDigitCenteredTextBox numericTextBox62;
        private SingleDigitCenteredTextBox numericTextBox63;
        private SingleDigitCenteredTextBox numericTextBox64;
        private SingleDigitCenteredTextBox numericTextBox65;
        private SingleDigitCenteredTextBox numericTextBox66;
        private SingleDigitCenteredTextBox numericTextBox67;
        private SingleDigitCenteredTextBox numericTextBox68;
        private SingleDigitCenteredTextBox numericTextBox69;
        private SingleDigitCenteredTextBox numericTextBox70;
        private SingleDigitCenteredTextBox numericTextBox71;
        private SingleDigitCenteredTextBox numericTextBox72;
    }
}

