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
    /// �����ʼģ��Y������ת����Ҫ��ģ����תֵ��ֵ������
    /// </summary>
    //private float mYRaation = 180;

    public void Update()
    {
        //if (Input.GetMouseButton(0))
        //{
        //     ���߼��
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit hitInfo;
        //    if (Physics.Raycast(ray, out hitInfo))
        //    {
        //        if (hitInfo.collider.isTrigger)
        //        {
        //            ��ȡ�������  
        //            mYRaation += Input.GetAxis("Fire1") * mRotationSpeed;
        //            ������ת  
        //            Quaternion mRotation = Quaternion.Euler(transform.rotation.x, -mYRaation, 0);
        //             ��ֵ��ת
        //            transform.rotation = Quaternion.Lerp(transform.rotation, mRotation, Time.deltaTime * mRotationSpeed);
        //        }
        //    }
        //}
    }

}