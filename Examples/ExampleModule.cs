namespace SoundAPI
{
    public class ExampleModule : ETGModule
    {
        public override void Init()
        {
            //inits soundapi. you can do this in start() but doing it in init() is better and less likely to cause issues.
            SoundManager.Init();
        }

        public override void Start()
        {
            //adds a new switch to the "WPN_Guns" switch group called "Example" that replaces the "Play_WPN_Gun_Shot_01" event with jk47's shoot sound and  the "Play_WPN_gun_reload_01" event with the "Play_WPN_kthulu_blast_01" sound.
            SoundManager.AddCustomSwitchData("WPN_Guns", "Example", "Play_WPN_Gun_Shot_01", new SwitchedEvent("Play_WPN_Gun_Shot_01", "WPN_Guns", "jk47"));
            SoundManager.AddCustomSwitchData("WPN_Guns", "Example", "Play_WPN_gun_reload_01", "Play_WPN_kthulu_blast_01");
            //makes magnum use the "example" switch
            Gungeon.Game.Items["magnum"].GetComponent<Gun>().gunSwitchGroup = "Example";

            //modifies the already existing switch of gamma ray to instead play face melter's sounds. also makes it play advanced dragun's roar when starting the loop and an explosion sound when ending the loop.
            SoundManager.AddCustomSwitchData("WPN_Guns", "RadiationLaser", "Play_WPN_Gun_Shot_01", new SwitchedEvent("Play_WPN_Gun_Shot_01", "WPN_Guns", "Guitar"), "Play_BOSS_DragunGold_Roar_01");
            SoundManager.AddCustomSwitchData("WPN_Guns", "RadiationLaser", "Stop_WPN_Gun_Loop_01", new SwitchedEvent("Stop_WPN_Gun_Loop_01", "WPN_Guns", "Guitar"), "Play_WPN_grenade_blast_01");

            //modifies the already existing switch of heroine to instead play the lockpick sound on the first charge stage, the gun throw sound on the second, the "kthulu blast" sound on third and the "chest" sound on the fourth.
            SoundManager.AddCustomSwitchData("WPN_Guns", "BountyHunterArm", "Play_WPN_Gun_Charge_01", "Play_OBJ_lock_pick_01");
            SoundManager.AddCustomSwitchData("WPN_Guns", "BountyHunterArm", "Play_WPN_Gun_Charge_02", "Play_OBJ_item_throw_01");
            SoundManager.AddCustomSwitchData("WPN_Guns", "BountyHunterArm", "Play_WPN_Gun_Charge_03", "Play_WPN_kthulu_blast_01");
            SoundManager.AddCustomSwitchData("WPN_Guns", "BountyHunterArm", "Play_WPN_Gun_Charge_04", "Play_WPN_LowerCaseR_Chest_Chest_01");
        }

        public override void Exit()
        {
        }
    }
}
