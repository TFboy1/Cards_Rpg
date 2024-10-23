using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class card_move : MonoBehaviour
{
    public float moveSpeed = 5f;    // �ƶ��ٶ�
    private Rigidbody2D rb2d;       // 2D ��������
    private Vector2 movement;       // �����ƶ�����

    void Start()
    {
        // ��ȡRigidbody2D���
        rb2d = GetComponent<Rigidbody2D>();

        if (rb2d == null)
        {
            Debug.LogError("û���ҵ� Rigidbody2D �������ȷ���Ѹ��� Rigidbody2D��");
        }
    }

    void Update()
    {
        // ��ȡˮƽ�ʹ�ֱ�������� (AWSD ����)
        float moveX = Input.GetAxisRaw("Horizontal");  // A(-1) �� D(1) ���������ƶ�
        float moveY = Input.GetAxisRaw("Vertical");    // W(1) �� S(-1) ���������ƶ�

        // �����ƶ�����
        movement = new Vector2(moveX, moveY).normalized;  // ��һ�������������ٶȺ㶨
    }

    void FixedUpdate()
    {
        // ʹ�ø���2D�ƶ�
        rb2d.MovePosition(rb2d.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
