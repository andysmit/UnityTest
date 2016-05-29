using UnityEngine;
using System.Collections;

public class CannonShooter : MonoBehaviour
{
    GameObject prefab;
    public int power;
    
    // Use this for initialization
    void Start()
    {
        prefab = Resources.Load("projectile") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Random.Range(1,1000) == 42)
        {
            GetComponent<AudioSource>().Play();
            GameObject projectile = Instantiate(prefab) as GameObject;
            projectile.transform.position = transform.position;
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.velocity = transform.TransformDirection(new Vector3(0,0,-1)) * power;
            Destroy(projectile, 5);
        }
    }
}