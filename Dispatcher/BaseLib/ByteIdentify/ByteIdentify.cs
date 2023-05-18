
namespace BaseLib.ByteIdentify
{
    public static class ByteBaseIdentify
    {
        public static byte CheckSum(byte[] dataCheck)
        {
            byte RecSum = 0x00;
            foreach (byte BData in dataCheck)
            {
                RecSum ^= BData;
            }
            return RecSum;
        }
    }
}
