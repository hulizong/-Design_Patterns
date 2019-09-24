using System;

namespace Template_Method_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //技术文章
            WriteArticle writeTchnology = new TchnologyArticle();
            writeTchnology.Article();

            //生活文章
            WriteArticle writeLife = new LifeArticle();
            writeLife.Article();
        }
    }
}
