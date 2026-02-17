# Setup rápido (Unity 2022+)

## Como abrir este blueprint no Unity
1. Abra o **Unity Hub**.
2. Clique em **New project** > **3D (URP)** > Create.
3. Depois da criação, feche o Unity Editor.
4. Copie `MundoX-Unity-MVP/Assets/Scripts` para `SEU_PROJETO/Assets/Scripts`.
5. Copie `MundoX-Unity-MVP/Packages/manifest.json` para `SEU_PROJETO/Packages/manifest.json`.
6. Reabra o projeto e aguarde a importação/recompilação.
7. Se houver aviso de pacote ausente, abra `Window > Package Manager` e reinstale o pacote listado.

## Configuração da cena
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
