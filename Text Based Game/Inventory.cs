using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

//TODO: Make list conversion for InvPrompt method nicer, pretty garbage rn.
//TODO: Get InventorySwitch to return a custom menu prompt?

namespace Text_Based_Game
{
    class Inventory : BaseGame
    {
        public static void GameInventory(Slayers player)
        {
            //AllItems is a new list that takes everything from Items,Equipables, and Consumambles and is used for the inventory display.
            Equipables.Add("Sword");
            Items.Add("Quest Item");
            var AllItems = Items.Concat(Equipables).Concat(Consumables).ToList();
            string[] equip;
            Equipables.Add("Back");
            Consumables.Add("Back");
            equip = Equipables.ToArray();
            //Another copy of the list gets sent to the output for the inventory screen. Was resizing an array but this should be better.
            //Commenting it out to add later.
            //List<string> OutPutList = Items.ToList();
            string[] consume = Consumables.ToArray();
            string[] output;
            Console.Clear();
            bool loop = true;
            while (loop == true)
            {
                //output to send to inventory screen
                output = AllItems.ToArray();
                //Equip for equipables, certain items aren't equipable! Now I can remove certain items that I don't think should be in the equipables list.
                Menu goback = new Menu(InvPrompt(output), new[] { "Equipables","Consumables" ,"Back" });

                {
                    goback.Run(goback.SelectedIndex = 0);
                    //While Statements that manually sort items out of certain menus
                    //These are while statements in case there are multiple instances of the item for some reason.
                    //*NO LONGER NEEDED* Using Concat method, now if you want something in Equipables simply use equipables list.
                    //Lists are combined to a global list that is used
                    //while (Equipables.Contains("Egg" /*Anything else I don't want to pop up in equipables*/))
                    //{
                    //    Equipables.Remove("Egg");
                    //    equip = Equipables.ToArray();
                    //}
                    //while (Consumables.Contains("Torch"))
                    //{
                    //    Consumables.Remove("Torch");
                    //    consume = Consumables.ToArray();
                    //}
                    if (goback.SelectedIndex == 0)

                    {
                        //Menu instancating outside of the loop, allows for seemless loop putting inside will return Index back to top
                        //Not including equipables.Run inside the loop causes a endless loop hang
                        //Public global bool variable is set to false here
                        //It is set to true in the InventorySwitch in main when needed and this causes the loop to end
                        //Example, back button sets this to true so the player can actually exit the loop and go back
                        Back = false;
                        Menu equipables = new Menu(ASCII.UI(player), equip);
                        while (Back == false)
                        {
                            equipables.Run(goback.SelectedIndex);
                            switch (equipables.SelectedIndex)
                            {
                                case 0:
                                    string result0 = Equipables.ElementAt(0);
                                    Main.InventorySwitch(result0);
                                    break;
                                case 1:
                                    string result1 = Equipables.ElementAt(1);
                                    Main.InventorySwitch(result1);
                                    break;
                                case 2:
                                    string result2 = Equipables.ElementAt(2);
                                    Main.InventorySwitch(result2);
                                    break;
                                case 3:
                                    string result3 = Equipables.ElementAt(3);
                                    Main.InventorySwitch(result3);
                                    break;
                                case 4:
                                    string result4 = Equipables.ElementAt(4);
                                    Main.InventorySwitch(result4);
                                    break;

                            }
                        }
                    }
                       
                    
                    else if (goback.SelectedIndex == 1)
                    {
                        Back = false;
                        Menu consuambles = new Menu(ASCII.UI(player), consume);
                        while (Back == false)
                        {
                            consuambles.Run(consuambles.SelectedIndex);
                            switch (consuambles.SelectedIndex)
                            {
                                case 0:
                                    string result0 = Consumables.ElementAt(0);
                                    Main.InventorySwitch(result0);
                                    break;
                                case 1:
                                    string result1 = Consumables.ElementAt(1);
                                    Main.InventorySwitch(result1);
                                    break;
                                case 2:
                                    string result2 = Consumables.ElementAt(2);
                                    Main.InventorySwitch(result2);
                                    break;
                                case 3:
                                    string result3 = Consumables.ElementAt(3);
                                    Main.InventorySwitch(result3);
                                    break;
                            } 
                        }
                    }
                    else if (goback.SelectedIndex == 2)
                    {
                        loop = false;
                    }
                }
            }
        }
        public static string InvPrompt(string[] output)
        {
            string[] inv = output;
            //Simple loop that resizes the array and adds blank strings for the inventory placeholder
            //You can't display things that are not in the array so there must be something there.
            while (inv.Length < 33)
            {
                Array.Resize(ref inv, inv.Length + 1);
                inv[inv.Length - 1] = "";
            }
            while (true)
            {
                try
                {
                    return $@"
                    .-=~=-.                                                                 .-=~=-.
                    (__  _)-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-(__  _)
                    ( _ __)                                                                 (_ ___)
                    (__  _)                        Inventory:                               (_ ___)
                    (_ ___)                                                                 (_ ___)
                    (__  _)      {inv[0].PadRight(30)}       {inv[17].PadRight(13)}         (_ ___)     
                    ( _ __)      {inv[1].PadRight(30)}       {inv[18].PadRight(13)}         (_ ___)    
                    (__  _)      {inv[2].PadRight(30)}       {inv[19].PadRight(13)}         (_ ___)
                    (_ ___)      {inv[3].PadRight(30)}       {inv[20].PadRight(13)}         (_ ___)
                    (__  _)      {inv[4].PadRight(30)}       {inv[21].PadRight(13)}         (_ ___)
                    ( _ __)      {inv[5].PadRight(30)}       {inv[22].PadRight(13)}         (_ ___)
                    (__  _)      {inv[7].PadRight(30)}       {inv[23].PadRight(13)}         (_ ___)
                    (_ ___)      {inv[8].PadRight(30)}       {inv[24].PadRight(13)}         (_ ___)
                    (__  _)      {inv[9].PadRight(30)}       {inv[25].PadRight(13)}         (_ ___)
                    ( _ __)      {inv[10].PadRight(31)}      {inv[26].PadRight(13)}         (_ ___)
                    (__  _)      {inv[11].PadRight(31)}      {inv[27].PadRight(13)}         (_ ___)
                    (_ ___)      {inv[12].PadRight(31)}      {inv[28].PadRight(13)}         (_ ___)
                    (__  _)      {inv[13].PadRight(31)}      {inv[29].PadRight(13)}         (_ ___)
                    ( _ __)      {inv[14].PadRight(31)}      {inv[30].PadRight(13)}         (_ ___)
                    (__  _)      {inv[15].PadRight(31)}      {inv[31].PadRight(13)}         (_ ___)
                    ( _ __)      {inv[16].PadRight(31)}      {inv[32].PadRight(13)}         (_ ___)
                    (__  _)                                                                 (_ ___)
                    (_ ___)-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-(_ ___)
                    `-._.-'                                                                 `-._.-'
                    ";
                }

                catch (System.IndexOutOfRangeException)
                {
                    //Out of range exceptions will add a blank string in it's place
                    //Added just in case the loop were to fail for some reason
                    Array.Resize(ref inv, inv.Length + 1);
                    inv[inv.Length - 1] = "";
                    continue;
                } 
            }
        }

    }
}

