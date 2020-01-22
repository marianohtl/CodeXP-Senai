using System;
using System.Drawing;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;

namespace exemplo {
    class Program {
        static void Main (string[] args) {
            //
            #region Criacão do documento
            Document exemploDoc = new Document ();
            #endregion

            #region Criacao de Secao
            //Adiciona uma seção com o nome secaoCapa ao documneto

            //CADA SECÃO PODE SER ENTENDIDA COMO UMA PÁGINA DO DOCUMENTO
            Section secaoCapa = exemploDoc.AddSection ();
            #endregion

            #region Criar um paragrafo
            //cria um paragrafo com o nome e título e adiciona à seleção secacoCapa
            //os paragrafos são necessários para inserção de textos, imagens, tabelas
            //IMPORTAMOS SPIREDO DOCUMENTS
            Paragraph titulo = secaoCapa.AddParagraph ();

            #endregion

            #region Adiciona texto ao paragrafo
            //adicionando um texto ao parágrafo título e pulando duas linhas
            titulo.AppendText ("Hello World :)\n\n");
            #endregion

            #region Formatar paragrafo
            //alinhando o parágrafo ao centro do documento
            titulo.Format.HorizontalAlignment = HorizontalAlignment.Center;

            //adicionando um estilo com o nome estilo01 e adiciona ao documento
            ParagraphStyle estilo01 = new ParagraphStyle (exemploDoc);
            
            //definindo nome ao estilo
            estilo01.Name = "Cor do título";
            
            // definindo a cor do título
            estilo01.CharacterFormat.TextColor = Color.DarkBlue;

            //definindo que o texto será em negrito
            estilo01.CharacterFormat.Bold = true;

            //adicionando o estolo01 ao documento exemplo Doc
            exemploDoc.Styles.Add (estilo01);

            //aplicando o estilo01 ao parágrafo título
            titulo.ApplyStyle (estilo01.Name);
            #endregion

            #region Trabalhar com tabulacao
                // adicionando um parágrafo textoCapa a seção secaoCapa
                Paragraph textoCapa = secaoCapa.AddParagraph();

                //adicionando um texto ao parágrafo com tabulação 
                textoCapa.AppendText("\t Este é um exemplo de texto com tabulação");

                //adicionando um novo parágrafo a mesma seção 
                Paragraph textoCapa2 = secaoCapa.AddParagraph();

                //adicionando um texto ao parágrafo textoCapa2 com contatenação            
                textoCapa2.AppendText("\t Basicamente, então, uma seção representa uma página do documento e os parágrafos dentro de uma mesma seção,"+"obviamente, aparecem na mesma página");
            #endregion

            #region Inserir Imagens
                //adcionando um parágrafo à seção secaoCapa
                Paragraph imagemCapa = secaoCapa.AddParagraph();

                //adiciona um texto paragrafo imagemCapa
                imagemCapa.AppendText("\n\n Agora vamos inserir uma imagem ao documento.\n\n");

                //centraliza horizontalmente o parágrafo imagemCapa
                imagemCapa.Format.HorizontalAlignment = HorizontalAlignment.Center;
           
                DocPicture imagemExemplo = imagemCapa.AppendPicture(Image.FromFile(@"saida\img\C.jpg"));

                // define uma largyra e uma altura para a imagem
                imagemExemplo.Width=300;
                imagemExemplo.Height=300;
            #endregion

            #region adicionar uma nova seção
                // adicionar uma nova seção
                Section secaoCorpo = exemploDoc.AddSection ();

                // adicionando um parágrafo a secaoCorpo
                Paragraph paragrafoCorpo1 = secaoCorpo.AddParagraph();

                paragrafoCorpo1.AppendText("\t Este é um exemplo de parágrafo criado em uma nova seção"+"\t Como foi criado uma nova seção, perceba que este texto aparece em uma nova página");

            #endregion

            #region Adicionar uma Tabela
                //adicionando uma tebla a seção secaoCorpo
                Table tabela = secaoCorpo.AddTable(true);

                //cria o cabeçalho da tabela
                String[] cabecalho = {"ITEM","DESCRIÇÃO","QTD","PREÇO UNITÁRIO","PREÇO",};
                
                //vetor destiado
                String[][] dados = {
                    new String[]{"Cenoura", "Vegetal muito nutritivo", "1", "R$4,00","4,80"},
                    new String[]{"Batata", "Legume muito nutritivo", "1", "R$3,00","3,80"},
                    new String[]{"Berinjela", "Vegetal muito nutritivo", "1", "R$1,00","1,80"},
                    new String[]{"Cebola", "Vegetal muito nutritivo", "1", "R$2,00","2,80"}
                };
                //adiciona as células na tabela
                tabela.ResetCells(dados.Length + 1, cabecalho.Length);

                //adiciona uma linha na posição [0] do vetor de linhas
                // e define que esta linha é o cabeçalho
                TableRow linha1 = tabela.Rows[0];
                linha1.IsHeader = true;

                //degine a altura da linha
                linha1.Height = 23;

                //formatação do cabeçalho
                linha1.RowFormat.BackColor = Color.AliceBlue;
                
                //percorre as colunas od cabeçalho
                for (int i = 0; i < cabecalho.Length; i++)
                {
                    //alinhando as células
                    Paragraph p = linha1.Cells[i].AddParagraph();
                    linha1.Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                    p.Format.HorizontalAlignment = HorizontalAlignment.Center;

                    //formatação dos dados do cabeçalho
                    TextRange TR = p.AppendText(cabecalho[i]);

                    TR.CharacterFormat.FontName = "Calibri";
                    TR.CharacterFormat.FontSize = 14;
                    TR.CharacterFormat.TextColor = Color.Teal;
                    TR.CharacterFormat.Bold = true;
                }

                //adiciona as linhas do corpo da tabela 
    
                for (int r = 0; r < dados.Length; r++)
                {
                    TableRow linhaDados = tabela.Rows[r+1];

                    //define a altura da linha
                    linhaDados.Height = 20;
                    for (int c = 0; c < dados[r].Length; c++)
                    {
                        //alinihas as celulas
                        linhaDados.Cells[c].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                    
                        //preencha os dados na linhas
                        Paragraph p2 = linhaDados.Cells[c].AddParagraph();
                        TextRange TR2 = p2.AppendText(dados[r][c]);

                        //Formatando as células
                        p2.Format.HorizontalAlignment = HorizontalAlignment.Center;
                        TR2.CharacterFormat.FontName = "Calibri";
                        TR2.CharacterFormat.FontSize = 12;
                        TR2.CharacterFormat.TextColor = Color.Brown;
                         
                    }
                }
            #endregion
        //salva o arquivo .Docx
        //utiliza o método SaveToFile para salvar o arquivo no formaro desejado
        //Assim como no Word, caso já exista um arquivo com este nome, é substituído
      #region Salvar Arquivo
            exemploDoc.SaveToFile(@"saida\exemplo_arquivo_world.docx",FileFormat.Docx);    
      #endregion


        }
    }
}