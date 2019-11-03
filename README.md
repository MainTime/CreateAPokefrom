# CreateAPokefrom

CAP is a little tool which lets you create your own set of Pok3froms for my game called Pok3from

## How to use

I.  When you open the program you are visited by a splash screen while the program is loading

![](https://raw.githubusercontent.com/MainTime/CreateAPokefrom/master/Images/splash.png)

II. When the program finished loading you will see the main menu, where all of your pokefroms are located

![](https://raw.githubusercontent.com/MainTime/CreateAPokefrom/master/Images/mm.png)

III. Already created Pokefroms will be displayed in the main menu

![](https://raw.githubusercontent.com/MainTime/CreateAPokefrom/master/Images/mmwithsamples.png)

## Create a pokefrom

I. Click on the Button "Create >"

![](https://raw.githubusercontent.com/MainTime/CreateAPokefrom/master/Images/mm.png)

II. Fill in all of the fields
Type can be:
- Fire
- Stone
- Electric
- All
- Water
    
![](https://raw.githubusercontent.com/MainTime/CreateAPokefrom/master/Images/create.png)

## Create a attack

I. Click on "Create attack >" below "Create >"

![](https://raw.githubusercontent.com/MainTime/CreateAPokefrom/master/Images/mm.png)

II. Fill in all of the fields *1

![](https://raw.githubusercontent.com/MainTime/CreateAPokefrom/master/Images/ba.png)

## Export your Pokefroms and Attacks

I. Press the "Export" button in the main menu

II. The json file will be generated in the folder 
```
../pfr_Data/out/(Date).pfrCollection
```

It has the structure of:
    
``` Json
[
  {
    "Name0": "asdfasdfasdfsadf",
    "Name1": "",
    "Name2": "",
    "Name3": "",
    "Level": 0,
    "Health": 0,
    "Attacks": [
      
    ],
    "Type0": 0,
    "Type1": 0,
    "Type2": 0,
    "Type3": 0,
    "LevelUp1": 0,
    "LevelUp2": 0,
    "LevelUp3": 0,
    "Gender": false,
    "ContinuousDamage": null,
    "Texture1": null,
    "Texture2": null,
    "Texture3": null,
    "Texture4": null,
    "CatchIndex": 0,
    "IsAlive": "False"
  },
  {
    "Name0": "asdfsa",
    "Name1": "",
    "Name2": "",
    "Name3": "",
    "Level": 0,
    "Health": 0,
    "Attacks": [
      {
        "Name": "Mud Slap",
        "Damage": 4,
        "IsContinuous": false,
        "Type": 4,
        "Level": 1
      }
    ],
    "Type0": 0,
    "Type1": 0,
    "Type2": 0,
    "Type3": 0,
    "LevelUp1": 0,
    "LevelUp2": 0,
    "LevelUp3": 0,
    "Gender": false,
    "ContinuousDamage": null,
    "Texture1": null,
    "Texture2": null,
    "Texture3": null,
    "Texture4": null,
    "CatchIndex": 0,
    "IsAlive": "False"
  },
  {
    "Name0": "sadf",
    "Name1": "",
    "Name2": "",
    "Name3": "",
    "Level": 0,
    "Health": 0,
    "Attacks": [
      {
        "Name": "Tackle",
        "Damage": 8,
        "IsContinuous": false,
        "Type": 5,
        "Level": 1
      }
    ],
    "Type0": 0,
    "Type1": 0,
    "Type2": 0,
    "Type3": 0,
    "LevelUp1": 0,
    "LevelUp2": 0,
    "LevelUp3": 0,
    "Gender": false,
    "ContinuousDamage": null,
    "Texture1": null,
    "Texture2": null,
    "Texture3": null,
    "Texture4": null,
    "CatchIndex": 0,
    "IsAlive": "False"
  }
]
```

### *1 

   Fairness is calculated by 
   ```
-  y1 = -1,9132x + 95,229
-  y2 = -1,621x + 105,76
-  y3 = -1,3204x + 109,46
-  y4 = -0,0001x3 + 0,0306x2 - 2,6924x + 99,697
(yn is DmgFairness and x is DMG)
```
```
y = (y1 + y2 + y3 + y4 + y(again for level wich is selected for the pokefrom) / 5 )
```

If IsContinous is true then  
```
Fairness = ( y + 75 ) / 2
```
If IsContinous is false then
```
Fairness = ( y + 100 ) / 2
```
If Fairness is above 100 Then the fairness will be 100
If Fairness is below 0 Then the fairness will be 0
