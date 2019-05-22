using Microsoft.VisualStudio.TestTools.UnitTesting;
using SupportCode;

namespace CreatingAndUsingCustomFormatProvidersToRemoveBadWord
{
    [TestClass]
    public class CustomFormatExample
    {

        [TestMethod]
        public void NaughtyWordCensor()
        {
            const string naughtyVersion = "He is a poopy head and darn idiot!";

            var cleanVersion = string.Format(new NaughtyWordCensorFormatProvider(),
                                                                 "Clean version: {0}",
                                                                 naughtyVersion);

            var cleanVersion2 = string.Format(new NaughtyWordCensorFormatProvider(),
                                                     "Clean version: {0:xxx}, {1}",
                                                     naughtyVersion,
                                                     "some other darn string");

            // WordyFormatProvider:  http://bit.ly/pscsformat 
        }
    }
}
