using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {

	void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag =="Enemy" || collision.gameObject.tag == "Clickable") collision.gameObject.GetComponent<PlayerUnit>().reduceHealth(1);
        Destroy(gameObject);
    }
}
