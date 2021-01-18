using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : Skill
{
  private GameObject Prefab;

  public Missile()
  {
      Prefab = (GameObject) Resources.Load("Missile");
      behaviour = new SummonBehaviour(Prefab);
  }
}
