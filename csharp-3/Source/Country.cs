using System.Collections.Generic;
using System.Linq;

namespace Codenation.Challenge
{
    public class Country
    {    
        //Function that returns the 10 highest states in country
        public State[] Top10StatesByArea()
        {
            int i = 0, selection = 10;

            State[] Top10 = new State[10];

            List<State> BrazilianStates = new List<State>();

            // add objects to the list
            BrazilianStates.Add(new State("Acre", "AC", 164123.040));
            BrazilianStates.Add(new State("Alagoas", "AL", 27778.506));
            BrazilianStates.Add(new State("Amapa", "AP", 142828.521));
            BrazilianStates.Add(new State("Amazonas", "AM", 1559159.148));
            BrazilianStates.Add(new State("Bahia", "BA", 564733.177));
            BrazilianStates.Add(new State("Ceara", "CE", 148920.472));
            BrazilianStates.Add(new State("Distrito Federal", "DF", 5779.999));
            BrazilianStates.Add(new State("Espírito Santo", "ES", 46095.583));
            BrazilianStates.Add(new State("Goias", "GO", 340111.783));
            BrazilianStates.Add(new State("Maranhao", "MA", 331937.450));
            BrazilianStates.Add(new State("Mato Grosso", "MT", 903366.192));
            BrazilianStates.Add(new State("Mato Grosso do Sul", "MS", 357145.532));
            BrazilianStates.Add(new State("Minas Gerais", "MG", 586522.122));
            BrazilianStates.Add(new State("Para", "PA", 1247954.666));
            BrazilianStates.Add(new State("Paraiba", "PB", 56585.000));
            BrazilianStates.Add(new State("Parana", "PR", 199307.922));
            BrazilianStates.Add(new State("Pernambuco", "PE", 98311.616));
            BrazilianStates.Add(new State("Piaui", "PI", 251577.738));
            BrazilianStates.Add(new State("Rio de Janeiro", "RJ", 43780.172));
            BrazilianStates.Add(new State("Rio Grande do Norte", "RN", 52811.047));
            BrazilianStates.Add(new State("Rio Grande do Sul", "RS", 281730.223));
            BrazilianStates.Add(new State("Rondonia", "RO", 237590.547));
            BrazilianStates.Add(new State("Roraima", "RR", 224300.506));
            BrazilianStates.Add(new State("Santa Catarina", "SC", 95736.165));
            BrazilianStates.Add(new State("Sao Paulo", "SP", 248222.362));
            BrazilianStates.Add(new State("Sergipe", "SE", 21915.116));
            BrazilianStates.Add(new State("Tocantins", "TO", 277720.520));

            // querry that ordenate the elements
            var statesQuerry =
                from BrazilianState in BrazilianStates
                orderby BrazilianState.Extension descending
                select BrazilianState;

            // select elements
            while (i < selection)
            {
                Top10[i] = statesQuerry.ToArray()[i];
                i++;
            }

            // return object
            return Top10;
        }
    }
}
