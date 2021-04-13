# Trabalho realizado para fins acadêmicos

## Ferramentas necessárias
#### Para iniciar essa aplicação, primeiramente é necessário obter o SDK do .NET CORE na versão 3.1 (ou superior). 
#### Além disso, se caso for utilizar o Visual Studio, utilizar a versão 16.8.1 (ou superior).

## Como iniciar
#### Depois de obter os requisitos acima e baixar a aplicação, será necessário você inicie ela. 
#### Caso você esteja utilizando o Visual Studio, garante que o projeto selecionado seja o 'Apresentation' (na aba superior próximo às opções de ambientes de execução).
#### Após isso, selecione o ambiente de execução 'IIS Express' e clique para iniciar a aplicação. 

## Observações
#### Não será necessário inserir uma conexão com o banco de dados, pois a aplicação usa um banco de dados em memória. Mas se caso quiser inserir uma ConnectionString de algum banco de dados, será necessário fazer as devidas alterações para realizar tal procedimento.

## Objetivo
#### O intuito dessa aplicação é implementar um sistema especialista, dentro do contexto de IA. Nele, é possível criar 1 ou N sistemas especialistas e suas respectivas características e, no final, iniciar o sistema para que o mesmo tente conseguir, com base nas respostas e regras inseridas, chegar à uma análise correta do problema apresentado.

## Como usar
#### > Primeiro, crie um projeto e o selecione
#### > Vá até a aba de 'Variáveis'. Nela, você irá inserir as variáveis do sistema, as perguntas correspondentes à elas e as opções de valores (caso não for objetivo) ou opções de resultado (caso for objetivo).
#### > Na aba de 'Regras', você irá associar as variáveis que não são objetivas com as que são objetivas, ou seja, você irá demonstrar quais valores de variáveis (não objetivas) resultam em um resultado (que são as variáveis objetivas).
#### > Na aba de 'Iniciar', você irá iniciar o sistema especialista, onde perguntas irão ser feitas e possíveis respostas poderão ser escolhidas.
#### > No final, irá mostrar o resultado da análise.

##### Tecnologias: 
##### Blazor WebAssembly e .NET Core.
