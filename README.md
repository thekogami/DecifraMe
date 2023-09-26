# DecifraMe

DecifraMe é um aplicativo Xamarin.Forms que apresenta ao usuário uma série de charadas. O usuário deve inserir a resposta correta para avançar para a próxima charada. Se a resposta estiver errada, uma mensagem de alerta será exibida.

## Estrutura do Projeto

O projeto é composto por três páginas:

- `Page1`: Contém a primeira charada. Se a resposta for "SILENCIO", o usuário avança para `Page2`.
- `Page2`: Contém a segunda charada. Se a resposta for "PIANO", o usuário avança para `Page3`.
- `Page3`: Última página, que permite ao usuário retornar à página inicial.

## Funcionalidades

- Verificação de respostas: As respostas são verificadas em maiúsculas para evitar problemas de case-sensitivity.
- Navegação: Utiliza o sistema de navegação do Xamarin.Forms para mover entre as páginas.
- Tratamento de campos vazios: Se o usuário tentar enviar uma resposta vazia, nenhuma ação será tomada.

## Como Usar

1. Abra o aplicativo.
2. Insira a resposta para a charada apresentada.
3. Clique no botão "Responder" para verificar a resposta.
4. Se estiver correto, você será direcionado para a próxima charada.

## Dependências

- Xamarin.Forms
