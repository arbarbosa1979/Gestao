using System.Collections.Generic;

namespace Models
{
    public class GrupoFornecedor
    {
        public int IdGrupoFornecedor { get; set; }
        public string NomeGrupo { get; set; }
        public List<Permissao> Permissoes { get; set; }
    }
}

