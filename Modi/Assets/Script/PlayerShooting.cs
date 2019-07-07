using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public int damagePerShot = 60;
    public float timeBetweenBullets = 0.15f;
    public float range = 50.0f;

    public Transform shootPoint;

    float timer;
    Ray ShootRay = new Ray();
    RaycastHit shootHit;

    LineRenderer gunline;
    ParticleSystem gunParticles;
    Light gunLight;

    float effectsDisplayTime = 0.2f;

    DualJoystickPlayerController dualJoystickPlayerController;

    AudioSource audiosource;
    public AudioClip audioClip;

    private void Awake()
    {
        gunline = GetComponent<LineRenderer>();
        gunLight = GetComponent<Light>();
        dualJoystickPlayerController = GetComponentInParent<DualJoystickPlayerController>();
        gunParticles = GetComponentInChildren<ParticleSystem>();
        audiosource = GetComponent<AudioSource>();
        audiosource.clip = audioClip;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;


        if (dualJoystickPlayerController.leftJoystickInput == Vector3.zero && dualJoystickPlayerController.rightJoystickInput != Vector3.zero && timer >= timeBetweenBullets && Time.timeScale != 0)
        {
            Shoot();
            audiosource.Play();
        }
        if (dualJoystickPlayerController.leftJoystickInput != Vector3.zero && dualJoystickPlayerController.rightJoystickInput != Vector3.zero &&  timer >= timeBetweenBullets && Time.timeScale != 0)
        {
            Shoot();
            audiosource.PlayOneShot(audioClip);
        }

        if (timer >= timeBetweenBullets * effectsDisplayTime)
        {
            DisabeleEffects();
        }
    }

    public void DisabeleEffects()
    {
        gunline.enabled = false;
        gunLight.enabled = false;
    }

    void Shoot()
    {
        timer = 0f;
        gunline.enabled = true;
        gunline.SetPosition(0, transform.position);
        gunLight.enabled = true;

        gunParticles.Stop();
        gunParticles.Play();
       

        ShootRay.origin = shootPoint.transform.position;
        ShootRay.direction = shootPoint.transform.forward;

        Debug.DrawRay(ShootRay.origin,transform.forward,Color.red);

        if (Physics.Raycast(ShootRay, out shootHit, range))
           
        {
            EnemyHealth enemyHealth = shootHit.collider.GetComponent<EnemyHealth>();
            if(enemyHealth !=null)
            {
                enemyHealth.TakeDamage(damagePerShot, shootHit.point);

            }
            gunline.SetPosition(1, shootHit.point);
        }
        else
        {
            gunline.SetPosition(1,ShootRay.origin + ShootRay.direction  * range);
        }

        
    }
}
