# 🎲 Rolagem de Dado em C#

## 📌 Sobre o projeto

Este projeto consiste em um programa desenvolvido em **C#** que simula a rolagem de um dado com uma quantidade de faces definida pelo usuário.

O programa solicita ao usuário a quantidade de faces do dado, gera aleatoriamente um número dentro desse intervalo e apresenta o resultado da rolagem no console.

A versão desenvolvida também permite que o usuário realize várias rolagens sem precisar reiniciar o programa.

## 🎯 Objetivos

O objetivo da atividade é colocar em prática conceitos básicos de programação em C#, como:

* Declaração de variáveis;
* Entrada de dados pelo usuário;
* Conversão e validação de dados;
* Estruturas de repetição;
* Estruturas condicionais;
* Geração de números aleatórios;
* Interação através do console.

## ⚙️ Funcionamento

O programa funciona da seguinte maneira:

1. O usuário informa a quantidade de faces do dado;
2. O programa valida se o valor informado é válido;
3. Um número aleatório é gerado entre `1` e a quantidade de faces;
4. O resultado da rolagem é exibido na tela;
5. O usuário pode escolher se deseja realizar outra rolagem;
6. O programa é encerrado quando o usuário escolher a opção `N`.

## 🛠️ Tecnologias utilizadas

* **C#**
* **.NET**
* Aplicação Console
* `System.Security.Cryptography`

## 💻 Exemplo de execução

```text
================================
        ROLAGEM DE DADO
================================

Quantas faces o dado possui? 20

Dado criado com sucesso!
Quantidade de faces: 20

--------------------------------
Resultado da rolagem: 13
--------------------------------

Deseja rolar novamente? (S/N): S

--------------------------------
Resultado da rolagem: 7
--------------------------------

Deseja rolar novamente? (S/N): N

================================
Obrigado por utilizar o programa!
================================
```

## 🎓 Atividade acadêmica

Este projeto foi desenvolvido como **atividade do curso de Informática da ETEC Adolpho Berezin — Mongaguá/SP**.

A atividade tem como objetivo praticar os fundamentos da programação utilizando a linguagem C# e desenvolver a lógica necessária para criar aplicações simples de console.

## 📚 Conceitos praticados

Durante o desenvolvimento foram utilizados conceitos como:

```csharp
int.TryParse()
```

para validação da entrada do usuário;

```csharp
RandomNumberGenerator.GetInt32()
```

para geração do resultado aleatório;

```csharp
do...while
```

para permitir novas rolagens;

e estruturas condicionais para validar as informações fornecidas pelo usuário.

## 👨‍💻 Projeto

**Instituição:** ETEC Adolpho Berezin — Mongaguá/SP

**Atividade:** Programação em C#

**Ano:** 2024

**Tipo:** Atividade de Curso
