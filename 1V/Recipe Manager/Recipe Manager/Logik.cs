﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_Manager
{
    class Logik
    {
        //The register
        List<Recipe> recipeList = new List<Recipe>();

        public Logik()
        {
            //start the first Form
            OpenManager();
        }

        //Open the Manager
        private void OpenManager()
        {
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
