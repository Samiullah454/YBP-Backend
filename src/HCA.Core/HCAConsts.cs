using HCA.Debugging;

namespace HCA
{
    public class HCAConsts
    {
        public const string LocalizationSourceName = "HCA";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "048395b16761401ca365cef2dc843872";
    }
}
