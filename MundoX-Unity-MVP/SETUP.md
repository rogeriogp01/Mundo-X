# Setup detalhado (Unity 2022+)

## Passo a passo para colocar no Unity

### 1) Pré-requisitos
1. Instale o **Unity Hub**.
2. No Unity Hub, instale o **Unity 2022 LTS** (recomendado 2022.3+).
3. Tenha este repositório clonado/baixado no computador.

### 2) Criar o projeto base
1. Abra o **Unity Hub**.
2. Clique em **New project**.
3. Escolha o template **3D (URP)**.
4. Nomeie o projeto (ex.: `MundoXApp`).
5. Escolha a pasta onde o projeto será salvo.
6. Clique em **Create project**.
7. Espere abrir o Editor e depois **feche o Unity**.

### 3) Copiar os arquivos do blueprint
Com o Unity fechado:
1. Abra a pasta do seu projeto Unity.
2. Copie a pasta abaixo deste repositório:
   - Origem: `MundoX-Unity-MVP/Assets/Scripts`
   - Destino: `SEU_PROJETO/Assets/Scripts`
3. Copie também o manifesto de pacotes:
   - Origem: `MundoX-Unity-MVP/Packages/manifest.json`
   - Destino: `SEU_PROJETO/Packages/manifest.json`
4. Se o sistema pedir para substituir, confirme.

> Exemplo de destino no Windows: `C:\Projetos\MundoXApp\Assets\Scripts`

### 4) Reabrir e importar no Unity
1. Volte ao **Unity Hub**.
2. Abra o projeto `MundoXApp`.
3. Aguarde o Unity:
   - Baixar pacotes;
   - Reimportar assets;
   - Recompilar scripts (barra de progresso no canto inferior).
4. Só continue quando o Console estiver sem erros críticos de compilação.

### 5) Resolver pacotes (se necessário)
Se aparecer erro de pacote:
1. Abra `Window > Package Manager`.
2. Em **Packages: In Project**, localize o pacote com erro.
3. Clique em **Update** ou **Reinstall**.
4. Repita para todos os pacotes faltantes.

### 6) Montar a cena mínima para testar
1. Crie a cena `MainScene` (`File > New Scene`) e salve em `Assets/Scenes/MainScene.unity`.
2. Adicione um `Plane` como chão.
3. Crie um objeto `Player` com:
   - `CharacterController`
   - Tag `Player`
   - Script `PlayerController`
4. Crie uma zona de evento (`Cube` com collider `Is Trigger`) e adicione `EventParticipationManager`.
5. Crie um trigger de marca (`Cube` com `Is Trigger`) e adicione `BrandExperienceTrigger`.
6. Crie um `Canvas` com TextMeshPro para HUD e adicione `HudController`.
7. Adicione um objeto `NetworkManager` e o script `RealtimeBootstrap`.

### 7) Primeiro teste rápido
1. Clique em **Play**.
2. Movimente o Player (teclas WASD/setas).
3. Verifique no Console se não há erros de referência nula.
4. Entre na zona de evento e confirme ganho de XP (quando integrado ao HUD/progressão).

## Checklist de validação
- [ ] Scripts compilam sem erro.
- [ ] Cena `MainScene` abre corretamente.
- [ ] Player se move.
- [ ] Triggers detectam `Player`.
- [ ] Pacotes principais instalados.

## Segurança
- Não armazene chaves de IA no cliente.
- Use backend proxy para chamadas OpenAI.
- Valide XP/drop no servidor para evitar fraude.
