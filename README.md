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

---------------------------------------
 Instructions for panyi.exe from zeffy
---------------------------------------
<table>
<thead>
<tr>
<th>Argument</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr>
<td><code>-update</code></td>
<td>Downloads the latest <code>panyi.ini</code> from this repository. Your old copy will be backed up.</td>
</tr>
<tr>
<td><code>-file [path]</code></td>
<td>Optional path to <code>resource.db</code>. If unspecified, panyi will use the registry to find <code>resource.db</code>.</td>
</tr>
<tr>
<td><code>-lang [lang]</code></td>
<td>Optional language from <code>panyi.ini</code> that you want to translate to. Defaults to <code>en</code>.</td>
</tr>
<tr>
<td><code>-x</code></td>
<td>Extracts <code>StringTable.xml</code> strings to your <code>panyi.ini</code>'s <code>cn</code> section.</td>
</tr>
</tbody>
</table>
