using SalvarArquivo.Utilitarios;

string men = "isso sera salvo no arquivo";
var arq = new ArquivoTxt(men);
arq.GravaArquivoLogTxt();