namespace Frigo_V1.Classe
{
    public class Aliments
    {
        private string _nom;
        private float _quantite;
        public Aliments(string nom, float quantite)
        {
            _nom = nom;
            _quantite = quantite;
        }
        public string Nom { get => _nom; set => _nom = value; }
        public float Quantite { get => _quantite; set => _quantite = value; }
    }
}
