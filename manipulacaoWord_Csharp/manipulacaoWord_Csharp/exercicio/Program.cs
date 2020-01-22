using System;
using Spire.Doc;
using Spire.Doc.Documents;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Criação do Documento
                Document exercicio = new Document();
            #endregion
            
            #region Criação da Seção
                //Adicionando uma seção 
                //nome > primeira seção
                //
                Section primeiraSecao = exercicio.AddSection();
            #endregion

            #region Novo Paragrafo
                // Criando um parágrafo
                Paragraph tituloCentro = primeiraSecao.AddParagraph();
            #endregion
            


        }
    }
}
