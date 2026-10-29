namespace pizza_projct
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
            this.label1 = new System.Windows.Forms.Label();
            this.rdSmaal = new System.Windows.Forms.RadioButton();
            this.rdmeduim = new System.Windows.Forms.RadioButton();
            this.rdLarge = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdThinCrust = new System.Windows.Forms.RadioButton();
            this.rdThinkCrust = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdEatin = new System.Windows.Forms.RadioButton();
            this.rdTakeOut = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkGreenPappers = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatos = new System.Windows.Forms.CheckBox();
            this.chkMashroum = new System.Windows.Forms.CheckBox();
            this.chkxtraCheese = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbSize = new System.Windows.Forms.Label();
            this.lbCrustType = new System.Windows.Forms.Label();
            this.lbWhereToEat = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lbToppings = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(-2, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(729, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make your Pizza";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rdSmaal
            // 
            this.rdSmaal.AutoSize = true;
            this.rdSmaal.Location = new System.Drawing.Point(6, 22);
            this.rdSmaal.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rdSmaal.Name = "rdSmaal";
            this.rdSmaal.Size = new System.Drawing.Size(50, 17);
            this.rdSmaal.TabIndex = 1;
            this.rdSmaal.TabStop = true;
            this.rdSmaal.Text = "Small";
            this.rdSmaal.UseVisualStyleBackColor = true;
            this.rdSmaal.CheckedChanged += new System.EventHandler(this.rdSmaal_CheckedChanged);
            // 
            // rdmeduim
            // 
            this.rdmeduim.AutoSize = true;
            this.rdmeduim.Location = new System.Drawing.Point(6, 63);
            this.rdmeduim.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rdmeduim.Name = "rdmeduim";
            this.rdmeduim.Size = new System.Drawing.Size(62, 17);
            this.rdmeduim.TabIndex = 2;
            this.rdmeduim.TabStop = true;
            this.rdmeduim.Text = "Meduim";
            this.rdmeduim.UseVisualStyleBackColor = true;
            this.rdmeduim.CheckedChanged += new System.EventHandler(this.rdmeduim_CheckedChanged);
            // 
            // rdLarge
            // 
            this.rdLarge.AutoSize = true;
            this.rdLarge.Location = new System.Drawing.Point(6, 100);
            this.rdLarge.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rdLarge.Name = "rdLarge";
            this.rdLarge.Size = new System.Drawing.Size(52, 17);
            this.rdLarge.TabIndex = 3;
            this.rdLarge.TabStop = true;
            this.rdLarge.Text = "Large";
            this.rdLarge.UseVisualStyleBackColor = true;
            this.rdLarge.CheckedChanged += new System.EventHandler(this.rdLarge_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdmeduim);
            this.groupBox1.Controls.Add(this.rdLarge);
            this.groupBox1.Controls.Add(this.rdSmaal);
            this.groupBox1.Location = new System.Drawing.Point(58, 93);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox1.Size = new System.Drawing.Size(111, 121);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdThinCrust
            // 
            this.rdThinCrust.AutoSize = true;
            this.rdThinCrust.Location = new System.Drawing.Point(2, 29);
            this.rdThinCrust.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rdThinCrust.Name = "rdThinCrust";
            this.rdThinCrust.Size = new System.Drawing.Size(70, 17);
            this.rdThinCrust.TabIndex = 4;
            this.rdThinCrust.TabStop = true;
            this.rdThinCrust.Text = "ThinCrust";
            this.rdThinCrust.UseVisualStyleBackColor = true;
            this.rdThinCrust.CheckedChanged += new System.EventHandler(this.rdThinCrust_CheckedChanged);
            // 
            // rdThinkCrust
            // 
            this.rdThinkCrust.AutoSize = true;
            this.rdThinkCrust.Location = new System.Drawing.Point(2, 65);
            this.rdThinkCrust.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rdThinkCrust.Name = "rdThinkCrust";
            this.rdThinkCrust.Size = new System.Drawing.Size(79, 17);
            this.rdThinkCrust.TabIndex = 5;
            this.rdThinkCrust.TabStop = true;
            this.rdThinkCrust.Text = "Think Crust";
            this.rdThinkCrust.UseVisualStyleBackColor = true;
            this.rdThinkCrust.CheckedChanged += new System.EventHandler(this.rdThinkCrust_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdThinCrust);
            this.groupBox2.Controls.Add(this.rdThinkCrust);
            this.groupBox2.Location = new System.Drawing.Point(58, 269);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox2.Size = new System.Drawing.Size(111, 91);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crust Type";
            // 
            // rdEatin
            // 
            this.rdEatin.AutoSize = true;
            this.rdEatin.Location = new System.Drawing.Point(2, 16);
            this.rdEatin.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rdEatin.Name = "rdEatin";
            this.rdEatin.Size = new System.Drawing.Size(52, 17);
            this.rdEatin.TabIndex = 7;
            this.rdEatin.TabStop = true;
            this.rdEatin.Text = "Eat in";
            this.rdEatin.UseVisualStyleBackColor = true;
            this.rdEatin.CheckedChanged += new System.EventHandler(this.rdEatin_CheckedChanged);
            // 
            // rdTakeOut
            // 
            this.rdTakeOut.AutoSize = true;
            this.rdTakeOut.Location = new System.Drawing.Point(105, 16);
            this.rdTakeOut.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rdTakeOut.Name = "rdTakeOut";
            this.rdTakeOut.Size = new System.Drawing.Size(68, 17);
            this.rdTakeOut.TabIndex = 8;
            this.rdTakeOut.TabStop = true;
            this.rdTakeOut.Text = "Take out";
            this.rdTakeOut.UseVisualStyleBackColor = true;
            this.rdTakeOut.CheckedChanged += new System.EventHandler(this.rdTakeOut_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdTakeOut);
            this.groupBox3.Controls.Add(this.rdEatin);
            this.groupBox3.Location = new System.Drawing.Point(240, 318);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox3.Size = new System.Drawing.Size(187, 42);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Where to eat";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkGreenPappers);
            this.groupBox4.Controls.Add(this.chkOlives);
            this.groupBox4.Controls.Add(this.chkOnion);
            this.groupBox4.Controls.Add(this.chkTomatos);
            this.groupBox4.Controls.Add(this.chkMashroum);
            this.groupBox4.Controls.Add(this.chkxtraCheese);
            this.groupBox4.Location = new System.Drawing.Point(242, 93);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox4.Size = new System.Drawing.Size(217, 121);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Topping";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // chkGreenPappers
            // 
            this.chkGreenPappers.AutoSize = true;
            this.chkGreenPappers.Location = new System.Drawing.Point(120, 90);
            this.chkGreenPappers.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.chkGreenPappers.Name = "chkGreenPappers";
            this.chkGreenPappers.Size = new System.Drawing.Size(97, 17);
            this.chkGreenPappers.TabIndex = 21;
            this.chkGreenPappers.Text = "Green Pappers";
            this.chkGreenPappers.UseVisualStyleBackColor = true;
            this.chkGreenPappers.CheckedChanged += new System.EventHandler(this.chkGreenPappers_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(120, 57);
            this.chkOlives.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(55, 17);
            this.chkOlives.TabIndex = 20;
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(120, 22);
            this.chkOnion.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(54, 17);
            this.chkOnion.TabIndex = 19;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTomatos
            // 
            this.chkTomatos.AutoSize = true;
            this.chkTomatos.Location = new System.Drawing.Point(8, 90);
            this.chkTomatos.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.chkTomatos.Name = "chkTomatos";
            this.chkTomatos.Size = new System.Drawing.Size(67, 17);
            this.chkTomatos.TabIndex = 18;
            this.chkTomatos.Text = "Tomatos";
            this.chkTomatos.UseVisualStyleBackColor = true;
            this.chkTomatos.CheckedChanged += new System.EventHandler(this.chkTomatos_CheckedChanged);
            // 
            // chkMashroum
            // 
            this.chkMashroum.AutoSize = true;
            this.chkMashroum.Location = new System.Drawing.Point(8, 57);
            this.chkMashroum.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.chkMashroum.Name = "chkMashroum";
            this.chkMashroum.Size = new System.Drawing.Size(75, 17);
            this.chkMashroum.TabIndex = 17;
            this.chkMashroum.Text = "Mashroum";
            this.chkMashroum.UseVisualStyleBackColor = true;
            this.chkMashroum.CheckedChanged += new System.EventHandler(this.chkMashroum_CheckedChanged);
            // 
            // chkxtraCheese
            // 
            this.chkxtraCheese.AutoSize = true;
            this.chkxtraCheese.Location = new System.Drawing.Point(9, 22);
            this.chkxtraCheese.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.chkxtraCheese.Name = "chkxtraCheese";
            this.chkxtraCheese.Size = new System.Drawing.Size(79, 17);
            this.chkxtraCheese.TabIndex = 16;
            this.chkxtraCheese.Text = "ExtraChess";
            this.chkxtraCheese.UseVisualStyleBackColor = true;
            this.chkxtraCheese.CheckedChanged += new System.EventHandler(this.chkxtraCheese_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(529, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "Order Summry";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(526, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 26);
            this.label3.TabIndex = 18;
            this.label3.Text = "Size : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(526, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 26);
            this.label4.TabIndex = 19;
            this.label4.Text = "Toppings : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(526, 269);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 26);
            this.label5.TabIndex = 20;
            this.label5.Text = "Crust Types : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(522, 308);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 26);
            this.label6.TabIndex = 21;
            this.label6.Text = "Where To Eat : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(532, 346);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 26);
            this.label7.TabIndex = 22;
            this.label7.Text = "Total Price : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(240, 393);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(79, 37);
            this.btnOrder.TabIndex = 23;
            this.btnOrder.Text = "Order Pizza";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(348, 393);
            this.button2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 37);
            this.button2.TabIndex = 24;
            this.button2.Text = "Reset Form";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbSize
            // 
            this.lbSize.Location = new System.Drawing.Point(579, 156);
            this.lbSize.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(75, 15);
            this.lbSize.TabIndex = 25;
            this.lbSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSize.Click += new System.EventHandler(this.lbSize_Click);
            // 
            // lbCrustType
            // 
            this.lbCrustType.Location = new System.Drawing.Point(634, 276);
            this.lbCrustType.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbCrustType.Name = "lbCrustType";
            this.lbCrustType.Size = new System.Drawing.Size(78, 15);
            this.lbCrustType.TabIndex = 28;
            this.lbCrustType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbWhereToEat
            // 
            this.lbWhereToEat.Location = new System.Drawing.Point(651, 315);
            this.lbWhereToEat.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbWhereToEat.Name = "lbWhereToEat";
            this.lbWhereToEat.Size = new System.Drawing.Size(67, 15);
            this.lbWhereToEat.TabIndex = 29;
            this.lbWhereToEat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Wide Latin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Green;
            this.lblPrice.Location = new System.Drawing.Point(632, 377);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(81, 53);
            this.lblPrice.TabIndex = 30;
            this.lblPrice.Text = "0";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbToppings
            // 
            this.lbToppings.AutoSize = true;
            this.lbToppings.Location = new System.Drawing.Point(577, 209);
            this.lbToppings.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbToppings.Name = "lbToppings";
            this.lbToppings.Size = new System.Drawing.Size(74, 13);
            this.lbToppings.TabIndex = 27;
            this.lbToppings.Text = "(No Toppings)";
            this.lbToppings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbToppings.Click += new System.EventHandler(this.label10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(776, 448);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lbWhereToEat);
            this.Controls.Add(this.lbCrustType);
            this.Controls.Add(this.lbToppings);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdSmaal;
        private System.Windows.Forms.RadioButton rdmeduim;
        private System.Windows.Forms.RadioButton rdLarge;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdThinCrust;
        private System.Windows.Forms.RadioButton rdThinkCrust;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdEatin;
        private System.Windows.Forms.RadioButton rdTakeOut;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbCrustType;
        private System.Windows.Forms.Label lbWhereToEat;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lbToppings;
        private System.Windows.Forms.CheckBox chkGreenPappers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomatos;
        private System.Windows.Forms.CheckBox chkMashroum;
        private System.Windows.Forms.CheckBox chkxtraCheese;
    }
}

