double totalPedido = 0;
bool pedidoAberto = true;
while(pedidoAberto)
{
    Console.WriteLine("Bem vindo ao melhor sistema de sistema de pedidos!");
    Console.WriteLine("1 - Adicionar item ao pedido:");
    Console.WriteLine("2 - Exibir total do pedido:");
    Console.WriteLine("3 - Finalizar pedido e sair.");
    Console.WriteLine("Escolha uma das opções acima!");
    string opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1":
        Console.WriteLine("Escolha um item abaixo:");
        Console.WriteLine("1 - Pizza R$30,00 ");
        Console.WriteLine("2 - Hambúrguer R$15,00 ");
        Console.WriteLine("3 - Refrigerante R$5,00 ");
        string escolha = Console.ReadLine();
        if(escolha == "1")
        {
            totalPedido += 30;
            Console.WriteLine("Pizza adicionada ao pedido!");
        }
        else if( escolha == "2")
        {
            totalPedido += 15;
            Console.WriteLine("Hambúrguer adicionado ao pedido!");
        }
        else if(escolha == "3")
        {
            totalPedido += 5;
            Console.WriteLine("Refrigerante adicionado ao pedido!");
        }
        else
        {
            Console.WriteLine($"Item não encontrado");
            
        }
        break;

        case "2":
        Console.WriteLine("Total do pedido: R$" + totalPedido);
        break;

        case "3":
        Console.WriteLine("Obrigado por utilizar nosso sistema!");
        pedidoAberto = false;
        break;
        default:
        Console.WriteLine("Opção inválida");
        break;
    }
}