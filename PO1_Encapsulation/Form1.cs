namespace PO1_Encapsulation
{
    public partial class Form1 : Form
    {
        Personnage joueur = new Personnage();
        Personnage dragon = new();

        public Form1()
        {
            InitializeComponent();
            //Personnage personnage = new Personnage(); //acceder au personnage
            //personnage.PointsDePuissance = 5;
            //personnage.PointsDeVie = -10;
            //personnage.Nom = "Flash";
            //MessageBox.Show(personnage.PointsDeVie.ToString());

            //DateTime momentPresent = DateTime.Now;
            //momentPresent.Year = 1; // on ne peut pas modidier momentPresent, c'est en lecture seule

            //if (personnage.EstEnVie)
            //{
            //    MessageBox.Show("Vous êtes en vie.");
            //}

            joueur.PointsDeVie = 10;
            joueur.PointsDePuissance = 1;

            dragon.PointsDeVie = joueur.PointsDeVie * 3;
            dragon.PointsDePuissance = 3;
        }

        private void ActualiserLabels()
        {
            lbl_pointsVieJoueur.Text = "Vie du joueur : " + joueur.PointsDeVie.ToString();
            lbl_puissanceAttaqueJoueur.Text = "Puissance d'attaque du joueur : " + joueur.PointsDePuissance.ToString();

            lbl_pointsVieDragon.Text = "Vie du dragon: " + dragon.PointsDeVie.ToString();
            lbl_puissanceAttaqueDragon.Text = "Puissance d'attaque du dragon: " + dragon.PointsDePuissance.ToString();
        }

        private void btn_attaquer_Click(object sender, EventArgs e)
        {
            dragon.PointsDeVie -= joueur.PointsDePuissance;
            ActualiserLabels();
        }

        private void btn_seSoigner_Click(object sender, EventArgs e)
        {
            ActualiserLabels();
        }

        private void btn_puissanceAttaque_Click(object sender, EventArgs e)
        {
            ActualiserLabels();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualiserLabels();
        }
    }
}