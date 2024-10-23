using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class card_move : MonoBehaviour
{
    public float moveSpeed = 5f;    // 移动速度
    private Rigidbody2D rb2d;       // 2D 刚体引用
    private Vector2 movement;       // 保存移动方向

    void Start()
    {
        // 获取Rigidbody2D组件
        rb2d = GetComponent<Rigidbody2D>();

        if (rb2d == null)
        {
            Debug.LogError("没有找到 Rigidbody2D 组件，请确保已附加 Rigidbody2D！");
        }
    }

    void Update()
    {
        // 获取水平和垂直方向输入 (AWSD 控制)
        float moveX = Input.GetAxisRaw("Horizontal");  // A(-1) 和 D(1) 控制左右移动
        float moveY = Input.GetAxisRaw("Vertical");    // W(1) 和 S(-1) 控制上下移动

        // 创建移动向量
        movement = new Vector2(moveX, moveY).normalized;  // 归一化向量，保持速度恒定
    }

    void FixedUpdate()
    {
        // 使用刚体2D移动
        rb2d.MovePosition(rb2d.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
