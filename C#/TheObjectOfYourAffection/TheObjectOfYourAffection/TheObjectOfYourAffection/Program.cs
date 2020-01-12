using System;

namespace TheObjectOfYourAffection
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile profile = new Profile("Sam Drakkila", 30, "New York", "USA", "he/him");
            profile.SetHobbies(new string[] { "Listening to audiobooks and podcasts", "Playing rec sports like bowling and kickball", "Writing a speculative fiction novel", "Reading advice columns" });
            Console.WriteLine(profile.ViewProfile());
        }
    }
}