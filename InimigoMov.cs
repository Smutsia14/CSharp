
//Scrip Usado para criação de movimentação para um inimigo com NavMeshAgent

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class InimigoMov : MonoBehaviour
{
    //Movimentação Enemy
    public Transform playerTransform;
    public NavMeshAgent nav;
    float distanciaAtual;
    
    
    //Ataque
    SphereCollider areaAtk;
    //bool atacando = false;
    public float distanciaAtk = 2f;
    float distanciaAtaque;
    
    public Animator anim;

    void Start()
    {
        
        anim = GetComponent<Animator>();
        
        
        nav = GetComponent <NavMeshAgent>();
        nav.SetDestination (playerTransform.position);
    }

    // Update is called once per frame
    void Update()
    {   
        distanciaAtual = Vector3.Distance (transform.position, playerTransform.transform.position);
        nav.SetDestination (playerTransform.position);
        
        
        if (distanciaAtual <= distanciaAtk )
        {
        anim.SetBool("atk", true);
        }
        else{
        anim.SetBool("atk", false);
        }
        
    }
}
