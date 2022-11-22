namespace ApiDiscovery.Models
{
    public class PalmVeinVerifyAccountResponse
    {
        public bool PalmExists { get; private set; }
        public bool UserExists { get; private set; }
        public string ScanId { get; private set; }
        public string UserName { get; private set; }
        public int UserId { get; private set; }

        public PalmVeinVerifyAccountResponse(bool palmExists, bool userExists, string scanId, string username,
            int userId)
        {
            UserExists = userExists;
            PalmExists = palmExists;
            ScanId = scanId;
            UserName = username;
            UserId = userId;
        }
    }
}