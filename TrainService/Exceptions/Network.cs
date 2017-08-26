using System.IO;

namespace TrainService.Exceptions
{
    public static class Network
    {
        public static IOException LinkFailed = new IOException("网络连接已断开，请检查网络连接后重试当前操作。");
        public static IOException ResponseNull = new IOException("网络不稳定，请重试当前操作。");
    }
}