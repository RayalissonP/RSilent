namespace RSilent
{
    public class AppItem
    {
        public string Nome { get; set; }
        public string Caminho { get; set; }
        public string ChaveSilenciosa { get; set; }
        public string Versao { get; set; }

        public override string ToString()
        {
            return $"{Nome} {(string.IsNullOrEmpty(Versao) ? "" : $"[{Versao}]")}";
        }
    }
}