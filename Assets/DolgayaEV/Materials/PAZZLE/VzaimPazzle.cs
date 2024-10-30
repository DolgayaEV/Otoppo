using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VzaimPazzle : MonoBehaviour
{
    private Vector3 offset;
    private Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

    void OnMouseDown()
    {
        offset = transform.position - GetMouseWorldPos();
    }

    void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + offset;
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mouseScreenPos = Input.mousePosition;
        mouseScreenPos.z = cam.nearClipPlane; // расстояние от камеры
        return cam.ScreenToWorldPoint(mouseScreenPos);
    }
}

