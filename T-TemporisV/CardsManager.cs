using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;

namespace T_TemporisV
{
    public class CardsManager
    {
        private readonly string cardURL =
            "https://raw.githubusercontent.com/StonyTV/dofus-temporis-v-cards/main/db.json";

        private readonly string levelURL =
            "https://raw.githubusercontent.com/StonyTV/dofus-temporis-v-cards/main/levelup.json";

        private readonly List<Card> cards = new List<Card>();

        private readonly List<Level> levels = new List<Level>();
        private Dictionary<int, Level> _levels = new Dictionary<int, Level>();
        private Dictionary<int, Card> _cards = new Dictionary<int, Card>();

        public CardsManager()
        {
            using (var w = new WebClient())
            {
                w.Encoding = Encoding.UTF8;
                var tmpJson = string.Empty;
                try
                {
                    tmpJson = w.DownloadString(levelURL);
                    var levelsData = JArray.Parse(tmpJson);
                    for (var index = 0; index < 199; index++)
                    {
                        var p = levelsData[index];

                        var newLevel = int.Parse(p["level"].ToString());
                        _levels[newLevel] = new Level(newLevel);
                        JArray cardList = JArray.Parse(p["cards"].ToString());

                        foreach (var i in cardList)
                        {
                            _levels[newLevel].CardIds.Add(int.Parse(i.ToString()));
                        }
                    }

                    tmpJson = w.DownloadString(cardURL);
                    var cardsData = JObject.Parse(tmpJson);
                    IList<JToken> cardResults = cardsData["indexDB"].Children().ToList();
                    foreach (var result in cardResults)
                    {
                        var newCard = result.ToObject<Card>();
                        if (newCard.Obt != null)
                        {
                            newCard.Obtention = new Obtention(newCard.Obt);
                        }
                        else
                        {
                            newCard.Obtention = new Obtention(null);
                        }

                        int cardId = newCard.Id;
                        _cards[cardId] = newCard;
                    }
                }
                catch (Exception e)
                {
                    MaterialMessageBox.Show(e.StackTrace);
                }
            }
        }

        public List<Card> NeededDCards { get; set; } = new List<Card>();

        public List<Card> NeededCCards { get; set; } = new List<Card>();

        public void GetCards(int start, int finish)
        {
            for (int level = start; level <= finish; level++)
            {
                foreach (var cardId in _levels[level].CardIds)
                {
                    Card cardTarget = _cards[cardId];
                    if (cardTarget.Obtention.IsDrop)
                        NeededDCards.Add(cardTarget);
                    else
                        NeededCCards.Add(cardTarget);
                }
            }
        }
    }
}