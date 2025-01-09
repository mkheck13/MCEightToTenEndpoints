namespace MCEightToTenEndpoints.Services
{
    public class MagicEightBallServices
    {
        public string Question()
        {
            string[] fortune = new string[]
            {
                "",
            };

            int randomIndex = new Random().Next(0, fortune.Length);

            return fortune[randomIndex];
        }
    }
}