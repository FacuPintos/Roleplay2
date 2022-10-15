using NUnit.Framework;
using src/RoleplayGame;

namespace test.Library
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void EquiparItem()
        {
            const int expected = 15;
            Archer guillermo = new Archer ("Guillermo",0,0,100);
            Bow arco = new Bow("arco");
            guillermo.PickUpItem(arco);
            guillermo.EquipItems("arco");
            Assert.AreEqual(expected, guillermo.attack);
        }

        //En este caso se testea que se le coloca un arco a guillermo, lo cual aumenta su poder en 15

        [Test]
        public void RecibirDamage()
        {
            // 
        }

    }
}