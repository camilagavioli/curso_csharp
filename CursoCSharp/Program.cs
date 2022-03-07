using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Intepolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},
                
                // Estruturas de Controle 
                {"Estrutura If - Estruturas De Controle", EstruturaIf.Executar},
                {"Estrutura If/Else - Estruturas De Controle", EstruturaIfElse.Executar},
                {"Estrutura If/Else/If - Estruturas De Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas De Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas De Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas De Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas De Controle", EstruturaFor.Executar},
                {"Estrutura Foreach - Estruturas De Controle", EstruturaForeach.Executar},
                {"Usando Break - Estruturas De Controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas De Controle", UsandoContinue.Executar},

                //Classes e Métodos
                {"Membros - Classes e Métodos", Membros.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}