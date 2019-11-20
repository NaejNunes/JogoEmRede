using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carro : MonoBehaviour
{
    public float velocidade;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Vertical") > 0)
        {
            transform.Translate(Vector3.forward * velocidade * Time.deltaTime);
        }
    }
}
