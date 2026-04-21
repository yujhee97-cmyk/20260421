using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToTitle : MonoBehaviour
{
    void Update()
    {
        // 2는 마우스 휠(가운데 버튼) 클릭을 의미합니다.
        // GetMouseButtonDown은 누르는 순간 작동합니다.
        if (Input.GetMouseButtonDown(2))
        {
            SceneManager.LoadScene("Title");
        }
    }
}
