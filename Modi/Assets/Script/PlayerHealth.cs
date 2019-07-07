using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public Image Health;


    public Transform particleeffect;
    public int currentHealth;
    private static int StartingHealth =100;

    public Image damageImage;
    public float flashSpeed = 5f;
    public Color flashcolor = new Color(1f, 0f, 0f, 0.01f);


    public AudioClip audioClip;
    public AudioSource audioSource;


    bool isDead;
    bool damaged;

    public GameObject gameover_ui;

    [SerializeField] GameObject hitParticleSystem;

    DualJoystickPlayerController dualJoystickPlayerController; //For Player Movement Refrence;
    PlayerShooting playershooting; // For Player Shooting reference;


    private void Awake()
    {
        dualJoystickPlayerController = GetComponent<DualJoystickPlayerController>();
        playershooting = GetComponentInChildren<PlayerShooting>();
        
        currentHealth = StartingHealth;

        audioSource = GetComponent<AudioSource>();



        }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(damaged)
        {
            damageImage.color = flashcolor;
            GameObject ph = Instantiate(hitParticleSystem) as GameObject;
            ph.transform.position = particleeffect.transform.position;
                
           


        }
        else
        {
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);

        }

        damaged = false;

    }

    public void TakeDamage(int amount)
    {
        damaged = true;
        currentHealth -= amount;
        float healthbar = (float)currentHealth / (float)StartingHealth;
        SetHealth(healthbar);
        audioSource.Play();
       

        if(currentHealth <=0 && !isDead)
        {
            Death();

        }
    }

    public void Death()
    {
        isDead = true;
        playershooting.DisabeleEffects();
      //  Debug.Log("Player Dead");
        playershooting.enabled = false;
        dualJoystickPlayerController.enabled = false;
        gameover_ui.SetActive(true);

        audioSource.clip = audioClip;
        audioSource.PlayOneShot(audioClip);
            
    }


    void SetHealth(float myHealth)
    {
        Health.fillAmount = (float)myHealth ;
    }
}
