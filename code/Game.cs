using Sandbox;
using Ovo.UI;

namespace Ovo
{
  [Library("ovo", Title = "OvO")]
  partial class OvoGame : Game
  {
    public OvoGame()
    {
      Log.Info("Game Started");
      if (IsServer)
        new OvoHUD();
    }

    public override Player CreatePLayer() => new OvoPlayer();
  }
}