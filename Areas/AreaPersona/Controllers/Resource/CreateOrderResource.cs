namespace esercizioUnikey.Areas.AreaPersona.Controllers.Resource
{
    public class CreateOrderResource
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public double Prezzo { get; set; }
        public bool Selected { get; set; }

    }
}