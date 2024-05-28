namespace FlavorVerse.Common
{
    public class Constants
    {
        public const string SYSTEM_USER_ID = "00000000-0000-0000-0000-000000000001";

        public const int DEFAULT_SALT_LENGTH = 32;
        public const int TOKEN_EXPIRATION_TIME = 12;

        // Policies

        public const string ADMIN = "Admin";
        public const string MEMBER = "Member";

        // Params

        public const int DEFAULT_PAGE_SIZE = 10;
        public const int MAX_PAGE_SIZE = 50;
    }
}