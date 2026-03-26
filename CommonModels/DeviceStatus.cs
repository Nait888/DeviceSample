namespace CommonModels
{
    public class DeviceStatus
    {
        public bool IsReady { get; set; }
        public int CurrentStep { get; set; }
        public string ErrorCode { get; set; }
    }
}