namespace Exercicio4_parte2
{
    public class SistemaTotem
    {
        private Dictionary<string, List<ItemCompra>> corredores;
        private List<(ItemCompra Item, double Quantidade, double Subtotal)> listaAtual;

        public SistemaTotem()
        {
            InicializarCatalogo();
            listaAtual = new List<(ItemCompra, double, double)>();
        }

        private void InicializarCatalogo()
        {
            corredores = new Dictionary<string, List<ItemCompra>>();

            corredores.Add("A", new List<ItemCompra>
            {
                new ItemCompra("Melão", 2.50, "UNIDADE"),
                new ItemCompra("Mamão", 2.50, "UNIDADE"),
                new ItemCompra("Pêra", 2.50, "UNIDADE"),
                new ItemCompra("Maçã", 2.50, "UNIDADE"),
                new ItemCompra("Uva", 2.50, "UNIDADE"),
                new ItemCompra("Abacate", 2.50, "UNIDADE"),
                new ItemCompra("Limão", 2.50, "UNIDADE"),
                new ItemCompra("Alface", 2.50, "UNIDADE"),
                new ItemCompra("Couve", 2.50, "UNIDADE"),
                new ItemCompra("Brócolis", 2.50, "UNIDADE")
            });

            corredores.Add("B", new List<ItemCompra>
            {
                new ItemCompra("Feijão", 5.00, "UNIDADE"),
                new ItemCompra("Arroz", 5.00, "UNIDADE"),
                new ItemCompra("Açúcar Mascavo", 5.00, "UNIDADE"),
                new ItemCompra("Biscoito de maisena", 5.00, "UNIDADE"),
                new ItemCompra("Farofa", 5.00, "UNIDADE"),
                new ItemCompra("Macarrão", 5.00, "UNIDADE"),
                new ItemCompra("Óleo", 5.00, "UNIDADE"),
                new ItemCompra("Azeite", 5.00, "UNIDADE"),
                new ItemCompra("Fubá", 5.00, "UNIDADE"),
                new ItemCompra("Pipoca", 5.00, "UNIDADE")
            });

            corredores.Add("C", new List<ItemCompra>
            {
                new ItemCompra("Alcatra", 20.00, "KG"),
                new ItemCompra("Patinho", 20.00, "KG"),
                new ItemCompra("Carne moída de patinho", 20.00, "KG"),
                new ItemCompra("Picanha", 20.00, "KG"),
                new ItemCompra("Asinha de frango", 20.00, "KG"),
                new ItemCompra("Coxa de frango", 20.00, "KG"),
                new ItemCompra("Bisteca", 20.00, "KG"),
                new ItemCompra("Queijo", 20.00, "KG"),
                new ItemCompra("Presunto", 20.00, "KG"),
                new ItemCompra("Mortadela", 20.00, "KG")
            });
        }
        public void IniciarNovaLista()
        {
            listaAtual.Clear();
            Console.WriteLine("\n--- NOVA LISTA INICIADA ---");
            MenuCorredores();
        }

        private void MenuCorredores()
        {
            while (true)
            {
                Console.WriteLine("\n==================================");
                Console.WriteLine("    ESCOLHA O CORREDOR (Tio João)    ");
                Console.WriteLine("==================================");
                Console.WriteLine("A - Frutas e Verduras (R$ 2,50/un)");
                Console.WriteLine("B - Itens Básicos (R$ 5,00/un)");
                Console.WriteLine("C - Carnes e Frios (R$ 20,00/kg)");
                Console.WriteLine("F - Finalizar Compra");
                Console.Write("Opção: ");
                string escolha = Console.ReadLine().ToUpper();

                if (escolha == "F")
                {
                    EncerrarLista();
                    break;
                }
                else if (corredores.ContainsKey(escolha))
                {
                    MenuItens(escolha);
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente A, B, C ou F.");
                }
            }
        }
        private void MenuItens(string corredor)
        {
            var itensCorredor = corredores[corredor];

            while (true)
            {
                Console.WriteLine($"\n CORREDOR: {corredor}");
                for (int i = 0; i < itensCorredor.Count; i++)
                {
                    var item = itensCorredor[i];
                    Console.WriteLine($"{i + 1} - {item.Nome} ({item.Preco:C2}/{item.TipoCobranca})");
                }

                Console.WriteLine("V - Voltar para escolha de corredores");
                Console.Write("Escolha o número do item ou 'V' para voltar: ");
                string escolha = Console.ReadLine().ToUpper();

                if (escolha == "V")
                {
                    return;
                }

                if (int.TryParse(escolha, out int indice) && indice >= 1 && indice <= itensCorredor.Count)
                {
                    AdicionarItemALista(itensCorredor[indice - 1]);
                }
                else
                {
                    Console.WriteLine("Opção inválida.");
                }
            }
        }

        private void AdicionarItemALista(ItemCompra item)
        {
            Console.Write($"Qual a quantidade de {item.Nome} ({item.TipoCobranca})? ");

            if (double.TryParse(Console.ReadLine(), out double quantidade) && quantidade > 0)
            {
                double subtotal = quantidade * item.Preco;
                listaAtual.Add((item, quantidade, subtotal));
                Console.WriteLine($"{item.Nome} ({quantidade} {item.TipoCobranca}) adicionado. Subtotal: {subtotal:C2}");
            }
            else
            {
                Console.WriteLine("Quantidade inválida.");
            }
        }
        private void EncerrarLista()
        {
            double totalPagar = listaAtual.Sum(i => i.Subtotal);

            Console.WriteLine("\n**********************************");
            Console.WriteLine("         RESUMO DA COMPRA         ");
            Console.WriteLine("**********************************");

            if (listaAtual.Any())
            {
                foreach (var item in listaAtual)
                {
                    Console.WriteLine($"- {item.Item.Nome}: {item.Quantidade:F2} {item.Item.TipoCobranca} x {item.Item.Preco:C2} = {item.Subtotal:C2}");
                }
            }
            else
            {
                Console.WriteLine("Sua lista de compras está vazia.");
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine($"TOTAL A PAGAR: {totalPagar:C2}");
            Console.WriteLine("**********************************");
            Console.WriteLine("Obrigado pela preferência! Volte sempre ao Mercadinho do Tio João.");
        }
    }
}
