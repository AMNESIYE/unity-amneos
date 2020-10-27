using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieCollision : MonoBehaviour
{

    [SerializeField] private GameObject player;

    private Joueur joueurScript;
    // Start is called before the first frame update
    void Start()
    {
        joueurScript = player.GetComponent<Joueur>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            joueurScript.viePlayer--;
        }
    }
}
