# VidaPet — TP1 | C# / Ubuntu / VS Code

Projeto inicial para estudo e demonstração do TP1. **Não é o sistema completo.**

## 1. Instalar ferramentas (Ubuntu)
Instale o **.NET SDK 10** seguindo a documentação oficial para sua versão do Ubuntu: https://learn.microsoft.com/pt-br/dotnet/core/install/linux-ubuntu-install e instale o VS Code: https://code.visualstudio.com/docs/setup/linux . Na aba Extensões do VS Code, instale **C# Dev Kit** (Microsoft). Instale Git (`sudo apt update && sudo apt install git`). A disponibilidade do pacote `dotnet-sdk-10.0` depende da versão do Ubuntu e dos repositórios configurados.

## 2. Verificar o ambiente
```bash
dotnet --version
dotnet --list-sdks
git --version
code --version
```
A versão de SDK deve começar por `10.`.

## 3. Abrir e executar
```bash
cd VidaPet_TP1
code .
dotnet restore src/VidaPet.App/VidaPet.App.csproj
dotnet build src/VidaPet.App/VidaPet.App.csproj
dotnet run --project src/VidaPet.App/VidaPet.App.csproj
```
No VS Code: Terminal > Executar tarefa > **Executar VidaPet TP1**.

## 4. Como o código demonstra os fundamentos
- `string`, `int`, `bool`, `DateTime`, `TimeSpan`: dados básicos e temporais.
- `const`: duração e expediente.
- `if/else`, `&&`, `||`, `!`: validação de regras.
- `do/while` e `switch`: menu e repetição.
- `TryParse`/`TryParseExact`: entrada inválida não encerra o programa.
- Contadores e último nome: somente memória da execução, **não** cadastro real.

## 5. Testes manuais sugeridos
1. Digitar `x` no menu: mensagem de opção inválida, menu permanece.
2. Simular animal cão válido: contador incrementa.
3. Informar espécie diferente de C/G: operação recusada.
4. Simular veterinário válido: contador incrementa.
5. Informar uma data passada: horário recusado.
6. Informar sábado ou domingo: horário recusado.
7. Informar 17:45: horário recusado por terminar após 18h.
8. Informar dia útil futuro às 09:00: horário aprovado como **simulação**, sem salvar consulta.
9. Consultar resumo e sair.

## 6. Limitações conhecidas
Não há banco, arquivo, lista de animais, lista de veterinários, agenda real, verificação de conflito, identificação de usuário ou autorização por papel. Validação de CRMV/telefone é apenas de preenchimento. Nenhum agendamento é realmente registrado.

## 7. GitHub
```bash
git init
git add .
git commit -m "TP1: prototipo console e estrutura documental"
git branch -M main
git remote add origin https://github.com/SEU_USUARIO/vidapet-tp1.git
git push -u origin main
```
Crie primeiro um repositório vazio no GitHub; substitua `SEU_USUARIO`. Não é possível publicar automaticamente sem sua conta.

## 8. Entrega
Revise e produza pessoalmente a análise e a UML, conforme as regras acadêmicas. Gere o PDF revisado, grave o vídeo de até 5 min com webcam e tela, inclua link do GitHub no Moodle, e compacte arquivos com o nome `nome_sobrenome_PB_TP1.ZIP`. Preencha seu nome e código da disciplina.

## 9. Transparência do uso de IA
IA utilizada como par de programação para estruturar e revisar o programa C# e explicar seus fundamentos. Os documentos de requisitos, escopo e casos de uso fornecidos como **modelos de estudo** precisam de elaboração e validação autoral, segundo as orientações da disciplina.
