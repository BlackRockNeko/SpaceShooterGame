using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_collision : MonoBehaviour {
    public GameObject boom_sound;
    public GameObject boom_obj;
    public int player_life;
    public RawImage player_life_display;
    public Texture2D[] player_life_tex;

    // Use this for initialization
    void Start () {
        player_life = 3;
        player_life_display.texture = player_life_tex[player_life];
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision info)
    {
       if (info.gameObject.tag=="npc_laser")
        {
            Instantiate(boom_obj, transform.position, transform.rotation);
            Instantiate(boom_sound, transform.position, transform.rotation);
            Destroy(this.gameObject);
            Destroy(info.gameObject);
            player_life--;
            player_life_display.texture = player_life_tex[player_life];
            if (player_life > 0) swap_player(); 
        }
    }

    void swap_player ()
    {


    }
}
