using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClasseEMetodos;
using CursoCSharp.OO;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constates - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos1.Executar},
                {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternários - Fundamentos", OperadorTernario.Executar},
                
                //Estrutura de Controles
                {"Estrutura If - Controle de Controle", EstruturaIf.Executar},
                {"Estrutura If / Else - Controle de Controle", EstruturaIfElse.Executar},
                {"Estrutura If / Else / If - Controle de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Controle de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Controle de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Controle de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Controle de Controle", EstruturaFor.Executar},
                {"Estrutura Foreach - Controle de Controle", EstruturaForeach.Executar},
                {"Usando Break - Controle de Controle", UsandoBreak.Executar},
                {"Usando Continue - Controle de Controle", UsandoContinue.Executar},

                //Classes e Métodos
                {"Membros - Classe e Métodos", Membros.Executar},

                //Coleções

                //OO
                {"Herança - OO", Heranca.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", OO.Encapsulamento.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar}, 
                {"Abstract - OO", Abstract.Executar},


            }); ;

            central.SelecionarEExecutar();
        }
    }
}