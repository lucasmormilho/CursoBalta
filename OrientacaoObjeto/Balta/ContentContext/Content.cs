using Balta.SharedContext;

namespace Balta.ContentContext
{
    //classe abstrata pois não se tem conteudo sozinho
    //somente dnetro de um curso, carreira, artigo...
    public abstract class Content : Base
    {
        //gerar id automaticamente
        public Content(string title, string url)
        {
            Title = title;
            Url = url;
        }


        public string Title { get; set; }
        public string Url { get; set; }

    }
}