# O Mundo X — Unity MVP Blueprint

Este repositório contém um **blueprint funcional** para iniciar o app mobile social gamificado "O Mundo X" usando Unity 2022+.

## Objetivo do MVP
- Presença ativa em ambiente 3D (praças e eventos).
- Progressão por presença e participação (não pay-to-win).
- Sistema de baús com itens cosméticos e raridade social.
- Interação social em tempo real com base em sessões/eventos.
- Integrações de marca imersivas sem interromper o fluxo.
- Ganchos de IA para conteúdo dinâmico.

## Estrutura
- `MundoX-Unity-MVP/Packages/manifest.json`: pacotes sugeridos.
- `MundoX-Unity-MVP/Assets/Scripts`: scripts base por domínio.

## Fluxo de implementação
1. Criar projeto Unity 2022 LTS (3D URP mobile).
2. Copiar a pasta `MundoX-Unity-MVP` para dentro do projeto.
3. Ajustar IDs de pacotes/SDKs (Firebase/OpenAI/Netcode).
4. Criar prefabs base:
   - `AvatarPrefab` (NetworkObject + PlayerController).
   - `ChestPrefab` (trigger + ChestLootSystem).
   - `EventZonePrefab` (trigger + EventParticipationManager).
5. Configurar backend Firebase (Auth + Firestore + Remote Config).
6. Configurar serviço de IA em backend seguro (não expor chave em cliente).
7. Buildar Android/iOS e validar telemetria.

## Notas de arquitetura
- Autoritativo no servidor para XP, drop e inventário.
- Inventário e progressão com versionamento de schema.
- Raridade com economia limitada por temporada.
- Eventos e missões com configuração remota.

## Próximos passos recomendados
- Adicionar moderação (filtro de chat e anti-abuso).
- Implementar reconexão resiliente em redes móveis.
- Criar testes de economia (simulação Monte Carlo de drops).
- Instrumentar analytics por funil (retenção D1/D7/D30).
