using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToExit : MonoBehaviour
{
    void Update()
    {
        // 1은 오른쪽 마우스 버튼을 의미합니다. 
        // GetMouseButtonUp은 눌렀다 뗐을 때 작동합니다.
        if (Input.GetMouseButtonUp(1))
        {
            SceneManager.LoadScene("End");
        }
    }
}
