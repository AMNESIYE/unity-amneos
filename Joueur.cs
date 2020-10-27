using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joueur : MonoBehaviour
{
    //private Rigidbody rigidbody;
    [SerializeField] private float moveSpeed = 2.0f;

    public float viePlayer = 50.0f;
    // Start is called before the first frame update
    void Start()
    {
        //rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movements();
    }

    private void Movements()
    {
        /*if (Input.GetKey(KeyCode.Z))
            rigidbody.AddForce(Vector3.forward);
        if (Input.GetKey(KeyCode.S))
            rigidbody.AddForce(Vector3.back);
        if (Input.GetKey(KeyCode.D))
            rigidbody.AddForce(Vector3.right);
        if (Input.GetKey(KeyCode.Q))
            rigidbody.AddForce(Vector3.left);*/
        
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime);
    }
}
