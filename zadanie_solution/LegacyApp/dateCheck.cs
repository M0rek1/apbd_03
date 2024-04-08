using System;

namespace LegacyApp
{
    public interface dateCheck
    {
        static bool checkdate(DateTime dateOfBirth, DateTime now, int age )
        {

            if (now.Month < dateOfBirth.Month || (now.Month == dateOfBirth.Month && now.Day < dateOfBirth.Day)) age--;

            if (age < 21)
            {
                return false;
            }

            return true;
        }
    }
}