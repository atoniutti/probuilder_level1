using UnityEngine;
using UnityEngine.UI;

public class CharacterInteraction : MonoBehaviour {

    public GameObject tpGoal;
    public Text flouzText;

    public int flouz;

	// Use this for initialization
	void Start ()
    {
        flouz = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Portal")
        {
            gameObject.transform.position = tpGoal.transform.position;
        }
        else if (col.gameObject.tag == "gold")
        {
            flouz++;
            Destroy(col.gameObject);
            flouzText.text = flouz.ToString();
        }
    }

}
