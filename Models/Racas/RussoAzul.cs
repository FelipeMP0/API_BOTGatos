using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MarabotaBotsProjeto.Models.Interfaces;

namespace MarabotaBotsProjeto.Models.Racas
{
    public class RussoAzul : Raca
    {
        public string Nome { get; } = "Russo Azul";

        public string CaracteristicasFisicas { get; } = "Sua pelagem pode ser azul acinzentado ou prateado, tem orelhas grandes e pontudas e cauda longa";

        public string CaracteristicasComportamentais { get; } = "Eles são muito inteligentes e tranquilos, desenvolvem um laço muito grande com seu dono, se dá muito bem com outros animais e criaças dentro de casa, porem é reservado com estranhos.";

        public string Problemas { get; } = "O russo azul apresenta poucos problemas de saúde, porem ele nao come muito e é preciso tomar cuidado para que ele não fique muito magro e fraco.";

        public string Cuidados { get; } = "Seu pelo deve ser penteado duas vezes na semana, para melhor distribuição da oleosidade e eliminação dos pelos mortos. Os dentes devem ser escovados semanalmente, as unhas cortadas quinzenalmente e o banho deve ser dado quando ele soltar pelo em excesso. Mantenha uma rotina de alimentação, limpeza e cuidados para que ele se sinta confortável.";

        public List<string> Imagens { get; }

        public string Origem { get; } = "Foi desenvolvido principalmente na Rússia e na Escandinâvia, é uma raça natural e a primeira vez que foi visto fora da região foi em 1875 na Inglaterra. Acredita-se que tenha sido cruzado com gatos siameses devido a escassez da raça. Os traços modernos da raça surgiram no final do século XIX com a criação desses gatos no Estados Unidos.";

        public string PaisDeOrigem { get; } = "Rússia";

        public List<string> Curiosidades { get; }
    }
}