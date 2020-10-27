using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoueurTir : MonoBehaviour
{
    private Ray ray;
    //[SerializeField] private AudioClip sonTir;
    [SerializeField] private float degatArme = 5.0f;
    private RaycastHit hit;    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //GetComponent<AudioSource>().PlayOneShot(sonTir);
            
            Vector2 ScreenOnPoint = new Vector2(Screen.width/2, Screen.height/2);
            ray = Camera.main.ScreenPointToRay(ScreenOnPoint);

            if (Physics.Raycast(ray, out hit, Camera.main.farClipPlane))
            {
                if (hit.transform.gameObject.tag == "Zombie")
                {
                    Zombie cible = hit.transform.gameObject.GetComponent<Zombie>();
                    cible.vie -= degatArme;
                }
            }
        }
    }
}