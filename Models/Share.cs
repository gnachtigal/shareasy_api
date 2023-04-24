namespace Shareasy.Models
{
    public class Share
    {
        public DateTime CreatedAt { get; set; }

        public string ShareCode { get; set; }

        private readonly string tokenCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";


        public void generateRandomToken()
        {
            string token = string.Empty;
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                token += this.tokenCharacters[rnd.Next(0, 36)];
            }

            this.ShareCode = token;
        }


    }
}