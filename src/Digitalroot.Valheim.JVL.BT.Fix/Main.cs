using BepInEx;
using JetBrains.Annotations;
using Jotunn.Managers;

namespace Digitalroot.Valheim.JotunnBetterTraderFix
{
  [BepInPlugin(Guid, Name, Version)]
  [BepInDependency(Jotunn.Main.ModGuid)]
  [BepInDependency(BetterTrader.BetterTrader.GUID)]
  public class Main : BaseUnityPlugin
  {
    public const string Version = "1.0.4";
    public const string Name = "Digitalroot Jotunn BetterTrader Fix";
    public const string Guid = "digitalroot.mods.jotunnbettertraderfix";
    public const string Namespace = "Digitalroot.Valheim.JotunnBetterTraderFix";

    [UsedImplicitly]
    public void Awake()
    {
      ItemManager.OnItemsRegistered += Fix;
      ItemManager.OnItemsRegisteredFejd += Fix;
    }

    private void Fix()
    {
      BetterTrader.ObjectDB_Patches.RegisterObjectDBItems(ObjectDB.instance.m_items);
    }
  }
}
