namespace Курсовая_работа___1
{
    partial class MenuEditor
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.newPosition = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pAddButton = new System.Windows.Forms.Button();
            this.pPrise = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pCalories = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pMass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pComposition = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newOrder = new System.Windows.Forms.TabPage();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.MakingAnOrderButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.deleteFromOrderButton = new System.Windows.Forms.Button();
            this.addToOrderButton = new System.Windows.Forms.Button();
            this.orderBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuBox = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.orders = new System.Windows.Forms.TabPage();
            this.allOrdersBox = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.close = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.newPosition.SuspendLayout();
            this.panel1.SuspendLayout();
            this.newOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.orders.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.newPosition);
            this.tabControl1.Controls.Add(this.newOrder);
            this.tabControl1.Controls.Add(this.orders);
            this.tabControl1.Location = new System.Drawing.Point(0, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 454);
            this.tabControl1.TabIndex = 0;
            // 
            // newPosition
            // 
            this.newPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(97)))), ((int)(((byte)(164)))));
            this.newPosition.Controls.Add(this.panel1);
            this.newPosition.Controls.Add(this.pPrise);
            this.newPosition.Controls.Add(this.label5);
            this.newPosition.Controls.Add(this.pCalories);
            this.newPosition.Controls.Add(this.label4);
            this.newPosition.Controls.Add(this.pMass);
            this.newPosition.Controls.Add(this.label3);
            this.newPosition.Controls.Add(this.pComposition);
            this.newPosition.Controls.Add(this.label2);
            this.newPosition.Controls.Add(this.pName);
            this.newPosition.Controls.Add(this.label1);
            this.newPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPosition.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newPosition.Location = new System.Drawing.Point(4, 22);
            this.newPosition.Name = "newPosition";
            this.newPosition.Size = new System.Drawing.Size(776, 428);
            this.newPosition.TabIndex = 0;
            this.newPosition.Text = "Новое блюдо";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.pAddButton);
            this.panel1.Location = new System.Drawing.Point(-4, 361);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 77);
            this.panel1.TabIndex = 10;
            // 
            // pAddButton
            // 
            this.pAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(215)))), ((int)(((byte)(146)))));
            this.pAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pAddButton.FlatAppearance.BorderSize = 0;
            this.pAddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(65)))));
            this.pAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pAddButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(97)))), ((int)(((byte)(164)))));
            this.pAddButton.Location = new System.Drawing.Point(582, 8);
            this.pAddButton.Name = "pAddButton";
            this.pAddButton.Size = new System.Drawing.Size(157, 51);
            this.pAddButton.TabIndex = 0;
            this.pAddButton.Text = "Добавить";
            this.pAddButton.UseVisualStyleBackColor = false;
            this.pAddButton.Click += new System.EventHandler(this.pAddButton_Click);
            // 
            // pPrise
            // 
            this.pPrise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(210)))));
            this.pPrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pPrise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(37)))));
            this.pPrise.Location = new System.Drawing.Point(303, 323);
            this.pPrise.Name = "pPrise";
            this.pPrise.Size = new System.Drawing.Size(451, 32);
            this.pPrise.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(100)))));
            this.label5.Location = new System.Drawing.Point(3, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Цена блюда:";
            // 
            // pCalories
            // 
            this.pCalories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(210)))));
            this.pCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pCalories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(37)))));
            this.pCalories.Location = new System.Drawing.Point(303, 264);
            this.pCalories.Name = "pCalories";
            this.pCalories.Size = new System.Drawing.Size(451, 32);
            this.pCalories.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(100)))));
            this.label4.Location = new System.Drawing.Point(3, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Каллорийность блюда:";
            // 
            // pMass
            // 
            this.pMass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(210)))));
            this.pMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pMass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(37)))));
            this.pMass.Location = new System.Drawing.Point(303, 207);
            this.pMass.Name = "pMass";
            this.pMass.Size = new System.Drawing.Size(451, 32);
            this.pMass.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(3, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Масса блюда:";
            // 
            // pComposition
            // 
            this.pComposition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(210)))));
            this.pComposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pComposition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(37)))));
            this.pComposition.Location = new System.Drawing.Point(303, 73);
            this.pComposition.Multiline = true;
            this.pComposition.Name = "pComposition";
            this.pComposition.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pComposition.Size = new System.Drawing.Size(451, 107);
            this.pComposition.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(3, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Описание блюда:";
            // 
            // pName
            // 
            this.pName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(210)))));
            this.pName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(2)))), ((int)(((byte)(37)))));
            this.pName.Location = new System.Drawing.Point(303, 13);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(451, 32);
            this.pName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название блюда:";
            // 
            // newOrder
            // 
            this.newOrder.Controls.Add(this.numberTextBox);
            this.newOrder.Controls.Add(this.label14);
            this.newOrder.Controls.Add(this.MakingAnOrderButton);
            this.newOrder.Controls.Add(this.label13);
            this.newOrder.Controls.Add(this.label12);
            this.newOrder.Controls.Add(this.textBox5);
            this.newOrder.Controls.Add(this.label11);
            this.newOrder.Controls.Add(this.textBox4);
            this.newOrder.Controls.Add(this.label10);
            this.newOrder.Controls.Add(this.textBox3);
            this.newOrder.Controls.Add(this.label9);
            this.newOrder.Controls.Add(this.textBox2);
            this.newOrder.Controls.Add(this.label8);
            this.newOrder.Controls.Add(this.textBox1);
            this.newOrder.Controls.Add(this.label7);
            this.newOrder.Controls.Add(this.deleteFromOrderButton);
            this.newOrder.Controls.Add(this.addToOrderButton);
            this.newOrder.Controls.Add(this.orderBox);
            this.newOrder.Controls.Add(this.label6);
            this.newOrder.Controls.Add(this.menuBox);
            this.newOrder.Location = new System.Drawing.Point(4, 22);
            this.newOrder.Name = "newOrder";
            this.newOrder.Size = new System.Drawing.Size(776, 428);
            this.newOrder.TabIndex = 1;
            this.newOrder.Text = "Новый заказ";
            this.newOrder.UseVisualStyleBackColor = true;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberTextBox.Location = new System.Drawing.Point(354, 331);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(85, 30);
            this.numberTextBox.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(186, 331);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(167, 25);
            this.label14.TabIndex = 18;
            this.label14.Text = "Укажите кол-во:";
            // 
            // MakingAnOrderButton
            // 
            this.MakingAnOrderButton.Location = new System.Drawing.Point(666, 373);
            this.MakingAnOrderButton.Name = "MakingAnOrderButton";
            this.MakingAnOrderButton.Size = new System.Drawing.Size(107, 53);
            this.MakingAnOrderButton.TabIndex = 17;
            this.MakingAnOrderButton.Text = "Перейти к оформлению заказа";
            this.MakingAnOrderButton.UseVisualStyleBackColor = true;
            this.MakingAnOrderButton.Click += new System.EventHandler(this.MakingAnOrderButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(293, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(169, 25);
            this.label13.TabIndex = 16;
            this.label13.Text = "Выбраное блюдо";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(637, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 25);
            this.label12.TabIndex = 15;
            this.label12.Text = "Заказ";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(354, 244);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(203, 30);
            this.textBox5.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(186, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 25);
            this.label11.TabIndex = 13;
            this.label11.Text = "Каллорийность:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(354, 201);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(203, 30);
            this.textBox4.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(186, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "Цена:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(354, 160);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(203, 30);
            this.textBox3.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(186, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Масса:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(354, 71);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 78);
            this.textBox2.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(186, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Описание:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(354, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 30);
            this.textBox1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(186, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Название:";
            // 
            // deleteFromOrderButton
            // 
            this.deleteFromOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteFromOrderButton.Location = new System.Drawing.Point(563, 373);
            this.deleteFromOrderButton.Name = "deleteFromOrderButton";
            this.deleteFromOrderButton.Size = new System.Drawing.Size(97, 53);
            this.deleteFromOrderButton.TabIndex = 4;
            this.deleteFromOrderButton.Text = "Удалить из заказа";
            this.deleteFromOrderButton.UseVisualStyleBackColor = true;
            this.deleteFromOrderButton.Click += new System.EventHandler(this.deleteFromOrderButton_Click);
            // 
            // addToOrderButton
            // 
            this.addToOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addToOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addToOrderButton.Location = new System.Drawing.Point(298, 374);
            this.addToOrderButton.Name = "addToOrderButton";
            this.addToOrderButton.Size = new System.Drawing.Size(164, 49);
            this.addToOrderButton.TabIndex = 3;
            this.addToOrderButton.Text = "Добавть в заказ";
            this.addToOrderButton.UseVisualStyleBackColor = true;
            this.addToOrderButton.Click += new System.EventHandler(this.addToOrderButton_Click);
            // 
            // orderBox
            // 
            this.orderBox.DisplayMember = "ViewOrder";
            this.orderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderBox.FormattingEnabled = true;
            this.orderBox.ItemHeight = 18;
            this.orderBox.Location = new System.Drawing.Point(563, 26);
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new System.Drawing.Size(212, 346);
            this.orderBox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(57, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Меню";
            // 
            // menuBox
            // 
            this.menuBox.BackColor = System.Drawing.SystemColors.Info;
            this.menuBox.DisplayMember = "ViewMenu";
            this.menuBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuBox.FormattingEnabled = true;
            this.menuBox.ItemHeight = 18;
            this.menuBox.Location = new System.Drawing.Point(3, 26);
            this.menuBox.Name = "menuBox";
            this.menuBox.Size = new System.Drawing.Size(180, 400);
            this.menuBox.TabIndex = 0;
            this.menuBox.SelectedIndexChanged += new System.EventHandler(this.menuBox_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // orders
            // 
            this.orders.Controls.Add(this.textBox8);
            this.orders.Controls.Add(this.textBox7);
            this.orders.Controls.Add(this.textBox6);
            this.orders.Controls.Add(this.label18);
            this.orders.Controls.Add(this.label17);
            this.orders.Controls.Add(this.label16);
            this.orders.Controls.Add(this.label15);
            this.orders.Controls.Add(this.allOrdersBox);
            this.orders.Location = new System.Drawing.Point(4, 22);
            this.orders.Name = "orders";
            this.orders.Size = new System.Drawing.Size(776, 428);
            this.orders.TabIndex = 2;
            this.orders.Text = "Список заказов";
            this.orders.UseVisualStyleBackColor = true;
            // 
            // allOrdersBox
            // 
            this.allOrdersBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allOrdersBox.FormattingEnabled = true;
            this.allOrdersBox.ItemHeight = 20;
            this.allOrdersBox.Location = new System.Drawing.Point(26, 33);
            this.allOrdersBox.Name = "allOrdersBox";
            this.allOrdersBox.Size = new System.Drawing.Size(185, 364);
            this.allOrdersBox.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(75, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 26);
            this.label15.TabIndex = 1;
            this.label15.Text = "Заказы";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(248, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(179, 29);
            this.label16.TabIndex = 2;
            this.label16.Text = "Номер заказа:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(248, 80);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(181, 29);
            this.label17.TabIndex = 3;
            this.label17.Text = "Состав заказа:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(246, 355);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(181, 29);
            this.label18.TabIndex = 4;
            this.label18.Text = "Сумма заказа:";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(435, 33);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(154, 33);
            this.textBox6.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.Location = new System.Drawing.Point(435, 89);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(154, 246);
            this.textBox7.TabIndex = 6;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox8.Location = new System.Drawing.Point(433, 355);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(156, 33);
            this.textBox8.TabIndex = 7;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.Location = new System.Drawing.Point(750, 5);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(28, 26);
            this.close.TabIndex = 1;
            this.close.Text = "Х";
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            // 
            // MenuEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(784, 466);
            this.Controls.Add(this.close);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuEditor";
            this.Text = "MenuEditor";
            this.Load += new System.EventHandler(this.MenuEditor_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuEditor_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuEditor_MouseMove);
            this.tabControl1.ResumeLayout(false);
            this.newPosition.ResumeLayout(false);
            this.newPosition.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.newOrder.ResumeLayout(false);
            this.newOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.orders.ResumeLayout(false);
            this.orders.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage newOrder;
        private System.Windows.Forms.TabPage newPosition;
        private System.Windows.Forms.TextBox pName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pComposition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pPrise;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pCalories;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pMass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button pAddButton;
        private System.Windows.Forms.ListBox menuBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addToOrderButton;
        private System.Windows.Forms.ListBox orderBox;
        private System.Windows.Forms.Button deleteFromOrderButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button MakingAnOrderButton;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabPage orders;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox allOrdersBox;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label close;
    }
}