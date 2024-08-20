using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public int velocidade = 10;
    private Rigidbody rb; 

    // Start is called before the first frame update
    void Start()
    {
       Debug.Log(message:"START");
       TryGetComponent(out rb);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(message:"UPDATE");

    float h = Input.GetAxis("Horizontal"); // -1 esquerda,0 ou nada, 1 direita
    float v = Input.GetAxis("Vertical"); // -1 pra tras,  nada, 1 ´pra frente
  
   
    UnityEngine.Vector3 direcao = new Vector3(x:h, y:0, z:v);
    rb.AddForce(direcao * velocidade);
    }
}
