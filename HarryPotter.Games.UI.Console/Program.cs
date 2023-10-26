using System.Diagnostics;
using System.Globalization;


#region --- début str ---

string titre = "jeu harry potter";
titre = "un jeu épique !";

string sousTitre = "Harry Potter";

// inverser les variables titre et sousTitre : 
string variableTemporaire = titre;
titre = sousTitre;
sousTitre = variableTemporaire;

// mettre un majuscule une chaine de caractère.
titre.ToUpper();

// soustraire une partie de la chaîne 
//Console.WriteLine(sousTitre.Substring(0, sousTitre.Length - 1));

//debug.writeline("==> je teste " + titre);

#endregion

#region --- PARTIE SAISIE INFORMATIONS JOUER ---
Console.WriteLine("Ton âge s'il te plait ?");
string ageSaisie = Console.ReadLine();

int ageJoueur  = int.Parse(ageSaisie);
// ageJoueur += 1; // vrai addition mathématique

int ageMinimum = 12;

// compare deux entiers
// renvoie -1 si ageJoueur < ageMinimum, renvoie 1 si ageJoueur > ageMinimum et renvoie 0 si les deux sont ==
int comparaison = ageJoueur.CompareTo(ageMinimum);
Console.WriteLine("si 1 age > ageMin " + comparaison);

bool estAgeValide = comparaison > 0;

if (/*! estAgeValide ou */ ! (comparaison > 0)) // si je n'ai pas true donc si j'ai false, si age pas valide !
{
    Console.WriteLine("Age interdit !");
    Environment.Exit(0);
}
else
{
    Console.WriteLine("Tu peux continuer !");
    if (ageJoueur < 18)
    {
        Console.WriteLine("Tu n'es pas majeure !");
    }
}

/* première façon de faire
//if (estAgeValide == false)
//{
//    Console.WriteLine("Age interdit !");
//    Environment.Exit(0);
//}
*/

/* type decimal
// decimal puissanceArme = 10;
float puissanceArme = 10;
puissanceArme = 15.5F;

Console.WriteLine(puissanceArme);
int valeurParDefaultPuissanceArme = 10;
puissanceArme = valeurParDefaultPuissanceArme;

// int valeurPuissanceArmeX = (int) puissanceArme;*/

#endregion

#region --- DATE DE NAISSANCE ---

Console.WriteLine("ta date de naissance ?");
string dateSaisie = Console.ReadLine();

DateTime dateEtHeureNaissance = DateTime.Parse(dateSaisie);
DateOnly dateNaissance = DateOnly.FromDateTime(dateEtHeureNaissance);  // DateOnly.Parse(dateSaisie);

// TimeOnly;
Console.WriteLine("tu as saisie " + dateEtHeureNaissance.ToString());
Console.WriteLine("tu as saisie " + dateEtHeureNaissance);

#endregion

#region --- AFFICHAGE MENU  ---

/* explications formatage 2 étapes
"{0}.{1}" => string.Format() prend 1 caractère (ici {0} et sera 1)
puis met un point ensuite prend un deuxième caractère (ici {1} et sera ItemMenu) 
*/

string format = "{0}.{1}";

/* formatage une étape
*/
string ItemMenu = "nouvelle partie";
Console.WriteLine(format, 1, ItemMenu.Substring(0, 1).ToUpper() + ItemMenu.Substring(1).ToLower());

/* formatage deux étapes
//string ItemMenu = "nouvelle partie";
//string resultatFormattage = string.Format(format, 1, ItemMenu.Substring(0, 1).ToUpper() + ItemMenu.Substring(1).ToLower());
//Console.WriteLine(resultatFormattage);
*/

ItemMenu = "Charger partie";
string resultatFormattage = $"{2}. {ItemMenu.Substring(0, 1).ToUpper() + ItemMenu.Substring(1).ToLower()}";   //string.Format(format, 1, ItemMenu.Substring(0, 1).ToUpper() + ItemMenu.Substring(1).ToLower());
Console.WriteLine(format, 2, ItemMenu.Substring(0, 1).ToUpper() + ItemMenu.Substring(1).ToLower());

ItemMenu = "Credits";
Console.WriteLine(format, 3, ItemMenu.Substring(0, 1).ToUpper() + ItemMenu.Substring(1).ToLower());

ItemMenu = "Quitter";
Console.WriteLine(format, 4, ItemMenu.Substring(0, 1).ToUpper() + ItemMenu.Substring(1).ToLower());



/* Première étape avant formattage
// prend la var, prend premier caractère -> upper et ajoute le reste (à partir du deuxième car) -> lower
//Console.WriteLine(1 + "." + ItemMenu.Substring(0, 1).ToUpper() + ItemMenu.Substring(1).ToLower());
//Console.WriteLine(2 + "." + "Charger partie");
//Console.WriteLine(3 + "." + "Credits");
//Console.WriteLine(4 + "." + "Quitter");
*/


#endregion