using MarabotaBotsProjeto.Models.Racas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarabotaBotsProjeto.Models
{
    public class Informacoes
    {
        public static List<string> CaracteristicasFisicas(string raca)
        {
            List<string> informacoes = new List<string>();
            switch (raca)
            {
                case "scottishfold":
                    ScottishFold sf = new ScottishFold();
                    informacoes.Add(sf.Nome);
                    informacoes.Add(sf.CaracteristicasFisicas);
                break;
                case "persa":
                    Persa p = new Persa();
                    informacoes.Add(p.Nome);
                    informacoes.Add(p.CaracteristicasFisicas);
                break;
                case "russoazul":
                    RussoAzul ra = new RussoAzul();
                    informacoes.Add(ra.Nome);
                    informacoes.Add(ra.CaracteristicasFisicas);
                    break;
            }
            return informacoes;
        }

        public static List<string> CaracteristicasComportamentais(string raca)
        {
            List<string> informacoes = new List<string>();
            switch (raca)
            {
                case "scottishfold":
                    ScottishFold sf = new ScottishFold();
                    informacoes.Add(sf.Nome);
                    informacoes.Add(sf.CaracteristicasComportamentais);
                    break;
                case "persa":
                    Persa p = new Persa();
                    informacoes.Add(p.Nome);
                    informacoes.Add(p.CaracteristicasComportamentais);
                    break;
                case "russoazul":
                    RussoAzul ra = new RussoAzul();
                    informacoes.Add(ra.Nome);
                    informacoes.Add(ra.CaracteristicasComportamentais);
                    break;
            }
            return informacoes;
        }

        public static List<string> Problemas(string raca)
        {
            List<string> informacoes = new List<string>();
            switch (raca)
            {
                case "scottishfold":
                    ScottishFold sf = new ScottishFold();
                    informacoes.Add(sf.Nome);
                    informacoes.Add(sf.Problemas);
                    break;
                case "persa":
                    Persa p = new Persa();
                    informacoes.Add(p.Nome);
                    informacoes.Add(p.Problemas);
                    break;
                case "russoazul":
                    RussoAzul ra = new RussoAzul();
                    informacoes.Add(ra.Nome);
                    informacoes.Add(ra.Problemas);
                    break;
            }
            return informacoes;
        }

        public static List<string> Cuidados(string raca)
        {
            List<string> informacoes = new List<string>();
            switch (raca)
            {
                case "scottishfold":
                    ScottishFold sf = new ScottishFold();
                    informacoes.Add(sf.Nome);
                    informacoes.Add(sf.Cuidados);
                    break;
                case "persa":
                    Persa p = new Persa();
                    informacoes.Add(p.Nome);
                    informacoes.Add(p.Cuidados);
                    break;
                case "russoazul":
                    RussoAzul ra = new RussoAzul();
                    informacoes.Add(ra.Nome);
                    informacoes.Add(ra.Cuidados);
                    break;
            }
            return informacoes;
        }

        public static List<string> Imagens(string raca)
        {
            List<string> informacoes = new List<string>();
            string imagens = "";
            switch (raca)
            {
                case "scottishfold":
                    ScottishFold sf = new ScottishFold();
                    informacoes.Add(sf.Nome);
                    imagens = "https://www.furrytips.com/wp-content/uploads/2017/09/Scottish-Fold-Cat-Health-Problems.jpg;https://amedia.britannica.com/700x450/44/186844-004-9F67496F.jpg;http://gatos.animais.info/Imagens/pelo-do-scottish-fold.jpg";
                    informacoes.Add(imagens);
                    break;
                case "persa":
                    Persa p = new Persa();
                    informacoes.Add(p.Nome);
                    imagens = "http://osgatos.com.br/gatos/wp-content/uploads/2015/12/persa.jpg;https://petgusto.com/wp-content/uploads/2016/05/gato-persa-a-venda-saiba-onde-comprar2.jpg;http://i0.statig.com.br/bancodeimagens/0l/b4/xl/0lb4xln09s6ptabwkf70u73jp.jpg";
                    informacoes.Add(imagens);
                    break;
                case "russoazul":
                    RussoAzul ra = new RussoAzul();
                    informacoes.Add(ra.Nome);
                    imagens = "http://portalmelhoresamigos.com.br/wp-content/uploads/2016/02/russian_blue_gato.png;http://www.guiaderacas.com.br/gatos/racas/azul-russo-02.jpg;http://gatoecachorro.com/wp-content/uploads/2016/11/Russo-Azul3-480x280.jpg";
                    informacoes.Add(imagens);
                    break;
            }
            return informacoes;
        }

        public static List<string> PaisDeOrigem(string raca)
        {
            List<string> informacoes = new List<string>();
            switch (raca)
            {
                case "scottishfold":
                    ScottishFold sf = new ScottishFold();
                    informacoes.Add(sf.Nome);
                    informacoes.Add(sf.PaisDeOrigem);
                    break;
                case "persa":
                    Persa p = new Persa();
                    informacoes.Add(p.Nome);
                    informacoes.Add(p.PaisDeOrigem);
                    break;
                case "russoazul":
                    RussoAzul ra = new RussoAzul();
                    informacoes.Add(ra.Nome);
                    informacoes.Add(ra.PaisDeOrigem);
                    break;
            }
            return informacoes;
        }

        public static List<string> Origem(string raca)
        {
            List<string> informacoes = new List<string>();
            switch (raca)
            {
                case "scottishfold":
                    ScottishFold sf = new ScottishFold();
                    informacoes.Add(sf.Nome);
                    informacoes.Add(sf.Origem);
                    break;
                case "persa":
                    Persa p = new Persa();
                    informacoes.Add(p.Nome);
                    informacoes.Add(p.Origem);
                    break;
                case "russoazul":
                    RussoAzul ra = new RussoAzul();
                    informacoes.Add(ra.Nome);
                    informacoes.Add(ra.Origem);
                    break;
            }
            return informacoes;
        }

        public static List<string> Curiosidades(string raca)
        {
            List<string> informacoes = new List<string>();
            switch (raca)
            {
                case "scottishfold":
                    ScottishFold sf = new ScottishFold();
                    informacoes.Add(sf.Nome);
                    informacoes.Add(sf.CaracteristicasFisicas);
                    break;
                case "persa":
                    Persa p = new Persa();
                    informacoes.Add(p.Nome);
                    informacoes.Add(p.CaracteristicasFisicas);
                    break;
                case "russoazul":
                    RussoAzul ra = new RussoAzul();
                    informacoes.Add(ra.Nome);
                    informacoes.Add(ra.CaracteristicasFisicas);
                    break;
            }
            return informacoes;
        }

        public static List<string> Idade()
        {
            List<string> informacoes = new List<string>();
            informacoes.Add("none");
            informacoes.Add("Em média os gatos vivem de 15 a 20 anos, alguns podem chegar até os 30 anos ou mais. Isso se aplica a gatos que vivem em casas e sem acesso à rua. Devido aos riscos, um gato que vive livre, em média chega aos 4 ou 5 anos. Genética e antecedentes também podem determinar o tempo de vida.");
            return informacoes;
        }
           
    }
}