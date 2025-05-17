using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    [Header("참조")]
    public Rigidbody2D rigid;
    [Header("설정")]
    public float jumpPower = 1f;
    public float grandCheckDistance = 1f;
    public LayerMask groundLayer;
    private bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 유니티 키보드 스페이스바를 입력받았을 때 - 조건
        // rigid에 있는 AddForce Vector.up 실행한다.
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, grandCheckDistance, groundLayer);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rigid.AddForce(jumpPower * Vector2.up, ForceMode2D.Impulse);
        }
    }
}
