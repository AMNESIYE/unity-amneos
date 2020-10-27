using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Zombie zombieScript;
    
    // Start is called before the first frame update
    void Start()
    {
        zombieScript = GetComponent<Zombie>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        ComportementZombie();
    }
    
    private void ComportementZombie()
    {
        Vector3 positionPlayer = player.transform.position;
        Vector3 positionZombie = transform.position;
        if (Vector3.Distance(positionPlayer, positionZombie) > 3.0f)
        {
            transform.position = Vector3.MoveTowards(positionZombie, positionPlayer, zombieScript.vitesse * Time.deltaTime);
        }
    }
}
