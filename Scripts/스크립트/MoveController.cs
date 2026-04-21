using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        // 2D 입력 받기
        float h = Input.GetAxisRaw("Horizontal"); // 좌(-1), 우(1)
        float v = Input.GetAxisRaw("Vertical");   // 하(-1), 상(1)

        // 2D는 X(좌우)와 Y(상하)를 사용합니다.
        Vector3 moveDir = new Vector3(h, v, 0).normalized;

        // 프레임 독립적인 이동
        transform.position += moveDir * moveSpeed * Time.deltaTime;
    }
}