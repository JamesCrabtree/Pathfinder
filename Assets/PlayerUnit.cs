using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlayerUnit : MonoBehaviour {
    public int health;
    public float range;
    public GameObject Bullet;
    public Transform spawn;
    private GameObject bullet;
    private float timer = 0;
    private float wait = 1;

    AudioSource myAudio;

    private void Start()
    {
        myAudio = GetComponent<AudioSource>();
    }

    public void attack()
    {
        timer += Time.deltaTime;
        if (timer > wait)
        {
            if(bullet)
                Destroy(bullet);
            bullet = Instantiate(Bullet, spawn.position, transform.rotation);
            bullet.GetComponent<Rigidbody>().velocity = (bullet.transform.forward * 75);
            myAudio.Play();
            timer = 0.0f;
        }
    }

    public void reduceHealth(int val)
    {
        health -= val;
        if (gameObject && health <= 0)
            die();
    }

    private void die()
    {
        Destroy(gameObject);
    }
}
