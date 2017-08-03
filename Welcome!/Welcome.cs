using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Welcome_
{
    [TestClass]
    public class Welcome
    {
        [TestMethod]
        public void English_should_return_Welcome()
        {
            Assert.AreEqual("Welcome",Kata.Greet("english"));
        }
        
        [TestMethod]
        public void Number_should_return_Welcome()
        {
            Assert.AreEqual("Welcome",Kata.Greet("2"));
        }

        [TestMethod]
        public void _Emptyinput_should_return_Welcome()
        {
            Assert.AreEqual("Welcome",Kata.Greet(""));
        }
    }

    public static class Kata
    {
        public static Dictionary<string,string> Db = new Dictionary<string, string>()
        {
            {"english","Welcome"},
            {"czech", "Vitejte"},
            {"danish", "Velkomst"},
            {"dutch", "Welkom"},
            {"estonian", "Tere tulemast"},
            {"finnish", "Tervetuloa"},
            {"flemish", "Welgekomen"},
            {"french", "Bienvenue"},
            {"german", "Willkommen"},
            {"irish", "Failte"},
            {"italian", "Benvenuto"},
            {"latvian", "Gaidits"},
            {"lithuanian", "Laukiamas"},
            {"polish", "Witamy"},
            {"spanish", "Bienvenido"},
            {"swedish", "Valkommen"},
            {"welsh", "Croeso"},
        }; 
        public static string Greet(string language)
        {
            if (!Db.ContainsKey(language))
                return "Welcome";
            return Db[language];
        }
    }
}
