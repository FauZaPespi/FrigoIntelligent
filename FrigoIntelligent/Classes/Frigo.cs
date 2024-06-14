using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Frigo_V1.Classe
{
	public class Frigo
	{
		private Dictionary<string, string[]> recettes = new Dictionary<string, string[]>();
		private List<Aliments> _Frigo = new List<Aliments>();
		const string URLMIGROS = "https://www.migros.ch/fr/search?query=";
		private List<string> alimentName = new List<string>();


		public List<Aliments> FrigoConstru
		{
			get => _Frigo;
		}
		/// <summary>
		/// Ajouter item dans le frigo 
		/// </summary>
		/// <param name="nomAliment">Nom d'aliment</param>
		/// <param name="quantite">Quantité</param>
		/// <param name="categorie">Categorie ou Type d'alimen</param>
		public void AjouterItem(string nomAliment, float quantite, string categorie)
		{
			if (categorie == "Viande")
			{
				foreach (Aliments aliment in FrigoConstru.Where(aliment => aliment is Viandes))
				{
					if (aliment.Nom == nomAliment)
					{
						aliment.Quantite = aliment.Quantite + quantite;
						return;
					}
				}
				_Frigo.Add(new Viandes(nomAliment, quantite));
			}
			else if (categorie == "Legume")
			{
				foreach (Aliments aliment in FrigoConstru.Where(aliment => aliment is Legumes))
				{
					if (aliment.Nom == nomAliment)
					{
						aliment.Quantite = aliment.Quantite + quantite;
						return;
					}
				}
				_Frigo.Add(new Legumes(nomAliment, quantite));
			}
			else if (categorie == "Boisson")
			{
				foreach (Aliments aliment in FrigoConstru.Where(aliment => aliment is Boissons))
				{
					if (aliment.Nom == nomAliment)
					{
						aliment.Quantite = aliment.Quantite + quantite;
						return;
					}
				}
				_Frigo.Add(new Boissons(nomAliment, quantite));
			}
		}
		/// <summary>
		/// Supprimer item dans le frigo 
		/// </summary>
		/// <param name="nomAliment">Nom d'aliment que vous souhaitez à supprimer.</param>
		public void RemoveFromFrigo(string nomAliment)
		{
			int idAliment = int.MaxValue;
			foreach (Aliments aliment in _Frigo.Where(aliment => aliment.Nom == nomAliment))
			{
				idAliment = _Frigo.IndexOf(aliment);
			}
			_Frigo.RemoveAt(idAliment);
			idAliment = -1;

		}
		/// <summary>
		/// Initialiser les items au frigo.
		/// </summary>
		public void InitialiseItems()
		{
			Aliments poulet = new Viandes("Poulet", 100);
			Aliments coca = new Boissons("Coca", 1);
			Aliments salad = new Legumes("Salad", 2);
			Aliments boeuf = new Viandes("Boeuf", 5);
			Aliments sel = new Boissons("Sel", 0);
			_Frigo.Add(poulet);
			_Frigo.Add(coca);
			_Frigo.Add(salad);
			_Frigo.Add(boeuf);
			_Frigo.Add(sel);
			_Frigo.Add(new Legumes("Avocat",10));
			_Frigo.Add(new Legumes("Pain", 10));
			_Frigo.Add(new Legumes("Mayonnaise", 10));
			_Frigo.Add(new Legumes("Laitue", 10));

		}
		/// <summary>
		/// Ininitialiser les recettes. 
		/// </summary>
		public void InitRecette()
		{
			recettes.Add("Pancake$ÉTAPE 1\r\nFaire fondre le beurre, dans une casserole à feu doux ou dans un bol au micro-ondes.\r\n\r\nÉTAPE 2\r\nMettre la farine, la levure et le sucre dans un saladier. Mélanger et creuser un puits.\r\n\r\nÉTAPE 3\r\nAjouter ensuite les oeufs entiers et fouetter l'ensemble.\r\n\r\nÉTAPE 4\r\nIncorporer le beurre fondu, fouetter puis délayer progressivement le mélange avec le lait afin d'éviter les grumeaux.\r\n\r\nÉTAPE 5\r\nLaisser reposer la pâte au minimum 1 heure au réfrigérateur.\r\n\r\nÉTAPE 6\r\nDans une poêle chaude et légèrement huilée, faire cuire comme des crêpes, mais en les faisant plus petites. Réserver au chaud et déguster.",
						new string[] { "Sel$12$g", "Beurre$12$g", "Levure$12$g", "Sucre$12$g", "Farine$12$g", "Oeufs$1$r", "Lait$1$l6" });
			recettes.Add("Burger$ÉTAPE 1\r\nTranchez de fines lamelles d'emmental afin de recouvrir la partie inférieure de votre pain à burger. Mettez ensuite au four sur le mode grill le temps de faire fondre le fromage.\r\n\r\nÉTAPE 2\r\nCoupez l'oignon de manière à obtenir de fines et grandes lamelles. Coupez la tomate en grandes tranches également. Coupez 2 à 3 grandes feuilles de salade en lamelles fines et longues.\r\n\r\nÉTAPE 3\r\nHachez en tout petits morceaux les cornichons et mélangez-les à la mayonnaise préalablement préparée.\r\n\r\nÉTAPE 4\r\nMettez au four la partie supérieure de votre pain à burger.\r\n\r\nÉTAPE 5\r\nFaites ensuite cuire à votre convenance votre steak haché dans une poêle avec du beurre ou de l'huile ou utilisez un grill. Assaisonnez généreusement en sel et poivre.\r\n\r\nÉTAPE 6\r\nSortez ensuite les deux parties de votre pain à burger. Disposez sur la partie avec le fromage fondu votre steak haché sur lequel vous allez étaler votre mayonnaise. Déposez ensuite une à deux grandes tranches de tomate puis la salade verte.\r\n\r\nÉTAPE 7\r\nSur la partie supérieure de votre pain, étaler du ketchup de manière à le recouvrir complètement, puis disposez vos lamelles d'oignons.\r\n\r\nÉTAPE 8\r\nRefermez. Bon appétit !",
									new string[] { "Pain burger$1$pièce", "Emmental$2$tranche", "Oignon$1$moyen", "Tomate$1$g", "Salade$2$feuille", "Cornichons$50$g", "Mayonnaise$2$cc", "Steak haché$1$pièce", "Ketchup$2$cc" });
			recettes.Add("Sandwich$ÉTAPE 1\r\nGrillez légèrement les tranches de pain au grille-pain ou au four.\r\n\r\nÉTAPE 2\r\nÉtalez une fine couche de mayonnaise sur une des tranches de pain.\r\n\r\nÉTAPE 3\r\nCoupez l'avocat en tranches fines et disposez-les sur la mayonnaise.\r\n\r\nÉTAPE 4\r\nAjoutez les tranches de poulet rôti par-dessus les tranches d'avocat.\r\n\r\nÉTAPE 5\r\nLavez et coupez la tomate en fines rondelles, puis placez-les sur le poulet.\r\n\r\nÉTAPE 6\r\nAjoutez des feuilles de laitue sur les tomates.\r\n\r\nÉTAPE 7\r\nRecouvrez le tout avec la deuxième tranche de pain grillé.\r\n\r\nÉTAPE 8\r\nCoupez le sandwich en deux et servez. Bon appétit !",
						new string[] { "Pain$2$trance", "Mayonnaise$2$cc", "Avocat$1$g", "Poulet$100$g", "Tomate$1$g", "Laitue$3$feuille" });
		}
		public void AllAlimentName()
		{
			foreach (Aliments aliment in _Frigo)
			{
				alimentName.Add(aliment.Nom);
			}
		}
		/// <summary>
		/// Chercher la recette 
		/// - Verifie le nom de recette s'il est exits dans la liste
		/// - Prends tous les ingredients qui est dans la recette 
		/// Verifie tous si les éléments sont dans le frigo 
		/// - Si bon : Affichier les étapes pour faire la recette 
		/// - Sinon : Indique tous les éléments qui manque et afficher un messager pour aller vers un site 
		/// </summary>
		/// <param name="recette">Nom de la recette </param>
		public void FindRecette(string recette)
		{
			List<string> alimentManque = new List<string>() ;
			string messageSortiErreur = "";
			string messageSortiSuccess = "";
			foreach (KeyValuePair<string, string[]> nomRecette in recettes)
			{
				string nomDeLaRecette = nomRecette.Key.Split('$')[0];
				//Verfie le nom de la recette
				if (nomDeLaRecette == recette)
				{
					//Verifie tous les ingredients dans la recette s'il est exits dans le frigo
					foreach (string nomIngredient in nomRecette.Value)
					{
						//Prends le nom de la recette
						string alimentNameTxt = nomIngredient.Split('$')[0];
						//Verifie si l'aliment est dans le frigo						
						if (alimentName.Contains(alimentNameTxt))
						{
							foreach (Aliments aliment in _Frigo)
							{
								if (aliment.Nom == alimentNameTxt)
								{
									float QuantiteAliment = Convert.ToInt32(nomIngredient.Split('$')[1]);
									//On verifie la quantité de l'ingredient avec l'aliment 
									if (aliment.Quantite < QuantiteAliment)
									{
										Console.WriteLine($"Vous n'avez pas assez de {alimentNameTxt}, il vous en manque {QuantiteAliment- aliment.Quantite}{nomIngredient.Split('$')[2]}");
										messageSortiErreur += $"Vous n'avez pas assez de {alimentNameTxt}, il vous en manque {QuantiteAliment- aliment.Quantite}{nomIngredient.Split('$')[2]}\n";
										alimentManque.Add(alimentNameTxt);
										//CommandeMigros(alimentNameTxt);
									}
									else
									{
                                        Console.WriteLine("Vous avez l'ingrédient");
										messageSortiSuccess = nomRecette.Key.Split('$')[1];
                                    }
								}
							}
						}
						else
						{
							Console.WriteLine($"vous n'avez pas {alimentNameTxt} ");
							messageSortiErreur += $"Vous n'avez pas {alimentNameTxt} \n";
							alimentManque.Add(alimentNameTxt);
						}
					}
				}

			}
            if (alimentManque.Count == 0)
            {
                MessageBox.Show(messageSortiSuccess, "Frigo Intelligent"); 
            }
            else
            {
				messageSortiErreur += "\r\nVoulez-vous commander les aliments manquants ?";
				DialogResult dialogResult = MessageBox.Show(messageSortiErreur, "Frigo Intelligent", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					for (int i = 0; i < alimentManque.Count; i++)
					{
						CommandeMigros(alimentManque[i]);
					}
				}
				else if (dialogResult == DialogResult.No)
				{
					
				}
			}
		}
		/// <summary>
		/// Envoye l'utlisateur vers le site du Migros.
		/// </summary>
		/// <param name="nom"></param>
		static void CommandeMigros(string nom)
		{
			string nomR = nom.Replace(" ", "%20");
			string urlComplete = URLMIGROS + nom;
			System.Diagnostics.Process.Start(new ProcessStartInfo
			{
				FileName = urlComplete,
				UseShellExecute = true
			});
			System.Threading.Thread.Sleep(1000);
		}

	}
}
