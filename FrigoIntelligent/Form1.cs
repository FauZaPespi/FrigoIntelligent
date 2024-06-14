using Frigo_V1.Classe;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FrigoIntelligent
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Instance de la classe Frigo.
        /// </summary>
        public Frigo frigo = new Frigo();

        /// <summary>
        /// Constructeur de la classe Form1.
        /// Initialise les composants et les éléments du frigo.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            frigo.InitialiseItems();
            frigo.InitRecette();
            frigo.AllAlimentName();
        }

        /// <summary>
        /// Gère l'événement du clic sur le bouton Ajouter.
        /// Ajoute un nouvel aliment au frigo en fonction de la sélection de l'utilisateur.
        /// </summary>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string selectedRadioButtonValue = "";

            if (radBtnBoisson.Checked)
            {
                selectedRadioButtonValue = radBtnBoisson.Text;
            }
            else if (radBtnLegume.Checked)
            {
                selectedRadioButtonValue = radBtnLegume.Text;
            }
            else if (radBtnViande.Checked)
            {
                selectedRadioButtonValue = radBtnViande.Text;
            }

            frigo.AjouterItem(txtboxName.Text, (float)Convert.ToDouble(txtBoxQuant.Text), selectedRadioButtonValue);
            ReloadItem();
            panelAdd.Hide();
            frigo.AllAlimentName();
        }

        /// <summary>
        /// Gère l'événement du clic sur le bouton Pancake.
        /// Trouve la recette Pancake.
        /// </summary>
        private void btn_tryPancake_Click(object sender, EventArgs e)
        {
            frigo.FindRecette("Pancake");
        }

        /// <summary>
        /// Gère l'événement du clic sur le bouton Burger.
        /// Trouve la recette Burger.
        /// </summary>
        private void btn_tryBurger_Click(object sender, EventArgs e)
        {
            frigo.FindRecette("Burger");
        }

        /// <summary>
        /// Gère l'événement du clic sur le bouton Sandwich.
        /// Trouve la recette Sandwich.
        /// </summary>
        private void btn_trySandwich_Click(object sender, EventArgs e)
        {
            frigo.FindRecette("Sandwich");
        }

        /// <summary>
        /// Gère l'événement du chargement du formulaire.
        /// Initialise l'affichage des catégories du frigo et recharge les éléments.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            panelAdd.Hide();
            AjouterFrigoEtCateg();
            ReloadItem();
        }

        /// <summary>
        /// Gère l'événement de la sélection d'un nœud dans le TreeView.
        /// Affiche la quantité de l'aliment sélectionné dans une infobulle.
        /// </summary>
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            toolTip1.SetToolTip(treeView1, $"Quantité: {FromNameToSize(treeView1.SelectedNode.Text)}");
        }

        /// <summary>
        /// Obtient la quantité d'un aliment à partir de son nom.
        /// </summary>
        /// <param name="alimentName">Le nom de l'aliment.</param>
        /// <returns>La quantité de l'aliment.</returns>
        public float FromNameToSize(string alimentName)
        {
            float SizeVal = 0;

            foreach (Aliments aliment in frigo.FrigoConstru)
            {
                if (aliment.Nom == alimentName)
                {
                    SizeVal = aliment.Quantite;
                }
            }
            return SizeVal;
        }

        /// <summary>
        /// Gère l'événement du clic sur le bouton Ajouter Aliment.
        /// Affiche ou masque le panneau d'ajout d'aliment.
        /// </summary>
        private void btn_AddAliment_Click(object sender, EventArgs e)
        {
            if (!panelAdd.Visible)
            {
                panelAdd.Show();
                Console.WriteLine(1);
            }
            else
            {
                panelAdd.Hide();
            }
        }

        /// <summary>
        /// Recharge les éléments du frigo dans le TreeView.
        /// </summary>
        private void ReloadItem()
        {
            treeView1.Nodes[0].Nodes[0].Nodes.Clear();
            treeView1.Nodes[0].Nodes[1].Nodes.Clear();
            treeView1.Nodes[0].Nodes[2].Nodes.Clear();
            treeView1.BeginUpdate();
            foreach (Aliments aliment in frigo.FrigoConstru.Where(aliment => aliment is Boissons))
            {
                treeView1.Nodes[0].Nodes[1].Nodes.Add(aliment.Nom);
            }
            foreach (Aliments aliment in frigo.FrigoConstru.Where(aliment => aliment is Viandes))
            {
                treeView1.Nodes[0].Nodes[0].Nodes.Add(aliment.Nom);
            }
            foreach (Aliments aliment in frigo.FrigoConstru.Where(aliment => aliment is Legumes))
            {
                treeView1.Nodes[0].Nodes[2].Nodes.Add(aliment.Nom);
            }
            treeView1.EndUpdate();
        }

        /// <summary>
        /// Gère l'événement du clic sur le bouton Supprimer Aliment.
        /// Supprime l'aliment sélectionné dans le TreeView.
        /// </summary>
        private void btn_DelAliment_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                if (treeView1.SelectedNode.IsSelected)
                {
                    if (!InterditeDel())
                    {
                        frigo.RemoveFromFrigo(treeView1.SelectedNode.Text);
                        treeView1.SelectedNode.Remove();
                        treeView1.SelectedNode = null;
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un item");
            }
        }

        /// <summary>
        /// Vérifie si l'aliment sélectionné est interdit de suppression.
        /// </summary>
        /// <returns>True si l'aliment est interdit de suppression, sinon False.</returns>
        private bool InterditeDel()
        {
            if (treeView1.SelectedNode.Text == treeView1.Nodes[0].Text)
            {
                MessageBox.Show("Arretez de détruire votre frigo");
                return true;
            }
            else if (treeView1.SelectedNode.Text == treeView1.Nodes[0].Nodes[0].Text)
            {
                MessageBox.Show("Arretez de détruire votre cuisine");
                return true;
            }
            else if (treeView1.SelectedNode.Text == treeView1.Nodes[0].Nodes[1].Text)
            {
                MessageBox.Show("Arretez de détruire votre cuisine");
                return true;
            }
            else if (treeView1.SelectedNode.Text == treeView1.Nodes[0].Nodes[2].Text)
            {
                MessageBox.Show("Arretez de détruire votre cuisine");
                return true;
            }
            return false;
        }

        /// <summary>
        /// Ajoute les catégories du frigo dans le TreeView.
        /// </summary>
        private void AjouterFrigoEtCateg()
        {
            treeView1.BeginUpdate();
            treeView1.Nodes.Add("Frigo");
            treeView1.Nodes[0].Nodes.Add("Viandes");
            treeView1.Nodes[0].Nodes.Add("Boissons");
            treeView1.Nodes[0].Nodes.Add("Legumes");
            treeView1.EndUpdate();
        }
    }
}