using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour
{
    public Material[] skin;
    public float velocidade, velocidadeRotate;
    public GameObject tiro;
    // Start is called before the first frame update
    void Start()
    {
        int n = Random.Range(0, skin.Length);
        this.gameObject.GetComponent<Renderer>().material = skin[n];
    }

    // Update is called once per frame
    void Update()
    {
        if(isLocalPlayer)
        {
            if(Input.GetAxis("Horizontal") > 0)
             {
                 transform.Rotate(Vector3.up * velocidadeRotate * Time.deltaTime);
             }

            if(Input.GetAxis("Horizontal") < 0)
            {
               transform.Rotate(Vector3.up * -velocidadeRotate * Time.deltaTime);
            }

            if(Input.GetAxis("Vertical") > 0)
            {
                transform.Translate(Vector3.forward * velocidade * Time.deltaTime);
            }

            if(Input.GetAxis("Vertical") < 0)
            {
                transform.Translate(Vector3.back * velocidade * Time.deltaTime);
            }
        }
        
    }
}
