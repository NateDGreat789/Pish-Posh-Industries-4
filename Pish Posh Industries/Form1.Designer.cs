namespace Pish_Posh_Industries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titlelabel = new System.Windows.Forms.Label();
            this.givebutton = new System.Windows.Forms.Button();
            this.catchphraselabel = new System.Windows.Forms.Label();
            this.carlabel = new System.Windows.Forms.Label();
            this.companylabel = new System.Windows.Forms.Label();
            this.houselabel = new System.Windows.Forms.Label();
            this.subtotallabel = new System.Windows.Forms.Label();
            this.carinput = new System.Windows.Forms.NumericUpDown();
            this.houseinput = new System.Windows.Forms.NumericUpDown();
            this.companyinput = new System.Windows.Forms.NumericUpDown();
            this.taxlabel = new System.Windows.Forms.Label();
            this.totallabel = new System.Windows.Forms.Label();
            this.subtotaloutput = new System.Windows.Forms.Label();
            this.taxoutput = new System.Windows.Forms.Label();
            this.totaloutput = new System.Windows.Forms.Label();
            this.tenderedlabel = new System.Windows.Forms.Label();
            this.tenderedinput = new System.Windows.Forms.NumericUpDown();
            this.tenderedbutton = new System.Windows.Forms.Button();
            this.changelabel = new System.Windows.Forms.Label();
            this.changeoutput = new System.Windows.Forms.Label();
            this.printbutton = new System.Windows.Forms.Button();
            this.receiptlabel = new System.Windows.Forms.Label();
            this.morebutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenderedinput)).BeginInit();
            this.SuspendLayout();
            // 
            // titlelabel
            // 
            this.titlelabel.BackColor = System.Drawing.Color.Goldenrod;
            this.titlelabel.Font = new System.Drawing.Font("Niagara Engraved", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelabel.Location = new System.Drawing.Point(108, 9);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(353, 78);
            this.titlelabel.TabIndex = 0;
            this.titlelabel.Text = "Pish Posh Industries";
            this.titlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // givebutton
            // 
            this.givebutton.Location = new System.Drawing.Point(38, 225);
            this.givebutton.Name = "givebutton";
            this.givebutton.Size = new System.Drawing.Size(240, 35);
            this.givebutton.TabIndex = 2;
            this.givebutton.Text = "SO HOW MUCH WILL YOU DONATE?";
            this.givebutton.UseVisualStyleBackColor = true;
            this.givebutton.Click += new System.EventHandler(this.givebutton_Click);
            // 
            // catchphraselabel
            // 
            this.catchphraselabel.Location = new System.Drawing.Point(12, 89);
            this.catchphraselabel.Name = "catchphraselabel";
            this.catchphraselabel.Size = new System.Drawing.Size(309, 41);
            this.catchphraselabel.TabIndex = 3;
            this.catchphraselabel.Text = "Welcome to Pish Posh Industries, where there is such a thing as too much money! W" +
    "e have shallow code and deep pockets.";
            this.catchphraselabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carlabel
            // 
            this.carlabel.Location = new System.Drawing.Point(35, 138);
            this.carlabel.Name = "carlabel";
            this.carlabel.Size = new System.Drawing.Size(166, 19);
            this.carlabel.TabIndex = 4;
            this.carlabel.Text = "How many cars strike your fancy?";
            this.carlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // companylabel
            // 
            this.companylabel.Location = new System.Drawing.Point(35, 189);
            this.companylabel.Name = "companylabel";
            this.companylabel.Size = new System.Drawing.Size(169, 19);
            this.companylabel.TabIndex = 6;
            this.companylabel.Text = "Want a company or two?";
            this.companylabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // houselabel
            // 
            this.houselabel.Location = new System.Drawing.Point(35, 157);
            this.houselabel.Name = "houselabel";
            this.houselabel.Size = new System.Drawing.Size(187, 32);
            this.houselabel.TabIndex = 8;
            this.houselabel.Text = "We have some houses still in stock!";
            this.houselabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // subtotallabel
            // 
            this.subtotallabel.Location = new System.Drawing.Point(35, 272);
            this.subtotallabel.Name = "subtotallabel";
            this.subtotallabel.Size = new System.Drawing.Size(77, 27);
            this.subtotallabel.TabIndex = 11;
            this.subtotallabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // carinput
            // 
            this.carinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carinput.Location = new System.Drawing.Point(236, 139);
            this.carinput.Name = "carinput";
            this.carinput.Size = new System.Drawing.Size(42, 20);
            this.carinput.TabIndex = 12;
            // 
            // houseinput
            // 
            this.houseinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.houseinput.Location = new System.Drawing.Point(236, 165);
            this.houseinput.Name = "houseinput";
            this.houseinput.Size = new System.Drawing.Size(42, 20);
            this.houseinput.TabIndex = 13;
            // 
            // companyinput
            // 
            this.companyinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyinput.Location = new System.Drawing.Point(236, 191);
            this.companyinput.Name = "companyinput";
            this.companyinput.Size = new System.Drawing.Size(42, 20);
            this.companyinput.TabIndex = 14;
            // 
            // taxlabel
            // 
            this.taxlabel.Location = new System.Drawing.Point(35, 299);
            this.taxlabel.Name = "taxlabel";
            this.taxlabel.Size = new System.Drawing.Size(77, 27);
            this.taxlabel.TabIndex = 15;
            this.taxlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totallabel
            // 
            this.totallabel.Location = new System.Drawing.Point(35, 326);
            this.totallabel.Name = "totallabel";
            this.totallabel.Size = new System.Drawing.Size(77, 27);
            this.totallabel.TabIndex = 16;
            this.totallabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // subtotaloutput
            // 
            this.subtotaloutput.Location = new System.Drawing.Point(104, 272);
            this.subtotaloutput.Name = "subtotaloutput";
            this.subtotaloutput.Size = new System.Drawing.Size(174, 27);
            this.subtotaloutput.TabIndex = 17;
            this.subtotaloutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taxoutput
            // 
            this.taxoutput.Location = new System.Drawing.Point(101, 299);
            this.taxoutput.Name = "taxoutput";
            this.taxoutput.Size = new System.Drawing.Size(177, 27);
            this.taxoutput.TabIndex = 18;
            this.taxoutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totaloutput
            // 
            this.totaloutput.Location = new System.Drawing.Point(101, 326);
            this.totaloutput.Name = "totaloutput";
            this.totaloutput.Size = new System.Drawing.Size(177, 27);
            this.totaloutput.TabIndex = 19;
            this.totaloutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tenderedlabel
            // 
            this.tenderedlabel.Location = new System.Drawing.Point(35, 362);
            this.tenderedlabel.Name = "tenderedlabel";
            this.tenderedlabel.Size = new System.Drawing.Size(77, 19);
            this.tenderedlabel.TabIndex = 20;
            this.tenderedlabel.Text = "Tendered";
            this.tenderedlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tenderedinput
            // 
            this.tenderedinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tenderedinput.Location = new System.Drawing.Point(153, 363);
            this.tenderedinput.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.tenderedinput.Name = "tenderedinput";
            this.tenderedinput.Size = new System.Drawing.Size(125, 20);
            this.tenderedinput.TabIndex = 21;
            // 
            // tenderedbutton
            // 
            this.tenderedbutton.Location = new System.Drawing.Point(38, 389);
            this.tenderedbutton.Name = "tenderedbutton";
            this.tenderedbutton.Size = new System.Drawing.Size(240, 35);
            this.tenderedbutton.TabIndex = 22;
            this.tenderedbutton.Text = "TENDERLY TENDER PLEASE!";
            this.tenderedbutton.UseVisualStyleBackColor = true;
            this.tenderedbutton.Click += new System.EventHandler(this.tenderedbutton_Click);
            // 
            // changelabel
            // 
            this.changelabel.Location = new System.Drawing.Point(38, 436);
            this.changelabel.Name = "changelabel";
            this.changelabel.Size = new System.Drawing.Size(486, 19);
            this.changelabel.TabIndex = 23;
            this.changelabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // changeoutput
            // 
            this.changeoutput.BackColor = System.Drawing.Color.Transparent;
            this.changeoutput.Location = new System.Drawing.Point(177, 432);
            this.changeoutput.Name = "changeoutput";
            this.changeoutput.Size = new System.Drawing.Size(101, 27);
            this.changeoutput.TabIndex = 24;
            this.changeoutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // printbutton
            // 
            this.printbutton.Location = new System.Drawing.Point(38, 466);
            this.printbutton.Name = "printbutton";
            this.printbutton.Size = new System.Drawing.Size(240, 35);
            this.printbutton.TabIndex = 25;
            this.printbutton.Text = "PRINT YOUR MAGNIFICENT RECEIPT!";
            this.printbutton.UseVisualStyleBackColor = true;
            this.printbutton.Click += new System.EventHandler(this.printbutton_Click);
            // 
            // receiptlabel
            // 
            this.receiptlabel.BackColor = System.Drawing.Color.White;
            this.receiptlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.receiptlabel.Location = new System.Drawing.Point(327, 101);
            this.receiptlabel.Name = "receiptlabel";
            this.receiptlabel.Size = new System.Drawing.Size(234, 282);
            this.receiptlabel.TabIndex = 26;
            // 
            // morebutton
            // 
            this.morebutton.Location = new System.Drawing.Point(327, 389);
            this.morebutton.Name = "morebutton";
            this.morebutton.Size = new System.Drawing.Size(234, 35);
            this.morebutton.TabIndex = 27;
            this.morebutton.Text = "BUY MORE!!";
            this.morebutton.UseVisualStyleBackColor = true;
            this.morebutton.Click += new System.EventHandler(this.morebutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(327, 466);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(234, 35);
            this.exitbutton.TabIndex = 28;
            this.exitbutton.Text = "LEAVE AFTER BUYING!";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 512);
            this.Controls.Add(this.subtotaloutput);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.morebutton);
            this.Controls.Add(this.receiptlabel);
            this.Controls.Add(this.printbutton);
            this.Controls.Add(this.changeoutput);
            this.Controls.Add(this.changelabel);
            this.Controls.Add(this.tenderedbutton);
            this.Controls.Add(this.tenderedinput);
            this.Controls.Add(this.tenderedlabel);
            this.Controls.Add(this.totaloutput);
            this.Controls.Add(this.taxoutput);
            this.Controls.Add(this.totallabel);
            this.Controls.Add(this.taxlabel);
            this.Controls.Add(this.companyinput);
            this.Controls.Add(this.houseinput);
            this.Controls.Add(this.carinput);
            this.Controls.Add(this.houselabel);
            this.Controls.Add(this.companylabel);
            this.Controls.Add(this.carlabel);
            this.Controls.Add(this.catchphraselabel);
            this.Controls.Add(this.givebutton);
            this.Controls.Add(this.titlelabel);
            this.Controls.Add(this.subtotallabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pish Posh Industries Storefront";
            ((System.ComponentModel.ISupportInitialize)(this.carinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenderedinput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.Button givebutton;
        private System.Windows.Forms.Label catchphraselabel;
        private System.Windows.Forms.Label carlabel;
        private System.Windows.Forms.Label companylabel;
        private System.Windows.Forms.Label houselabel;
        private System.Windows.Forms.Label subtotallabel;
        private System.Windows.Forms.NumericUpDown carinput;
        private System.Windows.Forms.NumericUpDown houseinput;
        private System.Windows.Forms.NumericUpDown companyinput;
        private System.Windows.Forms.Label taxlabel;
        private System.Windows.Forms.Label totallabel;
        private System.Windows.Forms.Label subtotaloutput;
        private System.Windows.Forms.Label taxoutput;
        private System.Windows.Forms.Label totaloutput;
        private System.Windows.Forms.Label tenderedlabel;
        private System.Windows.Forms.NumericUpDown tenderedinput;
        private System.Windows.Forms.Button tenderedbutton;
        private System.Windows.Forms.Label changelabel;
        private System.Windows.Forms.Label changeoutput;
        private System.Windows.Forms.Button printbutton;
        private System.Windows.Forms.Label receiptlabel;
        private System.Windows.Forms.Button morebutton;
        private System.Windows.Forms.Button exitbutton;
    }
}

