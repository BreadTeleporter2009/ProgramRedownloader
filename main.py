from os import system
import requests
def clear():
    system("cls")
print("Welcome to program reinstaller version 0.1.")
print("Please select an option. \n (1) Install \n (2) Exit")
choice=input()
if choice==2:
    exit
elif choice==1:
    print("Downloading...")
    print("[----------]")
    try:
        url = 'https://dl.google.com/tag/s/appguid%3D%7B8A69D345-D564-463C-AFF1-A69D9E530F96%7D%26iid%3D%7BB706BA5E-1C60-8708-D514-B399302F0385%7D%26lang%3Den%26browser%3D4%26usagestats%3D1%26appname%3DGoogle%2520Chrome%26needsadmin%3Dprefers%26ap%3Dx64-stable-statsdef_1%26installdataindex%3Ddefaultbrowser/chrome/'
        r = requests.get(url, allow_redirects=True)
        open('chrome.exe', 'wb').write(r.content)
    except: 
        print("!ERROR! Unable to download Google Chrome.")
    clear()
    print("Downloading...")
    print("[█---------]")
    try:
        url = 'https://www.7-zip.org/a/7z2107.exe'
        r = requests.get(url, allow_redirects=True)
        open('7zip.exe', 'wb').write(r.content)
    except:
        print("!ERROR! Unable to download 7zip.")
    clear()
    print("Downloading...")
    print("[██--------]")

    clear()
    print("Downloads finished.")
    print("Installing programs...")
    print("[----------]")
    try:
        system("chrome.exe")
        print("Finished installing \"Google Chrome\"")
    except:
        print("!ERROR! Unable to install Google Chrome.")
    print("Installing programs...")
    print("[█----------]")
    try:
        system("7zip.exe")
        print("Finished installing \"7zip File Manager"")
    except:
        print("!ERROR! Unable to install 7zip")
