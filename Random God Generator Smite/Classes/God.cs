using System;
using System.Collections.Generic;

namespace Random_God_Generator_Smite.Classes
{
    class God
    {
        public string Name { get; set; }
        public string Pantheon { get; set; }
        public string AttackType { get; set; }
        public string PowerType { get; set; }
        public string Class { get; set; }
        public string FavourCost { get; set; }
        public string GemCost { get; set; }
        public string ReleaseDate { get; set; }
        public List<string> Skins { get; set; }
        public List<string> SkinLinks { get; set; }

        public override string ToString()
        {
            Console.WriteLine ("{0,15}{1,9}{2,7}{3,9}{4,9}{5,5}{6,5}{7,11}",
                Name,
                Pantheon,
                AttackType,
                PowerType,
                Class,
                FavourCost,
                GemCost,
                ReleaseDate);

            return string.Empty;
        }
    }
}
