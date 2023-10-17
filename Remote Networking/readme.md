# Remote Networking Script

This script allows remote, two-way communication between two programming boards running the same script, which are not physically linked. They do not need to be on the same construct, but the recievers/emitters do need to be loaded and within rendering range when attempting to connect.
This script is entirely unfinished and unpolished. It does occasionally have some hiccups, and is by no means perfect. If anything bugs out, I recommend resetting the Programming Board and Screen, then try again.

## Usage

When setting up the system, you will likely want to edit some of the default values of the variables in the onStart() filter.
<b>DeviceTag</b> contains the name of the current machine you are setting up - this name will be seen and displayed by other machines that attempt to connect to it. Having multiple machines with the same DeviceTag in close proximity causes issues, make sure this is unique to each machine.
<b>SeekTag</b> can be given the name of another machine, to which this machine should attempt to connect with automatically upon startup. Used in combination with the WhitelistOnly variable.

To connect to a remote machine, simply activate the Programming Board, and press the "SCAN LOCAL" button to retrieve a list of the DeviceTag of all nearby machines which are also running this script.
Click the name of the machine you wish to connect to. A message should show, stating the connection was successful.

Click "TERMINATE" to disconnect from the remote machine.
"DATA READ" will use the contents of Buffer-1 to attempt to read a databank key with that name from the remote machine. Result is returned to Buffer-2.
"DATA WRITE" will attempt to write a databank key to the remote machine, using Buffer-1 as the key name, and Buffer-2 as the value. (Currently broken, works with some slight tweaks)

Read Key, Save Key, and Clear Keys are local (non-remote) operations which modify the databank contents on the current machine.

Verify Keys is an example function which showcases one method of making a function call to the remote machine, and returning the result.

## Setup

Requires at least 1x Screen (any size), 1x Programming Board, 2x Recievers, 2x Emitters, 1x Manual Switch, and 1x Databank.
For detailed link order and direction, see the included diagram in this directory.