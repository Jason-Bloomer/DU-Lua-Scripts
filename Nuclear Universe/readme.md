# Nuclear Winter
Dual Universe Unavoidable Lag Trap
<b><u><i>Using this script to lag other players is against Novaquark's Terms of Service, and is likely to get you banned. Use of this script for anything other than testing purposes is heavily discouraged. I bear no responsibility for the results of using it.</b></u></i>
I decided to document this script because, as of the time of posting, Dual Universe has been released for over a year - and this script still, unfortunately, works quite well. I have made every attempt to notify NQ of the possibility of such scripts to impact players, however based on the fact they still work over a year later, it seems they are not  concerned enough to fix it. By making this publicly available, I hope to showcase just how trivial lagging players with Lua in DU truly is, in the hopes that NQ will eventually deem it necessary to fix.

## Unavoidability
Players are able to remotely shut down any programming boards or scripts they are running, by pressing CTRL + Backspace. This would effectively render our lagscript useless in most scenarios, in the event that this worked properly. However, it does not.
As of the time of posting, CTRL+BKSPC will only shut down ONE script at a time. Thus if we create multiple lag scripts which all reactivate each other every tick, we can prevent players from ever escaping our lag field, effectively trapping them until the system is disabled.
Logging out and back into the game world, will immediately reactivate the trap.

*** To properly combat this, all NQ would need to do is make it so CTRL+BKSPC terminates ALL running scripts, simultaneously. Simple, right?... ***

## Setup
There are two main components at play here:
<ul>
	<li>The Main Module, whose job is to constantly reactivate the Nuke Modules</li>
	<li>The Nuke Modules, whose job is to generate crippling lag</li>
</ul>

There are two Nuke Modules provided which cause lag by utilizing different methods. Load Recursion causes lag by recursively loading a string, which when loaded, causes itself to be loaded (into infinity). Timer Recursion causes lag by recursively creating timers and consuming exponential amounts of memory.

For more detailed information about the link structure and order, see the included diagram in this directory.
You can link up to ten (10) Nuke Modules to a single Main Module, though two is more than sufficient.
