namespace FavoritesSystem
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
         System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Entry 1",
            "{}"}, -1);
         System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Entry 2",
            ""}, -1);
         System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "Entry 3",
            ""}, -1);
         System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "Entry 4",
            ""}, -1);
         System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "Entry 5",
            ""}, -1);
         this.listView1 = new System.Windows.Forms.ListView();
         this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.entryItself = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.textBox3 = new System.Windows.Forms.TextBox();
         this.textBox4 = new System.Windows.Forms.TextBox();
         this.textBox5 = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.button1 = new System.Windows.Forms.Button();
         this.label6 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.choice1text = new System.Windows.Forms.TextBox();
         this.choice2text = new System.Windows.Forms.TextBox();
         this.chooses1 = new System.Windows.Forms.Button();
         this.chooses2 = new System.Windows.Forms.Button();
         this.ranklabel1 = new System.Windows.Forms.Label();
         this.ranklabel2 = new System.Windows.Forms.Label();
         this.ranklabel3 = new System.Windows.Forms.Label();
         this.ranklabel4 = new System.Windows.Forms.Label();
         this.ranklabel5 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // listView1
         // 
         this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.title,
            this.entryItself});
         this.listView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         listViewItem6.StateImageIndex = 0;
         listViewItem6.ToolTipText = "Entry 1";
         listViewItem7.StateImageIndex = 0;
         listViewItem8.StateImageIndex = 0;
         listViewItem9.StateImageIndex = 0;
         listViewItem10.StateImageIndex = 0;
         this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10});
         this.listView1.Location = new System.Drawing.Point(253, 250);
         this.listView1.Name = "listView1";
         this.listView1.ShowItemToolTips = true;
         this.listView1.Size = new System.Drawing.Size(197, 129);
         this.listView1.TabIndex = 0;
         this.listView1.UseCompatibleStateImageBehavior = false;
         this.listView1.View = System.Windows.Forms.View.Details;
         this.listView1.Visible = false;
         // 
         // title
         // 
         this.title.Text = "Entry Number";
         this.title.Width = 81;
         // 
         // entryItself
         // 
         this.entryItself.Text = "Your Entry:";
         this.entryItself.Width = 112;
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(160, 26);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(100, 20);
         this.textBox1.TabIndex = 1;
         // 
         // textBox2
         // 
         this.textBox2.Location = new System.Drawing.Point(160, 65);
         this.textBox2.Name = "textBox2";
         this.textBox2.Size = new System.Drawing.Size(100, 20);
         this.textBox2.TabIndex = 2;
         // 
         // textBox3
         // 
         this.textBox3.Location = new System.Drawing.Point(160, 103);
         this.textBox3.Name = "textBox3";
         this.textBox3.Size = new System.Drawing.Size(100, 20);
         this.textBox3.TabIndex = 3;
         // 
         // textBox4
         // 
         this.textBox4.Location = new System.Drawing.Point(160, 146);
         this.textBox4.Name = "textBox4";
         this.textBox4.Size = new System.Drawing.Size(100, 20);
         this.textBox4.TabIndex = 4;
         this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
         // 
         // textBox5
         // 
         this.textBox5.Location = new System.Drawing.Point(160, 184);
         this.textBox5.Name = "textBox5";
         this.textBox5.Size = new System.Drawing.Size(100, 20);
         this.textBox5.TabIndex = 5;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(141, 29);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(13, 13);
         this.label1.TabIndex = 6;
         this.label1.Text = "1";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(141, 68);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(13, 13);
         this.label2.TabIndex = 7;
         this.label2.Text = "2";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(141, 106);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(13, 13);
         this.label3.TabIndex = 8;
         this.label3.Text = "3";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(141, 149);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(13, 13);
         this.label4.TabIndex = 9;
         this.label4.Text = "4";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(141, 184);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(13, 13);
         this.label5.TabIndex = 10;
         this.label5.Text = "5";
         this.label5.Click += new System.EventHandler(this.label5_Click);
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(304, 101);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 11;
         this.button1.Text = "done";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(66, 265);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(46, 13);
         this.label6.TabIndex = 12;
         this.label6.Text = "Choice1";
         this.label6.Visible = false;
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(141, 265);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(46, 13);
         this.label7.TabIndex = 13;
         this.label7.Text = "Choice2";
         this.label7.Visible = false;
         // 
         // choice1text
         // 
         this.choice1text.Location = new System.Drawing.Point(12, 290);
         this.choice1text.Name = "choice1text";
         this.choice1text.ReadOnly = true;
         this.choice1text.Size = new System.Drawing.Size(100, 20);
         this.choice1text.TabIndex = 14;
         this.choice1text.Visible = false;
         // 
         // choice2text
         // 
         this.choice2text.Location = new System.Drawing.Point(144, 290);
         this.choice2text.Name = "choice2text";
         this.choice2text.ReadOnly = true;
         this.choice2text.Size = new System.Drawing.Size(100, 20);
         this.choice2text.TabIndex = 15;
         this.choice2text.Visible = false;
         // 
         // chooses1
         // 
         this.chooses1.Location = new System.Drawing.Point(37, 325);
         this.chooses1.Name = "chooses1";
         this.chooses1.Size = new System.Drawing.Size(75, 23);
         this.chooses1.TabIndex = 16;
         this.chooses1.Text = "^this one";
         this.chooses1.UseVisualStyleBackColor = true;
         this.chooses1.Visible = false;
         this.chooses1.Click += new System.EventHandler(this.chooses1_Click);
         // 
         // chooses2
         // 
         this.chooses2.Location = new System.Drawing.Point(144, 325);
         this.chooses2.Name = "chooses2";
         this.chooses2.Size = new System.Drawing.Size(75, 23);
         this.chooses2.TabIndex = 17;
         this.chooses2.Text = "this one^";
         this.chooses2.UseVisualStyleBackColor = true;
         this.chooses2.Visible = false;
         this.chooses2.Click += new System.EventHandler(this.chooses2_Click);
         // 
         // ranklabel1
         // 
         this.ranklabel1.AutoSize = true;
         this.ranklabel1.Location = new System.Drawing.Point(102, 29);
         this.ranklabel1.Name = "ranklabel1";
         this.ranklabel1.Size = new System.Drawing.Size(33, 13);
         this.ranklabel1.TabIndex = 18;
         this.ranklabel1.Text = "Rank";
         this.ranklabel1.Visible = false;
         // 
         // ranklabel2
         // 
         this.ranklabel2.AutoSize = true;
         this.ranklabel2.Location = new System.Drawing.Point(102, 68);
         this.ranklabel2.Name = "ranklabel2";
         this.ranklabel2.Size = new System.Drawing.Size(33, 13);
         this.ranklabel2.TabIndex = 19;
         this.ranklabel2.Text = "Rank";
         this.ranklabel2.Visible = false;
         // 
         // ranklabel3
         // 
         this.ranklabel3.AutoSize = true;
         this.ranklabel3.Location = new System.Drawing.Point(102, 103);
         this.ranklabel3.Name = "ranklabel3";
         this.ranklabel3.Size = new System.Drawing.Size(33, 13);
         this.ranklabel3.TabIndex = 20;
         this.ranklabel3.Text = "Rank";
         this.ranklabel3.Visible = false;
         // 
         // ranklabel4
         // 
         this.ranklabel4.AutoSize = true;
         this.ranklabel4.Location = new System.Drawing.Point(102, 146);
         this.ranklabel4.Name = "ranklabel4";
         this.ranklabel4.Size = new System.Drawing.Size(33, 13);
         this.ranklabel4.TabIndex = 21;
         this.ranklabel4.Text = "Rank";
         this.ranklabel4.Visible = false;
         // 
         // ranklabel5
         // 
         this.ranklabel5.AutoSize = true;
         this.ranklabel5.Location = new System.Drawing.Point(102, 184);
         this.ranklabel5.Name = "ranklabel5";
         this.ranklabel5.Size = new System.Drawing.Size(33, 13);
         this.ranklabel5.TabIndex = 22;
         this.ranklabel5.Text = "Rank";
         this.ranklabel5.Visible = false;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(451, 382);
         this.Controls.Add(this.ranklabel5);
         this.Controls.Add(this.ranklabel4);
         this.Controls.Add(this.ranklabel3);
         this.Controls.Add(this.ranklabel2);
         this.Controls.Add(this.ranklabel1);
         this.Controls.Add(this.chooses2);
         this.Controls.Add(this.chooses1);
         this.Controls.Add(this.choice2text);
         this.Controls.Add(this.choice1text);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.textBox5);
         this.Controls.Add(this.textBox4);
         this.Controls.Add(this.textBox3);
         this.Controls.Add(this.textBox2);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.listView1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ListView listView1;
      private System.Windows.Forms.ColumnHeader title;
      private System.Windows.Forms.ColumnHeader entryItself;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.TextBox textBox2;
      private System.Windows.Forms.TextBox textBox3;
      private System.Windows.Forms.TextBox textBox4;
      private System.Windows.Forms.TextBox textBox5;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.TextBox choice1text;
      private System.Windows.Forms.TextBox choice2text;
      private System.Windows.Forms.Button chooses1;
      private System.Windows.Forms.Button chooses2;
      private System.Windows.Forms.Label ranklabel1;
      private System.Windows.Forms.Label ranklabel2;
      private System.Windows.Forms.Label ranklabel3;
      private System.Windows.Forms.Label ranklabel4;
      private System.Windows.Forms.Label ranklabel5;
   }
}

