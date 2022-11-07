namespace SeguroWebApi.Domain
{
    public class Cliente
    {
        public int id { get; set; }

        public string nome { get; set; }

        public string cpf { get; set; }

        public string rg { get; set; }

        public string endereco { get; set; }

        public string valorPremiado { get; set; }

        public string valorImovel { get; set; }

        public string stPagamentos { get; set; }

        public DateOnly dtInicio { get; set; }

        public DateOnly dtFim { get; set; }


    }
}
