# Health Control

## Sobre o projeto

O **Health Control** é um sistema desenvolvido para servir como uma base operacional para gestores e equipes, especialmente em ambientes corporativos nos quais diferentes setores possuem sistemas e fluxos de trabalho independentes.

A proposta é centralizar e facilitar a execução das atividades operacionais de cada setor, proporcionando uma solução previamente estruturada que pode ser adaptada às necessidades específicas de cada empresa.

O projeto busca, dessa forma, **reduzir o tempo necessário para desenvolvimento de novas soluções, acelerar a implementação de sistemas internos e disponibilizar uma base funcional para gestores e suas equipes**.

## Objetivo

O objetivo principal do Health Control é fornecer uma **base reutilizável, adaptável e de código aberto para sistemas internos corporativos**, permitindo que organizações possam reduzir o esforço inicial necessário para desenvolver ferramentas específicas para seus setores.

A ideia é oferecer uma estrutura que possa evoluir conforme as necessidades de cada ambiente, servindo tanto como solução funcional quanto como ponto de partida para novos sistemas.

## Tecnologias

O sistema é desenvolvido utilizando o ecossistema **C#/.NET**, com **Blazor Server** como principal tecnologia para a aplicação.

A escolha dessa stack permite que o Health Control seja facilmente integrado e adaptado a ambientes corporativos que já utilizam tecnologias e serviços do ecossistema Microsoft.

### Principais tecnologias

* **C#**
* **.NET**
* **Blazor Server**

## Open Source

O Health Control é desenvolvido como um projeto de **código aberto**, possuindo uma licença MIT.

O usuário possui liberdade para:

* Utilizar o sistema em sua própria empresa;
* Modificar o código-fonte conforme suas necessidades;
* Adaptar ou expandir suas funcionalidades;
* Publicar versões modificadas;
* Integrar o sistema a outros projetos e serviços.

O projeto pode ser utilizado tanto em sua forma original quanto como base para o desenvolvimento de soluções completamente personalizadas.

## Desenvolvimento com auxílio de IA

Durante o desenvolvimento do projeto, ferramentas de **Inteligência Artificial** foram utilizadas como recurso auxiliar, principalmente na elaboração de elementos de interface e design.

Entretanto, todo o código produzido com esse auxílio foi **analisado, corrigido, adaptado, orientado e supervisionado pelo desenvolvedor responsável pelo projeto**.

A utilização de IA teve como objetivo apoiar o processo de desenvolvimento, sem substituir a análise técnica, as decisões arquiteturais ou a responsabilidade do desenvolvedor sobre o código final.

## Segurança

O projeto possui, por padrão, mecanismos básicos de segurança implementados, incluindo:

* **Hashing de credenciais**
* **Salting**
* **Sanitização de entradas**
* **Rate Limiting**
* **Account Lockout**

Esses mecanismos fornecem uma camada inicial de proteção para a aplicação. Entretanto, a implementação de medidas adicionais é recomendada de acordo com o ambiente em que o sistema será executado.

### Medidas adicionais recomendadas

Dependendo da infraestrutura e do nível de exposição da aplicação, recomenda-se considerar a implementação de:

* **HTTPS**
* **Web Application Firewall (WAF)**
* **Autenticação Multifator (MFA)**
* Políticas adicionais de controle de acesso e monitoramento

A configuração adequada dessas medidas deve considerar a infraestrutura, os dados tratados e os requisitos de segurança da organização.

## Administração e manutenção

Embora o sistema possua uma estrutura inicial de segurança e funcionalidades operacionais, sua implantação em um ambiente corporativo exige gerenciamento adequado da aplicação e de sua infraestrutura.

É **altamente recomendado que o ambiente possua pelo menos um profissional qualificado** para realizar a administração e manutenção do sistema, abrangendo aspectos como:

* Código e manutenção da aplicação;
* Banco de dados;
* Servidor e infraestrutura;
* Configurações de segurança;
* Atualizações e correções;
* Monitoramento e disponibilidade do sistema.

## Status do projeto

**Em desenvolvimento**

O **Health Control** encontra-se atualmente em **fase de desenvolvimento**, sendo desenvolvido também como **projeto acadêmico**.

O conteúdo apresentado sobre o sistema ainda não está em fase completa, após a finalização a expectativa é que seu uso e funcionalidades estão pouco além do que foi apresentado atualmente
