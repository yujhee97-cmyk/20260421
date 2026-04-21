using UnityEngine;
using UnityEngine.SceneManagement; // 씬 전환을 위한 네임스페이스

public class Goal2D : MonoBehaviour
{
    public string sceneName = "End"; // 이동할 씬 이름

    // 2D 트리거 콜라이더에 무언가 들어왔을 때 실행됩니다.
    private void OnTriggerEnter2D(Collider2D other)
    {
        // 부딪힌 오브젝트의 태그가 "Player"인지 확인
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}