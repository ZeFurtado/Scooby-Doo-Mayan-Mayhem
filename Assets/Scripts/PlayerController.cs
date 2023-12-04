using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float velocidade;
        float xKey = Input.GetAxis("Horizontal");
        float yKey = Input.GetAxis("Vertical");

        Vector3 position = new Vector3();
        position.Set(xKey, yKey, 0);

        float timeSinceLastFrame = Time.deltaTime;


        if(xKey!= 0 && yKey != 0)
        {
            velocidade = 0.4f;
        }else
        {
            velocidade = 0.6f;
        }

        Vector3 translation = position * velocidade * timeSinceLastFrame;
        transform.Translate(translation);
        
    }
}
