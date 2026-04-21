using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private bool hasKey = false;
    private GameObject nearObject;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && nearObject != null)
        {
            if (nearObject.CompareTag("Key"))
            {
                hasKey = true;
                Debug.Log("<color=yellow>열쇠 획득!</color>");
                Destroy(nearObject);
                nearObject = null;
            }
            else if (nearObject.CompareTag("Door"))
            {
                if (hasKey)
                {
                    Debug.Log("<color=cyan>문이 열렸습니다!</color>");
                    Destroy(nearObject);
                    nearObject = null;
                }
                else
                {
                    Debug.Log("<color=red>열쇠가 필요합니다.</color>");
                }
            }
        }
    }

    // 1. 트리거인 열쇠(세모)를 감지
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Key")) nearObject = collision.gameObject;
    }

    // 2. 딱딱한 벽(문)에 부딪혔을 때 감지
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Door")) nearObject = collision.gameObject;
    }

    // 범위 밖으로 나갈 때 감지 해제
    private void OnTriggerExit2D(Collider2D collision) { if (collision.gameObject == nearObject) nearObject = null; }
    private void OnCollisionExit2D(Collision2D collision) { if (collision.gameObject == nearObject) nearObject = null; }
}
