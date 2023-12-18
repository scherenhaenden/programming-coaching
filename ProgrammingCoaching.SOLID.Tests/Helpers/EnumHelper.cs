namespace ProgrammingCoaching.SOLID.Tests.Helpers
{
    public static class EnumHelper
    {
        private static Random random = new Random();

        public static T GetRandomEnumValue<T>() where T : Enum
        {
            T[] enumValues = (T[])Enum.GetValues(typeof(T));
            return enumValues[random.Next(enumValues.Length)];
        }
    }
}