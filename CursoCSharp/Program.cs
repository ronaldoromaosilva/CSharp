using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControles;
using CursoCSharp.CalssesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                { "Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar },
                {"Variaveis e Constantes - Fundamentos", VariaveisEContantes.Executar },
                {"Inferencia - Fundamentos", Inferencia.Executar },
                {"Interpolação - Fundamentos", interpolacao.Executar },
                {"Notação Ponto - Fundamentos", NotacaoPornto.Executar },
                {"Lendo Dados - Fundamentos", LendoDados.Executar },
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar },
                {"Conversoes - Fundamentos", Conversoes.Executar },
                {"Operadores Aritimeticos - Fundamentos", OperadoresAritimeticos.Executar },
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar },
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar },
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar },
                {"Operadores Ternário - Fundamentos", OperadorTernario.Executar },

                //Estruturas de Controle
                { "Estrutura If - Estruturas de Controle", EstruturaIf.Executar },
                { "Estrutura If/Else - Estruturas de Controle", EstruturaIfElse.Executar },
                { "Estrutura If/Else/If - Estruturas de Controle", EstruturaIfElseIf.Executar },
                { "Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar },
                { "Estrutura While - Estruturas de Controle", EstruturaWhile.Executar },
                { "Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar },
                { "Estrutura For - Estruturas de Controle", EstruturaFor.Executar },
                { "Estrutura Foreach - Estruturas de Controle", EstruturaForEach.Executar },
                { "Estrutura Usando Break - Estruturas de Controle", UsandoBreak.Executar },
                { "Estrutura Usando Continue - Estruturas de Controle", UsandoContinue.Executar },

                // Classes e Métodos
                
                        

                { "Membros - Classes e Mtodos", Membros.Executar },
                { "Construtores - Classes e Métodos", Construtores.Executar },
                { "Metodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar },
                { "Metodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar },
                { "Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar },
                { "Desafio Estáticos - Classes e Métodos", DesafioAtributo.Executar },
                { "Params - Classes e Métodos", Params.Executar },
                { "Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar },
                { "Get Set - Classes e Métodos", GetSet.Executar },
                { "Props - Classes e Métodos", Props.Executar },
                //{ "Readonly - Classes e Métodos", Readonly.Executar },
                { "Enum - Classes e Métodos", ExemploEnum.Executar },
                { "Struct - Classes e Métodos", ExemploStruct.Executar },
                { "Struct Vs Classe - Classes e Métodos", StructVsClasse.Executar },
                { "Valor Vs Referencia - Classes e Métodos", ValorVsReferencia.Executar },
                { "Parâmetros Por Referencia - Classes e Métodos", ParametrosPorReferencia.Executar },
                { "Parâmetros Com Valor Padrao - Classes e Métodos", ParametroPadrao.Executar },

                // Coleçoes
                { "Array - Coloções", Colecoes.Array.Executar },
                { "List - Coloções", ColecoesList.Executar },
                { "Array List - Coloções", ColecoesList.Executar },
                { "Set - Coloções", ColecoesSet.Executar },
                { "Queue - Coloções", ColecoesQueue.Executar },
                { "Igualdade - Coloções", igualdade.Executar },
                { "Stack - Coloções", ColecoesStack.Executar },
                { "Dictionary - Coloções", ColecoesDictionary.Executar },

                //OO
                { "Herança - OO", Heranca.Executar },
                { "Construtor This - OO", ConstrutorThis.Executar },
                { "Encapsulamento - OO", OO.Encapsulamento.Executar },
            });


            central.SelecionarEExecutar();
        }
    }
}