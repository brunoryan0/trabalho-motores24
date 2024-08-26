using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public int velocidade = 10;
    private Rigidbody rb; 
    public int forcaPulo = 7;
    public bool noChao;

    // Start is called before the first frame update
    void Start()
    {
       Debug.Log(message:"START");
       TryGetComponent(out rb);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (!noChao && collision.gameObject.tag == "Chão")
        {
            noChao = true;
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        Debug.Log(message:"UPDATE");

    float h = Input.GetAxis("Horizontal"); // -1 esquerda,0 ou nada, 1 direita
    float v = Input.GetAxis("Vertical"); // -1 pra tras,  nada, 1 ´pra frente
  
   
    Vector3 direcao = new Vector3(x:h, y:0, z:v);
    rb.AddForce(direcao * velocidade * Time.deltaTime,ForceMode.Impulse);

    if (Input.GetKeyDown(KeyCode.Space) && noChao)
    {
        rb.AddForce(Vector3.up * forcaPulo, ForceMode.Impulse);
        noChao = false;
    }

    if(transform.position.y <= -10)
    {

    //jogador caiu
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    }
}
