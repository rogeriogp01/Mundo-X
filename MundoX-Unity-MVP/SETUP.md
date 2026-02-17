# Setup rápido (Unity 2022+)

1. Crie um projeto `3D (URP)` no Unity Hub.
2. Feche o editor.
3. Copie `Assets/` e `Packages/manifest.json` deste blueprint para o projeto.
4. Abra o Unity e deixe recompilar scripts.
5. Instale Firebase SDK (Auth + Firestore) manualmente.
6. Crie cena `MainScene` com:
   - Ground + iluminação mobile.
   - Player prefab com `CharacterController`, tag `Player`, e `PlayerController`.
   - Zona de evento com collider trigger + `EventParticipationManager`.
   - Trigger de marca com `BrandExperienceTrigger`.
   - HUD com TextMeshPro + `HudController`.
7. Configure Netcode em um objeto `NetworkManager` + `RealtimeBootstrap`.
8. Rode no editor com duas instâncias para validar presença social.

## Segurança
- Não armazene chaves de IA no cliente.
- Use backend proxy para chamadas OpenAI.
- Valide XP/drop no servidor para evitar fraude.
