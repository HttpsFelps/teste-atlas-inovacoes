namespace Loja 
{
    public class Produto
    {
        private string nome;
        private decimal preco;
        private int estoque;
        public String Nome {
            get { return nome; }
            set { nome = value; }
        }
        public decimal Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        public int Estoque {
            get { return estoque; }
            set { estoque = value; }
        }

        public Produto(String nome, decimal preco, int estoque)
        {
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }

        public void  Vender(int quantidade)
        {
            if (quantidade > Estoque)
            {
                Console.WriteLine("Não há estoque suficiente para vender essa quantidade."); 
            }
            else
            { 
                Estoque -= quantidade;
                Console.WriteLine($"Venda realizada com sucesso! Estoque atualizado para {Estoque}"); 
            }
        }
    }
}