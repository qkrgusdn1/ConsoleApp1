using System.Diagnostics.Metrics;

namespace ConsoleApp1
{
    class GiftBox
    {
        public string? Letter;
        public int Money;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GiftBox addressA = GiftBoxMaker("A친구야 잘 지내지?", 110000);
            GiftBox addressB = GiftBoxMaker("B친구야 잘 지내지?", 120000);
            GiftBox addressC = GiftBoxMaker("C친구야 잘 지내지?", 130000);
            GiftBox[] giftBoxes = new GiftBox[3];
            giftBoxes[0] = addressA;
            giftBoxes[1] = addressB;
            giftBoxes[2] = addressC;
            Console.WriteLine("giftbox Array Count : " + giftBoxes.Length);

            List<GiftBox> giftBoxList = new List<GiftBox>();
            giftBoxList.Add(addressA);
            giftBoxList.Add(addressB);
            giftBoxList.Add(addressC);
            Console.WriteLine(giftBoxList[2].Letter);
            Console.WriteLine("giftBox List Count : " + giftBoxList.Count);
        }

        static GiftBox GiftBoxMaker(string letter, int money)
        {
            GiftBox adderss = new GiftBox()
            {
                Letter = letter,
                Money = money
            };
            return adderss;
        }

    }
}
