using SQLite;

namespace CamadaMobileAndroid.Resources.modelo
{
    public class aluno
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
    }
}
