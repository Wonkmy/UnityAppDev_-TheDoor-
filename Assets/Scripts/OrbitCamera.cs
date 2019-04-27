using UnityEngine;
using System.Collections;

/// <summary>
/// Handles orbiting a camera around a transform based on mouse input while looking at it
/// </summary>
public class OrbitCamera : MonoBehaviour
{
    public float sensitive = 0.001f;
    private void OnMouseDrag()
    {
        gameObject.transform.Rotate(new Vector3(0, -(Input.mousePosition.x - Camera.main.WorldToScreenPoint(gameObject.transform.position).x) * sensitive, 0));
    }
    //public float mRotationSpeed = 800f;
    /// <summary>
    /// 如果初始模型Y轴有旋转，需要把模型旋转值赋值到这里
    /// </summary>
    //private float mYRaation = 180;

    public void Update()
    {
        //if (Input.GetMouseButton(0))
        //{
        //     射线检测
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit hitInfo;
        //    if (Physics.Raycast(ray, out hitInfo))
        //    {
        //        if (hitInfo.collider.isTrigger)
        //        {
        //            获取鼠标输入  
        //            mYRaation += Input.GetAxis("Fire1") * mRotationSpeed;
        //            计算旋转  
        //            Quaternion mRotation = Quaternion.Euler(transform.rotation.x, -mYRaation, 0);
        //             插值旋转
        //            transform.rotation = Quaternion.Lerp(transform.rotation, mRotation, Time.deltaTime * mRotationSpeed);
        //        }
        //    }
        //}
    }

}