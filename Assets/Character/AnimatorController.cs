﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class AnimatorController : MonoBehaviour {
    
     public Animator animator;
     public NavMeshAgent nav;
    
    // Use this for initialization
    void Start () {
       animator = GetComponent<Animator>();
    }
    
    // Update is called once per frame
    void Update () {
        bool walk = Input.GetButtonDown("Fire1");
        bool turn = Input.GetButtonDown("Fire1");
        if(nav.angularSpeed>1){
            //Debug.Log(nav.angularSpeed);
            walk=false;
            //turn=true;            
        }
        if(nav.remainingDistance>0.5){
            //Debug.Log("massss");
            walk=true;
            //turn=false;
        }
            animator.SetBool("walk", walk);
            animator.SetBool("turn", turn);
    }

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.CompareTag("Enemy"))
        {
            animator.SetTrigger("Die");
        }
    }
}