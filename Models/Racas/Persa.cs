using MarabotaBotsProjeto.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarabotaBotsProjeto.Models.Racas
{
    public class Persa : Raca
    {
        public string Nome { get; } = "Persa";

        public string CaracteristicasFisicas { get; } = "Eles tem longo pelo e fucinho achatado, podem ser de diversas cores, são bem calmos e companheiros, alem de inteligentes. É considerado uma das raças mais inteligentes.";

        public string CaracteristicasComportamentais { get; } = "São gatos extremamente tranquilos e preguiçosos com forte apego ao dono. São sociáveis e convivem muito bem com cães, outros gatos ou crianças. São também curiosos e silencios, miam muito pouco.";

        public string Problemas { get; } = "Os perças criam bolas de pelo que se formam no estômago, chamadas tricobezoar, para evitá-las você deve escovar seus pelos diariamente. Eles são propensos a sofrer de rim policistico, você deve fazer ecografias anuais a partir dos 12 primeiros meses por segurança. Eles tambem apresentam problemas respiratórios por conta de seus fucinhos achatdos, ele não deve ficar em ambientes secos ou muito quentes, nem se exercitar por longos periodos, os problemas respiratórios podem levar a problemas cardiacos. Entre os problemas oculares temos:Anquilobléfaro congênita,Epífora congênita,Entrópio e Glaucoma primário.";

        public string Cuidados { get; } = "Necessitam de limpeza constante nos olhos, pois lacrimejam e macham a pelagem. Também precisão de escovação diária, com a escova correta, ou a pelagem terá muitos nós. Os persas são sensíveis ao calor.";

        public List<string> Imagens { get; }

        public string Origem { get; } = "A história dos persas se inicia no século XVII quando um viajante italiano trouxe da Pérsia alguns gatos da região. Rapidamentes esses gatos ganharam popularidade. A raça moderna surgiu no século XIX quando os persas foram cruzados com a raça Angorá. Após, foi feito um trabalho de melhoramento genético para obter variedades de cores e pelagens.";

        public string PaisDeOrigem { get; } = "Irã";

        public List<string> Curiosidades { get; }

    }
}