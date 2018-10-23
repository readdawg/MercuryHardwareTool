namespace MercuryHardwareTool
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_Connectivity = new System.Windows.Forms.ComboBox();
            this.pan_Ethernet = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_EthernetContNum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_EthernetCont = new System.Windows.Forms.Label();
            this.lbl_EthernetSub = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_EthernetSubNum = new System.Windows.Forms.Label();
            this.pan_RS485 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_RsSub1Count = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pan_Comb = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_Com51Num = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbl_CombContNum = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbl_RsSub2Count = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbl_Com50Num = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lbl_Com52Num = new System.Windows.Forms.Label();
            this.btn_Calc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.pan_Ethernet.SuspendLayout();
            this.pan_RS485.SuspendLayout();
            this.pan_Comb.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Doors";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(118, 48);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Connectivity";
            // 
            // cbx_Connectivity
            // 
            this.cbx_Connectivity.FormattingEnabled = true;
            this.cbx_Connectivity.Items.AddRange(new object[] {
            "Please Choose a Connectivity Type",
            "Ethernet",
            "RS-485",
            "Combination"});
            this.cbx_Connectivity.Location = new System.Drawing.Point(118, 75);
            this.cbx_Connectivity.Name = "cbx_Connectivity";
            this.cbx_Connectivity.Size = new System.Drawing.Size(121, 21);
            this.cbx_Connectivity.TabIndex = 2;
            // 
            // pan_Ethernet
            // 
            this.pan_Ethernet.Controls.Add(this.lbl_EthernetSub);
            this.pan_Ethernet.Controls.Add(this.label8);
            this.pan_Ethernet.Controls.Add(this.lbl_EthernetSubNum);
            this.pan_Ethernet.Controls.Add(this.lbl_EthernetCont);
            this.pan_Ethernet.Controls.Add(this.label5);
            this.pan_Ethernet.Controls.Add(this.lbl_EthernetContNum);
            this.pan_Ethernet.Controls.Add(this.label3);
            this.pan_Ethernet.Location = new System.Drawing.Point(13, 124);
            this.pan_Ethernet.Name = "pan_Ethernet";
            this.pan_Ethernet.Size = new System.Drawing.Size(124, 64);
            this.pan_Ethernet.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ethernet";
            // 
            // lbl_EthernetContNum
            // 
            this.lbl_EthernetContNum.AutoSize = true;
            this.lbl_EthernetContNum.Location = new System.Drawing.Point(7, 21);
            this.lbl_EthernetContNum.Name = "lbl_EthernetContNum";
            this.lbl_EthernetContNum.Size = new System.Drawing.Size(13, 13);
            this.lbl_EthernetContNum.TabIndex = 1;
            this.lbl_EthernetContNum.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "x";
            // 
            // lbl_EthernetCont
            // 
            this.lbl_EthernetCont.AutoSize = true;
            this.lbl_EthernetCont.Location = new System.Drawing.Point(41, 21);
            this.lbl_EthernetCont.Name = "lbl_EthernetCont";
            this.lbl_EthernetCont.Size = new System.Drawing.Size(45, 13);
            this.lbl_EthernetCont.TabIndex = 3;
            this.lbl_EthernetCont.Text = "EP1501";
            // 
            // lbl_EthernetSub
            // 
            this.lbl_EthernetSub.AutoSize = true;
            this.lbl_EthernetSub.Location = new System.Drawing.Point(41, 36);
            this.lbl_EthernetSub.Name = "lbl_EthernetSub";
            this.lbl_EthernetSub.Size = new System.Drawing.Size(42, 13);
            this.lbl_EthernetSub.TabIndex = 6;
            this.lbl_EthernetSub.Text = "MR51e";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "x";
            // 
            // lbl_EthernetSubNum
            // 
            this.lbl_EthernetSubNum.AutoSize = true;
            this.lbl_EthernetSubNum.Location = new System.Drawing.Point(7, 36);
            this.lbl_EthernetSubNum.Name = "lbl_EthernetSubNum";
            this.lbl_EthernetSubNum.Size = new System.Drawing.Size(13, 13);
            this.lbl_EthernetSubNum.TabIndex = 4;
            this.lbl_EthernetSubNum.Text = "1";
            // 
            // pan_RS485
            // 
            this.pan_RS485.Controls.Add(this.label20);
            this.pan_RS485.Controls.Add(this.label21);
            this.pan_RS485.Controls.Add(this.lbl_RsSub2Count);
            this.pan_RS485.Controls.Add(this.label4);
            this.pan_RS485.Controls.Add(this.label6);
            this.pan_RS485.Controls.Add(this.lbl_RsSub1Count);
            this.pan_RS485.Controls.Add(this.label9);
            this.pan_RS485.Controls.Add(this.label10);
            this.pan_RS485.Controls.Add(this.label11);
            this.pan_RS485.Controls.Add(this.label12);
            this.pan_RS485.Location = new System.Drawing.Point(12, 194);
            this.pan_RS485.Name = "pan_RS485";
            this.pan_RS485.Size = new System.Drawing.Size(124, 90);
            this.pan_RS485.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "MR52";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "x";
            // 
            // lbl_RsSub1Count
            // 
            this.lbl_RsSub1Count.AutoSize = true;
            this.lbl_RsSub1Count.Location = new System.Drawing.Point(7, 36);
            this.lbl_RsSub1Count.Name = "lbl_RsSub1Count";
            this.lbl_RsSub1Count.Size = new System.Drawing.Size(13, 13);
            this.lbl_RsSub1Count.TabIndex = 4;
            this.lbl_RsSub1Count.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "EP1501";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "x";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "RS-485";
            // 
            // pan_Comb
            // 
            this.pan_Comb.Controls.Add(this.label7);
            this.pan_Comb.Controls.Add(this.label13);
            this.pan_Comb.Controls.Add(this.label22);
            this.pan_Comb.Controls.Add(this.label14);
            this.pan_Comb.Controls.Add(this.lbl_Com50Num);
            this.pan_Comb.Controls.Add(this.lbl_Com51Num);
            this.pan_Comb.Controls.Add(this.label24);
            this.pan_Comb.Controls.Add(this.label25);
            this.pan_Comb.Controls.Add(this.label16);
            this.pan_Comb.Controls.Add(this.lbl_Com52Num);
            this.pan_Comb.Controls.Add(this.label17);
            this.pan_Comb.Controls.Add(this.lbl_CombContNum);
            this.pan_Comb.Controls.Add(this.label19);
            this.pan_Comb.Location = new System.Drawing.Point(13, 290);
            this.pan_Comb.Name = "pan_Comb";
            this.pan_Comb.Size = new System.Drawing.Size(124, 123);
            this.pan_Comb.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(41, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "MR51e";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(12, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "x";
            // 
            // lbl_Com51Num
            // 
            this.lbl_Com51Num.AutoSize = true;
            this.lbl_Com51Num.Location = new System.Drawing.Point(7, 36);
            this.lbl_Com51Num.Name = "lbl_Com51Num";
            this.lbl_Com51Num.Size = new System.Drawing.Size(13, 13);
            this.lbl_Com51Num.TabIndex = 4;
            this.lbl_Com51Num.Text = "1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(41, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "EP1501";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(12, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "x";
            // 
            // lbl_CombContNum
            // 
            this.lbl_CombContNum.AutoSize = true;
            this.lbl_CombContNum.Location = new System.Drawing.Point(7, 21);
            this.lbl_CombContNum.Name = "lbl_CombContNum";
            this.lbl_CombContNum.Size = new System.Drawing.Size(13, 13);
            this.lbl_CombContNum.TabIndex = 1;
            this.lbl_CombContNum.Text = "1";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(4, 4);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Combination";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(41, 53);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 13);
            this.label20.TabIndex = 9;
            this.label20.Text = "MR50";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(22, 53);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(12, 13);
            this.label21.TabIndex = 8;
            this.label21.Text = "x";
            // 
            // lbl_RsSub2Count
            // 
            this.lbl_RsSub2Count.AutoSize = true;
            this.lbl_RsSub2Count.Location = new System.Drawing.Point(7, 53);
            this.lbl_RsSub2Count.Name = "lbl_RsSub2Count";
            this.lbl_RsSub2Count.Size = new System.Drawing.Size(13, 13);
            this.lbl_RsSub2Count.TabIndex = 7;
            this.lbl_RsSub2Count.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "MR50";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(22, 69);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(12, 13);
            this.label22.TabIndex = 14;
            this.label22.Text = "x";
            // 
            // lbl_Com50Num
            // 
            this.lbl_Com50Num.AutoSize = true;
            this.lbl_Com50Num.Location = new System.Drawing.Point(7, 69);
            this.lbl_Com50Num.Name = "lbl_Com50Num";
            this.lbl_Com50Num.Size = new System.Drawing.Size(13, 13);
            this.lbl_Com50Num.TabIndex = 13;
            this.lbl_Com50Num.Text = "1";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(41, 52);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(36, 13);
            this.label24.TabIndex = 12;
            this.label24.Text = "MR52";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(22, 52);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(12, 13);
            this.label25.TabIndex = 11;
            this.label25.Text = "x";
            // 
            // lbl_Com52Num
            // 
            this.lbl_Com52Num.AutoSize = true;
            this.lbl_Com52Num.Location = new System.Drawing.Point(7, 52);
            this.lbl_Com52Num.Name = "lbl_Com52Num";
            this.lbl_Com52Num.Size = new System.Drawing.Size(13, 13);
            this.lbl_Com52Num.TabIndex = 10;
            this.lbl_Com52Num.Text = "1";
            // 
            // btn_Calc
            // 
            this.btn_Calc.Location = new System.Drawing.Point(143, 102);
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.Size = new System.Drawing.Size(124, 23);
            this.btn_Calc.TabIndex = 9;
            this.btn_Calc.Text = "Calculate Hardware";
            this.btn_Calc.UseVisualStyleBackColor = true;
            this.btn_Calc.Click += new System.EventHandler(this.btn_Calc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 450);
            this.Controls.Add(this.btn_Calc);
            this.Controls.Add(this.pan_Comb);
            this.Controls.Add(this.pan_RS485);
            this.Controls.Add(this.pan_Ethernet);
            this.Controls.Add(this.cbx_Connectivity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculate Hardware";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.pan_Ethernet.ResumeLayout(false);
            this.pan_Ethernet.PerformLayout();
            this.pan_RS485.ResumeLayout(false);
            this.pan_RS485.PerformLayout();
            this.pan_Comb.ResumeLayout(false);
            this.pan_Comb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_Connectivity;
        private System.Windows.Forms.Panel pan_Ethernet;
        private System.Windows.Forms.Label lbl_EthernetSub;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_EthernetSubNum;
        private System.Windows.Forms.Label lbl_EthernetCont;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_EthernetContNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pan_RS485;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lbl_RsSub2Count;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_RsSub1Count;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pan_Comb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_Com50Num;
        private System.Windows.Forms.Label lbl_Com51Num;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_Com52Num;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbl_CombContNum;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn_Calc;
    }
}

