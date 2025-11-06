using System.Text;
using System.Globalization;
using Exercicio03.Entities.Enums;

namespace Exercicio03.Entities {
    internal class Pedido {

        public DateTime Momento { get; set; }
        public StatusPedido Status { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItemPedido> ItemPedido { get; set; } = new List<ItemPedido>();

        public Pedido(DateTime momento, StatusPedido status, Cliente cliente) {

            Momento = momento;
            Status = status;
            Cliente = cliente;
        }

        public void AdicionarItem(ItemPedido item) {

            ItemPedido.Add(item);
        }

        public void RemoverItem(ItemPedido item) {

            ItemPedido.Remove(item);
        }

        public double Total() {

            double soma = 0;
            foreach (ItemPedido item in ItemPedido) {
                soma += item.SubTotal();
            }
            return soma;
        }

        public override string ToString() {
            
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Momento do pedido: {Momento.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine($"Status do pedido: {Status}");
            sb.AppendLine($"Cliente: {Cliente}");
            Console.WriteLine();
            sb.AppendLine("Lista de compras:");
            foreach(ItemPedido item in ItemPedido) {

                sb.AppendLine(item.ToString());
            }

            sb.AppendLine($"Preço total: {Total().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
