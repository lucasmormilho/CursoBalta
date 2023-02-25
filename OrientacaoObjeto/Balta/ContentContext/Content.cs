namespace Balta.ContentContext
{
    //classe abstrata pois não se tem conteudo sozinho
    //somente dnetro de um curso, carreira, artigo...
    public abstract class Content
    {
        //gerar id automaticamente
        public Content()
        {
            Id = Guid.NewGuid(); //SPOF
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }

    }
}