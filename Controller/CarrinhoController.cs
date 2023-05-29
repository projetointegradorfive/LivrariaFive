using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivrariaFive.Model;

namespace LivrariaFive.Controller
{
    public class CarrinhoController
    {
        private Carrinho carrinho;

        public CarrinhoController()
        {
            carrinho = new Carrinho();
        }

        public void AdicionarItensAoCarrinho(List<ItemDeCompra> itens)
        {
            foreach (ItemDeCompra item in itens)
            {
                AdicionarLivro(item.Livro, item.Quantidade);
            }
        }

        public void AdicionarLivro(Livro livro, int quantidade)
        {
            // Verificar se o livro já está no carrinho
            ItemDeCompra itemExistente = carrinho.ItensDeCompra.FirstOrDefault(item => item.Livro.Id == livro.Id);

            if (itemExistente != null)
            {
                // O livro já existe no carrinho, apenas atualiza a quantidade e o preço total
                itemExistente.Quantidade += quantidade;
                itemExistente.PrecoTotal = itemExistente.Quantidade * itemExistente.PrecoUnitario;
            }
            else
            {
                // O livro não existe no carrinho, cria um novo item de compra
                ItemDeCompra novoItem = new ItemDeCompra
                {
                    Livro = livro,
                    Quantidade = quantidade,
                    PrecoUnitario = livro.Preco,
                    PrecoTotal = quantidade * livro.Preco
                };

                carrinho.ItensDeCompra.Add(novoItem);
            }

            // Atualiza o total do carrinho
            carrinho.Total += quantidade * livro.Preco;
        }

        public void RemoverLivro(Livro livro, int quantidade)
        {
            // Verificar se o livro está no carrinho
            ItemDeCompra itemExistente = carrinho.ItensDeCompra.FirstOrDefault(item => item.Livro.Id == livro.Id);

            if (itemExistente != null)
            {
                // Atualiza a quantidade e o preço total do item de compra
                itemExistente.Quantidade -= quantidade;
                itemExistente.PrecoTotal = itemExistente.Quantidade * itemExistente.PrecoUnitario;

                // Remove o item de compra do carrinho se a quantidade ficar menor ou igual a zero
                if (itemExistente.Quantidade <= 0)
                {
                    carrinho.ItensDeCompra.Remove(itemExistente);
                }

                // Atualiza o total do carrinho
                carrinho.Total -= quantidade * livro.Preco;
            }
        }

        public void LimparCarrinho()
        {
            carrinho.ItensDeCompra.Clear();
            carrinho.Total = 0;
        }

        public Carrinho ObterCarrinho()
        {
            return carrinho;
        }
    }
}
