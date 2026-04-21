using UnityEngine;
using UnityEngine.SceneManagement; // 씬 관리를 위해 필수

public class TitleController : MonoBehaviour
{
    void Update()
    {
        // 0은 왼쪽 마우스 클릭을 의미합니다.
        if (Input.GetMouseButtonDown(0))
        {
            // MainGame 씬으로 이동합니다.
            SceneManager.LoadScene("MainGame");
        }
    }
}