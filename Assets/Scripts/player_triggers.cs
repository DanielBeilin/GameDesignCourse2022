using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class player_triggers : MonoBehaviour
{
    private int _capturedGhosts = 0;
    private int _coinsCollectd = 0;
    private bool _blueZone = false;
    private bool _redZone = false;
    public bool isObjectiveComplete = false;
    private int player_hitpoints = 3;
    private int platforms = 0;
    private bool hasSpell = false;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        player_hitpoints = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getCoinsCollected()
    {
        return _coinsCollectd;
    }

    public void collectCoin()
    {
        _coinsCollectd++;
        GameObject.Find("coin_amount").GetComponent<Text>().text = _coinsCollectd + " / 5";

    }
    public int getCapturedGhosts()
    {
        return _capturedGhosts;
    }

    public void captureGhost()
    {
        _capturedGhosts++;
        GameObject.Find("ghosts_amount").GetComponent<Text>().text = _capturedGhosts + " / 3";

    }

    public void interactBlueZone()
    {
        _blueZone = true;
        GameObject.Find("blue_zone_visited").GetComponent<Text>().text = _blueZone.ToString();
    }

    public void interactRedZone() 
    {
        _redZone = true;
        GameObject.Find("red_zone_visited").GetComponent<Text>().text = _redZone.ToString();

    }

    public void getSpell()
    {
        hasSpell = true;
    }

    public bool returnSpell(){return hasSpell;}

    public bool objectiveComplete()
    {
        Debug.Log(_blueZone);
        Debug.Log(_redZone);
        Debug.Log(_capturedGhosts);
        Debug.Log(_coinsCollectd);
        if (_blueZone && _redZone && _coinsCollectd == 5 && _capturedGhosts == 3)
        {
            isObjectiveComplete= true;
            return true;
        }
        else return false;
    }

    public void get_hit()
    {
        Debug.Log("got hit");
        Debug.Log(player_hitpoints);
        player_hitpoints--;
        GameObject.Find("player_hits").GetComponent<Text>().text = player_hitpoints + " / 3";
        if (player_hitpoints == 0)
        {
            SceneManager.LoadScene("Scenes/LoseScreen");
        }
    }

    public void step_on_platform()
    {
        platforms++; 
        GameObject.Find("platforms_pressed").GetComponent<Text>().text = platforms + " / 4";
        if (platforms == 4)
        {
            SceneManager.LoadScene("Scenes/boss");
        }
    }

}
