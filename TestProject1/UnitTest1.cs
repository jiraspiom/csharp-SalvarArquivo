using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalvarArquivo.Utilitarios;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string testo = "testere";
            var teste = new ArquivoTxt(testo);
            teste.GravaArquivoLogTxt();
        }
    }
}