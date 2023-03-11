

namespace Balta.ContentContext
{
    //Classe vazia que apenas deriva de outra
    public class Article : Content
    {
        public Article(string title, string url)
            : base(title, url) //passando para a classe pai
        {

        }
    }

}