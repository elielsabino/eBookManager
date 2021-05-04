using System;

namespace eBookManager.Engine
{
    public class Documento
    {
        public string Titulo { get; set; }
        public string NomeArquivo { get; set; }
        public string ExtensaoArquivo { get; set; }
        public string CaminhoArquivo { get; set; }
        public string TamanhoArquivo { get; set; }
        public string PrecoArquivo { get; set; }
        public string EditoraArquivo { get; set; }
        public string Autor { get; set; }
        public string CategoriaArquivo { get; set; }
        public DateTime UltimoAcesso { get; set; }
        public DateTime Criado { get; set; }
        public DateTime DataPublicacao { get; set; }

       
    }
}
