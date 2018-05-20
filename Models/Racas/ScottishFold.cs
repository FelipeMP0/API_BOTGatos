using MarabotaBotsProjeto.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarabotaBotsProjeto.Models.Racas
{
    public class ScottishFold : Raca
    {
        public string Nome { get; } = "Scottish Fold";

        public string CaracteristicasFisicas { get; } = "Tem uma cabeça redonda,as orelhas podem ter um a dobra unica, dupla ou trpla e se apresentam em varias cores.";

        public string CaracteristicasComportamentais { get; } = "Eles são doceis e calmos, tem laços duradouros com seus donos. Gostam de contato e de carinho. Não são animais tímidos e costumam ficar sempre perto dos humanos. São inteligentes,  aprendem truques e ser treinados para buscarem coisas. Convivem bem com crianças e, se adaptados, com outros animais de estimação.";

        public string Problemas { get; } = "É mais acometido por doenças das articulações degenerativas,Cardiomiopatia hipertrófica,Osteocondroodisplasia e rins policísticos.";

        public string Cuidados { get; } = "As orelhas precisam ser limpas, pois ocorre um maior acumulo de cera. Um pano ou algodão úmido é o suficiente. Os banhos podem ocorrer mensalmente, e a escovação dos dentes e corte das unhas de duas em duas semanas. Escovar os pelos semanalmente para evitar nos.";

        public List<string> Imagens { get; }

        public string Origem { get; } = "Surgiu na Escócia quando um pastor encontrou uma gata com orelhas dobradas em 1961. Não se sabia se as orelhas eram a primeira aparição dessa característica ou uma heranças dos pais. Quando a gata teve dois filhotes com a mesma característica, o pastor e sua esposa iniciaram um programa para estabelecer o Scottish Fold. A raça então foi para os Estados Unidos onde a raça se desenvolveu mais.";

        public string PaisDeOrigem { get; } = "Escócia";

        public List<string> Curiosidades { get; }
    }
}