public class Program
{
    public static void Main(String[] args)
    {
        FileInfo arquivo = null;

        try
        { 
            Console.WriteLine("Digite o nome do arquivo que você vai criar:");
            string nomeArquivo = Console.ReadLine();

            arquivo = new FileInfo(nomeArquivo);

            using (StreamWriter gravadorFluxo = File.AppendText(nomeArquivo))
            {
                gravadorFluxo.WriteLine("Texto de dentro do arquivo:");
            }
        }

        catch(ArgumentException ex)
        {
            Console.WriteLine($"Tratando o erro específico:{ex}.");
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro:{ex}.");
        }

        finally
        {
            Console.WriteLine($"Encerrando programa...\n");
            //arquivo = null;
            //Console.Clear();
        }
    }
}

