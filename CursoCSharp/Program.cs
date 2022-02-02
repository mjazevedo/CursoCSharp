using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                //Fundamentos

                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência de Tipos - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Leitura de dados do console - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumeros.Executar},
                {"Conversõs - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},

                //Estruturas de Controle

                {"Estrutura IF - Estruturas de Controle", EstruturaIF.Executar},
                {"Estrutura IF/ELSE - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura IF/ELSE IF - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura SWITCH - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura WHILE - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura DO WHILE - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura FOR - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura FOR EACH- Estruturas de Controle", EstruturaForEach.Executar},
                {"Usando BREAK - Estruturas de Controle", UsandoBreak.Executar},
                {"Usando CONTINUE - Estruturas de Controle", UsandoContinue.Executar},

                //Classes e Métodos

                {"Membros - Classes e métodos", Membros.Executar},
                {"Construtores - Classes e métodos", Construtores.Executar},
                {"Metodos com retorno - Classes e métodos", MetodosComRetorno.Executar},
                {"Metodos estáticos - Classes e métodos", MetodosEstaticos.Executar},
                {"Atributos estáticos - Classes e métodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e métodos", DesafioAtributo.Executar},
                {"Paramêtros Variáveis - Classes e métodos", ParametrosVariaveis.Executar},
                {"Paramêtros Nomeados - Classes e métodos", ParametrosNomeados.Executar},
                {"Get e Set - Classes e métodos", GetSet.Executar},
                {"Propriedades - Classes e métodos", Propriedades.Executar},
                {"Readonly - Classes e métodos", Readonly.Executar},
                {"Enum - Classes e métodos", ExemploEnum.Executar},
                {"Struct - Classes e métodos", ExemploStruct.Executar},
                {"Struct VS Classe - Classes e métodos", StructVsClasse.Executar},
                {"Valor VS Referência - Classes e métodos", ValorVsReferencia.Executar},
                {"Paramêtros Por Referência - Classes e métodos", ParametrosPorReferencia.Executar},
                {"Paramêtros com Valor Padrão - Classes e métodos", ParametrosPadrao.Executar},

                //Coleções

                {"Array- Coleções", Colecoes.Array.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"ArrayList - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecoesStack.Executar},
                {"Dictionary - Coleções", ColecoesDictionary.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}