using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystem : MonoBehaviour
{
    public GameObject particles;
    public GameObject particles2;
    public GameObject a;
    public GameObject b;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 position = this.gameObject.transform.position;
        a = Instantiate(particles, position, transform.rotation) as GameObject;
        b = Instantiate(particles2, position, transform.rotation) as GameObject;
        a.transform.Rotate(-90f, 0, 0, Space.Self);
        b.transform.Rotate(-90f, 0, 0, Space.Self);
        Rigidbody rb = a.GetComponent<Rigidbody>();
        Rigidbody rb2 = b.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void Awake()
    {
        StartCoroutine(DestroyParticles());
    }

    IEnumerator DestroyParticles()
    {
        yield return new WaitForSeconds(5f);
        Destroy(a.gameObject);
        Destroy(b.gameObject);
    }
}
