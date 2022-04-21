Baidu Netdisk / Cloud app English translation files

It's far from perfect: the layout is screwy in places, and as the translations are from google, they are also somewhat screwy. 
But it's definitely functional.

Thanks to zeffy for his/her panyi.exe, which simplifies the process of inserting translations. Unfortunately zeffy's repo no longer exists, so I've posted panyi.exe and its instructions here. 

This fork is for the purpose of distributing updates for the panyi.ini and DuiStringTable.xml files. 

Instructions

 - download panyi.exe, panyi.ini and DuiStringTable.xml
 - copy panyi.exe and panyi.ini to \AppData\Roaming\baidu\BaiduNetdisk
 - run panyi.exe
 - copy DuiStringTable.xml to \AppData\Roaming\baidu\BaiduNetdisk\skin
 - open duiengineskin.zip
 - go to the xml directory
 - replace the DuiStringTable.xml file in the zip archive with the downloaded english version

Current as of Mar 4 2022

--------------------------------------
Instructions for panyi.exe from zeffy
--------------------------------------

Baidu Netdisk reads its strings from %AppData%\baidu\BaiduNetdisk\resource.db:StringTable.xml, a Compound File Binary Format stream.

panyi simply replaces these strings with their translated counterparts from panyi.ini.

Arguments
  -update	Downloads the latest panyi.ini from this repository. Your old copy will be backed up.
  -file [path]	Optional path to resource.db. If unspecified, panyi will use the registry to find resource.db.
  -lang [lang]	Optional language from panyi.ini that you want to translate to. Defaults to en.
  -x	Extracts StringTable.xml strings to your panyi.ini's cn section.
