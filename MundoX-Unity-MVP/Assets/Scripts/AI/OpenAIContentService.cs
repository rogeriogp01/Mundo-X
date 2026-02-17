using System.Collections;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;

namespace MundoX.AI
{
    public class OpenAIContentService : MonoBehaviour
    {
        [SerializeField] private string backendProxyUrl = "https://your-backend.example.com/ai/events";

        public IEnumerator RequestDynamicEvent(string playerContextJson, System.Action<string> onCompleted)
        {
            var body = Encoding.UTF8.GetBytes(playerContextJson);

            var request = new UnityWebRequest(backendProxyUrl, UnityWebRequest.kHttpVerbPOST)
            {
                uploadHandler = new UploadHandlerRaw(body),
                downloadHandler = new DownloadHandlerBuffer()
            };
            request.SetRequestHeader("Content-Type", "application/json");

            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                onCompleted?.Invoke(request.downloadHandler.text);
            }
            else
            {
                onCompleted?.Invoke("{\"error\":\"ai_service_unavailable\"}");
            }
        }
    }
}
