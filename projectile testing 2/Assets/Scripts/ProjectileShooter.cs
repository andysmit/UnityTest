using UnityEngine;
using System.Collections;

public class ProjectileShooter : MonoBehaviour {
    GameObject prefab;
    PhysicMaterial ball;
   // ScriptableObject Cold;
    public int speed;
	// Use this for initialization
	void Start () {
        prefab = Resources.Load("projectile") as GameObject;
        ball = Resources.Load("ball") as PhysicMaterial;
        //Cold = load("ProjectileCol") as ScriptableObject;
        //print(prefab.name);
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetMouseButtonDown(0))
        {
            GameObject projectile = Instantiate(prefab) as GameObject;
            PhysicMaterial bullet = Instantiate(ball) as PhysicMaterial;
            projectile.transform.position = transform.position + Camera.main.transform.forward * 2;
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.velocity = Camera.main.transform.forward * speed;
            SphereCollider SP = projectile.GetComponent<SphereCollider>();
            SP.material = bullet;
            //print(SP.name);
            //OnTriggerEnter(SP);
            //if (projectile)
            Destroy(projectile,5);

        }
	}
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("EHH");
        //if (projectile)
        //print(col.collider.name);
    }
}
