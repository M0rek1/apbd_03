namespace LegacyApp
{
    public interface creditlimitChecker
    {
        static bool checkcreditlimit( User user)
        {
            if (user.HasCreditLimit && user.CreditLimit < 500)
            {
                return false;
            }

            return true;
        }
        }
    }
