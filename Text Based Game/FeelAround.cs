using System;
using System.Collections.Generic;
using System.Text;

namespace Text_Based_Game
{
    class FeelAroundM : Main
    {
        
        public static void FeelAround()
        {
            Console.Clear();
                    string programmingQuote3 = $@"


        You start feeling around in the darkness hoping to come across something, anything, 
        that may give you a clue as to how you got here. As you feel around you take notice to
        the cold rocky hardness. It is definitely natural rock that you are touching.

        ...
        ...

        Your hands come across something with a wooden texture. Holding it up to your face you can 
        barely make out the look of a.. Torch..? Yes it has to be!
        Now you'll just have to figure out how to light it and you'll hopefully be able to see!

        As you think this you also have to wonder why there would be a torch here.. Someone or something
        must have left it here for you to find..
        ";
                    Menu.AnimateTyping(programmingQuote3, 25);

            Torch_B = true;
            //Items.Add("Torch");
            BPrompt = programmingQuote3;
            BOptions = new[] { "Inventory", "Stand Up" };
            Menu goback = new Menu(BPrompt, new[] { "Continue" });
            goback.Run(goback.SelectedIndex = 0);

                }

            }

        }
    

