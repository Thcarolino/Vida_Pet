using System;
using System.Globalization;

// VidaPet - TP1
CultureInfo.CurrentCulture = new CultureInfo("pt-BR");
const int DuracaoConsultaMinutos = 30;
const int HoraInicio = 8;
const int HoraFim = 18;
int totalAnimais = 0;
int totalVeterinarios = 0;
int simulacoesValidas = 0;
string ultimoAnimal = "(nenhum)";
string ultimoVeterinario = "(nenhum)";
int opcao;

do
{
    Console.WriteLine("\n=== VidaPet |  TP1 ===");
    Console.WriteLine("1 - Cadastrar animal");
    Console.WriteLine("2 - Cadastrar veterinário");
    Console.WriteLine("3 - Verificar horário de consulta");
    Console.WriteLine("4 - Resumo da sessão");
    Console.WriteLine("0 - Sair");
    Console.Write("Opção: ");
    if (!int.TryParse(Console.ReadLine(), out opcao)) opcao = -1;

    switch (opcao)
    {
        case 1:
            Console.Write("Nome do animal: ");
            string nomeAnimal = (Console.ReadLine() ?? "").Trim();
            Console.Write("Espécie (C = cão, G = gato): ");
            string especie = (Console.ReadLine() ?? "").Trim().ToUpperInvariant();
            Console.Write("Idade em anos: ");
            bool idadeValida = int.TryParse(Console.ReadLine(), out int idade);
            Console.Write("Nome do tutor: ");
            string tutor = (Console.ReadLine() ?? "").Trim();
            Console.Write("Telefone do tutor: ");
            string telefone = (Console.ReadLine() ?? "").Trim();
            if (nomeAnimal.Length == 0 || (especie != "C" && especie != "G") ||
                !idadeValida || idade < 0 || tutor.Length == 0 || telefone.Length == 0)
            {
                Console.WriteLine("Dados inválidos. Nenhum cadastro realizado.");
                break;
            }
            totalAnimais++;
            ultimoAnimal = nomeAnimal;
            Console.WriteLine($"Simulação #{totalAnimais}: {nomeAnimal}, {(especie == "C" ? "cão" : "gato")}, {idade} ano(s), tutor: {tutor}, Contato: ({telefone}).");
            break;

        case 2:
            Console.Write("Nome do veterinário: ");
            string nomeVet = (Console.ReadLine() ?? "").Trim();
            Console.Write("CRMV: ");
            string crmv = (Console.ReadLine() ?? "").Trim();
            if (nomeVet.Length == 0 || crmv.Length == 0)
            {
                Console.WriteLine("Dados inválidos. Nenhum cadastro simulado.");
                break;
            }
            totalVeterinarios++;
            ultimoVeterinario = nomeVet;
            Console.WriteLine($"Simulação #{totalVeterinarios}: {nomeVet}, (CRMV {crmv}).");
            break;

        case 3:
            Console.Write("Data (dd/MM/aaaa): ");
            string entradaData = Console.ReadLine() ?? "";
            Console.Write("Hora inicial (HH:mm): ");
            string entradaHora = Console.ReadLine() ?? "";
            bool dataOk = DateTime.TryParseExact(entradaData, "dd/MM/yyyy", CultureInfo.GetCultureInfo("pt-BR"), DateTimeStyles.None, out DateTime data);
            bool horaOk = TimeSpan.TryParseExact(entradaHora, @"hh\:mm", CultureInfo.InvariantCulture, out TimeSpan hora);
            if (!dataOk || !horaOk)
            {
                Console.WriteLine("Data ou horário inválido.");
                break;
            }
            DateTime inicio = data.Date.Add(hora);
            DateTime fim = inicio.AddMinutes(DuracaoConsultaMinutos);
            bool diaUtil = inicio.DayOfWeek >= DayOfWeek.Monday && inicio.DayOfWeek <= DayOfWeek.Friday;
            bool dentroExpediente = hora >= TimeSpan.FromHours(HoraInicio) && fim.TimeOfDay <= TimeSpan.FromHours(HoraFim);
            bool futuro = inicio > DateTime.Now;
            if (diaUtil && dentroExpediente && futuro)
            {
                simulacoesValidas++;
                Console.WriteLine($"Horário permitido pelas regras básicas: {inicio:dd/MM/yyyy HH:mm} a {fim:HH:mm}.");
                Console.WriteLine("ATENÇÃO: não há agendamento real nem verificação de conflitos neste TP1.");
            }
            else
            {
                Console.WriteLine("Horário recusado: verifique dia útil, expediente 08:00-18:00 e data futura.");
            }
            break;

        case 4:
            Console.WriteLine($"Animais cadastrados: {totalAnimais} | Último: {ultimoAnimal}");
            Console.WriteLine($"Veterinários cadastrados: {totalVeterinarios} | Último: {ultimoVeterinario}");
            Console.WriteLine($"Horários aprovados: {simulacoesValidas}");
            Console.WriteLine("Dados apenas em memória; não existe armazenamento de registros.");
            break;
        case 0:
            Console.WriteLine("Encerrando VidaPet TP1. Até logo!");
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
} while (opcao != 0);
