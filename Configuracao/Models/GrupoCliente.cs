using System.Collections.Generic;

namespace Models
{
    public class GrupoCliente
    {
        public int IdGrupoCliente { get; set; }
        public string NomeGrupo { get; set; }
        public List<Permissao> Permissoes { get; set; }
    }
}

