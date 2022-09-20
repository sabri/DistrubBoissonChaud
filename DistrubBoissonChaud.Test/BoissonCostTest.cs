

using DistrubBoissonChaud;

namespace TestFunctions
{
    [TestFixture]
    public class BoissonCostTest
    {
        // cost of the Expresso recipe
        [Test]
        public void CalculCost_Expresso_boisson()
        {
            Recette rec = new Recette();
            rec.Name = "expresso";
            rec.Cafe = 1;
            rec.Eau = 1;
            var res = BoissonCost.CalculCostBoission(rec);
            string expect = "Le prix de recette expresso est 1.2 et le prix de Vente est 1.56";
            Assert.That(res, Is.EqualTo(expect));
        }
        // cost of the allong� recipe 
        [Test]
        public void CalculCost_allong�_boisson()
        {
            Recette rec = new Recette();
            rec.Name = "allong�";
            rec.Cafe = 1;
            rec.Eau = 2;
            var res = BoissonCost.CalculCostBoission(rec);
            string expect = "Le prix de recette allong� est 1.4 et le prix de Vente est 1.8199999999999998";
            Assert.That(res, Is.EqualTo(expect));
        }
        // cost of the allonge recipe when you forget to put �
        [Test]
        public void CalculCost_allonge_boisson()
        {
            Recette rec = new Recette();
            rec.Name = "allonge";
            rec.Cafe = 1;
            rec.Eau = 2;
            var res = BoissonCost.CalculCostBoission(rec);
            string expect = "Le prix de recette allonge est 1.4 et le prix de Vente est 1.8199999999999998";
            Assert.That(res, Is.EqualTo(expect));
        }
        // cost of the capuccino recipe 
        [Test]
        public void CalculCost_capuccino_boisson()
        {
            Recette rec = new Recette();
            rec.Name = "capuccino";
            rec.Cafe = 1;
            rec.Choclat = 1;
            rec.Eau = 1;
            rec.Creme = 1;
            var res = BoissonCost.CalculCostBoission(rec);
            string expect = "Le prix de recette capuccino est 2.7 et le prix de Vente est 3.5100000000000002";
            Assert.That(res, Is.EqualTo(expect));
        }
        // cost of the chocolat recipe 

        [Test]
        public void CalculCost_Chocolat_boisson()
        {
            Recette rec = new Recette();
            rec.Name = "chocolat";
            rec.Lait = 2;
            rec.Choclat = 3;
            rec.Eau = 1;
            rec.Sucre = 1;
            var res = BoissonCost.CalculCostBoission(rec);
            string expect = "Le prix de recette chocolat est 4.1 et le prix de Vente est 5.329999999999999";
            Assert.That(res, Is.EqualTo(expect));
        }
        // cost of the th� recipe

        [Test]
        public void CalculCost_th�_boisson()
        {
            Recette rec = new Recette();
            rec.Name = "th�";
            rec.The = 1;
            rec.Eau = 2;
            var res = BoissonCost.CalculCostBoission(rec);
            string expect = "Le prix de recette th� est 2.4 et le prix de Vente est 3.12";
            Assert.That(res, Is.EqualTo(expect));
        }
        // cost of the th� recipe  when you forget to Put �
        [Test]
        public void CalculCost_the_boisson()
        {
            Recette rec = new Recette();
            rec.Name = "the";
            rec.The = 1;
            rec.Eau = 2;
            var res = BoissonCost.CalculCostBoission(rec);
            string expect = "Le prix de recette the est 2.4 et le prix de Vente est 3.12";
            Assert.That(res, Is.EqualTo(expect));
        }
        [Test]
        public void CalculCost_autre_boisson()
        {
            Recette rec = new Recette();
            rec.Name = "autre";
            rec.The = 1;
            rec.Eau = 2;
            rec.Choclat = 0;
            rec.Creme = 0;
            var res = BoissonCost.CalculCostBoission(rec);
            string expect = "Le prix de recette autre est 2.4 et le prix de Vente est 3.12";
            Assert.That(res, Is.EqualTo(expect));
        }
    }
}