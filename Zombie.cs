using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public float vie = 30.0f;
    public float vitesse = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckLife();
    }

    void CheckLife()
    {
        if (vie <= 0)
        {
            Destroy(this);
        }
    }

}
