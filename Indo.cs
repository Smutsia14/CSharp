
//Script para Movimentação do Player

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indo : MonoBehaviour
{
    //Movimentação
    public float Velocidade;
    public Animator anim;
    float InputX;
    float InputZ;
    Vector3 Direcao;
    void Start()
    {
        
    }

    
    void Update()
    {
        InputX = Input.GetAxis("Horizontal");
        InputZ = Input.GetAxis("Vertical");
        Direcao = new Vector3(InputX,0,InputZ);
        
        if(InputX != 0 || InputZ != 0)
        {
            transform.Translate(0,0,Velocidade * Time.deltaTime);
            anim.SetBool("Walk", true);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(Direcao), 5 * Time.deltaTime);
        }
        
        if (InputX == 0 && InputZ == 0)
        {
            anim.SetBool("Walk", false);
        }
        
        RunFaster();
    }
    void RunFaster()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("Run", true);
        }
        else
        {
            anim.SetBool("Run", false);
        }
    }
    
   
}
