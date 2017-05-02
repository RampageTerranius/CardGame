using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Networking
{
    public partial class Form1 : Form
    {
        List <Button> DrawnCardArray;
        bool[] DrawnCardArrayFlipped;

        public Form1()
        {
            Client.AsynchronousClient.StartClient();

            //preparing the game
            DrawnCardArrayFlipped = new bool[Program.game.deck.CardDeck.GetLength()];
            for (int i = 0; i < DrawnCardArrayFlipped.Length; i++)
                DrawnCardArrayFlipped[i] = false;

            //default winform
            InitializeComponent();
        }

        private void UpdateHand()
        {
            List<Button> temp = null;
            if (DrawnCardArray != null)
               temp = DrawnCardArray;
            DrawnCardArray = new List<Button>();

            //clear up all older buttons ahead of time
            if (temp != null)
            foreach(Button b in temp)
            {
                this.Controls.Remove(b);
                b.Dispose();
            }

            for (int i = 0; i < Program.game.player.Hand.GetLength(); i++)
            {
                Button button = new Button();
                string s;
                if (!DrawnCardArrayFlipped[i])
                    s = Program.game.player.Hand.GetValueAt(i).Value.ToString().ToLower() + "_of_" + Program.game.player.Hand.GetValueAt(i).Suit.ToString().ToLower();
                else
                    s = "black_joker";

                Image image = Image.FromFile(s + ".png");
                //button.Text = Program.game.player.Hand.GetValueAt(i).Suit + "\n" + Program.game.player.Hand.GetValueAt(i).Value;
                button.Text = "";
                button.BackgroundImage = image;
                button.BackgroundImageLayout = ImageLayout.Stretch;
                button.Width = 125;
                button.Height = 182;
                button.Click += new EventHandler(ButtonClickHandle);
                
                button.Name = "CARD_" + i;
                button.Location = new Point(125 * i, 50);
                DrawnCardArray.Add(button);
            }

            //setup all things that must be drawn
            foreach(Button b in DrawnCardArray)
                this.Controls.Add(b);
        }

        private void ButtonClickHandle(object sender, EventArgs e)
        {
            Button button = (Button) sender;

            string name = button.Name;

            switch (name)
            {
                case "btn_Draw":
                    Program.game.player.Draw(Program.game.deck);//draw a card into hand
                    UpdateHand();
                    break;

                default:
                    if (name.StartsWith("CARD_"))
                    {
                        int cardnum = int.Parse(name.Split('_')[1]);
                        if (DrawnCardArrayFlipped[cardnum])
                            DrawnCardArrayFlipped[cardnum] = false;
                        else
                            DrawnCardArrayFlipped[cardnum] = true;

                        UpdateHand();
                    }
                    break;
            }
        }
    }
}
