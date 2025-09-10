<img src="https://github.com/fzanneti/wex-e2e-csharp/blob/main/study_material/08IntroductionToTheCloudWithAWS/ChallengeReducePharmacyCostsWithAWS/assets/images/logo.png" width=185px align="left">

### RELATÓRIO DE IMPLEMENTAÇÃO DE SERVIÇOS AWS

**Data:** 15 de Julho de 2025  
**Empresa:** Abstergo Industries - Empresa do segmento farmacêutico  
**Responsável:** Fabio Zanneti da Silva  
**Parceria:** DIO e Wex

---

# Introdução

Este relatório apresenta o processo de implementação de ferramentas AWS na empresa **Abstergo Industries**, realizado por *Fabio Zanneti da Silva*. O objetivo do projeto foi implementar três serviços da AWS (Amazon EC2, Amazon S3 e AWS Lambda) com a finalidade de otimizar processos, aumentar a escalabilidade e reduzir custos operacionais imediatos.

---

# Descrição do Projeto

O projeto de implementação de ferramentas foi dividido em 3 etapas, cada uma com objetivos específicos voltados para atender às necessidades do setor financeiro da Abstergo Industries. A seguir, serão descritas as etapas do projeto:

1. **Nome da ferramenta:** Amazon EC2 (Elastic Compute Cloud)  
- **Foco da ferramenta:** Infraestrutura de computação escalável  
- **Descrição de caso de uso:**  
  A Abstergo Industries possui um sistema interno de gerenciamento de dados financeiros que enfrenta picos sazonais de uso, como no fechamento fiscal. O Amazon EC2 foi implementado para fornecer instâncias de computação sob demanda, permitindo escalabilidade automática durante períodos de alta demanda. Isso elimina a necessidade de servidores físicos locais, reduzindo custos com manutenção de hardware e consumo energético. A configuração de auto-scaling garante que a empresa pague apenas pela capacidade utilizada, otimizando os gastos.

    

2. **Nome da ferramenta:** Amazon S3 (Simple Storage Service)  
- **Foco da ferramenta:** Armazenamento de dados seguro e econômico  
- **Descrição de caso de uso:**  
  Para gerenciar o grande volume de relatórios financeiros, históricos de transações e documentos regulatórios, a Abstergo Industries implementou o Amazon S3. Este serviço permite o armazenamento seguro de dados com alta disponibilidade e durabilidade, além de oferecer opções de classes de armazenamento (como S3 Glacier) para dados arquivados, reduzindo significativamente os custos em comparação com soluções locais. A integração com políticas de acesso via IAM garante conformidade com normas de segurança do setor farmacêutico.

3. **Nome da ferramenta:** AWS Lambda  
- **Foco da ferramenta:** Computação sem servidor para automação de processos  
- **Descrição de caso de uso:**  
  A Abstergo Industries identificou a necessidade de automatizar processos repetitivos, como a geração de relatórios financeiros diários e a validação de dados contábeis. O AWS Lambda foi implementado para executar essas tarefas sem a necessidade de gerenciar servidores, reduzindo custos operacionais. Por exemplo, funções Lambda foram configuradas para processar automaticamente dados de transações em tempo real, gerando relatórios e alertas para o setor financeiro, o que aumentou a eficiência e reduziu o tempo de processamento manual.  

---

### Benefícios e Redução de Custos

A implementação das três ferramentas AWS trouxe os seguintes benefícios:  
- **Amazon EC2:** Redução de até 40% nos custos de infraestrutura devido à eliminação de servidores físicos e à utilização de instâncias sob demanda.  
- **Amazon S3:** Economia de aproximadamente 60% em armazenamento de dados arquivados com a classe S3 Glacier, além de maior segurança e conformidade regulatória.  
- **AWS Lambda:** Diminuição de 50% nos custos operacionais relacionados a processos manuais, com automação que reduz o tempo de execução de tarefas repetitivas. 

---

# Conclusão

A implementação das ferramentas Amazon EC2, Amazon S3 e AWS Lambda na Abstergo Industries resultará em maior eficiência operacional, escalabilidade e segurança, além de uma redução significativa nos custos operacionais. Estima-se uma economia total de 45-50% nos processos financeiros e de infraestrutura. Recomenda-se a continuidade da utilização dessas ferramentas e a exploração de outros serviços AWS, como Amazon RDS, para otimizar ainda mais os processos da empresa.

---

# Anexos

- [Planilha de custos detalhada](https://github.com/fzanneti/wex-e2e-csharp/blob/main/study_material/08IntroductionToTheCloudWithAWS/ChallengeReducePharmacyCostsWithAWS/assets/docs/xls/Analise%20de%20Custo%20-%20Abstergo.xlsx)
- [Manual de configuração do Amazon EC2](https://github.com/fzanneti/wex-e2e-csharp/blob/main/study_material/08IntroductionToTheCloudWithAWS/ChallengeReducePharmacyCostsWithAWS/assets/docs/pdf/Amazon%20EC2.pdf)  
- [Documentação de políticas de segurança do Amazon S3](https://github.com/fzanneti/wex-e2e-csharp/blob/main/study_material/08IntroductionToTheCloudWithAWS/ChallengeReducePharmacyCostsWithAWS/assets/docs/pdf/Amazon%20EC2.pdf)  
- [Relatório de automação com AWS Lambda](https://github.com/fzanneti/wex-e2e-csharp/blob/main/study_material/08IntroductionToTheCloudWithAWS/ChallengeReducePharmacyCostsWithAWS/assets/docs/pdf/AWS%20Lambda.pdf)  

*Nota: Os anexos podem ser fornecidos em formato editável para ajustes, se necessário.*

---
<br>
<img src="https://github.com/fzanneti/wex-e2e-csharp/blob/main/study_material/08IntroductionToTheCloudWithAWS/ChallengeReducePharmacyCostsWithAWS/assets/images/ass.png" width="150px">   
_______________________<br>                    
Fabio Zanneti da Silva<br>
