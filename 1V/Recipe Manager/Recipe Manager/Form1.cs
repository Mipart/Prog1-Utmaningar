﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipe_Manager
{
    public partial class Form1 : Form
    {
        List<Recipe> recipeList = new List<Recipe>();
        public Form1()
        {
            InitializeComponent();
        }
    }
}
