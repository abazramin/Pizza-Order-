namespace Pizza_project
{
    partial class Pizza
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
            this.gSize = new System.Windows.Forms.GroupBox();
            this.rdLarg = new System.Windows.Forms.RadioButton();
            this.rdMeduim = new System.Windows.Forms.RadioButton();
            this.rdSmall = new System.Windows.Forms.RadioButton();
            this.gCurstType = new System.Windows.Forms.GroupBox();
            this.rdThinkCrust = new System.Windows.Forms.RadioButton();
            this.rdThinCurst = new System.Windows.Forms.RadioButton();
            this.title = new System.Windows.Forms.Label();
            this.gToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkExtraChees = new System.Windows.Forms.CheckBox();
            this.gWhereEat = new System.Windows.Forms.GroupBox();
            this.rdTakeOut = new System.Windows.Forms.RadioButton();
            this.rdEatin = new System.Windows.Forms.RadioButton();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            this.gOrderSummery = new System.Windows.Forms.GroupBox();
            this.lbPriceSlected = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbWhereEatSlected = new System.Windows.Forms.Label();
            this.lbWhereEat = new System.Windows.Forms.Label();
            this.lbCusrtSelect = new System.Windows.Forms.Label();
            this.lbCusrttype = new System.Windows.Forms.Label();
            this.lbSelectToppings = new System.Windows.Forms.Label();
            this.lbToppings = new System.Windows.Forms.Label();
            this.lbSizeSelcted = new System.Windows.Forms.Label();
            this.lbSummerySize = new System.Windows.Forms.Label();
            this.gSize.SuspendLayout();
            this.gCurstType.SuspendLayout();
            this.gToppings.SuspendLayout();
            this.gWhereEat.SuspendLayout();
            this.gOrderSummery.SuspendLayout();
            this.SuspendLayout();
            // 
            // gSize
            // 
            this.gSize.Controls.Add(this.rdLarg);
            this.gSize.Controls.Add(this.rdMeduim);
            this.gSize.Controls.Add(this.rdSmall);
            this.gSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gSize.Location = new System.Drawing.Point(48, 120);
            this.gSize.Margin = new System.Windows.Forms.Padding(2);
            this.gSize.Name = "gSize";
            this.gSize.Padding = new System.Windows.Forms.Padding(4, 5, 2, 2);
            this.gSize.Size = new System.Drawing.Size(180, 163);
            this.gSize.TabIndex = 0;
            this.gSize.TabStop = false;
            this.gSize.Text = "Size";
            // 
            // rdLarg
            // 
            this.rdLarg.AutoSize = true;
            this.rdLarg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdLarg.Location = new System.Drawing.Point(31, 111);
            this.rdLarg.Margin = new System.Windows.Forms.Padding(2);
            this.rdLarg.Name = "rdLarg";
            this.rdLarg.Size = new System.Drawing.Size(55, 21);
            this.rdLarg.TabIndex = 1;
            this.rdLarg.TabStop = true;
            this.rdLarg.Tag = "40";
            this.rdLarg.Text = "Larg";
            this.rdLarg.UseVisualStyleBackColor = true;
            this.rdLarg.CheckedChanged += new System.EventHandler(this.rdLarg_CheckedChanged);
            // 
            // rdMeduim
            // 
            this.rdMeduim.AutoSize = true;
            this.rdMeduim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMeduim.Location = new System.Drawing.Point(31, 71);
            this.rdMeduim.Margin = new System.Windows.Forms.Padding(2);
            this.rdMeduim.Name = "rdMeduim";
            this.rdMeduim.Size = new System.Drawing.Size(75, 21);
            this.rdMeduim.TabIndex = 2;
            this.rdMeduim.TabStop = true;
            this.rdMeduim.Tag = "30";
            this.rdMeduim.Text = "Meduim";
            this.rdMeduim.UseVisualStyleBackColor = true;
            this.rdMeduim.CheckedChanged += new System.EventHandler(this.rdMeduim_CheckedChanged);
            // 
            // rdSmall
            // 
            this.rdSmall.AutoSize = true;
            this.rdSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSmall.Location = new System.Drawing.Point(31, 37);
            this.rdSmall.Margin = new System.Windows.Forms.Padding(2);
            this.rdSmall.Name = "rdSmall";
            this.rdSmall.Size = new System.Drawing.Size(57, 19);
            this.rdSmall.TabIndex = 0;
            this.rdSmall.TabStop = true;
            this.rdSmall.Tag = "20";
            this.rdSmall.Text = "Small";
            this.rdSmall.UseVisualStyleBackColor = true;
            this.rdSmall.CheckedChanged += new System.EventHandler(this.rdSmall_CheckedChanged);
            // 
            // gCurstType
            // 
            this.gCurstType.Controls.Add(this.rdThinkCrust);
            this.gCurstType.Controls.Add(this.rdThinCurst);
            this.gCurstType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gCurstType.Location = new System.Drawing.Point(48, 317);
            this.gCurstType.Margin = new System.Windows.Forms.Padding(2);
            this.gCurstType.Name = "gCurstType";
            this.gCurstType.Padding = new System.Windows.Forms.Padding(4, 5, 2, 2);
            this.gCurstType.Size = new System.Drawing.Size(180, 110);
            this.gCurstType.TabIndex = 1;
            this.gCurstType.TabStop = false;
            this.gCurstType.Text = "Curst Type";
            // 
            // rdThinkCrust
            // 
            this.rdThinkCrust.AutoSize = true;
            this.rdThinkCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdThinkCrust.Location = new System.Drawing.Point(31, 71);
            this.rdThinkCrust.Margin = new System.Windows.Forms.Padding(2);
            this.rdThinkCrust.Name = "rdThinkCrust";
            this.rdThinkCrust.Size = new System.Drawing.Size(98, 21);
            this.rdThinkCrust.TabIndex = 2;
            this.rdThinkCrust.TabStop = true;
            this.rdThinkCrust.Tag = "10";
            this.rdThinkCrust.Text = "Think Crust";
            this.rdThinkCrust.UseVisualStyleBackColor = true;
            this.rdThinkCrust.CheckedChanged += new System.EventHandler(this.rdThinkCrust_CheckedChanged);
            // 
            // rdThinCurst
            // 
            this.rdThinCurst.AutoSize = true;
            this.rdThinCurst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdThinCurst.Location = new System.Drawing.Point(31, 37);
            this.rdThinCurst.Margin = new System.Windows.Forms.Padding(2);
            this.rdThinCurst.Name = "rdThinCurst";
            this.rdThinCurst.Size = new System.Drawing.Size(80, 19);
            this.rdThinCurst.TabIndex = 0;
            this.rdThinCurst.TabStop = true;
            this.rdThinCurst.Tag = "0";
            this.rdThinCurst.Text = "Thin Curst";
            this.rdThinCurst.UseVisualStyleBackColor = true;
            this.rdThinCurst.CheckedChanged += new System.EventHandler(this.rdThinCurst_CheckedChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Pristina", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Red;
            this.title.Location = new System.Drawing.Point(279, 22);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(417, 85);
            this.title.TabIndex = 2;
            this.title.Tag = " ";
            this.title.Text = "Make Your Pizza";
            // 
            // gToppings
            // 
            this.gToppings.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gToppings.Controls.Add(this.chkGreenPeppers);
            this.gToppings.Controls.Add(this.chkOlives);
            this.gToppings.Controls.Add(this.chkOnion);
            this.gToppings.Controls.Add(this.chkTomatoes);
            this.gToppings.Controls.Add(this.chkMushrooms);
            this.gToppings.Controls.Add(this.chkExtraChees);
            this.gToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gToppings.Location = new System.Drawing.Point(258, 130);
            this.gToppings.Margin = new System.Windows.Forms.Padding(2);
            this.gToppings.Name = "gToppings";
            this.gToppings.Padding = new System.Windows.Forms.Padding(2);
            this.gToppings.Size = new System.Drawing.Size(348, 153);
            this.gToppings.TabIndex = 3;
            this.gToppings.TabStop = false;
            this.gToppings.Text = "Toppings";
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(184, 109);
            this.chkGreenPeppers.Margin = new System.Windows.Forms.Padding(2);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(146, 26);
            this.chkGreenPeppers.TabIndex = 5;
            this.chkGreenPeppers.Tag = "5";
            this.chkGreenPeppers.Text = "GreenPeppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(184, 67);
            this.chkOlives.Margin = new System.Windows.Forms.Padding(2);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(79, 26);
            this.chkOlives.TabIndex = 4;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(184, 29);
            this.chkOnion.Margin = new System.Windows.Forms.Padding(2);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(77, 26);
            this.chkOnion.TabIndex = 3;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(21, 109);
            this.chkTomatoes.Margin = new System.Windows.Forms.Padding(2);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(109, 26);
            this.chkTomatoes.TabIndex = 2;
            this.chkTomatoes.Tag = "5";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(21, 67);
            this.chkMushrooms.Margin = new System.Windows.Forms.Padding(2);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(121, 26);
            this.chkMushrooms.TabIndex = 1;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkExtraChees
            // 
            this.chkExtraChees.AutoSize = true;
            this.chkExtraChees.Location = new System.Drawing.Point(21, 29);
            this.chkExtraChees.Margin = new System.Windows.Forms.Padding(2);
            this.chkExtraChees.Name = "chkExtraChees";
            this.chkExtraChees.Size = new System.Drawing.Size(128, 26);
            this.chkExtraChees.TabIndex = 0;
            this.chkExtraChees.TabStop = false;
            this.chkExtraChees.Tag = "5";
            this.chkExtraChees.Text = "Extra Chees";
            this.chkExtraChees.UseVisualStyleBackColor = true;
            this.chkExtraChees.CheckedChanged += new System.EventHandler(this.chkExtraChees_CheckedChanged);
            // 
            // gWhereEat
            // 
            this.gWhereEat.Controls.Add(this.rdTakeOut);
            this.gWhereEat.Controls.Add(this.rdEatin);
            this.gWhereEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gWhereEat.Location = new System.Drawing.Point(258, 317);
            this.gWhereEat.Margin = new System.Windows.Forms.Padding(2);
            this.gWhereEat.Name = "gWhereEat";
            this.gWhereEat.Padding = new System.Windows.Forms.Padding(4, 5, 2, 2);
            this.gWhereEat.Size = new System.Drawing.Size(180, 110);
            this.gWhereEat.TabIndex = 3;
            this.gWhereEat.TabStop = false;
            this.gWhereEat.Text = "Where To Eat";
            // 
            // rdTakeOut
            // 
            this.rdTakeOut.AutoSize = true;
            this.rdTakeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTakeOut.Location = new System.Drawing.Point(31, 71);
            this.rdTakeOut.Margin = new System.Windows.Forms.Padding(2);
            this.rdTakeOut.Name = "rdTakeOut";
            this.rdTakeOut.Size = new System.Drawing.Size(85, 21);
            this.rdTakeOut.TabIndex = 2;
            this.rdTakeOut.TabStop = true;
            this.rdTakeOut.Text = "Take Out";
            this.rdTakeOut.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.rdTakeOut.UseVisualStyleBackColor = true;
            // 
            // rdEatin
            // 
            this.rdEatin.AutoSize = true;
            this.rdEatin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdEatin.Location = new System.Drawing.Point(31, 37);
            this.rdEatin.Margin = new System.Windows.Forms.Padding(2);
            this.rdEatin.Name = "rdEatin";
            this.rdEatin.Size = new System.Drawing.Size(56, 19);
            this.rdEatin.TabIndex = 0;
            this.rdEatin.TabStop = true;
            this.rdEatin.Text = "Eat In";
            this.rdEatin.UseVisualStyleBackColor = true;
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPizza.Location = new System.Drawing.Point(279, 470);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(145, 47);
            this.btnOrderPizza.TabIndex = 4;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnRest
            // 
            this.btnRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRest.Location = new System.Drawing.Point(442, 470);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(145, 47);
            this.btnRest.TabIndex = 5;
            this.btnRest.Text = "Rest Form";
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // gOrderSummery
            // 
            this.gOrderSummery.Controls.Add(this.lbPriceSlected);
            this.gOrderSummery.Controls.Add(this.lbPrice);
            this.gOrderSummery.Controls.Add(this.lbWhereEatSlected);
            this.gOrderSummery.Controls.Add(this.lbWhereEat);
            this.gOrderSummery.Controls.Add(this.lbCusrtSelect);
            this.gOrderSummery.Controls.Add(this.lbCusrttype);
            this.gOrderSummery.Controls.Add(this.lbToppings);
            this.gOrderSummery.Controls.Add(this.lbSizeSelcted);
            this.gOrderSummery.Controls.Add(this.lbSummerySize);
            this.gOrderSummery.Controls.Add(this.lbSelectToppings);
            this.gOrderSummery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gOrderSummery.Location = new System.Drawing.Point(633, 137);
            this.gOrderSummery.Name = "gOrderSummery";
            this.gOrderSummery.Size = new System.Drawing.Size(297, 380);
            this.gOrderSummery.TabIndex = 6;
            this.gOrderSummery.TabStop = false;
            this.gOrderSummery.Text = "Order Summery";
            // 
            // lbPriceSlected
            // 
            this.lbPriceSlected.AutoSize = true;
            this.lbPriceSlected.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriceSlected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbPriceSlected.Location = new System.Drawing.Point(108, 305);
            this.lbPriceSlected.Name = "lbPriceSlected";
            this.lbPriceSlected.Size = new System.Drawing.Size(75, 53);
            this.lbPriceSlected.TabIndex = 9;
            this.lbPriceSlected.Text = "0$";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(21, 267);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(64, 20);
            this.lbPrice.TabIndex = 8;
            this.lbPrice.Text = "Price : ";
            // 
            // lbWhereEatSlected
            // 
            this.lbWhereEatSlected.AutoSize = true;
            this.lbWhereEatSlected.Location = new System.Drawing.Point(147, 221);
            this.lbWhereEatSlected.Name = "lbWhereEatSlected";
            this.lbWhereEatSlected.Size = new System.Drawing.Size(36, 20);
            this.lbWhereEatSlected.TabIndex = 7;
            this.lbWhereEatSlected.Text = "Any";
            // 
            // lbWhereEat
            // 
            this.lbWhereEat.AutoSize = true;
            this.lbWhereEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWhereEat.Location = new System.Drawing.Point(21, 221);
            this.lbWhereEat.Name = "lbWhereEat";
            this.lbWhereEat.Size = new System.Drawing.Size(104, 20);
            this.lbWhereEat.TabIndex = 6;
            this.lbWhereEat.Text = "Where Eat :";
            // 
            // lbCusrtSelect
            // 
            this.lbCusrtSelect.AutoSize = true;
            this.lbCusrtSelect.Location = new System.Drawing.Point(147, 175);
            this.lbCusrtSelect.Name = "lbCusrtSelect";
            this.lbCusrtSelect.Size = new System.Drawing.Size(36, 20);
            this.lbCusrtSelect.TabIndex = 5;
            this.lbCusrtSelect.Text = "Any";
            // 
            // lbCusrttype
            // 
            this.lbCusrttype.AutoSize = true;
            this.lbCusrttype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCusrttype.Location = new System.Drawing.Point(21, 175);
            this.lbCusrttype.Name = "lbCusrttype";
            this.lbCusrttype.Size = new System.Drawing.Size(110, 20);
            this.lbCusrttype.TabIndex = 4;
            this.lbCusrttype.Text = "Cusrt Type : ";
            // 
            // lbSelectToppings
            // 
            this.lbSelectToppings.AllowDrop = true;
            this.lbSelectToppings.AutoEllipsis = true;
            this.lbSelectToppings.AutoSize = true;
            this.lbSelectToppings.Location = new System.Drawing.Point(21, 117);
            this.lbSelectToppings.Name = "lbSelectToppings";
            this.lbSelectToppings.Size = new System.Drawing.Size(40, 20);
            this.lbSelectToppings.TabIndex = 3;
            this.lbSelectToppings.Text = "Any ";
            // 
            // lbToppings
            // 
            this.lbToppings.AutoSize = true;
            this.lbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToppings.Location = new System.Drawing.Point(21, 83);
            this.lbToppings.Name = "lbToppings";
            this.lbToppings.Size = new System.Drawing.Size(92, 20);
            this.lbToppings.TabIndex = 2;
            this.lbToppings.Text = "Toppings :";
            // 
            // lbSizeSelcted
            // 
            this.lbSizeSelcted.AutoSize = true;
            this.lbSizeSelcted.Location = new System.Drawing.Point(78, 37);
            this.lbSizeSelcted.Name = "lbSizeSelcted";
            this.lbSizeSelcted.Size = new System.Drawing.Size(36, 20);
            this.lbSizeSelcted.TabIndex = 1;
            this.lbSizeSelcted.Text = "Any";
            // 
            // lbSummerySize
            // 
            this.lbSummerySize.AutoSize = true;
            this.lbSummerySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSummerySize.Location = new System.Drawing.Point(21, 37);
            this.lbSummerySize.Name = "lbSummerySize";
            this.lbSummerySize.Size = new System.Drawing.Size(59, 20);
            this.lbSummerySize.TabIndex = 0;
            this.lbSummerySize.Text = "Size : ";
            // 
            // Pizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pizza_project.Properties.Resources._9824685;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 541);
            this.Controls.Add(this.gOrderSummery);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gWhereEat);
            this.Controls.Add(this.gToppings);
            this.Controls.Add(this.title);
            this.Controls.Add(this.gCurstType);
            this.Controls.Add(this.gSize);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Pizza";
            this.Text = "Form1";
            this.gSize.ResumeLayout(false);
            this.gSize.PerformLayout();
            this.gCurstType.ResumeLayout(false);
            this.gCurstType.PerformLayout();
            this.gToppings.ResumeLayout(false);
            this.gToppings.PerformLayout();
            this.gWhereEat.ResumeLayout(false);
            this.gWhereEat.PerformLayout();
            this.gOrderSummery.ResumeLayout(false);
            this.gOrderSummery.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gSize;
        private System.Windows.Forms.RadioButton rdSmall;
        private System.Windows.Forms.RadioButton rdLarg;
        private System.Windows.Forms.RadioButton rdMeduim;
        private System.Windows.Forms.GroupBox gCurstType;
        private System.Windows.Forms.RadioButton rdThinkCrust;
        private System.Windows.Forms.RadioButton rdThinCurst;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.GroupBox gToppings;
        private System.Windows.Forms.CheckBox chkExtraChees;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.GroupBox gWhereEat;
        private System.Windows.Forms.RadioButton rdTakeOut;
        private System.Windows.Forms.RadioButton rdEatin;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.GroupBox gOrderSummery;
        private System.Windows.Forms.Label lbSummerySize;
        private System.Windows.Forms.Label lbSizeSelcted;
        private System.Windows.Forms.Label lbToppings;
        private System.Windows.Forms.Label lbSelectToppings;
        private System.Windows.Forms.Label lbCusrttype;
        private System.Windows.Forms.Label lbPriceSlected;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbWhereEatSlected;
        private System.Windows.Forms.Label lbWhereEat;
        private System.Windows.Forms.Label lbCusrtSelect;
    }
}

