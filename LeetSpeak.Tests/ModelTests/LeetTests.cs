using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetAF.Models;

namespace LeetAF.Tests
{
  [TestClass]

  public class ItemTests
  {
    [TestMethod]

    public void Translate_ConvertsETo3_3()
    {
      LeetspeakTranslator le = new LeetspeakTranslator();
      Assert.AreEqual("y33", LeetspeakTranslator.Translate("yee"));
    }

    [TestMethod]
    public void Translate_ConvertsoTo0_0()
    {
      LeetspeakTranslator le = new LeetspeakTranslator();
      Assert.AreEqual("d03", LeetspeakTranslator.Translate("doe"));

    }

    [TestMethod]
    public void Tranlate_ConvertsITo1_1()
    {
      LeetspeakTranslator le = new LeetspeakTranslator();
      Assert.AreEqual("1 d0 3v3n", LeetspeakTranslator.Translate("I do even"));
    }

    [TestMethod]

    public void Translate_ConvertstTo7_7()
    {
      LeetspeakTranslator le = new LeetspeakTranslator();
      Assert.AreEqual("A l07 0f b337", LeetspeakTranslator.Translate("A lot of beet")); // A lO7 0f b337s
    }

    [TestMethod]
    public void Translate_ConvertssToz_z()
    {
      LeetspeakTranslator le = new LeetspeakTranslator();
      Assert.AreEqual("D0n'7 y0u l0v3 7h3z3 'S7ring' 3x3rciz3z? 1 d0!", LeetspeakTranslator.Translate("Don't you love these 'String' exercises? I do!"));
    }



  }
}