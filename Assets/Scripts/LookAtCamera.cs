using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    private Camera mainCamera;
    void Start()
    {
        mainCamera = Camera.main;
        
    }

    private void LateUpdate() {
        transform.LookAt(mainCamera.transform.position);
    }
}
