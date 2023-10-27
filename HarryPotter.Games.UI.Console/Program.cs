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

string ageSaisie;
do
{
    Console.WriteLine("Ton âge s'il te plait ?");
    ageSaisie = Console.ReadLine();

} while (string.IsNullOrWhiteSpace(ageSaisie));

int ageJoueur = int.Parse(ageSaisie);
int ageMinimum = 12;

// compare deux entiers
// renvoie -1 si ageJoueur < ageMinimum, renvoie 1 si ageJoueur > ageMinimum et renvoie 0 si les deux sont ==
int comparaison = ageJoueur.CompareTo(ageMinimum);
Console.WriteLine("si 1 age > ageMin " + comparaison);
bool estAgeValide = comparaison >= 0;


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
    else if (ageJoueur < 40)
    {
        Console.WriteLine("ca va tu n'es pas trop vieux !");
    }
    else
    {
        Console.WriteLine("Tu as plus de 40 ans");
    }
}

/* première façon de faire
//if (estAgeValide == false)
//{
//    Console.WriteLine("Age interdit !");
//    Environment.Exit(0);
//}
*/

#endregion

#region --- DATE DE NAISSANCE ---

Console.WriteLine("ta date de naissance ?");
string dateSaisie = Console.ReadLine();

DateTime dateEtHeureNaissance = DateTime.Parse(dateSaisie);
DateOnly dateNaissance = DateOnly.FromDateTime(dateEtHeureNaissance);  // DateOnly.Parse(dateSaisie);

// TimeOnly;;
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

#region --- PREPARATION ARME ---

// decimal puissanceArme = 10;
float puissanceArme = 10;
puissanceArme = 15.5F;

Console.WriteLine(puissanceArme);

int valeurParDefaultPuissanceArme = 10;


Console.WriteLine("Choississez votre arme par défaut pour démarrer le jeu");

for (int i = 0; i < 4; i++)
{
    Console.WriteLine($"Arme {i + 1}");
}

// int valeurPuissanceArmeX = (int) puissanceArme;

#endregion

#region --- CHOIX COTÉ FORCE ---

Console.WriteLine("De quel coté de la force sera tu ?");
Console.WriteLine("1. coté lumineux");
Console.WriteLine("2. coté obscur");
Console.WriteLine("3. neutre");

string SaisieForce = Console.ReadLine();
int TypeForce = int.Parse(SaisieForce);

const int forceLumineuse = 1;
const int forceObscur = 2;
const int sansForce = 3;

// apres le case, il doit y avoir une constante obligatoirement !!
switch(TypeForce)
{
    case forceLumineuse:
        {
            Console.WriteLine("tu as choisies lumineux");
        } 
        break;
    case forceObscur:
        {
            Console.WriteLine("tu as choisies obscur");
        }
        break;
    case sansForce:
        {
            Console.WriteLine("tu as choisies neutre");
        }
        break;
    default: 
        {
            Console.WriteLine("Aucune force");
        }
        break;
}


#endregion