
namespace SalvarArquivo.Utilitarios
{
    public class ArquivoTxt
    {
        private string _log { get; set; }

        public ArquivoTxt(string log)
        {
            _log = log;
        }

        public void GravaArquivoLogTxt()
        {
            var filePath = AppDomain.CurrentDomain.BaseDirectory + @"/logs";
            var dataMes = DateTime.Now.ToString("yyyyMM");
            var file = filePath + @$"\{dataMes}_ARQUIVO_LOG.txt";

            try
            {
                if (File.Exists(file)) 
                {
                    CriarArquivo(file);
                }
                else
                {
                    Directory.CreateDirectory(filePath);
                    File.Create(file).Close();
                    CriarArquivo(file);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void CriarArquivo(string caminho)
        {
            var filePath = caminho;
            using (StreamWriter file = new StreamWriter(filePath, true))
            {
                file.WriteLine($"{DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss")} - {_log}");
            }
        }

    }
}
