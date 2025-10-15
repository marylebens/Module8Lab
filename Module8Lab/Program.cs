// Directives to import other classes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;

// Class for creating a new Pokemon creature
class Pokemon {
    // Attributes of a Pokemon
    // Variables that describe the class/object
    public int Id { get; set;}
    public string Name {get; set;}
    public string Type {get;set;}
    public int Level {get; set;}
} //end Pokemon class

// Class that runs the program
// When the program is executed, a new instance of the PokemonLinqLab class
// is created and the Main method is called
class PokemonLinqLab {
    // Main method - automatically called when the program runs
    static void Main() {
        // Sample data - list of Pokemon
        var pokemons = new List<Pokemon> {
            new Pokemon { Id = 1, Name = "Bulbasaur", Type="Grass", Level=15},
            new Pokemon { Id = 2, Name = "Charmander", Type="Fire", Level=36}, 
            new Pokemon { Id = 3, Name = "Squirtle", Type="Water", Level=10},
            new Pokemon { Id = 4, Name = "Pikachu", Type="Electric", Level=22},
            new Pokemon { Id = 5, Name = "Eevee", Type="Normal", Level=25}
        };

        // LINQ Query to find Pokemon ready to evolve (assuming level 16
        // for the first evolution)
        var readyToEvolveQuery = from p in pokemons 
                                    where p.Level >= 16 
                                    orderby p.Level 
                                    select p;
        //This is how the LINQ query would look in SQL:
        // SELECT * FROM pokemons WHERE level >= 16 ORDER BY Level

        // Excute the query and display the results
        Console.WriteLine("Pokemon Ready to Evolve: ");
        //Use a foreach loop to iterate through the list elements
        //That were returned by the LINQ query
        foreach (var pokemon in readyToEvolveQuery) {
            Console.WriteLine($"Name: {pokemon.Name}, Type: {pokemon.Type}, Level: {pokemon.Level}");
        } //end loop
    } //end method
} //end class
