

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
        // cost of the allongé recipe 
        [Test]
        public void CalculCost_allongé_boisson()
        {
            Recette rec = new Recette();
            rec.Name = "allongé";
            rec.Cafe = 1;
            rec.Eau = 2;
            var res = BoissonCost.CalculCostBoission(rec);
            string expect = "Le prix de recette allongé est 1.4 et le prix de Vente est 1.8199999999999998";
            Assert.That(res, Is.EqualTo(expect));
        }
        // cost of the allonge recipe when you forget to put é
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
        // cost of the thé recipe

        [Test]
        public void CalculCost_thé_boisson()
        {
            Recette rec = new Recette();
            rec.Name = "thé";
            rec.The = 1;
            rec.Eau = 2;
            var res = BoissonCost.CalculCostBoission(rec);
            string expect = "Le prix de recette thé est 2.4 et le prix de Vente est 3.12";
            Assert.That(res, Is.EqualTo(expect));
        }
        // cost of the thé recipe  when you forget to Put é
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