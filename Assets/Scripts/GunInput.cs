using UnityEngine;
using static OVRInput;
public class GunInput : MonoBehaviour
{
    [SerializeField]
    Transform GunModel;
    [SerializeField]
    Transform GunBarrel;
    public float cooldownTime = 0.5f;
    [HideInInspector]
    public float timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //maybe a machine on the wall is the only way to reload the gun?
    [SerializeField]
    int ammoLeft = 17;
    [SerializeField]
    int MaxAmmo = 17;
  
    void Start()
    {
        Debug.Log("startin");
    }

    // Update is called once per frame
    void Update()
    {
        detectInputs();
    }

    void detectInputs()
    {
        if (timer >= cooldownTime)
        {
            if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
            {
                Debug.Log("Pew");

                //raycast out from gun barrel

            }
            /*
            if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger))
            {
                Debug.Log("Shoot");
            }*/
        }

        
        if (timer < cooldownTime)
            timer = Mathf.Min( cooldownTime + 5, timer + Time.deltaTime);
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.transform.CompareTag("Magazine"))
        {

        }
    }



    //idea - carry items and furniture to a different location to use them to block off certain spawner areas
    //the idea of junk collection
}
