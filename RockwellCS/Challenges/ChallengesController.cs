using System;
namespace RockwellCS.Challenges
{
    public class ChallengesController
    {
        public ChallengesController()
        {
            /*
             * CHALLENGES
             * 
             * DATA Compression
             * RLE (RUN LENGTH ENCODING)
             * 
             *         Create an algorithm that can take a phrase, and count the
             *         amount of characters that phrase has
             *         then create a second phrase that just represents how many
             *         characters the first phrase had
             *         for example
             *         
             *         Example w = White, b = black (in a picture)
             *         Original -> 
             *          ln 1: wwwwwwwwbwwwwwwwwwwbwwwwwwwwww
             *          ln 2: wwwwwwwbbbwwwwwwwwbbbwwwwwwwww
             *          ln 3: wwwwwwbbbbbwwwwwwbbbbbwwwwwwww
             *          ln 4: wwwwwbbbbbbbwwwwbbbbbbbwwwwwww
             *          ln 5: wwwwwbbbbbbbbbbbbbbbbbbwwwwwww
             *          ln 6: wwwwwbbbbbbbbbbbbbbbbbbwwwwwww
             *          ln 7: wwwwwbbbbbbbbbbbbbbbbbbwwwwwww
             *          ln 8: wwwwwbbbbbbbbbbbbbbbbbbwwwwwww
             *          ln 9: wwwwwbbbbbbbbbbbbbbbbbbwwwwwww
             *         ln 10: wwwwwbbbbbbbbbbbbbbbbbbwwwwwww
             *         ln 11: wwbbbbbbbbbbbbbbbbbbbbbbbwwwww
             *         
             *         total Data Required = 330 bytes
             *         Compressed ->
             *          ln 1: 8w1b10w1b10w1\
             *          ln 2: 7w3b8w3b9w1\
             *          ln 3: 6w3b6w5b8w1\
             *          ln 4: 5w7b4w7b7w1\
             *          ln 5: 5w18b7w1\
             *          ln 6: 5w18b7w1\
             *          ln 7: 5w18b7w1\
             *          ln 8: 5w18b7w1\
             *          ln 9: 5w18b7w1\
             *         ln 10: 5w18b7w1\
             *         ln 11: 2w23b5w1\
             *         
             *         Total Data Needed -> 113 bytes.
             *         
             *         
             *         
             *         
             *         The String:
             * OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOnOOOxxOOOxOxxxxxOxOxOOOOxxxxOOOOnOOOxxOOOxOxOOOOOxOxOOxxOOOxxOOOnOOOxxxxxxOxxxxOOxOxOOxOOOOOxOOOnOOOxxOOOxOxOOOOOxOxOOxOOOOOxOOOnOOOxxOOOxOxOOOOOxOxOOxOOOOOxOOOnOOOxxOOOxOxxxxxOxOxOOOxxxxxOOOOnOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOnOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOnOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOnOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOnOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOnOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOn
             *         
             *         
             *         OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOn
             *         OOOxxOOOxOxxxxxOxOxOOOOxxxxOOOOn
             *         OOOxxOOOxOxOOOOOxOxOOxxOOOxxOOOn
             *         OOOxxxxxxOxxxxOOxOxOOxOOOOOxOOOn
             *         OOOxxOOOxOxOOOOOxOxOOxOOOOOxOOOn
             *         OOOxxOOOxOxOOOOOxOxOOxOOOOOxOOOn
             *         OOOxxOOOxOxxxxxOxOxOOOxxxxxOOOOn
             *         OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOn
             *         OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOn
             *         OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOn
             *         OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOn
             *         OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOn
             *         OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOn
             *         
             *         note: every time you encounter a 'n' this means a new
             *         line. represented in a string as '\n'
             *         
             */
        }




        public void Test()
        {
            string uncodedstring = "OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOnOOOxxOOOxOxxxxxOxOxOOOOxxxxOOOOnOOOxxOOOxOxOOOOOxOxOOxxOOOxxOOOnOOOxxxxxxOxxxxOOxOxOOxOOOOOxOOOnOOOxxOOOxOxOOOOOxOxOOxOOOOOxOOOnOOOxxOOOxOxOOOOOxOxOOxOOOOOxOOOnOOOxxOOOxOxxxxxOxOxOOOxxxxxOOOOnOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOnOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOnOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOnOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOnOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOnOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOn";

            int position = 0;
            string codedString = "";
            char activeChar;
            char? previousChar = null;
            int previousCharCount = 0;
            

            while (position < uncodedstring.Length)
            {
                if (position == 0)
                {
                    activeChar = uncodedstring[position];
                    previousChar = uncodedstring[position];
                    previousCharCount++;
                    
                }
                else
                {
                    activeChar = uncodedstring[position];
                    if (activeChar == previousChar)
                    {
                        previousCharCount++;
                    }
                    else
                    {
                        codedString += previousCharCount.ToString() + previousChar;

                        previousChar = activeChar;
                        previousCharCount = 1;
                    }
                }

                position++;
            }

            Console.WriteLine($"Previous String Length: {uncodedstring.Length} | Coded String Length {codedString.Length}");
            Console.WriteLine(uncodedstring);
            Console.WriteLine(codedString);


            Console.WriteLine("Now Working on Decoding the string");
            QuickNDrityDecoder(codedString);
        }

        private void QuickNDrityDecoder(string code)
        {
            string message = "";
            int currentLineLength = 0;


            /* can we turn current window into a number
                // yes - > make current substring,
                       - > expand window by one character

                // no -> turn current substring to int
                      -> Set new active char
                      -> add active char to message string
                         the times it is specified
                      -> Move to next available
            */



            //30w54b30wn30w54b30w

            string sample = "30w54b30wn30w54b30w";
            string buffer = "";
            char? LookAt = null;
            int LoopFor = 0;
            string done = "";

            for (int i = 0; i < code.Length; i++)
            {
                //our look at window is the -substring.
                if (i == 0)
                {
                    LookAt = code[i];
                    try
                    {
                        Convert.ToInt32(LookAt.ToString());

                        //if this Int32 did not throw an Exception this is a number

                        buffer += LookAt;
                    }
                    catch (Exception)
                    {
                        //this is a character not a number

                        if (LookAt == 'n')
                        {
                            done += "\n";
                        }
                        else
                        {
                            LoopFor = Convert.ToInt32(buffer);
                            for (int j = 0; j <= LoopFor; j++)
                            {
                                done += LookAt;
                            }
                        }

                        LoopFor = 0;
                        buffer = "";   
                    }
                }
                else
                {
                    LookAt = code[i];
                    try
                    {
                        Convert.ToInt32(LookAt.ToString());

                        //if this Int32 did not throw an Exception this is a number

                        buffer += LookAt;
                    }
                    catch (Exception)
                    {
                        //this is a character not a number

                        if (LookAt == 'n')
                        {
                            Console.WriteLine(done);
                            Console.WriteLine($"Line Length {currentLineLength}");
                            done += "\n";
                            currentLineLength = 0;
                        }
                        else
                        {
                            LoopFor = Convert.ToInt32(buffer);
                            for (int j = 0; j < LoopFor; j++)
                            {
                                done += LookAt;
                                currentLineLength++;
                            }
                        }

                        LoopFor = 0;
                        buffer = "";
                    }
                }
            }




            Console.WriteLine("Decoded Message:");
            Console.WriteLine(done);
            Console.Read();
        }
    }
}
