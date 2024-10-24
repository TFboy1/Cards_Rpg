using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;  // 要跟随的目标（例如玩家）
    public Vector3 offset;    // 摄像机与目标之间的偏移量
    public float smoothSpeed = 0.125f;  // 平滑跟随的速度

    void LateUpdate()
    {
        // 目标位置加上偏移量
        Vector3 desiredPosition = target.position + offset;

        // 使用插值函数使摄像机平滑跟随
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // 更新摄像机的位置
        transform.position = smoothedPosition;

        // 始终面向目标
        transform.LookAt(target);
    }
}
