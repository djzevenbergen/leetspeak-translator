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

  }
}