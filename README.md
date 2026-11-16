# VidaPet — TP1 | C# / Ubuntu / VS Code

Projeto inicial para estudo do TP1. **Não é o sistema completo.**

## Como o código demonstra os fundamentos
- `string`, `int`, `bool`, `DateTime`, `TimeSpan`: dados básicos e temporais.
- `const`: duração e expediente.
- `if/else`, `&&`, `||`, `!`: validação de regras.
- `do/while` e `switch`: menu e repetição.
- `TryParse`/`TryParseExact`: entrada inválida não encerra o programa.
- Contadores e último nome: somente memória da execução, **não** cadastro real.

## Testes manuais sugeridos
1. Digitar `x` no menu: mensagem de opção inválida, menu permanece.
2. Simular animal cão válido: contador incrementa.
3. Informar espécie diferente de C/G: operação recusada.
4. Simular veterinário válido: contador incrementa.
5. Informar uma data passada: horário recusado.
6. Informar sábado ou domingo: horário recusado.
7. Informar 17:45: horário recusado por terminar após 18h.
8. Informar dia útil futuro às 09:00: horário aprovado como **simulação**, sem salvar consulta.
9. Consultar resumo e sair.

## Limitações conhecidas
Não há banco, arquivo, lista de animais, lista de veterinários, agenda real, verificação de conflito, identificação de usuário ou autorização por papel. Validação de CRMV/telefone é apenas de preenchimento. Nenhum agendamento é realmente registrado.


## Obs.:
IA utilizada como par de programação para estruturar e revisar o programa C# e explicar seus fundamentos. Os documentos de requisitos, escopo e casos de uso fornecidos como **modelos de estudo** precisam de elaboração e validação autoral, segundo as orientações da disciplina.
