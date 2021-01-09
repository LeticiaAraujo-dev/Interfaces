namespace Objetos_como_argumentos.classes
{
    public interface ICarrinho
    {
         void Listar();
         void MostrarTotal();
         void Adicionar( Produto produto);
         void Deletar(Produto produto);
    }
}