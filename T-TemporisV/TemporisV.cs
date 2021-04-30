using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace T_TemporisV
{
    public partial class T_TemporisV : MaterialForm
    {
        private CardsManager cardsManager = new CardsManager();

        public T_TemporisV()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.BlueGrey900, Primary.Red500,
                Accent.Red400, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 2; i <= 200; i++)
            {
                startLevel_CB.Items.Add(i);
                finishLevel_CB.Items.Add(i);
            }
        }

        private void search_B_Click(object sender, EventArgs e)
        {
            export_B.Enabled = false;
            dropCards_LV.Items.Clear();
            craftCards_LV.Items.Clear();
            cardsManager.NeededCCards.Clear();
            cardsManager.NeededDCards.Clear();

            int tmp = int.Parse(finishLevel_CB.Text) - int.Parse(startLevel_CB.Text);

            cardsManager.GetCards(int.Parse(startLevel_CB.Text), int.Parse(finishLevel_CB.Text));
            foreach (var card in cardsManager.NeededCCards)
            {
                ListViewItem newItem = new ListViewItem();
                newItem.Text = card.Name;
                craftCards_LV.Items.Add(newItem);
            }
            export_B.Enabled = true;
            foreach (var card in cardsManager.NeededDCards)
            {
                ListViewItem newItem = new ListViewItem();
                newItem.Text = card.Name;
                dropCards_LV.Items.Add(newItem);
            }
        }

        private void export_B_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog= new SaveFileDialog();
            saveFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var writer = new StreamWriter(saveFileDialog.OpenFile()))
                {
                    foreach (var card in cardsManager.NeededCCards)
                    {
                        if (card.Obtention.Unknow == false)
                        foreach (var pair in card.Obtention.ItemDetails)
                        {
                            writer.WriteLine("{0};{1};", pair.Key, pair.Value);
                        }
                    }
                }
               
            }
        }
    }
}