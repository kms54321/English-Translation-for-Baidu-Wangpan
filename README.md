English Translation for Baidu Wangpan 百度网盘

Baidu offers 2TB of free storage, with some significant drawbacks. Downloads are slow, and the desktop client has no English version.

This repo provides a solution: English strings for the Baidu Windows desktop app. It's far from perfect, but still definitely functional. Instructions:

 - download and install Baidu Netdisk --> English guide: https://www.baiduinenglish.com/baiduyun-pan-baidu-cloud-wangpan-disk.html
 - download panyi.exe, panyi.ini and DuiStringTable.xml
 - copy panyi.exe and panyi.ini to \AppData\Roaming\baidu\BaiduNetdisk
 - run panyi.exe
 - copy DuiStringTable.xml to \AppData\Roaming\baidu\BaiduNetdisk\skin
 - open duiengineskin.zip
 - go to the xml directory
 - replace the DuiStringTable.xml file in the zip archive with the downloaded english version

Current as of Apr 21 2022

-------------------------------------------------

Thanks to zeffy for his/her/their panyi.exe, which simplifies the process of inserting translations. Unfortunately zeffy's repo no longer exists, so I've included panyi.exe above and the info from zeffy's repo below:

-------------------------------------------------
<article class="markdown-body entry-content container-lg" itemprop="text"><h2><a id="user-content-panyi" class="anchor" aria-hidden="true" href="#panyi"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M7.775 3.275a.75.75 0 001.06 1.06l1.25-1.25a2 2 0 112.83 2.83l-2.5 2.5a2 2 0 01-2.83 0 .75.75 0 00-1.06 1.06 3.5 3.5 0 004.95 0l2.5-2.5a3.5 3.5 0 00-4.95-4.95l-1.25 1.25zm-4.69 9.64a2 2 0 010-2.83l2.5-2.5a2 2 0 012.83 0 .75.75 0 001.06-1.06 3.5 3.5 0 00-4.95 0l-2.5 2.5a3.5 3.5 0 004.95 4.95l1.25-1.25a.75.75 0 00-1.06-1.06l-1.25 1.25a2 2 0 01-2.83 0z"></path></svg></a>panyi</h2>
<p>Translate <a href="https://pan.baidu.com/" rel="nofollow">Baidu Wangpan</a> (Netdisk) for Windows to other languages.</p>
<h3><a id="user-content-how-to-use" class="anchor" aria-hidden="true" href="#how-to-use"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M7.775 3.275a.75.75 0 001.06 1.06l1.25-1.25a2 2 0 112.83 2.83l-2.5 2.5a2 2 0 01-2.83 0 .75.75 0 00-1.06 1.06 3.5 3.5 0 004.95 0l2.5-2.5a3.5 3.5 0 00-4.95-4.95l-1.25 1.25zm-4.69 9.64a2 2 0 010-2.83l2.5-2.5a2 2 0 012.83 0 .75.75 0 001.06-1.06 3.5 3.5 0 00-4.95 0l-2.5 2.5a3.5 3.5 0 004.95 4.95l1.25-1.25a.75.75 0 00-1.06-1.06l-1.25 1.25a2 2 0 01-2.83 0z"></path></svg></a>How to use</h3>
<p>If you simply want to translate Baidu Netdisk to English, just download and run
<code>panyi.exe</code>.</p>
<p>Otherwise, refer to the <strong>Arguments</strong> section below.</p>
<h3><a id="user-content-how-it-works" class="anchor" aria-hidden="true" href="#how-it-works"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M7.775 3.275a.75.75 0 001.06 1.06l1.25-1.25a2 2 0 112.83 2.83l-2.5 2.5a2 2 0 01-2.83 0 .75.75 0 00-1.06 1.06 3.5 3.5 0 004.95 0l2.5-2.5a3.5 3.5 0 00-4.95-4.95l-1.25 1.25zm-4.69 9.64a2 2 0 010-2.83l2.5-2.5a2 2 0 012.83 0 .75.75 0 001.06-1.06 3.5 3.5 0 00-4.95 0l-2.5 2.5a3.5 3.5 0 004.95 4.95l1.25-1.25a.75.75 0 00-1.06-1.06l-1.25 1.25a2 2 0 01-2.83 0z"></path></svg></a>How it works</h3>
<p>Baidu Netdisk reads its strings from
<code>%AppData%\baidu\BaiduNetdisk\resource.db:StringTable.xml</code>, a Compound File
Binary Format stream.</p>
<p>panyi simply replaces these strings with their translated counterparts from
<code>panyi.ini</code>.</p>
<h3><a id="user-content-arguments" class="anchor" aria-hidden="true" href="#arguments"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M7.775 3.275a.75.75 0 001.06 1.06l1.25-1.25a2 2 0 112.83 2.83l-2.5 2.5a2 2 0 01-2.83 0 .75.75 0 00-1.06 1.06 3.5 3.5 0 004.95 0l2.5-2.5a3.5 3.5 0 00-4.95-4.95l-1.25 1.25zm-4.69 9.64a2 2 0 010-2.83l2.5-2.5a2 2 0 012.83 0 .75.75 0 001.06-1.06 3.5 3.5 0 00-4.95 0l-2.5 2.5a3.5 3.5 0 004.95 4.95l1.25-1.25a.75.75 0 00-1.06-1.06l-1.25 1.25a2 2 0 01-2.83 0z"></path></svg></a>Arguments</h3>
<table>
<thead>
<tr>
<th>Argument</th>
<th>Description</th>
</tr>
</thead>
<tbody>
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
<h3><a id="user-content-contributing" class="anchor" aria-hidden="true" href="#contributing"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M7.775 3.275a.75.75 0 001.06 1.06l1.25-1.25a2 2 0 112.83 2.83l-2.5 2.5a2 2 0 01-2.83 0 .75.75 0 00-1.06 1.06 3.5 3.5 0 004.95 0l2.5-2.5a3.5 3.5 0 00-4.95-4.95l-1.25 1.25zm-4.69 9.64a2 2 0 010-2.83l2.5-2.5a2 2 0 012.83 0 .75.75 0 001.06-1.06 3.5 3.5 0 00-4.95 0l-2.5 2.5a3.5 3.5 0 004.95 4.95l1.25-1.25a.75.75 0 00-1.06-1.06l-1.25 1.25a2 2 0 01-2.83 0z"></path></svg></a>Contributing</h3>
<p>Pull requests with translation improvements or new languages are welcome!</p>
<p>Just fork this repository and commit your changes to <code>panyi.ini</code>, then submit a
pull request.</p>
<h3><a id="user-content-acknowledgements" class="anchor" aria-hidden="true" href="#acknowledgements"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M7.775 3.275a.75.75 0 001.06 1.06l1.25-1.25a2 2 0 112.83 2.83l-2.5 2.5a2 2 0 01-2.83 0 .75.75 0 00-1.06 1.06 3.5 3.5 0 004.95 0l2.5-2.5a3.5 3.5 0 00-4.95-4.95l-1.25 1.25zm-4.69 9.64a2 2 0 010-2.83l2.5-2.5a2 2 0 012.83 0 .75.75 0 001.06-1.06 3.5 3.5 0 00-4.95 0l-2.5 2.5a3.5 3.5 0 004.95 4.95l1.25-1.25a.75.75 0 00-1.06-1.06l-1.25 1.25a2 2 0 01-2.83 0z"></path></svg></a>Acknowledgements</h3>
<table>
<thead>
<tr>
<th>Project</th>
<th>Version</th>
<th>Copyright</th>
<th>License</th>
</tr>
</thead>
<tbody>
<tr>
<td><a href="https://github.com/ironfede/openmcdf"><strong>OpenMcdf</strong></a></td>
<td>2.1</td>
<td>Copyright © 2010-2018, Federico Blaseotto</td>
<td><a href="https://github.com/ironfede/openmcdf/blob/master/License.txt">MPL-2.0</a></td>
</tr>
</tbody>
</table>
</article>

