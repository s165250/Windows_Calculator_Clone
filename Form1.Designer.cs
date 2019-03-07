namespace CalculatorCopy
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private static byte operationCode;
        private static double a = 0;
        private static double b = 0;
        private static double memory = 0;
        private static bool resultCalculated = false;
        private const int BACKSPACE = 8;
        private const int ENTER = 13;
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonRESULT = new System.Windows.Forms.Button();
            this.buttonPLUS = new System.Windows.Forms.Button();
            this.buttonMINUS = new System.Windows.Forms.Button();
            this.buttonINV = new System.Windows.Forms.Button();
            this.buttonMUL = new System.Windows.Forms.Button();
            this.buttonPERCENT = new System.Windows.Forms.Button();
            this.buttonDIV = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonMmin = new System.Windows.Forms.Button();
            this.buttonMplus = new System.Windows.Forms.Button();
            this.buttonMS = new System.Windows.Forms.Button();
            this.buttonMR = new System.Windows.Forms.Button();
            this.buttonMC = new System.Windows.Forms.Button();
            this.buttonSQRT = new System.Windows.Forms.Button();
            this.buttonPM = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonRET = new System.Windows.Forms.Button();
            this.numericPanel = new System.Windows.Forms.Panel();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.blaBlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blaBlaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BackgroundFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.layoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkOrangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.numericPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.numericPanel);
            this.panel1.Location = new System.Drawing.Point(12, 138);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 410);
            this.panel1.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonRESULT);
            this.panel3.Controls.Add(this.buttonPLUS);
            this.panel3.Controls.Add(this.buttonMINUS);
            this.panel3.Controls.Add(this.buttonINV);
            this.panel3.Controls.Add(this.buttonMUL);
            this.panel3.Controls.Add(this.buttonPERCENT);
            this.panel3.Controls.Add(this.buttonDIV);
            this.panel3.Location = new System.Drawing.Point(219, 135);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(138, 270);
            this.panel3.TabIndex = 2;
            // 
            // buttonRESULT
            // 
            this.buttonRESULT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRESULT.Location = new System.Drawing.Point(73, 138);
            this.buttonRESULT.Name = "buttonRESULT";
            this.buttonRESULT.Size = new System.Drawing.Size(64, 124);
            this.buttonRESULT.TabIndex = 7;
            this.buttonRESULT.Text = "=";
            this.buttonRESULT.UseVisualStyleBackColor = true;
            this.buttonRESULT.Click += new System.EventHandler(this.buttonRESULT_Click);
            // 
            // buttonPLUS
            // 
            this.buttonPLUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPLUS.Location = new System.Drawing.Point(4, 202);
            this.buttonPLUS.Name = "buttonPLUS";
            this.buttonPLUS.Size = new System.Drawing.Size(64, 60);
            this.buttonPLUS.TabIndex = 6;
            this.buttonPLUS.Text = "+";
            this.buttonPLUS.UseVisualStyleBackColor = true;
            this.buttonPLUS.Click += new System.EventHandler(this.buttonPLUS_Click);
            // 
            // buttonMINUS
            // 
            this.buttonMINUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMINUS.Location = new System.Drawing.Point(4, 136);
            this.buttonMINUS.Name = "buttonMINUS";
            this.buttonMINUS.Size = new System.Drawing.Size(64, 60);
            this.buttonMINUS.TabIndex = 4;
            this.buttonMINUS.Text = "-";
            this.buttonMINUS.UseVisualStyleBackColor = true;
            this.buttonMINUS.Click += new System.EventHandler(this.buttonMINUS_Click);
            // 
            // buttonINV
            // 
            this.buttonINV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonINV.Location = new System.Drawing.Point(74, 72);
            this.buttonINV.Name = "buttonINV";
            this.buttonINV.Size = new System.Drawing.Size(64, 60);
            this.buttonINV.TabIndex = 3;
            this.buttonINV.Text = "1/x";
            this.buttonINV.UseVisualStyleBackColor = true;
            this.buttonINV.Click += new System.EventHandler(this.buttonINV_Click);
            // 
            // buttonMUL
            // 
            this.buttonMUL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMUL.Location = new System.Drawing.Point(3, 70);
            this.buttonMUL.Name = "buttonMUL";
            this.buttonMUL.Size = new System.Drawing.Size(64, 60);
            this.buttonMUL.TabIndex = 2;
            this.buttonMUL.Text = "*";
            this.buttonMUL.UseVisualStyleBackColor = true;
            this.buttonMUL.Click += new System.EventHandler(this.buttonMUL_Click);
            // 
            // buttonPERCENT
            // 
            this.buttonPERCENT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPERCENT.Location = new System.Drawing.Point(73, 5);
            this.buttonPERCENT.Name = "buttonPERCENT";
            this.buttonPERCENT.Size = new System.Drawing.Size(64, 60);
            this.buttonPERCENT.TabIndex = 1;
            this.buttonPERCENT.Text = "%";
            this.buttonPERCENT.UseVisualStyleBackColor = true;
            this.buttonPERCENT.Click += new System.EventHandler(this.buttonPERCENT_Click);
            // 
            // buttonDIV
            // 
            this.buttonDIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDIV.Location = new System.Drawing.Point(3, 5);
            this.buttonDIV.Name = "buttonDIV";
            this.buttonDIV.Size = new System.Drawing.Size(64, 60);
            this.buttonDIV.TabIndex = 0;
            this.buttonDIV.Text = "/";
            this.buttonDIV.UseVisualStyleBackColor = true;
            this.buttonDIV.Click += new System.EventHandler(this.buttonDIV_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonMmin);
            this.panel2.Controls.Add(this.buttonMplus);
            this.panel2.Controls.Add(this.buttonMS);
            this.panel2.Controls.Add(this.buttonMR);
            this.panel2.Controls.Add(this.buttonMC);
            this.panel2.Controls.Add(this.buttonSQRT);
            this.panel2.Controls.Add(this.buttonPM);
            this.panel2.Controls.Add(this.buttonC);
            this.panel2.Controls.Add(this.buttonCE);
            this.panel2.Controls.Add(this.buttonRET);
            this.panel2.Location = new System.Drawing.Point(5, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 136);
            this.panel2.TabIndex = 1;
            // 
            // buttonMmin
            // 
            this.buttonMmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMmin.Location = new System.Drawing.Point(287, 6);
            this.buttonMmin.Name = "buttonMmin";
            this.buttonMmin.Size = new System.Drawing.Size(64, 60);
            this.buttonMmin.TabIndex = 9;
            this.buttonMmin.Text = "M-";
            this.buttonMmin.UseVisualStyleBackColor = true;
            this.buttonMmin.Click += new System.EventHandler(this.buttonMmin_Click);
            // 
            // buttonMplus
            // 
            this.buttonMplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMplus.Location = new System.Drawing.Point(217, 6);
            this.buttonMplus.Name = "buttonMplus";
            this.buttonMplus.Size = new System.Drawing.Size(64, 60);
            this.buttonMplus.TabIndex = 8;
            this.buttonMplus.Text = "M+";
            this.buttonMplus.UseVisualStyleBackColor = true;
            this.buttonMplus.Click += new System.EventHandler(this.buttonMplus_Click);
            // 
            // buttonMS
            // 
            this.buttonMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMS.Location = new System.Drawing.Point(147, 6);
            this.buttonMS.Name = "buttonMS";
            this.buttonMS.Size = new System.Drawing.Size(64, 60);
            this.buttonMS.TabIndex = 7;
            this.buttonMS.Text = "MS";
            this.buttonMS.UseVisualStyleBackColor = true;
            this.buttonMS.Click += new System.EventHandler(this.buttonMS_Click);
            // 
            // buttonMR
            // 
            this.buttonMR.Enabled = false;
            this.buttonMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMR.Location = new System.Drawing.Point(75, 6);
            this.buttonMR.Name = "buttonMR";
            this.buttonMR.Size = new System.Drawing.Size(64, 60);
            this.buttonMR.TabIndex = 6;
            this.buttonMR.Text = "MR";
            this.buttonMR.UseVisualStyleBackColor = true;
            this.buttonMR.Click += new System.EventHandler(this.buttonMR_Click);
            // 
            // buttonMC
            // 
            this.buttonMC.Enabled = false;
            this.buttonMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMC.Location = new System.Drawing.Point(3, 6);
            this.buttonMC.Name = "buttonMC";
            this.buttonMC.Size = new System.Drawing.Size(64, 60);
            this.buttonMC.TabIndex = 5;
            this.buttonMC.Text = "MC";
            this.buttonMC.UseVisualStyleBackColor = true;
            this.buttonMC.Click += new System.EventHandler(this.buttonMC_Click);
            // 
            // buttonSQRT
            // 
            this.buttonSQRT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSQRT.Location = new System.Drawing.Point(287, 72);
            this.buttonSQRT.Name = "buttonSQRT";
            this.buttonSQRT.Size = new System.Drawing.Size(64, 60);
            this.buttonSQRT.TabIndex = 4;
            this.buttonSQRT.Text = "sqrt";
            this.buttonSQRT.UseVisualStyleBackColor = true;
            this.buttonSQRT.Click += new System.EventHandler(this.buttonSQRT_Click);
            // 
            // buttonPM
            // 
            this.buttonPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPM.Location = new System.Drawing.Point(217, 72);
            this.buttonPM.Name = "buttonPM";
            this.buttonPM.Size = new System.Drawing.Size(64, 60);
            this.buttonPM.TabIndex = 3;
            this.buttonPM.Text = "+/-";
            this.buttonPM.UseVisualStyleBackColor = true;
            this.buttonPM.Click += new System.EventHandler(this.buttonPM_Click);
            // 
            // buttonC
            // 
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonC.Location = new System.Drawing.Point(147, 72);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(64, 60);
            this.buttonC.TabIndex = 2;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCE.Location = new System.Drawing.Point(75, 73);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(64, 60);
            this.buttonCE.TabIndex = 1;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // buttonRET
            // 
            this.buttonRET.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRET.Location = new System.Drawing.Point(3, 72);
            this.buttonRET.Name = "buttonRET";
            this.buttonRET.Size = new System.Drawing.Size(64, 60);
            this.buttonRET.TabIndex = 0;
            this.buttonRET.Text = "RETURN";
            this.buttonRET.UseVisualStyleBackColor = true;
            this.buttonRET.Click += new System.EventHandler(this.buttonRET_Click);
            // 
            // numericPanel
            // 
            this.numericPanel.AutoSize = true;
            this.numericPanel.Controls.Add(this.buttonPoint);
            this.numericPanel.Controls.Add(this.button9);
            this.numericPanel.Controls.Add(this.button8);
            this.numericPanel.Controls.Add(this.button7);
            this.numericPanel.Controls.Add(this.button6);
            this.numericPanel.Controls.Add(this.button5);
            this.numericPanel.Controls.Add(this.button4);
            this.numericPanel.Controls.Add(this.button3);
            this.numericPanel.Controls.Add(this.button2);
            this.numericPanel.Controls.Add(this.button1);
            this.numericPanel.Controls.Add(this.button0);
            this.numericPanel.Location = new System.Drawing.Point(5, 135);
            this.numericPanel.Margin = new System.Windows.Forms.Padding(5);
            this.numericPanel.Name = "numericPanel";
            this.numericPanel.Size = new System.Drawing.Size(216, 270);
            this.numericPanel.TabIndex = 0;
            // 
            // buttonPoint
            // 
            this.buttonPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPoint.Location = new System.Drawing.Point(147, 202);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(64, 60);
            this.buttonPoint.TabIndex = 10;
            this.buttonPoint.Text = ".";
            this.buttonPoint.UseVisualStyleBackColor = true;
            this.buttonPoint.Click += new System.EventHandler(this.buttonPoint_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button9.Location = new System.Drawing.Point(147, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(64, 60);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.Location = new System.Drawing.Point(75, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(64, 60);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.Location = new System.Drawing.Point(3, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(64, 60);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(147, 70);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(64, 60);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(75, 70);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 60);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(3, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 60);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(147, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 60);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(75, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(3, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button0.Location = new System.Drawing.Point(3, 202);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(136, 60);
            this.button0.TabIndex = 0;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ResultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ResultBox.Location = new System.Drawing.Point(20, 36);
            this.ResultBox.MaxLength = 40;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ResultBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ResultBox.Size = new System.Drawing.Size(348, 102);
            this.ResultBox.TabIndex = 12;
            this.ResultBox.Text = "0";
            this.ResultBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ResultBox_KeyDown);
            this.ResultBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ResultBox_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blaBlaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // blaBlaToolStripMenuItem
            // 
            this.blaBlaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blaBlaToolStripMenuItem1,
            this.layoutToolStripMenuItem});
            this.blaBlaToolStripMenuItem.Name = "blaBlaToolStripMenuItem";
            this.blaBlaToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.blaBlaToolStripMenuItem.Text = "View";
            // 
            // blaBlaToolStripMenuItem1
            // 
            this.blaBlaToolStripMenuItem1.Name = "blaBlaToolStripMenuItem1";
            this.blaBlaToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.blaBlaToolStripMenuItem1.Text = "Change Background";
            this.blaBlaToolStripMenuItem1.Click += new System.EventHandler(this.blaBlaToolStripMenuItem1_Click);
            // 
            // BackgroundFileDialog
            // 
            this.BackgroundFileDialog.FileName = "Select Background";
            // 
            // layoutToolStripMenuItem
            // 
            this.layoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.darkOrangeToolStripMenuItem,
            this.blueToolStripMenuItem});
            this.layoutToolStripMenuItem.Name = "layoutToolStripMenuItem";
            this.layoutToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.layoutToolStripMenuItem.Text = "Layout";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            // 
            // darkOrangeToolStripMenuItem
            // 
            this.darkOrangeToolStripMenuItem.Name = "darkOrangeToolStripMenuItem";
            this.darkOrangeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.darkOrangeToolStripMenuItem.Text = "Dark Orange";
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.numericPanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel numericPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonMmin;
        private System.Windows.Forms.Button buttonMplus;
        private System.Windows.Forms.Button buttonMS;
        private System.Windows.Forms.Button buttonMR;
        private System.Windows.Forms.Button buttonMC;
        private System.Windows.Forms.Button buttonSQRT;
        private System.Windows.Forms.Button buttonPM;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonRET;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonRESULT;
        private System.Windows.Forms.Button buttonPLUS;
        private System.Windows.Forms.Button buttonMINUS;
        private System.Windows.Forms.Button buttonINV;
        private System.Windows.Forms.Button buttonMUL;
        private System.Windows.Forms.Button buttonPERCENT;
        private System.Windows.Forms.Button buttonDIV;
        private System.Windows.Forms.RichTextBox ResultBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem blaBlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blaBlaToolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog BackgroundFileDialog;
        private System.Windows.Forms.ToolStripMenuItem layoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkOrangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
    }
}

