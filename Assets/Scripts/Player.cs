using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    Animator animator;
    private NavMeshAgent nmeshagent;
    private float dist;
    GameObject go;
    
    
    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
        nmeshagent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        dist= nmeshagent.remainingDistance;
        if(Input.GetMouseButtonDown(0))
        {
            animator.SetBool("Walk",true);
        }
        else if(dist!=Mathf.Infinity && nmeshagent.pathStatus==NavMeshPathStatus.PathComplete && nmeshagent.remainingDistance==0) {
            animator.SetBool("Walk",false);
        }
    }
}
