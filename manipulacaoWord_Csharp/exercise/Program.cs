using System;
using System.Drawing;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;

namespace exercise
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
                Section primeiraSecao = exercicio.AddSection();
            #endregion

            #region Criando, Adicionando e Formatando Paragrafos  
                // Criando um parágrafo
                Paragraph tituloCentro = primeiraSecao.AddParagraph();
            
                
                // Segundo Paragrafo
                 Paragraph segundoParagrafo = primeiraSecao.AddParagraph();

                //Atribuindo um Texto ao Parágrafo
                tituloCentro.AppendText("Desafio");
                
                segundoParagrafo.AppendText("\t\t Este é o segundo parágrafo! \n \t Veja como é divertido escrever um arquivo word por linha de comando.");
            #endregion

            #region Criando um Estilo
            
                 //adicionando um estilo com o nome estiloTitulo ao documento e definindo propriedades ao mesmo
                ParagraphStyle estiloTitulo = new ParagraphStyle (exercicio);
                
                //Definindo o nome do estilo
                estiloTitulo.Name = "Cor do Título";
                
                //Definindo uma cor ao título
                estiloTitulo.CharacterFormat.TextColor = Color.DarkCyan;

                //Definindo que o texto estará em negrito
                estiloTitulo.CharacterFormat.Bold = true;

            #endregion

            #region Centralizando um Parágrafo
                tituloCentro.Format.HorizontalAlignment = HorizontalAlignment.Center;
            #endregion

            #region  Aplicando o Estilo Acima no Arquivo exercicio e em Parágrafos Específicos
                //Adicionando o estilo ao documento 
                exercicio.Styles.Add(estiloTitulo);             

                //aplicando o estilo ao parágrafo titulo
                tituloCentro.ApplyStyle(estiloTitulo.Name);

            #endregion

            //salva o arquivo .Docx
            //O método SaveToFile é utilizado para salvar o arquivo no formaro desejado
            //Assim como no Word, caso já exista um arquivo com este nome, é substituído
          
            #region Criando Tabela
                //adicionando uma tabela a seção primeira seção
                Table tabela = primeiraSecao.AddTable(true);

                String[] cabecalho = {"NOME","DESCRIÇÃO","NOME","VENDEDOR","PREÇO"};
               
                String[][] dados = {
                    new String[]{"Marmita 1","Sopa com legumes.","Sopa","João","R$9,99"},
                    new String[]{"Marmita 2","Molho com carne moída.","Bolonhesa","Ana","R$5,99"},
                    new String[]{"Marmita 3","Barcar de legumes recheadas com carne moida.","Barcas","Tainar","R$1,99"}
                };

                //adicionando células à tabela
                tabela.ResetCells(dados.Length + 1, cabecalho.Length);    

                //Adicionando uma linha na posição [0] do vetor de linhas e definindo que esta linha é o cabeçalho
                TableRow linha01 = tabela.Rows[0];
                linha01.IsHeader = true;


                //formatação

                //definindo a altura da linha
                linha01.Height = 30;

                //formatanado o cabeçalho
                linha01.RowFormat.BackColor = Color.DarkMagenta;
                                                
            #endregion


            #region Adicionando os Dados do Cabeçalho à Tabela
                  for (int i = 0; i < cabecalho.Length; i++)
                {
                    //alinhando as células
                    Paragraph p = linha01.Cells[i].AddParagraph();
                    linha01.Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                    p.Format.HorizontalAlignment = HorizontalAlignment.Center;

                    //formatação dos dados do cabeçalho
                    TextRange TR = p.AppendText(cabecalho[i]);

                    TR.CharacterFormat.FontName = "Calibri";
                    TR.CharacterFormat.FontSize = 14;
                    TR.CharacterFormat.TextColor = Color.Teal;
                    TR.CharacterFormat.Bold = true;
                }

            #endregion


            #region Criação da Segunda Seção
                //Adicionando a segunda seção 
                Section segundaSecao = exercicio.AddSection();

            #endregion

            #region Criando o Terceiro Parágrafo  
                // Terceiro Paragrafo
                 Paragraph terceiroParagrafo = segundaSecao.AddParagraph();

            #endregion

              #region Salvar Arquivo
                    exercicio.SaveToFile(@"saida\exercicio.docx",FileFormat.Docx);    
                #endregion



        }
    }
}
