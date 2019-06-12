# Git commands

Goal of this workshop is to be able understand what happens under the hood after typical git commands. 

Follow the commands in [Tasks document](./tasks.md).

## Comparison of Diff tools

* This table was relevant in october 2018
* *Y* - Means YES
* Paths - Number of Windows the tool uses to visualize the diff
    * 1 - source revision with target revision below in one window
	* 2 - source revision and target revision side by side
    * 3 - source revision and target revision side by side with final result or base revision below in third window
    * 4 - source, target, base revisions and result windows

| Merge tool          | Last release | Paths | Navigate to conflict | Git build-in | Syntax highlighting |
| -----------------   | ------------ | ----- | -------------------- | ------------ | ------------------- |
| TortoiseGitMerge    | 2018/2       | 3     | Y                    |              |                     |
| p4merge             | 2018/2       | 4     | Y                    | Y            |                     |
| Winmerge            | 2016/2       | 2     |                      | Y            | Y                   |
| kdiff3              | 2014/7       | 4     | Y                    | Y            |                     |
| Sourcegear difmerge | 2013/10      | 3     | Y                    |              |                     |
| Visual studio Code  | 2018/7       | 1     |                      |              | Y                   |
| Visual studio 2017  | 2018/7       | 3     | Y                    |              | Y                   |
| Compare IT!         | ?            | 2     |                      |              |                     |

## Diff tools

* [Windiff](https://www.grigsoft.com/download-windiff.htm)
* [Tortiosegit](https://tortoisegit.org/download/)
* [p4merge](https://www.perforce.com/downloads/visual-merge-tool)
* [WinMerge](http://winmerge.org/)
* [Kdiff3](http://kdiff3.sourceforge.net/)
* [diffmerge](http://www.sourcegear.com/diffmerge/)
* [Compare IT!](https://www.grigsoft.com/wincmp3.htm)

## Recommended tools

* [posh-git](https://github.com/dahlbyk/posh-git)
* [Notepad++](https://notepad-plus-plus.org/)

## Other links

* https://learningitbranching.js.org
* [Diff tools Configuration for TFVC](https://github.com/deadlydog/VS.DiffAllFiles/wiki/Common-Diff-Tool-Configurations-For-TFVC
)
* Use `git mergetool --tool-help`
