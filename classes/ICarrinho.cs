namespace Objetos_como_argumentos.classes
{
    public interface ICarrinho
    {
         void Listar();
         void Cadastrar(Produto produto);
         void Adcionar(int _codigo, Produto produto);
         void Deletar(Produto produto);
    }
}