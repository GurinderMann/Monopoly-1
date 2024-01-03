using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    // Indica che questa classe contiene test MSTest.
    [TestClass]
    public class GameTests
    {
        // Metodo di test che verifica l'inizializzazione corretta del gioco.
        [TestMethod]
        public void TestGameInitialization()
        {
            // Crea una lista di giocatori con nomi "Horse" e "Car".
            List<Player> players = new List<Player>
        {
            new Player("Horse"),
            new Player("Car")
        };

            // Crea un'istanza della classe Game usando la lista di giocatori.
            var game = new Game(players);

            // Verifica che il numero totale di round sia inizializzato a 0.
            Assert.AreEqual(0, game.GetTotalRounds());

            // Verifica che l'ordine dei giocatori iniziale sia corretto.
            CollectionAssert.AreEquivalent(new List<string> { "Horse", "Car" }, game.GetPlayerOrder());
        }

        // Metodo di test che verifica la corretta esecuzione di 20 round di gioco.
        [TestMethod]
        public void TestGamePlay()
        {
            // Crea una lista di giocatori con nomi "Horse" e "Car".
            List<Player> players = new List<Player>
        {
            new Player("Horse"),
            new Player("Car")
        };

            // Crea un'istanza della classe Game usando la lista di giocatori.
            var game = new Game(players);

            // Esegue il gioco per 20 round.
            game.Play();

            // Verifica che il numero totale di round sia 20.
            Assert.AreEqual(20, game.GetTotalRounds());

            // Verifica che l'ordine dei giocatori rimanga invariato dopo 20 round.
            CollectionAssert.AreEquivalent(new List<string> { "Horse", "Car" }, game.GetPlayerOrder());
        }
    }

}
