using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {
    public GameObject Laser;
    public GameObject my_player;
	private float Last_shoot_time;
	public float fire_cd;
	public int power_level;
    public float power_up_time;
	// Use this for initialization
	void Start () {
		Last_shoot_time = Time.time - fire_cd;
		power_level = 1;

    }
	
	// Update is called once per frame
	void Update () {
        my_player = GameObject.Find("player");
		if (power_level == 1)
			fire_cd = 0.8f;
		else if (power_level == 2) 
			fire_cd = 0.5f;
		else if (power_level >= 3)
			fire_cd = 0.3f;

        power_up_time -= 1 * Time.deltaTime;
        if (power_up_time < 0)
            power_level = 1;

    }

    public void fire_on()
    {
		if (my_player != null && Time.time > Last_shoot_time + fire_cd) {
            
			Last_shoot_time = Time.time;

            if (power_level == 1)
            {
                GameObject clone_bullet_1;
                clone_bullet_1 = Instantiate(Laser, my_player.transform.position + new Vector3(0, 0, 1f), my_player.transform.rotation);
            }

            if (power_level == 2)
            {
                GameObject clone_bullet_1;
                GameObject clone_bullet_2;
                GameObject clone_bullet_3;
                clone_bullet_1 = Instantiate(Laser, my_player.transform.position + new Vector3(0, 0, 1f), my_player.transform.rotation);
                clone_bullet_2 = Instantiate(Laser, my_player.transform.position + new Vector3(0, 0, 1f), Quaternion.Euler(new Vector3(0, my_player.transform.rotation.y - 30F, 0)));
                clone_bullet_3 = Instantiate(Laser, my_player.transform.position + new Vector3(0, 0, 1f), Quaternion.Euler(new Vector3(0, my_player.transform.rotation.y + 30F, 0)));
            }

            if (power_level == 3)
            {
                GameObject clone_bullet_1;
                GameObject clone_bullet_2;
                GameObject clone_bullet_3;
                GameObject clone_bullet_4;
                GameObject clone_bullet_5;
                clone_bullet_1 = Instantiate(Laser, my_player.transform.position + new Vector3(0, 0, 1f), my_player.transform.rotation);
                clone_bullet_2 = Instantiate(Laser, my_player.transform.position + new Vector3(0, 0, 1f), Quaternion.Euler(new Vector3(0, my_player.transform.rotation.y - 20F, 0)));
                clone_bullet_3 = Instantiate(Laser, my_player.transform.position + new Vector3(0, 0, 1f), Quaternion.Euler(new Vector3(0, my_player.transform.rotation.y + 20F, 0)));
                clone_bullet_4 = Instantiate(Laser, my_player.transform.position + new Vector3(0, 0, 1f), Quaternion.Euler(new Vector3(0, my_player.transform.rotation.y - 40F, 0)));
                clone_bullet_5 = Instantiate(Laser, my_player.transform.position + new Vector3(0, 0, 1f), Quaternion.Euler(new Vector3(0, my_player.transform.rotation.y + 40F, 0)));
            }

        }


    }
}
