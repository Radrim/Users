namespace Blazor.Data
{
    public class UserService
    {
        private static string[] FirstNames = new[]
        {
        "Bred", "Jack", "Tom", "Sasha", "Victor", "Bruce", "Jason", "Tomas", "Sergey"
        };

        private static string[] LastNames = new[]
        {
        "Ivanov", "Skvorcov", "Norov", "Vovorov", "Sogin", "Mikelson", "Pit"
        };

        public static List<User> GetUserList()
        {
            return Enumerable.Range(1, Random.Shared.Next(1, 9)).Select(index => new User
            {
                FirstName = FirstNames[Random.Shared.Next(FirstNames.Length)],
                LastName = LastNames[Random.Shared.Next(LastNames.Length)],
                Age = Random.Shared.Next(0, 100)
            }).ToList();
        }
    }
}