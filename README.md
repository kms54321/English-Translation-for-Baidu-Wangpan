## panfanyi

Translate Baidu Netdisk (Wangpan) for Windows to other languages.

### How to use

If you simply want to translate Baidu Netdisk to English, just download and run
`panfanyi.exe`. 

Otherwise, refer to the **Arguments** section below.

### How it works

panfanyi uses the collection of translationed strings in `fanyi.ini` to replace
the string resources used by Baidu Netdisk.

Baidu Netdisk reads its strings from `StringTable.xml`, a file stored inside
`%AppData%\baidu\BaiduNetdisk\resource.db`, which is a Compound File Binary
Format file.

panfanyi replaces the strings in `StringTable.xml` with their translated
counterparts in `fanyi.ini`.

### Contributing

Pull requests with translation improvements or new languages are welcome!

Just fork this repository and commit your changes to `fanyi.ini`, then submit a
pull request.

### Arguments

Argument       | Description
-------------- | -------------------------------------------------------------------------------------------------------------------------
`-update`      | Updates to the latest `fanyi.ini` from this repository. Your old copy will be backed up.
`-file [path]` | Optional path to `resource.db`. If unspecified, panfanyi will use the registry to find `resource.db`.
`-lang [lang]` | Optional language from `fanyi.ini` that you want to translate to. Defaults to `en`.
`-x`           | Extracts the current string table in `StringTable.xml` to your `fanyi.ini` under the `cn` section.

### Acknowledgements

Project          | Version | Copyright                                 | License
---------------- | ------- | ------------------------------------------| ----------------------------
[**OpenMcdf**]   | 2.1     | Copyright © 2010-2018, Federico Blaseotto | [MPL-2.0][openmcdf-license]

[pan]: https://pan.baidu.com/
[**OpenMcdf**]: https://github.com/ironfede/openmcdf
[openmcdf-license]: https://github.com/ironfede/openmcdf/blob/master/License.txt
