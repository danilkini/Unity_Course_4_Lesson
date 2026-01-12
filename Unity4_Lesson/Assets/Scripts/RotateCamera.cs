using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float speedRotate;
    
    void Start()
    {
        
    }

    void Update()
    {
        float horizontInput = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up * Time.deltaTime * horizontInput * speedRotate);

    }
}
