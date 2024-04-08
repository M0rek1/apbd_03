namespace LegacyApp
{
    public interface emailchecker
    {
        static bool checkemail(string email)
        {
            if (!email.Contains("@") && !email.Contains("."))
            {
                return false;
            }


            return true;
        }
    }
}