using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movetonextlevel : MonoBehaviour {
 public void ChangeScene(string sceneName)
 {
  Application.LoadLevel(sceneName);
 }
}