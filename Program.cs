internal class Program
{
    private static void Main(string[] args)
    {     
       //var retorno = new Servico().BuscarSomatoriaDaMediaSemestralETrimestral();
       //Console.WriteLine(retorno);
       
       (decimal um, decimal dois) = new Servico().BuscarSomatoriaDaMediaSemestralETrimestral();

       Console.WriteLine(um);
       Console.WriteLine(dois);
        System.Console.WriteLine( " ==================== " ); 
        var (numero, texto) = new Servico().RetornarDoisValores(0);
        Console.WriteLine(numero);    
        Console.WriteLine(texto);
        System.Console.WriteLine( " ==================== " ); 
        (numero, texto) = new Servico().RetornarDoisValores(1);
        Console.WriteLine(numero);
        Console.WriteLine(texto);
    }
}


internal class Servico
{
    private string[] LETRAS = new string[2] {"Brasil","Inglaterra"};	
    public (decimal, decimal) BuscarSomatoriaDaMediaSemestralETrimestral() 
    {
        var mediaSemetral = ( 8 + 9) / 2;
        var mediaTrimestral = (9 + 6 + 5 + 7) / 4;

        return (mediaSemetral, mediaTrimestral);
    }

    public (int , string) RetornarDoisValores(int indice)
    {
        var numero = new Random().Next(1, 900);
        var texto = LETRAS[indice];

        return (numero, texto);
    }
}