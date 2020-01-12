namespace TheObjectOfYourAffection
{
    public class Profile
    {
        #region Fields

        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;

        #endregion

        #region Constructor

        public Profile(string name, int age, string city, string country, string pronouns = "they/them")
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
        }

        #endregion

        #region Methods

        public string ViewProfile()
        {
            string profile = "";
            profile += $"Name: {name}";
            profile += $" Age: {age}";
            profile += $" City: {city}";
            profile += $" Country: {country}";
            profile += $" Pronouns: {pronouns}";

            for (int i = 0; i < this.hobbies.Length; i++)
            {
                profile += $" Hobby {i + 1}: {hobbies[i]}";
            }

            return profile;
        }

        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }

        #endregion
    }
}
