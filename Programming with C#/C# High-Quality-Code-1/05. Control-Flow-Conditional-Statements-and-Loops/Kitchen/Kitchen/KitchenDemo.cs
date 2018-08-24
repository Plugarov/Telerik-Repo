//Refactor the following class using best practices for organizing straight-line code:

//public class Chef
//{
//    private Bowl GetBowl()
//    {
//        //... 
//    }
//    private Carrot GetCarrot()
//    {
//        //...
//    }
//    private void Cut(Vegetable potato)
//    {
//        //...
//    }
//    public void Cook()
//    {
//        Potato potato = GetPotato();
//        Carrot carrot = GetCarrot();
//        Bowl bowl;
//        Peel(potato);

//        Peel(carrot);
//        bowl = GetBowl();
//        Cut(potato);
//        Cut(carrot);
//        bowl.Add(carrot);

//        bowl.Add(potato);
//    }
//    private Potato GetPotato()
//    {
//        //...
//    }
//}

namespace Kitchen
{
    using Kitchen.Food;
    using Kitchen.Interfaces;
    using Kitchen.Appearance;


    class KitchenDemo
    {
        static void Main(string[] args)
        {
            IVegetable carrot = new Carrot();
            IVegetable patato = new Patato();
            IVegetable paper = new Paper();

            IVegetable vegetables = new Vegetables();

            IAppearance bowl = new Bowl();
            IAppearance steamer = new Steamer();

            Chef chef = new Chef();

            chef.Wash();
            chef.Cut();
            chef.Prepare(bowl);
            chef.Cook(steamer);
            chef.Serve();
        }
    }
}
