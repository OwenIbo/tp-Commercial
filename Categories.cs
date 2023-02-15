using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_Commercial
{
    internal class Categories
    {
        private string codeCategorie;
        private string libCategorie;

        public Categories (string codeCategorie, string libCategorie)
        {
            this.codeCategorie = codeCategorie;
            this.libCategorie = libCategorie;
        }

        public string CodeCategorie
        {
            get { return codeCategorie; }
            set { codeCategorie = value; }
        }

        public string LibCategorie
        {
            get { return libCategorie; }
            set { libCategorie = value; }
        }

        public override string ToString()
        {
            return $"Code catégorie: {codeCategorie}, Libellé catégorie: {libCategorie}";
        }
    }
}


