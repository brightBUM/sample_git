using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    public List<GameObject> items;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Idamagable dmg;
            foreach(GameObject gs in items)
            {
                dmg = gs.GetComponent<Idamagable>();
                dmg.damage();
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        items.Add(other.gameObject);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        items.Remove(other.gameObject);
    }
}
