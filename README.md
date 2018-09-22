## panfanyi

Translate Baidu Netdisk (Wangpan) for Windows to other languages.

### How it works

panfanyi uses `fanyi.ini` which is a collection of translations in different
languages for the string table resources used by the Baidu Netdisk application.

Baidu Netdisk uses a string table located in `StringTable.xml`, which is stored
inside `%AppData%\baidu\BaiduNetdisk\resource.db`, a Compound File Binary
Format file.

panfanyi replaces the strings in `StringTable.xml` with their respective
translations in `fanyi.ini`.

### Arguments

Argument       | Description
-------------- | -------------------------------------------------------------------------------------------------------------------------
`-update`      | Updates to the latest `panyi.ini` in this repository. Your old copy will be backed up.
`-file [path]` | Optional path to `resource.db`. If unspecified, panfanyi will use the registry to find `resource.db`.
`-lang [lang]` | Optional language from `panyi.ini` that you want to translate to. Defaults to `en`.
`-x`           | Extracts the current string table in `StringTable.xml` to your `panyi.ini` under the `cn` section.

### Acknowledgements

Project          | Version | Copyright                                 | License
---------------- | ------- | ------------------------------------------| ----------------------------
[**OpenMcdf**]   | 2.1     | Copyright © 2010-2018, Federico Blaseotto | [MPL-2.0][openmcdf-license]

[pan]: https://pan.baidu.com/
[**OpenMcdf**]: https://github.com/ironfede/openmcdf
[openmcdf-license]: https://github.com/ironfede/openmcdf/blob/master/License.txt
