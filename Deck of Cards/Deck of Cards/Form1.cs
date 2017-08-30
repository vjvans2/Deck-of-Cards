using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deck_of_Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public void button1_Click(object sender, EventArgs e)
        {
            List<string> deckCards = new List<string>(52);
            //clubs
            deckCards.Add("Ace of clubs");//0
            deckCards.Add("2 of clubs");//1
            deckCards.Add("3 of clubs");//2
            deckCards.Add("4 of clubs");//3
            deckCards.Add("5 of clubs");//4
            deckCards.Add("6 of clubs");//5
            deckCards.Add("7 of clubs");//6
            deckCards.Add("8 of clubs");//7
            deckCards.Add("9 of clubs");//8
            deckCards.Add("10 of clubs");//9
            deckCards.Add("Jack of clubs");//10
            deckCards.Add("Queen of clubs");//11
            deckCards.Add("King of clubs") ;//12
            // spades
            deckCards.Add("Ace of spades");//13
            deckCards.Add("2 of spades");//14
            deckCards.Add("3 of spades");//15
            deckCards.Add("4 of spades");//16
            deckCards.Add("5 of spades");//17
            deckCards.Add("6 of spades");//18
            deckCards.Add("7 of spades");//19
            deckCards.Add("8 of spades");//20
            deckCards.Add("9 of spades");//21
            deckCards.Add("10 of spades");//22
            deckCards.Add("Jack of spades");//23
            deckCards.Add("Queen of spades");//24
            deckCards.Add("King of spades");//25
            //hearts
            deckCards.Add("Ace of hearts");//26
            deckCards.Add("2 of hearts");//27
            deckCards.Add("3 of hearts");//28
            deckCards.Add("4 of hearts");//29
            deckCards.Add("5 of hearts");//30
            deckCards.Add("6 of hearts");//31
            deckCards.Add("7 of hearts");//32
            deckCards.Add("8 of hearts");//33
            deckCards.Add("9 of hearts");//34
            deckCards.Add("10 of hearts");//35
            deckCards.Add("Jack of hearts");//36
            deckCards.Add("Queen of hearts");//37
            deckCards.Add("King of hearts");//38
            //diamonds
            deckCards.Add("Ace of diamonds");//39
            deckCards.Add("2 of diamonds");//40
            deckCards.Add("3 of diamonds");//41
            deckCards.Add("4 of diamonds");//42
            deckCards.Add("5 of diamonds");//43
            deckCards.Add("6 of diamonds");//44
            deckCards.Add("7 of diamonds");//45
            deckCards.Add("8 of diamonds");//46
            deckCards.Add("9 of diamonds");//47
            deckCards.Add("10 of diamonds");//48
            deckCards.Add("Jack of diamonds");//49
            deckCards.Add("Queen of diamonds");//50
            deckCards.Add("King of diamonds");//51

            Random randomCard = new Random();
            int number1; int number2; int number3; int number4; int number5;
            number1 = randomCard.Next(0, 51);
            number2 = randomCard.Next(0, 51);
            if (number2 == number1)
            {
                number2 = randomCard.Next(0, 51);
            }
            number3 = randomCard.Next(0, 51);
            if (number3 == number2)
            {
                number3 = randomCard.Next(0, 51);
            }
            number4 = randomCard.Next(0, 51);
            if (number4 == number3)
            {
                number4 = randomCard.Next(0, 51);
            }
            number5 = randomCard.Next(0, 51);
            if (number5 == number4)
            {
                number5 = randomCard.Next(0, 51);
            }

            string firstCard; string secondCard; string thirdCard; string fourthCard; string fifthCard; string msg;
            firstCard = deckCards[number1];
            secondCard = deckCards[number2];
            thirdCard = deckCards[number3];
            fourthCard = deckCards[number4];
            fifthCard = deckCards[number5];

            List<int> cardsInHand = new List<int>(5);
            cardsInHand.Add(number1); //0 Cards In Hand Index
            cardsInHand.Add(number2); //1
            cardsInHand.Add(number3); //2
            cardsInHand.Add(number4); //3
            cardsInHand.Add(number5); //4   //if x+13 = true then pair
            cardsInHand.Sort();

            //TODO: add logic to recognize pair, flush, etc.

            msg = null;
            MessageBox.Show(
                             firstCard + "\r" +
                             secondCard + "\r" +
                             thirdCard + "\r" +
                             fourthCard + "\r" +
                             fifthCard + "\r" +
                             msg + "\r"
                             ,"Your Hand"
                             );

        }


    }
}
