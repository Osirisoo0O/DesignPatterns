using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new iPhone();

            Decorator iPhoneWithSticker = new Sticker(phone);
            iPhoneWithSticker.Print();
            Console.WriteLine("-----------------");

            Decorator iPhoneWithAccessories = new Accessories(phone);
            iPhoneWithAccessories.Print();
            Console.WriteLine("-----------------");


            Sticker sticker = new Sticker(phone);
            Accessories iPhoneWithStickerAndAccessoies = new Accessories(sticker);
            iPhoneWithStickerAndAccessoies.Print();
            Console.ReadLine();
        }
    }
}
