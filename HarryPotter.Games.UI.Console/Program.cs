
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

#region VariablesGlobal


Player player = new Player("yoda");
Enemy ennemi = new(100, "dark vador");

List<Force> forces = new List<Force>();

#endregion

#region --- FRAMEWORK DU PROJET ---

// Affiche les crédits sur la console
void AffichageCredits()
{
    Console.WriteLine("******************");
    Console.WriteLine("Antoine Nowakowski");
    Console.WriteLine("2023");
    Console.WriteLine("******************");
}

void PreparerListeForce()
{
    forces.Add(new LumineuseForce());
    forces.Add(new ObscureForce());
    forces.Add(new NeutreForce());
}

void AfficherChoixForce()
{
    Console.WriteLine("De quel coté de la force sera tu ?");

    foreach(var force in forces)
    {
        Console.WriteLine(force);
    }
}

int AfficheForceEtRetourneChoixSelection()
{
    AfficherChoixForce();

    string saisieForce = Console.ReadLine();
    int TypeForce = int.Parse(saisieForce);

    return TypeForce;
    // on peut très bien faire :
    // return int.Parse(SaisieForce);
}

int[,] PrepareGrilleDuJeu()
{
    // tableau matriciel
    int[,] grilleDeJeu = new int[20, 20];
    const int valeurSansElement = -1;


    for (int i = 0; i < grilleDeJeu.GetLength(0); i++)
    {
        for (int j = 0; j < grilleDeJeu.GetLength(1); j++)
        {
            grilleDeJeu[i, j] = valeurSansElement;
        }
    }
    return grilleDeJeu;
}

void AfficherItemMenu(string ItemMenu, int indexMenu = 1)
{
    string format = "{0}.{1}";

    string resultatFormattage = string.Format(format, indexMenu, ItemMenu.Substring(0, 1).ToUpper() + ItemMenu.Substring(1).ToLower());
    Console.WriteLine(resultatFormattage);
}

void AfficherMenu()
{
    AfficherItemMenu("nouvelle partie", 1);
    AfficherItemMenu("charger partie", 2);
    AfficherItemMenu("crédits", 3);
    AfficherItemMenu("quitter", 4);
}

string RecupereSaisieAgeNonVide()
{

    bool ageSaisiPasValide = true;
    string ageSaisie = "";

    do
    {

        Console.WriteLine("Ton âge s'il te plait ?");
        ageSaisie = Console.ReadLine();

        ageSaisiPasValide = string.IsNullOrWhiteSpace(ageSaisie);

    } while (ageSaisiPasValide);

    return ageSaisie;
}

int DemandeEtRecupereAgeValide()
{
    int ageJoueur = -1;
    bool estAgeValide = false;

    while (!estAgeValide) // on peut écrire "estAgeValide == false"
    {

        string ageSaisie = RecupereSaisieAgeNonVide();

        int.TryParse(ageSaisie, out ageJoueur);

        /* try catch
        //try
        //{
        //    ageJoueur = int.Parse(ageSaisie);
        //}
        //catch (FormatException ex)
        //{
        //    ageJoueur = 0;
        //    throw new AgeNonValideException();
        //    // ici l'exception est "envoyé" à AgeNonValideException(), ça permet une meilleur lisibilité du code.
        //    // on peut créer des exceptions pour connaître les règles de gestions d'excéption
        //}
        //finally
        //{
        //    Console.WriteLine("pas bien saisi !");
        //}
        */

        int ageMinimum = 12;

        // compare deux entiers
        // renvoie -1 si ageJoueur < ageMinimum, renvoie 1 si ageJoueur > ageMinimum et renvoie 0 si les deux sont ==
        int comparaison = ageJoueur.CompareTo(ageMinimum);
        Console.WriteLine(comparaison);

        estAgeValide = comparaison >= 0;
    }
    return ageJoueur;
}

void AfficherInfoAuSujetAge(int ageJoueur = 0)
{
    if (ageJoueur > 0)
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
}

int RecupereAgeValide()
{
    int ageJoueur = DemandeEtRecupereAgeValide();

    AfficherInfoAuSujetAge(ageJoueur);

    return ageJoueur;
}

DateOnly RecupererEtAfficherDateDeNaissance()
{
    Console.WriteLine("ta date de naissance ?");
    string dateSaisie = Console.ReadLine();

    DateTime dateEtHeureNaissance = DateTime.Parse(dateSaisie);
    DateOnly dateNaissance = DateOnly.FromDateTime(dateEtHeureNaissance);  // DateOnly.Parse(dateSaisie);

    // TimeOnly;;
    Console.WriteLine("tu as saisie " + dateEtHeureNaissance);

    return dateNaissance;
}

void AfficherArmes()
{
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
}

void AfficherForceSelectionnee()
{


    int TypeForce = AfficheForceEtRetourneChoixSelection();

    const int forceLumineuse = 1;
    const int forceObscur = 2;
    const int sansForce = 3;

    player.ForceSelectionnee = forces[TypeForce - 1];

    // apres le case, il doit y avoir une constante obligatoirement !!
    switch (TypeForce)
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
}

#endregion

#region --- MOTEUR DU JEU ---

/* approche tableau simple
int positionJoueur = 1;

int[] positions = new int[10];

var position = positions[0];
Console.WriteLine(position);

bool[] etats = new bool[5];
Console.WriteLine(etats[2]);

string[] noms = new string[4];
Console.WriteLine(noms[2]);
*/

int[,] grille;

void InitDonneesJeu()
{
    PreparerListeForce();
    grille = PrepareGrilleDuJeu();
}

InitDonneesJeu();

/* tableau de tableau
int[][] grilleDeJeuDeux = new int[20][];

for (int i = 0; i < 20; i++)
{
    grilleDeJeuDeux[i] = new int[20];
}
*/

#endregion

#region  --- AFFICHAGE MENU  ---

#region ancien affichage

/* explications formatage 2 étapes
"{0}.{1}" => string.Format() prend 1 caractère (ici {0} et sera 1)
puis met un point ensuite prend un deuxième caractère (ici {1} et sera ItemMenu) 
*/

/* formatage une étape
*/

/* formatage deux étapes
//string ItemMenu = "nouvelle partie";
//string resultatFormattage = string.Format(format, 1, ItemMenu.Substring(0, 1).ToUpper() + ItemMenu.Substring(1).ToLower());
//Console.WriteLine(resultatFormattage);
*/

/* Ancien affichage du menu
string ItemMenu = "nouvelle partie";
Console.WriteLine(format, 1, ItemMenu.Substring(0, 1).ToUpper() + ItemMenu.Substring(1).ToLower());

ItemMenu = "Charger partie";
string resultatFormattage = $"{2}. {ItemMenu.Substring(0, 1).ToUpper() + ItemMenu.Substring(1).ToLower()}";   //string.Format(format, 1, ItemMenu.Substring(0, 1).ToUpper() + ItemMenu.Substring(1).ToLower());
Console.WriteLine(resultatFormattage);

ItemMenu = "Credits";
resultatFormattage = string.Format(format, 3, ItemMenu.Substring(0, 1).ToUpper() + ItemMenu.Substring(1).ToLower());
Console.WriteLine(resultatFormattage);

ItemMenu = "Quitter";
resultatFormattage = string.Format(format, 4, ItemMenu.Substring(0, 1).ToUpper() + ItemMenu.Substring(1).ToLower());
Console.WriteLine(resultatFormattage);

*/

/* Première étape avant formattage
// prend la var, prend premier caractère -> upper et ajoute le reste (à partir du deuxième car) -> lower
//Console.WriteLine(1 + "." + ItemMenu.Substring(0, 1).ToUpper() + ItemMenu.Substring(1).ToLower());
//Console.WriteLine(2 + "." + "Charger partie");
//Console.WriteLine(3 + "." + "Credits");
//Console.WriteLine(4 + "." + "Quitter");
*/

#endregion

// créer classe qui représente le menu
// sous classe item du menu

AfficherMenu();

#endregion

#region --- PARTIE SAISIE INFORMATIONS JOUER ---

int ageJoueur = RecupereAgeValide();

Console.WriteLine(ageJoueur);

/* première façon de faire
//if (estAgeValide == false)
//{
//    Console.WriteLine("Age interdit !");
//    Environment.Exit(0);
//}
*/

#endregion

#region --- DATE DE NAISSANCE --- 

DateOnly dateNaissance = RecupererEtAfficherDateDeNaissance();
player.DateDeNaissance = dateNaissance;

Console.WriteLine($"Le player a la date {player.DateDeNaissance}");


//var player2 = new Player();
//Console.WriteLine($"Le player a la date {player2.DateDeNaissance}");

#endregion

#region --- PREPARATION ARME ---

AfficherArmes();

// int valeurPuissanceArmeX = (int) puissanceArme;

#endregion

#region --- CHOIX COTÉ FORCE ---

// classe force; puis lister force
// selctionner et affecter au player

AfficherForceSelectionnee();

#endregion

#region --- AFFICHAGE CREDITS ---

AffichageCredits();

#endregion

#region --- Lancement du Jeu ---

player.SeDeplacer(new Position(x : 1, y : 1));
// player.SeDeplacer(new Position() { X = 1, Y = 1 });
player.Attaquer(ennemi);

ennemi.SeDeplacer();
ennemi.Attaquer(player);

#endregion