using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Planet
{
    public partial class PlanetAppUI : Form
    {
        public PlanetAppUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string planetName=planetNameComboBox.Text;
            
            if(planetName=="Mercury")
            {
                MessageBox.Show("Mercury\nIt is in 1st position");
            }

            else if(planetName=="Venus")
            {
                MessageBox.Show("Venus\nIt is in 2nd position");
            }

            else if(planetName=="Earth")
            {
                MessageBox.Show("Earth\nIt is in 3rd position");
            }
                
            else if(planetName=="Mars")
            {
                MessageBox.Show("Mars\nIt is in 4th position");
            }
            
            else if(planetName=="Jupiter")
            {
                MessageBox.Show("Jupiter\nIt is in 5th position");
            }
            
            else if(planetName=="Saturn")
            {
                MessageBox.Show("Saturn\nIt is in 6th position");  
            }

            else if(planetName=="Uranus")
            {
                MessageBox.Show("Uranus\nIt is in 7th position");
            }
 
            else if(planetName=="Neptune")
            {
                MessageBox.Show("Neptune\nIt is in 8th position");
            }
            
            else if(planetName=="Pluto")
            {
                MessageBox.Show("Pluto\nIt is in 9th position");
            }
            
            else
            {
                MessageBox.Show("I don’t know");
            }
        }
    }
}