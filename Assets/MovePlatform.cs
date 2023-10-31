using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    public GameObject Rock;
    public bool hello = true;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)&&transform.position.x >= -10)
        {
            transform.Translate(Vector3.left * Time.deltaTime * 50);
        }
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.z >= 3)
        {
            transform.Translate(Vector3.back * Time.deltaTime * 50);
        }
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.z <= 30)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 50);
        }
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x <= 10)
        {
            transform.Translate(Vector3.right * Time.deltaTime * 50);
        }
    }

    void Awake()
    {
        StartCoroutine(CreateRocK());
    }

    IEnumerator CreateRocK()
    {
        while (hello)
        {
            yield return new WaitForSeconds(2.5f);
            Vector3 position = new Vector3(Random.Range(-10.0F, 10.0F), 30, Random.Range(3.0F, 30.0F));
            GameObject a = Instantiate(Rock, position, transform.rotation) as GameObject;
            a.transform.Rotate(90,0,0);
            Rigidbody rb = a.GetComponent<Rigidbody>();
        }
    }
}
