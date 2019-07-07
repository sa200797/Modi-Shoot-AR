using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] GameObject deathparticles;

    private static int startingHealth = 100;
    public int currentHealth;

    public  int scoreValue = 2;

    ParticleSystem hitparticles;

    bool isDead;
    BoxCollider boxCollider;

   

    public AudioSource _audioSource;
    public AudioClip _audioclip;


    public void Awake()
    {
        boxCollider = GetComponent<BoxCollider>();
        hitparticles = GetComponentInChildren<ParticleSystem>();
        currentHealth = startingHealth;

        _audioSource = GetComponent<AudioSource>();
        _audioSource.clip = _audioclip;
       
    }
    // Start is called before the first frame update
    public void Start()
    {
       
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int amount,Vector3 hitPoint)
    {
        if(isDead)
        {
            return;
        }

        currentHealth -= amount;
        hitparticles.transform.position = hitPoint;
        hitparticles.Play();
        

        if(currentHealth <=0)
        {
            Death();
        }


    }

    public void Death()
    {
        isDead = true;
        boxCollider.isTrigger = true;
       
        ScoreManager.score += scoreValue;
        GameObject go = Instantiate(deathparticles) as GameObject;
        go.transform.position = transform.position;
        Destroy(gameObject,0.3f);

        _audioSource.Play();
    }
}
