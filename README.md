### Filezorg
Filezorg automatically makes a folder every week so you can organize your files. This is just a project that I made to help organize *my* files and wanted to publish it in case anyone could make use of it.

### Install and setup
### Step One: Clone this repository
mkdir filezorg
cd filezorg
git clone https://github.com/JuliusWon/Filezorg.git

### Step 2: Add to crontab
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
sudo systemctl enable cronie.service --now

This may be different for debian systems.


