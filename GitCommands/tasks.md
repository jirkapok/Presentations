## Tasks

* Use powershell to execute following commands
* after each git command use `git log --oneline --decorate` and `git status`, to ensure, what is the current state.
* `git clean` is called because merge tool may create backup files, so we need to remove them from disk.
* notepad++ or eny other tool can be used  instead of KDiff3

> **NOTE:** Keep in mind to execute them from correct directory!

## Create infrastructure

```powershell
md C:\GitTests\server
md C:\GitTests\clientA
md C:\GitTests\clientB
```

## server - Initialize server

```powershell
git init --bare
```

## clientA - Initialize repository from clientA

```powershell
git init
git commit --allow-empty -am "First commit"
git remote add origin '\\localhost\c$\GitTests\server\'
git remote --v
git push --set-upstream origin master
git log --oneline --decorate
```

## clientA - setup clientA

```powershell
get-content .git\config
git config -l # list options
git config --add core.editor "'C:/Program Files/Notepad++/notepad++.exe' -multiInst -notabbar -nosession -noPlugin"
git config --edit
# add lines:
[user]
	name = Jiri Pokorny
	email = jirka@wug.cz
[credential]
	helper = manager
[merge]
	tool = kdiff3
[mergetool "kdiff3"]
	path = C:/Program Files/KDiff3/kdiff3.exe
	trustExitCode = false
[diff]
	guitool = kdiff3
[difftool "kdiff3"]
	path = C:/Program Files/KDiff3/kdiff3.exe
	trustExitCode = false
[difftool]
	prompt = false
[mergetool]
	keepBackup = false
```

## clientA - create git ignore file

```powershell
echo "" >> .gitignore
git add .\.gitignore
git commit -am "added gitignore"
git push
```

## clientA - Create commit

```powershell
echo "first" >> readme.md
git add .
git status --short
git commit -m "first wrong"
git log --oneline --decorate
git commit --amend
git push
```

## clientB - initialize second client from clientB

```powershell
git clone \\localhost\c$\GitTests\server .
echo "two" >> readme.md
git commit -am "two"
git push
```

## clientA - download changes

```powershell
git fetch -p
git log --decorate --oneline --all
```

## clientA - create branch

```powershell
git checkout -b featureA
git branch
git branch -vv
echo "three" >> .\readme.md
git commit -am "three"
git log --decorate --graph --oneline --all
```

## clientA - merge from masteru

```powershell
git fetch origin master:master
git merge master
git mergetool .\readme.md
git clean -xdf
git commit -m "merge from master"
git log --decorate --graph --oneline --all
git push --set-upstream origin featureA
```

## clientB - download changes using merge

```powershell
git checkout -b featureA
echo "four" >> .\readme.md
git commit -am "four"
git log --decorate --graph --oneline --all
git branch -r
git branch -u origin/featureA featureA
git pull
git mergetool .\readme.md
git clean -xdf
git commit -m "merge from clientA"
```

## clientB - rollback last commit

```powershell
git reset head~
git checkout .
```

## clientB - download changes using rebase

```powershell
git pull --rebase
git mergetool .\readme.md
git clean -xdf
git status
git rebase --continue
git log --decorate --graph --oneline --all
```

## clientB - work with stash

```powershell
git stash help
echo "five" >> .\readme.md
git stash
git stash show 'stash@{0}'
git stash apply 'stash@{0}'
git stash drop 'stash@{0}'
```

## clientB - tags

```powershell
git tag -a v1.0 -m "version 1.0" head~3
git push --tags
```

## clientA - download and remove tag

```powershell
git fetch
git tag -d v1.0
git push -d origin v1.0
```

## other interesting tasks

* interactive rebase to fix commit
* remove/rename branch
* i did a commit, but forgot to create branch (detached head)
