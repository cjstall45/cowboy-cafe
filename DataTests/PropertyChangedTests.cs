using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class AngyChickenPropertyChangedTests
    {
        /// <summary>
        /// test to check if AngryChicken implements INotifyPropertyChanged Interface
        /// </summary>
        [Fact]
        public void AngryChickenShouldImplentINotifyPropertyChanged()
        {
            var chicken = new AngryChicken();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chicken);
        }
        /// <summary>
        /// Changing bread should notify property changed
        /// </summary>
        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForBread()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "Bread", () =>
            {
                chicken.Bread = false;
            }
            );
        }

        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedforSpecialInstructions()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () => { chicken.Bread = false; });
        }

        [Fact]
        public void ChangingPickelShouldInvokePropertyChangedforPickle()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "Pickle", () =>
            {
                chicken.Pickle = false;
            }
            );
        }

        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedforSpecialInstructions()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () => { chicken.Pickle = false; });
        }
    }

    public class SidePropertyChangedTests
    {
        [Fact]
        public void BakedBeansShouldImplentINotifyPropertyChanged()
        {
            var item = new BakedBeans();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        [Fact]
        public void ChiliCheeseFriesShouldImplentINotifyPropertyChanged()
        {
            var item = new ChiliCheeseFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        [Fact]
        public void CornDodgersShouldImplentINotifyPropertyChanged()
        {
            var item = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        [Fact]
        public void PanDeCampoShouldImplentINotifyPropertyChanged()
        {
            var item = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedforSize()
        {
            var item = new BakedBeans();
            Assert.PropertyChanged(item , "Size", () => { item.Size = Size.Large; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedforPrice()
        {
            var item = new BakedBeans();
            Assert.PropertyChanged(item, "Price", () => { item.Size = Size.Large; });
        }
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedforCalories()
        {
            var item = new BakedBeans();
            Assert.PropertyChanged(item, "Calories", () => { item.Size = Size.Large; });
        }




    }

    public class CowboyCoffeePropertyChangedTests
    {
        [Fact]
        public void CowboyCoffeeShouldImplentINotifyPropertyChanged()
        {
            var item = new CowboyCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedforSize()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "Size", () => { item.Size = Size.Large; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedforPrice()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "Price", () => { item.Size = Size.Large; });
        }
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedforCalories()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "Calories", () => { item.Size = Size.Large; });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedforIce()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "Ice", () => { item.Ice = true; });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedforSpecialInstructions()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Ice = true; });
        }

        [Fact]
        public void ChangingDecafShouldInvokePropertyChangedforDecaf()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "Decaf", () => { item.Decaf = true; });
        }

        [Fact]
        public void ChangingDecafShouldInvokePropertyChangedforSpecialInstructions()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Decaf = true; });
        }

        [Fact]
        public void ChangingRoomForCreamShouldInvokePropertyChangedforRoomForCream()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "RoomForCream", () => { item.RoomForCream = true; });
        }

        [Fact]
        public void ChangingSugarShouldInvokePropertyChangedforSpecialInstructions()
        {
            var item = new CowboyCoffee();
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.RoomForCream = true; });
        }
    }

    public class WaterPropertyChangedTests
    {
        [Fact]
        public void WaterShouldImplentINotifyPropertyChanged()
        {
            var item = new Water();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedforSize()
        {
            var item = new Water();
            Assert.PropertyChanged(item, "Size", () => { item.Size = Size.Large; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedforPrice()
        {
            var item = new Water();
            Assert.PropertyChanged(item, "Price", () => { item.Size = Size.Large; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedforCalories()
        {
            var item = new Water();
            Assert.PropertyChanged(item, "Calories", () => { item.Size = Size.Large; });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedforIce()
        {
            var item = new Water();
            Assert.PropertyChanged(item, "Ice", () => { item.Ice = false; });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedforSpecialInstructions()
        {
            var item = new Water();
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Ice = false; });
        }

        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedforLemon()
        {
            var item = new Water();
            Assert.PropertyChanged(item, "Lemon", () => { item.Lemon = true; });
        }

        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedforSpecialInstructions()
        {
            var item = new Water();
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Lemon = true; });
        }
    }

    public class TexasTeaPropertyChangedTest
    {
        [Fact]
        public void TexasTeaShouldImplentINotifyPropertyChanged()
        {
            var item = new TexasTea();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedforSize()
        {
            var item = new TexasTea();
            Assert.PropertyChanged(item, "Size", () => { item.Size = Size.Large; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedforPrice()
        {
            var item = new TexasTea();
            Assert.PropertyChanged(item, "Price", () => { item.Size = Size.Large; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedforCalories()
        {
            var item = new TexasTea();
            Assert.PropertyChanged(item, "Calories", () => { item.Size = Size.Large; });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedforIce()
        {
            var item = new TexasTea();
            Assert.PropertyChanged(item, "Ice", () => { item.Ice = false; });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedforSpecialInstructions()
        {
            var item = new TexasTea();
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Ice = false; });
        }

        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedforLemon()
        {
            var item = new TexasTea();
            Assert.PropertyChanged(item, "Lemon", () => { item.Lemon = true; });
        }

        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedforSpecialInstructions()
        {
            var item = new TexasTea();
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Lemon = true; });
        }

        [Fact]
        public void ChangingSweetShouldInvokePropertyChangedforSweet()
        {
            var item = new TexasTea();
            Assert.PropertyChanged(item, "Sweet", () => { item.Sweet = false; });
        }

        [Fact]
        public void ChangingSweetShouldInvokePropertyChangedforSpecialInstructions()
        {
            var item = new TexasTea();
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Sweet = false; });
        }

        [Fact]
        public void ChangingSweetShouldInvokePropertyChangedforCalories()
        {
            var item = new TexasTea();
            Assert.PropertyChanged(item, "Calories", () => { item.Sweet = false; });
        }
    }

    public class JerkedSodaPropertyChangedTests
    {
        [Fact]
        public void JerkedSodaShouldImplentINotifyPropertyChanged()
        {
            var item = new JerkedSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedforSize()
        {
            var item = new JerkedSoda();
            Assert.PropertyChanged(item, "Size", () => { item.Size = Size.Large; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedforPrice()
        {
            var item = new JerkedSoda();
            Assert.PropertyChanged(item, "Price", () => { item.Size = Size.Large; });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedforCalories()
        {
            var item = new JerkedSoda();
            Assert.PropertyChanged(item, "Calories", () => { item.Size = Size.Large; });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedforIce()
        {
            var item = new JerkedSoda();
            Assert.PropertyChanged(item, "Ice", () => { item.Ice = false; });
        }

        [Fact]
        public void ChangingIceShouldInvokePropertyChangedforSpecialInstructions()
        {
            var item = new JerkedSoda();
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Ice = false; });
        }

        [Fact]
        public void ChangingFlavorShouldInvokePropertyChangedforFlavor()
        {
            var item = new JerkedSoda();
            Assert.PropertyChanged(item, "Flavor", () => { item.Flavor = SodaFlavor.RootBeer; });
        }
    }

    public class PecosPulledPorkPropertyChangedTests
    {
        [Fact]
        public void PecosPulledPorkShouldImplentINotifyPropertyChanged()
        {
            var chicken = new PecosPulledPork();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chicken);
        }
        /// <summary>
        /// Changing bread should notify property changed
        /// </summary>
        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForBread()
        {
            var chicken = new PecosPulledPork();
            Assert.PropertyChanged(chicken, "Bread", () =>
            {
                chicken.Bread = false;
            }
            );
        }
        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedforSpecialInstructions()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () => { chicken.Bread = false; });
        }

        

        [Fact]
        public void ChangingPickelShouldInvokePropertyChangedforPickle()
        {
            var chicken = new PecosPulledPork();
            Assert.PropertyChanged(chicken, "Pickle", () =>
            {
                chicken.Pickle = false;
            }
            );
        }

        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedforSpecialInstructions()
        {
            var chicken = new PecosPulledPork();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () => { chicken.Pickle = false; });
        }
    }

    public class CowpokeChiliPropertyChangedTests
    {
        [Fact]
        public void CowpokeChiliShouldImplentINotifyPropertyChanged()
        {
            var chicken = new CowpokeChili();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chicken);
        }

        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedforCheese()
        {
            var chicken = new CowpokeChili();
            Assert.PropertyChanged(chicken, "Cheese", () =>
            {
                chicken.Cheese = false;
            }
            );
        }

        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedforSpecialInstructions()
        {
            var chicken = new CowpokeChili();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () => { chicken.Cheese = false; });
        }

        [Fact]
        public void ChangingSourCreamShouldInvokePropertyChangedforSourCream()
        {
            var chicken = new CowpokeChili();
            Assert.PropertyChanged(chicken, "SourCream", () =>
            {
                chicken.SourCream = false;
            }
            );
        }

        [Fact]
        public void ChangingSourCreamShouldInvokePropertyChangedforSpecialInstructions()
        {
            var chicken = new CowpokeChili();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () => { chicken.SourCream = false; });
        }

        [Fact]
        public void ChangingGreenOnionsShouldInvokePropertyChangedforGreenOnions()
        {
            var chicken = new CowpokeChili();
            Assert.PropertyChanged(chicken, "GreenOnions", () =>
            {
                chicken.GreenOnions = false;
            }
            );
        }

        [Fact]
        public void ChangingGreenOnionsShouldInvokePropertyChangedforSpecialInstructions()
        {
            var chicken = new CowpokeChili();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () => { chicken.GreenOnions = false; });
        }

        [Fact]
        public void ChangingTortillaStripsShouldInvokePropertyChangedforCheese()
        {
            var chicken = new CowpokeChili();
            Assert.PropertyChanged(chicken, "TortillaStrips", () =>
            {
                chicken.TortillaStrips = false;
            }
            );
        }

        [Fact]
        public void ChangingTortillaStripsShouldInvokePropertyChangedforSpecialInstructions()
        {
            var chicken = new CowpokeChili();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () => { chicken.TortillaStrips = false; });
        }
    }

    public class TexasTripleBurgerChangedPropertyTests
    {
        [Fact]
        public void TexasTripleBurgerShouldImplentINotifyPropertyChanged()
        {
            var item = new TexasTripleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        [Fact]
        public void ChangingBunShouldInvokePropertyChangedforBun()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "Bun", () => { item.Bun = false; });
        }

        [Fact]
        public void ChangingBunShouldInvokePropertyChangedforSpecialInstructions()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Bun = false; });
        }

        

        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedforChese()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "Cheese", () => { item.Cheese = false; });
        }

        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedforSpecialInstructions()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Cheese = false; });
        }

        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedforKetchup()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "Ketchup", () => { item.Ketchup = false; });
        }

        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedforSpecialInstructions()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Ketchup = false; });
        }

        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedforMustard()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "Mustard", () => { item.Mustard = false; });
        }

        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedforSpecialInstructions()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Mustard = false; });
        }

        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedforPickle()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "Pickle", () => { item.Pickle = false; });
        }

        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedforSpecialInstructions()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Pickle = false; });
        }

        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedforTomato()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "Tomato", () => { item.Tomato = false; });
        }

        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedforSpecialInstructions()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Tomato = false; });
        }

        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedforLettuce()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "Lettuce", () => { item.Lettuce = false; });
        }

        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedforSpecialInstructions()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Lettuce = false; });
        }

        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedforMayo()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "Mayo", () => { item.Mayo = false; });
        }

        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedforSpecialInstructions()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Mayo = false; });
        }

        [Fact]
        public void ChangingBaconShouldInvokePropertyChangedforBacon()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "Bacon", () => { item.Bacon = false; });
        }

        [Fact]
        public void ChangingBaconShouldInvokePropertyChangedforSpecialInstructions()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Bacon = false; });
        }

        [Fact]
        public void ChangingEggShouldInvokePropertyChangedforEgg()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "Egg", () => { item.Egg = false; });
        }

        [Fact]
        public void ChangingEggShouldInvokePropertyChangedforSpecialInstructions()
        {
            var item = new TexasTripleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Egg = false; });
        }
    }

    public class DakotaDoubleBurgerPropertyChangedTests
    {
        [Fact]
        public void DakotaDoubleBurgerShouldImplentINotifyPropertyChanged()
        {
            var item = new DakotaDoubleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        [Fact]
        public void ChangingBunShouldInvokePropertyChangedforBun()
        {
            var item = new DakotaDoubleBurger();
            Assert.PropertyChanged(item, "Bun", () => { item.Bun = false; });
        }

        [Fact]
        public void ChangingBunShouldInvokePropertyChangedforSpecialInstructions()
        {
            var item = new DakotaDoubleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Bun = false; });
        }

        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedforChese()
        {
            var item = new DakotaDoubleBurger();
            Assert.PropertyChanged(item, "Cheese", () => { item.Cheese = false; });
        }

        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedforSpecialInstructions()
        {
            var item = new DakotaDoubleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Cheese = false; });
        }

        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedforKetchup()
        {
            var item = new DakotaDoubleBurger();
            Assert.PropertyChanged(item, "Ketchup", () => { item.Ketchup = false; });
        }

        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedforSpecialInstructions()
        {
            var item = new DakotaDoubleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Ketchup = false; });
        }

        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedforMustard()
        {
            var item = new DakotaDoubleBurger();
            Assert.PropertyChanged(item, "Mustard", () => { item.Mustard = false; });
        }

        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedforSpecialInstructions()
        {
            var item = new DakotaDoubleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Mustard = false; });
        }

        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedforPickle()
        {
            var item = new DakotaDoubleBurger();
            Assert.PropertyChanged(item, "Pickle", () => { item.Pickle = false; });
        }

        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedforSpecialInstructions()
        {
            var item = new DakotaDoubleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Pickle = false; });
        }

        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedforTomato()
        {
            var item = new DakotaDoubleBurger();
            Assert.PropertyChanged(item, "Tomato", () => { item.Tomato = false; });
        }

        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedforSpecialInstructions()
        {
            var item = new DakotaDoubleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Tomato = false; });
        }

        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedforLettuce()
        {
            var item = new DakotaDoubleBurger();
            Assert.PropertyChanged(item, "Lettuce", () => { item.Lettuce = false; });
        }

        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedforSpecialInstructions()
        {
            var item = new DakotaDoubleBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Lettuce = false; });
        }

        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedforMayo()
        {
            var item = new DakotaDoubleBurger();
            Assert.PropertyChanged(item, "Mayo", () => { item.Mayo = false; });
        }
    }

    public class TrailBurgerPropertyChangedTests
    {
        [Fact]
        public void TexasTripleBurgerShouldImplentINotifyPropertyChanged()
        {
            var item = new TrailBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        [Fact]
        public void ChangingBunShouldInvokePropertyChangedforBun()
        {
            var item = new TrailBurger();
            Assert.PropertyChanged(item, "Bun", () => { item.Bun = false; });
        }

        [Fact]
        public void ChangingBunShouldInvokePropertyChangedforSpecialInstructions()
        {
            var item = new TrailBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Bun = false; });
        }



        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedforChese()
        {
            var item = new TrailBurger();
            Assert.PropertyChanged(item, "Cheese", () => { item.Cheese = false; });
        }

        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedforSpecialInstructions()
        {
            var item = new TrailBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Cheese = false; });
        }

        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedforKetchup()
        {
            var item = new TrailBurger();
            Assert.PropertyChanged(item, "Ketchup", () => { item.Ketchup = false; });
        }

        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedforSpecialInstructions()
        {
            var item = new TrailBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Ketchup = false; });
        }

        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedforMustard()
        {
            var item = new TrailBurger();
            Assert.PropertyChanged(item, "Mustard", () => { item.Mustard = false; });
        }

        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedforSpecialInstructions()
        {
            var item = new TrailBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Mustard = false; });
        }

        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedforPickle()
        {
            var item = new TrailBurger();
            Assert.PropertyChanged(item, "Pickle", () => { item.Pickle = false; });
        }

        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedforSpecialInstructions()
        {
            var item = new TrailBurger();
            Assert.PropertyChanged(item, "SpecialInstructions", () => { item.Pickle = false; });
        }
    }
}



