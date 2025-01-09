namespace MCEightToTenEndpoints.Services
{
    public class RestaurantPickerServices
    {
        public string FoodPicker(string pizzaMexicanFastFood)
        {
            string[] pizza = new string[]
            {
                "Dominos",
                "Pizza Hut",
                "Mountain Mike's",
                "Eddie's",
                "Little Caesars",
                "Papa Murphys",
                "David's Pizza",
                "Michael's Pizza",
                "Eric's Pizza",
                "Dante's Pizza"
            };
            string[] mexican = new string[]
            {
                "Taco House",
                "Yellow House",
                "Don Rafas",
                "Casa Flores",
                "Betto's Birreria",
                "El Grullense",
                "Xochimilco cafe",
                "Maria's Cafe",
                "Susy's",
                "Arroyo's"
            };
            string[] fastFood = new string[]
            {
                "MCDonald's",
                "Burger King",
                "Wendy's",
                "Jack in the Box",
                "Taco Bell",
                "Subway",
                "Carl's Jr.",
                "A&W",
                "The Habit",
                "In N Out"
            };

            int randomIndex = new Random().Next(0, 10);

            string genre = pizzaMexicanFastFood.ToLower();

            if (genre == "pizza")
            {
                return $"{pizza[randomIndex]}";
            }
            else if (genre == "mexican")
            {
                return $"{mexican[randomIndex]}";
            }
            else if (genre == "fastfood")
            {
                return $"{fastFood[randomIndex]}";
            }
            else
            {
                return $"{pizzaMexicanFastFood} was not a valid option. Try choosing between pizza, mexican, or fast food";
            }
        }
    }
}