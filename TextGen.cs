using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4CH
{
    class TextGen
    {
        static public void FileCreator()
        {
            using (var stream = File.Open("Text.txt", FileMode.Create))
            {
                using (var writer = new StreamWriter(stream))
                {
                    string s = "[Intro]\r\n" +
                        "Desert you\r\n" +
                        "Ooh-ooh-ooh-ooh\r\n" +
                        "Hurt you\r\n\r\n" +
                        "[Verse 1]\r\n" +
                        "We're no strangers to love\r\n" +
                        "You know the rules and so do I (Do I)\r\n" +
                        "A full commitment's what I'm thinking of\r\n" +
                        "You wouldn't get this from any other guy\r\n\r\n" +
                        "[Pre-Chorus]\r\n" +
                        "I just wanna tell you how I'm feeling\r\n" +
                        "Gotta make you understand\r\n\r\n" +
                        "[Chorus]\r\n" +
                        "Never gonna give you up\r\n" +
                        "Never gonna let you down\r\n" +
                        "Never gonna run around and desert you\r\n" +
                        "Never gonna make you cry\r\n" +
                        "Never gonna say goodbye\r\n" +
                        "Never gonna tell a lie and hurt you\r\n\r\n" +
                        "[Verse 2]\r\n" +
                        "We've known each other for so long\r\n" +
                        "Your heart's been aching, but you're too shy to say it (To say it)\r\n" +
                        "Inside, we both know what's been going on (Going on)\r\n" +
                        "We know the game, and we're gonna play it\r\n" +
                        "You might also like\r\n" +
                        "ILLEGALS IN MY YARD\r\n" +
                        "The Fox and Rice Experience\r\n" +
                        "Say Don’t Go (Taylor’s Version) [From The Vault]\r\n" +
                        "Taylor Swift\r\n" +
                        "A&W\r\n" +
                        "Lana Del Rey\r\n" +
                        "[Pre-Chorus]\r\n" +
                        "And if you ask me how I'm feeling\r\n" +
                        "Don't tell me you're too blind to see\r\n\r\n" +
                        "[Chorus]\r\n" +
                        "Never gonna give you up\r\n" +
                        "Never gonna let you down\r\n" +
                        "Never gonna run around and desert you\r\n" +
                        "Never gonna make you cry\r\n" +
                        "Never gonna say goodbye\r\n" +
                        "Never gonna tell a lie and hurt you\r\n" +
                        "Never gonna give you up\r\n" +
                        "Never gonna let you down\r\n" +
                        "Never gonna run around and desert you\r\n" +
                        "Never gonna make you cry\r\n" +
                        "Never gonna say goodbye\r\n" +
                        "Never gonna tell a lie and hurt you\r\n\r\n" +
                        "[Post-Chorus]\r\n" +
                        "Ooh (Give you up)\r\n" +
                        "Ooh-ooh (Give you up)\r\n" +
                        "Ooh-ooh\r\n" +
                        "Never gonna give, never gonna give (Give you up)\r\n" +
                        "Ooh-ooh\r\n" +
                        "Never gonna give, never gonna give (Give you up)\r\n" +
                        "[Bridge]\r\n" +
                        "We've known each other for so long\r\n" +
                        "Your heart's been aching, but you're too shy to say it (To say it)\r\n" +
                        "Inside, we both know what's been going on (Going on)\r\n" +
                        "We know the game, and we're gonna play it\r\n\r\n" +
                        "[Pre-Chorus]\r\n" +
                        "I just wanna tell you how I'm feeling\r\n" +
                        "Gotta make you understand\r\n\r\n" +
                        "[Chorus]\r\n" +
                        "Never gonna give you up\r\n" +
                        "Never gonna let you down\r\n" +
                        "Never gonna run around and desert you\r\n" +
                        "Never gonna make you cry\r\n" +
                        "Never gonna say goodbye\r\n" +
                        "Never gonna tell a lie and hurt you\r\n" +
                        "Never gonna give you up\r\n" +
                        "Never gonna let you down\r\n" +
                        "Never gonna run around and desert you\r\n" +
                        "Never gonna make you cry\r\n" +
                        "Never gonna say goodbye\r\n" +
                        "Never gonna tell a lie and hurt you\r\n" +
                        "Never gonna give you up\r\n" +
                        "Never gonna let you down\r\n" +
                        "Never gonna run around and desert you\r\n" +
                        "Never gonna make you cry\r\n" +
                        "Never gonna say goodbye\r\n" +
                        "Never gonna tell a lie and hurt you";
                    writer.Write(s);
                }
            }
        }
    }
}
