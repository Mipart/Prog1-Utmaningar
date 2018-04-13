using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_Manager
{
    public class Recipe
    {
        string name;
        string instructions;
        string ingredients;

        public Recipe(string _name, string _instruction, string _ingredients)
        {
            name = _name;
            instructions = _instruction;
            ingredients = _ingredients;
        }

        //Return the name
        public string GetName()
        {
            return name;
        }

        //Return ingredients
        public string GetIngredients()
        {
            return ingredients;
        }

        //Retun Instruction
        public string GetInstruction()
        {
            return instructions;
        }
    }
}
