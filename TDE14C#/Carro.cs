public class Carro : Veiculo, IAceleravel, IFrear
{
    public Carro(string marca, string modelo) :base(marca, modelo)
    {
        
    }

    public override void Ligar()
    {
        Console.WriteLine($"O veiculo de marca {Marca} e modelo {Modelo} esta ligando.");
    }

    public void Acelerar()
    {
         Console.WriteLine($"O carro de modelo {Modelo} e marca {Marca} está acelerando.");
    }

    public void Frear()
    {
         Console.WriteLine($"O carro de mode {Modelo} e marca {Marca} está freiando.");
    }
}