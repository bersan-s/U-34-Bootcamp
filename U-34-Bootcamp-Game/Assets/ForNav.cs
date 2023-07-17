using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;




public class ForNav : MonoBehaviour
{
    NavMeshAgent agent;

    [SerializeField]
    GameObject target;

    [SerializeField]
    GameObject spawn;

    int enemyH = 3;

   

    Animator anim;
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        
            
    }

   
    void Update()
    {
        agent.SetDestination(target.transform.position);
        anim.SetBool("isRunning",true);

        if (enemyH== 0) 
        { 
            transform.position = spawn.transform.position;

            GameObject.FindGameObjectWithTag("Player").GetComponent<ForScore>().scoreE++;
            enemyH= 3;
        }
    }

   

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Dirt"))
        {
            Debug.Log("kursunnnnnnnnnnnnnnnnnnn");
            enemyH -= 1;
        }
    }


}
