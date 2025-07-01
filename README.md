
# Pool Pump Controller (In Development)
### IoT Project - SBC-Based Swimming Pool Pump Controller. <hr/>

This Project controls your swimming Pool Pump autonomously, via a Raspberry Pi SBC.

#### Features: <br/>
+ Check and Display Current Pool Temp + Change Colour.
+ Control Pool Pump Timing + Based on Weather Condition.
+ Display Current Weather Data from set Location.
+ Has Bypass Control.
+ Just Being Cool - This Project is Obviously an "Overkill of this type of project." xD
<hr/>

## How to Install: <br/>
### 1. Install and flash a Raspberry Pi 3, 4, 5 With at least 1GB Ram with Raspberry Pi OS 64bit. <br/> (Username : admin)

### 2. Clone Project on Development PC.
```
git clone https://github.com/TheSloppyCoder/PoolController.git
```

### 3. Build and Deploy / Publish Project in IDE [self-contained] [linux-arm64].

### 4. Copy over Published Project to Raspberry Pi /home/admin/Desktop.

### 5. Copy over Files in the "setup-files" Directory to:
1. run.sh => /home/admin/Desktop
2. PoolController.desktop => /home/.config/autostart/PoolController.desktop: <br/>
   mkdir -p ~/.config/autostart

### 6. Create an Account on OpenWeatherMap to get an API Key.

### 7. Create an txt file with only the API Key in it (apikey.txt). <br/>
1. Copy the apikey.txt file to the Root Directory of the Published App on the Raspberry Pi.

### 8. Make sure to make the PoolController file - executable.
```
chmod + x /home/admin/PoolController/PoolController
```
### 9. Reboot Raspberry Pi and Test auto start of the App.
```
sudo reboot
```


