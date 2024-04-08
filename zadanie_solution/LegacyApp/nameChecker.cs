namespace LegacyApp
{
    public interface name_checker
    {
        static bool checkname(string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                return false;
            }

            return true;
        }

    }
}