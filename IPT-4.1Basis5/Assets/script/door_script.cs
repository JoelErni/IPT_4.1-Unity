using UnityEngine;
using System.Collections;

public class door_script : MonoBehaviour
{
  private Animator anim;
  public AudioClip door_open;
  public AudioClip door_close;
  private AudioSource audiosource;
  private bool door;

  private void Start()
  {
    anim = GetComponent<Animator>();
    audiosource = GetComponent<AudioSource>();
  }
  void FixedUpdate()
  {
    if (Vector3.Distance(transform.position, GameObject.Find("Player").transform.position)<7.5f) // wenn der Abstand zwischen Spieler und T�re unter 7.5 ist...
    {
      anim.SetBool("BTN 1", true); // Spielt animation ab, damit T�re sich �ffnet
    }
    else
    {
      anim.SetBool("BTN 1", false); // Spielt animation ab, damit T�re sich schliesst
    }
  }

  void close_sound()
  {
    /*
     * Spielt einen Sound ab w�hrend sich die T�re schliesst
     */
    audiosource.clip = door_close;
    audiosource.Play();

  }
  void open_sound()
  {
    /*
     * Spielt einen Sound ab w�hrend sich die T�re �ffnet
     */

    audiosource.clip = door_open;
    audiosource.Play();
  }

}
