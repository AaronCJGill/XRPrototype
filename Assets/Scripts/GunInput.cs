using UnityEngine;
using OVR.Input;
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
    int ammoLeft;
    [SerializeField]
    int MaxAmmo;

    void Start()
    {
        
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
            if (OVRInput.GetDown(OVRInput.Button.Back))
            {
                Debug.Log("Pew");
            }
        }

        if(timer < cooldownTime)
            timer = Mathf.Min( cooldownTime + 5, timer + Time.deltaTime);
        
    }

    private void OnCollisionStay(Collision collision)
    {
        //check to see if we are colliding with theplayer's controllers. 
        //try not to 
    }

}
