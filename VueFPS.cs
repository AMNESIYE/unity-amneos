using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VueFPS : MonoBehaviour
{
  
    public float minimumVert = -45.0f;
    public float maximumVert = 45.0f;

    public float sensVertical = 35.0f;
    public float sensHorizontal = 35.0f;

    public float _rotationX;

    void Awake()
    {
        CursorLock();
        _rotationX = 0;
    }
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        CameraRotationX();
        CameraRotationY();
    }

    private void CameraRotationX()
    {
        transform.Rotate (0, Input.GetAxis ("Mouse X") * sensHorizontal * Time.deltaTime, 0);
    }

    private void CameraRotationY()
    {
        _rotationX -= Input.GetAxis ("Mouse Y") * sensVertical * Time.deltaTime;
        _rotationX = Mathf.Clamp (_rotationX, minimumVert, maximumVert);

        float rotationY = transform.localEulerAngles.y;

        transform.localEulerAngles = new Vector3 (_rotationX, rotationY, 0);
    }

    private void CursorLock()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
}
