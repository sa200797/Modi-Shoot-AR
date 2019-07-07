using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour {

   
    public Animator anim;
    bool pursuing = false;

    public float AttakDistance;
    public float followingDistance;

    public Transform playerposition;

    public GameObject player;

    PlayerHealth playerHealth;
     EnemyHealth enemyHealth;


    bool playerInRange;
    float timer;

    public float TimeBetweenAttacks = 5.0f;
    public int attackDamage = 10;


    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerposition = GameObject.FindGameObjectWithTag("Player").transform;
        playerHealth = player.GetComponent<PlayerHealth>();
        enemyHealth = GetComponent<EnemyHealth>();


   
        anim = GetComponent<Animator>();
    }

    // Use this for initialization
    void Start()
    {
      
    }

    // Update is called once per frame
    public void Update()
    {
        timer += Time.deltaTime;


        Vector3 direction = playerposition.position - this.transform.position;
        direction.y = 0;

        float angle = Vector3.Angle(direction, playerposition.up);

        if (Vector3.Distance(playerposition.position, this.transform.position) < followingDistance)
        {

            pursuing = true;
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
                                        Quaternion.LookRotation(direction), 0.1f);

            anim.SetBool("isIdle", false);
            if ( direction.magnitude > AttakDistance )
            {
                this.transform.Translate(0, 0, 0.05f);
                anim.SetBool("isWalking", true);
                anim.SetBool("isAttacking", false);
            }

           else 
            {
               
                anim.SetBool("isWalking", false);

                if(timer >= TimeBetweenAttacks && enemyHealth.currentHealth > 0)
                {
                    Attack();
                }
                
            }
           

        }
        else
        {
            anim.SetBool("isIdle", true);
            anim.SetBool("isWalking", false);
            anim.SetBool("isAttacking", false);
            pursuing = false;
            playerInRange = false;
        }
        
    }

    //Enemy Attack

    void Attack()
    {
        timer = 0f;

        if (playerHealth.currentHealth > 0)
        {
            anim.SetBool("isAttacking", true);
            playerHealth.TakeDamage(attackDamage);
            //Debug.Log(playerHealth.currentHealth);

        }
    }
    
    

}
