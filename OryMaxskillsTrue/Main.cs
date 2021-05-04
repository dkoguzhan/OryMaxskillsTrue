using Rocket.API;
using Rocket.Core;
using Rocket.Core.Commands;
using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using SDG.Unturned;
using Steamworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace OryFullMaxskills
{
    public class Main : RocketPlugin
	{
		
		protected override void Load()
		{
			U.Events.OnBeforePlayerConnected += Connect;
			UnturnedPlayerEvents.OnPlayerRevive += Revive;
		}

		protected override void Unload()
		{
			U.Events.OnBeforePlayerConnected -= Connect;
			UnturnedPlayerEvents.OnPlayerRevive -= Revive;
		}

		public void Revive(UnturnedPlayer player, Vector3 position, byte angle)
		{
			player.Player.skills.ServerUnlockAllSkills();
		}

		public void Connect(UnturnedPlayer player)
        {
			player.Player.skills.ServerUnlockAllSkills();
			
		}
	}
}
