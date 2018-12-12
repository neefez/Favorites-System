using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FavoritesSystem
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void textBox4_TextChanged(object sender, EventArgs e)
      {

      }

      private void label5_Click(object sender, EventArgs e)
      {

      }

      private void button1_Click(object sender, EventArgs e)
      {
         string one = textBox1.Text;
         string two = textBox2.Text;
         string three = textBox3.Text;
         string four = textBox4.Text;
         string five = textBox5.Text;
         EntryControl.MakeNewSet(one, two, three, four, five);
         makeShitInvisible();
         makeShitVisible();

         updateChoices();
      }

      private void makeShitInvisible()
      {
         label1.Visible = false;
         label2.Visible = false;
         label3.Visible = false;
         label4.Visible = false;
         label5.Visible = false;
         textBox1.Visible = false;
         textBox2.Visible = false;
         textBox3.Visible = false;
         textBox4.Visible = false;
         textBox5.Visible = false;
         button1.Visible = false;
      }

      public void makeShitInvisible2()
      {
         label6.Visible = false;
         label7.Visible = false;
         choice1text.Visible = false;
         choice2text.Visible = false;
         chooses1.Visible = false;
         chooses2.Visible = false;
      }

      public void makeShitVisible()
      {
         label6.Visible = true;
         label7.Visible = true;
         choice1text.Visible = true;
         choice2text.Visible = true;
         chooses1.Visible = true;
         chooses2.Visible = true;
      }

      public void makeShitVisible2()
      {
         ranklabel1.Text = $"{EntryControl.rankedEntries[0].ranking}";
         ranklabel2.Text = $"{EntryControl.rankedEntries[1].ranking}";
         ranklabel3.Text = $"{EntryControl.rankedEntries[2].ranking}";
         ranklabel4.Text = $"{EntryControl.rankedEntries[3].ranking}";
         ranklabel5.Text = $"{EntryControl.rankedEntries[4].ranking}";

         ranklabel1.Visible = true;
         ranklabel2.Visible = true;
         ranklabel3.Visible = true;
         ranklabel4.Visible = true;
         ranklabel5.Visible = true;

         textBox1.Text = $"{EntryControl.rankedEntries[0].name}";
         textBox2.Text = $"{EntryControl.rankedEntries[1].name}";
         textBox3.Text = $"{EntryControl.rankedEntries[2].name}";
         textBox4.Text = $"{EntryControl.rankedEntries[3].name}";
         textBox5.Text = $"{EntryControl.rankedEntries[4].name}";

         textBox1.ReadOnly = true;
         textBox2.ReadOnly = true;
         textBox3.ReadOnly = true;
         textBox4.ReadOnly = true;
         textBox5.ReadOnly = true;

         textBox1.Visible = true;
         textBox2.Visible = true;
         textBox3.Visible = true;
         textBox4.Visible = true;
         textBox5.Visible = true;
      }

      public void updateChoices()
      {
         if (EntryControl.done)
         {
            makeShitVisible2();
            makeShitInvisible2();
            return;
         }

         choice1text.Text = EntryControl.EntryOne.name;
         choice2text.Text = EntryControl.EntryTwo.name;
      }

      private void chooses1_Click(object sender, EventArgs e)
      {
         EntryControl.EntryOne.ranking = EntryControl.EntryTwo.ranking;
         EntryControl.EntryOne.ranking++;
         EntryControl.ChooseEntries();
         updateChoices();
      }

      private void chooses2_Click(object sender, EventArgs e)
      {
         EntryControl.EntryTwo.ranking = EntryControl.EntryOne.ranking;
         EntryControl.EntryTwo.ranking++;
         EntryControl.ChooseEntries();
         updateChoices();
      }
   }
}
