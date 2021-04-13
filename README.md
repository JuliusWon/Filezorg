### Filezorg
Filezorg automatically makes a folder every week so you can organize your files. This is just a project that I made to help organize *my* files and wanted to publish it in case anyone could make use of it.
test
### Install and setup
### Clone this repository
```bash
mkdir filezorg
cd filezorg
git clone https://github.com/JuliusWon/Filezorg.git
```
### Add to crontab
To make the folder crontab must run this app on a set time. To do this:
install crontab. This varies by distrobution.

For arch based distros:
```bash
sudo pacman -S cronie
```
For debian based distros:
```bash
sudo apt install cron
```
### Enable Crontab

enable cronie for arch:

```bash 
sudo systemctl enable cronie.service --now
```

This may be different for debian systems.

### Get Env Variables

```bash
echo "$SHELL | $PATH | $DISPLAY | $DESKTOP_SESSION | $DBUS_SESSION_BUS_ADDRESS | $XDG_RUNTIME_DIR"
```

### Set crontab

```bash
export EDITOR=vim
crontab -e
#replace values with the ones found in previous step
0 * * * * env PATH=/usr/local/bin:/usr/bin DISPLAY=:0 DESKTOP_SESSION=Openbox DBUS_SESSION_BUS_ADDRESS="unix:path=/run/user/1000/bus" ./~/filezorg/filezorg.sh
```
