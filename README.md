readme_text = """
# 🏥 Projeto BlackOutCare – Sistema de Apoio em Quedas de Energia

## 📌 Objetivo do Projeto
O projeto **BlackOutCare** tem como objetivo criar um sistema robusto e integrado para **monitoramento e suporte em ambientes críticos durante quedas de energia elétrica**. Com foco em hospitais, clínicas e áreas sensíveis, a solução oferece funcionalidades para registro de incidentes, alertas, visualização de status e geração de relatórios, tudo mesmo em cenários adversos.

## ✅ Requisitos do Sistema

### Requisitos Funcionais:
- Realizar login com validação de usuário e senha
- Registrar incidentes com data, setor e descrição
- Emitir alertas para setores específicos
- Monitorar o status dos setores
- Gerar relatório com histórico de alertas e incidentes

### Requisitos Não Funcionais:
- Sistema com funcionamento local (offline)
- Tempo de resposta inferior a 2 segundos nas operações
- Interface simples e via terminal (console)
- Compatibilidade com Windows 10+

## 🧠 Regras de Negócio
- O sistema só é acessível mediante login válido
- Alertas alteram o status do setor para “ALERTA”
- Setores são monitorados continuamente no sistema
- Relatórios exibem todos os eventos desde o início da sessão

## 🛠️ Tecnologias Utilizadas
- Linguagem: **C# (.NET)**
- Interface: Console Application
- Padrão arquitetural: **MVC**
- Organização por camadas:
  - `Model/`: estrutura dos dados
  - `Controller/`: lógica de negócio
  - `Repository/`: simulação do banco de dados
  - `View/`: interação com o usuário

## 🗂️ Estrutura de Pastas
BlackOutCare/
├── Model/
│ ├── Usuario.cs
│ ├── Incidente.cs
│ ├── Setor.cs
│ └── Alerta.cs
├── Repository/
│ └── BancoSimulado.cs
├── Controller/
│ ├── LoginController.cs
│ ├── IncidenteController.cs
│ ├── AlertaController.cs
│ ├── SetorController.cs
│ └── RelatorioController.cs
├── View/
│ ├── LoginView.cs
│ └── MenuView.cs
└── Program.cs


## 🔁 Fluxograma da Lógica do Sistema
![image](https://github.com/user-attachments/assets/bd63ae81-e773-4347-b883-587f6b55d50e)


## 🧪 Funcionalidades Implementadas

| # | Funcionalidade | Descrição |
|--|----------------|-----------|
| 1 | Registro de Incidente | Coleta setor, data e descrição |
| 2 | Emissão de Alerta | Gera alerta e atualiza status |
| 3 | Monitoramento | Exibe status atual de todos os setores |
| 4 | Relatório | Mostra todos os incidentes e alertas da sessão |
| - | Login | Valida usuário e senha no início do sistema |

## ▶️ Como Executar
1. Abra o projeto no **Visual Studio**
2. Compile com `Ctrl + Shift + B`
3. Execute com `F5`
4. Faça login usando:
   - Usuário: `admin`
   - Senha: `123`
5. Navegue pelo menu para testar as funcionalidades

