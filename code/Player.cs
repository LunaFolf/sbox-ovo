using Sandbox;
using System;

namespace Ovo
{
  partial class OvoPlayer : BasePlayer
  {
    public OvoPlayer()
    {
      Log.Info("OvO Player");
    }

    public override void Respawn()
    {
      SetModel("models/citizen/citizen.vmdl");
      Controller = new WalkController();
      Animator = new StandardPlayerAnimator();
      Camera = new FirstPersonCamera();
      EnableAllCollisions = true;
      EnableDrawing = true;
      EnableHideInFirstPerson = true;
      EnableShadowInFirstPerson = true;
      base.Respawn();
    }
  }
}