using Sandbox;
using Sandbox.UI;

namespace Ovo.UI
{
  [Library]
  public partial class OvoHUD : Hud
  {
    public OvoHUD()
    {
      if (!IsClient) return;

      RootPanel.StyleSheet.Load("/ui/Hud.scss");
      RootPanel.AddChild<ChatBox>();
    }
  }
}