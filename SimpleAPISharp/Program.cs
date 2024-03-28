using SimpleAPISharp.API.Models.DBModels;
using SimpleAPISharp.API.V2;
using SimpleAPISharp.API.CRUD;

internal class Program
{

    //The following code demonstrates how SimpleAPISharp works. 
    /*
     * You can modify it or simply make it a package and install it to your existing applications.
     * 
     */
    private static async Task Main(string[] args)
    {


        Console.WriteLine("Please enter a country name");
        string countryName = Console.ReadLine();

        Console.Clear();


        //In terms of the GET, and GET_ALL Method:
        /*
         * GET_ALL is used for retrieving a collection of data, but it is not always sucessful and was only designed for my personal needs.
         * In most cases you will want to use the ApiMethod.GET only.
         * 
         * Also keep in mind, in the current format you can not send anything in the Body. Only in the URL (Which is kinda limiting).
         * My plan is to add support for Request Body, but at this time I do not have the time to implement due to school and work.
         * 
         * One other important note is that this requires deserialization. So you will need to make the model classes for everything.
         * 
         */
        var request = await ApiLine.AsyncRequest<List<Root>>(ApiMethod.GET, $"https://restcountries.com/v3.1/name/{countryName}?fullText=true");

        Root country = request.ApiModel[0];


        Console.WriteLine(country.Name.Official);
        Console.WriteLine($"Population: {country.Population.ToString()}");
        Console.WriteLine($"Region: {country.Region.ToString()}");

        if (country.UnMember == true)
        {
            Console.WriteLine($"{country.Name.Common} is a UN Member");

        }
        else if (country.UnMember == false)
        {
            Console.WriteLine($"{country.Name.Common} is NOT a UN Member");
        }


        Console.WriteLine($"Capital: {country.Capital[0]}");


        Console.WriteLine($"Country Name In Italian: {country.Translations.Ita.Official}");
        Console.WriteLine($"Country Name In French: {country.Translations.Fra.Official}");

    }
}