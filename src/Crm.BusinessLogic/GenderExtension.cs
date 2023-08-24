using Crm.DataAccess;

namespace Crm.BusinessLogic;

public static class GenderExtension
{
    public static Gender ToGenderEnum(this string genderStr)
        => Enum.Parse<Gender>(genderStr);
}
