namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone:Smartphone
    {
        public Iphone(string numero,string modelo,string imei, int memoria):base(numero,modelo,imei,memoria)
        {
            
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instaladando o Aplicativo {nomeApp} no Iphone");
        }
    }
}