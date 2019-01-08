using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float sensitivity;
    public Transform characterBody;

    public int maxY;
    public int minY;
    [SerializeField]
    private float rotY;
    private float rotX;


    private void Update() {
        rotX += Input.GetAxis("Mouse X") * sensitivity;
        rotY += Input.GetAxis("Mouse Y") * sensitivity;
        rotY = Mathf.Clamp(rotY, minY, maxY);

        characterBody.eulerAngles = new Vector3(0, rotX, 0);
        transform.localEulerAngles = new Vector3(-rotY, 0, 0);
    }

    private void OnDisable() {
        
    }
}
