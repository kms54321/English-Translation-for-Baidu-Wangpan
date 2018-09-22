## panyi

Translate [Baidu Wangpan] (Netdisk) for Windows to other languages.

### How to use

If you simply want to translate Baidu Netdisk to English, just download and run
`panyi.exe`. 

Otherwise, refer to the **Arguments** section below.

### How it works

Baidu Netdisk reads its strings from
`%AppData%\baidu\BaiduNetdisk\resource.db:StringTable.xml`, a Compound File
Binary Format stream.

panyi simply replaces these strings with their translated counterparts from
`panyi.ini`.

### Arguments

Argument       | Description
-------------- | --------------------------------------------------------------------------------------------------
`-update`      | Downloads the latest `panyi.ini` from this repository. Your old copy will be backed up.
`-file [path]` | Optional path to `resource.db`. If unspecified, panyi will use the registry to find `resource.db`.
`-lang [lang]` | Optional language from `panyi.ini` that you want to translate to. Defaults to `en`.
`-x`           | Extracts `StringTable.xml` strings to your `panyi.ini`'s `cn` section.

### Contributing

Pull requests with translation improvements or new languages are welcome!

Just fork this repository and commit your changes to `panyi.ini`, then submit a
pull request.

### Acknowledgements

Project          | Version | Copyright                                 | License
---------------- | ------- | ----------------------------------------- | ---------------------------
[**OpenMcdf**]   | 2.1     | Copyright © 2010-2018, Federico Blaseotto | [MPL-2.0][openmcdf-license]

[Baidu Wangpan]: https://pan.baidu.com/
[**OpenMcdf**]: https://github.com/ironfede/openmcdf
[openmcdf-license]: https://github.com/ironfede/openmcdf/blob/master/License.txt
