using Unity.Netcode;
using UnityEngine;

namespace MundoX.Networking
{
    public class RealtimeBootstrap : MonoBehaviour
    {
        [SerializeField] private bool startAsHost;

        private void Start()
        {
            if (startAsHost)
            {
                NetworkManager.Singleton.StartHost();
                return;
            }

            NetworkManager.Singleton.StartClient();
        }
    }
}
