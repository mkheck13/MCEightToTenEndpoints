namespace MCEightToTenEndpoints.Services
{
    public class MagicEightBallServices
    {
        public string Question()
        {
            string[] fortune = new string[]
            {
                "It is certain",
                 "It is decidedly so", 
                 "Without a doubt",
                 "Yes definitely", 
                 "You may rely on it", 
                 "As I see it, yes", 
                 "Most likely", 
                 "Outlook good", 
                 "Yes", 
                 "Signs point to yes", 
                 "Reply hazy, try again", 
                 "Ask again later", 
                 "Better not tell you now", 
                 "Cannot predict now", 
                 "Concentrate and ask again", 
                 "Don't count on it", 
                 "My reply is no", 
                 "My sources say no", 
                 "Outlook not so good", 
                 "Very doubtful", 
                 "ERROR 404\nPAGE NOT FOUND"
            };

            int randomIndex = new Random().Next(0, fortune.Length);

            return fortune[randomIndex];
        }
    }
}