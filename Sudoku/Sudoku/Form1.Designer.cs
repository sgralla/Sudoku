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
            this.GameMessageBox = new System.Windows.Forms.TextBox();
            this.PlayingField = new System.Windows.Forms.GroupBox();
            this.sdc25 = new SingleDigitCenteredTextBox();
            this.sdc11 = new SingleDigitCenteredTextBox();
            this.sdc99 = new SingleDigitCenteredTextBox();
            this.sdc12 = new SingleDigitCenteredTextBox();
            this.sdc98 = new SingleDigitCenteredTextBox();
            this.sdc13 = new SingleDigitCenteredTextBox();
            this.sdc97 = new SingleDigitCenteredTextBox();
            this.sdc21 = new SingleDigitCenteredTextBox();
            this.sdc89 = new SingleDigitCenteredTextBox();
            this.sdc22 = new SingleDigitCenteredTextBox();
            this.sdc88 = new SingleDigitCenteredTextBox();
            this.sdc23 = new SingleDigitCenteredTextBox();
            this.sdc87 = new SingleDigitCenteredTextBox();
            this.sdc31 = new SingleDigitCenteredTextBox();
            this.sdc79 = new SingleDigitCenteredTextBox();
            this.sdc32 = new SingleDigitCenteredTextBox();
            this.sdc78 = new SingleDigitCenteredTextBox();
            this.sdc33 = new SingleDigitCenteredTextBox();
            this.sdc77 = new SingleDigitCenteredTextBox();
            this.sdc41 = new SingleDigitCenteredTextBox();
            this.sdc69 = new SingleDigitCenteredTextBox();
            this.sdc42 = new SingleDigitCenteredTextBox();
            this.sdc68 = new SingleDigitCenteredTextBox();
            this.sdc43 = new SingleDigitCenteredTextBox();
            this.sdc67 = new SingleDigitCenteredTextBox();
            this.sdc51 = new SingleDigitCenteredTextBox();
            this.sdc59 = new SingleDigitCenteredTextBox();
            this.sdc52 = new SingleDigitCenteredTextBox();
            this.sdc58 = new SingleDigitCenteredTextBox();
            this.sdc53 = new SingleDigitCenteredTextBox();
            this.sdc57 = new SingleDigitCenteredTextBox();
            this.sdc61 = new SingleDigitCenteredTextBox();
            this.sdc49 = new SingleDigitCenteredTextBox();
            this.sdc62 = new SingleDigitCenteredTextBox();
            this.sdc48 = new SingleDigitCenteredTextBox();
            this.sdc63 = new SingleDigitCenteredTextBox();
            this.sdc47 = new SingleDigitCenteredTextBox();
            this.sdc71 = new SingleDigitCenteredTextBox();
            this.sdc39 = new SingleDigitCenteredTextBox();
            this.sdc72 = new SingleDigitCenteredTextBox();
            this.sdc38 = new SingleDigitCenteredTextBox();
            this.sdc73 = new SingleDigitCenteredTextBox();
            this.sdc37 = new SingleDigitCenteredTextBox();
            this.sdc81 = new SingleDigitCenteredTextBox();
            this.sdc29 = new SingleDigitCenteredTextBox();
            this.sdc82 = new SingleDigitCenteredTextBox();
            this.sdc28 = new SingleDigitCenteredTextBox();
            this.sdc83 = new SingleDigitCenteredTextBox();
            this.sdc27 = new SingleDigitCenteredTextBox();
            this.sdc91 = new SingleDigitCenteredTextBox();
            this.sdc19 = new SingleDigitCenteredTextBox();
            this.sdc92 = new SingleDigitCenteredTextBox();
            this.sdc18 = new SingleDigitCenteredTextBox();
            this.sdc93 = new SingleDigitCenteredTextBox();
            this.sdc17 = new SingleDigitCenteredTextBox();
            this.sdc14 = new SingleDigitCenteredTextBox();
            this.sdc96 = new SingleDigitCenteredTextBox();
            this.sdc15 = new SingleDigitCenteredTextBox();
            this.sdc95 = new SingleDigitCenteredTextBox();
            this.sdc16 = new SingleDigitCenteredTextBox();
            this.sdc94 = new SingleDigitCenteredTextBox();
            this.sdc24 = new SingleDigitCenteredTextBox();
            this.sdc86 = new SingleDigitCenteredTextBox();
            this.sdc26 = new SingleDigitCenteredTextBox();
            this.sdc85 = new SingleDigitCenteredTextBox();
            this.sdc34 = new SingleDigitCenteredTextBox();
            this.sdc84 = new SingleDigitCenteredTextBox();
            this.sdc35 = new SingleDigitCenteredTextBox();
            this.sdc76 = new SingleDigitCenteredTextBox();
            this.sdc36 = new SingleDigitCenteredTextBox();
            this.sdc75 = new SingleDigitCenteredTextBox();
            this.sdc44 = new SingleDigitCenteredTextBox();
            this.sdc74 = new SingleDigitCenteredTextBox();
            this.sdc45 = new SingleDigitCenteredTextBox();
            this.sdc66 = new SingleDigitCenteredTextBox();
            this.sdc46 = new SingleDigitCenteredTextBox();
            this.sdc65 = new SingleDigitCenteredTextBox();
            this.sdc54 = new SingleDigitCenteredTextBox();
            this.sdc64 = new SingleDigitCenteredTextBox();
            this.sdc55 = new SingleDigitCenteredTextBox();
            this.sdc56 = new SingleDigitCenteredTextBox();
            this.Main_MenuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IOcSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayingField.SuspendLayout();
            this.Main_MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameMessageBox
            // 
            this.GameMessageBox.Location = new System.Drawing.Point(20, 390);
            this.GameMessageBox.Name = "GameMessageBox";
            this.GameMessageBox.Size = new System.Drawing.Size(334, 20);
            this.GameMessageBox.TabIndex = 81;
            // 
            // PlayingField
            // 
            this.PlayingField.Controls.Add(this.sdc25);
            this.PlayingField.Controls.Add(this.sdc11);
            this.PlayingField.Controls.Add(this.sdc99);
            this.PlayingField.Controls.Add(this.sdc12);
            this.PlayingField.Controls.Add(this.sdc98);
            this.PlayingField.Controls.Add(this.sdc13);
            this.PlayingField.Controls.Add(this.sdc97);
            this.PlayingField.Controls.Add(this.sdc21);
            this.PlayingField.Controls.Add(this.sdc89);
            this.PlayingField.Controls.Add(this.sdc22);
            this.PlayingField.Controls.Add(this.sdc88);
            this.PlayingField.Controls.Add(this.sdc23);
            this.PlayingField.Controls.Add(this.sdc87);
            this.PlayingField.Controls.Add(this.sdc31);
            this.PlayingField.Controls.Add(this.sdc79);
            this.PlayingField.Controls.Add(this.sdc32);
            this.PlayingField.Controls.Add(this.sdc78);
            this.PlayingField.Controls.Add(this.sdc33);
            this.PlayingField.Controls.Add(this.sdc77);
            this.PlayingField.Controls.Add(this.sdc41);
            this.PlayingField.Controls.Add(this.sdc69);
            this.PlayingField.Controls.Add(this.sdc42);
            this.PlayingField.Controls.Add(this.sdc68);
            this.PlayingField.Controls.Add(this.sdc43);
            this.PlayingField.Controls.Add(this.sdc67);
            this.PlayingField.Controls.Add(this.sdc51);
            this.PlayingField.Controls.Add(this.sdc59);
            this.PlayingField.Controls.Add(this.sdc52);
            this.PlayingField.Controls.Add(this.sdc58);
            this.PlayingField.Controls.Add(this.sdc53);
            this.PlayingField.Controls.Add(this.sdc57);
            this.PlayingField.Controls.Add(this.sdc61);
            this.PlayingField.Controls.Add(this.sdc49);
            this.PlayingField.Controls.Add(this.sdc62);
            this.PlayingField.Controls.Add(this.sdc48);
            this.PlayingField.Controls.Add(this.sdc63);
            this.PlayingField.Controls.Add(this.sdc47);
            this.PlayingField.Controls.Add(this.sdc71);
            this.PlayingField.Controls.Add(this.sdc39);
            this.PlayingField.Controls.Add(this.sdc72);
            this.PlayingField.Controls.Add(this.sdc38);
            this.PlayingField.Controls.Add(this.sdc73);
            this.PlayingField.Controls.Add(this.sdc37);
            this.PlayingField.Controls.Add(this.sdc81);
            this.PlayingField.Controls.Add(this.sdc29);
            this.PlayingField.Controls.Add(this.sdc82);
            this.PlayingField.Controls.Add(this.sdc28);
            this.PlayingField.Controls.Add(this.sdc83);
            this.PlayingField.Controls.Add(this.sdc27);
            this.PlayingField.Controls.Add(this.sdc91);
            this.PlayingField.Controls.Add(this.sdc19);
            this.PlayingField.Controls.Add(this.sdc92);
            this.PlayingField.Controls.Add(this.sdc18);
            this.PlayingField.Controls.Add(this.sdc93);
            this.PlayingField.Controls.Add(this.sdc17);
            this.PlayingField.Controls.Add(this.sdc14);
            this.PlayingField.Controls.Add(this.sdc96);
            this.PlayingField.Controls.Add(this.sdc15);
            this.PlayingField.Controls.Add(this.sdc95);
            this.PlayingField.Controls.Add(this.sdc16);
            this.PlayingField.Controls.Add(this.sdc94);
            this.PlayingField.Controls.Add(this.sdc24);
            this.PlayingField.Controls.Add(this.sdc86);
            this.PlayingField.Controls.Add(this.sdc26);
            this.PlayingField.Controls.Add(this.sdc85);
            this.PlayingField.Controls.Add(this.sdc34);
            this.PlayingField.Controls.Add(this.sdc84);
            this.PlayingField.Controls.Add(this.sdc35);
            this.PlayingField.Controls.Add(this.sdc76);
            this.PlayingField.Controls.Add(this.sdc36);
            this.PlayingField.Controls.Add(this.sdc75);
            this.PlayingField.Controls.Add(this.sdc44);
            this.PlayingField.Controls.Add(this.sdc74);
            this.PlayingField.Controls.Add(this.sdc45);
            this.PlayingField.Controls.Add(this.sdc66);
            this.PlayingField.Controls.Add(this.sdc46);
            this.PlayingField.Controls.Add(this.sdc65);
            this.PlayingField.Controls.Add(this.sdc54);
            this.PlayingField.Controls.Add(this.sdc64);
            this.PlayingField.Controls.Add(this.sdc55);
            this.PlayingField.Controls.Add(this.sdc56);
            this.PlayingField.Location = new System.Drawing.Point(12, 27);
            this.PlayingField.Name = "PlayingField";
            this.PlayingField.Size = new System.Drawing.Size(350, 357);
            this.PlayingField.TabIndex = 82;
            this.PlayingField.TabStop = false;
            this.PlayingField.Text = "Spielfeld";
            // 
            // sdc25
            // 
            this.sdc25.AllowSpace = false;
            this.sdc25.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc25.Location = new System.Drawing.Point(160, 51);
            this.sdc25.MaxLength = 1;
            this.sdc25.Multiline = false;
            this.sdc25.Name = "sdc25";
            this.sdc25.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc25.Size = new System.Drawing.Size(30, 30);
            this.sdc25.TabIndex = 31;
            this.sdc25.Text = "";
            // 
            // sdc11
            // 
            this.sdc11.AllowSpace = false;
            this.sdc11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc11.Location = new System.Drawing.Point(8, 15);
            this.sdc11.MaxLength = 1;
            this.sdc11.Multiline = false;
            this.sdc11.Name = "sdc11";
            this.sdc11.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc11.Size = new System.Drawing.Size(30, 30);
            this.sdc11.TabIndex = 0;
            this.sdc11.Text = "";
            // 
            // sdc99
            // 
            this.sdc99.AllowSpace = false;
            this.sdc99.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc99.Location = new System.Drawing.Point(312, 319);
            this.sdc99.MaxLength = 1;
            this.sdc99.Multiline = false;
            this.sdc99.Name = "sdc99";
            this.sdc99.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc99.Size = new System.Drawing.Size(30, 30);
            this.sdc99.TabIndex = 80;
            this.sdc99.Text = "";
            // 
            // sdc12
            // 
            this.sdc12.AllowSpace = false;
            this.sdc12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc12.Location = new System.Drawing.Point(44, 15);
            this.sdc12.MaxLength = 1;
            this.sdc12.Multiline = false;
            this.sdc12.Name = "sdc12";
            this.sdc12.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc12.Size = new System.Drawing.Size(30, 30);
            this.sdc12.TabIndex = 1;
            this.sdc12.Text = "";
            // 
            // sdc98
            // 
            this.sdc98.AllowSpace = false;
            this.sdc98.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc98.Location = new System.Drawing.Point(276, 319);
            this.sdc98.MaxLength = 1;
            this.sdc98.Multiline = false;
            this.sdc98.Name = "sdc98";
            this.sdc98.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc98.Size = new System.Drawing.Size(30, 30);
            this.sdc98.TabIndex = 79;
            this.sdc98.Text = "";
            // 
            // sdc13
            // 
            this.sdc13.AllowSpace = false;
            this.sdc13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc13.Location = new System.Drawing.Point(80, 15);
            this.sdc13.MaxLength = 1;
            this.sdc13.Multiline = false;
            this.sdc13.Name = "sdc13";
            this.sdc13.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc13.Size = new System.Drawing.Size(30, 30);
            this.sdc13.TabIndex = 2;
            this.sdc13.Text = "";
            // 
            // sdc97
            // 
            this.sdc97.AllowSpace = false;
            this.sdc97.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc97.Location = new System.Drawing.Point(240, 319);
            this.sdc97.MaxLength = 1;
            this.sdc97.Multiline = false;
            this.sdc97.Name = "sdc97";
            this.sdc97.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc97.Size = new System.Drawing.Size(30, 30);
            this.sdc97.TabIndex = 78;
            this.sdc97.Text = "";
            // 
            // sdc21
            // 
            this.sdc21.AllowSpace = false;
            this.sdc21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc21.Location = new System.Drawing.Point(8, 51);
            this.sdc21.MaxLength = 1;
            this.sdc21.Multiline = false;
            this.sdc21.Name = "sdc21";
            this.sdc21.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc21.Size = new System.Drawing.Size(30, 30);
            this.sdc21.TabIndex = 3;
            this.sdc21.Text = "";
            // 
            // sdc89
            // 
            this.sdc89.AllowSpace = false;
            this.sdc89.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc89.Location = new System.Drawing.Point(312, 283);
            this.sdc89.MaxLength = 1;
            this.sdc89.Multiline = false;
            this.sdc89.Name = "sdc89";
            this.sdc89.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc89.Size = new System.Drawing.Size(30, 30);
            this.sdc89.TabIndex = 77;
            this.sdc89.Text = "";
            // 
            // sdc22
            // 
            this.sdc22.AllowSpace = false;
            this.sdc22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc22.Location = new System.Drawing.Point(44, 51);
            this.sdc22.MaxLength = 1;
            this.sdc22.Multiline = false;
            this.sdc22.Name = "sdc22";
            this.sdc22.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc22.Size = new System.Drawing.Size(30, 30);
            this.sdc22.TabIndex = 4;
            this.sdc22.Text = "";
            // 
            // sdc88
            // 
            this.sdc88.AllowSpace = false;
            this.sdc88.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc88.Location = new System.Drawing.Point(276, 283);
            this.sdc88.MaxLength = 1;
            this.sdc88.Multiline = false;
            this.sdc88.Name = "sdc88";
            this.sdc88.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc88.Size = new System.Drawing.Size(30, 30);
            this.sdc88.TabIndex = 76;
            this.sdc88.Text = "";
            // 
            // sdc23
            // 
            this.sdc23.AllowSpace = false;
            this.sdc23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc23.Location = new System.Drawing.Point(80, 51);
            this.sdc23.MaxLength = 1;
            this.sdc23.Multiline = false;
            this.sdc23.Name = "sdc23";
            this.sdc23.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc23.Size = new System.Drawing.Size(30, 30);
            this.sdc23.TabIndex = 5;
            this.sdc23.Text = "";
            // 
            // sdc87
            // 
            this.sdc87.AllowSpace = false;
            this.sdc87.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc87.Location = new System.Drawing.Point(240, 283);
            this.sdc87.MaxLength = 1;
            this.sdc87.Multiline = false;
            this.sdc87.Name = "sdc87";
            this.sdc87.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc87.Size = new System.Drawing.Size(30, 30);
            this.sdc87.TabIndex = 75;
            this.sdc87.Text = "";
            // 
            // sdc31
            // 
            this.sdc31.AllowSpace = false;
            this.sdc31.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc31.Location = new System.Drawing.Point(8, 87);
            this.sdc31.MaxLength = 1;
            this.sdc31.Multiline = false;
            this.sdc31.Name = "sdc31";
            this.sdc31.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc31.Size = new System.Drawing.Size(30, 30);
            this.sdc31.TabIndex = 6;
            this.sdc31.Text = "";
            // 
            // sdc79
            // 
            this.sdc79.AllowSpace = false;
            this.sdc79.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc79.Location = new System.Drawing.Point(312, 247);
            this.sdc79.MaxLength = 1;
            this.sdc79.Multiline = false;
            this.sdc79.Name = "sdc79";
            this.sdc79.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc79.Size = new System.Drawing.Size(30, 30);
            this.sdc79.TabIndex = 74;
            this.sdc79.Text = "";
            // 
            // sdc32
            // 
            this.sdc32.AllowSpace = false;
            this.sdc32.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc32.Location = new System.Drawing.Point(44, 87);
            this.sdc32.MaxLength = 1;
            this.sdc32.Multiline = false;
            this.sdc32.Name = "sdc32";
            this.sdc32.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc32.Size = new System.Drawing.Size(30, 30);
            this.sdc32.TabIndex = 7;
            this.sdc32.Text = "";
            // 
            // sdc78
            // 
            this.sdc78.AllowSpace = false;
            this.sdc78.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc78.Location = new System.Drawing.Point(276, 247);
            this.sdc78.MaxLength = 1;
            this.sdc78.Multiline = false;
            this.sdc78.Name = "sdc78";
            this.sdc78.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc78.Size = new System.Drawing.Size(30, 30);
            this.sdc78.TabIndex = 73;
            this.sdc78.Text = "";
            // 
            // sdc33
            // 
            this.sdc33.AllowSpace = false;
            this.sdc33.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc33.Location = new System.Drawing.Point(80, 87);
            this.sdc33.MaxLength = 1;
            this.sdc33.Multiline = false;
            this.sdc33.Name = "sdc33";
            this.sdc33.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc33.Size = new System.Drawing.Size(30, 30);
            this.sdc33.TabIndex = 8;
            this.sdc33.Text = "";
            // 
            // sdc77
            // 
            this.sdc77.AllowSpace = false;
            this.sdc77.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc77.Location = new System.Drawing.Point(240, 247);
            this.sdc77.MaxLength = 1;
            this.sdc77.Multiline = false;
            this.sdc77.Name = "sdc77";
            this.sdc77.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc77.Size = new System.Drawing.Size(30, 30);
            this.sdc77.TabIndex = 72;
            this.sdc77.Text = "";
            // 
            // sdc41
            // 
            this.sdc41.AllowSpace = false;
            this.sdc41.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc41.Location = new System.Drawing.Point(8, 131);
            this.sdc41.MaxLength = 1;
            this.sdc41.Multiline = false;
            this.sdc41.Name = "sdc41";
            this.sdc41.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc41.Size = new System.Drawing.Size(30, 30);
            this.sdc41.TabIndex = 9;
            this.sdc41.Text = "";
            // 
            // sdc69
            // 
            this.sdc69.AllowSpace = false;
            this.sdc69.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc69.Location = new System.Drawing.Point(312, 203);
            this.sdc69.MaxLength = 1;
            this.sdc69.Multiline = false;
            this.sdc69.Name = "sdc69";
            this.sdc69.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc69.Size = new System.Drawing.Size(30, 30);
            this.sdc69.TabIndex = 71;
            this.sdc69.Text = "";
            // 
            // sdc42
            // 
            this.sdc42.AllowSpace = false;
            this.sdc42.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc42.Location = new System.Drawing.Point(44, 131);
            this.sdc42.MaxLength = 1;
            this.sdc42.Multiline = false;
            this.sdc42.Name = "sdc42";
            this.sdc42.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc42.Size = new System.Drawing.Size(30, 30);
            this.sdc42.TabIndex = 10;
            this.sdc42.Text = "";
            // 
            // sdc68
            // 
            this.sdc68.AllowSpace = false;
            this.sdc68.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc68.Location = new System.Drawing.Point(276, 203);
            this.sdc68.MaxLength = 1;
            this.sdc68.Multiline = false;
            this.sdc68.Name = "sdc68";
            this.sdc68.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc68.Size = new System.Drawing.Size(30, 30);
            this.sdc68.TabIndex = 70;
            this.sdc68.Text = "";
            // 
            // sdc43
            // 
            this.sdc43.AllowSpace = false;
            this.sdc43.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc43.Location = new System.Drawing.Point(80, 131);
            this.sdc43.MaxLength = 1;
            this.sdc43.Multiline = false;
            this.sdc43.Name = "sdc43";
            this.sdc43.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc43.Size = new System.Drawing.Size(30, 30);
            this.sdc43.TabIndex = 11;
            this.sdc43.Text = "";
            // 
            // sdc67
            // 
            this.sdc67.AllowSpace = false;
            this.sdc67.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc67.Location = new System.Drawing.Point(240, 203);
            this.sdc67.MaxLength = 1;
            this.sdc67.Multiline = false;
            this.sdc67.Name = "sdc67";
            this.sdc67.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc67.Size = new System.Drawing.Size(30, 30);
            this.sdc67.TabIndex = 69;
            this.sdc67.Text = "";
            // 
            // sdc51
            // 
            this.sdc51.AllowSpace = false;
            this.sdc51.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc51.Location = new System.Drawing.Point(8, 167);
            this.sdc51.MaxLength = 1;
            this.sdc51.Multiline = false;
            this.sdc51.Name = "sdc51";
            this.sdc51.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc51.Size = new System.Drawing.Size(30, 30);
            this.sdc51.TabIndex = 12;
            this.sdc51.Text = "";
            // 
            // sdc59
            // 
            this.sdc59.AllowSpace = false;
            this.sdc59.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc59.Location = new System.Drawing.Point(312, 167);
            this.sdc59.MaxLength = 1;
            this.sdc59.Multiline = false;
            this.sdc59.Name = "sdc59";
            this.sdc59.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc59.Size = new System.Drawing.Size(30, 30);
            this.sdc59.TabIndex = 68;
            this.sdc59.Text = "";
            // 
            // sdc52
            // 
            this.sdc52.AllowSpace = false;
            this.sdc52.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc52.Location = new System.Drawing.Point(44, 167);
            this.sdc52.MaxLength = 1;
            this.sdc52.Multiline = false;
            this.sdc52.Name = "sdc52";
            this.sdc52.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc52.Size = new System.Drawing.Size(30, 30);
            this.sdc52.TabIndex = 13;
            this.sdc52.Text = "";
            // 
            // sdc58
            // 
            this.sdc58.AllowSpace = false;
            this.sdc58.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc58.Location = new System.Drawing.Point(276, 167);
            this.sdc58.MaxLength = 1;
            this.sdc58.Multiline = false;
            this.sdc58.Name = "sdc58";
            this.sdc58.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc58.Size = new System.Drawing.Size(30, 30);
            this.sdc58.TabIndex = 67;
            this.sdc58.Text = "";
            // 
            // sdc53
            // 
            this.sdc53.AllowSpace = false;
            this.sdc53.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc53.Location = new System.Drawing.Point(80, 167);
            this.sdc53.MaxLength = 1;
            this.sdc53.Multiline = false;
            this.sdc53.Name = "sdc53";
            this.sdc53.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc53.Size = new System.Drawing.Size(30, 30);
            this.sdc53.TabIndex = 14;
            this.sdc53.Text = "";
            // 
            // sdc57
            // 
            this.sdc57.AllowSpace = false;
            this.sdc57.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc57.Location = new System.Drawing.Point(240, 167);
            this.sdc57.MaxLength = 1;
            this.sdc57.Multiline = false;
            this.sdc57.Name = "sdc57";
            this.sdc57.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc57.Size = new System.Drawing.Size(30, 30);
            this.sdc57.TabIndex = 66;
            this.sdc57.Text = "";
            // 
            // sdc61
            // 
            this.sdc61.AllowSpace = false;
            this.sdc61.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc61.Location = new System.Drawing.Point(8, 203);
            this.sdc61.MaxLength = 1;
            this.sdc61.Multiline = false;
            this.sdc61.Name = "sdc61";
            this.sdc61.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc61.Size = new System.Drawing.Size(30, 30);
            this.sdc61.TabIndex = 15;
            this.sdc61.Text = "";
            // 
            // sdc49
            // 
            this.sdc49.AllowSpace = false;
            this.sdc49.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc49.Location = new System.Drawing.Point(312, 131);
            this.sdc49.MaxLength = 1;
            this.sdc49.Multiline = false;
            this.sdc49.Name = "sdc49";
            this.sdc49.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc49.Size = new System.Drawing.Size(30, 30);
            this.sdc49.TabIndex = 65;
            this.sdc49.Text = "";
            // 
            // sdc62
            // 
            this.sdc62.AllowSpace = false;
            this.sdc62.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc62.Location = new System.Drawing.Point(44, 203);
            this.sdc62.MaxLength = 1;
            this.sdc62.Multiline = false;
            this.sdc62.Name = "sdc62";
            this.sdc62.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc62.Size = new System.Drawing.Size(30, 30);
            this.sdc62.TabIndex = 16;
            this.sdc62.Text = "";
            // 
            // sdc48
            // 
            this.sdc48.AllowSpace = false;
            this.sdc48.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc48.Location = new System.Drawing.Point(276, 131);
            this.sdc48.MaxLength = 1;
            this.sdc48.Multiline = false;
            this.sdc48.Name = "sdc48";
            this.sdc48.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc48.Size = new System.Drawing.Size(30, 30);
            this.sdc48.TabIndex = 64;
            this.sdc48.Text = "";
            // 
            // sdc63
            // 
            this.sdc63.AllowSpace = false;
            this.sdc63.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc63.Location = new System.Drawing.Point(80, 203);
            this.sdc63.MaxLength = 1;
            this.sdc63.Multiline = false;
            this.sdc63.Name = "sdc63";
            this.sdc63.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc63.Size = new System.Drawing.Size(30, 30);
            this.sdc63.TabIndex = 17;
            this.sdc63.Text = "";
            // 
            // sdc47
            // 
            this.sdc47.AllowSpace = false;
            this.sdc47.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc47.Location = new System.Drawing.Point(240, 131);
            this.sdc47.MaxLength = 1;
            this.sdc47.Multiline = false;
            this.sdc47.Name = "sdc47";
            this.sdc47.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc47.Size = new System.Drawing.Size(30, 30);
            this.sdc47.TabIndex = 63;
            this.sdc47.Text = "";
            // 
            // sdc71
            // 
            this.sdc71.AllowSpace = false;
            this.sdc71.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc71.Location = new System.Drawing.Point(8, 247);
            this.sdc71.MaxLength = 1;
            this.sdc71.Multiline = false;
            this.sdc71.Name = "sdc71";
            this.sdc71.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc71.Size = new System.Drawing.Size(30, 30);
            this.sdc71.TabIndex = 18;
            this.sdc71.Text = "";
            // 
            // sdc39
            // 
            this.sdc39.AllowSpace = false;
            this.sdc39.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc39.Location = new System.Drawing.Point(312, 87);
            this.sdc39.MaxLength = 1;
            this.sdc39.Multiline = false;
            this.sdc39.Name = "sdc39";
            this.sdc39.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc39.Size = new System.Drawing.Size(30, 30);
            this.sdc39.TabIndex = 62;
            this.sdc39.Text = "";
            // 
            // sdc72
            // 
            this.sdc72.AllowSpace = false;
            this.sdc72.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc72.Location = new System.Drawing.Point(44, 247);
            this.sdc72.MaxLength = 1;
            this.sdc72.Multiline = false;
            this.sdc72.Name = "sdc72";
            this.sdc72.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc72.Size = new System.Drawing.Size(30, 30);
            this.sdc72.TabIndex = 19;
            this.sdc72.Text = "";
            // 
            // sdc38
            // 
            this.sdc38.AllowSpace = false;
            this.sdc38.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc38.Location = new System.Drawing.Point(276, 87);
            this.sdc38.MaxLength = 1;
            this.sdc38.Multiline = false;
            this.sdc38.Name = "sdc38";
            this.sdc38.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc38.Size = new System.Drawing.Size(30, 30);
            this.sdc38.TabIndex = 61;
            this.sdc38.Text = "";
            // 
            // sdc73
            // 
            this.sdc73.AllowSpace = false;
            this.sdc73.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc73.Location = new System.Drawing.Point(80, 247);
            this.sdc73.MaxLength = 1;
            this.sdc73.Multiline = false;
            this.sdc73.Name = "sdc73";
            this.sdc73.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc73.Size = new System.Drawing.Size(30, 30);
            this.sdc73.TabIndex = 20;
            this.sdc73.Text = "";
            // 
            // sdc37
            // 
            this.sdc37.AllowSpace = false;
            this.sdc37.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc37.Location = new System.Drawing.Point(240, 87);
            this.sdc37.MaxLength = 1;
            this.sdc37.Multiline = false;
            this.sdc37.Name = "sdc37";
            this.sdc37.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc37.Size = new System.Drawing.Size(30, 30);
            this.sdc37.TabIndex = 60;
            this.sdc37.Text = "";
            // 
            // sdc81
            // 
            this.sdc81.AllowSpace = false;
            this.sdc81.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc81.Location = new System.Drawing.Point(8, 283);
            this.sdc81.MaxLength = 1;
            this.sdc81.Multiline = false;
            this.sdc81.Name = "sdc81";
            this.sdc81.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc81.Size = new System.Drawing.Size(30, 30);
            this.sdc81.TabIndex = 21;
            this.sdc81.Text = "";
            // 
            // sdc29
            // 
            this.sdc29.AllowSpace = false;
            this.sdc29.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc29.Location = new System.Drawing.Point(312, 51);
            this.sdc29.MaxLength = 1;
            this.sdc29.Multiline = false;
            this.sdc29.Name = "sdc29";
            this.sdc29.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc29.Size = new System.Drawing.Size(30, 30);
            this.sdc29.TabIndex = 59;
            this.sdc29.Text = "";
            // 
            // sdc82
            // 
            this.sdc82.AllowSpace = false;
            this.sdc82.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc82.Location = new System.Drawing.Point(44, 283);
            this.sdc82.MaxLength = 1;
            this.sdc82.Multiline = false;
            this.sdc82.Name = "sdc82";
            this.sdc82.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc82.Size = new System.Drawing.Size(30, 30);
            this.sdc82.TabIndex = 22;
            this.sdc82.Text = "";
            // 
            // sdc28
            // 
            this.sdc28.AllowSpace = false;
            this.sdc28.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc28.Location = new System.Drawing.Point(276, 51);
            this.sdc28.MaxLength = 1;
            this.sdc28.Multiline = false;
            this.sdc28.Name = "sdc28";
            this.sdc28.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc28.Size = new System.Drawing.Size(30, 30);
            this.sdc28.TabIndex = 58;
            this.sdc28.Text = "";
            // 
            // sdc83
            // 
            this.sdc83.AllowSpace = false;
            this.sdc83.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc83.Location = new System.Drawing.Point(80, 283);
            this.sdc83.MaxLength = 1;
            this.sdc83.Multiline = false;
            this.sdc83.Name = "sdc83";
            this.sdc83.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc83.Size = new System.Drawing.Size(30, 30);
            this.sdc83.TabIndex = 23;
            this.sdc83.Text = "";
            // 
            // sdc27
            // 
            this.sdc27.AllowSpace = false;
            this.sdc27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc27.Location = new System.Drawing.Point(240, 51);
            this.sdc27.MaxLength = 1;
            this.sdc27.Multiline = false;
            this.sdc27.Name = "sdc27";
            this.sdc27.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc27.Size = new System.Drawing.Size(30, 30);
            this.sdc27.TabIndex = 57;
            this.sdc27.Text = "";
            // 
            // sdc91
            // 
            this.sdc91.AllowSpace = false;
            this.sdc91.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc91.Location = new System.Drawing.Point(8, 319);
            this.sdc91.MaxLength = 1;
            this.sdc91.Multiline = false;
            this.sdc91.Name = "sdc91";
            this.sdc91.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc91.Size = new System.Drawing.Size(30, 30);
            this.sdc91.TabIndex = 24;
            this.sdc91.Text = "";
            // 
            // sdc19
            // 
            this.sdc19.AllowSpace = false;
            this.sdc19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc19.Location = new System.Drawing.Point(312, 15);
            this.sdc19.MaxLength = 1;
            this.sdc19.Multiline = false;
            this.sdc19.Name = "sdc19";
            this.sdc19.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc19.Size = new System.Drawing.Size(30, 30);
            this.sdc19.TabIndex = 56;
            this.sdc19.Text = "";
            // 
            // sdc92
            // 
            this.sdc92.AllowSpace = false;
            this.sdc92.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc92.Location = new System.Drawing.Point(44, 319);
            this.sdc92.MaxLength = 1;
            this.sdc92.Multiline = false;
            this.sdc92.Name = "sdc92";
            this.sdc92.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc92.Size = new System.Drawing.Size(30, 30);
            this.sdc92.TabIndex = 25;
            this.sdc92.Text = "";
            // 
            // sdc18
            // 
            this.sdc18.AllowSpace = false;
            this.sdc18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc18.Location = new System.Drawing.Point(276, 15);
            this.sdc18.MaxLength = 1;
            this.sdc18.Multiline = false;
            this.sdc18.Name = "sdc18";
            this.sdc18.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc18.Size = new System.Drawing.Size(30, 30);
            this.sdc18.TabIndex = 55;
            this.sdc18.Text = "";
            // 
            // sdc93
            // 
            this.sdc93.AllowSpace = false;
            this.sdc93.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc93.Location = new System.Drawing.Point(80, 319);
            this.sdc93.MaxLength = 1;
            this.sdc93.Multiline = false;
            this.sdc93.Name = "sdc93";
            this.sdc93.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc93.Size = new System.Drawing.Size(30, 30);
            this.sdc93.TabIndex = 26;
            this.sdc93.Text = "";
            // 
            // sdc17
            // 
            this.sdc17.AllowSpace = false;
            this.sdc17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc17.Location = new System.Drawing.Point(240, 15);
            this.sdc17.MaxLength = 1;
            this.sdc17.Multiline = false;
            this.sdc17.Name = "sdc17";
            this.sdc17.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc17.Size = new System.Drawing.Size(30, 30);
            this.sdc17.TabIndex = 54;
            this.sdc17.Text = "";
            // 
            // sdc14
            // 
            this.sdc14.AllowSpace = false;
            this.sdc14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc14.Location = new System.Drawing.Point(124, 15);
            this.sdc14.MaxLength = 1;
            this.sdc14.Multiline = false;
            this.sdc14.Name = "sdc14";
            this.sdc14.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc14.Size = new System.Drawing.Size(30, 30);
            this.sdc14.TabIndex = 27;
            this.sdc14.Text = "";
            // 
            // sdc96
            // 
            this.sdc96.AllowSpace = false;
            this.sdc96.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc96.Location = new System.Drawing.Point(196, 319);
            this.sdc96.MaxLength = 1;
            this.sdc96.Multiline = false;
            this.sdc96.Name = "sdc96";
            this.sdc96.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc96.Size = new System.Drawing.Size(30, 30);
            this.sdc96.TabIndex = 53;
            this.sdc96.Text = "";
            // 
            // sdc15
            // 
            this.sdc15.AllowSpace = false;
            this.sdc15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc15.Location = new System.Drawing.Point(160, 15);
            this.sdc15.MaxLength = 1;
            this.sdc15.Multiline = false;
            this.sdc15.Name = "sdc15";
            this.sdc15.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc15.Size = new System.Drawing.Size(30, 30);
            this.sdc15.TabIndex = 28;
            this.sdc15.Text = "";
            // 
            // sdc95
            // 
            this.sdc95.AllowSpace = false;
            this.sdc95.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc95.Location = new System.Drawing.Point(160, 319);
            this.sdc95.MaxLength = 1;
            this.sdc95.Multiline = false;
            this.sdc95.Name = "sdc95";
            this.sdc95.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc95.Size = new System.Drawing.Size(30, 30);
            this.sdc95.TabIndex = 52;
            this.sdc95.Text = "";
            // 
            // sdc16
            // 
            this.sdc16.AllowSpace = false;
            this.sdc16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc16.Location = new System.Drawing.Point(196, 15);
            this.sdc16.MaxLength = 1;
            this.sdc16.Multiline = false;
            this.sdc16.Name = "sdc16";
            this.sdc16.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc16.Size = new System.Drawing.Size(30, 30);
            this.sdc16.TabIndex = 29;
            this.sdc16.Text = "";
            // 
            // sdc94
            // 
            this.sdc94.AllowSpace = false;
            this.sdc94.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc94.Location = new System.Drawing.Point(124, 319);
            this.sdc94.MaxLength = 1;
            this.sdc94.Multiline = false;
            this.sdc94.Name = "sdc94";
            this.sdc94.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc94.Size = new System.Drawing.Size(30, 30);
            this.sdc94.TabIndex = 51;
            this.sdc94.Text = "";
            // 
            // sdc24
            // 
            this.sdc24.AllowSpace = false;
            this.sdc24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc24.Location = new System.Drawing.Point(124, 51);
            this.sdc24.MaxLength = 1;
            this.sdc24.Multiline = false;
            this.sdc24.Name = "sdc24";
            this.sdc24.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc24.Size = new System.Drawing.Size(30, 30);
            this.sdc24.TabIndex = 30;
            this.sdc24.Text = "";
            // 
            // sdc86
            // 
            this.sdc86.AllowSpace = false;
            this.sdc86.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc86.Location = new System.Drawing.Point(196, 283);
            this.sdc86.MaxLength = 1;
            this.sdc86.Multiline = false;
            this.sdc86.Name = "sdc86";
            this.sdc86.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc86.Size = new System.Drawing.Size(30, 30);
            this.sdc86.TabIndex = 50;
            this.sdc86.Text = "";
            // 
            // sdc26
            // 
            this.sdc26.AllowSpace = false;
            this.sdc26.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc26.Location = new System.Drawing.Point(196, 51);
            this.sdc26.MaxLength = 1;
            this.sdc26.Multiline = false;
            this.sdc26.Name = "sdc26";
            this.sdc26.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc26.Size = new System.Drawing.Size(30, 30);
            this.sdc26.TabIndex = 32;
            this.sdc26.Text = "";
            // 
            // sdc85
            // 
            this.sdc85.AllowSpace = false;
            this.sdc85.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc85.Location = new System.Drawing.Point(160, 283);
            this.sdc85.MaxLength = 1;
            this.sdc85.Multiline = false;
            this.sdc85.Name = "sdc85";
            this.sdc85.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc85.Size = new System.Drawing.Size(30, 30);
            this.sdc85.TabIndex = 49;
            this.sdc85.Text = "";
            // 
            // sdc34
            // 
            this.sdc34.AllowSpace = false;
            this.sdc34.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc34.Location = new System.Drawing.Point(124, 87);
            this.sdc34.MaxLength = 1;
            this.sdc34.Multiline = false;
            this.sdc34.Name = "sdc34";
            this.sdc34.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc34.Size = new System.Drawing.Size(30, 30);
            this.sdc34.TabIndex = 33;
            this.sdc34.Text = "";
            // 
            // sdc84
            // 
            this.sdc84.AllowSpace = false;
            this.sdc84.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc84.Location = new System.Drawing.Point(124, 283);
            this.sdc84.MaxLength = 1;
            this.sdc84.Multiline = false;
            this.sdc84.Name = "sdc84";
            this.sdc84.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc84.Size = new System.Drawing.Size(30, 30);
            this.sdc84.TabIndex = 48;
            this.sdc84.Text = "";
            // 
            // sdc35
            // 
            this.sdc35.AllowSpace = false;
            this.sdc35.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc35.Location = new System.Drawing.Point(160, 87);
            this.sdc35.MaxLength = 1;
            this.sdc35.Multiline = false;
            this.sdc35.Name = "sdc35";
            this.sdc35.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc35.Size = new System.Drawing.Size(30, 30);
            this.sdc35.TabIndex = 34;
            this.sdc35.Text = "";
            // 
            // sdc76
            // 
            this.sdc76.AllowSpace = false;
            this.sdc76.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc76.Location = new System.Drawing.Point(196, 247);
            this.sdc76.MaxLength = 1;
            this.sdc76.Multiline = false;
            this.sdc76.Name = "sdc76";
            this.sdc76.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc76.Size = new System.Drawing.Size(30, 30);
            this.sdc76.TabIndex = 47;
            this.sdc76.Text = "";
            // 
            // sdc36
            // 
            this.sdc36.AllowSpace = false;
            this.sdc36.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc36.Location = new System.Drawing.Point(196, 87);
            this.sdc36.MaxLength = 1;
            this.sdc36.Multiline = false;
            this.sdc36.Name = "sdc36";
            this.sdc36.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc36.Size = new System.Drawing.Size(30, 30);
            this.sdc36.TabIndex = 35;
            this.sdc36.Text = "";
            // 
            // sdc75
            // 
            this.sdc75.AllowSpace = false;
            this.sdc75.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc75.Location = new System.Drawing.Point(160, 247);
            this.sdc75.MaxLength = 1;
            this.sdc75.Multiline = false;
            this.sdc75.Name = "sdc75";
            this.sdc75.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc75.Size = new System.Drawing.Size(30, 30);
            this.sdc75.TabIndex = 46;
            this.sdc75.Text = "";
            // 
            // sdc44
            // 
            this.sdc44.AllowSpace = false;
            this.sdc44.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc44.Location = new System.Drawing.Point(124, 131);
            this.sdc44.MaxLength = 1;
            this.sdc44.Multiline = false;
            this.sdc44.Name = "sdc44";
            this.sdc44.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc44.Size = new System.Drawing.Size(30, 30);
            this.sdc44.TabIndex = 36;
            this.sdc44.Text = "";
            // 
            // sdc74
            // 
            this.sdc74.AllowSpace = false;
            this.sdc74.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc74.Location = new System.Drawing.Point(124, 247);
            this.sdc74.MaxLength = 1;
            this.sdc74.Multiline = false;
            this.sdc74.Name = "sdc74";
            this.sdc74.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc74.Size = new System.Drawing.Size(30, 30);
            this.sdc74.TabIndex = 45;
            this.sdc74.Text = "";
            // 
            // sdc45
            // 
            this.sdc45.AllowSpace = false;
            this.sdc45.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc45.Location = new System.Drawing.Point(160, 131);
            this.sdc45.MaxLength = 1;
            this.sdc45.Multiline = false;
            this.sdc45.Name = "sdc45";
            this.sdc45.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc45.Size = new System.Drawing.Size(30, 30);
            this.sdc45.TabIndex = 37;
            this.sdc45.Text = "";
            // 
            // sdc66
            // 
            this.sdc66.AllowSpace = false;
            this.sdc66.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc66.Location = new System.Drawing.Point(196, 203);
            this.sdc66.MaxLength = 1;
            this.sdc66.Multiline = false;
            this.sdc66.Name = "sdc66";
            this.sdc66.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc66.Size = new System.Drawing.Size(30, 30);
            this.sdc66.TabIndex = 44;
            this.sdc66.Text = "";
            // 
            // sdc46
            // 
            this.sdc46.AllowSpace = false;
            this.sdc46.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc46.Location = new System.Drawing.Point(196, 131);
            this.sdc46.MaxLength = 1;
            this.sdc46.Multiline = false;
            this.sdc46.Name = "sdc46";
            this.sdc46.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc46.Size = new System.Drawing.Size(30, 30);
            this.sdc46.TabIndex = 38;
            this.sdc46.Text = "";
            // 
            // sdc65
            // 
            this.sdc65.AllowSpace = false;
            this.sdc65.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc65.Location = new System.Drawing.Point(160, 203);
            this.sdc65.MaxLength = 1;
            this.sdc65.Multiline = false;
            this.sdc65.Name = "sdc65";
            this.sdc65.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc65.Size = new System.Drawing.Size(30, 30);
            this.sdc65.TabIndex = 43;
            this.sdc65.Text = "";
            // 
            // sdc54
            // 
            this.sdc54.AllowSpace = false;
            this.sdc54.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc54.Location = new System.Drawing.Point(124, 167);
            this.sdc54.MaxLength = 1;
            this.sdc54.Multiline = false;
            this.sdc54.Name = "sdc54";
            this.sdc54.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc54.Size = new System.Drawing.Size(30, 30);
            this.sdc54.TabIndex = 39;
            this.sdc54.Text = "";
            // 
            // sdc64
            // 
            this.sdc64.AllowSpace = false;
            this.sdc64.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc64.Location = new System.Drawing.Point(124, 203);
            this.sdc64.MaxLength = 1;
            this.sdc64.Multiline = false;
            this.sdc64.Name = "sdc64";
            this.sdc64.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc64.Size = new System.Drawing.Size(30, 30);
            this.sdc64.TabIndex = 42;
            this.sdc64.Text = "";
            // 
            // sdc55
            // 
            this.sdc55.AllowSpace = false;
            this.sdc55.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc55.Location = new System.Drawing.Point(160, 167);
            this.sdc55.MaxLength = 1;
            this.sdc55.Multiline = false;
            this.sdc55.Name = "sdc55";
            this.sdc55.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc55.Size = new System.Drawing.Size(30, 30);
            this.sdc55.TabIndex = 40;
            this.sdc55.Text = "";
            // 
            // sdc56
            // 
            this.sdc56.AllowSpace = false;
            this.sdc56.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdc56.Location = new System.Drawing.Point(196, 167);
            this.sdc56.MaxLength = 1;
            this.sdc56.Multiline = false;
            this.sdc56.Name = "sdc56";
            this.sdc56.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.sdc56.Size = new System.Drawing.Size(30, 30);
            this.sdc56.TabIndex = 41;
            this.sdc56.Text = "";
            // 
            // Main_MenuStrip
            // 
            this.Main_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.iOToolStripMenuItem});
            this.Main_MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.Main_MenuStrip.Name = "Main_MenuStrip";
            this.Main_MenuStrip.Size = new System.Drawing.Size(374, 24);
            this.Main_MenuStrip.TabIndex = 83;
            this.Main_MenuStrip.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // fillToolStripMenuItem
            // 
            this.fillToolStripMenuItem.Name = "fillToolStripMenuItem";
            this.fillToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fillToolStripMenuItem.Text = "Fill";
            this.fillToolStripMenuItem.Click += new System.EventHandler(this.fillToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Exit_Programm);
            // 
            // iOToolStripMenuItem
            // 
            this.iOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.writeToolStripMenuItem});
            this.iOToolStripMenuItem.Name = "iOToolStripMenuItem";
            this.iOToolStripMenuItem.Size = new System.Drawing.Size(31, 20);
            this.iOToolStripMenuItem.Text = "IO";
            // 
            // writeToolStripMenuItem
            // 
            this.writeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IOcSVToolStripMenuItem});
            this.writeToolStripMenuItem.Name = "writeToolStripMenuItem";
            this.writeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.writeToolStripMenuItem.Text = "Write";
            // 
            // cSVToolStripMenuItem
            // 
            this.IOcSVToolStripMenuItem.Name = "IOcSVToolStripMenuItem";
            this.IOcSVToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.IOcSVToolStripMenuItem.Text = "CSV";
            this.IOcSVToolStripMenuItem.Click += new System.EventHandler(this.IOcSVToolStripMenuItem_Click);
            // 
            // GameField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 416);
            this.Controls.Add(this.PlayingField);
            this.Controls.Add(this.GameMessageBox);
            this.Controls.Add(this.Main_MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.Main_MenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameField";
            this.Text = "Sudoku";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PlayingField.ResumeLayout(false);
            this.Main_MenuStrip.ResumeLayout(false);
            this.Main_MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SingleDigitCenteredTextBox sdc11;
        private SingleDigitCenteredTextBox sdc12;
        private SingleDigitCenteredTextBox sdc13;
        private SingleDigitCenteredTextBox sdc21;
        private SingleDigitCenteredTextBox sdc22;
        private SingleDigitCenteredTextBox sdc23;
        private SingleDigitCenteredTextBox sdc31;
        private SingleDigitCenteredTextBox sdc32;
        private SingleDigitCenteredTextBox sdc33;
        private SingleDigitCenteredTextBox sdc63;
        private SingleDigitCenteredTextBox sdc62;
        private SingleDigitCenteredTextBox sdc61;
        private SingleDigitCenteredTextBox sdc53;
        private SingleDigitCenteredTextBox sdc52;
        private SingleDigitCenteredTextBox sdc51;
        private SingleDigitCenteredTextBox sdc43;
        private SingleDigitCenteredTextBox sdc42;
        private SingleDigitCenteredTextBox sdc41;
        private SingleDigitCenteredTextBox sdc93;
        private SingleDigitCenteredTextBox sdc92;
        private SingleDigitCenteredTextBox sdc91;
        private SingleDigitCenteredTextBox sdc83;
        private SingleDigitCenteredTextBox sdc82;
        private SingleDigitCenteredTextBox sdc81;
        private SingleDigitCenteredTextBox sdc73;
        private SingleDigitCenteredTextBox sdc72;
        private SingleDigitCenteredTextBox sdc71;
        private SingleDigitCenteredTextBox sdc96;
        private SingleDigitCenteredTextBox sdc95;
        private SingleDigitCenteredTextBox sdc94;
        private SingleDigitCenteredTextBox sdc86;
        private SingleDigitCenteredTextBox sdc85;
        private SingleDigitCenteredTextBox sdc84;
        private SingleDigitCenteredTextBox sdc76;
        private SingleDigitCenteredTextBox sdc75;
        private SingleDigitCenteredTextBox sdc74;
        private SingleDigitCenteredTextBox sdc66;
        private SingleDigitCenteredTextBox sdc65;
        private SingleDigitCenteredTextBox sdc64;
        private SingleDigitCenteredTextBox sdc56;
        private SingleDigitCenteredTextBox sdc55;
        private SingleDigitCenteredTextBox sdc54;
        private SingleDigitCenteredTextBox sdc46;
        private SingleDigitCenteredTextBox sdc45;
        private SingleDigitCenteredTextBox sdc44;
        private SingleDigitCenteredTextBox sdc36;
        private SingleDigitCenteredTextBox sdc35;
        private SingleDigitCenteredTextBox sdc34;
        private SingleDigitCenteredTextBox sdc26;
        private SingleDigitCenteredTextBox sdc25;
        private SingleDigitCenteredTextBox sdc24;
        private SingleDigitCenteredTextBox sdc16;
        private SingleDigitCenteredTextBox sdc15;
        private SingleDigitCenteredTextBox sdc14;
        private SingleDigitCenteredTextBox sdc99;
        private SingleDigitCenteredTextBox sdc98;
        private SingleDigitCenteredTextBox sdc97;
        private SingleDigitCenteredTextBox sdc89;
        private SingleDigitCenteredTextBox sdc88;
        private SingleDigitCenteredTextBox sdc87;
        private SingleDigitCenteredTextBox sdc79;
        private SingleDigitCenteredTextBox sdc78;
        private SingleDigitCenteredTextBox sdc77;
        private SingleDigitCenteredTextBox sdc69;
        private SingleDigitCenteredTextBox sdc68;
        private SingleDigitCenteredTextBox sdc67;
        private SingleDigitCenteredTextBox sdc59;
        private SingleDigitCenteredTextBox sdc58;
        private SingleDigitCenteredTextBox sdc57;
        private SingleDigitCenteredTextBox sdc49;
        private SingleDigitCenteredTextBox sdc48;
        private SingleDigitCenteredTextBox sdc47;
        private SingleDigitCenteredTextBox sdc39;
        private SingleDigitCenteredTextBox sdc38;
        private SingleDigitCenteredTextBox sdc37;
        private SingleDigitCenteredTextBox sdc29;
        private SingleDigitCenteredTextBox sdc28;
        private SingleDigitCenteredTextBox sdc27;
        private SingleDigitCenteredTextBox sdc19;
        private SingleDigitCenteredTextBox sdc18;
        private SingleDigitCenteredTextBox sdc17;
        private GroupBox PlayingField;
        private TextBox GameMessageBox;
        private MenuStrip Main_MenuStrip;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem fillToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem iOToolStripMenuItem;
        private ToolStripMenuItem writeToolStripMenuItem;
        private ToolStripMenuItem IOcSVToolStripMenuItem;
    }
}

