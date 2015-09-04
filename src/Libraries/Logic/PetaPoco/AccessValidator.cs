namespace PetaPoco
{
    public class AccessValidator
    {
        public static bool Validate(IPolicy policy)
        {
            //Todo
            if (policy.LoginId == 0)
            {
                return false;
            }

            return true;
        }
    }
}