using UnityEngine;
using System.Collections;

public class Card : MonoBehaviour {
    public string cardName;
    public Sprite front;
    public Sprite back;
    bool flipCard; //for when you want to flip a card.
    public float rotationSmoothening;
    Quaternion target;
    SpriteRenderer spriteRenderer;
	
	void Start ()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        flipCard = false;
	}

    // Update is called once per frame
    void Update()
    {
        if (flipCard == true && spriteRenderer.sprite == front)    
        {
            //rotates 90 degrees
            target = Quaternion.Euler(gameObject.transform.rotation.x + 90, 0, 0);
            gameObject.transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * rotationSmoothening);
            //changes sprite
            spriteRenderer.sprite = back;
            //rotates 90 degrees
            target = Quaternion.Euler(gameObject.transform.rotation.x + 90, 0, 0);
            gameObject.transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * rotationSmoothening);
            flipCard = false;
        }
        else if(flipCard == true && spriteRenderer.sprite == back)
        {
            //same as above
            target = Quaternion.Euler(gameObject.transform.rotation.x + 90, 0, 0);
            gameObject.transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * rotationSmoothening);
            spriteRenderer.sprite = front;
            target = Quaternion.Euler(gameObject.transform.rotation.x + 90, 0, 0);
            gameObject.transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * rotationSmoothening);
            flipCard = false;
        }
	}
}
