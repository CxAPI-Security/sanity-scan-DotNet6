namespace ApiDiscovery.Models
{

    public class PalmVeinEnrollResponse
    {
        public PalmVeinEnrollResponseResult Result { get; private set; }

        public PalmVeinEnrollResponse(PalmVeinEnrollResponseResult result)
        {
            Result = result;
        }
    }
}