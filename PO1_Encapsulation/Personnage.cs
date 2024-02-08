using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1_Encapsulation
{
    public class Personnage //toujours mettre : public
    {
        string nom;
        int pointsDeVie;
        int pointsDePuissance;
        // Pour protéger les attributs //selectionner les 3 lignes en haut
        //click droite //Action rapides et refactorisation 
        //Encapsuler les champs (et utiliser la propriétés)

        public string Nom { get => nom; set => nom = value; }
        public int PointsDeVie { get => pointsDeVie;
            set
            {
                if(value < 0)
                {
                    pointsDeVie = 0;
                }
                else
                {
                    pointsDeVie = value;
                }
            }
        }
        public int PointsDePuissance { get => pointsDePuissance; set => pointsDePuissance = value; }

        public bool EstEnVie //boolean parce que retourne vrai ou faux 
            //EstEnVie est une propriété 
        {
            get 
            {
                if (PointsDeVie > 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
