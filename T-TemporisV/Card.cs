using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace T_TemporisV
{
    public class Card
    {
        private String color;
        private int ID;
        private int item_id;
        private String job;
        private int level;
        private string name;
        private string obt;

        private Obtention obtention;
        private String rarity;

        public Card(String name, string obt, int ID, int item_id, String rarity, String color, String job, int level)
        {
            this.name = name;
            this.obt = obt;
            this.ID = ID;
            this.item_id = item_id;
            this.rarity = rarity;
            this.color = color;
            this.job = job;
            this.level = level;
        }

        public string Obt
        {
            get => obt;
            set => obt = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public Obtention Obtention
        {
            get => obtention;
            set => obtention = value;
        }

        public int Id
        {
            get => ID;
            set => ID = value;
        }

        public int ItemId
        {
            get => item_id;
            set => item_id = value;
        }

        public string Rarity
        {
            get => rarity;
            set => rarity = value;
        }

        public string Color
        {
            get => color;
            set => color = value;
        }

        public string Job
        {
            get => job;
            set => job = value;
        }

        public int Level
        {
            get => level;
            set => level = value;
        }
    }

    public class Obtention
    {
        private bool isDrop;
        private bool unknow = false;
        public bool IsDrop
        {
            get => isDrop;
            set => isDrop = value;
        }
        public bool Unknow
        {
            get => unknow;
            set => unknow = value;
        }
        public Dictionary<string, string> ItemDetails
        {
            get => itemDetails;
            set => itemDetails = value;
        }

        private Dictionary<string, string> itemDetails;

        public Obtention(string obt)
        {
            if (obt == null)
            {
                unknow = true;
                return;
            }
            this.isDrop = obt.Contains("%");
            itemDetails = new Dictionary<string, string>();
            var item_list = obt.Replace(", ", ",").Replace(" (", "(").Split(',');
            foreach (string item in item_list)
            {
                string name = item.Split('(')[0];

                string value = item.Split('(')[1].Replace(")", "").Replace("x", "").Replace("%", "").Trim();

                try
                {
                    KeyValuePair<string, string> tmpPair = new KeyValuePair<string, string>(name, value);
                    if (itemDetails.ContainsKey(tmpPair.Key) == false)
                    {
                        itemDetails.Add(name, value);
                    }
                }
                catch (Exception e)
                {
                    MaterialMessageBox.Show(e.Message);
                }
            }
        }
    }
}