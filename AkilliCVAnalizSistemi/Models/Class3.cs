namespace AkilliCVAnalizSistemi.Models
{
    public class AnalizSonuc
    {
        public int Id { get; set; }   // 👈 PRIMARY KEY (ZORUNLU)

        public string CVMetni { get; set; }
        public int Puan { get; set; }
    }
}